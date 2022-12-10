using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Podaci.Domen;
using Podaci.Transfer;

namespace Klijent.Kontroleri
{
    public class KontrolerPretragaStomatologa
    {
        private static KontrolerPretragaStomatologa instance;
        private BindingList<Stomatolog> Lista;
        private KontrolerPretragaStomatologa()
        {

        }

        public static KontrolerPretragaStomatologa Instance
        {
            get
            {
                if (instance == null) instance = new KontrolerPretragaStomatologa();
                return instance;
            }
        }

        public void Inicijalno(DataGridView dataGridView1)
        {
            Odgovor odgovor = Transfer.Transfer.Instance.PosaljiZahtev(SistemskaOperacija.UcitajListuStomatologa, null);
            if (odgovor != null)
            {
                Lista = new BindingList<Stomatolog>((List<Stomatolog>)odgovor.Podaci);
                dataGridView1.DataSource = Lista;
            }
        }

        public void Pretrazi(DataGridView dataGridView1, TextBox txtNaziv)
        {
            if (string.IsNullOrEmpty(txtNaziv.Text))
            {
                MessageBox.Show("NE");
                return;
            }

            KriterijumPretrage kp = new KriterijumPretrage(txtNaziv.Text, null);
            Odgovor odgovor = Transfer.Transfer.Instance.PosaljiZahtev(SistemskaOperacija.NadjiStomatologa, kp);
            if (odgovor != null && odgovor.Uspesno)
            {
                List<Stomatolog> lista = (List<Stomatolog>)odgovor.Podaci;
                if (lista.Count > 0)
                {
                    MessageBox.Show("Sistem je nasao stomatologa po zadatim parametrima!");
                    Lista = new BindingList<Stomatolog>(lista);
                    dataGridView1.DataSource = Lista;
                }
                else
                {
                    MessageBox.Show("Nije pronadjen stomatolog po zadatim parametrima!");
                }
            }
            else
            {
                MessageBox.Show("Nije pronadjen stomatolog po zadatim parametrima!");
            }
        }
    }
}
