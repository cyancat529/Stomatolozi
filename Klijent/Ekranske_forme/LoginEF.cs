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
    public partial class LoginEF : Form
    {
        public LoginEF()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegistracijaEF ef = new RegistracijaEF();
            ef.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            KontrolerLogin.Instance.SacuvajLogin(txtKorisnicko, txtSifra);
        }

        
    }
}
