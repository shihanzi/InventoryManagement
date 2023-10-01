using System.Data.SqlClient;
using System.Data;

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
                dgvStockDetails.DataSource = dt;
            }
            dgvStockDetails.Columns["ItemCode"].HeaderText = "Item Code";
            dgvStockDetails.Columns["SerialNo"].HeaderText = "Serial No";

            dgvStockDetails.Columns["ItemCode"].DisplayIndex = 0;
            dgvStockDetails.Columns["SerialNo"].DisplayIndex = 1;
            dgvStockDetails.Columns["ItemName"].DisplayIndex = 2;
            dgvStockDetails.Columns["CategoryName"].DisplayIndex = 3;
            dgvStockDetails.Columns["QTY"].DisplayIndex = 4;
            dgvStockDetails.Columns["SupplierName"].DisplayIndex = 5;
            dgvStockDetails.Columns["Cost"].DisplayIndex = 6;
            dgvStockDetails.Columns["DateOfPurchase"].DisplayIndex = 7;
            dgvStockDetails.Columns["DateAdded"].DisplayIndex = 8;
            dgvStockDetails.Columns["Description"].DisplayIndex = 9;
        }
    }
}