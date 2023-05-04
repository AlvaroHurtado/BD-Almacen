using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConexionAlmacen
{
    public partial class CFrmProductos : Form
    {
        private int? Id;

        public CFrmProductos(int? pId = null)
        {
            InitializeComponent();
            this.Id = pId;
        }

        private void CFrmProductos_Load(object sender, EventArgs e)
        {
            if (Id != null)
            {
                DSAlmacenTableAdapters.ProductosTableAdapter ta = new DSAlmacenTableAdapters.ProductosTableAdapter();
                DSAlmacen.ProductosDataTable dt = ta.ObtenerProducto((int)Id);
                DSAlmacen.ProductosRow row = (DSAlmacen.ProductosRow)dt.Rows[0];
                txtProducto.Text = row.nombre;
                txtDescripcion.Text = row.descripcion;
                nmrDepartamento.Value = row.id_Departamento;
                nmrProveedor.Value = row.id_Departamento;
                nmrCosto.Value = row.costo;
                nmrPrecio.Value = row.precio;
                nmrStock.Value = row.stock;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DSAlmacenTableAdapters.ProductosTableAdapter ta = new DSAlmacenTableAdapters.ProductosTableAdapter();

            if (Id == null)
            {
                ta.AgregarProducto(txtProducto.Text, txtDescripcion.Text, (int)nmrDepartamento.Value, (int)nmrProveedor.Value, (int)nmrCosto.Value, (int)nmrPrecio.Value, (int)nmrStock.Value);
            }
            else
            {
                ta.ActualizarProducto((int)Id, txtProducto.Text, txtDescripcion.Text, (int)nmrDepartamento.Value, (int)nmrProveedor.Value, (int)nmrCosto.Value, (int)nmrPrecio.Value, (int)nmrStock.Value);
            }
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
