using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Podaci.Domen;
using Podaci.Storage;
using Podaci.Transfer;

namespace Klijent.Kontroleri
{
    public class KontrolerRegistracija
    {
        private static KontrolerRegistracija instance;

        private KontrolerRegistracija()
        {

        }

        public static KontrolerRegistracija Instance
        {
            get
            {
                if (instance == null) instance = new KontrolerRegistracija();
                return instance;
            }
        }

        public void Registracija(TextBox txtIme, TextBox txtPrezime, TextBox txtKorisnicko, TextBox txtLozinka)
        {
            Pacijent pacijent = FormirajPacijenta(txtIme,txtPrezime,txtKorisnicko,txtLozinka);
            if (pacijent == null)
            {
                return;
            }
            Odgovor odgovor =
                Transfer.Transfer.Instance.PosaljiZahtev(SistemskaOperacija.RegistrujNovogPacijenta, pacijent);
            if (odgovor != null && odgovor.Uspesno)
            {
                MessageBox.Show($"{pacijent.KorisnickoIme} je uspesno registrovana!");
            }
            else
            {
                MessageBox.Show("Greska pri registraciji!");
            }
        }

        private Pacijent FormirajPacijenta(TextBox txtIme, TextBox txtPrezime, TextBox txtKorisnicko, TextBox txtLozinka)
        {
            string ime = txtIme.Text;
            string prezime = txtPrezime.Text;
            string kor = txtKorisnicko.Text;
            string loz = txtLozinka.Text;
            if (string.IsNullOrEmpty(ime) || string.IsNullOrEmpty(prezime) || string.IsNullOrEmpty(kor) ||
                string.IsNullOrEmpty(loz))
            {
                MessageBox.Show("Niste sva polja popunili!");
                return null;
            }

            if (kor.Length < 5)
            {
                MessageBox.Show("Korisnicko ime mora imati makar 5 karaktera");
                return null;
            }
            if (kor.Length < 6)
            {
                MessageBox.Show("Sigra mora imati makar 6 karaktera");
                return null;
            }
            if (Storage.Instance.Administratori.ContainsKey(kor))
            {
                MessageBox.Show("Postoji vec korisnik sa tim korisnickim imenom!");
                return null;
            }
            return new Pacijent(0, kor, loz, ime, prezime);
        }
    }
}
