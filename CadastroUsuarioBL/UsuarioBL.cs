using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastroUsuarioDAL;

namespace CadastroUsuarioBL
{
    public class UsuarioBL
    {
        public bool Login(string usuario, string senha)
        {
            UsuarioDAL usuarioDAL = new UsuarioDAL();

            return usuarioDAL.Login(usuario, senha);
        }
    }
}
