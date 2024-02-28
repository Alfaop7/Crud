using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud
{
    public class Base_Residencia
    {
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conexion = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=residencia;Data Source=DESKTOP-VM9");
            conexion.Open();

            return conexion;
        }
    }
}