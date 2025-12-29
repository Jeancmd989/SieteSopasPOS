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
    public partial class FormPlato : Form
    {
        private NPlato nPlato = new NPlato();
        public FormPlato()
        {
            InitializeComponent();
            MostrarPlatos(nPlato.ListarTodo());
        }
        private void MostrarPlatos(List<Plato> platos)
        {
            dgPlatos.DataSource = null;
            if (platos.Count == 0)
            {
                return;
            }
            else
            {
                dgPlatos.DataSource = platos;
            }
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (tbNombrePlato.Text == "" || tbDescripcion.Text == "" || tbPrecio.Text == "" || cbTipo.Text == "")
            {
                MessageBox.Show("Ingrese todos los datos solicitados");
                return;
            }
            Plato plato = new Plato()
            {
                Nombre = tbNombrePlato.Text,
                Descripcion = tbDescripcion.Text,
                Precio = int.Parse(tbPrecio.Text),
                Tipo = cbTipo.Text
            };

            String mess = nPlato.Registrar(plato);
            MessageBox.Show($"{mess}", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MostrarPlatos(nPlato.ListarTodo());

        }
    }
}
