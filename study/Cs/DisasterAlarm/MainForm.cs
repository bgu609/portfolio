using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DisasterAlarm.Subitems;
using MetroFramework.Forms;

namespace DisasterAlarm
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MessageLog messageLog = new MessageLog();
            messageLog.Location = this.Location;
            messageLog.ShowDialog();
            this.Close();
        }
    }
}
