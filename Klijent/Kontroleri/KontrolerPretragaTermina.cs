using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Podaci.Domen;
using Podaci.Storage;
using Podaci.Transfer;

namespace Klijent.Kontroleri
{
    public class KontrolerPretragaTermina
    {
        private static KontrolerPretragaTermina instance;
        private BindingList<Termin> Lista;
        private KontrolerPretragaTermina()
        {

        }

        public static KontrolerPretragaTermina Instance
        {
            get
            {
                if (instance == null) instance = new KontrolerPretragaTermina();
                return instance;
            }
        }

        public void Inicijalno(DataGridView dataGridView1, ComboBox cmbStomatolog, Button btnOtkazi, Button btnZakazi)
        {
            Odgovor odgovor = Transfer.Transfer.Instance.PosaljiZahtev(SistemskaOperacija.UcitajListuTermina, null);
            if (odgovor != null)
            {
                Lista = new BindingList<Termin>((List<Termin>)odgovor.Podaci);
                dataGridView1.DataSource = Lista;
                SortiranjeUtil(dataGridView1);
                
            }

            odgovor = Transfer.Transfer.Instance.PosaljiZahtev(SistemskaOperacija.UcitajListuStomatologa, null);
            if (odgovor != null)
            {
                var stomatolozi = (List<Stomatolog>) odgovor.Podaci;
                stomatolozi.Insert(0,new Stomatolog(0,"","","","","",null));
                cmbStomatolog.DataSource = new BindingList<Stomatolog>(stomatolozi);
            }

            if (Storage.Instance.UserRole == UserUtil.Pacijent)
            {
                btnZakazi.Enabled = true;
                btnOtkazi.Enabled = true;
            }
            else
            {
                btnZakazi.Enabled = false;
                btnOtkazi.Enabled = false;
            }
        }

        private void SortiranjeUtil(DataGridView dataGridView1)
        {
            if (Storage.Instance.UserRole == UserUtil.Stomatolog)
            {
                Stomatolog s = Storage.Instance.Login as Stomatolog;
                var result = Lista.Where(termin => termin.Stomatolog.IdStomatolog == s?.IdStomatolog).ToList();
                
                Lista = new BindingList<Termin>(result);
            }
            else
            {
                Pacijent p = Storage.Instance.Login as Pacijent;
                var result = Lista.Where(termin =>
                    (termin.Pacijent != null && termin.Pacijent.IdPacijent == p?.IdPacijent && termin.Status == "Zauzet") || (termin.Status != "Zauzet" && termin.Datum > DateTime.Now)).ToList();
                Lista = new BindingList<Termin>(result);
            }
            dataGridView1.DataSource = Lista;
        }

        public void Zakazi(DataGridView dataGridView1, ComboBox cmbStomatolog, Button btnOtkazi, Button btnZakazi)
        {
            try
            {
                Termin termin = (Termin)dataGridView1.SelectedRows[0].DataBoundItem;
                termin.Pacijent = Storage.Instance.Login as Pacijent;
                termin.Status = "Zauzet";
                var result = MessageBox.Show(
                    $"Da li ste sigurni da zelite da zakazete termin {termin.Datum} kod stomatologa {termin.Stomatolog.Ime} {termin.Stomatolog.Prezime}", "Potvrda",
                    MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    Odgovor odgovor =
                        Transfer.Transfer.Instance.PosaljiZahtev(SistemskaOperacija.ZapamtiTermin, termin);
                    if (odgovor != null && odgovor.Uspesno)
                    {
                        MessageBox.Show("Uspesno ste zakazali termin!");
                        Inicijalno(dataGridView1, cmbStomatolog, btnOtkazi, btnZakazi);
                    }
                    else
                    {
                        MessageBox.Show("Greska pri zakazivanju termina!");
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Morate selektovati polaznik");
                return;
            }
        }

        public void Otkazi(DataGridView dataGridView1, ComboBox cmbStomatolog, Button btnOtkazi, Button btnZakazi)
        {
            try
            {
                Termin termin = (Termin)dataGridView1.SelectedRows[0].DataBoundItem;
                termin.Pacijent = Storage.Instance.Login as Pacijent;
                if (termin.Status != "Zauzet")
                {
                    MessageBox.Show("Morate izabrati svoj zauzet termin");
                    return;
                }

                termin.Status = "Slobodan";
                termin.Pacijent = null;
                var result = MessageBox.Show(
                    $"Da li ste sigurni da zelite da oktazete termin {termin.Datum} kod stomatologa {termin.Stomatolog.Ime} {termin.Stomatolog.Prezime}","Potvrda",
                    MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    Odgovor odgovor = Transfer.Transfer.Instance.PosaljiZahtev(SistemskaOperacija.ObrisiTermin, termin);
                    if (odgovor != null && odgovor.Uspesno)
                    {
                        MessageBox.Show("Uspesno ste obrisali termin!");
                        Inicijalno(dataGridView1, cmbStomatolog, btnOtkazi, btnZakazi);
                    }
                    else
                    {
                        MessageBox.Show("Greska pri brisanju termina!");
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Morate selektovati termin");
                return;
            }
        }

       
        public void Pretrazi(DataGridView dataGridView1, TextBox txtNaziv, ComboBox cmbStomatolog)
        {
            Stomatolog stomatolog = cmbStomatolog.SelectedItem as Stomatolog;
            
            if (string.IsNullOrEmpty(txtNaziv.Text) && (stomatolog == null || stomatolog.IdStomatolog == 0))
            {
                MessageBox.Show("Morate uneti neki kriterijum za pretragu!");
                return;
            }

            KriterijumPretrage kp = new KriterijumPretrage(txtNaziv.Text, stomatolog);
            Odgovor odgovor = Transfer.Transfer.Instance.PosaljiZahtev(SistemskaOperacija.VratiTerminePoKriterijumu, kp);
            if (odgovor != null && odgovor.Uspesno)
            {
                List<Termin> lista = (List<Termin>)odgovor.Podaci;
                if (lista.Count > 0)
                {
                    MessageBox.Show("Sistem je pronasao termine po zadatim parametrima!");
                    Lista = new BindingList<Termin>(lista);
                    dataGridView1.DataSource = Lista;
                   // SortiranjeUtil(dataGridView1);
                }
                else
                {
                    MessageBox.Show("Nisu pronadjeni slobodni termini!");
                }
            }
            else
            {
                MessageBox.Show("Nisu pronadjeni slobodni termini!");
            }
        }
    }
}
