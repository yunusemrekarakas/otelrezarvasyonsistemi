using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;


namespace rezarvasyonsistemiOtel
{
    class veritabani
    {
        public SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-1H5NTHC\SQLEXPRESS;Initial Catalog=otelrezarvasyonsistemi;Integrated Security=True;MultipleActiveResultSets=True");
    }
}
