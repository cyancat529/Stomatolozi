using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Podaci.Domen
{
    public interface IDomenskiObjekat
    {
        string NazivTabele(bool extend);
        string VrednostiZaUnos();
        string VrednostiZaIzmenu();
        string VrednostiZaJoinUpit();
        string VrednostiZaWhereUpit();
        List<IDomenskiObjekat> VratiVrednosti(SqlDataReader reader);

    }
}
