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
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStockDetails).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = SystemColors.ControlDark;
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
            btnAddCategory.Location = new Point(34, 193);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(126, 53);
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
            btnAddUser.Location = new Point(34, 262);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(126, 53);
            btnAddUser.TabIndex = 4;
            btnAddUser.Text = "Add User";
            btnAddUser.UseVisualStyleBackColor = true;
            // 
            // btnAddItem
            // 
            btnAddItem.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnAddItem.AutoSize = true;
            btnAddItem.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddItem.Location = new Point(34, 134);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(126, 53);
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
            btnLogout.Location = new Point(34, 607);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(126, 25);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // dgvStockDetails
            // 
            dgvStockDetails.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvStockDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStockDetails.Location = new Point(238, 162);
            dgvStockDetails.Name = "dgvStockDetails";
            dgvStockDetails.RowTemplate.Height = 25;
            dgvStockDetails.Size = new Size(1104, 482);
            dgvStockDetails.TabIndex = 1;
            // 
            // FrmDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1364, 656);
            Controls.Add(dgvStockDetails);
            Controls.Add(panel1);
            Name = "FrmDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
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
    }
}