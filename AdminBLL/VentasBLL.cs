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
    public class VentasBLL
    {
        public int id_ventas { get; set; }
        public DateTime fecha { get; set; }
        public int monto { get; set; }

        public VentasBLL() { }

        public VentasBLL(int id_ventas, DateTime fecha, int monto)
        {
            this.id_ventas = id_ventas; this.fecha = fecha; this.monto = monto;
        }

        public List<VentasBLL> TraerTodaV()
        {
            VentasDAL ventasDAL = new VentasDAL();
            DataTable tabla = ventasDAL.GetAllVentas();
            List<VentasBLL> listaVentas = new List<VentasBLL>();

            int i = 0;
            while ( i< tabla.Rows.Count)
            {
                int id_ventas = int.Parse(tabla.Rows[i]["idVentas"].ToString());
                DateTime fecha = DateTime.Parse(tabla.Rows[i]["fecha"].ToString());
                int monto = int.Parse(tabla.Rows[i]["monto"].ToString());



                VentasBLL objVentas = new VentasBLL();

                objVentas.id_ventas = id_ventas;
                objVentas.fecha = fecha;
                objVentas.monto = monto;

                listaVentas.Add(objVentas);
            }
            return listaVentas;
        }

    }
}
