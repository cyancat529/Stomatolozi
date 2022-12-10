using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Podaci.Domen;

namespace AplikacionaLogika.SistemskeOperacije
{
    public class SacuvajSlobodneTermine : OpstaSistemskaOperacija
    {
        private List<Termin> termini;
        public SacuvajSlobodneTermine(List<Termin> termini)
        {
            this.termini = termini;
        }
        protected override void operation(IDomenskiObjekat odo)
        {
            if (termini != null)
            {
                foreach (var termin in termini)
                {
                    broker.GenerickiUnos(termin);
                }
            }
        } 
    }
}
