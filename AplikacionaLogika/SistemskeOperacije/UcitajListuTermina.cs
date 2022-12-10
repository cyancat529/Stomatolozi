using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Podaci.Domen;

namespace AplikacionaLogika.SistemskeOperacije
{
    public class UcitajListuTermina : OpstaSistemskaOperacija
    {
        public List<Termin> Elementi { get; set; }
        protected override void operation(IDomenskiObjekat odo)
        {
            Elementi = broker.GenerickiSelect(new Termin()).OfType<Termin>().ToList();
        }
    }
}
