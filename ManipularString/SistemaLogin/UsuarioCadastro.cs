using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLogin
{
    static class UsuarioCadastro
    {
        private static Usuario[] usuarios =
        {
            new Usuario(){Nome="Gustavo", Senha="abc123"},
            new Usuario(){Nome="Henrique", Senha="123abc"},
            new Usuario(){Nome="Silva", Senha="a1b2c3"}
        };

        private static Usuario _usuarioLogado = null;

        public static Usuario UsuarioLogado
        {
            get { return _usuarioLogado; }
            private set { _usuarioLogado = value;}
        }

        public static bool Login(string nome, string senha)
        {
            foreach (Usuario usuario in usuarios)
            {
                if(usuario.Nome == nome && usuario.Senha == senha)
                {
                    UsuarioLogado = usuario;
                    return true;
                }
            }
            return false;
        }
    }
}
