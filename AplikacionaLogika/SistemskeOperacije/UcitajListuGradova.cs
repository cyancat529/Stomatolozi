using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Podaci.Domen;

namespace AplikacionaLogika.SistemskeOperacije
{
    public class UcitajListuGradova : OpstaSistemskaOperacija
    {
        public List<Grad> Elementi { get; set; }
        protected override void operation(IDomenskiObjekat odo)
        {
            Elementi = broker.GenerickiSelect(new Grad()).OfType<Grad>().ToList();

        }
    }
}
