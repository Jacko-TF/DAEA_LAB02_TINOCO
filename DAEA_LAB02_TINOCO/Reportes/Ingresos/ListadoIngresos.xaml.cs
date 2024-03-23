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

namespace DAEA_LAB02_TINOCO.Reportes.Ingresos
{
    /// <summary>
    /// Lógica de interacción para ListadoIngresos.xaml
    /// </summary>
    public partial class ListadoIngresos : Window
    {
        public ListadoIngresos()
        {
            InitializeComponent();

            Ingreso ingreso1 = new Ingreso("12/02/24", "01235", "mañana", "juan", "laptop", 1254, "Camion");
            Ingreso ingreso2 = new Ingreso("13/02/24", "12456", "tarde", "pedro", "celular", 500, "Camioneta");
            Ingreso ingreso3 = new Ingreso("14/02/24", "98754", "noche", "nicolas", "mouse", 350, "Auto");

            List<Ingreso> Ingresos = new List<Ingreso>();
            Ingresos.Add(ingreso1);
            Ingresos.Add(ingreso2);
            Ingresos.Add(ingreso3);
            IngresosDataGrid.ItemsSource = Ingresos;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Ingreso ingreso1 = new Ingreso("12/02/24", "01235", "mañana", "juan", "laptop", 1254, "Camion");
            Ingreso ingreso2 = new Ingreso("13/02/24", "12456", "tarde", "pedro", "celular", 500, "Camioneta");
            Ingreso ingreso3 = new Ingreso("14/02/24", "98754", "noche", "nicolas", "mouse", 350, "Auto");

            List<Ingreso> Ingresos = new List<Ingreso>();
            Ingresos.Add(ingreso1);
            Ingresos.Add(ingreso2);
            Ingresos.Add(ingreso3);

            var newList = Ingresos.Where(ingreso => ingreso.conductor.StartsWith(txtConductor.Text));
            IngresosDataGrid.ItemsSource = Ingresos;

        }
    }
}
