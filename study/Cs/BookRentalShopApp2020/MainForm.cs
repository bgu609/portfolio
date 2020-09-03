using System;
using BookRentalShopApp2020.subforms;
using MetroFramework;
using MetroFramework.Forms;
using MySqlX.XDevAPI.Common;
using System.Windows.Forms;

namespace BookRentalShopApp2020
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.ShowDialog();

            metroLabel1.Text = $"LOGIN : {Common.USERID}";
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MetroMessageBox.Show(this, "종료하시겠습니까?", "종료", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(result == DialogResult.Yes)
            {
                e.Cancel = false;
                Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void Mnuitem_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Mnuitem_code_Click(object sender, EventArgs e)
        {
            tableForm tableForm = new tableForm();
            //tableForm.ShowDialog();
            ShowFormControl(tableForm);
        }

        private void MnuItemBooksMng_Click(object sender, EventArgs e)
        {
            BookMngForm BookMngForm = new BookMngForm();
            //BookMngForm.ShowDialog();
            ShowFormControl(BookMngForm);
        }

        private void ShowFormControl(Form form)
        {
            form.MdiParent = this;
            form.Show();
        }

        private void MnuItemRentalMng_Click(object sender, EventArgs e)
        {
            RentalForm RentalForm = new RentalForm();
            ShowFormControl(RentalForm);
        }

        private void MnuItemUserMng_Click(object sender, EventArgs e)
        {
            UserForm UserForm = new UserForm();
            ShowFormControl(UserForm);
        }
    }
}
