using Klijent.Kontroleri;
using System;
using System.Windows.Forms;

namespace Klijent.Ekranske_forme
{
    public partial class UnosTerminaEF : Form
    {

        public UnosTerminaEF()
        {
            InitializeComponent();
        }

        private void UnosTerminaEF_Load(object sender, EventArgs e)
        {
            KontrolerUnosTermina.Instance.Inicijalno(cmbStatus, cmbStomatolog, dataGridView1);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            KontrolerUnosTermina.Instance.Dodaj(dataGridView1, txtDatum, cmbStomatolog, cmbStatus);
        }


        private void btnSkloni_Click(object sender, EventArgs e)
        {
            KontrolerUnosTermina.Instance.Skloni(dataGridView1);
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            KontrolerUnosTermina.Instance.Sacuvaj(dataGridView1);
        }
    }
}
