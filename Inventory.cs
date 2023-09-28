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
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
            LoadCategoriesToComboBox();
            lblCurrentDate.Text = DateTime.Now.ToShortDateString();
            int selectedCategoryId = (int)cmbCategory.SelectedValue;
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
    }
}
