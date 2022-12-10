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
    public partial class UnosRacunaEF : Form
    {
        public UnosRacunaEF()
        {
            InitializeComponent();
        }

        private void UnosRacunaEF_Load(object sender, EventArgs e)
        {
            KontrolerUnosRacuna.Instance.Inicijalno();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            KontrolerUnosRacuna.Instance.Sacuvaj( txtDatum, txtBIznos, txtBIme, txtBPrezime);

        }

    }
}
