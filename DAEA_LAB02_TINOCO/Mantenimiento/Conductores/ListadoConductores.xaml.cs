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

namespace DAEA_LAB02_TINOCO.Mantenimiento.Conductores
{
    /// <summary>
    /// Lógica de interacción para ListadoConductores.xaml
    /// </summary>
    public partial class ListadoConductores : Window
    {
        public ListadoConductores()
        {
            InitializeComponent();

            Conductor conductor1 = new Conductor("Juan", "001", "Auto");
            Conductor conductor2 = new Conductor("Pedro", "002", "Camion");
            Conductor conductor3 = new Conductor("Alberto", "003", "Camioneta");
            List<Conductor> conductores = new List<Conductor>();
            conductores.Add(conductor1);
            conductores.Add(conductor2);
            conductores.Add(conductor3);

            ConductoresDataGrid.ItemsSource = conductores;
        }
    }
}
