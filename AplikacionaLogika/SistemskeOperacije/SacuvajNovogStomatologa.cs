using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Podaci.Domen;

namespace AplikacionaLogika.SistemskeOperacije
{
    public class SacuvajNovogStomatologa : OpstaSistemskaOperacija
    {
        protected override void operation(IDomenskiObjekat odo)
        {
            Stomatolog stoma = (Stomatolog)odo;
            List<Pacijent> pacijenti = broker.GenerickiSelect(new Pacijent()).OfType<Pacijent>().ToList();
            List<Stomatolog> stomatolozi = broker.GenerickiSelect(new Stomatolog()).OfType<Stomatolog>().ToList();

            foreach (var pacijent in pacijenti)
            {
                if (pacijent.KorisnickoIme == stoma.KorisnickoIme)
                {
                    throw new Exception($"Vec postoji korisnik {stoma.KorisnickoIme}");
                }

            }

            foreach (var stomatolog in stomatolozi)
            {
                if (stomatolog.KorisnickoIme == stoma.KorisnickoIme)
                {
                    throw new Exception($"Vec postoji stomatolog {stoma.KorisnickoIme}");
                }
            }

            broker.GenerickiUnos(stoma);
        }
    }
}
