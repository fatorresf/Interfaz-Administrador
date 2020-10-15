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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Interfaz_Administrador
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

   
        private void BtnRecursos_Click(object sender, RoutedEventArgs e)
        {
            Recursos rcs = new Recursos();
            rcs.Show();
            this.Close();

        }

        private void BtnCerrar_Click(object sender, RoutedEventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Close();
        }

        private void BtnUsuarios_Click(object sender, RoutedEventArgs e)
        {
            Usuarios us = new Usuarios();
            us.Show();
            this.Close();
        }

        private void BtnFinanzas_Click(object sender, RoutedEventArgs e)
        {
            Finanzas fnz = new Finanzas();
            fnz.Show();
            this.Close();
        }
    }
}
