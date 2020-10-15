using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace AdminDAL
{
    public class MesaDAL
    {
        public int Id_mesa { get; set; }
        public int Id_estado { get; set; }
        public int Capacidad { get; set; }

        public MesaDAL() { }

        public MesaDAL(int id_mesa, int id_estado, int capacidad)
        {
            Id_mesa = id_mesa;
            Id_estado = id_estado;
            Capacidad = capacidad;
        }

        public bool RegistrarMesa(int id_mesa, int id_estado,  int capacidad)
        {
            OracleConnection conexion = BD.Conexion;
            string st = "INSERT INTO Cliente VALUES (@id_mesa, @id_estado, @capacidad)";

            OracleCommand cm = new OracleCommand(st,conexion);
            cm.CommandType = CommandType.Text;

            cm.Parameters.Add("@id_mesa", id_mesa);
            cm.Parameters.Add("@id_estado", id_estado);
            cm.Parameters.Add("@capacidad", capacidad);

            conexion.Open();
            cm.ExecuteNonQuery();
            conexion.Close();
            return true;
        }
        public DataTable GetById(string _id_mesa)
        {
            using (OracleConnection cnxDB = BD.Conexion)
            {
                string st = "SELECT id_mesa,id_estado, capacidad FROM Mesas";
                OracleCommand cm = new OracleCommand(st, cnxDB);
                cm.CommandType = CommandType.Text;
                cm.Parameters.Add("@id_mesa", _id_mesa);

                using (DataTable dt = new DataTable())
                {
                    OracleDataAdapter da = new OracleDataAdapter(cm);
                    da.Fill(dt);
                    return dt;
                }
            }
        }


    }
}
