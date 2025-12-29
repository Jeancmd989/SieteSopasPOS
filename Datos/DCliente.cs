using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DCliente
    {
        public String Registrar(Cliente cliente)
        {
            try
            {
                using (var context = new DBEFEntities())
                {
                    context.Cliente.Add(cliente);
                    context.SaveChanges();
                }
                return "Registrado correctamente en la base de datos";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Modificar(Cliente cliente)
        {
            try
            {
                using (var context = new DBEFEntities())
                {
                    Cliente clienteTemp = context.Cliente.Find(cliente.idCliente);
                    clienteTemp.DniCliente = cliente.DniCliente;
                    clienteTemp.Nombre = cliente.Nombre;
                    clienteTemp.Telefono = cliente.Telefono;
                    clienteTemp.Correo = cliente.Correo;
                    context.SaveChanges();
                }
                return "Modificado correctamente en la base de datos";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Eliminar(int idCliente)
        {
            try
            {
                using (var context = new DBEFEntities())
                {
                    Cliente clienteTemp = context.Cliente.Find(idCliente);
                    clienteTemp.Activo = false;
                    context.SaveChanges();
                }
                return "Eliminado correctamente de la base de datos";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Cliente> ListarTodo()
        {
            try
            {
                using (var context = new DBEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    return context.Cliente.ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al listar clientes: " + ex.Message);
                return null;
            }
        }

    }
}
