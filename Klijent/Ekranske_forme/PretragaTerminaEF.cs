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
    public partial class PretragaTerminaEF : Form
    {
        public PretragaTerminaEF()
        {
            InitializeComponent();
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            KontrolerPretragaTermina.Instance.Pretrazi(dataGridView1, txtNaziv, cmbStomatolog);
            
        }

        private void PretragaTerminaEF_Load(object sender, EventArgs e)
        {
            KontrolerPretragaTermina.Instance.Inicijalno(dataGridView1, cmbStomatolog, btnOtkazi, btnZakazi);
        }

        private void btnPocetno_Click(object sender, EventArgs e)
        {
            KontrolerPretragaTermina.Instance.Inicijalno(dataGridView1, cmbStomatolog, btnOtkazi, btnZakazi);
        }

        private void btnZakazi_Click(object sender, EventArgs e)
        {
            KontrolerPretragaTermina.Instance.Zakazi(dataGridView1, cmbStomatolog, btnOtkazi, btnZakazi);
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            KontrolerPretragaTermina.Instance.Otkazi(dataGridView1, cmbStomatolog, btnOtkazi, btnZakazi);
        }
        
    }
}
