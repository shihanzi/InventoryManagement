using System.Data.SqlClient;
using System.Data;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace InventoryManagement
{
    public partial class FrmDashboard : Form
    {
        Inventory inv = new Inventory();
        public FrmDashboard()
        {
            InitializeComponent();
            LoadCategories();

            dgvStockDetails.Columns["ItemCode"].Width = 150;
            dgvStockDetails.Columns["SerialNo"].Width = 75;
            dgvStockDetails.Columns["ItemName"].Width = 100;
            dgvStockDetails.Columns["CategoryName"].Width = 70;
            dgvStockDetails.Columns["QTY"].Width = 50;
            dgvStockDetails.Columns["SupplierName"].Width = 150;
            dgvStockDetails.Columns["Cost"].Width = 70;
            dgvStockDetails.Columns["DateOfPurchase"].Width = 80;
            dgvStockDetails.Columns["DateAdded"].Width = 80;
            dgvStockDetails.Columns["Description"].Width = 250;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            string message = "Do you really want to close this applcation?";
            string title = "Exit Application";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Hide();
                FrmDashboard frm = new FrmDashboard();
                frm.Show();
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Hide();
            Inventory inv = new Inventory();
            inv.Show();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Hide();
            Category cat = new Category();
            cat.Show();
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
            dgvStockDetails.Columns["DateOfExpire"].HeaderText = "Expiry Date of Item";

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

        private void FrmDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Hide();
            ManageLocations ml = new ManageLocations();
            ml.Show();
        }
    }
}