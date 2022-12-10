
namespace Klijent.Ekranske_forme
{
    partial class PretragaTerminaEF
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnPocetno = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.btnZakazi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbStomatolog = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(273, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(515, 232);
            this.dataGridView1.TabIndex = 59;
            // 
            // btnPocetno
            // 
            this.btnPocetno.Location = new System.Drawing.Point(9, 107);
            this.btnPocetno.Name = "btnPocetno";
            this.btnPocetno.Size = new System.Drawing.Size(107, 41);
            this.btnPocetno.TabIndex = 58;
            this.btnPocetno.Text = "Vrati pocetno";
            this.btnPocetno.UseVisualStyleBackColor = true;
            this.btnPocetno.Click += new System.EventHandler(this.btnPocetno_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "Molim vas unesite neki tekst..";
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(160, 107);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(107, 41);
            this.btnPretrazi.TabIndex = 56;
            this.btnPretrazi.Text = "Pretrazi";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(9, 32);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(258, 20);
            this.txtNaziv.TabIndex = 55;
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Location = new System.Drawing.Point(160, 163);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(107, 41);
            this.btnOtkazi.TabIndex = 60;
            this.btnOtkazi.Text = "Otkazi termin";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // btnZakazi
            // 
            this.btnZakazi.Location = new System.Drawing.Point(9, 163);
            this.btnZakazi.Name = "btnZakazi";
            this.btnZakazi.Size = new System.Drawing.Size(107, 41);
            this.btnZakazi.TabIndex = 61;
            this.btnZakazi.Text = "ZakaziTermin";
            this.btnZakazi.UseVisualStyleBackColor = true;
            this.btnZakazi.Click += new System.EventHandler(this.btnZakazi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = "Stomatolog:";
            // 
            // cmbStomatolog
            // 
            this.cmbStomatolog.FormattingEnabled = true;
            this.cmbStomatolog.Location = new System.Drawing.Point(6, 75);
            this.cmbStomatolog.Name = "cmbStomatolog";
            this.cmbStomatolog.Size = new System.Drawing.Size(261, 21);
            this.cmbStomatolog.TabIndex = 62;
            // 
            // PretragaTerminaEF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 281);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbStomatolog);
            this.Controls.Add(this.btnZakazi);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnPocetno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.txtNaziv);
            this.Name = "PretragaTerminaEF";
            this.Text = "PretragaTerminaEF";
            this.Load += new System.EventHandler(this.PretragaTerminaEF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPocetno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.Button btnZakazi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbStomatolog;
    }
}