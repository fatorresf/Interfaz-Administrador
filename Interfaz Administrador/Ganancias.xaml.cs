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
    /// Lógica de interacción para Ganancias.xaml
    /// </summary>
    public partial class Ganancias : Window
    {
        public Ganancias()
        {
            InitializeComponent();
        }

        private void BtnRegresar_Click(object sender, RoutedEventArgs e)
        {
            Finanzas fz = new Finanzas();
            fz.Show();
            this.Close();
        }
    }
}
