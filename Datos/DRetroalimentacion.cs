using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DRetroalimentacion
    {
        public String Registrar(Retroalimentacion retroalimentacion)
        {
            try
            {
                using (var context = new DBEFEntities())
                {
                    context.Retroalimentacion.Add(retroalimentacion);
                    context.SaveChanges();
                }
                return "Registrado correctamente en la base de datos";
            }
            catch (Exception ex)
            {
                // Captura el mensaje interno si existe
                string error = ex.InnerException != null
                    ? ex.InnerException.InnerException?.Message ?? ex.InnerException.Message
                    : ex.Message;

                return $"Error: {error}";
            }
        }

        public String Modificar(Retroalimentacion retroalimentacion)
        {
            try
            {
                using (var context = new DBEFEntities())
                {
                    Retroalimentacion retroalimentacionTemp = context.Retroalimentacion.Find(retroalimentacion.idRetroalimentacion);
                    retroalimentacionTemp.Comentario = retroalimentacion.Comentario;
                    retroalimentacionTemp.TipoComentario = retroalimentacion.TipoComentario;
                    retroalimentacionTemp.Puntuacion = retroalimentacion.Puntuacion;
                    retroalimentacionTemp.Fecha = retroalimentacion.Fecha;
                    context.SaveChanges();
                }
                return "Modificado correctamente en la base de datos";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Eliminar(int IdRetro)
        {
            try
            {
                using (var context = new DBEFEntities())
                {
                    Retroalimentacion retroalimentacionTemp = context.Retroalimentacion.Find(IdRetro);
                    context.Retroalimentacion.Remove(retroalimentacionTemp);
                    context.SaveChanges();
                }
                return "Eliminado correctamente de la base de datos";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Retroalimentacion> ListarTodo()
        {
            List<Retroalimentacion> retroalimentaciones = new List<Retroalimentacion>();
            try
            {
                using (var context = new DBEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    retroalimentaciones = context.Retroalimentacion.ToList();
                }
                return retroalimentaciones;
            }
            catch (Exception ex)
            {
                return retroalimentaciones;
            }
        }
    }
}
