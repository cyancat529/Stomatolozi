using Podaci.Domen;
using Podaci.Storage;
using Podaci.Transfer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent.Kontroleri
{
    public class KontrolerUnosRacuna
    {
        private static KontrolerUnosRacuna instance;

        private KontrolerUnosRacuna()
        {

        }

        public static KontrolerUnosRacuna Instance
        {
            get
            {
                if (instance == null) instance = new KontrolerUnosRacuna();
                return instance;
            }
        }

        public void Inicijalno()
        {
           
        }

        public void Sacuvaj(TextBox txtDatum, TextBox txtBIznos, TextBox txtBIme, TextBox txtBPrezime)
        {
            Racun rac = FormirajRacun(txtDatum, txtBIznos, txtBIme, txtBPrezime);
            if (!DateTime.TryParseExact(txtDatum.Text, "dd/MM/yyyy HH:mm",
               CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date))
            {
                MessageBox.Show("Pogresno ste uneli datum. Mora biti u formatu dd/MM/yyyy hh:MM");
            }
            
            if (rac == null)
            {
                return;
            }

            Odgovor odgovor =
                Transfer.Transfer.Instance.PosaljiZahtev(SistemskaOperacija.SacuvajNoviRacun, rac);
            if (odgovor != null && odgovor.Uspesno)
            {
                MessageBox.Show("Uspesno sacuvani podaci racuna");
            }
            else
            {
                MessageBox.Show("Greska pri cuvanju podataka racuna!");
            }
        }


        private Racun FormirajRacun(TextBox txtDatum, TextBox txtBIznos, TextBox txtBIme, TextBox txtBPrezime)
        {
            string iznos = txtBIznos.Text;
            string ime = txtBIme.Text;
            string prezime = txtBPrezime.Text;

            if (!DateTime.TryParseExact(txtDatum.Text, "dd/MM/yyyy HH:mm",
                CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date))
            {
                MessageBox.Show("Pogresno ste uneli datum. Mora biti u formatu dd/MM/yyyy hh:MM");
                return null;
            }
            if (date < DateTime.Now)
            {
                MessageBox.Show("Datum mora biti veci od danasnjeg");
                return null;
            }

            if (string.IsNullOrEmpty(ime) || string.IsNullOrEmpty(prezime) || string.IsNullOrEmpty(iznos))
            {
                MessageBox.Show("Niste sva polja popunili!");
                return null;
            }
            return new Racun(0,date, iznos, ime, prezime);

        }
    }
}
