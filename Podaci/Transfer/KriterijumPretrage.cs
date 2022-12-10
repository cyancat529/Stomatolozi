using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Podaci.Domen;

namespace Podaci.Transfer
{
    [Serializable]
    public class KriterijumPretrage : IDomenskiObjekat
    {
        public string Tekst { get; set; }
        public Stomatolog Stomatolog { get; set; }

        public KriterijumPretrage(string tekst, Stomatolog stomatolog)
        {
            Tekst = tekst;
            Stomatolog = stomatolog;
        }

        public string NazivTabele(bool extend)
        {
            throw new NotImplementedException();
        }

        public string VrednostiZaUnos()
        {
            throw new NotImplementedException();
        }

        public string VrednostiZaIzmenu()
        {
            throw new NotImplementedException();
        }

        public string VrednostiZaJoinUpit()
        {
            throw new NotImplementedException();
        }

        public string VrednostiZaWhereUpit()
        {
            throw new NotImplementedException();
        }

        public List<IDomenskiObjekat> VratiVrednosti(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
