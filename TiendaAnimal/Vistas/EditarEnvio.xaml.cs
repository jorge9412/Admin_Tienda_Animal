using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;
using System.Windows;
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
    /// Lógica de interacción para EditarEnvio.xaml
    /// </summary>
    public partial class EditarEnvio : Window
    {
        public EditarEnvio()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
        public int id_envio;
        public void Consultar()
        {
            conn.Open();
            SqlCommand com = new SqlCommand("Select * From Cliente_Envio where id_envio=" + id_envio, conn);
            SqlDataReader rdr = com.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            rdr.Read();
            this.txt_nombre_cliente.Text = rdr["nombre_cliente"].ToString();
            this.txt_apellidos_cliente.Text = rdr["apellido_cliente"].ToString();
            this.txt_cedula_cliente.Text = rdr["cedula_cliente"].ToString();
            this.txt_celular_cliente.Text = rdr["celular_cliente"].ToString();
            this.txt_correo_cliente.Text = rdr["correo_cliente"].ToString();
            this.txt_direccion_cliente.Text = rdr["direccion_cliente"].ToString();
            this.txt_fecha.Text = rdr["fecha_pedido"].ToString();
            this.txt_nombre_destinatario.Text = rdr["nombres_destinatario"].ToString();
            this.txt_direccion_destinatario.Text = rdr["direccion_destinatario"].ToString();
            this.txt_ciudad_destino.Text = rdr["ciudad_destino"].ToString();
            this.txt_ciudad_origen_envio.Text = rdr["ciudad_origen_envio"].ToString();
            this.txt_precio_envio.Text = rdr["precio_envio"].ToString();
            this.txt_descripcion_envio.Text = rdr["descripcion_envio"].ToString();
            rdr.Close();
        }
        private void btn_guardar_cambios(object sender, RoutedEventArgs e)
        {
            try
            {
                conn.Open();
                string query = "UPDATE Cliente_Envio SET nombre_cliente ='" + txt_nombre_cliente.Text + "',apellido_cliente='" + txt_apellidos_cliente.Text  + "',cedula_cliente='" + txt_cedula_cliente.Text +
                    "',celular_cliente='" + txt_celular_cliente.Text + "',correo_cliente='" + txt_correo_cliente.Text + "',direccion_cliente='" + txt_direccion_cliente.Text +
                    "',nombres_destinatario='" + txt_nombre_destinatario.Text + "',direccion_destinatario='" + txt_direccion_destinatario.Text + "',ciudad_destino='" + txt_ciudad_destino.Text +
                    "',ciudad_origen_envio='" + txt_ciudad_origen_envio.Text + "',precio_envio='" + txt_precio_envio.Text +
                    "',descripcion_envio='" + txt_descripcion_envio.Text + "'   where id_envio=" + id_envio;

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Envio editado correctamente");
                conn.Close();
                Usuarios user = new Usuarios();
                user.CargarDatos();
                Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void btn_cerrar_envio(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
