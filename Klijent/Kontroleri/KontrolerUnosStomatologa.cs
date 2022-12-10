using Podaci.Domen;
using Podaci.Storage;
using Podaci.Transfer;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Klijent.Kontroleri
{
    public class KontrolerUnosStomatologa
    {
        private static KontrolerUnosStomatologa instance;
        private KontrolerUnosStomatologa()
        {

        }

        public static KontrolerUnosStomatologa Instance
        {
            get
            {
                if (instance == null) instance = new KontrolerUnosStomatologa();
                return instance;
            }
        }

        public void Inicijalno(ComboBox cmbGrad)
        {
            Odgovor odgovor = Transfer.Transfer.Instance.PosaljiZahtev(SistemskaOperacija.UcitajListuGradova, null);
            if (odgovor != null)
            {
                cmbGrad.DataSource = (List<Grad>)odgovor.Podaci;
            }
        }

        public void Sacuvaj(TextBox txtIme, TextBox txtPrezime, TextBox txtKorisnicko, TextBox txtLozinka, TextBox txtBio, ComboBox cmbGrad)
        {
            Stomatolog sto = FormirajStomatologa(txtIme,txtPrezime,txtKorisnicko,txtLozinka,txtBio,cmbGrad);
            if (sto == null)
            {
                return;
            }

            Odgovor odgovor =
                Transfer.Transfer.Instance.PosaljiZahtev(SistemskaOperacija.SacuvajNovogStomatologa, sto);
            if (odgovor != null && odgovor.Uspesno)
            {
                MessageBox.Show("Uspesno sacuvani podaci o stomatologu");
            }
            else
            {
                MessageBox.Show("Greska pri cuvanju podataka o stomatologu!");
            }
        }


        private Stomatolog FormirajStomatologa(TextBox txtIme, TextBox txtPrezime, TextBox txtKorisnicko, TextBox txtLozinka, TextBox txtBio, ComboBox cmbGrad)
        {
            string ime = txtIme.Text;
            string prezime = txtPrezime.Text;
            string kor = txtKorisnicko.Text;
            string loz = txtLozinka.Text;
            string bio = txtBio.Text;

            Grad grad = cmbGrad.SelectedItem as Grad;

            if (string.IsNullOrEmpty(ime) || string.IsNullOrEmpty(prezime) || string.IsNullOrEmpty(kor) ||
                string.IsNullOrEmpty(loz) || string.IsNullOrEmpty(bio))
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
            return new Stomatolog(0, ime, prezime, bio, kor, loz, grad);

        }

    }
}
