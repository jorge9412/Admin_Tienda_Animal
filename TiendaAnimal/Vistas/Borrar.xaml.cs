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
    /// Lógica de interacción para Borrar.xaml
    /// </summary>
    public partial class Borrar : Window
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
        public int id_login;
        public Borrar()
        {
            InitializeComponent();
        }

        
        public void Consultar()
        {
            conn.Open();
            SqlCommand com = new SqlCommand("Select * From LoginUser WHERE id_login=" + id_login, conn);
            SqlDataReader rdr = com.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            rdr.Read();
            this.lblEliminar.Content = rdr["usuario"].ToString();
            rdr.Close();

        }

        private void btn_borrar(object sender, RoutedEventArgs e)
        {
            try
            {
                conn.Open();
                string query = "DELETE LoginUser WHERE id_login=" + id_login;
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuario eliminado correctamente");
                conn.Close();
                Close();

            }
            catch (Exception ex)
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
