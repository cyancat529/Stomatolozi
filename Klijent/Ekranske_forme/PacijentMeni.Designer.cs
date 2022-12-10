
namespace Klijent.Ekranske_forme
{
    partial class PacijentMeni
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
            this.terminiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakazivanjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaSlobodnihToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otkazivanjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stomatologToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosRacun2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosUsluge2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.terminiToolStripMenuItem,
            this.stomatologToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(215, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // terminiToolStripMenuItem
            // 
            this.terminiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zakazivanjeToolStripMenuItem,
            this.pretragaSlobodnihToolStripMenuItem,
            this.otkazivanjeToolStripMenuItem,
            this.unosRacun2ToolStripMenuItem,
            this.unosUsluge2ToolStripMenuItem});
            this.terminiToolStripMenuItem.Name = "terminiToolStripMenuItem";
            this.terminiToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.terminiToolStripMenuItem.Text = "Termini";
            // 
            // zakazivanjeToolStripMenuItem
            // 
            this.zakazivanjeToolStripMenuItem.Name = "zakazivanjeToolStripMenuItem";
            this.zakazivanjeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zakazivanjeToolStripMenuItem.Text = "Zakazivanje ";
            this.zakazivanjeToolStripMenuItem.Click += new System.EventHandler(this.zakazivanjeToolStripMenuItem_Click);
            // 
            // pretragaSlobodnihToolStripMenuItem
            // 
            this.pretragaSlobodnihToolStripMenuItem.Name = "pretragaSlobodnihToolStripMenuItem";
            this.pretragaSlobodnihToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pretragaSlobodnihToolStripMenuItem.Text = "Pretraga slobodnih";
            this.pretragaSlobodnihToolStripMenuItem.Click += new System.EventHandler(this.pretragaSlobodnihToolStripMenuItem_Click);
            // 
            // otkazivanjeToolStripMenuItem
            // 
            this.otkazivanjeToolStripMenuItem.Name = "otkazivanjeToolStripMenuItem";
            this.otkazivanjeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.otkazivanjeToolStripMenuItem.Text = "Otkazivanje";
            this.otkazivanjeToolStripMenuItem.Click += new System.EventHandler(this.otkazivanjeToolStripMenuItem_Click);
            // 
            // stomatologToolStripMenuItem
            // 
            this.stomatologToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaToolStripMenuItem});
            this.stomatologToolStripMenuItem.Name = "stomatologToolStripMenuItem";
            this.stomatologToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.stomatologToolStripMenuItem.Text = "Stomatolog";
            // 
            // pretragaToolStripMenuItem
            // 
            this.pretragaToolStripMenuItem.Name = "pretragaToolStripMenuItem";
            this.pretragaToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.pretragaToolStripMenuItem.Text = "Pretraga";
            this.pretragaToolStripMenuItem.Click += new System.EventHandler(this.pretragaToolStripMenuItem_Click);
            // 
            // unosRacun2ToolStripMenuItem
            // 
            this.unosRacun2ToolStripMenuItem.Name = "unosRacun2ToolStripMenuItem";
            this.unosRacun2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.unosRacun2ToolStripMenuItem.Text = "Racun2";
            this.unosRacun2ToolStripMenuItem.Click += new System.EventHandler(this.unosRacun2ToolStripMenuItem_Click_1);
            // 
            // unosUsluge2ToolStripMenuItem
            // 
            this.unosUsluge2ToolStripMenuItem.Name = "unosUsluge2ToolStripMenuItem";
            this.unosUsluge2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.unosUsluge2ToolStripMenuItem.Text = "Usluge2";
            this.unosUsluge2ToolStripMenuItem.Click += new System.EventHandler(this.unosUsluge2ToolStripMenuItem_Click_1);
            // 
            // PacijentMeni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 85);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PacijentMeni";
            this.Text = "PacijentMeni";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem terminiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakazivanjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaSlobodnihToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otkazivanjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stomatologToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosRacun2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosUsluge2ToolStripMenuItem;
    }
}