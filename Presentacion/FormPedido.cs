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
    public partial class FormPedido : Form
    {
        private NMesa nMesa = new NMesa();
        private NCliente nCliente = new NCliente();
        private NPedido nPedido = new NPedido();
        private NPlato nPlato = new NPlato();
        private NDetallePedido nDetallePedido = new NDetallePedido();
        private int idUsuarioSistema;
        private NMesaxPedido nMesaxPedido = new NMesaxPedido();

        public FormPedido(int idUsuarioSistema)
        {
            this.idUsuarioSistema = idUsuarioSistema;
            InitializeComponent();
            MostrarMesa(nMesa.ListarTodo());
            MostrarCliente(nCliente.ListarTodo());
            MostrarPedidos(nPedido.ListarTodo());
            MostrarPlato(nPlato.ListarTodo());
            MostrarDPedidos(nPedido.ListarTodo());
            MostrarDetallePedido(nDetallePedido.ListarTodo());
            MostrarPedidosMesa(nPedido.ListarTodo());
            MostrarMesaPedido(nMesa.ListarTodo());
            MostrarMesaxPedido(nMesaxPedido.ListarTodo());
        }
        /*PEDIDO*/
        private void MostrarMesa(List<Mesa> mesas)
        {
            cbMesa.DataSource = mesas;
            cbMesa.DisplayMember = "Numero";
            cbMesa.ValueMember = "Numero";
        }
        private void MostrarCliente(List<Cliente> clientes)
        {
            cbDniCliente.DataSource = clientes;
            cbDniCliente.DisplayMember = "DniCliente";
            cbDniCliente.ValueMember = "idCliente";
        }
        private void MostrarPlato(List<Plato> platos)
        {
            cbPlato.DataSource = platos;
            cbPlato.DisplayMember = "Nombre";
            cbPlato.ValueMember = "idPlato";
        }
        /*DETALLE PEDIDO*/
        private void MostrarDPedidos(List<Pedido> pedidos)
        {
            cbDpedido.DataSource = pedidos;
            cbDpedido.DisplayMember = "idPedido";
            cbDpedido.ValueMember = "idPedido";
        }
        private void MostrarPedidos(List<Pedido> pedidos)
        {
            dgPedidos.DataSource = null;
            if (pedidos.Count == 0)
            {
                return;
            }
            else
            {
                dgPedidos.DataSource = pedidos;
            }
        }
        private void MostrarDetallePedido(List<DetallePedido> detallePedidos)
        {
            dgDetallePedido.DataSource = null;
            if (detallePedidos.Count == 0)
            {
                return;
            }
            else
            {
                dgDetallePedido.DataSource = detallePedidos;
            }
        }
        private void btnAgregarPlato_Click(object sender, EventArgs e)
        {
            FormPlato formPLato = new FormPlato();
            formPLato.Show();
        }

        private void btnRegistrarPedido_Click(object sender, EventArgs e)
        {
            if (dtFechaPedido.Text.Trim() == "" || cbEstadoPedido.Text.Trim() == "" || cbDniCliente.Text.Trim() == "" || cbMesa.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese todos los valores solicitados");
                return;
            }
            int idCliente = Convert.ToInt32(cbDniCliente.SelectedValue);

            Pedido pedido = new Pedido()
            {
                FechaPedido=dtFechaPedido.Value.Date,
                Estado=cbEstadoPedido.Text,
                idCliente= idCliente,
                idUsuario = idUsuarioSistema,
                Eliminado = false
                
            };
            String mess = nPedido.Registrar(pedido);
            MessageBox.Show($"{mess}", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MostrarPedidos(nPedido.ListarTodo());

        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dtFechaPedido.Text.Trim() == "" || cbEstadoPedido.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese todos los valores solicitados");
                return;
            }
            if (dgPedidos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecioe un pedido");
                return;
            }
            int idPedido = int.Parse(dgPedidos.SelectedRows[0].Cells[0].Value.ToString());
            Pedido pedido = new Pedido()
            {
                idPedido = idPedido,
                FechaPedido = dtFechaPedido.Value.Date,
                Estado = cbEstadoPedido.Text,
            };
            String mess = nPedido.Modificar(pedido);
            MessageBox.Show(mess);
            MostrarPedidos(nPedido.ListarTodo());
        }

        private void btnEliminarPedido_Click(object sender, EventArgs e)
        {
            if (dgPedidos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione un pedido");
                return;
            }
            int idPedido = int.Parse(dgPedidos.SelectedRows[0].Cells[0].Value.ToString());
            String mess = nPedido.Eliminar(idPedido);
            MessageBox.Show(mess);
            MostrarPedidos(nPedido.ListarTodo());

        }

        private void btnSalirPedido_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btRegistrarDP_Click(object sender, EventArgs e)
        {
            if (tbObservaciones.Text == "" || cbDpedido.Text == "" || cbPlato.Text == "")
            {
                MessageBox.Show("Ingrese todos los datos que se estan soliciando");
                return;
            }
            int idPlato = Convert.ToInt32(cbPlato.SelectedValue);

            DetallePedido detallePedido = new DetallePedido()
            {
                Observaciones = tbObservaciones.Text,
                idPedido = int.Parse(cbDpedido.Text),
                idPlato = idPlato
            };
            string mess = nDetallePedido.Registrar(detallePedido);
            MessageBox.Show($"{mess}", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MostrarDetallePedido(nDetallePedido.ListarTodo());
        }

        private void btModificarDP_Click(object sender, EventArgs e)
        {

        }

        private void btEliminiarDP_Click(object sender, EventArgs e)
        {
            if (dgDetallePedido.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecioe un detalle del pedido");
                return;
            }
            int idDetallePedido = int.Parse(dgDetallePedido.SelectedRows[0].Cells[0].Value.ToString());
            String mess = nDetallePedido.Eliminar(idDetallePedido);
            MessageBox.Show(mess);
            MostrarDetallePedido(nDetallePedido.ListarTodo());
        }

        private void btSalirDP_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            MostrarDPedidos(nPedido.ListarTodo());
            MostrarPlato(nPlato.ListarTodo());
            MostrarDetallePedido(nDetallePedido.ListarTodo());
            MostrarPedidosMesa(nPedido.ListarTodo());
        }


        private void MostrarPedidosMesa(List<Pedido> pedidos)
        {
            cbPedidoM.DataSource = pedidos;
            cbPedidoM.DisplayMember = "idPedido";
            cbPedidoM.ValueMember = "idPedido";
        }

        private void MostrarMesaPedido(List<Mesa> mesas)
        {
            cbMesaP.DataSource = mesas;
            cbMesaP.DisplayMember = "Numero";
            cbMesaP.ValueMember = "Numero";
        }

        private void MostrarMesaxPedido(List<MesaxPedido> mesaxPedidos)
        {
            dgMesaxPedido.DataSource = null;
            if (mesaxPedidos.Count == 0)
            {
                return;
            }
            else
            {
                dgMesaxPedido.DataSource = mesaxPedidos;
            }
        }
        private void btRegistrarGestionMesa_Click(object sender, EventArgs e)
        {
            if (cbMesaP.Text.Trim() == "" || cbPedidoM.Text.Trim() == "" || tbCapacidadClientes.Text.Trim() == "" || cbEstadoMesa.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese todos los valores solicitados", "xsd", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int idMesa = Convert.ToInt32(cbMesaP.SelectedValue);
            int idPedido = Convert.ToInt32(cbPedidoM.SelectedValue);

            MesaxPedido mesaxPedido = new MesaxPedido()
            {
                IdMesa = idMesa,
                idPedido = idPedido,
                Capacidad = Convert.ToInt32(tbCapacidadClientes.Text),
                Estado = cbEstadoMesa.Text
            };
            String mess = nMesaxPedido.Registrar(mesaxPedido);
            MostrarMesaxPedido(nMesaxPedido.ListarTodo());
            MessageBox.Show($"{mess}", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    

        private void btCambiarEstado_Click(object sender, EventArgs e)
        {
            if (tbCapacidadClientes.Text.Trim() == "" || cbEstadoMesa.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese todos los valores solicitados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgMesaxPedido.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un registro de la tabla MesaxPedido");
                return;
            }


            int.TryParse(tbCapacidadClientes.Text, out int capacidad); 

            MesaxPedido mesaxPedido = new MesaxPedido()
            {
                idPedido = Convert.ToInt32(dgMesaxPedido.SelectedRows[0].Cells[2].Value),
                IdMesa = Convert.ToInt32(dgMesaxPedido.SelectedRows[0].Cells[3].Value),
                Capacidad = capacidad,
                Estado = cbEstadoMesa.Text
            };

            string mensaje = nMesaxPedido.Modificar(mesaxPedido);
            MostrarMesaxPedido(nMesaxPedido.ListarTodo());
            MessageBox.Show(mensaje, "Modificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
