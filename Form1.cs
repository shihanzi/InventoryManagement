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
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM Items", db.Connection))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvStockDetails.DataSource = dt;
            }
        }
    }
}