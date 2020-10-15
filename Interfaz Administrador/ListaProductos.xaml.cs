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
using AdminBLL;
using System.Collections.Generic;


namespace Interfaz_Administrador
{
    /// <summary>
    /// Lógica de interacción para ListaProductos.xaml
    /// </summary>
    public partial class ListaProductos : Window
    {
        public ListaProductos()
        {
            InitializeComponent();
        }

        private void BtnListarP1_Click(object sender, RoutedEventArgs e)
        {
            ProductoBLL objProducto = new ProductoBLL();

            List<ProductoBLL> producto = objProducto.TraerTodosPro();

            dtgProductos.ItemsSource = producto;

        }

        private void BtnRegresar_Click(object sender, RoutedEventArgs e)
        {
            Productos pro = new Productos();
            pro.Show();
            this.Close();
        }

        
    }
}
