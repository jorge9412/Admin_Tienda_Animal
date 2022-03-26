using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Media.Animation;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AdminAlmacen.Vistas
{
    /// <summary>
    /// Lógica de interacción para envio.xaml
    /// </summary>
    public partial class envio : Window
    {
        public envio()
        {
            InitializeComponent();
            animacionLogo();

        }

        public void animacionLogo()
        {
            var fadeAnimation = new DoubleAnimation();
            fadeAnimation.From = 1;
            fadeAnimation.To = 0;
            fadeAnimation.AutoReverse = true;
            img_logo.BeginAnimation(Image.OpacityProperty, fadeAnimation);
        }

        private void TBShow(object sender, RoutedEventArgs e)
        {
            GridContent.Opacity = 0.8;

        }

        private void TBHide(object sender, RoutedEventArgs e)
        {
            GridContent.Opacity = 1;
        }

        private void PreviewMouseLeftBotton(object sender, MouseButtonEventArgs e)
        {
            BtnShowHide.IsChecked = false;
        }

        private void Minimizar(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Cerrar(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void usuariosClik(object sender, RoutedEventArgs e)
        {
            DataContext = new Usuarios();
        }
        private void enviosClik(object sender, RoutedEventArgs e)
        {
            DataContext = new Content_ListaEnvios();
        }

        private void BtnInfo_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new Acercade();
        }

    }
}
