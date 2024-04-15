using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDAL;

namespace CapaBLL
{
    public class BLLLogin
    {
        private CapaDAL usuarioDAL = new CapaDAL();

        public DataTable GetAllUsuarios()
        {
            return usuarioDAL.GetAllUsuarios();
        }

        public bool ValidateUsuario(string usuario, string contrasena)
        {
            int count = usuarioDAL.ValidateUsuario(usuario, contrasena);
            return count > 0;
        }

    }
}
