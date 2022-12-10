using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Podaci.Domen;

namespace AplikacionaLogika.SistemskeOperacije
{
    public class KartonPacijenta : OpstaSistemskaOperacija
    {
        private List<Dijagnoza> dijagnoze;
        public KartonPacijenta(List<Dijagnoza> dijagnoze)
        {
            this.dijagnoze = dijagnoze;
        }
        protected override void operation(IDomenskiObjekat odo)
        {
            if (dijagnoze != null)
            {
                foreach (var dijagnoza in dijagnoze)
                {
                    broker.GenerickiUnos(dijagnoza);
                    dijagnoze = broker.GenerickiSelect(new Dijagnoza()).OfType<Dijagnoza>().ToList();
                }
            }
        }
    }
}
