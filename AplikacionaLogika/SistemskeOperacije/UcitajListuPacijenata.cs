using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Podaci.Domen;

namespace AplikacionaLogika.SistemskeOperacije
{
    public class UcitajListuPacijenata : OpstaSistemskaOperacija
    {
        public List<Pacijent> Elementi { get; set; }
        protected override void operation(IDomenskiObjekat odo)
        {
            Elementi = broker.GenerickiSelect(new Pacijent()).OfType<Pacijent>().ToList();

        }
    }
}
