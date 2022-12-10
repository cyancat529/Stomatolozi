
namespace Klijent.Ekranske_forme
{
    partial class AdministratorMeni
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.terminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosSlobodnihTerminaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosRacunaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosUslugeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stomatologToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosNovogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.terminToolStripMenuItem,
            this.stomatologToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(220, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // terminToolStripMenuItem
            // 
            this.terminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosSlobodnihTerminaToolStripMenuItem,
            this.unosRacunaToolStripMenuItem,
            this.unosUslugeToolStripMenuItem});
            this.terminToolStripMenuItem.Name = "terminToolStripMenuItem";
            this.terminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.terminToolStripMenuItem.Text = "Termin";
            // 
            // unosSlobodnihTerminaToolStripMenuItem
            // 
            this.unosSlobodnihTerminaToolStripMenuItem.Name = "unosSlobodnihTerminaToolStripMenuItem";
            this.unosSlobodnihTerminaToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.unosSlobodnihTerminaToolStripMenuItem.Text = "Unos slobodnih termina";
            this.unosSlobodnihTerminaToolStripMenuItem.Click += new System.EventHandler(this.unosSlobodnihTerminaToolStripMenuItem_Click);
            // 
            // unosRacunaToolStripMenuItem
            // 
            this.unosRacunaToolStripMenuItem.Name = "unosRacunaToolStripMenuItem";
            this.unosRacunaToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.unosRacunaToolStripMenuItem.Text = "Racun";
            // 
            // unosUslugeToolStripMenuItem
            // 
            this.unosUslugeToolStripMenuItem.Name = "unosUslugeToolStripMenuItem";
            this.unosUslugeToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.unosUslugeToolStripMenuItem.Text = "Usluge";
            // 
            // stomatologToolStripMenuItem
            // 
            this.stomatologToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosNovogToolStripMenuItem,
            this.pretragaToolStripMenuItem});
            this.stomatologToolStripMenuItem.Name = "stomatologToolStripMenuItem";
            this.stomatologToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.stomatologToolStripMenuItem.Text = "Stomatolog";
            // 
            // unosNovogToolStripMenuItem
            // 
            this.unosNovogToolStripMenuItem.Name = "unosNovogToolStripMenuItem";
            this.unosNovogToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.unosNovogToolStripMenuItem.Text = "Unos novog";
            this.unosNovogToolStripMenuItem.Click += new System.EventHandler(this.unosNovogToolStripMenuItem_Click);
            // 
            // pretragaToolStripMenuItem
            // 
            this.pretragaToolStripMenuItem.Name = "pretragaToolStripMenuItem";
            this.pretragaToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.pretragaToolStripMenuItem.Text = "Pretraga";
            this.pretragaToolStripMenuItem.Click += new System.EventHandler(this.pretragaToolStripMenuItem_Click);
            // 
            // AdministratorMeni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 84);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdministratorMeni";
            this.Text = "AdministratorMeni";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem terminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosSlobodnihTerminaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stomatologToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosNovogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosUslugeToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem unosRacunaToolStripMenuItem;
    }
}