using DAEA_LAB02_TINOCO.Mantenimiento.Conductores;
using DAEA_LAB02_TINOCO.Reportes.Ingresos;
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

namespace DAEA_LAB02_TINOCO
{
    /// <summary>
    /// Lógica de interacción para Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void OpIngresos_Click(object sender, RoutedEventArgs e)
        {
            OperacionesIngresos operacionesIngresos = new OperacionesIngresos();
            operacionesIngresos.ShowDialog();
        }

        private void MaConductores_Click(object sender, RoutedEventArgs e)
        {
            ListadoConductores listadoConductores = new ListadoConductores();   
            listadoConductores.ShowDialog();
        }

        private void ReIngresos_Click(object sender, RoutedEventArgs e)
        {
            ListadoIngresos listadoIngresos = new ListadoIngresos();
            listadoIngresos.ShowDialog();
        }

        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            RegistroConductores registroConductores = new RegistroConductores();    
            registroConductores.ShowDialog();
        }

        private void ListBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {
            ListadoConductores listadoConductores = new ListadoConductores();
            listadoConductores.ShowDialog();
        }
    }
}
