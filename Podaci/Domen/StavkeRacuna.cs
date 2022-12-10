using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Podaci.Domen
{
    [Serializable]
    public class StavkeRacuna : IDomenskiObjekat
    {
        public int IdStavkeRacuna { get; set; }
        public DateTime Datum { get; set; }
        public Racun Racun { get; set; }
        public Usluge Usluge { get; set; }
        public Pacijent Pacijent { get; set; }
        public Stomatolog Stomatolog { get; set; }

        public StavkeRacuna()
        {
            
        }

        public StavkeRacuna(int idRacun, DateTime datum, Racun racun, Usluge usluge, Pacijent pacijent, Stomatolog stomatolog)
        {
            idRacun = idRacun;
            Datum = datum;
            Racun = racun;
            Usluge = usluge;
            Pacijent = pacijent;
            Stomatolog = stomatolog;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override string ToString()
        {
            return Datum + " - " + " - " + Racun.Iznos + " - " + Usluge.Naziv + " - " + Stomatolog.KorisnickoIme;
        }

        public string NazivTabele(bool extend)
        {
            return extend ? "StavkeRacuna sr" : "StavkeRacuna";
        }

        public string VrednostiZaUnos()
        {
            if (Pacijent == null)
            {
                 return $"'{Datum}','{Racun.Iznos}', '{Usluge.IdUsluge}', NULL,{Stomatolog.IdStomatolog}";
            }

            return $"'{Datum}','{Racun.Iznos}','{Usluge.IdUsluge}', {Pacijent.IdPacijent},{Stomatolog.IdStomatolog}";
        }

        public string VrednostiZaIzmenu()
        {
            if (Pacijent == null)
            {
                return $"datum ='{Datum}',iznos = '{Racun.Iznos}', idUsluge = '{Usluge.IdUsluge}', idPacijent =NULL ,idStomatolog = {Stomatolog.IdStomatolog}";

            }
            return $"datum ='{Datum}',iznos = '{Racun.Iznos}',idUsluge = '{Usluge.IdUsluge}', idPacijent = {Pacijent.IdPacijent},idStomatolog = {Stomatolog.IdStomatolog}";
        }

        public string VrednostiZaJoinUpit()
        {
            return "left join Racun r on (r.idRacun = t.idRacun) join Usluge u on (u.idUsluge = t.idUsluge)";
        }

        public string VrednostiZaWhereUpit()
        {
            return $"idStavkeRacuna = {IdStavkeRacuna}";
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

                int idRacun = reader["idRacun"] != DBNull.Value ? Convert.ToInt32(reader["idRacun"]) : 0;
                Racun racun;
                racun = new Racun(idRacun, Datum, Racun.Iznos, "", "");

                int idUsluge = reader["idUsluge"] != DBNull.Value ? Convert.ToInt32(reader["idUsluge"]) : 0;
                Usluge usluge;
                usluge = new Usluge(idUsluge, "", "");


                DateTime datum = Convert.ToDateTime(reader[1]);
                int idStavkeRacuna = Convert.ToInt32(reader[0]);

                StavkeRacuna sr = new StavkeRacuna(idStavkeRacuna, datum, racun, usluge, pacijent, s);
                objekti.Add(sr);

            }
            reader.Close();
            return objekti;
        }
    }
}
