namespace todolisthaha
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.cmbStato = new System.Windows.Forms.ComboBox();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.txtDescrizione = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.azioneAggiungi = new System.Windows.Forms.Button();
            this.azioneAnnullaAggiunta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbStato
            // 
            this.cmbStato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStato.FormattingEnabled = true;
            this.cmbStato.Location = new System.Drawing.Point(360, 289);
            this.cmbStato.Name = "cmbStato";
            this.cmbStato.Size = new System.Drawing.Size(168, 21);
            this.cmbStato.TabIndex = 17;
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(77, 290);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(221, 20);
            this.dateTime.TabIndex = 16;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(360, 189);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(187, 21);
            this.cmbCategoria.TabIndex = 15;
            // 
            // txtDescrizione
            // 
            this.txtDescrizione.Location = new System.Drawing.Point(77, 189);
            this.txtDescrizione.Name = "txtDescrizione";
            this.txtDescrizione.Size = new System.Drawing.Size(221, 20);
            this.txtDescrizione.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(357, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 35);
            this.label5.TabIndex = 13;
            this.label5.Text = "Stato";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(74, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 14);
            this.label4.TabIndex = 12;
            this.label4.Text = "Data";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(357, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 35);
            this.label3.TabIndex = 11;
            this.label3.Text = "Categoria";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 35);
            this.label2.TabIndex = 10;
            this.label2.Text = "Descrizione";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(-693, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2093, 102);
            this.label1.TabIndex = 9;
            this.label1.Text = "To Do List";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // azioneAggiungi
            // 
            this.azioneAggiungi.BackColor = System.Drawing.Color.SteelBlue;
            this.azioneAggiungi.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.azioneAggiungi.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.azioneAggiungi.Location = new System.Drawing.Point(211, 372);
            this.azioneAggiungi.Name = "azioneAggiungi";
            this.azioneAggiungi.Size = new System.Drawing.Size(87, 44);
            this.azioneAggiungi.TabIndex = 18;
            this.azioneAggiungi.Text = "Aggiungi";
            this.azioneAggiungi.UseVisualStyleBackColor = false;
            this.azioneAggiungi.Click += new System.EventHandler(this.azioneAggiungi_Click);
            // 
            // azioneAnnullaAggiunta
            // 
            this.azioneAnnullaAggiunta.BackColor = System.Drawing.Color.SteelBlue;
            this.azioneAnnullaAggiunta.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.azioneAnnullaAggiunta.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.azioneAnnullaAggiunta.Location = new System.Drawing.Point(360, 372);
            this.azioneAnnullaAggiunta.Name = "azioneAnnullaAggiunta";
            this.azioneAnnullaAggiunta.Size = new System.Drawing.Size(90, 44);
            this.azioneAnnullaAggiunta.TabIndex = 19;
            this.azioneAnnullaAggiunta.Text = "Annulla";
            this.azioneAnnullaAggiunta.UseVisualStyleBackColor = false;
            this.azioneAnnullaAggiunta.Click += new System.EventHandler(this.azioneAnnullaAggiunta_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 484);
            this.Controls.Add(this.azioneAnnullaAggiunta);
            this.Controls.Add(this.azioneAggiungi);
            this.Controls.Add(this.cmbStato);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.txtDescrizione);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ComboBox cmbStato;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.TextBox txtDescrizione;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button azioneAggiungi;
        private System.Windows.Forms.Button azioneAnnullaAggiunta;
    }
}
