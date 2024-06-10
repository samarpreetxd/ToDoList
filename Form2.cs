using System;
using System.Windows.Forms;

namespace todolisthaha
{
    public partial class Form2 : Form
    {
        private Form1 mainForm;
        private Form1.ToDoList currentItem;
        private int currentIndex;

        public Form2(Form1 form)
        {
            InitializeComponent();
            mainForm = form;
            currentItem = null;
            currentIndex = -1;
            InitializeComboBoxes();
        }

        public Form2(Form1 form, Form1.ToDoList item, int index)
        {
            InitializeComponent();
            mainForm = form;
            currentItem = item;
            currentIndex = index;
            InitializeComboBoxes();
            txtDescrizione.Text = item.Descrizione;
            cmbCategoria.SelectedItem = item.Categoria;
            dateTime.Value = item.Data;
            cmbStato.SelectedItem = item.Stato;
            azioneAggiungi.Text = "Conferma modifica";
        }

        private void InitializeComboBoxes()
        {
            cmbCategoria.Items.AddRange(new string[] { "Lavoro", "Scuola", "Appuntamento" });
            cmbCategoria.SelectedIndex = 0;

            cmbStato.Items.AddRange(new string[] { "Da svolgere", "Svolto" });
            cmbStato.SelectedIndex = 0;
        }

        private void azioneAggiungi_Click(object sender, EventArgs e)
        {
            if (cmbCategoria.SelectedItem == null || cmbStato.SelectedItem == null)
            {
                MessageBox.Show("Per favore, seleziona una categoria e uno stato.");
                return;
            }
            if (currentItem == null)
            {
                currentItem = new Form1.ToDoList();
            }

            currentItem.Descrizione = txtDescrizione.Text;
            currentItem.Categoria = cmbCategoria.SelectedItem.ToString();
            currentItem.Data = dateTime.Value;
            currentItem.Stato = cmbStato.SelectedItem.ToString();
            mainForm.SaveData(currentItem, currentIndex);
            this.Close();
        }

        private void azioneAnnullaAggiunta_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
