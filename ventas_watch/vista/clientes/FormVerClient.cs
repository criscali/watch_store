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

namespace ventas_watch.vista.clientes
{
    public partial class FormVerClient : Form
    {
        public FormVerClient()
        {
            InitializeComponent();

            // Configura las columnas del DataGridView
            dataGridView1.AutoGenerateColumns = false; // Evita la generación automática de columnas
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "Cedula Ciudadania", HeaderText = "cedula_ciudadania", DataPropertyName = "cedula_ciudadania" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "Nombre", HeaderText = "name", DataPropertyName = "name" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "Apellidos", HeaderText = "last_name", DataPropertyName = "last_name" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "Correo", HeaderText = "email", DataPropertyName = "email" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "Celular", HeaderText = "phone", DataPropertyName = "phone" });
            var data_acces = new dataAccessClient();
            dataGridView1.DataSource = data_acces.GetClients();
            


          

        }

        /*private void FormVerClient_Load(object sender , EventArgs e)
        {
            
        }
        */
        private void lvClients_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
