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
    /// Lógica de interacción para RegistroEnvio.xaml
    /// </summary>
    public partial class RegistroEnvio : Window
    {
        public RegistroEnvio()
        {
            InitializeComponent();
        }

        private void btn_guardar_envio_Click(object sender, RoutedEventArgs e)
        {
            bool validar;
            validar = validarCampos();
            if (validar == true)
            {
                try
                {
                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
                    string query = "INSERT INTO Cliente_Envio(nombre_cliente,apellido_cliente,cedula_cliente,celular_cliente,correo_cliente,direccion_cliente,nombres_destinatario,direccion_destinatario,ciudad_destino,descripcion_envio,ciudad_origen_envio,precio_envio,cedula_destinatario) " +
                        "VALUES('" + txt_nombre_cliente.Text + "','" + txt_apellidos_cliente.Text + "','" + txt_cedula_cliente.Text + "','" + 
                        txt_celular_cliente.Text + "','"+ txt_correo_cliente.Text + "','" + txt_direccion_cliente.Text + "','" + txt_nombre_destinatario.Text + 
                        "','" + txt_direccion_destinatario.Text + "','" + txt_ciudad_destino.Text + "','" + txt_descripcion_envio.Text + "','" + 
                        txt_ciudad_origen_envio.Text + "','" + txt_precio_envio.Text + "','" + txt_cedula_destinatario.Text + "')";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Usuario creado correctamente");
                    conn.Close();
                    LimpiarCampos();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Llenar todos los campos");
            }
        }

        private void btn_cerrar_envio_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        public void LimpiarCampos()
        {
            txt_nombre_cliente.Text = "";
            txt_apellidos_cliente.Text = "";
            txt_cedula_cliente.Text = "";
            txt_celular_cliente.Text = "";
            txt_correo_cliente.Text = "";
            txt_direccion_cliente.Text = "";
            txt_nombre_destinatario.Text = "";
            txt_direccion_destinatario.Text = "";
            txt_ciudad_destino.Text = "";
            txt_ciudad_origen_envio.Text = "";
            txt_precio_envio.Text = "";
            txt_cedula_destinatario.Text = "";
            txt_descripcion_envio.Text = "";
        }
        public bool validarCampos()
        {
            bool validar;
            if (txt_nombre_cliente.Text == string.Empty || txt_apellidos_cliente.Text == string.Empty || txt_cedula_cliente.Text == string.Empty || txt_celular_cliente.Text == string.Empty ||
                txt_correo_cliente.Text == string.Empty || txt_direccion_cliente.Text == string.Empty || txt_nombre_destinatario.Text == string.Empty || txt_direccion_destinatario.Text == string.Empty ||
                txt_ciudad_destino.Text == string.Empty || txt_descripcion_envio.Text == string.Empty || txt_ciudad_origen_envio.Text == string.Empty || txt_precio_envio.Text == string.Empty || txt_cedula_destinatario.Text == string.Empty)
            {
                validar = false;
            }
            else
            {
                validar = true;

            }
            return validar;
        }
    }
}
