using Microsoft.VisualBasic.Logging;
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
    public partial class CConteoFisico : Form
    {
        public CConteoFisico()
        {
            InitializeComponent();
        }

        private void CConteoFisico_Load(object sender, EventArgs e)
        {
            CConexionAlmacen conexion = new CConexionAlmacen();
            conexion.Abrir();

            string cadena = "EXEC ConsultarConteos";
            SqlCommand comando = new SqlCommand(cadena, conexion.conectarBaseDatos);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvConteo.DataSource = tabla;
            dgvConteo.AutoResizeColumn(0);
            dgvConteo.AutoResizeColumn(1);
            dgvConteo.AutoResizeColumn(2);
        }

        private void Refresh()
        {
            CConexionAlmacen conexion = new CConexionAlmacen();
            conexion.Abrir();

            string cadena = "EXEC ConsultarConteos";
            SqlCommand comando = new SqlCommand(cadena, conexion.conectarBaseDatos);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvConteo.DataSource = tabla;
            dgvConteo.AutoResizeColumn(0);
            dgvConteo.AutoResizeColumn(1);
            dgvConteo.AutoResizeColumn(2);
            dgvConteo.AutoResizeColumn(3);
        }

        private void RefreshProduct()
        {
            CConexionAlmacen conexion = new CConexionAlmacen();
            conexion.Abrir();

            int? id = GetId();

            string cadena2 = "EXEC ObtenerConteoProductos @id = @id_Conteo";
            SqlCommand comando2 = new SqlCommand(cadena2, conexion.conectarBaseDatos);
            comando2.Parameters.AddWithValue("@id_Conteo", id);
            SqlDataAdapter adaptador2 = new SqlDataAdapter(comando2);
            DataTable tabla2 = new DataTable();
            adaptador2.Fill(tabla2);
            dgvProductos.DataSource = tabla2;
            dgvProductos.AutoResizeColumn(0);
            dgvProductos.AutoResizeColumn(1);
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            CMenu pantalla = new CMenu();
            pantalla.Show();
            this.Close();
        }

        private void dgvConteo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private int? GetId()
        {
            try
            {
                return int.Parse(dgvConteo.Rows[dgvConteo.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {


            CConexionAlmacen conexion = new CConexionAlmacen();
            conexion.Abrir();

            int? id = GetId();

            string cadena2 = "EXEC ObtenerConteoProductos @id = @id_Conteo";
            SqlCommand comando2 = new SqlCommand(cadena2, conexion.conectarBaseDatos);
            comando2.Parameters.AddWithValue("@id_Conteo", id);
            SqlDataAdapter adaptador2 = new SqlDataAdapter(comando2);
            DataTable tabla2 = new DataTable();
            adaptador2.Fill(tabla2);
            dgvProductos.DataSource = tabla2;
            dgvProductos.AutoResizeColumn(0);
            dgvProductos.AutoResizeColumn(1);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CFrmConteosFisicos cFrmConteosFisicos = new CFrmConteosFisicos();
            cFrmConteosFisicos.ShowDialog();
            Refresh();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                CFrmConteosFisicos cFrmConteosFisicos = new CFrmConteosFisicos(id);
                cFrmConteosFisicos.ShowDialog();
                Refresh();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                DSAlmacenTableAdapters.ConteosFisicosTableAdapter ta = new DSAlmacenTableAdapters.ConteosFisicosTableAdapter();
                ta.BorrarConteo((int)id);
                Refresh();
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            CFrmConteoProductos cFrmConteoProductos = new CFrmConteoProductos();
            cFrmConteoProductos.ShowDialog();
            RefreshProduct();
        }

        private void btnEditarProducto_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                CFrmConteoProductos cFrmConteoProductos = new CFrmConteoProductos(id);
                cFrmConteoProductos.ShowDialog();
                RefreshProduct();
            }
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                DSAlmacenTableAdapters.ConteosFisicos_ProductosTableAdapter ta = new DSAlmacenTableAdapters.ConteosFisicos_ProductosTableAdapter();
                ta.BorrarConteoProductos((int)id);
                RefreshProduct();
            }
        }

        private void btnRefrescarProductos_Click(object sender, EventArgs e)
        {
            RefreshProduct();
        }
    }
}
