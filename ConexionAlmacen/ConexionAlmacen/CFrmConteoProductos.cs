using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConexionAlmacen
{
    public partial class CFrmConteoProductos : Form
    {
        private int? Id;

        public CFrmConteoProductos(int? pId = null)
        {
            InitializeComponent();
            this.Id = pId;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DSAlmacenTableAdapters.ConteosFisicos_ProductosTableAdapter ta = new DSAlmacenTableAdapters.ConteosFisicos_ProductosTableAdapter();

            if (Id == null)
            {
                ta.AgregarConteoProductos((int)nmrConteo.Value, (int)nmrProducto.Value, (int)nmrCantidad.Value);
            }
            else
            {
                ta.ActualizarConteoProductos((int)Id, (int)nmrProducto.Value, (int)nmrCantidad.Value);
            }
            this.Close();
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
        }

        private void nmrEmpleado_ValueChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CFrmConteoProductos_Load(object sender, EventArgs e)
        {
            if (Id != null)
            {
                DSAlmacenTableAdapters.ConteosFisicos_ProductosTableAdapter ta = new DSAlmacenTableAdapters.ConteosFisicos_ProductosTableAdapter();
                DSAlmacen.ConteosFisicos_ProductosDataTable dt = ta.ObtenerConteoProductos((int)Id);
                DSAlmacen.ConteosFisicos_ProductosRow row = (DSAlmacen.ConteosFisicos_ProductosRow)dt.Rows[0];
                nmrProducto.Value = row.id_Producto;
                nmrCantidad.Value = row.cantidadExistente;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void nmrConteo_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
