
namespace Klijent.Ekranske_forme
{
    partial class UnosUslugeEF
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
            this.naziv = new System.Windows.Forms.Label();
            this.txtBNaziv = new System.Windows.Forms.TextBox();
            this.opis = new System.Windows.Forms.Label();
            this.txtBOpis = new System.Windows.Forms.TextBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // naziv
            // 
            this.naziv.AutoSize = true;
            this.naziv.Location = new System.Drawing.Point(13, 13);
            this.naziv.Name = "naziv";
            this.naziv.Size = new System.Drawing.Size(34, 13);
            this.naziv.TabIndex = 0;
            this.naziv.Text = "Naziv";
            // 
            // txtBNaziv
            // 
            this.txtBNaziv.Location = new System.Drawing.Point(13, 30);
            this.txtBNaziv.Name = "txtBNaziv";
            this.txtBNaziv.Size = new System.Drawing.Size(100, 20);
            this.txtBNaziv.TabIndex = 1;
            // 
            // opis
            // 
            this.opis.AutoSize = true;
            this.opis.Location = new System.Drawing.Point(13, 57);
            this.opis.Name = "opis";
            this.opis.Size = new System.Drawing.Size(28, 13);
            this.opis.TabIndex = 2;
            this.opis.Text = "Opis";
            // 
            // txtBOpis
            // 
            this.txtBOpis.Location = new System.Drawing.Point(13, 74);
            this.txtBOpis.Name = "txtBOpis";
            this.txtBOpis.Size = new System.Drawing.Size(100, 20);
            this.txtBOpis.TabIndex = 3;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(13, 101);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(75, 23);
            this.btnSacuvaj.TabIndex = 4;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click_1);
            // 
            // UnosUslugeEF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.txtBOpis);
            this.Controls.Add(this.opis);
            this.Controls.Add(this.txtBNaziv);
            this.Controls.Add(this.naziv);
            this.Name = "UnosUslugeEF";
            this.Text = "UnosUslugeEF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label naziv;
        private System.Windows.Forms.TextBox txtBNaziv;
        private System.Windows.Forms.Label opis;
        private System.Windows.Forms.TextBox txtBOpis;
        private System.Windows.Forms.Button btnSacuvaj;
    }
}