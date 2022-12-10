using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podaci.Domen
{
    [Serializable]
    public class Stomatolog : IDomenskiObjekat
    {
        public int IdStomatolog { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string BioStomatologa { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public Grad Grad { get; set; }

        public Stomatolog()
        {
            
        }

        public Stomatolog(int idStomatolog, string ime, string prezime, string bioStomatologa, string korisnickoIme, string lozinka, Grad grad)
        {
            IdStomatolog = idStomatolog;
            Ime = ime;
            Prezime = prezime;
            BioStomatologa = bioStomatologa;
            KorisnickoIme = korisnickoIme;
            Lozinka = lozinka;
            Grad = grad;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override string ToString()
        {
            return KorisnickoIme;
        }

        public string NazivTabele(bool extend)
        {
            return extend ? "Stomatolog s" : "Stomatolog";
        }

        public string VrednostiZaUnos()
        {
            return $"'{Ime}','{Prezime}','{KorisnickoIme}','{Lozinka}','{BioStomatologa}', {Grad.IdGrad}";
        }

        public string VrednostiZaIzmenu()
        {
            return $"ime = '{Ime}',prezime = '{Prezime}',korisnickoIme = '{KorisnickoIme}',lozinka = '{Lozinka}',bioStomatologa = '{BioStomatologa}', idGrad = {Grad.IdGrad}";
        }

        public string VrednostiZaJoinUpit()
        {
            return "join Grad g on (g.idGrad = s.idGrad)";
        }

        public string VrednostiZaWhereUpit()
        {
            return $"idStomatolog = {IdStomatolog}";
        }

        public List<IDomenskiObjekat> VratiVrednosti(SqlDataReader reader)
        {
            List<IDomenskiObjekat> objekti = new List<IDomenskiObjekat>();
            while (reader.Read())
            {
                int gradId = Convert.ToInt32(reader["idGrad"]);
                string naziv = reader["naziv"].ToString();
                string ptt = reader["ptt"].ToString();
                Grad g = new Grad(gradId, naziv, ptt);

                int idPacijent = Convert.ToInt32(reader[0]);
                string ime = reader[1].ToString();
                string prezime = reader[2].ToString();
                string korisnicko = reader[3].ToString();
                string lozinka = reader[4].ToString();
                string bioStom = reader[5].ToString();

                objekti.Add(new Stomatolog(idPacijent,ime,prezime,bioStom,korisnicko,lozinka,g));
               
            }
            reader.Close();
            return objekti;
        }

    }
}
