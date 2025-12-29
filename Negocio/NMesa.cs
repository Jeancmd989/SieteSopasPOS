using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NMesa
    {
        private DMesa dMesa = new DMesa();
        public String Registrar(Mesa mesa)
        {
            return dMesa.Registrar(mesa);
        }

        public String Modificar(Mesa mesa)
        {
            return dMesa.Modificar(mesa);
        }

        public String Eliminar(int idMesa)
        {
            return dMesa.Eliminar(idMesa);
        }

        public List<Mesa> ListarTodo()
        {
            return dMesa.ListarTodo();
        }
    }
}
