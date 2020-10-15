using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using Oracle.ManagedDataAccess.Client;



namespace AdminDAL
{
    class UserDAL
    {
        public int id_usuario { get; set; }
        public string nom_usuario { get; set; }
        public string clave { get; set; }
        public int cargo { get; set; }

        public UserDAL()
        {

        }
        public UserDAL(int id_usuario, string nom_usuario, string clave, int cargo)
        {
            this.id_usuario = id_usuario;
            this.nom_usuario = nom_usuario;
            this.clave = clave;
            this.cargo = cargo;
        }
        public bool Add_SP()
        {
            /*
             terminar...
             */
            string cnxStr = "Data Source=(DESCRIPTION =(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST = localhost)(PORT = 1521)))(CONNECT_DATA =(SERVICE_NAME = xe)));User ID=sigloXXI;Password=felipe;";

            try
            {
                OracleConnection cnx = new OracleConnection(cnxStr);
                OracleCommand command = new OracleCommand("sp_insertar_datos", cnx);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("param_1", 123);

                command.Connection.Open();
                command.ExecuteNonQuery();
                command.Connection.Close();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar usuario: {0}", ex.Message);
                return false;
            }
        } 
    }
}
