using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class NUsuario
    {
        private DUsuarioSistema nUsuarioSistema = new DUsuarioSistema();

        public String Registrar(UsuarioSistema usuarioSistemas)
        {
            return nUsuarioSistema.Registrar(usuarioSistemas);
        }

        public String Modificar(UsuarioSistema usuarioSistemas)
        {
            return nUsuarioSistema.Modificar(usuarioSistemas);
        }

        public String Eliminar(int IdUsuario)
        {

            return nUsuarioSistema.Eliminar(IdUsuario);
        }

        public List<UsuarioSistema> ListarTodo()
        {
            return nUsuarioSistema.ListarTodo();
        }
    }
}
