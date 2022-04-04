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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AdminAlmacen.Vistas
{
    /// <summary>
    /// Lógica de interacción para home1.xaml
    /// </summary>
    public partial class home1 : UserControl
    {
        public home1()
        {
            InitializeComponent();
        }

        private void btn_lista_precios_Click(object sender, RoutedEventArgs e)
        {
            Window1 Listaprecios = new Window1();
            Listaprecios.Show();
        }

       
    }
}
