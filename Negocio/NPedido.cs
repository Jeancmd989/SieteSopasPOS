using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class NPedido
    {
         
        private DPedido dPedido = new DPedido();
        public String Registrar(Pedido pedido)
        {
            return dPedido.Registrar(pedido);
        }
        public String Modificar(Pedido pedido)
        {
            return dPedido.Modificar(pedido);
        }
        public String Eliminar(int idPedido)
        {
            return dPedido.Eliminar(idPedido);
        }
        public List<Pedido> ListarTodo()
        {
            return dPedido.ListarTodo();
        }
    }
}
