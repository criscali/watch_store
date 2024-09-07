using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ventas_watch.vista.clientes;

namespace ventas_watch.validaciones
{
    public class limpiarCampos
    {
        public Form formulario;

        public limpiarCampos(Form form)
        {
             formulario = form;
        }
        public void limpiar_Campos()
        {
            
            Console.WriteLine($"nombre de formulario {formulario.Name}");

            LimpiarTextBoxesRecursivamente(formulario);

        }
        private void LimpiarTextBoxesRecursivamente(Control control)
        {
            foreach (Control c in control.Controls)
            {
                // Si el control es un TextBox, limpie su texto
                if (c is TextBox textBox)
                {
                    textBox.Text = string.Empty;
                }
                // Si el control tiene controles hijos, llame recursivamente
                if (c.HasChildren)
                {
                    LimpiarTextBoxesRecursivamente(c);
                }
            }
        }
    }
}   

