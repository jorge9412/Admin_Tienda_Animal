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

namespace AdminAlmacen.Vistas
{
    /// <summary>
    /// Lógica de interacción para Content_ListaEnvios.xaml
    /// </summary>
    public partial class Content_ListaEnvios : UserControl
    {
        public Content_ListaEnvios()
        {
            InitializeComponent();
            CargarDatosEnvios();
        }

        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
        void CargarDatosEnvios()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select id_envio,nombre_cliente, apellido_cliente,cedula_cliente" +
                                            ",celular_cliente,nombres_destinatario,fecha_pedido," +
                                            "direccion_destinatario ,ciudad_destino, descripcion_envio, precio_envio from Cliente_Envio", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridDatosEnvios.AllowDrop = true;
            GridDatosEnvios.ItemsSource = dt.DefaultView;
            conn.Close();

        }

        private void irRegistroEnvioClik(object sender, RoutedEventArgs e)
        {
            RegistroEnvio registroEnvio = new RegistroEnvio();
            registroEnvio.Show();
        }
        private void txt_buscar_envio_click(object sender, TextChangedEventArgs e)
        {
            try
            {
                conn.Open();
                
                SqlCommand cmd = new SqlCommand("SELECT * FROM Cliente_Envio WHERE nombre_cliente like ('%" + txt_buscar_envio.Text + "%')or apellido_cliente like ('%" + txt_buscar_envio.Text + "%')" +
                                                "or cedula_cliente like ('%" + txt_buscar_envio.Text + "%')or cedula_destinatario like ('%" + txt_buscar_envio.Text + "%')" +
                                                "or descripcion_envio like ('%" + txt_buscar_envio.Text + "%')", conn);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                GridDatosEnvios.ItemsSource = dt.DefaultView;
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Sin datos");
            }
        }

        private void Eliminar(object sender, RoutedEventArgs e)
        {

            int id = (int)((Button)sender).CommandParameter;
            BorrrarListaEnvio borrar = new BorrrarListaEnvio();
            borrar.id_envio = id;
            borrar.Consultar();
            borrar.ShowDialog();
            CargarDatosEnvios();
        }

        private void Editar(object sender, RoutedEventArgs e)
        {

            int id = (int)((Button)sender).CommandParameter;
            EditarEnvio editar = new EditarEnvio();
            editar.id_envio = id;
            editar.Consultar();
            editar.ShowDialog();
            CargarDatosEnvios();

        }
    }
}
