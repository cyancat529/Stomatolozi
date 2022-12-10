using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Podaci.Domen;

namespace AplikacionaLogika.SistemskeOperacije
{
    public class UcitajStomatologa : OpstaSistemskaOperacija
    {
        public Stomatolog Stomatolog { get; set; }
        protected override void operation(IDomenskiObjekat odo)
        {
            List<Stomatolog> stomatolozi = broker.GenerickiSelect(new Stomatolog()).OfType<Stomatolog>().ToList();
            Stomatolog s = (Stomatolog) odo;
            foreach (var stomatolog in stomatolozi)
            {
                if (s.IdStomatolog == stomatolog.IdStomatolog)
                {
                    Stomatolog = s;
                    return;
                }
            }

            throw new Exception("Ne moze se pronaci ovaj stomatolog");
        }
    }
}
