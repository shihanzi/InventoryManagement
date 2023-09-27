namespace InventoryManagement
{
    partial class Inventory
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
            btnSave = new Button();
            btnEdit = new Button();
            btnClose = new Button();
            lblItemCode = new Label();
            lblManageItems = new Label();
            txtItemCode = new TextBox();
            lblSerialNo = new Label();
            txtSerialNumber = new TextBox();
            lblItemName = new Label();
            txtItemName = new TextBox();
            lblCategory = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.LimeGreen;
            btnSave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(58, 557);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(114, 55);
            btnSave.TabIndex = 0;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.GradientActiveCaption;
            btnEdit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.Location = new Point(198, 557);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(114, 55);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "EDIT";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.OrangeRed;
            btnClose.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.Location = new Point(341, 557);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(114, 55);
            btnClose.TabIndex = 2;
            btnClose.Text = "CLOSE";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // lblItemCode
            // 
            lblItemCode.AutoSize = true;
            lblItemCode.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblItemCode.Location = new Point(58, 83);
            lblItemCode.Name = "lblItemCode";
            lblItemCode.Size = new Size(83, 21);
            lblItemCode.TabIndex = 3;
            lblItemCode.Text = "ItemCode";
            // 
            // lblManageItems
            // 
            lblManageItems.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblManageItems.AutoSize = true;
            lblManageItems.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblManageItems.Location = new Point(198, 23);
            lblManageItems.Name = "lblManageItems";
            lblManageItems.Size = new Size(112, 27);
            lblManageItems.TabIndex = 4;
            lblManageItems.Text = "Manage Items";
            lblManageItems.UseCompatibleTextRendering = true;
            // 
            // txtItemCode
            // 
            txtItemCode.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtItemCode.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtItemCode.Location = new Point(198, 71);
            txtItemCode.Name = "txtItemCode";
            txtItemCode.Size = new Size(257, 33);
            txtItemCode.TabIndex = 5;
            // 
            // lblSerialNo
            // 
            lblSerialNo.AutoSize = true;
            lblSerialNo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSerialNo.Location = new Point(58, 126);
            lblSerialNo.Name = "lblSerialNo";
            lblSerialNo.Size = new Size(76, 21);
            lblSerialNo.TabIndex = 6;
            lblSerialNo.Text = "Serial No";
            // 
            // txtSerialNumber
            // 
            txtSerialNumber.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSerialNumber.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtSerialNumber.Location = new Point(198, 114);
            txtSerialNumber.Name = "txtSerialNumber";
            txtSerialNumber.Size = new Size(257, 33);
            txtSerialNumber.TabIndex = 7;
            // 
            // lblItemName
            // 
            lblItemName.AutoSize = true;
            lblItemName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblItemName.Location = new Point(58, 170);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(91, 21);
            lblItemName.TabIndex = 8;
            lblItemName.Text = "Item Name";
            // 
            // txtItemName
            // 
            txtItemName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtItemName.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtItemName.Location = new Point(198, 158);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(257, 33);
            txtItemName.TabIndex = 9;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCategory.Location = new Point(58, 211);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(78, 21);
            lblCategory.TabIndex = 10;
            lblCategory.Text = "Category";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(198, 209);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(257, 29);
            comboBox1.TabIndex = 11;
            // 
            // Inventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 651);
            Controls.Add(comboBox1);
            Controls.Add(lblCategory);
            Controls.Add(txtItemName);
            Controls.Add(lblItemName);
            Controls.Add(txtSerialNumber);
            Controls.Add(lblSerialNo);
            Controls.Add(txtItemCode);
            Controls.Add(lblManageItems);
            Controls.Add(lblItemCode);
            Controls.Add(btnClose);
            Controls.Add(btnEdit);
            Controls.Add(btnSave);
            Name = "Inventory";
            Text = "Inventory";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Button btnEdit;
        private Button btnClose;
        private Label lblItemCode;
        private Label lblManageItems;
        private TextBox txtItemCode;
        private Label lblSerialNo;
        private TextBox txtSerialNumber;
        private Label lblItemName;
        private TextBox txtItemName;
        private Label lblCategory;
        private ComboBox comboBox1;
    }
}