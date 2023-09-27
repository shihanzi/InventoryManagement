namespace InventoryManagement
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
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
    }
}