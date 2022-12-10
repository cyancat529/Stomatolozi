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
    public partial class StomatologMeni : Form
    {
        public StomatologMeni()
        {
            InitializeComponent();
        }

        private void unosDijagnozaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnosProblemaEF ef = new UnosProblemaEF();
            ef.ShowDialog();
        }

        private void pregledZakazanihToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PretragaTerminaEF().ShowDialog();
        }
    }
}
