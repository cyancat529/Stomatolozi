using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Podaci.Domen;

namespace AplikacionaLogika.SistemskeOperacije
{
    public class ObrisiDijagnozu: OpstaSistemskaOperacija
    {
        protected override void operation(IDomenskiObjekat odo)
        {
            broker.GenerickiObrisi((Dijagnoza)odo);
        }
    }
}
