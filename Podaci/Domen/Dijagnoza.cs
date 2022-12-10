using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podaci.Domen
{
    [Serializable]
    public class Dijagnoza : IDomenskiObjekat
    {
        public int IdDijagnoze { get; set; }
        public string NazivDijagnoze { get; set; }
        public string OpisDijagnoze { get; set; }
        public DateTime DatumDijagnoze { get; set; }
        public Stomatolog Stomatolog { get; set; }
        public Pacijent Pacijent { get; set; }

        public Dijagnoza()
        {
            
        }

        public Dijagnoza(int idDijagnoze, DateTime datumDijagnoze, string nazivDijagnoze, string opisDijagnoze, Stomatolog stomatolog, Pacijent pacijent)
        {
            IdDijagnoze = idDijagnoze;
            NazivDijagnoze = nazivDijagnoze;
            OpisDijagnoze = opisDijagnoze;
            DatumDijagnoze = datumDijagnoze;
            Stomatolog = stomatolog;
            Pacijent = pacijent;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override string ToString()
        {
            return NazivDijagnoze;
        }

        public string NazivTabele(bool extend)
        {
            return extend ? "Dijagnoza d" : "Dijagnoza";
        }

        public string VrednostiZaUnos()
        {
            return $"'{NazivDijagnoze}','{OpisDijagnoze}',{Pacijent.IdPacijent},{Stomatolog.IdStomatolog},'{DatumDijagnoze.ToString("yyyy-MM-dd")}'";
        }

        public string VrednostiZaIzmenu()
        {
            return $"datumDijagnoze = '{DatumDijagnoze}', nazivDijagnoze = '{NazivDijagnoze}', opisDijagnoze = '{OpisDijagnoze}', idPacijent = {Pacijent.IdPacijent}, idStomatolog = {Stomatolog.IdStomatolog}";
        }

        public string VrednostiZaJoinUpit()
        {
            return "join Pacijent p on (p.idPacijent = d.idPacijent)";
        }

        public string VrednostiZaWhereUpit()
        {
            return $"datumDijagnoze = '{DatumDijagnoze}' AND nazivDijagnoze = '{NazivDijagnoze}' AND opisDijagnoze = '{OpisDijagnoze}' AND idPacijent = { Pacijent.IdPacijent } AND idStomatolog = { Stomatolog.IdStomatolog }";
        }

        public List<IDomenskiObjekat> VratiVrednosti(SqlDataReader reader)
        {
            List<IDomenskiObjekat> objekti = new List<IDomenskiObjekat>();
            while (reader.Read())
            {
                int idStomatolog = Convert.ToInt32(reader["idStomatolog"]);
                string korisnickoStomatolog = reader["korisnickoIme"].ToString();
                Stomatolog s = new Stomatolog(idStomatolog, "", "", "", korisnickoStomatolog, "", null);


                int idPacijent = Convert.ToInt32(reader["idPacijent"]);
                string korisnicko = reader["korisnickoIme"].ToString();
                Pacijent pacijent = new Pacijent(idPacijent, korisnicko, "", "", "");


                string nazivDijagnoze = reader[1].ToString();
                string opis = reader[2].ToString();
                int idDijagnoze = Convert.ToInt32(reader[0]);
                DateTime datumDijagnoze = Convert.ToDateTime(reader[5]);

                Dijagnoza d = new Dijagnoza(idDijagnoze,datumDijagnoze, nazivDijagnoze, opis, s, pacijent);
                objekti.Add(d);

            }
            reader.Close();
            return objekti;
        }
    }
}
