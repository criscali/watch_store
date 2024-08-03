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
            var data_acces = new dataAccessClient();
            Console.WriteLine(
            data_acces.GetClients());
        }
    }
}
