using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AdminDAL;

namespace AdminBLL
{
    public class MesaBLL
    {
        public int id_messa { get; set; }
        public int id_estado { get; set; }
        public int capacidad { get; set; }

        public MesaBLL() {}

        public MesaBLL(int id_messa, int id_estado, int capacidad)
        {
            this.id_messa = id_messa; this.id_estado = id_estado; this.capacidad = capacidad;
        }

        public string TomarDatosMesa(int id_messa, int id_estado, int capacidad)
        {
            MesaDAL objClienteDAL = new MesaDAL();

            bool insert = objClienteDAL.RegistrarMesa(id_messa, id_estado, capacidad);

            string a;

            if (insert == true)
            {
                a = "La Mesa ha sido registrada";
                return a;
            }
            else
            {
                a = "Hubo un error al registrar";
                return a;
            }

        }

        public List<MesaBLL> ObtenerPorId(string _nombres)
        {
            MesaDAL mesaDAL = new MesaDAL();
            DataTable tablaMesa = mesaDAL.GetById(_nombres);

            List<MesaBLL> listado = new List<MesaBLL>();

            int i = 0;

            while (i < tablaMesa.Rows.Count)
            {
                int id_mesa = int.Parse(tablaMesa.Rows[i]["id_mesa"].ToString());
                int id_estado = int.Parse(tablaMesa.Rows[i]["Id_Estado"].ToString());
                int capacidad = int.Parse(tablaMesa.Rows[i]["capacidad"].ToString());


                MesaBLL mesaBLL = new MesaBLL(id_mesa, id_estado, capacidad);

                listado.Add(mesaBLL);

                i++;
            }
            return listado;
        }

    }
}
