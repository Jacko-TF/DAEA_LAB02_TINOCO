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
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txtusername.Text == "jacko" && txtpassword.Text == "123456")
            {
                Menu menu = new();
                menu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Credenciales invalidas");
            }
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Gracias por usar la aplicación");
            Close();
        }
    }
}
