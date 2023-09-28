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
using static InventoryManagement.MyDb;

namespace InventoryManagement
{
    public partial class Category : Form
    {
        public Category()
        {
            InitializeComponent();
            lblCategoryId.Text = GetNextCategoryId().ToString();
            LoadCategories();
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
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string categoryName = txtItemName.Text;
            if (string.IsNullOrEmpty(categoryName))
            {
                MessageBox.Show("Please enter a category to Continue");
                return;
            }

            MyDb db = new MyDb();
            db.OpenConnection();
            SqlCommand cmd;

            if (lblCategoryIdBeingEdited.Text != "0")
            {
                cmd = new SqlCommand("UPDATE Categories SET CategoryName = @name WHERE CategoryId = @id", db.Connection);
                cmd.Parameters.AddWithValue("@id", lblCategoryIdBeingEdited.Text);
            }
            else
            {
                cmd = new SqlCommand("INSERT INTO Categories (CategoryName) VALUES (@name)", db.Connection);
            }
            cmd.Parameters.AddWithValue("@name", categoryName);
            cmd.ExecuteNonQuery();
            txtItemName.Clear();
            LoadCategories();
            lblCategoryId.Text = GetNextCategoryId().ToString();
        }
        private void LoadCategories()
        {
            MyDb db = new MyDb();
            db.OpenConnection();
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM Categories", db.Connection))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvCategory.DataSource = dt;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvCategory.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvCategory.SelectedRows[0];
                lblCategoryIdBeingEdited.Text = selectedRow.Cells["CategoryId"].Value.ToString();
                txtItemName.Text = selectedRow.Cells["CategoryName"].Value.ToString();
            }
        }
    }
}
