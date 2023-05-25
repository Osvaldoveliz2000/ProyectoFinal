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
    public partial class DiagolBoxCaptura : Form
    {
        public DiagolBoxCaptura()
        {
            InitializeComponent();
        }

        //Declaracion de metodos get
        public string id
        {
            get { return (textBox1.Text); }
        }
        public string nombreproducto
        {
            get { return (textBox2.Text); }
        }
        public string precioproducto
        {
            get { return (textBox3.Text); }
        }
        public string existenciaproducto
        {
            get { return (textBox4.Text); }
        }


        private void DiagolBoxCaptura_Load(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Focus();
            textBox2.Clear();
            textBox3.Clear();            
            textBox4.Clear();
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                textBox3.Focus();
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                textBox4.Focus();
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                button1.PerformClick();
            }
        }

   
    }
}
