using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DMesa
    {
        public String Registrar(Mesa mesa)
        {
            try
            {
                using (var context = new DBEFEntities())
                {
                    context.Mesa.Add(mesa);
                    context.SaveChanges();
                }
                return "Registrado correctamente en la base de datos";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Modificar(Mesa mesa)
        {
            try
            {
                using (var context = new DBEFEntities())
                {
                    Mesa mesaTemp = context.Mesa.Find(mesa.IdMesa);
                    mesaTemp.Numero = mesa.Numero;
                    context.SaveChanges();
                }
                return "Modificado correctamente en la base de datos";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Eliminar(int idMesa)
        {
            try
            {   
                using (var context = new DBEFEntities())
                {
                    Mesa mesaTemp = context.Mesa.Find(idMesa);
                    context.Mesa.Remove(mesaTemp);
                    context.SaveChanges();
                }
                return "Eliminado correctamente de la base de datos";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Mesa> ListarTodo()
        {
            try
            {
                using (var context = new DBEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    return context.Mesa.ToList();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
