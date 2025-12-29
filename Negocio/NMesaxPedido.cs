using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NMesaxPedido
    {
        private DMesaxPedido dMesaxPedido = new DMesaxPedido();
        public String Registrar(MesaxPedido mesaxPedido)
        {
            return dMesaxPedido.Registrar(mesaxPedido);
        }

        public String Modificar(MesaxPedido mesaxPedido)
        {
            return dMesaxPedido.Modificar(mesaxPedido);
        }

        public string Eliminar(int idMesa, int idPedido)
        {
            return dMesaxPedido.Eliminar(idMesa, idPedido);
        }

        public List<MesaxPedido> ListarTodo()
        {
            return dMesaxPedido.Listar();
        }
    }
}
