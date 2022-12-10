using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Podaci.Domen;
using Podaci.Transfer;

namespace AplikacionaLogika.SistemskeOperacije
{
    public class UcitajKartonPacijenta : OpstaSistemskaOperacija
    {
        public List<Dijagnoza> Elementi { get; set; }
        protected override void operation(IDomenskiObjekat odo)
        {
            List<Dijagnoza> sveDijagnoze = broker.GenerickiSelect(new Dijagnoza()).OfType<Dijagnoza>().ToList();
            KriterijumPretrage kp = (KriterijumPretrage)odo;
            Elementi = new List<Dijagnoza>();
            Pacijent pacijent = kp.Pacijent;

            foreach (var dijagnoza in sveDijagnoze)
            {
                if (pacijent != null && pacijent.IdPacijent >= 0)
                {
                    if (pacijent.IdPacijent == dijagnoza.Pacijent.IdPacijent)
                    {
                        Elementi.Add(dijagnoza);
                    }
                }
            }
        }
    }
}
