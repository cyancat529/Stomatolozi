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
    public class LoginPodaci : IDomenskiObjekat
    {
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }

        public LoginPodaci(string korisnickoIme, string lozinka)
        {
            KorisnickoIme = korisnickoIme;
            Lozinka = lozinka;
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
