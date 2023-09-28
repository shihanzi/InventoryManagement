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
            btnClose = new Button();
            lblItemCode = new Label();
            lblManageItems = new Label();
            txtItemCode = new TextBox();
            lblSerialNo = new Label();
            txtSerialNumber = new TextBox();
            lblItemName = new Label();
            txtItemName = new TextBox();
            lblCategory = new Label();
            cmbCategory = new ComboBox();
            lblQuantity = new Label();
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            txtSuppliername = new TextBox();
            lblCost = new Label();
            txtCost = new TextBox();
            lblDateAdded = new Label();
            lblDateOfPurchase = new Label();
            dtpDateOfPurchase = new DateTimePicker();
            lblCurrentDate = new Label();
            lblDescription = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.LimeGreen;
            btnSave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(167, 633);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(147, 55);
            btnSave.TabIndex = 0;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.OrangeRed;
            btnClose.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.Location = new Point(337, 633);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(154, 55);
            btnClose.TabIndex = 2;
            btnClose.Text = "CLOSE";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // lblItemCode
            // 
            lblItemCode.AutoSize = true;
            lblItemCode.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblItemCode.Location = new Point(27, 83);
            lblItemCode.Name = "lblItemCode";
            lblItemCode.Size = new Size(83, 21);
            lblItemCode.TabIndex = 3;
            lblItemCode.Text = "ItemCode";
            // 
            // lblManageItems
            // 
            lblManageItems.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblManageItems.AutoSize = true;
            lblManageItems.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblManageItems.Location = new Point(167, 21);
            lblManageItems.Name = "lblManageItems";
            lblManageItems.Size = new Size(147, 34);
            lblManageItems.TabIndex = 4;
            lblManageItems.Text = "Manage Items";
            lblManageItems.UseCompatibleTextRendering = true;
            // 
            // txtItemCode
            // 
            txtItemCode.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtItemCode.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtItemCode.Location = new Point(168, 71);
            txtItemCode.Name = "txtItemCode";
            txtItemCode.Size = new Size(324, 33);
            txtItemCode.TabIndex = 5;
            // 
            // lblSerialNo
            // 
            lblSerialNo.AutoSize = true;
            lblSerialNo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSerialNo.Location = new Point(27, 126);
            lblSerialNo.Name = "lblSerialNo";
            lblSerialNo.Size = new Size(76, 21);
            lblSerialNo.TabIndex = 6;
            lblSerialNo.Text = "Serial No";
            // 
            // txtSerialNumber
            // 
            txtSerialNumber.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSerialNumber.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtSerialNumber.Location = new Point(168, 114);
            txtSerialNumber.Name = "txtSerialNumber";
            txtSerialNumber.Size = new Size(324, 33);
            txtSerialNumber.TabIndex = 7;
            // 
            // lblItemName
            // 
            lblItemName.AutoSize = true;
            lblItemName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblItemName.Location = new Point(27, 170);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(91, 21);
            lblItemName.TabIndex = 8;
            lblItemName.Text = "Item Name";
            // 
            // txtItemName
            // 
            txtItemName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtItemName.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtItemName.Location = new Point(167, 158);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(325, 33);
            txtItemName.TabIndex = 9;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCategory.Location = new Point(27, 211);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(78, 21);
            lblCategory.TabIndex = 10;
            lblCategory.Text = "Category";
            // 
            // cmbCategory
            // 
            cmbCategory.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(168, 203);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(323, 29);
            cmbCategory.TabIndex = 11;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblQuantity.Location = new Point(27, 256);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(72, 21);
            lblQuantity.TabIndex = 12;
            lblQuantity.Text = "Quantity";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            numericUpDown1.Location = new Point(167, 248);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 29);
            numericUpDown1.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(27, 306);
            label1.Name = "label1";
            label1.Size = new Size(115, 21);
            label1.TabIndex = 14;
            label1.Text = "Supplier name";
            // 
            // txtSuppliername
            // 
            txtSuppliername.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSuppliername.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtSuppliername.Location = new Point(167, 294);
            txtSuppliername.Name = "txtSuppliername";
            txtSuppliername.Size = new Size(325, 33);
            txtSuppliername.TabIndex = 15;
            // 
            // lblCost
            // 
            lblCost.AutoSize = true;
            lblCost.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCost.Location = new Point(27, 360);
            lblCost.Name = "lblCost";
            lblCost.Size = new Size(43, 21);
            lblCost.TabIndex = 16;
            lblCost.Text = "Cost";
            // 
            // txtCost
            // 
            txtCost.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtCost.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtCost.Location = new Point(167, 348);
            txtCost.Name = "txtCost";
            txtCost.Size = new Size(325, 33);
            txtCost.TabIndex = 17;
            txtCost.TextChanged += txtCost_TextChanged;
            txtCost.KeyPress += txtCost_KeyPress;
            // 
            // lblDateAdded
            // 
            lblDateAdded.AutoSize = true;
            lblDateAdded.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDateAdded.Location = new Point(27, 437);
            lblDateAdded.Name = "lblDateAdded";
            lblDateAdded.Size = new Size(98, 21);
            lblDateAdded.TabIndex = 18;
            lblDateAdded.Text = "Date Added";
            // 
            // lblDateOfPurchase
            // 
            lblDateOfPurchase.AutoSize = true;
            lblDateOfPurchase.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDateOfPurchase.Location = new Point(27, 401);
            lblDateOfPurchase.Name = "lblDateOfPurchase";
            lblDateOfPurchase.Size = new Size(135, 21);
            lblDateOfPurchase.TabIndex = 19;
            lblDateOfPurchase.Text = "Date Of Purchase";
            // 
            // dtpDateOfPurchase
            // 
            dtpDateOfPurchase.CalendarFont = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dtpDateOfPurchase.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dtpDateOfPurchase.Location = new Point(168, 399);
            dtpDateOfPurchase.Name = "dtpDateOfPurchase";
            dtpDateOfPurchase.Size = new Size(323, 29);
            dtpDateOfPurchase.TabIndex = 20;
            // 
            // lblCurrentDate
            // 
            lblCurrentDate.AutoSize = true;
            lblCurrentDate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCurrentDate.Location = new Point(167, 437);
            lblCurrentDate.Name = "lblCurrentDate";
            lblCurrentDate.Size = new Size(98, 21);
            lblCurrentDate.TabIndex = 21;
            lblCurrentDate.Text = "Date Added";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescription.Location = new Point(27, 470);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(94, 21);
            lblDescription.TabIndex = 22;
            lblDescription.Text = "Description";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(168, 470);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(324, 140);
            textBox1.TabIndex = 23;
            // 
            // Inventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 731);
            Controls.Add(textBox1);
            Controls.Add(lblDescription);
            Controls.Add(lblCurrentDate);
            Controls.Add(dtpDateOfPurchase);
            Controls.Add(lblDateOfPurchase);
            Controls.Add(lblDateAdded);
            Controls.Add(txtCost);
            Controls.Add(lblCost);
            Controls.Add(txtSuppliername);
            Controls.Add(label1);
            Controls.Add(numericUpDown1);
            Controls.Add(lblQuantity);
            Controls.Add(cmbCategory);
            Controls.Add(lblCategory);
            Controls.Add(txtItemName);
            Controls.Add(lblItemName);
            Controls.Add(txtSerialNumber);
            Controls.Add(lblSerialNo);
            Controls.Add(txtItemCode);
            Controls.Add(lblManageItems);
            Controls.Add(lblItemCode);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Name = "Inventory";
            Text = "Inventory";
            Load += Inventory_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Button btnClose;
        private Label lblItemCode;
        private Label lblManageItems;
        private TextBox txtItemCode;
        private Label lblSerialNo;
        private TextBox txtSerialNumber;
        private Label lblItemName;
        private TextBox txtItemName;
        private Label lblCategory;
        private ComboBox cmbCategory;
        private Label lblQuantity;
        private NumericUpDown numericUpDown1;
        private Label label1;
        private TextBox txtSuppliername;
        private Label lblCost;
        private TextBox txtCost;
        private Label lblDateAdded;
        private Label lblDateOfPurchase;
        private DateTimePicker dtpDateOfPurchase;
        private Label lblCurrentDate;
        private Label lblDescription;
        private TextBox textBox1;
    }
}