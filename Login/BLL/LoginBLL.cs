using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Login.DAL;

namespace Login.BLL
{
    public class LoginBLL
    {


        private UsuarioDAL usuarioDAL = new UsuarioDAL();

        public bool ValidateUsuario(string usuario, string contrasena)
        {
            // Llamar al método ValidateUsuario de UsuarioDAL para verificar las credenciales
            bool isValid = usuarioDAL.ValidateUsuario(usuario, contrasena);

            return isValid; // Devolver el resultado de la validación
        }
    }
}