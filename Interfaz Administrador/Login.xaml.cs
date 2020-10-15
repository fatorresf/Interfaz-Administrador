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
using System.Data;
using Oracle.ManagedDataAccess.Client;




namespace Interfaz_Administrador
{
    /// <summary>
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

       

        private void BtnIngresar_Click(object sender, RoutedEventArgs e)
        {
            OracleConnection connection = new OracleConnection("DATA SOURCE = localhost/xe ; PASSWORD = felipe ;USER ID= system;");
            connection.Open();
            MessageBox.Show("Conectado");
            OracleCommand comando = new OracleCommand("SELECT * FROM Usuarios  where :nom_usu AND :clave", connection);

            comando.Parameters.Add(":nom_usu", txtUsuario.Text);
            comando.Parameters.Add(":clave", txtClave.Text);

            OracleDataReader lector = comando.ExecuteReader();

            if (lector.Read())
            {
                MainWindow inicio = new MainWindow();
                connection.Close();
                inicio.Show();

            }
            else {
                MessageBox.Show("No se pudo ingresar");
            }
            

        }
    }
}
