using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Podaci.Domen
{
    [Serializable]
    public class Termin : IDomenskiObjekat
    {
        public int IdTermin { get; set; }
        public DateTime Datum { get; set; }
        public string Status { get; set; }
        public Pacijent Pacijent { get; set; }
        public Stomatolog Stomatolog { get; set; }

        public Termin()
        {
            
        }

        public Termin(int idTermin, DateTime datum,string status, Pacijent pacijent, Stomatolog stomatolog)
        {
            IdTermin = idTermin;
            Datum = datum;
            Status = status;
            Pacijent = pacijent;
            Stomatolog = stomatolog;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override string ToString()
        {
            return Datum + " - " + Stomatolog.KorisnickoIme;
        }

        public string NazivTabele(bool extend)
        {
            return extend ? "Termin t" : "Termin";
        }

        public string VrednostiZaUnos()
        {
            if (Pacijent == null)
            {
                 return $"'{Datum}','{Status}',NULL,{Stomatolog.IdStomatolog}";
            }

            return $"'{Datum}','{Status}',{Pacijent.IdPacijent},{Stomatolog.IdStomatolog}";
        }

        public string VrednostiZaIzmenu()
        {
            if (Pacijent == null)
            {
                return $"datum ='{Datum}',status = '{Status}',idPacijent =NULL ,idStomatolog = {Stomatolog.IdStomatolog}";

            }
            return $"datum ='{Datum}',status = '{Status}',idPacijent = {Pacijent.IdPacijent},idStomatolog = {Stomatolog.IdStomatolog}";
        }

        public string VrednostiZaJoinUpit()
        {
            return "left join Pacijent p on (p.idPacijent = t.idPacijent) join Stomatolog s on (s.idStomatolog = t.idStomatolog)";
        }

        public string VrednostiZaWhereUpit()
        {
            return $"idTermin = {IdTermin}";
        }

        public List<IDomenskiObjekat> VratiVrednosti(SqlDataReader reader)
        {
            List<IDomenskiObjekat> objekti = new List<IDomenskiObjekat>();
            while (reader.Read())
            {
                int idStomatolog = Convert.ToInt32(reader["idStomatolog"]);
                string korisnickoStomatolog = reader[13].ToString();
                Stomatolog s = new Stomatolog(idStomatolog, "", "", "", korisnickoStomatolog, "", null);


                int idPacijent = reader["idPacijent"] != DBNull.Value ?  Convert.ToInt32(reader["idPacijent"]) : 0;
                Pacijent pacijent;
                if (idPacijent == 0)
                {
                    pacijent = null;
                }
                else
                {
                    string korisnicko = reader["korisnickoIme"].ToString();
                     pacijent = new Pacijent(idPacijent, korisnicko, "", "", "");

                }
                DateTime datum = Convert.ToDateTime(reader[1]);
                string status = reader[2].ToString();
                int idTermin = Convert.ToInt32(reader[0]);

                Termin t = new Termin(idTermin, datum, status, pacijent, s);
                objekti.Add(t);

            }
            reader.Close();
            return objekti;
        }
    }
}
