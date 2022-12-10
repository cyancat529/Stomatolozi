using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Podaci.Domen;
using Podaci.Transfer;

namespace Klijent.Kontroleri
{
    public class KontrolerUnosTermina
    {
        private static KontrolerUnosTermina instance;
        BindingList<Termin> lista;
        private KontrolerUnosTermina()
        {

        }

        public static KontrolerUnosTermina Instance
        {
            get
            {
                if (instance == null) instance = new KontrolerUnosTermina();
                return instance;
            }
        }

        public void Inicijalno(ComboBox cmbStatus, ComboBox cmbStomatolog, DataGridView dataGridView1)
        {
            List<string> statusi = new List<string>() { "Slobodan"};
            cmbStatus.DataSource = statusi;

            Odgovor odgovor = Transfer.Transfer.Instance.PosaljiZahtev(SistemskaOperacija.UcitajListuStomatologa, null);
            if (odgovor != null)
            {
                cmbStomatolog.DataSource = (List<Stomatolog>)odgovor.Podaci;
            }

            lista = new BindingList<Termin>();
            dataGridView1.DataSource = lista;
        }

        private Termin FormiranjeTermina(TextBox txtDatum, ComboBox cmbStomatolog, ComboBox cmbStatus)
        {
            if (!DateTime.TryParseExact(txtDatum.Text, "dd/MM/yyyy HH:mm",
                CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date))
            {
                MessageBox.Show("Pogresno ste uneli datum. Mora biti u formatu dd/MM/yyyy hh:MM");
                return null;
            }
            if (date <= DateTime.Now)
            {
                MessageBox.Show("Datum mora biti veci od danasnjeg");
                return null;
            }

            Stomatolog stomatolog = cmbStomatolog.SelectedItem as Stomatolog;
            string status = cmbStatus.SelectedItem.ToString();

            Odgovor odgovor = Transfer.Transfer.Instance.PosaljiZahtev(SistemskaOperacija.UcitajListuTermina, null);
            if (odgovor != null)
            {
                var termini = (List<Termin>)odgovor.Podaci;
                if (termini.Count(termin =>
                    termin.Stomatolog.IdStomatolog == stomatolog?.IdStomatolog && termin.Datum == date) > 0)
                {
                    MessageBox.Show($"Vec ste uneli ovaj termin za stomatologa {stomatolog.Ime} {stomatolog.Prezime}");
                    return null;
                }

                if (lista.Count(termin =>
                    termin.Stomatolog.IdStomatolog == stomatolog?.IdStomatolog && termin.Datum == date) > 0)
                {
                    MessageBox.Show($"Vec ste uneli ovaj termin za stomatologa {stomatolog.Ime} {stomatolog.Prezime}");
                    return null;
                }

            }


            return new Termin(0, date, status, null, stomatolog);

        }

        public void Dodaj(DataGridView dataGridView1, TextBox txtDatum, ComboBox cmbStomatolog, ComboBox cmbStatus)
        {
            Termin termin = FormiranjeTermina(txtDatum,cmbStomatolog,cmbStatus);
            if (termin == null) return;
            lista.Add(termin);
            dataGridView1.DataSource = lista;
        }

        public void Skloni(DataGridView dataGridView1)
        {
            try
            {
                Termin termin = (Termin)dataGridView1.SelectedRows[0].DataBoundItem;
                lista.Remove(termin);
                dataGridView1.DataSource = lista;

            }
            catch (Exception)
            {
                MessageBox.Show("Morate selektovati polaznik");
                return;
            }
        }

        public void Sacuvaj(DataGridView dataGridView1)
        {
            if (lista.Count == 0)
            {
                MessageBox.Show("Unesite makar jedan slobodan termin");
                return;
            }

            Odgovor odgovor =
                Transfer.Transfer.Instance.PosaljiZahtev(SistemskaOperacija.SacuvajSlobodneTermine, lista.ToList());
            if (odgovor != null && odgovor.Uspesno)
            {
                MessageBox.Show("Uspesno sacuvani podaci o slobodnim terminima!");
            }
            else
            {
                MessageBox.Show("Greska pri cuvanju slobodnih termina!");
            }
        }
    }
}
