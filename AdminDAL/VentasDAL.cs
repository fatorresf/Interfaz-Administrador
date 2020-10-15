using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminDAL
{
    public class VentasDAL
    {
        public int id_orden { get; set; }
        public DateTime fecha { get; set; }
        public int monto { get; set; }

        public VentasDAL(int id_orden, DateTime fecha, int monto)
        {
            this.id_orden = id_orden;
            this.fecha = fecha;
            this.monto = monto;
        }

        public VentasDAL()
        {
        }

        public DataTable GetAllVentas()
        {
            DataTable tabla = new DataTable();

            OracleConnection conexion = BD.Conexion;

            //select de donde sacaran los datos
            string st = "SELECT * FROM orden";


            OracleCommand cm = new OracleCommand(st, conexion);//Invocar la conexión
            cm.CommandType = CommandType.Text;
            OracleDataAdapter sqlDataAdapter = new OracleDataAdapter(cm);

            sqlDataAdapter.Fill(tabla);
            return tabla;

        }

    }
}




/*
    public List<VentasDAL> ObtenerTodos()
        {
            OracleConnection cnxDB = BD.Conexion;

            string st = "SELECT * FROM orden";
            OracleCommand cm = new OracleCommand(st, cnxDB);
            cm.CommandType = CommandType.Text;
            List<VentasDAL> listado = new List<VentasDAL>();
            using (DataTable dt = new DataTable())
            {
                OracleDataAdapter da = new OracleDataAdapter(cm);
                da.Fill(dt);


                int i = 0;

                while (i < dt.Rows.Count)
                {
                    int id_producto = Int32.Parse(dt.Rows[i]["id_producto"].ToString());
                    int id_tipo = Int32.Parse(dt.Rows[i]["id_tipo"].ToString());
                    int precio = Int32.Parse(dt.Rows[i]["precio"].ToString());
                    string modelo = dt.Rows[i]["modelo"].ToString();
                    int stock = Int32.Parse(dt.Rows[i]["stock"].ToString());

                    VentasDAL ventaDAL = new VentasDAL();
                    ventaDAL.id_orden = id_orden;
                    ventaDAL.fecha = fecha;
                    ventaDAL.monto = monto;

                    listado.Add(ventaDAL);
                    i++;
                }
                return listado;
            }
        }
     */
