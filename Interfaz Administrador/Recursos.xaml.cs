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
    /// Lógica de interacción para Recursos.xaml
    /// </summary>
    public partial class Recursos : Window
    {
        public Recursos()
        {
            InitializeComponent();
        }

        private void BtnRegreso_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }

        private void BtnProducto_Click(object sender, RoutedEventArgs e)
        {
            Productos pr = new Productos();
            pr.Show();
            this.Close();
        }

        private void BtnClientes_Click(object sender, RoutedEventArgs e)
        {
            Clientes cl = new Clientes();
            cl.Show();
            this.Close();
        }

        private void BtnMesas_Click(object sender, RoutedEventArgs e)
        {
            Mesas ms = new Mesas();
            ms.Show();
            this.Close();
        }
    }
}
