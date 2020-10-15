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

namespace Interfaz_Administrador
{
    /// <summary>
    /// Lógica de interacción para Mesas.xaml
    /// </summary>
    public partial class Mesas : Window
    {
        public Mesas()
        {
            InitializeComponent();
        }

        private void BtnRegreso_Click(object sender, RoutedEventArgs e)
        {
            Recursos rc = new Recursos();
            rc.Show();
            this.Close();
        }
        //int x = 0;
        private void BtnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (txtId.Text.Trim() != "")
            {
                if (txtCapacidad.Text.Trim() != "")
                {
                    MesaBLL mesaBLL = new MesaBLL();

            /*        MessageBox.Show(mesaBLL.TomarDatosMesa(
                       // txtId.Text,
                        //txtCapacidad.Text,
                       // txtEstado.Text,
                        x));*/
                }
            }
        }
    }
}
