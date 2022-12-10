using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podaci.Domen
{
    [Serializable]
    public class Racun : IDomenskiObjekat
    {

        public int IdRacun { get; set; }
        public DateTime Datum { get; set; }
        public string Iznos { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public Racun()
        {
            
        }

        public Racun(int idRacun, DateTime datum, string iznos, string ime, string prezime)
        {
            IdRacun = idRacun;
            Datum = datum;
            Iznos = iznos;
            Ime = ime;
            Prezime = prezime;
        }

        public override string ToString()
        {
            if (IdRacun == 0)
            {
                return "NULL";
            }
            return Ime;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public string NazivTabele(bool extend)
        {
            return extend ? "Racun r" : "Racun";
        }

        public string VrednostiZaUnos()
        {
            return $"'{Datum}','{Iznos}','{Ime}','{Prezime}'";
        }

        public string VrednostiZaIzmenu()
        {
            return $"datum = '{Datum}',iznos = '{Iznos}',ime = '{Ime}',prezime = '{Prezime}'";
        }

        public string VrednostiZaJoinUpit()
        {
            return "";
        }

        public string VrednostiZaWhereUpit()
        {
            return $"idRacun = {IdRacun}";
        }

        public List<IDomenskiObjekat> VratiVrednosti(SqlDataReader reader)
        {
            List<IDomenskiObjekat> objekti = new List<IDomenskiObjekat>();
            while (reader.Read())
            {
                int idRacun = Convert.ToInt32(reader[0]);
                DateTime datum = Convert.ToDateTime(reader[1]);
                string iznos = Convert.ToString(reader[2]);
                string ime = reader[3].ToString();
                string prezime = reader[4].ToString();
                objekti.Add(new Racun(idRacun, datum, iznos, ime, prezime));
            }
            reader.Close();
            return objekti;
        }
    }
}
