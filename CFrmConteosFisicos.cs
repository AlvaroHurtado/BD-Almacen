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
    public partial class CFrmConteosFisicos : Form
    {
        private int? Id;

        public CFrmConteosFisicos(int? pId = null)
        {
            InitializeComponent();
            this.Id = pId;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void CFrmConteosFisicos_Load(object sender, EventArgs e)
        {
            if (Id != null)
            {
                DSAlmacenTableAdapters.ConteosFisicosTableAdapter ta = new DSAlmacenTableAdapters.ConteosFisicosTableAdapter();
                DSAlmacen.ConteosFisicosDataTable dt = ta.ObtenerConteo((int)Id);
                DSAlmacen.ConteosFisicosRow row = (DSAlmacen.ConteosFisicosRow)dt.Rows[0];
                nmrEmpleado.Value = row.id_Empleado;
                dtpFecha.Value = row.fechaConteo;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DSAlmacenTableAdapters.ConteosFisicosTableAdapter ta = new DSAlmacenTableAdapters.ConteosFisicosTableAdapter();

            if (Id == null)
            {
                ta.AgregarConteo((int)nmrEmpleado.Value, dtpFecha.Value);
            }
            else
            {
                ta.ActualizarConteo((int)Id, (int)nmrEmpleado.Value, dtpFecha.Value);
            }
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
