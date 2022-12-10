using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent.Ekranske_forme
{
    public partial class PacijentMeni : Form
    {
        public PacijentMeni()
        {
            InitializeComponent();
            
        }

        private void zakazivanjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PretragaTerminaEF ef = new PretragaTerminaEF();
            ef.ShowDialog();
        }

        private void pretragaSlobodnihToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PretragaTerminaEF ef = new PretragaTerminaEF();
            ef.ShowDialog();
        }

        private void otkazivanjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PretragaTerminaEF ef = new PretragaTerminaEF();
            ef.ShowDialog();
        }

        private void pretragaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PretragaStomatologaEF ef = new PretragaStomatologaEF();
            ef.ShowDialog();
        }

        private void unosRacun2ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            UnosRacunaEF ef = new UnosRacunaEF();
            ef.ShowDialog();
        }

        private void unosUsluge2ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            UnosUslugeEF ef = new UnosUslugeEF();
            ef.ShowDialog();
        }
    }
}
