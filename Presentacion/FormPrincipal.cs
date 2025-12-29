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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            FormRegistrarse formRegistrarse = new FormRegistrarse();
            formRegistrarse.Show();
        }

        private void btnRetroalimentacion_Click(object sender, EventArgs e)
        {
            FormRetroAlimentacion formRetroAlimentacion = new FormRetroAlimentacion();
            formRetroAlimentacion.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
