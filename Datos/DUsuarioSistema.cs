using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DUsuarioSistema
    {
        public String Registrar(UsuarioSistema usuarioSistemas)
        {
            try
            {
                using (var context = new DBEFEntities())
                {
                    context.UsuarioSistema.Add(usuarioSistemas);
                    context.SaveChanges();
                }
                return "Registrado correctamente en la base de datos";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Modificar(UsuarioSistema usuarioSistemas)
        {
            try
            {
                using (var context = new DBEFEntities())
                {
                    UsuarioSistema usuarioSistemasTemp = context.UsuarioSistema.Find(usuarioSistemas.idUsuario);
                    usuarioSistemasTemp.Nombre = usuarioSistemas.Nombre;
                    usuarioSistemasTemp.Email = usuarioSistemas.Email;
                    usuarioSistemasTemp.Telefono = usuarioSistemas.Telefono;
                    context.SaveChanges();
                }
                return "Modificado correctamente en la base de datos";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Eliminar(int IdUsuario)
        {
            try
            {
                using (var context = new DBEFEntities())
                {
                    UsuarioSistema usuarioSistemasTemp = context.UsuarioSistema.Find(IdUsuario);
                    usuarioSistemasTemp.Activo = false;
                    context.SaveChanges();
                }
                return "Eliminado correctamente de la base de datos";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<UsuarioSistema> ListarTodo()
        {
            List<UsuarioSistema> usuarioSistemas = new List<UsuarioSistema>();
            try
            {
                using (var context = new DBEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    usuarioSistemas = context.UsuarioSistema.ToList();
                }
                return usuarioSistemas;
            }
            catch (Exception ex)
            {
                return usuarioSistemas;
            }
        }
    }
}
