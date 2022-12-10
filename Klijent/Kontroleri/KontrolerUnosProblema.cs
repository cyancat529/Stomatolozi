using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Podaci.Domen;
using Podaci.Storage;
using Podaci.Transfer;

namespace Klijent.Kontroleri
{
    public class KontrolerUnosProblema
    {
        private static KontrolerUnosProblema instance;
        private BindingList<Dijagnoza> lista;
        private KontrolerUnosProblema()
        {

        }

        public static KontrolerUnosProblema Instance
        {
            get
            {
                if (instance == null) instance = new KontrolerUnosProblema();
                return instance;
            }
        }

        public void Inicijalno(DataGridView dataGridView1, ComboBox cmbPacijent)
        {
            Odgovor odgovor = Transfer.Transfer.Instance.PosaljiZahtev(SistemskaOperacija.UcitajListuPacijenata, null);
            if (odgovor != null)
            {
                cmbPacijent.DataSource = (List<Pacijent>)odgovor.Podaci;
            }

            lista = new BindingList<Dijagnoza>();
            dataGridView1.DataSource = lista;
        }

        public void Dodaj(TextBox txtDatumDijagnoze, TextBox txtNaziv, TextBox txtOpis, ComboBox cmbPacijent, DataGridView dataGridView1)
        {
            Dijagnoza dij = FormirajDijagnozu(txtDatumDijagnoze, txtNaziv, txtOpis,cmbPacijent);
            if (dij == null) return;
            lista.Add(dij);
            dataGridView1.DataSource = lista;
        }

        private Dijagnoza FormirajDijagnozu(TextBox txtDatumDijagnoze, TextBox txtNaziv, TextBox txtOpis, ComboBox cmbPacijent)
        {
            if (!DateTime.TryParseExact(txtDatumDijagnoze.Text, "dd/MM/yyyy HH:mm",
                CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime datumDijagnoze))
            {
                MessageBox.Show("Pogresno ste uneli datum. Mora biti u formatu dd/MM/yyyy hh:MM");
                return null;
            }
            if (datumDijagnoze <= DateTime.Now)
            {
                MessageBox.Show("Datum mora biti veci od danasnjeg");
                return null;
            }

            string naziv = txtNaziv.Text;
            string opis = txtOpis.Text;
            if (string.IsNullOrEmpty(naziv) || string.IsNullOrEmpty(opis))
            {
                MessageBox.Show("Niste popunili sva polja!");
                return null;
            }
            Pacijent p = cmbPacijent.SelectedItem as Pacijent;
            if (lista.Count(dij => dij.NazivDijagnoze.ToLower() == naziv.ToLower()) > 0)
            {
                MessageBox.Show("Vec postoji problem sa ovim nazivom!");
                return null;
            }
            if (lista.Count(dij => dij.Pacijent.IdPacijent != p.IdPacijent) > 0)
            {
                MessageBox.Show("Mozete u jednom cuvanju sacuvati dijagnoze za samo jednog pacijenta");
                return null;
            }
            return new Dijagnoza(0, datumDijagnoze, naziv, opis, Storage.Instance.Login as Stomatolog, p);

        }

        public void Skloni(DataGridView dataGridView1)
        {
            try
            {
                Dijagnoza dijagnoza = (Dijagnoza)dataGridView1.SelectedRows[0].DataBoundItem;
                lista.Remove(dijagnoza);
                dataGridView1.DataSource = lista;

            }
            catch (Exception)
            {
                MessageBox.Show("Morate selektovati polaznik");
                return;
            }
        }

        public void Sacuvaj()
        {
            if (lista.Count == 0)
            {
                MessageBox.Show("Unesite makar jednu dijagnozu");
                return;
            }


            Odgovor odgovor =
                Transfer.Transfer.Instance.PosaljiZahtev(SistemskaOperacija.KartonPacijenta, lista.ToList());
            if (odgovor != null && odgovor.Uspesno)
            {
                MessageBox.Show("Uspesno ste uneli probleme pacijenata!");
            }
            else
            {
                MessageBox.Show("Greska pri cuvanju podataka o pacijentu!");
            }
        }

    }
}
