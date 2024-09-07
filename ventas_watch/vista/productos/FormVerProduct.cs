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

namespace ventas_watch.vista.productos
{
    public partial class FormVerProduct : Form
    {
        public FormVerProduct()
        {
            InitializeComponent();

            dataGridViewProduct.AutoGenerateColumns = false; // Evita la generación automática de columnas
            dataGridViewProduct.Columns.Add(new DataGridViewTextBoxColumn { Name = "Nombre Producto", HeaderText = "Producto", DataPropertyName = "name" });
            dataGridViewProduct.Columns.Add(new DataGridViewTextBoxColumn { Name = "Descripcion", HeaderText = "Descripcion", DataPropertyName = "description" });
            dataGridViewProduct.Columns.Add(new DataGridViewTextBoxColumn { Name = "Precio Compra", HeaderText = "precio Compra", DataPropertyName = "price_buy" });
            dataGridViewProduct.Columns.Add(new DataGridViewTextBoxColumn { Name = "Precio Venta", HeaderText = "Precio Venta", DataPropertyName = "price_sell" });
            
            var product = new product();
            var data_acces = new dataAccessEntity<product>();
            dataGridViewProduct.DataSource = data_acces.DisplayEntity();
        }
    }
}
