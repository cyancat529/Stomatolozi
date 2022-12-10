using Podaci.Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacionaLogika.SistemskeOperacije
{
    public class SacuvajNoviRacun : OpstaSistemskaOperacija
    {
        protected override void operation(IDomenskiObjekat odo)
        {
            Racun rac = (Racun)odo;
            broker.GenerickiUnos(rac);
        }
    }
}
