using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podaci.Transfer
{
    [Serializable]
    public class Zahtev
    {
        public SistemskaOperacija SistemskaOperacija { get; set; }
        public object Podaci { get; set; }

        public Zahtev(SistemskaOperacija sistemskaOperacija, object podaci)
        {
            SistemskaOperacija = sistemskaOperacija;
            Podaci = podaci;
        }
    }
}
