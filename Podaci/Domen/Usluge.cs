using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podaci.Domen
{
    [Serializable]
    public class Usluge : IDomenskiObjekat
    {
        public int IdUsluge { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }

        public Usluge()
        {
            
        }

        public Usluge(int idUsluge, string naziv, string opis)
        {
            IdUsluge = idUsluge;
            Naziv = naziv;
            Opis = opis;
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
            return extend ? "Usluge u" : "Usluge";
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
                int uslugeId = Convert.ToInt32(reader[0]);
                string naziv = reader[1].ToString();
                string opis = reader[2].ToString();
                objekti.Add(new Usluge(uslugeId,naziv,opis));
            }
            reader.Close();
            return objekti;
        }
    }
}
