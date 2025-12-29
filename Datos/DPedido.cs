using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DPedido
    {
        public string Registrar(Pedido pedido)
        {
            try
            {
                using (var context = new DBEFEntities())
                {
                    context.Pedido.Add(pedido);
                    context.SaveChanges();
                }
                return "Registrado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Modificar(Pedido pedido)
        {
            try
            {
                using (var context = new DBEFEntities())
                {
                    Pedido pedido_temp = context.Pedido.Find(pedido.idPedido);
                    pedido_temp.FechaPedido = pedido.FechaPedido;
                    pedido_temp.Estado = pedido.Estado;
                    context.SaveChanges();
                }
                return "Modificado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Eliminar(int idPedido)
        {
            try
            {
                using (var context = new DBEFEntities())
                {
                    Pedido pedido_temp = context.Pedido.Find(idPedido);
                    pedido_temp.Eliminado = true;
                    context.SaveChanges();
                }
                return "Eliminado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Pedido> ListarTodo()
        {
            List<Pedido> lista_pedidos = new List<Pedido>();
            try
            {
                using (var context = new DBEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    lista_pedidos = context.Pedido.Where(p => p.Eliminado.Equals(false)).ToList();
                }
                return lista_pedidos;
            }
            catch (Exception)
            {
                return lista_pedidos;
            }
        }

    }
}
