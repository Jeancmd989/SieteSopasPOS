using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class NRetroalimentacion
    {
        private DRetroalimentacion dRetroalimentacion = new DRetroalimentacion();

        public String Registrar(Retroalimentacion retroalimentacion)
        {
            return dRetroalimentacion.Registrar(retroalimentacion);
                }

        public String Modificar(Retroalimentacion retroalimentacion)
        {
            return dRetroalimentacion.Modificar(retroalimentacion);
        }

        public String Eliminar(int IdREtro)
        {

            return dRetroalimentacion.Eliminar(IdREtro);
        }

        public List<Retroalimentacion> ListarTodo()
        {
            return dRetroalimentacion.ListarTodo();
        }
    }
}
