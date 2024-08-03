using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ventas_watch.vista.clientes
{
    public partial class FormCreate_Client : Form
    {
        public FormCreate_Client()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cedula_client = txtIdentificacion.Text;
            var nombre_client = txtNombres.Text;
            var apellidos_client = txtApellidos.Text;
            var correo_client = txtCorreo.Text;
            var celular_client = int.Parse(txtCelular.Text);

           
        }
    }
}
