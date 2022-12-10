using Podaci.Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacionaLogika.SistemskeOperacije
{
    public class SacuvajNovuUslugu : OpstaSistemskaOperacija
    {
        protected override void operation(IDomenskiObjekat odo)
        {
            Usluge us = (Usluge)odo;
            broker.GenerickiUnos(us);

        }
    }
}
