using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DDetallePedido
    {
        public String Registrar(DetallePedido detallePedido)
        {
            try
            {
                using (var context = new DBEFEntities())
                {
                    context.DetallePedido.Add(detallePedido);
                    context.SaveChanges();
                }
                return "Registrado correctamente en la base de datos";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Modificar(DetallePedido detallePedido)
        {
            try
            {
                using (var context = new DBEFEntities())
                {
                    DetallePedido detallePedidoTemp = context.DetallePedido.Find(detallePedido.idDetallePedido);
                    detallePedidoTemp.Observaciones = detallePedido.Observaciones;
                    context.SaveChanges();
                }
                return "Modificado correctamente en la base de datos";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Eliminar(int idDetallePedido)
        {
            try
            {
                using (var context = new DBEFEntities())
                {
                    DetallePedido detallePedidoTemp = context.DetallePedido.Find(idDetallePedido);
                    context.DetallePedido.Remove(detallePedidoTemp);
                    context.SaveChanges();
                }
                return "Eliminado correctamente de la base de datos";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<DetallePedido> ListarTodo()
        {
            List<DetallePedido> detallePedidos = new List<DetallePedido>();
            try
            {
                using (var context = new DBEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    detallePedidos = context.DetallePedido.ToList();
                }
                return detallePedidos;
            }
            catch (Exception ex)
            {
                return detallePedidos;
            }
        }
    }
}
