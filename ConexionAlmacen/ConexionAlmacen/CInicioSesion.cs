using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConexionAlmacen
{
    public partial class CInicioSesion : Form
    {
        SqlConnection conexion = new SqlConnection("Data Source = LAPTOP-IGD68BCG\\SQLEXPRESS02; Initial Catalog=Almacen; Integrated Security=True");
        string mensaje = "El usuario o contraseña son incorrectos o está inyectando código SQL";
        string leyenda = "Error Dectectado En El Ingreso De Los Datos";
        MessageBoxButtons botones = MessageBoxButtons.OK;
        public CInicioSesion()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CInicioSesion_Load(object sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand login = new SqlCommand("SELECT usuario, contrasenia FROM Usuarios WHERE usuario = @vusuario AND contrasenia = @vcontrasenia", conexion);
            login.Parameters.AddWithValue("@vusuario", txtUsuario.Text);
            login.Parameters.AddWithValue("@vcontrasenia", txtContrasena.Text);

            SqlDataReader lector = login.ExecuteReader();

            if (lector.Read())
            {
                conexion.Close();
                CMenu pantalla = new CMenu();
                pantalla.Show();
            }
            else
            {
                conexion.Close();
                MessageBox.Show(mensaje, leyenda, botones);
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            TextBox currentContainer = ((TextBox)sender);
            int caretPosition = currentContainer.SelectionStart;

            currentContainer.Text = currentContainer.Text.ToUpper();
            currentContainer.SelectionStart = caretPosition++;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
