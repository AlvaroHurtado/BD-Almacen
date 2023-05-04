using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConexionAlmacen
{
    internal class CConexionAlmacen
    {
        string cadena = "Data Source = LAPTOP-IGD68BCG\\SQLEXPRESS02; Initial Catalog=Almacen; Integrated Security=True";
        public SqlConnection conectarBaseDatos = new SqlConnection();

        public CConexionAlmacen()
        {
            conectarBaseDatos.ConnectionString = cadena;

        }

        public void Abrir()
        {
            try
            {
                conectarBaseDatos.Open();
                Console.WriteLine("Conexión abierta");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir la base de datos " + ex.Message);
            }
        }

        public void Cerrar()
        {
            conectarBaseDatos.Close();
        }
    }
}
