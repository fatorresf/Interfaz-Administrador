using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace AdminDAL
{
    class ClienteDAL
    {
        public string RutCliente { get; set; }
        public String Nombres { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public String Telefono { get; set; }
        public String Correo { get; set; }
        public int IdSexo { get; set; }

        public ClienteDAL() { }

        //Constructor con Parametros
        public ClienteDAL(string rut, string nombres, DateTime fechanacimiento, String telefono, String correo, int idsexo)
        {
            RutCliente = rut;
            Nombres = nombres;
            FechaNacimiento = fechanacimiento;
            Telefono = telefono;
            Correo = correo;
            IdSexo = idsexo;
        }

        public DataTable GetAllCliente()
        {
            DataTable tabla = new DataTable();

            OracleConnection conexion = BD.Conexion;

            string st = "SELECT * FROM Cliente";

            OracleCommand cm = new OracleCommand(st, conexion);//Invocar la conexión
            cm.CommandType = CommandType.Text;
            OracleDataAdapter sqlDataAdapter = new OracleDataAdapter(cm);

            sqlDataAdapter.Fill(tabla);
            return tabla;

        }

    }

}
