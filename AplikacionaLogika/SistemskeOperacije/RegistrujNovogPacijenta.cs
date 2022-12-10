using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Podaci.Domen;

namespace AplikacionaLogika.SistemskeOperacije
{
    public class RegistrujNovogPacijenta : OpstaSistemskaOperacija
    {
        protected override void operation(IDomenskiObjekat odo)
        {
            Pacijent p = (Pacijent) odo;
            List<Pacijent> pacijenti = broker.GenerickiSelect(new Pacijent()).OfType<Pacijent>().ToList();
            List<Stomatolog> stomatolozi = broker.GenerickiSelect(new Stomatolog()).OfType<Stomatolog>().ToList();

            foreach (var pacijent in pacijenti)
            {
                if (pacijent.KorisnickoIme == p.KorisnickoIme)
                {
                    throw new Exception($"Vec postoji korisnik {p.KorisnickoIme}");
                }
                
            }

            foreach (var stomatolog in stomatolozi)
            {
                if (stomatolog.KorisnickoIme == p.KorisnickoIme)
                {
                    throw new Exception($"Vec postoji stomatolog {p.KorisnickoIme}");
                }
            }

            broker.GenerickiUnos(p);

        }
    }
}
