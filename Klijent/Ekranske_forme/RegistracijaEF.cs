using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Klijent.Kontroleri;
using Podaci.Domen;
using Podaci.Storage;
using Podaci.Transfer;

namespace Klijent.Ekranske_forme
{
    public partial class RegistracijaEF : Form
    {
        public RegistracijaEF()
        {
            InitializeComponent();
        }

        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            KontrolerRegistracija.Instance.Registracija(txtIme, txtPrezime, txtKorisnicko, txtLozinka);
        }
    }
}
