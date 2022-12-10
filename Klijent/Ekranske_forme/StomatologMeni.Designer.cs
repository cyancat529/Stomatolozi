
namespace Klijent.Ekranske_forme
{
    partial class StomatologMeni
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
            this.pacijentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosDijagnozaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledZakazanihToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacijentiToolStripMenuItem,
            this.terminToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(344, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pacijentiToolStripMenuItem
            // 
            this.pacijentiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosDijagnozaToolStripMenuItem});
            this.pacijentiToolStripMenuItem.Name = "pacijentiToolStripMenuItem";
            this.pacijentiToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.pacijentiToolStripMenuItem.Text = "Pacijenti";
            // 
            // unosDijagnozaToolStripMenuItem
            // 
            this.unosDijagnozaToolStripMenuItem.Name = "unosDijagnozaToolStripMenuItem";
            this.unosDijagnozaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.unosDijagnozaToolStripMenuItem.Text = "Unos dijagnoza";
            this.unosDijagnozaToolStripMenuItem.Click += new System.EventHandler(this.unosDijagnozaToolStripMenuItem_Click);
            // 
            // terminToolStripMenuItem
            // 
            this.terminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledZakazanihToolStripMenuItem});
            this.terminToolStripMenuItem.Name = "terminToolStripMenuItem";
            this.terminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.terminToolStripMenuItem.Text = "Termin";
            // 
            // pregledZakazanihToolStripMenuItem
            // 
            this.pregledZakazanihToolStripMenuItem.Name = "pregledZakazanihToolStripMenuItem";
            this.pregledZakazanihToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pregledZakazanihToolStripMenuItem.Text = "Pregled zakazanih";
            this.pregledZakazanihToolStripMenuItem.Click += new System.EventHandler(this.pregledZakazanihToolStripMenuItem_Click);
            // 
            // StomatologMeni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 128);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StomatologMeni";
            this.Text = "StomatologMeni";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pacijentiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosDijagnozaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledZakazanihToolStripMenuItem;
    }
}