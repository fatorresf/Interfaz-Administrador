using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminDAL
{
    class BD
    {
        private static OracleConnection conexion = null;
        static string sc = @"DATA SOURCE=localhost/XE;USER ID=sigloXXI;PASSWORD=felipe;";

        private BD() { }

        public static OracleConnection Conexion
        {
            get
            {
                if (conexion == null)
                    conexion = new OracleConnection(sc);

                if (conexion.ConnectionString == "")
                    conexion.ConnectionString = sc;

                return conexion;
            }
        }
    }
}
