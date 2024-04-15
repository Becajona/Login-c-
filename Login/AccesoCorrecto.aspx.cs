using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace Login
{
    public partial class AccesoCorrecto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Llamada al método para cargar y mostrar los datos en el GridView
                CargarDatosUsuarios();
            }

        }
        private void CargarDatosUsuarios()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

                string query = "SELECT * FROM Usuarios";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    // Enlazar los datos al GridView
                    GridViewUsuarios.DataSource = dataTable;
                    GridViewUsuarios.DataBind();
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores (puedes implementar la lógica necesaria aquí)
                // Por ejemplo, mostrar un mensaje de error o registrar el error en un archivo de registro
                Response.Write("Error al cargar los datos: " + ex.Message);
            }
        }
    }
}