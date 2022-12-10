using Podaci.Domen;
using Podaci.Transfer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent.Kontroleri
{
   public  class KontrolerUnosUsluge
    {

        private static KontrolerUnosUsluge instance;
        private KontrolerUnosUsluge()
        {

        }

        public static KontrolerUnosUsluge Instance
        {
            get
            {
                if (instance == null) instance = new KontrolerUnosUsluge();
                return instance;
            }
        }

        public void Inicijalno()
        {
            
        }

        public void Sacuvaj(TextBox txtBNaziv, TextBox txtBOpis)
        {
            Usluge usl = FormirajUsluge(txtBNaziv, txtBOpis);
            if (usl == null)
            {
                return;
            }

            Odgovor odgovor =
                Transfer.Transfer.Instance.PosaljiZahtev(SistemskaOperacija.SacuvajNovuUslugu, usl);
            if (odgovor != null && odgovor.Uspesno)
            {
                MessageBox.Show("Uspesno sacuvani podaci usluge");
            }
            else
            {
                MessageBox.Show("Greska pri cuvanju podataka usluge!");
            }
        }


        private Usluge FormirajUsluge(TextBox txtBNaziv, TextBox txtBOpis)
        {
            string naziv = txtBNaziv.Text;
            string opis = txtBOpis.Text;
         

            if (string.IsNullOrEmpty(naziv) || string.IsNullOrEmpty(opis))
            {
                MessageBox.Show("Niste sva polja popunili!");
                return null;
            }

            return new Usluge(0,naziv, opis);

        }

    }
}
