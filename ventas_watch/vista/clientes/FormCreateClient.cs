using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ventas_watch.dataAccess;
using ventas_watch.modelo;
using ventas_watch.validaciones;

namespace ventas_watch.vista.clientes
{
    public partial class FormCreateClient : Form
    {
        
        public FormCreateClient()
        {
            InitializeComponent();
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var listaNuevoCliente = new List<client>();
            var nuevoCliente = new client();
            nuevoCliente.cedula_ciudadania = int.Parse(txtIdentificacion.Text);
            nuevoCliente.name = txtNombre.Text;
            nuevoCliente.last_name = txtApellidos.Text;
            nuevoCliente.email = txtCorreo.Text;
            nuevoCliente.phone = int.Parse( txtTelefono.Text);

            var dataAccess = new dataAccessEntity<client>();
            listaNuevoCliente.Add(nuevoCliente);
            var mensaje = dataAccess.CreateDataEntity(listaNuevoCliente);
            MessageBox.Show(mensaje);
        }
        public void limpiarCampos()
        {
            var limpiarDatos = new limpiarCampos(this);
            limpiarDatos.limpiar_Campos();
        }
        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            limpiarCampos();
        }
    }
}
