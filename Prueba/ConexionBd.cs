using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba
{
    class ConexionBd
    {
        string strConexion = " Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=prueba;Integrated Security=True";
        SqlConnection connection = new SqlConnection();
        public ConexionBd()
        {
            connection.ConnectionString = strConexion;
        }
        public void conectar()
        {
            try
            {
                connection.Open();
                MessageBox.Show("Conectado");

            } catch (Exception e)
            {
                MessageBox.Show("error" + e.Message);
            }
            finally
            {
                MessageBox.Show("Desconectado");
            }
        }
    }
   
}
