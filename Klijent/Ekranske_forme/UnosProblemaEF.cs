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
    public partial class UnosProblemaEF : Form
    {
        
        public UnosProblemaEF()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            KontrolerUnosProblema.Instance.Dodaj(txtNaziv,txtOpis, txtDatumDijagnoze,cmbPacijent,dataGridView1);
        }
        private void UnosProblemaEF_Load(object sender, EventArgs e)
        {
            KontrolerUnosProblema.Instance.Inicijalno(dataGridView1, cmbPacijent);
        }

        private void btnSkloni_Click(object sender, EventArgs e)
        {
            KontrolerUnosProblema.Instance.Skloni(dataGridView1);
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            KontrolerUnosProblema.Instance.Sacuvaj();
            
        }
    }
}
