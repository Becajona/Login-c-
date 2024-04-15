using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace CapaDAL
{
    public class DAL
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

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

        public int ValidateUsuario(string usuario, string contrasena)
        {
            int count = 0;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT COUNT(*) FROM Usuarios WHERE usuario = @usuario AND contrasena = @contrasena";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@contrasena", contrasena);
                object result = cmd.ExecuteScalar();
                count = result == null ? 0 : Convert.ToInt32(result);
            }
            return count;
        }
    }
}
