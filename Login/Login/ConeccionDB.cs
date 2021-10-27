using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Login
{
    public class ConeccionDB
    {
        readonly string cadena = "Data Source=.;Initial Catalog=Login;Integrated Security=True";


        public bool ValidarUsuario(Usuario user)
        {
            bool esUsuarioValido = false;

            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT 1 FROM USUARIOS WHERE USUARIO = @User AND CLAVE = @Clave; ");
                using(SqlConnection _conexion =new SqlConnection(cadena))
                {
                    _conexion.Open();
                    using (SqlCommand comando = new SqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@User", SqlDbType.NVarChar, 50).Value = user.CodigoUsuario;
                        comando.Parameters.Add("@Clave", SqlDbType.NVarChar, 50).Value = user.Clave;
                        esUsuarioValido = Convert.ToBoolean(comando.ExecuteScalar());
                    }
                }

            }
            catch (Exception ex)
            {

                
            }
            return esUsuarioValido;
        }

    }
}
