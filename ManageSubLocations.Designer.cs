namespace InventoryManagement
{
    partial class ManageSubLocations
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
            dgvSubLocations = new DataGridView();
            txtSubLocationName = new TextBox();
            label2 = new Label();
            lblSubLocationId = new Label();
            lblCatId = new Label();
            label1 = new Label();
            label4 = new Label();
            cmbSubLocation = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvSubLocations).BeginInit();
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
            lblCategoryIdBeingEdited.TabIndex = 53;
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
            label3.TabIndex = 52;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.ActiveBorder;
            btnUpdate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = SystemColors.ActiveCaptionText;
            btnUpdate.Location = new Point(178, 465);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(147, 55);
            btnUpdate.TabIndex = 51;
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
            btnClose.TabIndex = 50;
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
            btnSave.TabIndex = 49;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // dgvSubLocations
            // 
            dgvSubLocations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSubLocations.Location = new Point(12, 180);
            dgvSubLocations.Name = "dgvSubLocations";
            dgvSubLocations.RowTemplate.Height = 25;
            dgvSubLocations.Size = new Size(484, 257);
            dgvSubLocations.TabIndex = 48;
            dgvSubLocations.CellDoubleClick += dgvSubLocations_CellDoubleClick;
            // 
            // txtSubLocationName
            // 
            txtSubLocationName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSubLocationName.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtSubLocationName.Location = new Point(194, 76);
            txtSubLocationName.Name = "txtSubLocationName";
            txtSubLocationName.Size = new Size(302, 33);
            txtSubLocationName.TabIndex = 47;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(12, 82);
            label2.Name = "label2";
            label2.Size = new Size(152, 21);
            label2.TabIndex = 46;
            label2.Text = "Sub Location Name";
            // 
            // lblSubLocationId
            // 
            lblSubLocationId.AutoSize = true;
            lblSubLocationId.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSubLocationId.ForeColor = Color.White;
            lblSubLocationId.Location = new Point(194, 45);
            lblSubLocationId.Name = "lblSubLocationId";
            lblSubLocationId.Size = new Size(19, 21);
            lblSubLocationId.TabIndex = 45;
            lblSubLocationId.Text = "0";
            // 
            // lblCatId
            // 
            lblCatId.AutoSize = true;
            lblCatId.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCatId.ForeColor = Color.Transparent;
            lblCatId.Location = new Point(12, 46);
            lblCatId.Name = "lblCatId";
            lblCatId.Size = new Size(124, 21);
            lblCatId.TabIndex = 44;
            lblCatId.Text = "Sub Location Id";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(116, 3);
            label1.Name = "label1";
            label1.Size = new Size(308, 32);
            label1.TabIndex = 43;
            label1.Text = "Sub Location Management";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(12, 128);
            label4.Name = "label4";
            label4.Size = new Size(177, 21);
            label4.TabIndex = 54;
            label4.Text = "Select A Main Location";
            // 
            // cmbSubLocation
            // 
            cmbSubLocation.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbSubLocation.FormattingEnabled = true;
            cmbSubLocation.Location = new Point(194, 122);
            cmbSubLocation.Name = "cmbSubLocation";
            cmbSubLocation.Size = new Size(302, 33);
            cmbSubLocation.TabIndex = 55;
            // 
            // ManageSubLocations
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(508, 531);
            Controls.Add(cmbSubLocation);
            Controls.Add(label4);
            Controls.Add(lblCategoryIdBeingEdited);
            Controls.Add(label3);
            Controls.Add(btnUpdate);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(dgvSubLocations);
            Controls.Add(txtSubLocationName);
            Controls.Add(label2);
            Controls.Add(lblSubLocationId);
            Controls.Add(lblCatId);
            Controls.Add(label1);
            Name = "ManageSubLocations";
            Text = "ManageSubLocations";
            ((System.ComponentModel.ISupportInitialize)dgvSubLocations).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCategoryIdBeingEdited;
        private Label label3;
        private Button btnUpdate;
        private Button btnClose;
        private Button btnSave;
        private DataGridView dgvSubLocations;
        private TextBox txtSubLocationName;
        private Label label2;
        private Label lblSubLocationId;
        private Label lblCatId;
        private Label label1;
        private Label label4;
        private ComboBox cmbSubLocation;
    }
}