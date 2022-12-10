using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Podaci.Domen;

namespace AplikacionaLogika.SistemskeOperacije
{
    public abstract class OpstaSistemskaOperacija
    {
        protected Broker.Broker broker = new Broker.Broker();

        protected abstract void operation(IDomenskiObjekat odo);
        public void execute(IDomenskiObjekat odo)
        {
            try
            {
                broker.Connection.Open();
                broker.Transaction = broker.Connection.BeginTransaction();
                operation(odo);
                broker.Transaction.Commit();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                broker.Transaction.Rollback();
                throw;
            }
            finally
            {
                broker.Connection.Close();
            }
        }
    }
}
