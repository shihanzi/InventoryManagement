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
        private int? selectedCategoryId = null;
        public Category()
        {
            InitializeComponent();
            lblCategoryId.Text = GetNextCategoryId().ToString();
            LoadCategories();
            btnUpdate.Enabled = false;
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
            btnUpdate.Enabled = false;
            string categoryName = txtItemName.Text;
            if (string.IsNullOrEmpty(categoryName))
            {
                MessageBox.Show("Please enter a category to Continue");
                return;
            }

            MyDb db = new MyDb();
            db.OpenConnection();
            SqlCommand cmd;

            cmd = new SqlCommand("INSERT INTO Categories (CategoryName) VALUES (@name)", db.Connection);
            cmd.Parameters.AddWithValue("@name", categoryName);
            cmd.ExecuteNonQuery();
            txtItemName.Clear();
            LoadCategories();
            lblCategoryId.Text = GetNextCategoryId().ToString();
            MessageBox.Show("Category Saved Successfully");
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
            if (!selectedCategoryId.HasValue)
            {
                MessageBox.Show("Please select a category to update");
                return;
            }

            MyDb db = new MyDb();
            db.OpenConnection();
            SqlCommand cmd = new SqlCommand("UPDATE Categories SET CategoryName = @name WHERE CategoryId = @id", db.Connection);

            cmd.Parameters.AddWithValue("@name", txtItemName.Text);
            cmd.Parameters.AddWithValue("@id", selectedCategoryId.Value);

            int rowsAffected = cmd.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Category Updated Successfully");
                LoadCategories();
                lblCategoryId.Text = GetNextCategoryId().ToString();
                txtItemName.Clear();
            }
            else
            {
                MessageBox.Show("Error updating the category");
            }

            db.CloseConnection();
        }

        private void Category_Load(object sender, EventArgs e)
        {

        }

        private void dgvCategory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSave.Enabled = false;
            btnUpdate.Enabled = true;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCategory.Rows[e.RowIndex];
                selectedCategoryId = Convert.ToInt32(row.Cells["CategoryId"].Value);
                lblCategoryId.Text = selectedCategoryId.Value.ToString();
                txtItemName.Text = row.Cells["CategoryName"].Value.ToString();
            }
        }
    }
}
