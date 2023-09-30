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
//using static InventoryManagement.MyDb;

namespace InventoryManagement
{
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
            LoadCategoriesToComboBox();
            btnUpdate.Enabled = false;
            lblCurrentDate.Text = DateTime.Now.ToShortDateString();
            int selectedCategoryId = (int)cmbCategory.SelectedValue;
            LoadCategories();

            dgvItemDetails.Columns["ItemCode"].Width = 100;
            dgvItemDetails.Columns["SerialNo"].Width = 75;
            dgvItemDetails.Columns["ItemName"].Width = 100;
            dgvItemDetails.Columns["CategoryName"].Width = 70;
            dgvItemDetails.Columns["QTY"].Width = 50;
            dgvItemDetails.Columns["SupplierName"].Width = 150;
            dgvItemDetails.Columns["Cost"].Width= 70;
            dgvItemDetails.Columns["DateOfPurchase"].Width= 80;
            dgvItemDetails.Columns["DateAdded"].Width = 80;
            dgvItemDetails.Columns["Description"].Width = 150;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            // Check for non-digit and non-control characters.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Only allow one decimal point.
            if ((e.KeyChar == '.') && textBox.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

            // Only allow two digits after the decimal point.
            if (!char.IsControl(e.KeyChar) && textBox.Text.IndexOf('.') > -1)
            {
                if (textBox.SelectionStart > textBox.Text.IndexOf('.') && textBox.Text.Length - textBox.Text.IndexOf('.') > 2)
                {
                    e.Handled = true;
                }
            }
        }

        private void txtCost_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            // Remove any characters that aren't digits or the decimal point.
            string cleanText = new string(textBox.Text.Where(c => char.IsDigit(c) || c == '.').ToArray());

            // If there are multiple decimal points, remove all but the first.
            int firstDecimalIndex = cleanText.IndexOf('.');
            if (firstDecimalIndex != -1)
            {
                cleanText = cleanText.Substring(0, firstDecimalIndex + 1) +
                            cleanText.Substring(firstDecimalIndex + 1).Replace(".", "");
            }

            // If there are more than two digits after the decimal point, trim them.
            if (cleanText.IndexOf('.') != -1 && cleanText.Substring(cleanText.IndexOf('.') + 1).Length > 2)
            {
                cleanText = cleanText.Substring(0, cleanText.IndexOf('.') + 3);
            }

            if (textBox.Text != cleanText)
            {
                // Preserve the cursor position.
                int cursorPosition = textBox.SelectionStart - (textBox.Text.Length - cleanText.Length);
                textBox.Text = cleanText;
                textBox.SelectionStart = Math.Max(0, cursorPosition); // Ensure it doesn't go to a negative position.
            }
        }

        private void Inventory_Load(object sender, EventArgs e)
        {

        }
        private DataTable GetCategories()
        {
            MyDb db = new MyDb();
            db.OpenConnection();
            using (SqlCommand cmd = new SqlCommand("SELECT CategoryId, CategoryName FROM Categories", db.Connection))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;
            }
        }
        private void LoadCategoriesToComboBox()
        {
            DataTable categories = GetCategories();
            cmbCategory.DataSource = categories;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryId"; // Using ID as the value now
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var currentDate = DateTime.Now;
            if (dtpDateOfPurchase.Value > currentDate)
            {
                MessageBox.Show("Please enter a valid date");
                return;
            }
            if (string.IsNullOrEmpty(txtItemCode.Text) || string.IsNullOrEmpty(txtItemName.Text) || string.IsNullOrEmpty(txtSerialNumber.Text) || string.IsNullOrEmpty(cmbCategory.Text) || string.IsNullOrEmpty(cmbCategory.Text) || string.IsNullOrEmpty((nudQty.Value.ToString()))
                || string.IsNullOrEmpty(txtSuppliername.Text) || string.IsNullOrEmpty(txtCost.Text) || string.IsNullOrEmpty(txtCost.Text) || string.IsNullOrEmpty(txtDescription.Text))
            {
                MessageBox.Show("Please Fill all the fields");
                return;
            }
            MyDb db = new MyDb();
            db.OpenConnection();
            SqlCommand cmd;

            cmd = new SqlCommand("INSERT INTO Items (ItemCode,ItemName,CategoryId, QTY,SupplierName,Cost,DateOfPurchase,DateAdded,Description,SerialNo) VALUES (@ItemCode,@ItemName,@CategoryId,@QTY,@SupplierName,@Cost,@DateOfPurchase,@DateAdded,@Description,@SerialNo)", db.Connection);
            cmd.Parameters.AddWithValue("@ItemCode", txtItemCode.Text);
            cmd.Parameters.AddWithValue("@ItemName", txtItemName.Text);
            cmd.Parameters.AddWithValue("@CategoryId", cmbCategory.SelectedValue);
            cmd.Parameters.AddWithValue("@QTY", nudQty.Value);
            cmd.Parameters.AddWithValue("@SupplierName", txtSuppliername.Text);
            cmd.Parameters.AddWithValue("@Cost", txtCost.Text);
            cmd.Parameters.AddWithValue("@DateOfPurchase", dtpDateOfPurchase.Value);
            cmd.Parameters.AddWithValue("@DateAdded", DateTime.Parse(lblCurrentDate.Text));
            cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
            cmd.Parameters.AddWithValue("@SerialNo", txtSerialNumber.Text);
            cmd.ExecuteNonQuery();
            ClearTextBoxes();
            LoadCategories();
            MessageBox.Show("Item Added Succesfully");
        }
        private void ClearTextBoxes()
        {
            txtItemName.Clear();
            txtItemCode.Clear();
            nudQty.Equals(0);
            txtSuppliername.Clear();
            txtCost.Clear();
            txtDescription.Clear();
            txtSerialNumber.Clear();
        }
        private void LoadCategories()
        {
            MyDb db = new MyDb();
            db.OpenConnection();
            string query = @"SELECT 
            I.ItemCode, 
            I.ItemName, 
            C.CategoryName,
            I.QTY,
            I.SupplierName,
            I.Cost,
            I.DateOfPurchase,
            I.DateAdded,
            I.Description,
            I.SerialNo
        FROM 
            Items I
        INNER JOIN 
            Categories C ON I.CategoryId = C.CategoryId";
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, db.Connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvItemDetails.DataSource = dt;
            }
            dgvItemDetails.Columns["ItemCode"].HeaderText = "Item Code";
            dgvItemDetails.Columns["SerialNo"].HeaderText = "Serial No";

            dgvItemDetails.Columns["ItemCode"].DisplayIndex = 0;
            dgvItemDetails.Columns["SerialNo"].DisplayIndex = 1;
            dgvItemDetails.Columns["ItemName"].DisplayIndex = 2;
            dgvItemDetails.Columns["CategoryName"].DisplayIndex = 3;
            dgvItemDetails.Columns["QTY"].DisplayIndex = 4;
            dgvItemDetails.Columns["SupplierName"].DisplayIndex = 5;
            dgvItemDetails.Columns["Cost"].DisplayIndex = 6;
            dgvItemDetails.Columns["DateOfPurchase"].DisplayIndex = 7;
            dgvItemDetails.Columns["DateAdded"].DisplayIndex = 8;
            dgvItemDetails.Columns["Description"].DisplayIndex = 9;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
            var currentDate = DateTime.Now;
            if (dtpDateOfPurchase.Value > currentDate)
            {
                MessageBox.Show("Please enter a valid date");
                return;
            }
            if (string.IsNullOrEmpty(txtItemCode.Text) || string.IsNullOrEmpty(txtItemName.Text) || string.IsNullOrEmpty(txtSerialNumber.Text) || string.IsNullOrEmpty(cmbCategory.Text) || string.IsNullOrEmpty(cmbCategory.Text) || string.IsNullOrEmpty((nudQty.Value.ToString()))
                || string.IsNullOrEmpty(txtSuppliername.Text) || string.IsNullOrEmpty(txtCost.Text) || string.IsNullOrEmpty(txtCost.Text) || string.IsNullOrEmpty(txtDescription.Text))
            {
                MessageBox.Show("Please Fill all the fields");
                return;
            }
            MyDb db = new MyDb();
            db.OpenConnection();
            SqlCommand cmd;
            cmd = new SqlCommand("UPDATE Items SET ItemCode=@ItemCode,ItemName=@ItemName,CategoryId=@CategoryId, QTY=@QTY,SupplierName=@SupplierName,Cost=@Cost,DateOfPurchase=@DateOfPurchase,DateAdded=@DateAdded,Description=@Description,SerialNo=@SerialNo WHERE ItemCode=@ItemCode", db.Connection);
            cmd.Parameters.AddWithValue("@ItemCode", txtItemCode.Text);
            cmd.Parameters.AddWithValue("@ItemName", txtItemName.Text);
            cmd.Parameters.AddWithValue("@CategoryId", cmbCategory.SelectedValue);
            cmd.Parameters.AddWithValue("@QTY", nudQty.Value);
            cmd.Parameters.AddWithValue("@SupplierName", txtSuppliername.Text);
            cmd.Parameters.AddWithValue("@Cost", txtCost.Text);
            cmd.Parameters.AddWithValue("@DateOfPurchase", dtpDateOfPurchase.Value);
            cmd.Parameters.AddWithValue("@DateAdded", DateTime.Parse(lblCurrentDate.Text));
            cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
            cmd.Parameters.AddWithValue("@SerialNo", txtSerialNumber.Text);
            cmd.ExecuteNonQuery();
            ClearTextBoxes();
            LoadCategories();
            MessageBox.Show("Item Updated Succesfully");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you really want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                MyDb db = new MyDb();
                db.OpenConnection();
                SqlCommand cmd;

                cmd = new SqlCommand("DELETE FROM Items WHERE ItemCode = @ItemCode", db.Connection);
                cmd.Parameters.AddWithValue("@ItemCode", txtItemCode.Text);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Item Deleted Successfully");
                    ClearTextBoxes();
                    LoadCategories();
                }
                else
                {
                    MessageBox.Show("Error deleting the item. Please try again.");
                }

                db.CloseConnection();
            }
        }

        private void dgvItemDetails_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
            {
                //Populate Item Management Form for editing
                int row = dgvItemDetails.CurrentRow.Index;
                txtItemCode.Text = Convert.ToString(dgvItemDetails["ItemCode", row].Value);
                txtSerialNumber.Text = Convert.ToString(dgvItemDetails["SerialNo", row].Value);
                txtItemName.Text = Convert.ToString(dgvItemDetails["ItemName", row].Value);
                // cmbCategory.SelectedValue = Convert.ToString(dgvItemDetails["CategoryName", row].Value);
                nudQty.Value = Convert.ToInt32(dgvItemDetails["QTY", row].Value);
                txtSuppliername.Text = Convert.ToString(dgvItemDetails["SupplierName", row].Value);
                txtCost.Text = Convert.ToString(dgvItemDetails["Cost", row].Value);
                dtpDateOfPurchase.Value = Convert.ToDateTime(dgvItemDetails["DateOfPurchase", row].Value);
                lblCurrentDate.Text = Convert.ToString(dgvItemDetails["DateAdded", row].Value);
                txtDescription.Text = Convert.ToString(dgvItemDetails["Description", row].Value);
            }
        }
    }
}