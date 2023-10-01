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
            nudQty = new NumericUpDown();
            label1 = new Label();
            txtSuppliername = new TextBox();
            lblCost = new Label();
            txtCost = new TextBox();
            lblDateAdded = new Label();
            lblDateOfPurchase = new Label();
            dtpDateOfPurchase = new DateTimePicker();
            lblCurrentDate = new Label();
            lblDescription = new Label();
            txtDescription = new TextBox();
            dgvItemDetails = new DataGridView();
            btnUpdate = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            cmbFilter = new ComboBox();
            lblFilter = new Label();
            label2 = new Label();
            label3 = new Label();
            dtpFrom = new DateTimePicker();
            label4 = new Label();
            dtpTo = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            txtSearch = new TextBox();
            btnFilterByCmb = new Button();
            btnDateFilter = new Button();
            btnSearch = new Button();
            btnExportExcel = new Button();
            btnExportPdf = new Button();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)nudQty).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvItemDetails).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSave.BackColor = SystemColors.ActiveBorder;
            btnSave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.Black;
            btnSave.Location = new Point(280, 765);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(147, 55);
            btnSave.TabIndex = 0;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClose.BackColor = SystemColors.ActiveBorder;
            btnClose.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.Location = new Point(1236, 765);
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
            lblItemCode.BackColor = Color.Transparent;
            lblItemCode.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblItemCode.ForeColor = Color.Transparent;
            lblItemCode.Location = new Point(27, 232);
            lblItemCode.Name = "lblItemCode";
            lblItemCode.Size = new Size(83, 21);
            lblItemCode.TabIndex = 3;
            lblItemCode.Text = "ItemCode";
            // 
            // lblManageItems
            // 
            lblManageItems.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblManageItems.AutoSize = true;
            lblManageItems.BackColor = Color.Transparent;
            lblManageItems.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblManageItems.ForeColor = Color.Transparent;
            lblManageItems.Location = new Point(137, 163);
            lblManageItems.Name = "lblManageItems";
            lblManageItems.Size = new Size(147, 34);
            lblManageItems.TabIndex = 4;
            lblManageItems.Text = "Manage Items";
            lblManageItems.UseCompatibleTextRendering = true;
            // 
            // txtItemCode
            // 
            txtItemCode.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtItemCode.Location = new Point(169, 220);
            txtItemCode.Name = "txtItemCode";
            txtItemCode.Size = new Size(259, 33);
            txtItemCode.TabIndex = 5;
            // 
            // lblSerialNo
            // 
            lblSerialNo.AutoSize = true;
            lblSerialNo.BackColor = Color.Transparent;
            lblSerialNo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSerialNo.ForeColor = Color.Transparent;
            lblSerialNo.Location = new Point(27, 275);
            lblSerialNo.Name = "lblSerialNo";
            lblSerialNo.Size = new Size(76, 21);
            lblSerialNo.TabIndex = 6;
            lblSerialNo.Text = "Serial No";
            // 
            // txtSerialNumber
            // 
            txtSerialNumber.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtSerialNumber.Location = new Point(168, 263);
            txtSerialNumber.Name = "txtSerialNumber";
            txtSerialNumber.Size = new Size(259, 33);
            txtSerialNumber.TabIndex = 7;
            // 
            // lblItemName
            // 
            lblItemName.AutoSize = true;
            lblItemName.BackColor = Color.Transparent;
            lblItemName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblItemName.ForeColor = Color.Transparent;
            lblItemName.Location = new Point(27, 319);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(91, 21);
            lblItemName.TabIndex = 8;
            lblItemName.Text = "Item Name";
            // 
            // txtItemName
            // 
            txtItemName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtItemName.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtItemName.Location = new Point(167, 307);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(260, 33);
            txtItemName.TabIndex = 9;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.BackColor = Color.Transparent;
            lblCategory.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCategory.ForeColor = Color.Transparent;
            lblCategory.Location = new Point(27, 360);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(78, 21);
            lblCategory.TabIndex = 10;
            lblCategory.Text = "Category";
            // 
            // cmbCategory
            // 
            cmbCategory.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbCategory.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(168, 352);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(259, 29);
            cmbCategory.TabIndex = 11;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.BackColor = Color.Transparent;
            lblQuantity.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblQuantity.ForeColor = Color.Transparent;
            lblQuantity.Location = new Point(27, 405);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(72, 21);
            lblQuantity.TabIndex = 12;
            lblQuantity.Text = "Quantity";
            // 
            // nudQty
            // 
            nudQty.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nudQty.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            nudQty.Location = new Point(167, 397);
            nudQty.Name = "nudQty";
            nudQty.Size = new Size(260, 29);
            nudQty.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(27, 455);
            label1.Name = "label1";
            label1.Size = new Size(115, 21);
            label1.TabIndex = 14;
            label1.Text = "Supplier name";
            // 
            // txtSuppliername
            // 
            txtSuppliername.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSuppliername.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtSuppliername.Location = new Point(167, 443);
            txtSuppliername.Name = "txtSuppliername";
            txtSuppliername.Size = new Size(260, 33);
            txtSuppliername.TabIndex = 15;
            // 
            // lblCost
            // 
            lblCost.AutoSize = true;
            lblCost.BackColor = Color.Transparent;
            lblCost.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCost.ForeColor = Color.Transparent;
            lblCost.Location = new Point(27, 509);
            lblCost.Name = "lblCost";
            lblCost.Size = new Size(43, 21);
            lblCost.TabIndex = 16;
            lblCost.Text = "Cost";
            // 
            // txtCost
            // 
            txtCost.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCost.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtCost.Location = new Point(167, 497);
            txtCost.Name = "txtCost";
            txtCost.Size = new Size(260, 33);
            txtCost.TabIndex = 17;
            txtCost.TextChanged += txtCost_TextChanged;
            txtCost.KeyPress += txtCost_KeyPress;
            // 
            // lblDateAdded
            // 
            lblDateAdded.AutoSize = true;
            lblDateAdded.BackColor = Color.Transparent;
            lblDateAdded.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDateAdded.ForeColor = Color.Transparent;
            lblDateAdded.Location = new Point(27, 586);
            lblDateAdded.Name = "lblDateAdded";
            lblDateAdded.Size = new Size(98, 21);
            lblDateAdded.TabIndex = 18;
            lblDateAdded.Text = "Date Added";
            // 
            // lblDateOfPurchase
            // 
            lblDateOfPurchase.AutoSize = true;
            lblDateOfPurchase.BackColor = Color.Transparent;
            lblDateOfPurchase.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDateOfPurchase.ForeColor = Color.Transparent;
            lblDateOfPurchase.Location = new Point(27, 550);
            lblDateOfPurchase.Name = "lblDateOfPurchase";
            lblDateOfPurchase.Size = new Size(135, 21);
            lblDateOfPurchase.TabIndex = 19;
            lblDateOfPurchase.Text = "Date Of Purchase";
            // 
            // dtpDateOfPurchase
            // 
            dtpDateOfPurchase.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpDateOfPurchase.CalendarFont = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dtpDateOfPurchase.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dtpDateOfPurchase.Location = new Point(168, 548);
            dtpDateOfPurchase.Name = "dtpDateOfPurchase";
            dtpDateOfPurchase.Size = new Size(259, 29);
            dtpDateOfPurchase.TabIndex = 20;
            // 
            // lblCurrentDate
            // 
            lblCurrentDate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblCurrentDate.AutoSize = true;
            lblCurrentDate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCurrentDate.Location = new Point(167, 586);
            lblCurrentDate.Name = "lblCurrentDate";
            lblCurrentDate.Size = new Size(98, 21);
            lblCurrentDate.TabIndex = 21;
            lblCurrentDate.Text = "Date Added";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.BackColor = Color.Transparent;
            lblDescription.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescription.ForeColor = Color.Transparent;
            lblDescription.Location = new Point(27, 619);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(94, 21);
            lblDescription.TabIndex = 22;
            lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            txtDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDescription.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtDescription.Location = new Point(168, 619);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(259, 140);
            txtDescription.TabIndex = 23;
            // 
            // dgvItemDetails
            // 
            dgvItemDetails.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dgvItemDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItemDetails.Location = new Point(433, 220);
            dgvItemDetails.Name = "dgvItemDetails";
            dgvItemDetails.RowTemplate.Height = 25;
            dgvItemDetails.Size = new Size(955, 539);
            dgvItemDetails.TabIndex = 24;
            dgvItemDetails.CellContentClick += dgvItemDetails_CellContentClick;
            dgvItemDetails.CellDoubleClick += dgvItemDetails_CellDoubleClick;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnUpdate.BackColor = SystemColors.ActiveBorder;
            btnUpdate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(602, 765);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(147, 55);
            btnUpdate.TabIndex = 25;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnClear.BackColor = SystemColors.ActiveBorder;
            btnClear.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Location = new Point(950, 765);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(147, 55);
            btnClear.TabIndex = 26;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDelete.BackColor = SystemColors.ActiveBorder;
            btnDelete.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(777, 765);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(147, 55);
            btnDelete.TabIndex = 27;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // cmbFilter
            // 
            cmbFilter.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmbFilter.FormattingEnabled = true;
            cmbFilter.Location = new Point(501, 183);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(209, 29);
            cmbFilter.TabIndex = 28;
            cmbFilter.SelectedIndexChanged += cmbFilter_SelectedIndexChanged;
            // 
            // lblFilter
            // 
            lblFilter.AutoSize = true;
            lblFilter.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblFilter.ForeColor = Color.White;
            lblFilter.Location = new Point(432, 140);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(69, 21);
            lblFilter.TabIndex = 29;
            lblFilter.Text = "Filter By";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(419, 185);
            label2.Name = "label2";
            label2.Size = new Size(78, 21);
            label2.TabIndex = 30;
            label2.Text = "Category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(710, 101);
            label3.Name = "label3";
            label3.Size = new Size(48, 21);
            label3.TabIndex = 31;
            label3.Text = "Date:";
            // 
            // dtpFrom
            // 
            dtpFrom.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpFrom.CalendarFont = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dtpFrom.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dtpFrom.Location = new Point(823, 95);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(259, 29);
            dtpFrom.TabIndex = 32;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(764, 101);
            label4.Name = "label4";
            label4.Size = new Size(52, 21);
            label4.TabIndex = 33;
            label4.Text = "From:";
            // 
            // dtpTo
            // 
            dtpTo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpTo.CalendarFont = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dtpTo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dtpTo.Location = new Point(1125, 97);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(259, 29);
            dtpTo.TabIndex = 34;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(1088, 103);
            label5.Name = "label5";
            label5.Size = new Size(31, 21);
            label5.TabIndex = 35;
            label5.Text = "To:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(979, 149);
            label6.Name = "label6";
            label6.Size = new Size(129, 21);
            label6.TabIndex = 36;
            label6.Text = "Enter Item Code";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtSearch.Location = new Point(979, 173);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(259, 33);
            txtSearch.TabIndex = 37;
            // 
            // btnFilterByCmb
            // 
            btnFilterByCmb.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnFilterByCmb.BackColor = SystemColors.ActiveBorder;
            btnFilterByCmb.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnFilterByCmb.Location = new Point(716, 183);
            btnFilterByCmb.Name = "btnFilterByCmb";
            btnFilterByCmb.Size = new Size(140, 29);
            btnFilterByCmb.TabIndex = 38;
            btnFilterByCmb.Text = "Filter";
            btnFilterByCmb.UseVisualStyleBackColor = false;
            btnFilterByCmb.Click += btnFilterByCmb_Click;
            // 
            // btnDateFilter
            // 
            btnDateFilter.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDateFilter.BackColor = SystemColors.ActiveBorder;
            btnDateFilter.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDateFilter.Location = new Point(1244, 132);
            btnDateFilter.Name = "btnDateFilter";
            btnDateFilter.Size = new Size(141, 29);
            btnDateFilter.TabIndex = 39;
            btnDateFilter.Text = "Date Filter";
            btnDateFilter.UseVisualStyleBackColor = false;
            btnDateFilter.Click += btnDateFilter_Click;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSearch.BackColor = SystemColors.ActiveBorder;
            btnSearch.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(1244, 173);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(139, 33);
            btnSearch.TabIndex = 40;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnExportExcel
            // 
            btnExportExcel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnExportExcel.BackColor = SystemColors.ActiveBorder;
            btnExportExcel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExportExcel.Location = new Point(1244, 21);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Size = new Size(140, 29);
            btnExportExcel.TabIndex = 41;
            btnExportExcel.Text = "Export Excel";
            btnExportExcel.UseVisualStyleBackColor = false;
            btnExportExcel.Click += btnExportExcel_Click;
            // 
            // btnExportPdf
            // 
            btnExportPdf.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnExportPdf.BackColor = SystemColors.ActiveBorder;
            btnExportPdf.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExportPdf.Location = new Point(1244, 56);
            btnExportPdf.Name = "btnExportPdf";
            btnExportPdf.Size = new Size(141, 29);
            btnExportPdf.TabIndex = 42;
            btnExportPdf.Text = "Export Pdf";
            btnExportPdf.UseVisualStyleBackColor = false;
            btnExportPdf.Click += btnExportPdf_Click;
            // 
            // groupBox1
            // 
            groupBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(393, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(995, 217);
            groupBox1.TabIndex = 43;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter And Export";
            // 
            // Inventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(1412, 832);
            Controls.Add(btnExportPdf);
            Controls.Add(btnExportExcel);
            Controls.Add(btnSearch);
            Controls.Add(btnDateFilter);
            Controls.Add(btnFilterByCmb);
            Controls.Add(txtSearch);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dtpTo);
            Controls.Add(label4);
            Controls.Add(dtpFrom);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblFilter);
            Controls.Add(cmbFilter);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);
            Controls.Add(btnUpdate);
            Controls.Add(dgvItemDetails);
            Controls.Add(txtDescription);
            Controls.Add(lblDescription);
            Controls.Add(lblCurrentDate);
            Controls.Add(dtpDateOfPurchase);
            Controls.Add(lblDateOfPurchase);
            Controls.Add(lblDateAdded);
            Controls.Add(txtCost);
            Controls.Add(lblCost);
            Controls.Add(txtSuppliername);
            Controls.Add(label1);
            Controls.Add(nudQty);
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
            Controls.Add(groupBox1);
            Name = "Inventory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Item Management";
            ((System.ComponentModel.ISupportInitialize)nudQty).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvItemDetails).EndInit();
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
        private NumericUpDown nudQty;
        private Label label1;
        private TextBox txtSuppliername;
        private Label lblCost;
        private TextBox txtCost;
        private Label lblDateAdded;
        private Label lblDateOfPurchase;
        private DateTimePicker dtpDateOfPurchase;
        private Label lblCurrentDate;
        private Label lblDescription;
        private TextBox txtDescription;
        private DataGridView dgvItemDetails;
        private Button btnUpdate;
        private Button btnClear;
        private Button btnDelete;
        private ComboBox cmbFilter;
        private Label lblFilter;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpFrom;
        private Label label4;
        private DateTimePicker dtpTo;
        private Label label5;
        private Label label6;
        private TextBox txtSearch;
        private Button btnFilterByCmb;
        private Button btnDateFilter;
        private Button btnSearch;
        private Button btnExportExcel;
        private Button btnExportPdf;
        private GroupBox groupBox1;
    }
}