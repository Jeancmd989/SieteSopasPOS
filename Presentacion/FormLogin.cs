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
    public partial class FormLogin : Form
    {
        private NUsuario nUsuario = new NUsuario();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtDni.Text.Trim() == "" || txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Porfavor complete todos los campos","Login",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            if (txtDni.Text.Length > 8)
            {
                MessageBox.Show("Su dni debe contener máximo 8 digitos", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            // Aquí se puede agregar la lógica de autenticación
            List<UsuarioSistema> usuarioSistemas = nUsuario.ListarTodo();
            UsuarioSistema resul = usuarioSistemas.Find(u => u.DniUsuario == txtDni.Text && u.Password == txtPassword.Text);
            if (resul != null)
            {

                MessageBox.Show($"Bienvenido {resul.Nombre}, su cargo es {resul.Cargo}", "Login");

                if (resul.Cargo == "Administrador")
                {
                    FormReporte formReporte = new FormReporte();
                    formReporte.Show();
                    this.Close();
                    return;
                }
                FormPedido formPedido = new FormPedido(resul.idUsuario);
                formPedido.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("DNI o Contraseña incorrecta", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
