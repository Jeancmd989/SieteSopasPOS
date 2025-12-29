using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Negocio;

namespace Presentacion
{
    public partial class FormReporte : Form
    {
        private NPedido pedidoNegocio = new NPedido();
        private NRetroalimentacion retroNegocio = new NRetroalimentacion();

        public FormReporte()
        {
            InitializeComponent();
            CargarFechaPedidos(pedidoNegocio.ListarTodo());
            MostrarRetro(retroNegocio.ListarTodo());
        }
        private void CargarFechaPedidos(List<Pedido> pedidos)
        {
            cbFecha.DataSource = pedidos;
            cbFecha.DisplayMember = "FechaPedido";
            cbFecha.ValueMember = "FechaPedido";
        }
        private void MostrarPedido(List<Pedido> pedidos)
        {
            dgPedido.DataSource = null;
            dgPedido.DataSource = pedidos;
        }
        private void MostrarRetro(List<Retroalimentacion> retros)
        {
            dgRetro.DataSource = null;
            dgRetro.DataSource = retros;
        }

        private void btnBuscarFecha_Click(object sender, EventArgs e)
        {
            List<Pedido> tempPedido = new List<Pedido>();
            List<Pedido> pedidos = pedidoNegocio.ListarTodo();
            foreach (Pedido pedido in pedidos)
            {
                if (pedidos != null)
                {
                    if (pedido.FechaPedido.ToString() == cbFecha.SelectedValue.ToString())
                    {
                        tempPedido.Add(pedido);
                    }
                }
            }
            if (tempPedido.Count > 0)
            {
                MostrarPedido(tempPedido);
            }
            else
            {
                MessageBox.Show("No se encontraron pedidos para la fecha seleccionada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btBuscarEstado_Click(object sender, EventArgs e)
        {
            List<Pedido> tempPedido = new List<Pedido>();
            List<Pedido> pedidos = pedidoNegocio.ListarTodo();
            foreach (Pedido pedido in pedidos)
            {
                if (pedidos != null)
                {
                    if (pedido.Estado == cbEstadoPedidoEntregado.Text)
                    {
                        tempPedido.Add(pedido);
                    }
                }
            }
            if (tempPedido.Count > 0)
            {
                MostrarPedido(tempPedido);
            }
            else
            {
                MessageBox.Show("No se encontraron pedidos para el estado seleccionado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btBuscarTipoC_Click(object sender, EventArgs e)
        {
            List<Retroalimentacion> retroFiltradas = new List<Retroalimentacion>();
            List<Retroalimentacion> retroalimentaciones = retroNegocio.ListarTodo();

            foreach (Retroalimentacion retro in retroalimentaciones)
            {
                if (retroalimentaciones != null)
                {
                    if (retro.TipoComentario == cbTipoC.Text)
                    {
                        retroFiltradas.Add(retro);
                    }
                }
            }

            if (retroFiltradas.Count > 0)
            {
                MostrarRetro(retroNegocio.ListarTodo());
            }
            else
            {
                MessageBox.Show("No se encontraron comentarios para el tipo seleccionado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btBuscarPuntuacion_Click(object sender, EventArgs e)
        {
            List<Retroalimentacion> retroFiltradas = new List<Retroalimentacion>();
            List<Retroalimentacion> retroalimentaciones = retroNegocio.ListarTodo();

            foreach (Retroalimentacion retro in retroalimentaciones)
            {
                if (retroalimentaciones != null)
                {
                    if (retro.Puntuacion == int.Parse(cbPuntuacion.Text))
                    {
                        retroFiltradas.Add(retro);
                    }
                }
            }

            if (retroFiltradas.Count > 0)
            {
                MostrarRetro(retroNegocio.ListarTodo());
            }
            else
            {
                MessageBox.Show("No se encontraron comentarios con la puntuación seleccionada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
