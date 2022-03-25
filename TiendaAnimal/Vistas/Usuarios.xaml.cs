using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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
using TiendaAnimal.Vistas;

namespace AdminAlmacen.Vistas
{
    /// <summary>
    /// Lógica de interacción para Usuarios.xaml
    /// </summary>
    public partial class Usuarios : UserControl
    {
        public Usuarios()
        {
            InitializeComponent();
            CargarDatos();
        }
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
        public void CargarDatos()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select id_login, usuario, nombres,apellidos,cedula,correo from LoginUser", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridDatos.ItemsSource = dt.DefaultView;
            conn.Close();
        }

        private void irRegistroClik(object sender, RoutedEventArgs e)
        {            
            Registrar general = new Registrar();
            general.Show();
        }

        private void txt_buscar_click(object sender, TextChangedEventArgs e)
        {
            try
            {
                //SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM LoginUser WHERE usuario like ('%" + txt_buscar.Text + "%') or nombres like ('%" + txt_buscar.Text + "%')" +
                                                "or apellidos like ('%" + txt_buscar.Text + "%')or cedula like ('%" + txt_buscar.Text + "%')" +
                                                "or correo like ('%" + txt_buscar.Text + "%')", conn);                
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                GridDatos.ItemsSource = dt.DefaultView;
                conn.Close();
            }            
            catch (Exception)
            {
                MessageBox.Show("Sin datos");
            }
        }
        private void Editar(object sender, RoutedEventArgs e)
        {
            
            try
            {
                int id = (int)((Button)sender).CommandParameter;
                CrudUsuarios ventana = new CrudUsuarios();
                ventana.id_login = id;
                ventana.Consultar();
                ventana.Show();
                //FrameUsuarios.= ventana;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            
      
        }

        private void Eliminar(object sender, RoutedEventArgs e)
        {
            int id = (int)((Button)sender).CommandParameter;
            Borrar borrar = new Borrar();
            borrar.id_login = id;
            borrar.Consultar();
            borrar.Show();
        }
    }
}
