namespace InventoryManagement
{
    partial class ManageLocations
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblCategoryIdBeingEdited = new Label();
            label3 = new Label();
            btnUpdate = new Button();
            btnClose = new Button();
            btnSave = new Button();
            dgvLocations = new DataGridView();
            txtLocationName = new TextBox();
            label2 = new Label();
            lblLocationId = new Label();
            lblCatId = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvLocations).BeginInit();
            SuspendLayout();
            // 
            // lblCategoryIdBeingEdited
            // 
            lblCategoryIdBeingEdited.AutoSize = true;
            lblCategoryIdBeingEdited.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCategoryIdBeingEdited.ForeColor = Color.DimGray;
            lblCategoryIdBeingEdited.Location = new Point(434, 10);
            lblCategoryIdBeingEdited.Name = "lblCategoryIdBeingEdited";
            lblCategoryIdBeingEdited.Size = new Size(19, 21);
            lblCategoryIdBeingEdited.TabIndex = 42;
            lblCategoryIdBeingEdited.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(434, 10);
            label3.Name = "label3";
            label3.Size = new Size(0, 21);
            label3.TabIndex = 41;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.ActiveBorder;
            btnUpdate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = SystemColors.ActiveCaptionText;
            btnUpdate.Location = new Point(178, 465);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(147, 55);
            btnUpdate.TabIndex = 40;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = SystemColors.ActiveBorder;
            btnClose.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = SystemColors.ActiveCaptionText;
            btnClose.Location = new Point(342, 465);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(154, 55);
            btnClose.TabIndex = 39;
            btnClose.Text = "CLOSE";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.ActiveBorder;
            btnSave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = SystemColors.ActiveCaptionText;
            btnSave.Location = new Point(12, 465);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(147, 55);
            btnSave.TabIndex = 38;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // dgvLocations
            // 
            dgvLocations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLocations.Location = new Point(12, 180);
            dgvLocations.Name = "dgvLocations";
            dgvLocations.RowTemplate.Height = 25;
            dgvLocations.Size = new Size(484, 257);
            dgvLocations.TabIndex = 37;
            dgvLocations.CellDoubleClick += dgvLocations_CellDoubleClick;
            // 
            // txtLocationName
            // 
            txtLocationName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtLocationName.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtLocationName.Location = new Point(152, 128);
            txtLocationName.Name = "txtLocationName";
            txtLocationName.Size = new Size(344, 33);
            txtLocationName.TabIndex = 36;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(12, 134);
            label2.Name = "label2";
            label2.Size = new Size(120, 21);
            label2.TabIndex = 35;
            label2.Text = "Location Name";
            // 
            // lblLocationId
            // 
            lblLocationId.AutoSize = true;
            lblLocationId.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblLocationId.ForeColor = Color.White;
            lblLocationId.Location = new Point(152, 91);
            lblLocationId.Name = "lblLocationId";
            lblLocationId.Size = new Size(19, 21);
            lblLocationId.TabIndex = 34;
            lblLocationId.Text = "0";
            // 
            // lblCatId
            // 
            lblCatId.AutoSize = true;
            lblCatId.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCatId.ForeColor = Color.Transparent;
            lblCatId.Location = new Point(12, 91);
            lblCatId.Name = "lblCatId";
            lblCatId.Size = new Size(92, 21);
            lblCatId.TabIndex = 33;
            lblCatId.Text = "Location Id";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(116, 22);
            label1.Name = "label1";
            label1.Size = new Size(260, 32);
            label1.TabIndex = 32;
            label1.Text = "Location Management";
            // 
            // ManageLocations
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(508, 531);
            Controls.Add(lblCategoryIdBeingEdited);
            Controls.Add(label3);
            Controls.Add(btnUpdate);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(dgvLocations);
            Controls.Add(txtLocationName);
            Controls.Add(label2);
            Controls.Add(lblLocationId);
            Controls.Add(lblCatId);
            Controls.Add(label1);
            Name = "ManageLocations";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageLocations";
            ((System.ComponentModel.ISupportInitialize)dgvLocations).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCategoryIdBeingEdited;
        private Label label3;
        private Button btnUpdate;
        private Button btnClose;
        private Button btnSave;
        private DataGridView dgvLocations;
        private TextBox txtLocationName;
        private Label label2;
        private Label lblLocationId;
        private Label lblCatId;
        private Label label1;
    }
}