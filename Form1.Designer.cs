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
            panel1.Controls.Add(btnAddItem);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnLogout);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(253, 656);
            panel1.TabIndex = 0;
            // 
            // btnAddItem
            // 
            btnAddItem.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnAddItem.AutoSize = true;
            btnAddItem.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddItem.Location = new Point(64, 133);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(126, 53);
            btnAddItem.TabIndex = 3;
            btnAddItem.Text = "Add Item";
            btnAddItem.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(43, 19);
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
            btnLogout.Location = new Point(90, 603);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 25);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // dgvStockDetails
            // 
            dgvStockDetails.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvStockDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStockDetails.Location = new Point(272, 162);
            dgvStockDetails.Name = "dgvStockDetails";
            dgvStockDetails.RowTemplate.Height = 25;
            dgvStockDetails.Size = new Size(1070, 482);
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
    }
}