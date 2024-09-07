using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ventas_watch.dataAccess;
using ventas_watch.modelo;
using ventas_watch.validaciones;

namespace ventas_watch.vista.productos
{
    public partial class FormCreateProduct : Form
    {
        public FormCreateProduct()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var nuevoProducto = new product();
            var listadoNuevoProducto = new List<product>();
            nuevoProducto.name = txtProducto.Text;
            nuevoProducto.description = txtDescripcion.Text;
            nuevoProducto.price_buy = decimal.Parse(txtPrecioCompra.Text);
            nuevoProducto.price_sell = decimal.Parse(txtPrecioVenta.Text);

            var dataAccess = new dataAccessEntity<product>();
            listadoNuevoProducto.Add(nuevoProducto);
            var mensaje = dataAccess.CreateDataEntity(listadoNuevoProducto);
            MessageBox.Show(mensaje);
        }
        public void limpiarCampos()
        {
            var limpiarDatos = new limpiarCampos(this);
            limpiarDatos.limpiar_Campos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }
    }
}
