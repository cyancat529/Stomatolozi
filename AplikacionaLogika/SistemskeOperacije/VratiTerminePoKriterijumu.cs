using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Podaci.Domen;
using Podaci.Transfer;

namespace AplikacionaLogika.SistemskeOperacije
{
    public class VratiTerminePoKriterijumu : OpstaSistemskaOperacija
    {
        public List<Termin> Elementi { get; set; }
        protected override void operation(IDomenskiObjekat odo)
        {
            List<Termin> termini = broker.GenerickiSelect(new Termin()).OfType<Termin>().ToList();
            Elementi = new List<Termin>();
            KriterijumPretrage kp = (KriterijumPretrage) odo;
            string tekst = kp.Tekst.ToLower();
            foreach (var termin in termini)
            {
                if (kp.Stomatolog != null && kp.Stomatolog.IdStomatolog > 0)
                {
                    if (kp.Stomatolog.IdStomatolog == termin.Stomatolog.IdStomatolog &&
                        (termin.Stomatolog.KorisnickoIme.ToLower().Contains(tekst)
                         || (termin.Pacijent != null && termin.Pacijent.KorisnickoIme.ToLower().Contains(tekst))))
                    {
                        Elementi.Add(termin);
                    }
                }
                else
                {
                    if (termin.Stomatolog.KorisnickoIme.ToLower().Contains(tekst)
                        || (termin.Pacijent != null && termin.Pacijent.KorisnickoIme.ToLower().Contains(tekst)))
                    {
                        Elementi.Add(termin);
                    }
                }
            }
        }
    }
}
