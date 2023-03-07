using ManagerCoffeeShop.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerCoffeeShop
{
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;
            if (Login(username, password)) {
                FTableManager ftable = new FTableManager();
                this.Hide();
                ftable.ShowDialog();
                this.Show();
            }else {
                MessageBox.Show("Error Username or password!!!");
            }
        }

        bool Login (string username , string password)
        {
            return AccountDAO.Instance.Login(username, password);
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Do you want to logut!!!", "Notification", MessageBoxButtons.OKCancel) 
                != System.Windows.Forms.DialogResult.OK) {
                e.Cancel = true;
            }
        }
    }
}
