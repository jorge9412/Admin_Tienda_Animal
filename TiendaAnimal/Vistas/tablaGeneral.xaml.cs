using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TiendaAnimal.Vistas
{
    /// <summary>
    /// Lógica de interacción para tablaGeneral.xaml
    /// </summary>
    public partial class tablaGeneral : Window
    {
        public tablaGeneral()
        {
            InitializeComponent();


        }

        private void irLogin(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            this.Close();
            login.Show();
        }

        private void irRegistro(object sender, RoutedEventArgs e)
        {
            Registrar login = new Registrar();
            this.Close();
            login.Show();

        }

    }
}
