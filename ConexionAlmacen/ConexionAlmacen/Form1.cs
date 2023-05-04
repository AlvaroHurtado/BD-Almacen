using System.Data.SqlClient;
using System.Data;

namespace ConexionAlmacen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CConexionAlmacen conexion = new CConexionAlmacen();
            conexion.Abrir();

            string cadena = "EXEC ConsultarEmpleados";
            SqlCommand comando = new SqlCommand(cadena, conexion.conectarBaseDatos);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
            dataGridView1.AutoResizeColumn(1);
            dataGridView1.AutoResizeColumn(2);
            dataGridView1.AutoResizeColumn(3);
            dataGridView1.AutoResizeColumn(4);
            dataGridView1.AutoResizeColumn(5);
            dataGridView1.AutoResizeColumn(6);
            dataGridView1.Columns[0].Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}