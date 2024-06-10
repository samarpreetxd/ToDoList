namespace todolisthaha
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Descrizione = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbFiltraCategoria = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbFiltraStato = new System.Windows.Forms.ComboBox();
            this.azioneAggiungi = new System.Windows.Forms.Button();
            this.azioneFiltra = new System.Windows.Forms.Button();
            this.azioneAnnullaFiltro = new System.Windows.Forms.Button();
            this.btnEliminaMansioniSvolte = new System.Windows.Forms.Button();
            this.btnRipristina = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(-31, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2026, 102);
            this.label1.TabIndex = 0;
            this.label1.Text = "To Do List";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descrizione,
            this.Categoria,
            this.Data,
            this.Stato});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.Location = new System.Drawing.Point(446, 340);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1104, 417);
            this.dataGridView1.TabIndex = 9;
            // 
            // Descrizione
            // 
            this.Descrizione.HeaderText = "Descrizione";
            this.Descrizione.MinimumWidth = 8;
            this.Descrizione.Name = "Descrizione";
            this.Descrizione.ReadOnly = true;
            this.Descrizione.Width = 200;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.MinimumWidth = 8;
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            this.Categoria.Width = 170;
            // 
            // Data
            // 
            this.Data.HeaderText = "Data";
            this.Data.MinimumWidth = 8;
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.Width = 170;
            // 
            // Stato
            // 
            this.Stato.HeaderText = "Stato";
            this.Stato.MinimumWidth = 8;
            this.Stato.Name = "Stato";
            this.Stato.ReadOnly = true;
            this.Stato.Width = 150;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(145, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 14);
            this.label6.TabIndex = 10;
            this.label6.Text = "Categoria";
            // 
            // cmbFiltraCategoria
            // 
            this.cmbFiltraCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltraCategoria.FormattingEnabled = true;
            this.cmbFiltraCategoria.Location = new System.Drawing.Point(145, 407);
            this.cmbFiltraCategoria.Name = "cmbFiltraCategoria";
            this.cmbFiltraCategoria.Size = new System.Drawing.Size(221, 21);
            this.cmbFiltraCategoria.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(142, 481);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 35);
            this.label7.TabIndex = 12;
            this.label7.Text = "Stato";
            // 
            // cmbFiltraStato
            // 
            this.cmbFiltraStato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltraStato.FormattingEnabled = true;
            this.cmbFiltraStato.Location = new System.Drawing.Point(145, 551);
            this.cmbFiltraStato.Name = "cmbFiltraStato";
            this.cmbFiltraStato.Size = new System.Drawing.Size(221, 21);
            this.cmbFiltraStato.TabIndex = 13;
            // 
            // azioneAggiungi
            // 
            this.azioneAggiungi.BackColor = System.Drawing.Color.SteelBlue;
            this.azioneAggiungi.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.azioneAggiungi.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.azioneAggiungi.Location = new System.Drawing.Point(1610, 340);
            this.azioneAggiungi.Name = "azioneAggiungi";
            this.azioneAggiungi.Size = new System.Drawing.Size(175, 61);
            this.azioneAggiungi.TabIndex = 14;
            this.azioneAggiungi.Text = "Aggiungi";
            this.azioneAggiungi.UseVisualStyleBackColor = false;
            this.azioneAggiungi.Click += new System.EventHandler(this.azioneAggiungi_Click);
            // 
            // azioneFiltra
            // 
            this.azioneFiltra.BackColor = System.Drawing.Color.SteelBlue;
            this.azioneFiltra.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.azioneFiltra.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.azioneFiltra.Location = new System.Drawing.Point(144, 629);
            this.azioneFiltra.Name = "azioneFiltra";
            this.azioneFiltra.Size = new System.Drawing.Size(102, 58);
            this.azioneFiltra.TabIndex = 15;
            this.azioneFiltra.Text = "Filtra";
            this.azioneFiltra.UseVisualStyleBackColor = false;
            this.azioneFiltra.Click += new System.EventHandler(this.azioneFiltra_Click);
            // 
            // azioneAnnullaFiltro
            // 
            this.azioneAnnullaFiltro.BackColor = System.Drawing.Color.SteelBlue;
            this.azioneAnnullaFiltro.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.azioneAnnullaFiltro.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.azioneAnnullaFiltro.Location = new System.Drawing.Point(268, 628);
            this.azioneAnnullaFiltro.Name = "azioneAnnullaFiltro";
            this.azioneAnnullaFiltro.Size = new System.Drawing.Size(98, 59);
            this.azioneAnnullaFiltro.TabIndex = 16;
            this.azioneAnnullaFiltro.Text = "Annulla";
            this.azioneAnnullaFiltro.UseVisualStyleBackColor = false;
            this.azioneAnnullaFiltro.Click += new System.EventHandler(this.azioneAnnullaFiltro_Click);
            // 
            // btnEliminaMansioniSvolte
            // 
            this.btnEliminaMansioniSvolte.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEliminaMansioniSvolte.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminaMansioniSvolte.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnEliminaMansioniSvolte.Location = new System.Drawing.Point(144, 712);
            this.btnEliminaMansioniSvolte.Name = "btnEliminaMansioniSvolte";
            this.btnEliminaMansioniSvolte.Size = new System.Drawing.Size(222, 73);
            this.btnEliminaMansioniSvolte.TabIndex = 17;
            this.btnEliminaMansioniSvolte.Text = "Elimina le mansioni svolte";
            this.btnEliminaMansioniSvolte.UseVisualStyleBackColor = false;
            this.btnEliminaMansioniSvolte.Click += new System.EventHandler(this.btnEliminaMansioniSvolte_Click);
            // 
            // btnRipristina
            // 
            this.btnRipristina.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRipristina.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRipristina.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnRipristina.Location = new System.Drawing.Point(1610, 455);
            this.btnRipristina.Name = "btnRipristina";
            this.btnRipristina.Size = new System.Drawing.Size(175, 61);
            this.btnRipristina.TabIndex = 18;
            this.btnRipristina.Text = "Ripristina";
            this.btnRipristina.UseVisualStyleBackColor = false;
            this.btnRipristina.Click += new System.EventHandler(this.btnRipristina_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1867, 888);
            this.Controls.Add(this.btnRipristina);
            this.Controls.Add(this.btnEliminaMansioniSvolte);
            this.Controls.Add(this.azioneAnnullaFiltro);
            this.Controls.Add(this.azioneFiltra);
            this.Controls.Add(this.azioneAggiungi);
            this.Controls.Add(this.cmbFiltraStato);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbFiltraCategoria);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbFiltraCategoria;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbFiltraStato;
        private System.Windows.Forms.Button azioneAggiungi;
        private System.Windows.Forms.Button azioneFiltra;
        private System.Windows.Forms.Button azioneAnnullaFiltro;
        private System.Windows.Forms.Button btnEliminaMansioniSvolte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descrizione;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stato;
        private System.Windows.Forms.Button btnRipristina;
    }
}

