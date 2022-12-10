using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podaci.Domen
{
    [Serializable]
    public class Grad : IDomenskiObjekat
    {
        public int IdGrad { get; set; }
        public string Naziv { get; set; }
        public string Ptt { get; set; }

        public Grad()
        {
            
        }

        public Grad(int idGrad, string naziv, string ptt)
        {
            IdGrad = idGrad;
            Naziv = naziv;
            Ptt = ptt;
        }

        public override string ToString()
        {
            return Naziv;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public string NazivTabele(bool extend)
        {
            return extend ? "Grad g" : "Grad";
        }

        public string VrednostiZaUnos()
        {
            return "";
        }

        public string VrednostiZaIzmenu()
        {
            return "";
        }

        public string VrednostiZaJoinUpit()
        {
            return "";
        }

        public string VrednostiZaWhereUpit()
        {
            return "";
        }

        public List<IDomenskiObjekat> VratiVrednosti(SqlDataReader reader)
        {
            List<IDomenskiObjekat> objekti = new List<IDomenskiObjekat>();
            while (reader.Read())
            {
                int gradId = Convert.ToInt32(reader[0]);
                string naziv = reader[1].ToString();
                string ptt = reader[2].ToString();
                objekti.Add(new Grad(gradId,naziv,ptt));
            }
            reader.Close();
            return objekti;
        }
    }
}
