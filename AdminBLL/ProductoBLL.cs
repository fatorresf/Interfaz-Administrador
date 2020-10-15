using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using AdminDAL;

namespace AdminBLL
{
    public class ProductoBLL
    {


        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public int Stock { get; set; }
        public int IdTipoProducto { get; set; }
        public DateTime FechaIngreso { get; set; }

        public ProductoBLL() { }

        public ProductoBLL(int idProducto, string nombre, int stock, int idTipoProducto, DateTime fechaIngreso)
        {
            this.IdProducto = idProducto;
            this.Nombre = nombre;
            this.Stock = stock;
            this.IdTipoProducto = idTipoProducto;
            this.FechaIngreso = fechaIngreso;

        }
        public List<ProductoBLL> TraerTodosPro()
        {
            ProductoDAL productoDAL = new ProductoDAL();
            DataTable tabla = productoDAL.GetAllProductoe();
            List<ProductoBLL> listProductos = new List<ProductoBLL>();

            int i = 0;
            while (i < tabla.Rows.Count)
            {
                int idProducto = int.Parse(tabla.Rows[i]["IdInsumos"].ToString());
                string nombre = tabla.Rows[i]["Nombre"].ToString();
                int stock = int.Parse(tabla.Rows[i]["Stock"].ToString());
                int idTipoProducto = int.Parse(tabla.Rows[i]["IdTipoProducto"].ToString());
                DateTime fechaIngreso = DateTime.Parse(tabla.Rows[i]["Fecha"].ToString());

                ProductoBLL objProducto = new ProductoBLL();

                objProducto.IdProducto = idProducto;
                objProducto.Nombre = nombre;
                objProducto.Stock = stock;
                objProducto.IdTipoProducto = idTipoProducto;
                objProducto.FechaIngreso = fechaIngreso;




                listProductos.Add(objProducto);
                i++;
            }
            return listProductos;
        }
    }
    }