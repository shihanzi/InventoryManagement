using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "admin" && txtPassword.Text == "admin")
            {
                this.Hide();
                FrmDashboard fdb = new FrmDashboard();
                fdb.Show();
            }
            else
            {
                MessageBox.Show("UserName or Password Incorrect");
            }
        }
    }
}
