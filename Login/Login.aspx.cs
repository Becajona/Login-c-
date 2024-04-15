using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

using Login.DAL;
using Login.Model;
using Login.BLL;

namespace Login
{
    public partial class Login : System.Web.UI.Page
    {
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;

            LoginBLL usuarioBLL = new LoginBLL();

            if (usuarioBLL.ValidateUsuario(usuario, contrasena))
            {
                Response.Redirect("AccesoCorrecto.aspx");
            }
            else
            {
                lblError.Text = "Usuario o contraseña incorrectos";
            }
        }
        


    }
}
