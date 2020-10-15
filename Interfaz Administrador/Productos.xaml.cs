using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Interfaz_Administrador
{
    /// <summary>
    /// Lógica de interacción para Productos.xaml
    /// </summary>
    public partial class Productos : Window
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void BtnRegresar_Click(object sender, RoutedEventArgs e)
        {
            Recursos rc = new Recursos();
            rc.Show();
            this.Close();
        }

        private void BtnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (txtCant.Text == "")
            {
                MessageBox.Show("Falta Cantidad");
            }
            if (txtFecha.Text == "")
            {
                MessageBox.Show("Falta Fecha");
            }
            if (txtNomE.Text == "")
            {
                MessageBox.Show("Falta Nombre");
            }
            if (txtTipo.Text == "")
            {
                MessageBox.Show("Falta Tipo");
            }
        }

        private void BtnListarP_Click(object sender, RoutedEventArgs e)
        {
            ListaProductos lp = new ListaProductos();
            lp.Show();
            this.Close();
        }
    }
}
