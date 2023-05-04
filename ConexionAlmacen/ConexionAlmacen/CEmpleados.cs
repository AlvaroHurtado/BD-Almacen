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
    public partial class CEmpleados : Form
    {
        public CEmpleados()
        {
            InitializeComponent();
        }

        private void CEmpleados_Load(object sender, EventArgs e)
        {
            CConexionAlmacen conexion = new CConexionAlmacen();
            conexion.Abrir();

            string cadena = "EXEC ConsultarEmpleados";
            SqlCommand comando = new SqlCommand(cadena, conexion.conectarBaseDatos);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
            dataGridView1.AutoResizeColumn(0);
            dataGridView1.AutoResizeColumn(1);
            dataGridView1.AutoResizeColumn(2);
            dataGridView1.AutoResizeColumn(3);
            dataGridView1.AutoResizeColumn(4);
            dataGridView1.AutoResizeColumn(5);
            //dataGridView1.Columns[0].Visible = false;
        }

        private void Refresh()
        {
            CConexionAlmacen conexion = new CConexionAlmacen();
            conexion.Abrir();

            string cadena = "EXEC ConsultarEmpleados";
            SqlCommand comando = new SqlCommand(cadena, conexion.conectarBaseDatos);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
            dataGridView1.AutoResizeColumn(0);
            dataGridView1.AutoResizeColumn(1);
            dataGridView1.AutoResizeColumn(2);
            dataGridView1.AutoResizeColumn(3);
            dataGridView1.AutoResizeColumn(4);
            dataGridView1.AutoResizeColumn(5);
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CFrmEmpleados cFrmEmpleados = new CFrmEmpleados();
            cFrmEmpleados.ShowDialog();
            Refresh();
        }

        private int? GetId()
        {
            try
            {
                return int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                CFrmEmpleados frmEmpleados = new CFrmEmpleados(id);
                frmEmpleados.ShowDialog();
                Refresh();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                DSAlmacenTableAdapters.EmpleadosTableAdapter ta = new DSAlmacenTableAdapters.EmpleadosTableAdapter();
                ta.BorrarEmpleado((int)id);
                Refresh();
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            CMenu pantalla = new CMenu();
            pantalla.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
