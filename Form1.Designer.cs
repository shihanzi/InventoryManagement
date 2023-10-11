namespace InventoryManagement
{
    partial class FrmDashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnAddCategory = new Button();
            btnAddUser = new Button();
            btnAddItem = new Button();
            label1 = new Label();
            btnLogout = new Button();
            dgvStockDetails = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStockDetails).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnAddCategory);
            panel1.Controls.Add(btnAddUser);
            panel1.Controls.Add(btnAddItem);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnLogout);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(216, 656);
            panel1.TabIndex = 0;
            // 
            // btnAddCategory
            // 
            btnAddCategory.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnAddCategory.AutoSize = true;
            btnAddCategory.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddCategory.Location = new Point(25, 193);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(167, 53);
            btnAddCategory.TabIndex = 5;
            btnAddCategory.Text = "Add Category";
            btnAddCategory.UseVisualStyleBackColor = true;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // btnAddUser
            // 
            btnAddUser.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnAddUser.AutoSize = true;
            btnAddUser.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddUser.Location = new Point(25, 370);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(167, 53);
            btnAddUser.TabIndex = 4;
            btnAddUser.Text = "Add User";
            btnAddUser.UseVisualStyleBackColor = true;
            // 
            // btnAddItem
            // 
            btnAddItem.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnAddItem.AutoSize = true;
            btnAddItem.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddItem.Location = new Point(25, 134);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(167, 53);
            btnAddItem.TabIndex = 3;
            btnAddItem.Text = "Add Item";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(21, 25);
            label1.Name = "label1";
            label1.Size = new Size(160, 64);
            label1.TabIndex = 2;
            label1.Text = "Inventory \r\nManagement";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnLogout.AutoSize = true;
            btnLogout.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.Location = new Point(25, 618);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(167, 25);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // dgvStockDetails
            // 
            dgvStockDetails.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvStockDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStockDetails.Location = new Point(238, 243);
            dgvStockDetails.Name = "dgvStockDetails";
            dgvStockDetails.RowTemplate.Height = 25;
            dgvStockDetails.Size = new Size(1104, 401);
            dgvStockDetails.TabIndex = 1;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button1.AutoSize = true;
            button1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(25, 252);
            button1.Name = "button1";
            button1.Size = new Size(167, 53);
            button1.TabIndex = 6;
            button1.Text = "Manage Location";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button2.AutoSize = true;
            button2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(25, 311);
            button2.Name = "button2";
            button2.Size = new Size(167, 53);
            button2.TabIndex = 7;
            button2.Text = "Manage Sub Location";
            button2.UseVisualStyleBackColor = true;
            // 
            // FrmDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(1364, 656);
            Controls.Add(dgvStockDetails);
            Controls.Add(panel1);
            Name = "FrmDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            FormClosed += FrmDashboard_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStockDetails).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnLogout;
        private DataGridView dgvStockDetails;
        private Label label1;
        private Button btnAddItem;
        private Button btnAddUser;
        private Button btnAddCategory;
        private Button button2;
        private Button button1;
    }
}