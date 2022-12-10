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
using Podaci.Transfer;

namespace Klijent.Ekranske_forme
{
    public partial class PretragaStomatologaEF : Form
    {
        
        public PretragaStomatologaEF()
        {
            InitializeComponent();
        }

        private void PretragaStomatologaEF_Load(object sender, EventArgs e)
        {
            KontrolerPretragaStomatologa.Instance.Inicijalno(dataGridView1);
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            KontrolerPretragaStomatologa.Instance.Pretrazi(dataGridView1,txtNaziv);
        }

        private void btnPocetno_Click(object sender, EventArgs e)
        {
            KontrolerPretragaStomatologa.Instance.Inicijalno(dataGridView1);
        }
    }
}
