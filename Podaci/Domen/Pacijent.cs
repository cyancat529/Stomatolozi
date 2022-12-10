using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podaci.Domen
{
    [Serializable]
    public class Pacijent : IDomenskiObjekat
    {
        public int IdPacijent { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public Pacijent()
        {
            
        }

        public Pacijent(int idPacijent, string korisnickoIme, string lozinka, string ime, string prezime)
        {
            IdPacijent = idPacijent;
            KorisnickoIme = korisnickoIme;
            Lozinka = lozinka;
            Ime = ime;
            Prezime = prezime;
        }

        public override string ToString()
        {
            if (IdPacijent == 0)
            {
                return "NULL";
            }
            return KorisnickoIme;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public string NazivTabele(bool extend)
        {
            return extend ? "Pacijent p" : "Pacijent";
        }

        public string VrednostiZaUnos()
        {
            return $"'{KorisnickoIme}','{Lozinka}','{Ime}','{Prezime}'";
        }

        public string VrednostiZaIzmenu()
        {
            return $"korisnickoIme = '{KorisnickoIme}',lozinka = '{Lozinka}',ime = '{Ime}',prezime = '{Prezime}'";
        }

        public string VrednostiZaJoinUpit()
        {
            return "";
        }

        public string VrednostiZaWhereUpit()
        {
            return $"idPacijent = {IdPacijent}";
        }

        public List<IDomenskiObjekat> VratiVrednosti(SqlDataReader reader)
        {
            List<IDomenskiObjekat> objekti = new List<IDomenskiObjekat>();
            while (reader.Read())
            {
                int idPacijent = Convert.ToInt32(reader[0]);
                string korisnicko = reader[1].ToString();
                string lozinka = reader[2].ToString();
                string ime = reader[3].ToString();
                string prezime = reader[4].ToString();
                objekti.Add(new Pacijent(idPacijent,korisnicko,lozinka,ime,prezime));
            }
            reader.Close();
            return objekti;
        }
    }
}
