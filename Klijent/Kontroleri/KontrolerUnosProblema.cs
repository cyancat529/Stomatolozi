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
        private BindingList<Dijagnoza> listaTrenutnih;
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
            listaTrenutnih = new BindingList<Dijagnoza>();
            dataGridView1.DataSource = lista;
        }

        public void Dodaj(TextBox txtDatumDijagnoze, TextBox txtNaziv, TextBox txtOpis, ComboBox cmbPacijent, DataGridView dataGridView1)
        {
            Dijagnoza dij = FormirajDijagnozu(txtDatumDijagnoze, txtNaziv, txtOpis,cmbPacijent);
            if (dij == null) return;
            lista.Add(dij);
            listaTrenutnih.Add(dij);
            dataGridView1.DataSource = lista;
        }

        private Dijagnoza FormirajDijagnozu(TextBox txtDatumDijagnoze, TextBox txtNaziv, TextBox txtOpis, ComboBox cmbPacijent)
        {
            if (!DateTime.TryParseExact(txtDatumDijagnoze.Text, "dd/MM/yyyy HH:mm",
                CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime datumDijagnoze))
            {
                MessageBox.Show("Pogresno ste uneli datum. Mora biti u formatu dd/MM/yyyy hh:mm -> " + txtDatumDijagnoze.Text);
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

        public void Sacuvaj(DataGridView dataGridView1)
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

        public void Pretrazi(DataGridView dataGridView1, ComboBox cmbPacijent)
        {
            Pacijent pacijent = cmbPacijent.SelectedItem as Pacijent;

            if (pacijent == null || pacijent.IdPacijent == 0)
            {
                MessageBox.Show("Morate izabrati pacijenta!");
                return;
            }

            KriterijumPretrage kp = new KriterijumPretrage(pacijent);
            Odgovor odgovor = Transfer.Transfer.Instance.PosaljiZahtev(SistemskaOperacija.UcitajKartonPacijenta, kp);
            if (odgovor != null && odgovor.Uspesno)
            {
                List<Dijagnoza> listaP = (List<Dijagnoza>)odgovor.Podaci;
                if (listaP.Count > 0)
                {
                    MessageBox.Show("Sistem je pronasao termine po zadatim parametrima!");
                    lista = new BindingList<Dijagnoza>(listaP);
                    dataGridView1.DataSource = listaP;
                    // SortiranjeUtil(dataGridView1);
                }
                else
                {
                    MessageBox.Show("Nisu Pronadjene dijagnoze!");
                }
            }
            else
            {
                MessageBox.Show("Nisu pronadjene dijagnoze!");
            }
        }

        public void Obrisi(TextBox txtDatumDijagnoze, TextBox txtNaziv, TextBox txtOpis, ComboBox cmbPacijent, DataGridView dataGridView1)
        {
            try
            {
                Dijagnoza dijagnoza = (Dijagnoza)dataGridView1.SelectedRows[0].DataBoundItem;
                foreach (var dij in listaTrenutnih)
                {
                   if (dij.NazivDijagnoze == dijagnoza.NazivDijagnoze && dij.OpisDijagnoze == dijagnoza.OpisDijagnoze
                        && dij.Pacijent.IdPacijent == dijagnoza.Pacijent.IdPacijent && dij.Stomatolog.IdStomatolog == dijagnoza.Stomatolog.IdStomatolog
                        && dij.DatumDijagnoze.Date == dijagnoza.DatumDijagnoze.Date)
                    {
                        var result = MessageBox.Show(
                        $"Da li ste sigurni da zelite da obrisete dijagnozu od {dijagnoza.DatumDijagnoze} za pacijenta {dijagnoza.Pacijent.Ime} {dijagnoza.Pacijent.Prezime}", "Potvrda",
                        MessageBoxButtons.YesNoCancel);
                        if (result == DialogResult.Yes)
                        {
                            Odgovor odgovor = Transfer.Transfer.Instance.PosaljiZahtev(SistemskaOperacija.ObrisiDijagnozu, dijagnoza);
                            if (odgovor != null && odgovor.Uspesno)
                            {
                                MessageBox.Show("Uspesno ste obrisali termin!");
                                lista.Remove(dijagnoza);
                                return;
                            }
                            else
                            {
                                MessageBox.Show("Greska pri brisanju termina!");
                                return;
                            }
                        } else return;
                    } 
                }
                MessageBox.Show("Nemate dozvolu da brisete ovu dijagnozu");
            }
            catch (Exception)
            {
                MessageBox.Show("Morate selektovati dijagnozu");
                return;
            }
        }
    }
}
