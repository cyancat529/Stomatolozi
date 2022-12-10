using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Podaci.Domen;

namespace Broker
{
    public class Broker
    {
        public SqlTransaction Transaction;
        public SqlConnection Connection;

        public Broker()
        {
            Connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Stomatolozi;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        }
        public void GenerickiUnos(IDomenskiObjekat objekat)
        {
            SqlCommand command = new SqlCommand($"insert into {objekat.NazivTabele(false)} values({objekat.VrednostiZaUnos()})", Connection, Transaction);
            if (command.ExecuteNonQuery() == 0) throw new Exception();
        }
        public void GenerickaIzmena(IDomenskiObjekat objekat)
        {
            SqlCommand command = new SqlCommand($"update {objekat.NazivTabele(false)} set {objekat.VrednostiZaIzmenu()} where {objekat.VrednostiZaWhereUpit()}",
                 Connection, Transaction);
            if (command.ExecuteNonQuery() == 0) throw new Exception();
        }
        public List<IDomenskiObjekat> GenerickiSelect(IDomenskiObjekat objekat)
        {
            SqlCommand command = new SqlCommand($"select * from {objekat.NazivTabele(true)} {objekat.VrednostiZaJoinUpit()}", Connection, Transaction);
            SqlDataReader reader = command.ExecuteReader();
            return objekat.VratiVrednosti(reader);
        }
        public void GenerickiObrisi(IDomenskiObjekat objekat)
        {
            SqlCommand command = new SqlCommand($"delete from {objekat.NazivTabele(false)} where {objekat.VrednostiZaWhereUpit()}", Connection, Transaction);
            command.ExecuteNonQuery();
        }
    }
}
