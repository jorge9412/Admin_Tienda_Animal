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
    /// Lógica de interacción para CrudUsuarios.xaml
    /// </summary>
    public partial class CrudUsuarios : Window
    {
        public CrudUsuarios()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
        public int id_login;
        public void Consultar()
        {
            conn.Open();
            SqlCommand com = new SqlCommand("Select * From LoginUser where id_login=" + id_login, conn);
            SqlDataReader rdr = com.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            rdr.Read();
            this.txt_usuario.Text = rdr["usuario"].ToString();
            this.txt_contraseña.Text = rdr["contraseña"].ToString();
            this.txt_nombres.Text = rdr["nombres"].ToString();
            this.txt_apellidos.Text = rdr["apellidos"].ToString();
            this.txt_cedula.Text = rdr["cedula"].ToString();
            this.txt_correo.Text = rdr["correo"].ToString();
            rdr.Close();

        }

        public void refresh()
        {
            conn.Open();
            SqlCommand com = new SqlCommand("Select * From LoginUser", conn);
            SqlDataReader rdr = com.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            rdr.Read();
            rdr.Close();

        }
        private void btn_actualizar(object sender, RoutedEventArgs e)
        {
            try
            {
                conn.Open();
                string query = "UPDATE LoginUser SET usuario ='" + txt_usuario.Text + "',contraseña='" + txt_contraseña.Text +
                    "',nombres='" + txt_nombres.Text + "',apellidos='" + txt_apellidos.Text + "',cedula='" + txt_cedula.Text +
                    "',correo='" + txt_correo.Text + "' where id_login=" + id_login;

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                this.refresh();
                MessageBox.Show("Usuario editado correctamente");
                conn.Close();
                Close();

            }
            catch (Exception ex )
            {

                MessageBox.Show(ex.ToString());
            }
            
        }

        private void btn_cerrar(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
