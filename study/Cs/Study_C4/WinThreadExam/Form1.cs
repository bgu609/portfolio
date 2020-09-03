using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinThreadExam
{
    public partial class Form1 : Form
    {
        const int MAXVALUE = 1000000;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(new ThreadStart(Progress));
            th.Start();
            th.Join();
        }

        void Progress()
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = MAXVALUE;

            for (int i = 0; i <= MAXVALUE; i++)
            {
                progressBar1.Value = i;
            }
        }
    }
}
