using System.Data;
using System.Data.SqlClient;

namespace InventoryManagement
{
    public partial class ManageSubLocations : Form
    {
        private int? selectedSubLocationId = null;
        public ManageSubLocations()
        {
            InitializeComponent();
            LoadSubLocations();
            btnUpdate.Enabled = false;
            lblSubLocationId.Text = GetNextSublocationID().ToString();
            LoadLocationsToComboBox();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            if (string.IsNullOrEmpty(txtSubLocationName.Text))
            {
                MessageBox.Show("Please Enter a SubLocation Name");
                return;
            }

            MyDb db = new MyDb();
            db.OpenConnection();
            SqlCommand cmd = new SqlCommand("INSERT INTO SubLocations (SubLocationName,LocationID) VALUES (@SubLocationName,@LocationID)", db.Connection);
            cmd.Parameters.AddWithValue("@SubLocationName", txtSubLocationName.Text);
            cmd.Parameters.AddWithValue("@LocationID", cmbSubLocation.SelectedValue);
            MessageBox.Show("Sub Location Saved Successfully");
            cmd.ExecuteNonQuery();
            LoadSubLocations();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private int GetNextSublocationID()
        {
            MyDb db = new MyDb();
            db.OpenConnection();
            using (SqlCommand cmd = new SqlCommand("SELECT ISNULL(MAX(SubLocationID), 0) + 1 FROM SubLocations", db.Connection))
            {
                return (int)cmd.ExecuteScalar();
            }
        }
        private void LoadSubLocations()
        {
            MyDb db = new MyDb();
            db.OpenConnection();
            using (SqlCommand cmd = new SqlCommand("SELECT SubLocationID,SubLocationName,L.LocationName FROM SubLocations SL INNER JOIN Locations L ON SL.LocationID = L.LocationID", db.Connection))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvSubLocations.DataSource = dt;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!selectedSubLocationId.HasValue)
            {
                MessageBox.Show("Please select a SubLocation to update");
                return;
            }

            MyDb db = new MyDb();
            db.OpenConnection();
            SqlCommand cmd = new SqlCommand("UPDATE SubLocations SET SubLocationName = @name,LocationID = @LocationID WHERE SubLocationID = @id", db.Connection);

            cmd.Parameters.AddWithValue("@name", txtSubLocationName.Text);
            cmd.Parameters.AddWithValue("@id", selectedSubLocationId.Value);
            cmd.Parameters.AddWithValue("@LocationID", cmbSubLocation.SelectedValue);

            int rowsAffected = cmd.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Sub Location Updated Successfully");
                LoadSubLocations();
                lblSubLocationId.Text = GetNextSublocationID().ToString();
                txtSubLocationName.Clear();
            }
            else
            {
                MessageBox.Show("Error updating the SubLocation");
            }
            db.CloseConnection();

        }
        private void LoadLocationsToComboBox()
        {
            DataTable location = getLocations();
            cmbSubLocation.DataSource = location;
            cmbSubLocation.DisplayMember = "LocationName";
            cmbSubLocation.ValueMember = "LocationID";
        }
        private DataTable getLocations()
        {
            MyDb db = new MyDb();
            db.OpenConnection();
            using (SqlCommand cmd = new SqlCommand("SELECT LocationName,LocationID FROM Locations", db.Connection))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        private void dgvSubLocations_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
            if (e.RowIndex >= 0)
            {
                int row = dgvSubLocations.CurrentRow.Index;
                txtSubLocationName.Text = Convert.ToString(dgvSubLocations["SubLocationName", row].Value);
                selectedSubLocationId = Convert.ToInt32(dgvSubLocations["SubLocationID", row].Value);
                lblSubLocationId.Text = selectedSubLocationId.ToString();
            }
        }
    }
}
