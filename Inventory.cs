using iTextSharp.text;
using iTextSharp.text.pdf;
using OfficeOpenXml;
using System.Data;
using System.Data.SqlClient;

//using static InventoryManagement.MyDb;

namespace InventoryManagement
{
    public partial class Inventory : Form
    {
        private int selectedLocationId = 1;
        public Inventory()
        {
            InitializeComponent();
            LoadCategoriesToComboBox();
            LoadLocationsToComboBox();
            LoadSubLocationsToComboBox(selectedLocationId);
            selectedLocationId = Convert.ToInt32(cmbLocation.SelectedValue);
            btnUpdate.Enabled = false;
            lblCurrentDate.Text = DateTime.Now.ToShortDateString();
            int selectedCategoryId = (int)cmbCategory.SelectedValue;
            LoadCategories();

            dgvItemDetails.Columns["SerialNo"].Width = 75;
            dgvItemDetails.Columns["ItemName"].Width = 100;
            dgvItemDetails.Columns["CategoryName"].Width = 70;
            dgvItemDetails.Columns["LocationName"].Width = 70;
            dgvItemDetails.Columns["SubLocationName"].Width = 70;
            dgvItemDetails.Columns["QTY"].Width = 50;
            dgvItemDetails.Columns["SupplierName"].Width = 150;
            dgvItemDetails.Columns["Cost"].Width = 70;
            dgvItemDetails.Columns["DateOfPurchase"].Width = 80;
            dgvItemDetails.Columns["DateAdded"].Width = 80;
            dgvItemDetails.Columns["Description"].Width = 150;
            LoadCategoriesToFilterComboBox();

            lblItemId.Visible = false;
            //int itemIdToUpdate = Convert.ToInt32(lblItemId.Text);
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

        private DataTable GetLocations()
        {
            MyDb db = new MyDb();
            db.OpenConnection();
            using (SqlCommand cmd = new SqlCommand("SELECT LocationID,LocationName FROM Locations", db.Connection))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        private DataTable GetSubLocations(int locationId)
        {
            MyDb db = new MyDb();
            db.OpenConnection();
            using (SqlCommand cmd = new SqlCommand("SELECT SubLocationID,SubLocationName FROM SubLocations WHERE LocationID = @locationId", db.Connection))
            {
                cmd.Parameters.AddWithValue("@locationId", locationId);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        private void LoadLocationsToComboBox()
        {
            DataTable locations = GetLocations();
            cmbLocation.DataSource = locations;
            cmbLocation.DisplayMember = "LocationName";
            cmbLocation.ValueMember = "LocationID"; // Using ID as the value now
        }
        private void LoadSubLocationsToComboBox(int locationId)
        {
            DataTable subLocations = GetSubLocations(locationId);
            cmbSubLocation.DataSource = subLocations;
            cmbSubLocation.DisplayMember = "SubLocationName";
            cmbSubLocation.ValueMember = "SubLocationID";
        }

        private void LoadCategoriesToComboBox()
        {
            DataTable categories = GetCategories();
            cmbCategory.DataSource = categories;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryId"; // Using ID as the value now
        }
        private void LoadCategoriesToFilterComboBox()
        {
            LoadCategoriesToComboBox();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            var currentDate = DateTime.Now;
            if (dtpDateOfPurchase.Value > currentDate)
            {
                MessageBox.Show("Please enter a valid date");
                return;
            }
            if (string.IsNullOrEmpty(txtItemCode.Text) || string.IsNullOrEmpty(txtItemName.Text) || string.IsNullOrEmpty(cmbCategory.Text) || string.IsNullOrEmpty(cmbLocation.Text) || string.IsNullOrEmpty(cmbSubLocation.Text) || string.IsNullOrEmpty(cmbCategory.Text) || string.IsNullOrEmpty((nudQty.Value.ToString()))
                 || string.IsNullOrEmpty(txtCost.Text) || string.IsNullOrEmpty(txtCost.Text))
            {
                MessageBox.Show("Please Fill Required fields");
                return;
            }
            MyDb db = new MyDb();
            db.OpenConnection();
            SqlCommand cmd;

            SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Items WHERE ItemCode=@ItemCode", db.Connection);
            checkCmd.Parameters.AddWithValue("@ItemCode", txtItemCode.Text);
            int count = (int)checkCmd.ExecuteScalar();
            if (count > 0)
            {
                MessageBox.Show("ItemCode already exists. Please choose a different one.");
                return;
            }

            cmd = new SqlCommand("INSERT INTO Items (ItemCode,ItemName,CategoryId, QTY,SupplierName,Cost,DateOfPurchase,DateAdded,Description,SerialNo,DateOfExpire,LocationID,SubLocationID) VALUES (@ItemCode,@ItemName,@CategoryId,@QTY,@SupplierName,@Cost,@DateOfPurchase,@DateAdded,@Description,@SerialNo,@DateOfExpire,@LocationID,@SubLocationID)", db.Connection);
            cmd.Parameters.AddWithValue("@ItemCode", txtItemCode.Text);
            cmd.Parameters.AddWithValue("@ItemName", txtItemName.Text);
            cmd.Parameters.AddWithValue("@CategoryId", cmbCategory.SelectedValue);
            cmd.Parameters.AddWithValue("@LocationID", cmbLocation.SelectedValue);
            cmd.Parameters.AddWithValue("@SubLocationID", cmbSubLocation.SelectedValue);
            cmd.Parameters.AddWithValue("@QTY", nudQty.Value);
            cmd.Parameters.AddWithValue("@SupplierName", txtSuppliername.Text);
            cmd.Parameters.AddWithValue("@Cost", txtCost.Text);
            cmd.Parameters.AddWithValue("@DateOfPurchase", dtpDateOfPurchase.Value);
            cmd.Parameters.AddWithValue("@DateAdded", DateTime.Parse(lblCurrentDate.Text));
            cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
            cmd.Parameters.AddWithValue("@SerialNo", txtSerialNumber.Text);
            cmd.Parameters.AddWithValue("@DateOfExpire", dtpDateOfExpire.Value);
            cmd.ExecuteNonQuery();
            ClearTextBoxes();
            LoadCategories();
            MessageBox.Show("Item Added Succesfully");
        }
        private void ClearTextBoxes()
        {
            txtItemName.Clear();
            txtItemCode.Clear();
            nudQty.Value = 0;
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
            I.SerialNo,
            I.ItemName,
            C.CategoryName,
            L.LocationName,
			SL.SubLocationName,
            I.QTY,
            I.SupplierName,
            I.Cost,
            I.DateOfPurchase,
            I.DateOfExpire,
            I.DateAdded,
            I.Description
        FROM
            Items I
        INNER JOIN Categories C ON I.CategoryId = C.CategoryId
        INNER JOIN Locations L ON I.LocationID = L.LocationID
        INNER JOIN SubLocations SL ON I.SubLocationID = SL.SubLocationID";
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, db.Connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvItemDetails.DataSource = dt;
            }
            dgvItemDetails.Columns["ItemCode"].HeaderText = "Item Code";
            dgvItemDetails.Columns["SerialNo"].HeaderText = "Serial No";
            dgvItemDetails.Columns["DateOfExpire"].HeaderText = "Warranty Expire Date";

            dgvItemDetails.Columns["ItemCode"].DisplayIndex = 0;
            dgvItemDetails.Columns["SerialNo"].DisplayIndex = 1;
            dgvItemDetails.Columns["ItemName"].DisplayIndex = 2;
            dgvItemDetails.Columns["CategoryName"].DisplayIndex = 3;
            dgvItemDetails.Columns["LocationName"].DisplayIndex = 4;
            dgvItemDetails.Columns["SubLocationName"].DisplayIndex = 5;
            dgvItemDetails.Columns["QTY"].DisplayIndex = 6;
            dgvItemDetails.Columns["SupplierName"].DisplayIndex = 7;
            dgvItemDetails.Columns["Cost"].DisplayIndex = 8;
            dgvItemDetails.Columns["DateOfPurchase"].DisplayIndex = 9;
            dgvItemDetails.Columns["DateOfExpire"].DisplayIndex = 10;
            dgvItemDetails.Columns["DateAdded"].DisplayIndex = 11;
            dgvItemDetails.Columns["Description"].DisplayIndex = 12;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var currentDate = DateTime.Now;

            if (dtpDateOfPurchase.Value > currentDate)
            {
                MessageBox.Show("Please enter a valid date.");
                return;
            }

            // Validation for empty fields
            if (string.IsNullOrEmpty(txtItemCode.Text) ||
                string.IsNullOrEmpty(txtItemName.Text) ||
                cmbCategory.SelectedValue == null ||
                string.IsNullOrEmpty(nudQty.Value.ToString()) ||
                string.IsNullOrEmpty(txtCost.Text) ||
                cmbLocation.SelectedValue == null ||
                cmbSubLocation.SelectedValue == null)
            {
                MessageBox.Show("Please Fill Required fields.");
                return;
            }

            using (MyDb db = new MyDb())
            {
                db.OpenConnection();

                // Check for existing item code, excluding the current item being updated
                string checkCmdText = "SELECT COUNT(*) FROM Items WHERE ItemCode=@ItemCode AND ItemId<>@CurrentItemId";
                using (SqlCommand checkCmd = new SqlCommand(checkCmdText, db.Connection))
                {
                    checkCmd.Parameters.AddWithValue("@ItemCode", txtItemCode.Text);
                    checkCmd.Parameters.AddWithValue("@CurrentItemId", Convert.ToInt32(lblItemId.Text));

                    int count = (int)checkCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("ItemCode already exists in another item. Please choose a different one.");
                        return;
                    }
                }

                // Update item details
                string cmdText = @"UPDATE Items 
                          SET ItemCode=@ItemCode,ItemName=@ItemName,CategoryId=@CategoryId, 
                              QTY=@QTY,SupplierName=@SupplierName,Cost=@Cost,DateOfPurchase=@DateOfPurchase,
                              DateAdded=@DateAdded,Description=@Description,SerialNo=@SerialNo,DateOfExpire=@DateOfExpire,
                              LocationID=@LocationID,SubLocationID=@SubLocationID 
                          WHERE ItemId=@CurrentItemId";

                using (SqlCommand cmd = new SqlCommand(cmdText, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@ItemCode", txtItemCode.Text);
                    cmd.Parameters.AddWithValue("@ItemName", txtItemName.Text);
                    cmd.Parameters.AddWithValue("@CategoryId", cmbCategory.SelectedValue);
                    cmd.Parameters.AddWithValue("@LocationID", cmbLocation.SelectedValue);
                    cmd.Parameters.AddWithValue("@SubLocationID", cmbSubLocation.SelectedValue);
                    cmd.Parameters.AddWithValue("@QTY", nudQty.Value);
                    cmd.Parameters.AddWithValue("@SupplierName", txtSuppliername.Text);
                    cmd.Parameters.AddWithValue("@Cost", txtCost.Text);
                    cmd.Parameters.AddWithValue("@DateOfPurchase", dtpDateOfPurchase.Value);
                    cmd.Parameters.AddWithValue("@DateAdded", DateTime.Parse(lblCurrentDate.Text));
                    cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
                    cmd.Parameters.AddWithValue("@SerialNo", txtSerialNumber.Text);
                    cmd.Parameters.AddWithValue("@DateOfExpire", dtpDateOfExpire.Value);
                    cmd.Parameters.AddWithValue("@CurrentItemId", Convert.ToInt32(lblItemId.Text));

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Item Updated Successfully");
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Error updating item: " + ex.Message);
                    }
                }

                ClearTextBoxes();
                LoadCategories();

                btnSave.Enabled = true;
                btnUpdate.Enabled = false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            btnSave.Enabled = true;
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
            //string currentItemCode = txtItemCode.Text;
            //lblItemId.Text = GetItemIdByItemCode(currentItemCode).ToString();  

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

                lblItemId.Text = GetItemIdByItemCode(txtItemCode.Text).ToString();
            }
        }

        private void dgvItemDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnFilterByCmb_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbFilter.SelectedItem?.ToString()))
            {
                LoadCategories();
                return;
            }

            MyDb db = new MyDb();
            db.OpenConnection();

            SqlCommand cmd = new SqlCommand("select ItemCode,SerialNo,ItemName,c.CategoryName,QTY,SupplierName,Cost,DateOfPurchase,DateOfExpire,DateAdded,Description from Items i inner join Categories c on i.CategoryId = c.CategoryId WHERE c.CategoryId = @categoryId", db.Connection);
            cmd.Parameters.AddWithValue("@categoryId", Convert.ToInt32(cmbFilter.SelectedValue));

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvItemDetails.DataSource = dt;
        }

        private void btnDateFilter_Click(object sender, EventArgs e)
        {
            MyDb db = new MyDb();
            db.OpenConnection();

            var fromDate = dtpFrom.Value.Date;
            var toDate = dtpTo.Value.Date;

            if (fromDate > toDate)
            {
                MessageBox.Show("Start date must be before end date.");
                return;
            }
            string sql = "SELECT ItemCode, SerialNo, ItemName, c.CategoryName, QTY, SupplierName, Cost, DateOfPurchase, DateAdded, Description FROM Items i INNER JOIN Categories c ON i.CategoryId = c.CategoryId WHERE DateOfPurchase BETWEEN @fromDate AND @toDate";

            SqlCommand cmd = new SqlCommand(sql, db.Connection);
            cmd.Parameters.AddWithValue("@fromDate", fromDate);
            cmd.Parameters.AddWithValue("@toDate", toDate);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvItemDetails.DataSource = dt;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string itemCode = txtSearch.Text;

            if (string.IsNullOrEmpty(itemCode))
            {
                MessageBox.Show("Please enter an item code to search");
                return;
            }

            MyDb db = new MyDb();
            db.OpenConnection();
            using (SqlCommand cmd = new SqlCommand("SELECT ItemCode,ItemName,QTY,SupplierName,Cost,DateOfPurchase,DateOfExpire,DateAdded,Description,SerialNo,CategoryName FROM Items i INNER JOIN Categories c ON i.CategoryId = c.CategoryId WHERE i.ItemCode LIKE @itemCode", db.Connection))
            {
                cmd.Parameters.AddWithValue("@itemCode", "%" + itemCode + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvItemDetails.DataSource = dt;
            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
                saveDialog.FilterIndex = 0;

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                    using (ExcelPackage pck = new ExcelPackage())
                    {
                        ExcelWorksheet ws = pck.Workbook.Worksheets.Add("Report");
                        ws.Cells["A1"].LoadFromDataTable((DataTable)dgvItemDetails.DataSource, true);
                        pck.SaveAs(new FileInfo(saveDialog.FileName));
                    }
                }
            }
            MessageBox.Show("Excel Exported Successfully");
        }

        private void btnExportPdf_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "PDF files (*.pdf)|*.pdf";
                saveDialog.FilterIndex = 0;

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream stream = new FileStream(saveDialog.FileName, FileMode.Create))
                    {
                        Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 10f);
                        PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();

                        PdfPTable pdfTable = new PdfPTable(dgvItemDetails.ColumnCount);

                        // Setting the width percentage of the table to 100% to occupy the whole page
                        pdfTable.WidthPercentage = 100;

                        // If needed: Define relative column widths
                        // pdfTable.SetWidths(new float[] { 20f, 20f, 20f, 20f, 20f });  // Adjust as per your requirement

                        foreach (DataGridViewColumn column in dgvItemDetails.Columns)
                        {
                            pdfTable.AddCell(column.HeaderText);
                        }

                        foreach (DataGridViewRow row in dgvItemDetails.Rows)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                if (cell.Value != null)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                                else
                                {
                                    pdfTable.AddCell("");  // or whatever default value you want for null cells
                                }
                            }
                        }

                        pdfDoc.Add(pdfTable);
                        pdfDoc.Close();
                        stream.Close();
                    }
                }
            }
            MessageBox.Show("Pdf Exported Successfully");
        }

        private void cmbLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLocation.SelectedValue != null && cmbLocation.SelectedValue is int)
            {
                int selectedLocationId = Convert.ToInt32(cmbLocation.SelectedValue);
                LoadSubLocationsToComboBox(selectedLocationId);
            }
            //int selectedLocationId = Convert.ToInt32(cmbLocation.SelectedValue);
            //LoadSubLocationsToComboBox(selectedLocationId);
        }
        private int GetItemIdByItemCode(string itemCode)
        {
            using (MyDb db = new MyDb())
            {
                db.OpenConnection();
                using (SqlCommand cmd = new SqlCommand("SELECT ItemId FROM Items WHERE ItemCode = @ItemCode", db.Connection))
                {
                    cmd.Parameters.AddWithValue("@ItemCode", itemCode);
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }
    }
}