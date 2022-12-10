using Klijent.Kontroleri;
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
    public partial class UnosUslugeEF : Form
    {
        public UnosUslugeEF()
        {
            InitializeComponent();
        }

        private void UnosUslugeEF_Load(object sender, EventArgs e)
        {
            KontrolerUnosUsluge.Instance.Inicijalno();
        }

        private void btnSacuvaj_Click_1(object sender, EventArgs e)
        {
            KontrolerUnosUsluge.Instance.Sacuvaj(txtBNaziv, txtBOpis);
        }
    }
}
