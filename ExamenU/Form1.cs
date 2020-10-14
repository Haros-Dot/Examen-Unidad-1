using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnincrementar_Click(object sender, EventArgs e)
        {
    
            int count = int.Parse(pantalla.Text);
            count++;
            pantalla.Text = count.ToString();
            if(count >= 25)
            {
                pantalla.Text = "25";
                MessageBox.Show("Ya no es posible incrementar mas");
                
            }
            
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            int count = int.Parse(pantalla.Text);
            count--;
            pantalla.Text = count.ToString();
            if (count <= 0)
            {
                pantalla.Text = "0";
                MessageBox.Show("Ya no es posible decrementar mas");

            }
            
        }
    }
}
