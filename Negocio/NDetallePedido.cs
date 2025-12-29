using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NDetallePedido
    {
        private DDetallePedido dDetallePedido = new DDetallePedido();
        public String Registrar(DetallePedido detallePedido)
        {
            return dDetallePedido.Registrar(detallePedido);
        }

        public String Modificar(DetallePedido detallePedido)
        {
            return dDetallePedido.Modificar(detallePedido);
        }

        public String Eliminar(int idDetallePedido)
        {
            return dDetallePedido.Eliminar(idDetallePedido);
        }

        public List<DetallePedido> ListarTodo()
        {
            return dDetallePedido.ListarTodo();
        }
    }
}
