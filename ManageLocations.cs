using System.Data;
using System.Data.SqlClient;

namespace InventoryManagement
{
    public partial class ManageLocations : Form
    {
        private int? selectedLocationId = null;
        public ManageLocations()
        {
            InitializeComponent();
            LoadLocations();
            btnUpdate.Enabled = false;
            lblLocationId.Text = GetNextLocationId().ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            string locationName = txtLocationName.Text;
            if (string.IsNullOrEmpty(locationName))
            {
                MessageBox.Show("Please enter a Location to Continue");
                return;
            }

            MyDb db = new MyDb();
            db.OpenConnection();
            SqlCommand cmd;

            cmd = new SqlCommand("INSERT INTO Locations (LocationName) VALUES (@name)", db.Connection);
            cmd.Parameters.AddWithValue("@name", locationName);
            cmd.ExecuteNonQuery();
            lblLocationId.Text = GetNextLocationId().ToString();
            MessageBox.Show("Location Saved Successfully");
            txtLocationName.Clear();
            LoadLocations();
            Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!selectedLocationId.HasValue)
            {
                MessageBox.Show("Please select a Location to update");
                return;
            }

            MyDb db = new MyDb();
            db.OpenConnection();
            SqlCommand cmd = new SqlCommand("UPDATE Locations SET LocationName = @name WHERE LocationID = @id", db.Connection);

            cmd.Parameters.AddWithValue("@name", txtLocationName.Text);
            cmd.Parameters.AddWithValue("@id", selectedLocationId.Value);

            int rowsAffected = cmd.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Location Updated Successfully");
                LoadLocations();
                lblLocationId.Text = GetNextLocationId().ToString();
                txtLocationName.Clear();
            }
            else
            {
                MessageBox.Show("Error updating the Location");
            }
            Clear();
            db.CloseConnection();
        }

        private void dgvLocations_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSave.Enabled = false;
            btnUpdate.Enabled = true;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvLocations.Rows[e.RowIndex];
                selectedLocationId = Convert.ToInt32(row.Cells["LocationID"].Value);
                lblLocationId.Text = selectedLocationId.Value.ToString();
                txtLocationName.Text = row.Cells["LocationName"].Value.ToString();
            }
        }
        private void LoadLocations()
        {
            MyDb db = new MyDb();
            db.OpenConnection();
            using (SqlCommand cmd = new SqlCommand("SELECT* FROM Locations", db.Connection))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvLocations.DataSource = dt;
            }
        }
        private int GetNextLocationId()
        {
            MyDb db = new MyDb();
            db.OpenConnection();
            using (SqlCommand cmd = new SqlCommand("SELECT ISNULL(MAX(LocationID), 0) + 1 FROM Locations", db.Connection))
            {
                return (int)cmd.ExecuteScalar();
            }
        }
        private void Clear()
        {
            txtLocationName.Clear();
        }
    }
}
