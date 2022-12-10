using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Podaci.Domen;

namespace AplikacionaLogika.SistemskeOperacije
{
    public class UcitajSlobodanTermin : OpstaSistemskaOperacija
    {
        public Termin Termin { get; set; }
        protected override void operation(IDomenskiObjekat odo)
        {
            List<Termin> termini = broker.GenerickiSelect(new Termin()).OfType<Termin>().ToList();
            Termin ter = (Termin)odo;
            foreach (var termin in termini)
            {
                if (termin.IdTermin == ter.IdTermin)
                {
                    Termin = ter;
                    return;
                }
            }

            throw new Exception("Ne moze se pronaci ovaj stomatolog");
        }
    }
}
