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
    /// Lógica de interacción para Usuarios.xaml
    /// </summary>
    public partial class Usuarios : Window
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void BtnRegreso_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }

        private void BtnListar_Click(object sender, RoutedEventArgs e)
        {
            ListarU lu = new ListarU();
            lu.Show();
            this.Close();
        }

        private void BtnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            if (txtCargo.Text == "")
            {
                MessageBox.Show("Cargo esta vacio");
            }
            
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Nombre esta vacio");
            }
            if (txtRut.Text == "")
            {
                MessageBox.Show("Rut esta vacio");
            }
            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Usuario esta vacio");
            }

        }

    }
}
