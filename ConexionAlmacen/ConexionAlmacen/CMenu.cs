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
    public partial class CMenu : Form
    {
        public CMenu()
        {
            InitializeComponent();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            CEmpleados pantalla = new CEmpleados();
            pantalla.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            CProductos pantalla = new CProductos();
            pantalla.Show();
            this.Close();
        }

        private void btnConteo_Click(object sender, EventArgs e)
        {
            CConteoFisico pantalla = new CConteoFisico();
            pantalla.Show();
            this.Close();
        }

        private void CMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
