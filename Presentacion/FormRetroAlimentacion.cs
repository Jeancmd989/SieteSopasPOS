using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormRetroAlimentacion : Form
    {
        NMesa nMesa = new NMesa();
        private NCliente nCliente = new NCliente();
        NRetroalimentacion nRetroalimentacion = new NRetroalimentacion();
        public FormRetroAlimentacion()
        {
            InitializeComponent();
            MostrarIdCliente(nCliente.ListarTodo());
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MostrarIdCliente(List<Cliente> clientes)
        {
            cbIdCliente.DataSource = clientes;
            cbIdCliente.DisplayMember = "DniCliente";
            cbIdCliente.ValueMember = "idCliente";
        }
      

        private void btnRegistrarRetroalimentacion_Click(object sender, EventArgs e)
        {
            if (cbIdCliente.Text==""||dtFecha.Text.Trim() == "" || cbCalificacion.Text.Trim() == "" || cbTipoComentario.Text.Trim() == ""|| tbComenarioRetro.Text.Trim()=="")
            {
                MessageBox.Show("Ingrese todos los datos solicitados");
                return;
            }
            int idCliente = Convert.ToInt32(cbIdCliente.SelectedValue);
            int.TryParse(cbCalificacion.Text, out int califi);
            Retroalimentacion retroalimentacion = new Retroalimentacion()
            {
                Fecha = dtFecha.Value.Date,
                Puntuacion = califi,
                TipoComentario = cbTipoComentario.Text,
                Comentario = tbComenarioRetro.Text,
                idCliente = idCliente
            };
            string mess = nRetroalimentacion.Registrar(retroalimentacion);
            MessageBox.Show($"{mess}", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
