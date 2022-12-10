using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Podaci.Domen;

namespace AplikacionaLogika.SistemskeOperacije
{
    public class ZapamtiTermin : OpstaSistemskaOperacija
    {
        protected override void operation(IDomenskiObjekat odo)
        {
            Termin termin = (Termin)odo;
            
            broker.GenerickaIzmena((Termin) odo);
        }
    }
}
