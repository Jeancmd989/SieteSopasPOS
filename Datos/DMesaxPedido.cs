using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DMesaxPedido
    {
        public string Registrar(MesaxPedido mesaxpedido)
        {
            try
            {
                using (var context = new DBEFEntities())
                {
                    context.MesaxPedido.Add(mesaxpedido);
                    context.SaveChanges();
                }
                return "Registrado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Modificar(MesaxPedido mesaxpedido)
        {
            try
            {
                using (var context = new DBEFEntities())
                {
                    // Busca el registro usando las claves primarias
                    MesaxPedido mesaxpedido_temp = context.MesaxPedido
                        .FirstOrDefault(mpx => mpx.idPedido == mesaxpedido.idPedido && mpx.IdMesa == mesaxpedido.IdMesa);

                    // Si no se encuentra el registro, retorna un mensaje de error
                    if (mesaxpedido_temp == null)
                    {
                        return "Error: No se encontró el registro con las claves proporcionadas.";
                    }

                    // Actualiza solo los campos no-PK
                    mesaxpedido_temp.Capacidad = mesaxpedido.Capacidad;
                    mesaxpedido_temp.Estado = mesaxpedido.Estado;

                    context.SaveChanges();
                }
                return "Modificado correctamente";
            }
            catch (Exception ex)
            {
                return $"Error al modificar: {ex.Message}";
            }
        }

        public string Eliminar(int idMesa, int idPedido)
        {
            try
            {
                using (var context = new DBEFEntities())
                {
                    MesaxPedido mesaxpedido_temp = context.MesaxPedido.Find(idMesa, idPedido);
                    context.MesaxPedido.Remove(mesaxpedido_temp);
                    context.SaveChanges();
                }
                return "Eliminado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<MesaxPedido> Listar()
        {
            List<MesaxPedido> lista_mesaxpedidos = new List<MesaxPedido>();
            try
            {
                using (var context = new DBEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    lista_mesaxpedidos = context.MesaxPedido.ToList();
                }
                return lista_mesaxpedidos;
            }
            catch (Exception)
            {
                return lista_mesaxpedidos;
            }
        }
    }
}
