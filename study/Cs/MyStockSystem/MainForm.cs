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
using MyStockSystem.Subitems;

namespace MyStockSystem
{
    public partial class MainForm : MetroForm //Form
    {
        public MainForm()
        {
            InitializeComponent();
            /*
            this.Location = new Point
            {
                Screen.PrimaryScreen.Bounds.Width / 2 = this.Width / 2;
            }*/
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void MtlSearchItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            SearchitemForm searchitem = new SearchitemForm();
            searchitem.Location = this.Location;
            searchitem.ShowDialog();
            this.Close();
        }

        private void MtlGalmatgilGuide_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            GalmatgilForm Galmatgil = new GalmatgilForm();
            Galmatgil.Location = this.Location;
            Galmatgil.ShowDialog();
            this.Close();
        }
    }
}
