﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using AdminAlmacen.Vistas;

namespace TiendaAnimal.Vistas
{
    /// <summary>
    /// Lógica de interacción para Registrar.xaml
    /// </summary>
    public partial class Registrar : Window
    {
        public Registrar()
        {
            InitializeComponent();
        }       
        private void btn_guardar_usuario_Click(object sender, RoutedEventArgs e)
        {
            if (txt_usuario.Text == string.Empty || txt_contraseña.Text == string.Empty ||
                txt_nombres.Text == string.Empty || txt_apellidos.Text == string.Empty ||
                txt_cedula.Text == string.Empty || txt_correo.Text == string.Empty)
            {
                MessageBox.Show("Debes llenar los campos");
            }
            else
            {
                try

                {
                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
                    string query = "INSERT INTO LoginUser(usuario,contraseña,nombres,apellidos,cedula,correo) " +
                        "VALUES('" + txt_usuario.Text + "','" + txt_contraseña.Text + "','" + txt_nombres.Text + "','" +
                                     txt_apellidos.Text + "','" + txt_cedula.Text + "','" + txt_correo.Text + "')";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Usuario creado correctamente");
                    conn.Close();
                    Usuarios user = new Usuarios();
                    user.CargarDatos();
                    LimpiarCampos();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
            }
        }
        public void LimpiarCampos()
        {
            txt_nombres.Text = "";
            txt_apellidos.Text = "";
            txt_cedula.Text = "";
            txt_correo.Text = "";
            txt_usuario.Text = "";
            txt_cedula.Text = "";
            txt_contraseña.Text = "";
        }

        private void btn_cerrar_resgitro_Click(object sender, RoutedEventArgs e)
        {
            Close();           
        }

    }
}
