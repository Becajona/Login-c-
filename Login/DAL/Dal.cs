using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Login.DAL
{
    public class Dal
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

        public bool ValidateUsuario(string usuario, string contrasena)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("ValidateUsuario", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Usuario", usuario);
                    command.Parameters.AddWithValue("@Contrasena", contrasena);

                    int usuarioValido = (int)command.ExecuteScalar();

                    return usuarioValido > 0;
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción según sea necesario (por ejemplo, registrarla o relanzarla)
                throw new Exception("Error al validar usuario", ex);
            }
        }






        public DataTable GetAllUsuarios()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Usuarios";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                dt.Load(rdr);
            }
            return dt;
        }

        
    }
}