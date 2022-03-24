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
            this.txt_nombres.Text = rdr["usuario"].ToString();
            this.txt_nombres.Text = rdr["contraseña"].ToString();
            this.txt_nombres.Text = rdr["nombres"].ToString();
            this.txt_nombres.Text = rdr["apellidos"].ToString();
            this.txt_nombres.Text = rdr["cedula"].ToString();
            this.txt_nombres.Text = rdr["correo"].ToString();
            rdr.Close();

        }

        private void btn_cerrar_resgitro_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_guardar_usuario_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
