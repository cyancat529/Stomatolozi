using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Podaci.Domen;
using Podaci.Transfer;

namespace AplikacionaLogika.SistemskeOperacije
{
    public class NadjiStomatologa : OpstaSistemskaOperacija
    {
        public List<Stomatolog> Elementi { get; set; }
        protected override void operation(IDomenskiObjekat odo)
        {
            List<Stomatolog> sviStomatolozi  = broker.GenerickiSelect(new Stomatolog()).OfType<Stomatolog>().ToList();
            KriterijumPretrage kp = (KriterijumPretrage) odo;
            string tekst = kp.Tekst.ToLower();
            Elementi = new List<Stomatolog>();
            
            foreach (var stomatolog in sviStomatolozi)
            {
                if (stomatolog.Ime.ToLower().Contains(tekst) || stomatolog.Prezime.ToLower().Contains(tekst) ||
                    stomatolog.KorisnickoIme.ToLower().Contains(tekst) || stomatolog.Grad.Naziv.ToLower().Contains(tekst))
                {
                    Elementi.Add(stomatolog);
                }
            }
        }

    }
}
