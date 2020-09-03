using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using PublicBidApp.subforms;

namespace PublicBidApp
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

        private void BidNotice_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            bidNoticeForm bidNotice = new bidNoticeForm();
            bidNotice.Location = this.Location;
            bidNotice.ShowDialog();
            this.Close();
        }
    }
}
