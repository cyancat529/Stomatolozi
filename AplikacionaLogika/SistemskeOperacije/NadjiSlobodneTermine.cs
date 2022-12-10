using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Podaci.Domen;
using Podaci.Transfer;

namespace AplikacionaLogika.SistemskeOperacije
{
    public class NadjiSlobodneTermine : OpstaSistemskaOperacija
    {
        public List<Termin> Elementi { get; set; }
        protected override void operation(IDomenskiObjekat odo)
        {
            List<Termin> termini = broker.GenerickiSelect(new Termin()).OfType<Termin>().ToList();
            Elementi = new List<Termin>();

            foreach (var termin in termini)
            {
                if (termin.Status == "Slobodan")
                {
                    Elementi.Add(termin);
                }

            }
        }
    }
}
