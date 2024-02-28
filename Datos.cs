using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud
{
    internal class Datos
    {
        public static int Agregarpersona(Usuarios usuarios)
        {
            int retorna = 0;
            using (SqlConnection conexion = Base_Residencia.ObtenerConexion()
                {
                string query = "insert into Usuarios (PrimerNombre,SegundoNombre,ApellidoPaterno,ApellidoMaterno,NumTelefonico,Correo,NumeroCasa,DuenoArrendatario) values(" + Usuarios.PrimerNombre + "," + Usuarios.SegundoNombre + "," + Usuarios.ApellidoPaterno + "," + Usuarios.ApellidoMaterno"," + Usuarios.NumTelefonico + "," + Usuarios.Correo + ","Usuarios.NumCasa + "," + Usuarios.DuenoArrendatario + ");
        SqlCommand comando = new SqlCommand(query, conexion);
                return = comando.ExecuteNonQuery();
            }

            return retorna;
            }
    }
}
