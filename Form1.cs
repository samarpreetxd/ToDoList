using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace todolisthaha
{
    public partial class Form1 : Form
    {
        public List<ToDoList> rowDataList = new List<ToDoList>();
        private Form2 form2;
        private Stack<Action> actionStack = new Stack<Action>();

        public class ToDoList
        {
            public int Id { get; set; }
            public string Descrizione { get; set; }
            public string Categoria { get; set; }
            public DateTime Data { get; set; }
            public string Stato { get; set; }
        }

        public class Action
        {
            public string ActionType { get; set; }
            public ToDoList Item { get; set; }
            public ToDoList PreviousItem { get; set; }
            public int Index { get; set; }
            public ToDoList DatabaseItem { get; set; } 
        }

        public Form1()
        {
            InitializeComponent();

            cmbFiltraCategoria.Items.AddRange(new string[] { "Tutti", "Lavoro", "Scuola", "Appuntamento" });
            cmbFiltraCategoria.SelectedIndex = 0;

            cmbFiltraStato.Items.AddRange(new string[] { "Tutti", "Svolto", "Da svolgere" });
            cmbFiltraStato.SelectedIndex = 0;

            if (dataGridView1.Columns["btnDelete"] == null)
            {
                DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
                btnDelete.HeaderText = "Cancella";
                btnDelete.Name = "btnDelete";
                btnDelete.Text = "Cancella";
                btnDelete.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(btnDelete);
            }

            if (dataGridView1.Columns["btnModifica"] == null)
            {
                DataGridViewButtonColumn btnModifica = new DataGridViewButtonColumn();
                btnModifica.HeaderText = "Modifica";
                btnModifica.Name = "btnModifica";
                btnModifica.Text = "Modifica";
                btnModifica.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(btnModifica);
            }
            dataGridView1.CellContentClick += new DataGridViewCellEventHandler(dataGridView1_CellContentClick);
            dataGridView1.CellDoubleClick += new DataGridViewCellEventHandler(dataGridView1_CellDoubleClick);

            LoadData();
        }

        public void LoadData()
        {
            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.ToDoList", conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    rowDataList.Clear();

                    while (reader.Read())
                    {
                        rowDataList.Add(new ToDoList
                        {
                            Id = reader.GetInt32(0),
                            Descrizione = reader.GetString(1),
                            Categoria = reader.GetString(2),
                            Data = reader.GetDateTime(3),
                            Stato = reader.GetString(4)
                        });
                    }
                }

                AggiornaDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nel caricamento dei dati: " + ex.Message);
            }
        }

        public void AggiornaDataGridView()
        {
            dataGridView1.Rows.Clear();

            var sortedList = rowDataList
                .OrderBy(item => item.Stato)
                .ThenBy(item => item.Data)
                .ToList();

            foreach (var rowData in sortedList)
            {
                AggiungiRigaDataGridView(rowData);
            }

            FiltraDataGridView();
        }

        public void AggiungiRigaDataGridView(ToDoList rowData)
        {
            int rowIndex = dataGridView1.Rows.Add(rowData.Descrizione, rowData.Categoria, rowData.Data.ToShortDateString(), rowData.Stato, rowData.Stato == "Svolto");

            if (rowData.Stato == "Da svolgere")
            {
                TimeSpan difference = rowData.Data.Date - DateTime.Now.Date;
                if (difference.TotalDays <= 3)
                    dataGridView1.Rows[rowIndex].DefaultCellStyle.BackColor = Color.LightCoral;
                else if (difference.TotalDays > 3 && difference.TotalDays <= 7)
                    dataGridView1.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Yellow;
                else
                    dataGridView1.Rows[rowIndex].DefaultCellStyle.BackColor = Color.White;
            }
            else if (rowData.Stato == "Svolto")
            {
                dataGridView1.Rows[rowIndex].DefaultCellStyle.BackColor = Color.LightGreen; // Color for completed tasks
            }
        }

        private void btnEliminaMansioniSvolte_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM dbo.ToDoList WHERE Stato = 'Svolto'", conn);
                    cmd.ExecuteNonQuery();
                }

                var completedTasks = rowDataList.Where(item => item.Stato == "Svolto").ToList();
                foreach (var task in completedTasks)
                {
                    actionStack.Push(new Action { ActionType = "Delete", Item = task, DatabaseItem = task });
                }

                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nell'eliminazione delle mansioni svolte: " + ex.Message);
            }
        }

        private void azioneFiltra_Click(object sender, EventArgs e)
        {
            FiltraDataGridView();
        }

        private void azioneAnnullaFiltro_Click(object sender, EventArgs e)
        {
            cmbFiltraCategoria.SelectedIndex = 0;
            cmbFiltraStato.SelectedIndex = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    row.Visible = true;
                }
            }
        }

        private void FiltraDataGridView()
        {
            string selectedCategory = cmbFiltraCategoria.SelectedItem.ToString();
            string selectedStatus = cmbFiltraStato.SelectedItem.ToString();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    bool categoryMatch = selectedCategory == "Tutti" || row.Cells["Categoria"].Value.ToString() == selectedCategory;
                    bool statusMatch = selectedStatus == "Tutti" || row.Cells["Stato"].Value.ToString() == selectedStatus;
                    row.Visible = categoryMatch && statusMatch;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0 || e.RowIndex >= rowDataList.Count)
                return;

            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "btnDelete")
                {
                    int id = rowDataList[e.RowIndex].Id;
                    try
                    {
                        using (SqlConnection conn = GetConnection())
                        {
                            conn.Open();
                            SqlCommand cmd = new SqlCommand("DELETE FROM dbo.ToDoList WHERE Id = @Id", conn);
                            cmd.Parameters.AddWithValue("@Id", id);
                            cmd.ExecuteNonQuery();
                        }
                        actionStack.Push(new Action { ActionType = "Delete", Item = rowDataList[e.RowIndex], DatabaseItem = rowDataList[e.RowIndex], Index = e.RowIndex });
                        rowDataList.RemoveAt(e.RowIndex);
                        AggiornaDataGridView();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Errore nell'eliminazione della mansione: " + ex.Message);
                    }
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "btnModifica")
                {
                    ToDoList item = rowDataList[e.RowIndex];
                    apriForm2(item, e.RowIndex);
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= rowDataList.Count)
                return;
            ToDoList item = rowDataList[e.RowIndex];
            apriForm2(item, e.RowIndex);
        }

        private void apriForm2()
        {
            if (form2 == null || form2.IsDisposed)
            {
                form2 = new Form2(this);
                form2.FormClosed += Form2_FormClosed;
                form2.Show();
            }
            else
            {
                form2.BringToFront();
            }
        }

        private void apriForm2(ToDoList item, int index)
        {
            if (form2 == null || form2.IsDisposed)
            {
                form2 = new Form2(this, item, index);
                form2.FormClosed += Form2_FormClosed;
                form2.Show();
            }
            else
            {
                form2.BringToFront();
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            form2 = null;
        }

        private void azioneAggiungi_Click(object sender, EventArgs e)
        {
            cmbFiltraCategoria.SelectedIndex = 0;
            cmbFiltraStato.SelectedIndex = 0;
            apriForm2();
        }

        public SqlConnection GetConnection()
        {
            string connectionString = @"Server=your_server;Database=your_database;Integrated Security=True;";
            return new SqlConnection(connectionString);
        }

        public void SaveData(ToDoList item, int index = -1)
        {
            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();
                    SqlCommand cmd;
                    ToDoList databaseItem = null;

                    if (item.Id == 0)
                    {
                        cmd = new SqlCommand("INSERT INTO dbo.ToDoList (Descrizione, Categoria, Data, Stato) VALUES (@Descrizione, @Categoria, @Data, @Stato)", conn);
                    }
                    else
                    {
                        cmd = new SqlCommand("SELECT * FROM dbo.ToDoList WHERE Id = @Id", conn);
                        cmd.Parameters.AddWithValue("@Id", item.Id);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                databaseItem = new ToDoList
                                {
                                    Id = reader.GetInt32(0),
                                    Descrizione = reader.GetString(1),
                                    Categoria = reader.GetString(2),
                                    Data = reader.GetDateTime(3),
                                    Stato = reader.GetString(4)
                                };
                            }
                        }

                        cmd = new SqlCommand("UPDATE dbo.ToDoList SET Descrizione = @Descrizione, Categoria = @Categoria, Data = @Data, Stato = @Stato WHERE Id = @Id", conn);
                        cmd.Parameters.AddWithValue("@Id", item.Id);
                    }

                    cmd.Parameters.AddWithValue("@Descrizione", item.Descrizione);
                    cmd.Parameters.AddWithValue("@Categoria", item.Categoria);
                    cmd.Parameters.AddWithValue("@Data", item.Data);
                    cmd.Parameters.AddWithValue("@Stato", item.Stato);
                    cmd.ExecuteNonQuery();

                    if (item.Id == 0)
                    {
                        cmd = new SqlCommand("SELECT TOP 1 Id FROM dbo.ToDoList ORDER BY Id DESC", conn);
                        item.Id = (int)cmd.ExecuteScalar();
                        actionStack.Push(new Action { ActionType = "Add", Item = item });
                    }
                    else
                    {
                        actionStack.Push(new Action { ActionType = "Update", Item = item, PreviousItem = rowDataList.FirstOrDefault(x => x.Id == item.Id), DatabaseItem = databaseItem, Index = index });
                    }
                }

                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nel salvataggio dei dati: " + ex.Message);
            }
        }

        private void btnRipristina_Click(object sender, EventArgs e)
        {
            if (actionStack.Count > 0)
            {
                Action lastAction = actionStack.Pop();
                try
                {
                    using (SqlConnection conn = GetConnection())
                    {
                        conn.Open();
                        SqlCommand cmd;

                        if (lastAction.ActionType == "Add")
                        {
                            cmd = new SqlCommand("DELETE FROM dbo.ToDoList WHERE Id = @Id", conn);
                            cmd.Parameters.AddWithValue("@Id", lastAction.Item.Id);
                            cmd.ExecuteNonQuery();
                        }
                        else if (lastAction.ActionType == "Delete")
                        {
                            cmd = new SqlCommand("SET IDENTITY_INSERT dbo.ToDoList ON", conn);
                            cmd.ExecuteNonQuery();

                            cmd = new SqlCommand("INSERT INTO dbo.ToDoList (Id, Descrizione, Categoria, Data, Stato) VALUES (@Id, @Descrizione, @Categoria, @Data, @Stato)", conn);
                            cmd.Parameters.AddWithValue("@Id", lastAction.DatabaseItem.Id);
                            cmd.Parameters.AddWithValue("@Descrizione", lastAction.DatabaseItem.Descrizione);
                            cmd.Parameters.AddWithValue("@Categoria", lastAction.DatabaseItem.Categoria);
                            cmd.Parameters.AddWithValue("@Data", lastAction.DatabaseItem.Data);
                            cmd.Parameters.AddWithValue("@Stato", lastAction.DatabaseItem.Stato);
                            cmd.ExecuteNonQuery();

                            cmd = new SqlCommand("SET IDENTITY_INSERT dbo.ToDoList OFF", conn);
                            cmd.ExecuteNonQuery();
                        }
                        else if (lastAction.ActionType == "Update")
                        {
                            cmd = new SqlCommand("UPDATE dbo.ToDoList SET Descrizione = @Descrizione, Categoria = @Categoria, Data = @Data, Stato = @Stato WHERE Id = @Id", conn);
                            cmd.Parameters.AddWithValue("@Id", lastAction.DatabaseItem.Id);
                            cmd.Parameters.AddWithValue("@Descrizione", lastAction.DatabaseItem.Descrizione);
                            cmd.Parameters.AddWithValue("@Categoria", lastAction.DatabaseItem.Categoria);
                            cmd.Parameters.AddWithValue("@Data", lastAction.DatabaseItem.Data);
                            cmd.Parameters.AddWithValue("@Stato", lastAction.DatabaseItem.Stato);
                            cmd.ExecuteNonQuery();

                            if (lastAction.Index != -1)
                            {
                                rowDataList[lastAction.Index] = lastAction.DatabaseItem;
                            }
                        }
                    }
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Errore nel ripristino dell'azione: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Nessuna azione da ripristinare.");
            }
        }
    }
}
