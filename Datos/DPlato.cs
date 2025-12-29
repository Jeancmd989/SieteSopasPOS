using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DPlato
    {
        public string Registrar(Plato plato)
        {
            try
            {
                using (var context = new DBEFEntities())
                {
                    context.Plato.Add(plato);
                    context.SaveChanges();
                }
                return "Registrado correctamente";
            }
            catch (Exception ex)
            {
                return "FALLO EN ALGO PS EN PLATOS";
            }
        }

        public string Modificar(Plato plato)
        {
            try
            {
                using (var context = new DBEFEntities())
                {
                    Plato plato_temp = context.Plato.Find(plato.idPlato);
                    plato_temp.Nombre = plato.Nombre;
                    plato_temp.Descripcion = plato.Descripcion;
                    plato_temp.Precio = plato.Precio;
                    plato_temp.Tipo = plato.Tipo;
                    context.SaveChanges();
                }
                return "Modificado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Eliminar(int idPlato)
        {
            try
            {
                using (var context = new DBEFEntities())
                {
                    Plato pedido_temp = context.Plato.Find(idPlato);
                    context.Plato.Remove(pedido_temp);
                    context.SaveChanges();
                }
                return "Eliminado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Plato> ListarTodo()
        {
            List<Plato> lista_pedidos = new List<Plato>();
            try
            {
                using (var context = new DBEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    lista_pedidos = context.Plato.ToList();
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
