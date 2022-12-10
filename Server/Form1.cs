using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnZaustavi.Enabled = false;
        }

        private void btnStartuj_Click(object sender, EventArgs e)
        {
            bool signal = ServerPokretanje.Instance.Startuj();
            if (signal)
            {
                MessageBox.Show("Uspesno pokrenut server");
                btnStartuj.Enabled = false;
                btnZaustavi.Enabled = true;
            }
            else
            {
                MessageBox.Show("Neuspesno pokrenut server");
                btnStartuj.Enabled = true;
                btnZaustavi.Enabled = false;

            }
        }

        private void btnZaustavi_Click(object sender, EventArgs e)
        {
            bool signal = ServerPokretanje.Instance.Zaustavi();
            if (signal)
            {
                MessageBox.Show("Uspesno zaustavljen server");
                btnStartuj.Enabled = true;
                btnZaustavi.Enabled = false;
            }
            else
            {
                MessageBox.Show("Neuspesno zaustavljen server");
                btnStartuj.Enabled = false;
                btnZaustavi.Enabled = true;

            }
        }
    }
}
