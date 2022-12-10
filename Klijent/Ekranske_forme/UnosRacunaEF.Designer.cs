
namespace Klijent.Ekranske_forme
{
    partial class UnosRacunaEF
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
            this.DatumRacuna = new System.Windows.Forms.Label();
            this.Iznos = new System.Windows.Forms.Label();
            this.txtBIznos = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.Label();
            this.txtBIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.Label();
            this.txtBPrezime = new System.Windows.Forms.TextBox();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DatumRacuna
            // 
            this.DatumRacuna.AutoSize = true;
            this.DatumRacuna.Location = new System.Drawing.Point(13, 13);
            this.DatumRacuna.Name = "DatumRacuna";
            this.DatumRacuna.Size = new System.Drawing.Size(38, 13);
            this.DatumRacuna.TabIndex = 0;
            this.DatumRacuna.Text = "Datum";
            // 
            // Iznos
            // 
            this.Iznos.AutoSize = true;
            this.Iznos.Location = new System.Drawing.Point(13, 57);
            this.Iznos.Name = "Iznos";
            this.Iznos.Size = new System.Drawing.Size(32, 13);
            this.Iznos.TabIndex = 2;
            this.Iznos.Text = "Iznos";
            // 
            // txtBIznos
            // 
            this.txtBIznos.Location = new System.Drawing.Point(13, 74);
            this.txtBIznos.Name = "txtBIznos";
            this.txtBIznos.Size = new System.Drawing.Size(100, 20);
            this.txtBIznos.TabIndex = 3;
            // 
            // txtIme
            // 
            this.txtIme.AutoSize = true;
            this.txtIme.Location = new System.Drawing.Point(13, 101);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(24, 13);
            this.txtIme.TabIndex = 4;
            this.txtIme.Text = "Ime";
            // 
            // txtBIme
            // 
            this.txtBIme.Location = new System.Drawing.Point(13, 118);
            this.txtBIme.Name = "txtBIme";
            this.txtBIme.Size = new System.Drawing.Size(100, 20);
            this.txtBIme.TabIndex = 5;
            // 
            // txtPrezime
            // 
            this.txtPrezime.AutoSize = true;
            this.txtPrezime.Location = new System.Drawing.Point(13, 145);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(44, 13);
            this.txtPrezime.TabIndex = 6;
            this.txtPrezime.Text = "Prezime";
            // 
            // txtBPrezime
            // 
            this.txtBPrezime.Location = new System.Drawing.Point(13, 162);
            this.txtBPrezime.Name = "txtBPrezime";
            this.txtBPrezime.Size = new System.Drawing.Size(100, 20);
            this.txtBPrezime.TabIndex = 7;
            // 
            // txtDatum
            // 
            this.txtDatum.Location = new System.Drawing.Point(13, 30);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(100, 20);
            this.txtDatum.TabIndex = 8;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(13, 198);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(75, 23);
            this.btnSacuvaj.TabIndex = 9;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // UnosRacunaEF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.txtBPrezime);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtBIme);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.txtBIznos);
            this.Controls.Add(this.Iznos);
            this.Controls.Add(this.DatumRacuna);
            this.Name = "UnosRacunaEF";
            this.Text = "UnosRacunaEF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DatumRacuna;
        private System.Windows.Forms.Label Iznos;
        private System.Windows.Forms.TextBox txtBIznos;
        private System.Windows.Forms.Label txtIme;
        private System.Windows.Forms.TextBox txtBIme;
        private System.Windows.Forms.Label txtPrezime;
        private System.Windows.Forms.TextBox txtBPrezime;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.Button btnSacuvaj;
    }
}