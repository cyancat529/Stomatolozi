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
    public partial class UnosStomatologaEF : Form
    {
        public UnosStomatologaEF()
        {
            InitializeComponent();
        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            KontrolerUnosStomatologa.Instance.Sacuvaj(txtIme,txtPrezime,txtKorisnicko,txtLozinka,txtBio,cmbGrad);
            
        }

        private void UnosStomatologaEF_Load(object sender, EventArgs e)
        {
            KontrolerUnosStomatologa.Instance.Inicijalno(cmbGrad);
            
        }
    }
}
