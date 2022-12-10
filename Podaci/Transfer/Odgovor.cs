using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podaci.Transfer
{
    [Serializable]
    public class Odgovor
    {
        public bool Uspesno { get; set; }
        public object Podaci { get; set; }

        public Odgovor(bool uspesno, object podaci)
        {
            Uspesno = uspesno;
            Podaci = podaci;
        }
    }
}
