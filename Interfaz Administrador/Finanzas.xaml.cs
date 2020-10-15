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
    /// Lógica de interacción para Finanzas.xaml
    /// </summary>
    public partial class Finanzas : Window
    {
        public Finanzas()
        {
            InitializeComponent();
        }

 

        private void BtnRegreso_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }

        private void BtnVentas_Click(object sender, RoutedEventArgs e)
        {
            Ventas vt = new Ventas();
            vt.Show();
            this.Close();
        }

        private void BtnGanancias_Click(object sender, RoutedEventArgs e)
        {
            Ganancias gn = new Ganancias();
            gn.Show();
            this.Close();
        }
    }
}
