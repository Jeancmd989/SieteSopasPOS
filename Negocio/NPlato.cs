using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class NPlato
    {
        private DPlato dplato = new DPlato();
        public string Registrar(Plato plato)
        {
            return dplato.Registrar(plato);
        }

        public string Modificar(Plato plato)
        {
            return dplato.Modificar(plato);
        }

        public string Eliminar(int idPlato)
        {
            return dplato.Eliminar(idPlato);
        }

        public List<Plato> ListarTodo()
        {
            return dplato.ListarTodo();
        }
    }
}
