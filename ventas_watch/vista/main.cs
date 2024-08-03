using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ventas_watch.vista.clientes;

namespace ventas_watch
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void vERCLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
             FormVerClient formVerClient = new FormVerClient();
            formVerClient.Show();   
        }
    }
}
