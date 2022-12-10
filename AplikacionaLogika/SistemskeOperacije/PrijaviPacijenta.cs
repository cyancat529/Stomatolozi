using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using Podaci.Domen;
using Podaci.Transfer;

namespace AplikacionaLogika.SistemskeOperacije
{
    public class PrijaviPacijenta : OpstaSistemskaOperacija
    {
        public IDomenskiObjekat Objekat { get; set; }
        protected override void operation(IDomenskiObjekat odo)
        {
            LoginPodaci login = (LoginPodaci) odo;
            List<Pacijent> pacijenti = broker.GenerickiSelect(new Pacijent()).OfType<Pacijent>().ToList();
            foreach (var pacijent in pacijenti)
            {
                if (pacijent.KorisnickoIme == login.KorisnickoIme && pacijent.Lozinka == login.Lozinka)
                {
                    Objekat = pacijent;
                    return;
                }
            }

            List<Stomatolog> stomatolozi = broker.GenerickiSelect(new Stomatolog()).OfType<Stomatolog>().ToList();
            foreach (var stomatolog in stomatolozi)
            {
                if (stomatolog.KorisnickoIme == login.KorisnickoIme && stomatolog.Lozinka == login.Lozinka)
                {
                    Objekat = stomatolog;
                    return;
                }
            }

            throw new Exception("Losi kredencijali za unos");


        }
    }
}
