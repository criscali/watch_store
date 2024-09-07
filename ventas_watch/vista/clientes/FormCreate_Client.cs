using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ventas_watch.modelo;
using ventas_watch.dataAccess;

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

            var nuevo_client = new client();
            var data_acces = new dataAccessClient();
            var lista_datos = new List<client>();
            nuevo_client.cedula_ciudadania = int.Parse(txtIdentificacion.Text);
            nuevo_client.name = txtNombres.Text;
            nuevo_client.last_name = txtApellidos.Text;
            nuevo_client.email = txtCorreo.Text;
            nuevo_client.phone = int.Parse(txtCelular.Text);
            lista_datos.Add(nuevo_client);

            var mensaje = "";
            mensaje = data_acces.Create_Client(lista_datos);
            MessageBox.Show(mensaje);


            /*
            var cedula_client = txtIdentificacion.Text;
            var nombre_client = txtNombres.Text;
            var apellidos_client = txtApellidos.Text;
            var correo_client = txtCorreo.Text;
            var celular_client = int.Parse(txtCelular.Text);
            */





        }
    }
}
