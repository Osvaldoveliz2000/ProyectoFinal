using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArreglosRegistro
{
    public partial class DiagolBoxBuscarPrecioProducto : Form
    {
        public DiagolBoxBuscarPrecioProducto()
        {
            InitializeComponent();
        }
        //declaracion del metodo set

        public string precioproducto
        {
            get { return (textBox1.Text); }
        }

        private void DiagolBoxPrecioProducto_Load(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Focus();
        }
    }
}
