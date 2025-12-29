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
    public partial class FormRegistrarse : Form
    {
        private NUsuario nUsuario = new NUsuario();
        public FormRegistrarse()
        {
            InitializeComponent();
            cbCargo.DataSource = Enum.GetValues(typeof(CargoUsuarioSistema));
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "" || txtEmail.Text.Trim() == "" || txtDni.Text.Trim() == ""
                || txtPassword.Text.Trim() == "" || txtTelefono.Text.Trim() == "")
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int.TryParse(txtTelefono.Text, out int tel);
            UsuarioSistema usuarioSistema = new UsuarioSistema
            {
                Nombre = txtNombre.Text,
                DniUsuario = txtDni.Text,
                Email = txtEmail.Text,
                Telefono = tel,
                Password = txtPassword.Text,
                Cargo = cbCargo.SelectedItem.ToString(),
                Activo = true
            };
            string mess = nUsuario.Registrar(usuarioSistema);
            MessageBox.Show($"{mess}","Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
