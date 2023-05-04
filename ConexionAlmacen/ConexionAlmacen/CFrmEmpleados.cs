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
    public partial class CFrmEmpleados : Form
    {
        private int? Id;

        public CFrmEmpleados(int? pId = null)
        {
            InitializeComponent();
            this.Id = pId;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DSAlmacenTableAdapters.EmpleadosTableAdapter ta = new DSAlmacenTableAdapters.EmpleadosTableAdapter();

            if (Id == null)
            {
                ta.AgregarEmpleado(txtNombres.Text, txtApellidoP.Text, txtApellidoM.Text, (int)nmrEdad.Value, txtTelefono.Text, txtCorreo.Text);
            }
            else
            {
                ta.ActualizarEmpleado(txtNombres.Text, txtApellidoP.Text, txtApellidoM.Text, (int)nmrEdad.Value, txtTelefono.Text, txtCorreo.Text, (int)Id);
            }
            this.Close();
        }

        private void CFrmEmpleados_Load(object sender, EventArgs e)
        {
            if (Id != null)
            {
                DSAlmacenTableAdapters.EmpleadosTableAdapter ta = new DSAlmacenTableAdapters.EmpleadosTableAdapter();
                DSAlmacen.EmpleadosDataTable dt = ta.ObtenerEmpleado((int)Id);
                DSAlmacen.EmpleadosRow row = (DSAlmacen.EmpleadosRow)dt.Rows[0];
                txtNombres.Text = row.nombres;
                txtApellidoP.Text = row.apellidoPaterno;
                txtApellidoM.Text = row.apellidoMaterno;
                nmrEdad.Value = row.edad;
                txtTelefono.Text = row.telefono;
                txtCorreo.Text = row.correoElectronico;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
