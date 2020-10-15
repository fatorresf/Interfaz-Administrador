using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;


namespace AdminDAL
{
    public class ProductoDAL
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public int Stock { get; set; }
        public int IdTipoProducto { get; set; }
        public DateTime FechaIngreso { get; set; }

        public ProductoDAL() { }

        public ProductoDAL(int idProducto, string nombre, int stock, int idTipoProducto, DateTime fechaIngreso)
        {
            IdProducto = idProducto;
            Nombre = nombre;
            Stock = stock;
            IdTipoProducto = idTipoProducto;
            FechaIngreso = fechaIngreso;

        }


        public bool RegistrarProducto(int idProducto, string nombre, int stock, int idTipoProducto, DateTime fechaIngreso)
        {
            OracleConnection conexion = BD.Conexion;
            string st = "INSERT INTO Insumos VALUES (@rut, @nombres, @apellidos, @fechanacimiento, @idsexo, @idE)";

            OracleCommand cm = new OracleCommand(st, conexion);
            cm.CommandType = CommandType.Text;

            cm.Parameters.Add("@rut", idProducto);
            cm.Parameters.Add("@nombres", nombre);
            cm.Parameters.Add("@apellidos", stock);
            cm.Parameters.Add("@fechanacimiento", idTipoProducto);
            cm.Parameters.Add("@idsexo", fechaIngreso);

            conexion.Open();
            cm.ExecuteNonQuery();
            conexion.Close();

            return true;
        }
        public bool ActualizarProducto(string rut, string nombres, string apellidos, string fechanacimiento, int idSexo, int idE)
        {



            OracleConnection conexion = BD.Conexion;
            string st = "UPDATE Insumos set  Nombres = @nombres,Apellidos = @apellidos,FechaNacimiento = @fechanacimiento,IdSexo = @idsexo,IdEstadoCivil = @idE where RutCliente = @rut";

            OracleCommand cm = new OracleCommand(st, conexion);//Invocar la conexión
            cm.CommandType = CommandType.Text;


       
            cm.Parameters.Add("@nombres", nombres);
            cm.Parameters.Add("@apellidos", apellidos);
            cm.Parameters.Add("@fechanacimiento", fechanacimiento);
            cm.Parameters.Add("@idsexo", idSexo);
            OracleDataAdapter sqlDataAdapter = new OracleDataAdapter(cm);
            conexion.Open();
            cm.ExecuteNonQuery();
            conexion.Close();
            return true;



        }
        public DataTable GetByNombreP(string _nombres)
        {
            using (OracleConnection cnxDB = BD.Conexion)
            {
                string st = "SELECT RutCliente, Nombres, Apellidos,FechaNacimiento,IdSexo,IdEstadoCivil FROM Cliente WHERE Nombres LIKE '%'+@nombres+'%'";
                OracleCommand cm = new OracleCommand(st, cnxDB);
                cm.CommandType = CommandType.Text;
                cm.Parameters.Add("@nombres", _nombres);

                using (DataTable dt = new DataTable())
                {
                    OracleDataAdapter da = new OracleDataAdapter(cm);
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        public bool DeleteProducto(string rut)
        {

            OracleConnection conexion = BD.Conexion;
            string st = "Delete FROM Insumos WHERE idInsumo = @idInsumo";


            OracleCommand cm = new OracleCommand(st, conexion);//Invocar la conexión
            cm.CommandType = CommandType.Text;


            cm.Parameters.Add("@rut", rut);
            OracleDataAdapter sqlDataAdapter = new OracleDataAdapter(cm);
            conexion.Open();
            cm.ExecuteNonQuery();
            conexion.Close();
            return true;


        }

        //
        public DataTable GetAllProductoe()
        {
            DataTable tabla = new DataTable();

            OracleConnection conexion = BD.Conexion;

            string st = "SELECT * FROM insumo";

            OracleCommand cm = new OracleCommand(st, conexion);//Invocar la conexión
            cm.CommandType = CommandType.Text;
            OracleDataAdapter sqlDataAdapter = new OracleDataAdapter(cm);

            sqlDataAdapter.Fill(tabla);
            return tabla;

        }

     

    }
}
