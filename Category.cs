using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class Category : Form
    {
        public Category()
        {
            InitializeComponent();
            lblCategoryId.Text = GetNextCategoryId().ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private int GetNextCategoryId()
        {
            MyDb db = new MyDb();
            db.OpenConnection();
            using (SqlCommand cmd = new SqlCommand("SELECT ISNULL(MAX(CategoryId), 0) + 1 FROM Categories", db.Connection))
            {
                return (int)cmd.ExecuteScalar();
            }
        }

        private void lblCategoryId_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
        }
    }
}
