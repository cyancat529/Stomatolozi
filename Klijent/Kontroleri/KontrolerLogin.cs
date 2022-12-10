using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Klijent.Ekranske_forme;
using Podaci.Domen;
using Podaci.Storage;
using Podaci.Transfer;

namespace Klijent.Kontroleri
{
    public class KontrolerLogin
    {
        private static KontrolerLogin instance;

        private KontrolerLogin()
        {

        }

        public static KontrolerLogin Instance
        {
            get
            {
                if (instance == null) instance = new KontrolerLogin();
                return instance;
            }
        }

        public void SacuvajLogin(TextBox txtKorisnicko, TextBox txtSifra)
        {
            LoginPodaci login = FormirajLogin(txtKorisnicko,txtSifra);
            if (login == null) return;

            Odgovor odgovor = Transfer.Transfer.Instance.PosaljiZahtev(SistemskaOperacija.PrijaviPacijenta, login);
            if (odgovor != null && odgovor.Uspesno)
            {
                Storage.Instance.Login = odgovor.Podaci;
                MessageBox.Show("Uspesno ste se prijavili na sistem!");
                if (odgovor.Podaci is Pacijent)
                {
                    Storage.Instance.UserRole = UserUtil.Pacijent;
                    PacijentMeni meni = new PacijentMeni();
                    meni.ShowDialog();

                }
                else
                {
                    Storage.Instance.UserRole = UserUtil.Stomatolog;
                    StomatologMeni meni = new StomatologMeni();
                    meni.ShowDialog();
                }

            }
            else
            {
                var administratori = Storage.Instance.Administratori;
                if (administratori == null)
                {
                    MessageBox.Show("Greska pri prijavljivanju!");
                    return;
                }

                if (administratori.ContainsKey(login.KorisnickoIme))
                {
                    MessageBox.Show("Uspesno ste se prijavili na sistem!");
                    Storage.Instance.Login = login;
                    Storage.Instance.UserRole = UserUtil.Administrator;
                    AdministratorMeni meni = new AdministratorMeni();
                    meni.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Greska pri prijavljivanju!");
                }
            }
        }

        private LoginPodaci FormirajLogin(TextBox txtKorisnicko, TextBox txtSifra)
        {
            string kor = txtKorisnicko.Text;
            string loz = txtSifra.Text;
            return new LoginPodaci(kor, loz);
        }
    }
}
