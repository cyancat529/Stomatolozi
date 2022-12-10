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
    public partial class AdministratorMeni : Form
    {
        public AdministratorMeni()
        {
            InitializeComponent();
        }

        private void unosSlobodnihTerminaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnosTerminaEF ef = new UnosTerminaEF();
            ef.ShowDialog();
        }

        private void unosRacunaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnosRacunaEF ef = new UnosRacunaEF();
            ef.ShowDialog();
        }

        private void unosUslugeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnosUslugeEF ef = new UnosUslugeEF();
            ef.ShowDialog();
        }

        private void unosNovogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnosStomatologaEF ef = new UnosStomatologaEF();
            ef.ShowDialog();
        }

        private void pretragaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PretragaStomatologaEF ef = new PretragaStomatologaEF();
            ef.ShowDialog();
        }
    }
}
