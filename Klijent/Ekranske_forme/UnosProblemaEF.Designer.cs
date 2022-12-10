
namespace Klijent.Ekranske_forme
{
    partial class UnosProblemaEF
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
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSkloni = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPacijent = new System.Windows.Forms.ComboBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.btnPretraziDijagnoze = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDatumDijagnoze = new System.Windows.Forms.TextBox();
            this.btnOtkaziDijagnozu = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(823, 236);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(107, 41);
            this.btnSacuvaj.TabIndex = 45;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(288, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(500, 259);
            this.dataGridView1.TabIndex = 44;
            // 
            // btnSkloni
            // 
            this.btnSkloni.Location = new System.Drawing.Point(141, 185);
            this.btnSkloni.Name = "btnSkloni";
            this.btnSkloni.Size = new System.Drawing.Size(62, 41);
            this.btnSkloni.TabIndex = 43;
            this.btnSkloni.Text = "-";
            this.btnSkloni.UseVisualStyleBackColor = true;
            this.btnSkloni.Click += new System.EventHandler(this.btnSkloni_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Naziv dijagnoze:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Pacijent:";
            // 
            // cmbPacijent
            // 
            this.cmbPacijent.FormattingEnabled = true;
            this.cmbPacijent.Location = new System.Drawing.Point(12, 34);
            this.cmbPacijent.Name = "cmbPacijent";
            this.cmbPacijent.Size = new System.Drawing.Size(261, 21);
            this.cmbPacijent.TabIndex = 39;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(209, 184);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(64, 41);
            this.btnDodaj.TabIndex = 37;
            this.btnDodaj.Text = "+";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(12, 119);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(261, 20);
            this.txtNaziv.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Opis dijagnoze:";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(12, 158);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(261, 20);
            this.txtOpis.TabIndex = 46;
            // 
            // btnPretraziDijagnoze
            // 
            this.btnPretraziDijagnoze.Location = new System.Drawing.Point(15, 232);
            this.btnPretraziDijagnoze.Name = "btnPretraziDijagnoze";
            this.btnPretraziDijagnoze.Size = new System.Drawing.Size(120, 39);
            this.btnPretraziDijagnoze.TabIndex = 48;
            this.btnPretraziDijagnoze.Text = "Pretrazi";
            this.btnPretraziDijagnoze.UseVisualStyleBackColor = true;
            this.btnPretraziDijagnoze.Click += new System.EventHandler(this.btnPretraziDijagnoze_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Datum:";
            // 
            // txtDatumDijagnoze
            // 
            this.txtDatumDijagnoze.Location = new System.Drawing.Point(12, 78);
            this.txtDatumDijagnoze.Name = "txtDatumDijagnoze";
            this.txtDatumDijagnoze.Size = new System.Drawing.Size(261, 20);
            this.txtDatumDijagnoze.TabIndex = 50;
            // 
            // btnOtkaziDijagnozu
            // 
            this.btnOtkaziDijagnozu.Location = new System.Drawing.Point(141, 232);
            this.btnOtkaziDijagnozu.Name = "btnOtkaziDijagnozu";
            this.btnOtkaziDijagnozu.Size = new System.Drawing.Size(132, 39);
            this.btnOtkaziDijagnozu.TabIndex = 51;
            this.btnOtkaziDijagnozu.Text = "Otkaži";
            this.btnOtkaziDijagnozu.UseVisualStyleBackColor = true;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(15, 185);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(120, 39);
            this.btnObrisi.TabIndex = 52;
            this.btnObrisi.Text = "Obriši dijagnozu";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // UnosProblemaEF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 289);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnOtkaziDijagnozu);
            this.Controls.Add(this.txtDatumDijagnoze);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPretraziDijagnoze);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSkloni);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbPacijent);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtNaziv);
            this.Name = "UnosProblemaEF";
            this.Text = "UnosProblemaEF";
            this.Load += new System.EventHandler(this.UnosProblemaEF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSkloni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPacijent;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Button btnPretraziDijagnoze;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDatumDijagnoze;
        private System.Windows.Forms.Button btnOtkaziDijagnozu;
        private System.Windows.Forms.Button btnObrisi;
    }
}