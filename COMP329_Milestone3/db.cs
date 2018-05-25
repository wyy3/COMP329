using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;

namespace COMP329_Milestone3
{
    static class Db
    {
        public static OracleConnection Connection()
        {
            var ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["COMP329"].ConnectionString;
            return new OracleConnection(ConnectionString);
        }
    }
}
