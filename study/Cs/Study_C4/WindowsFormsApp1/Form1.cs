using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click Event occured");
            return;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Click += Button1_Click;
            textBox1.KeyPress += TextBox1_KeyPress;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click Event occured");
            return;
        }
        
        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                textBox2.Focus();
            }
        }
    }
}
