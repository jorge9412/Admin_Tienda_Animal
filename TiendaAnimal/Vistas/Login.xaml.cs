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

namespace TiendaAnimal.Vistas
{
    /// <summary>
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
            
        }

        private void btn_ingresar_Click(object sender, RoutedEventArgs e)
        {
            if (txt_user.Text == string.Empty || txt_pass.Password == string.Empty)
            {
                MessageBox.Show("Llenar campos");
            }
            else
            {
                try
                {
                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
                    conn.Open();
                    using (SqlCommand command = conn.CreateCommand())
                    {
                        SqlCommand cmd = new SqlCommand("SELECT usuario, contraseña FROM LoginUser WHERE usuario = '" + txt_user.Text + "' AND contraseña ='" + txt_pass.Password + "'", conn);
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            this.Hide();
                            tablaGeneral general = new tablaGeneral();
                            general.Show();
                        }
                        else
                        {
                            MessageBox.Show("Datos incorrectos");
                        }
                        dr.Close();
                        conn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }  
        }
    }
}
