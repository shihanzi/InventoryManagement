using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace InventoryManagement
{
    public partial class Advance_Report : Form
    {
        private int selectedLocationId = 1;
        public Advance_Report()
        {
            InitializeComponent();
            LoadCategories();
            LoadCategoriesToComboBox();
            LoadLocationsToComboBox();
            LoadSubLocationsToComboBox(selectedLocationId);
            selectedLocationId = Convert.ToInt32(cmbLocation.SelectedValue);
        }
        private void LoadCategories()
        {
            MyDb db = new MyDb();
            db.OpenConnection();
            string query = @"SELECT
            I.ItemCode, 
            I.ItemName, 
            C.CategoryName,
			L.LocationName,
            I.DateOfExpire,
			SL.SubLocationName,
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
            INNER JOIN Locations L
            ON L.LocationID = I.LocationID
            INNER JOIN  SubLocations SL
            ON SL.SubLocationID = I.LocationID";
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, db.Connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvStockDetails.DataSource = dt;
            }
            dgvStockDetails.Columns["ItemCode"].HeaderText = "Item Code";
            dgvStockDetails.Columns["SerialNo"].HeaderText = "Serial No";
            dgvStockDetails.Columns["DateOfExpire"].HeaderText = "Warranty Expire Date";

            dgvStockDetails.Columns["ItemCode"].DisplayIndex = 0;
            dgvStockDetails.Columns["SerialNo"].DisplayIndex = 1;
            dgvStockDetails.Columns["ItemName"].DisplayIndex = 2;
            dgvStockDetails.Columns["CategoryName"].DisplayIndex = 3;
            dgvStockDetails.Columns["LocationName"].DisplayIndex = 4;
            dgvStockDetails.Columns["SubLocationName"].DisplayIndex = 5;
            dgvStockDetails.Columns["QTY"].DisplayIndex = 6;
            dgvStockDetails.Columns["SupplierName"].DisplayIndex = 7;
            dgvStockDetails.Columns["Cost"].DisplayIndex = 8;
            dgvStockDetails.Columns["DateOfPurchase"].DisplayIndex = 9;
            dgvStockDetails.Columns["DateAdded"].DisplayIndex = 10;
            dgvStockDetails.Columns["DateOfExpire"].DisplayIndex = 11;
            dgvStockDetails.Columns["Description"].DisplayIndex = 12;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string baseQuery = @"SELECT I.ItemCode, I.SerialNo,I.ItemName,C.CategoryName, L.LocationName, SL.SubLocationName,I.QTY,I.SupplierName,I.Cost,I.DateOfPurchase,I.DateOfExpire,I.DateAdded,I.Description FROM Items I LEFT JOIN Categories C ON I.CategoryId = C.CategoryId LEFT JOIN Locations L ON I.LocationID = L.LocationID LEFT JOIN SubLocations SL ON I.SubLocationID = SL.SubLocationID WHERE 1=1"; // The 1=1 is just a dummy condition to simplify appending additional conditions.

            List<SqlParameter> parameters = new List<SqlParameter>();

            if (dtpEnterFrom.Value != null && dtpEnterTo.Value != null)
            {
                baseQuery += " AND DateAdded BETWEEN @EnteredFrom AND @EnteredTo";
                parameters.Add(new SqlParameter("@EnteredFrom", dtpEnterFrom.Value));
                parameters.Add(new SqlParameter("@EnteredTo", dtpEnterTo.Value));
            }

            if (dtpExpiryFrom.Value != null && dtpExpiryTo.Value != null)
            {
                baseQuery += " AND DateOfExpire BETWEEN @ExpiryFrom AND @ExpiryTo";
                parameters.Add(new SqlParameter("@ExpiryFrom", dtpExpiryFrom.Value));
                parameters.Add(new SqlParameter("@ExpiryTo", dtpExpiryTo.Value));
            }

            if (cmbCategory.SelectedValue != null)
            {
                baseQuery += " AND I.CategoryId = @CategoryId";
                parameters.Add(new SqlParameter("@CategoryId", cmbCategory.SelectedValue));
            }

            if (cmbLocation.SelectedValue != null)
            {
                baseQuery += " AND I.LocationId = @LocationId";
                parameters.Add(new SqlParameter("@LocationId", cmbLocation.SelectedValue));
            }

            if (cmbSubLocation.SelectedValue != null)
            {
                baseQuery += " AND I.SubLocationId = @SubLocationId";
                parameters.Add(new SqlParameter("@SubLocationId", cmbSubLocation.SelectedValue));
            }

            using (MyDb db = new MyDb())
            {
                db.OpenConnection();

                using (SqlCommand cmd = new SqlCommand(baseQuery, db.Connection))
                {
                    cmd.Parameters.AddRange(parameters.ToArray());

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Create a new DataTable.
                        DataTable dt = new DataTable();
                        // Load the result of the SQL query into the DataTable.
                        dt.Load(reader);
                        // Assign the DataTable as the DataSource of your DataGridView.
                        dgvStockDetails.DataSource = dt;
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmDashboard fd = new FrmDashboard();
            fd.Show();
        }
        private void LoadCategoriesToComboBox()
        {
            DataTable categories = GetCategories();
            cmbCategory.DataSource = categories;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryId"; // Using ID as the value now
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
        private void LoadLocationsToComboBox()
        {
            DataTable categories = GetLocations();
            cmbLocation.DataSource = categories;
            cmbLocation.DisplayMember = "LocationName";
            cmbLocation.ValueMember = "LocationID"; // Using ID as the value now
        }
        private DataTable GetLocations()
        {
            MyDb db = new MyDb();
            db.OpenConnection();
            using (SqlCommand cmd = new SqlCommand("SELECT LocationID, LocationName FROM Locations", db.Connection))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
        private void LoadSubLocationsToComboBox(int locationId)
        {
            DataTable subLocations = GetSubLocations(locationId);
            cmbSubLocation.DataSource = subLocations;
            cmbSubLocation.DisplayMember = "SubLocationName";
            cmbSubLocation.ValueMember = "SubLocationID"; // Using ID as the value now
        }
        private DataTable GetSubLocations(int locationId)
        {
            MyDb db = new MyDb();
            db.OpenConnection();
            using (SqlCommand cmd = new SqlCommand("SELECT SubLocationID, SubLocationName FROM SubLocations WHERE LocationID = @locationId", db.Connection))
            {
                cmd.Parameters.AddWithValue("@locationId", locationId);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        private void SubLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void cmbLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLocation.SelectedValue != null && cmbLocation.SelectedValue is int)
            {
                int selectedLocationId = Convert.ToInt32(cmbLocation.SelectedValue);
                LoadSubLocationsToComboBox(selectedLocationId);
            }
        }
    }
}
