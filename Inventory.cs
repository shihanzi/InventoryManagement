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
            //lblCategoryId.Text = GetNextCategoryId().ToString();
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

        private void dgvItemDetails_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
            {
                //Populate Item Management Form for editing
                int row = dgvItemDetails.CurrentRow.Index;
                txtItemCode.Text = Convert.ToString(dgvItemDetails[1, row].Value);
                txtSerialNumber.Text = Convert.ToString(dgvItemDetails[0, row].Value);
                txtItemName.Text = Convert.ToString(dgvItemDetails[2, row].Value);
                cmbCategory.SelectedValue = Convert.ToString(dgvItemDetails[3, row].Value);
                nudQty.Value = Convert.ToInt32(dgvItemDetails[4, row].Value);
                txtSuppliername.Text = Convert.ToString(dgvItemDetails[5, row].Value);
                txtCost.Text = Convert.ToString(dgvItemDetails[6, row].Value);
                dtpDateOfPurchase.Value = Convert.ToDateTime(dgvItemDetails[7, row].Value);
                lblCurrentDate.Text = Convert.ToString(dgvItemDetails[8, row].Value);
                txtDescription.Text = Convert.ToString(dgvItemDetails[9, row].Value);
            }
        }
        private void LoadCategories()
        {
            MyDb db = new MyDb();
            db.OpenConnection();
            string query = @"
        SELECT 
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
            Categories C ON I.CategoryId = C.CategoryId
    ";
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query,db.Connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvItemDetails.DataSource = dt;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
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
        }
    }
}