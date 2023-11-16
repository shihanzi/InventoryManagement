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
            label11 = new Label();
            cmbLocFilter = new ComboBox();
            btnLocFilter = new Button();
            label10 = new Label();
            cmbSubFilter = new ComboBox();
            btnSubLocFilter = new Button();
            dtpDateOfExpire = new DateTimePicker();
            label7 = new Label();
            label8 = new Label();
            cmbLocation = new ComboBox();
            label9 = new Label();
            cmbSubLocation = new ComboBox();
            lblItemId = new Label();
            label12 = new Label();
            pbItemPic = new PictureBox();
            btnBrowse = new Button();
            ((System.ComponentModel.ISupportInitialize)nudQty).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvItemDetails).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbItemPic).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSave.BackColor = SystemColors.ActiveBorder;
            btnSave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.Black;
            btnSave.Location = new Point(342, 662);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(119, 40);
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
            btnClose.Location = new Point(1232, 662);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(126, 40);
            btnClose.TabIndex = 2;
            btnClose.Text = "CLOSE";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // lblItemCode
            // 
            lblItemCode.AutoSize = true;
            lblItemCode.BackColor = Color.Transparent;
            lblItemCode.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblItemCode.ForeColor = Color.Transparent;
            lblItemCode.Location = new Point(12, 42);
            lblItemCode.Name = "lblItemCode";
            lblItemCode.Size = new Size(59, 15);
            lblItemCode.TabIndex = 3;
            lblItemCode.Text = "ItemCode";
            // 
            // lblManageItems
            // 
            lblManageItems.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblManageItems.AutoSize = true;
            lblManageItems.BackColor = Color.Transparent;
            lblManageItems.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblManageItems.ForeColor = Color.Transparent;
            lblManageItems.Location = new Point(12, 9);
            lblManageItems.Name = "lblManageItems";
            lblManageItems.Size = new Size(119, 28);
            lblManageItems.TabIndex = 4;
            lblManageItems.Text = "Manage Items";
            lblManageItems.UseCompatibleTextRendering = true;
            // 
            // txtItemCode
            // 
            txtItemCode.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtItemCode.Location = new Point(103, 39);
            txtItemCode.Name = "txtItemCode";
            txtItemCode.Size = new Size(217, 23);
            txtItemCode.TabIndex = 5;
            // 
            // lblSerialNo
            // 
            lblSerialNo.AutoSize = true;
            lblSerialNo.BackColor = Color.Transparent;
            lblSerialNo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSerialNo.ForeColor = Color.Transparent;
            lblSerialNo.Location = new Point(12, 77);
            lblSerialNo.Name = "lblSerialNo";
            lblSerialNo.Size = new Size(55, 15);
            lblSerialNo.TabIndex = 6;
            lblSerialNo.Text = "Serial No";
            // 
            // txtSerialNumber
            // 
            txtSerialNumber.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtSerialNumber.Location = new Point(103, 73);
            txtSerialNumber.Name = "txtSerialNumber";
            txtSerialNumber.Size = new Size(217, 23);
            txtSerialNumber.TabIndex = 7;
            // 
            // lblItemName
            // 
            lblItemName.AutoSize = true;
            lblItemName.BackColor = Color.Transparent;
            lblItemName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblItemName.ForeColor = Color.Transparent;
            lblItemName.Location = new Point(12, 110);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(67, 15);
            lblItemName.TabIndex = 8;
            lblItemName.Text = "Item Name";
            // 
            // txtItemName
            // 
            txtItemName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtItemName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtItemName.Location = new Point(103, 109);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(217, 23);
            txtItemName.TabIndex = 9;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.BackColor = Color.Transparent;
            lblCategory.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCategory.ForeColor = Color.Transparent;
            lblCategory.Location = new Point(13, 149);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(54, 15);
            lblCategory.TabIndex = 10;
            lblCategory.Text = "Category";
            // 
            // cmbCategory
            // 
            cmbCategory.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbCategory.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(104, 141);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(216, 23);
            cmbCategory.TabIndex = 11;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.BackColor = Color.Transparent;
            lblQuantity.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblQuantity.ForeColor = Color.Transparent;
            lblQuantity.Location = new Point(12, 240);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(53, 15);
            lblQuantity.TabIndex = 12;
            lblQuantity.Text = "Quantity";
            // 
            // nudQty
            // 
            nudQty.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nudQty.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            nudQty.Location = new Point(103, 237);
            nudQty.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudQty.Name = "nudQty";
            nudQty.Size = new Size(217, 23);
            nudQty.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(10, 270);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 14;
            label1.Text = "Supplier name";
            // 
            // txtSuppliername
            // 
            txtSuppliername.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSuppliername.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtSuppliername.Location = new Point(103, 270);
            txtSuppliername.Name = "txtSuppliername";
            txtSuppliername.Size = new Size(217, 23);
            txtSuppliername.TabIndex = 15;
            // 
            // lblCost
            // 
            lblCost.AutoSize = true;
            lblCost.BackColor = Color.Transparent;
            lblCost.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCost.ForeColor = Color.Transparent;
            lblCost.Location = new Point(10, 316);
            lblCost.Name = "lblCost";
            lblCost.Size = new Size(30, 15);
            lblCost.TabIndex = 16;
            lblCost.Text = "Cost";
            // 
            // txtCost
            // 
            txtCost.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCost.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtCost.Location = new Point(103, 308);
            txtCost.Name = "txtCost";
            txtCost.Size = new Size(217, 23);
            txtCost.TabIndex = 17;
            txtCost.TextChanged += txtCost_TextChanged;
            txtCost.KeyPress += txtCost_KeyPress;
            // 
            // lblDateAdded
            // 
            lblDateAdded.AutoSize = true;
            lblDateAdded.BackColor = Color.Transparent;
            lblDateAdded.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDateAdded.ForeColor = Color.Transparent;
            lblDateAdded.Location = new Point(10, 432);
            lblDateAdded.Name = "lblDateAdded";
            lblDateAdded.Size = new Size(70, 15);
            lblDateAdded.TabIndex = 18;
            lblDateAdded.Text = "Date Added";
            // 
            // lblDateOfPurchase
            // 
            lblDateOfPurchase.AutoSize = true;
            lblDateOfPurchase.BackColor = Color.Transparent;
            lblDateOfPurchase.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDateOfPurchase.ForeColor = Color.Transparent;
            lblDateOfPurchase.Location = new Point(4, 355);
            lblDateOfPurchase.Name = "lblDateOfPurchase";
            lblDateOfPurchase.Size = new Size(99, 15);
            lblDateOfPurchase.TabIndex = 19;
            lblDateOfPurchase.Text = "Date Of Purchase";
            // 
            // dtpDateOfPurchase
            // 
            dtpDateOfPurchase.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpDateOfPurchase.CalendarFont = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dtpDateOfPurchase.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dtpDateOfPurchase.Location = new Point(103, 351);
            dtpDateOfPurchase.Name = "dtpDateOfPurchase";
            dtpDateOfPurchase.Size = new Size(216, 23);
            dtpDateOfPurchase.TabIndex = 20;
            // 
            // lblCurrentDate
            // 
            lblCurrentDate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblCurrentDate.AutoSize = true;
            lblCurrentDate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCurrentDate.Location = new Point(104, 432);
            lblCurrentDate.Name = "lblCurrentDate";
            lblCurrentDate.Size = new Size(70, 15);
            lblCurrentDate.TabIndex = 21;
            lblCurrentDate.Text = "Date Added";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.BackColor = Color.Transparent;
            lblDescription.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescription.ForeColor = Color.Transparent;
            lblDescription.Location = new Point(10, 462);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(68, 15);
            lblDescription.TabIndex = 22;
            lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            txtDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDescription.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtDescription.Location = new Point(103, 462);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(216, 23);
            txtDescription.TabIndex = 23;
            // 
            // dgvItemDetails
            // 
            dgvItemDetails.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dgvItemDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItemDetails.Location = new Point(343, 220);
            dgvItemDetails.Name = "dgvItemDetails";
            dgvItemDetails.RowTemplate.Height = 25;
            dgvItemDetails.Size = new Size(1015, 436);
            dgvItemDetails.TabIndex = 24;
            dgvItemDetails.CellDoubleClick += dgvItemDetails_CellDoubleClick;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnUpdate.BackColor = SystemColors.ActiveBorder;
            btnUpdate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(472, 662);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(119, 40);
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
            btnClear.Location = new Point(607, 662);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(119, 40);
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
            btnDelete.Location = new Point(742, 662);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(119, 40);
            btnDelete.TabIndex = 27;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // cmbFilter
            // 
            cmbFilter.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cmbFilter.FormattingEnabled = true;
            cmbFilter.Location = new Point(90, 168);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(209, 23);
            cmbFilter.TabIndex = 28;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(30, 170);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 30;
            label2.Text = "Category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(615, 98);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 31;
            label3.Text = "Date:";
            // 
            // dtpFrom
            // 
            dtpFrom.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpFrom.CalendarFont = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dtpFrom.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dtpFrom.Format = DateTimePickerFormat.Short;
            dtpFrom.Location = new Point(720, 92);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(112, 23);
            dtpFrom.TabIndex = 32;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(664, 98);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 33;
            label4.Text = "From:";
            // 
            // dtpTo
            // 
            dtpTo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpTo.CalendarFont = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dtpTo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dtpTo.Format = DateTimePickerFormat.Short;
            dtpTo.Location = new Point(866, 94);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(134, 23);
            dtpTo.TabIndex = 34;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(837, 100);
            label5.Name = "label5";
            label5.Size = new Size(23, 15);
            label5.TabIndex = 35;
            label5.Text = "To:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(647, 153);
            label6.Name = "label6";
            label6.Size = new Size(92, 15);
            label6.TabIndex = 36;
            label6.Text = "Enter Item Code";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtSearch.Location = new Point(745, 152);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(259, 23);
            txtSearch.TabIndex = 37;
            // 
            // btnFilterByCmb
            // 
            btnFilterByCmb.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnFilterByCmb.BackColor = SystemColors.ActiveBorder;
            btnFilterByCmb.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnFilterByCmb.Location = new Point(305, 165);
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
            btnDateFilter.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDateFilter.Location = new Point(866, 118);
            btnDateFilter.Name = "btnDateFilter";
            btnDateFilter.Size = new Size(139, 29);
            btnDateFilter.TabIndex = 39;
            btnDateFilter.Text = "Date Filter";
            btnDateFilter.UseVisualStyleBackColor = false;
            btnDateFilter.Click += btnDateFilter_Click;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSearch.BackColor = SystemColors.ActiveBorder;
            btnSearch.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(866, 178);
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
            btnExportExcel.Location = new Point(1257, -82);
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
            btnExportPdf.Location = new Point(1257, -47);
            btnExportPdf.Name = "btnExportPdf";
            btnExportPdf.Size = new Size(141, 29);
            btnExportPdf.TabIndex = 42;
            btnExportPdf.Text = "Export Pdf";
            btnExportPdf.UseVisualStyleBackColor = false;
            btnExportPdf.Click += btnExportPdf_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(cmbLocFilter);
            groupBox1.Controls.Add(btnLocFilter);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(cmbSubFilter);
            groupBox1.Controls.Add(btnSubLocFilter);
            groupBox1.Controls.Add(txtSearch);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(btnDateFilter);
            groupBox1.Controls.Add(cmbFilter);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(btnFilterByCmb);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dtpFrom);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dtpTo);
            groupBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(343, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1016, 217);
            groupBox1.TabIndex = 43;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter And Export";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(30, 77);
            label11.Name = "label11";
            label11.Size = new Size(53, 15);
            label11.TabIndex = 45;
            label11.Text = "Location";
            // 
            // cmbLocFilter
            // 
            cmbLocFilter.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cmbLocFilter.FormattingEnabled = true;
            cmbLocFilter.Location = new Point(90, 75);
            cmbLocFilter.Name = "cmbLocFilter";
            cmbLocFilter.Size = new Size(209, 23);
            cmbLocFilter.TabIndex = 44;
            // 
            // btnLocFilter
            // 
            btnLocFilter.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLocFilter.BackColor = SystemColors.ActiveBorder;
            btnLocFilter.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLocFilter.Location = new Point(305, 72);
            btnLocFilter.Name = "btnLocFilter";
            btnLocFilter.Size = new Size(140, 29);
            btnLocFilter.TabIndex = 46;
            btnLocFilter.Text = "Filter";
            btnLocFilter.UseVisualStyleBackColor = false;
            btnLocFilter.Click += btnLocFilter_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(8, 122);
            label10.Name = "label10";
            label10.Size = new Size(77, 15);
            label10.TabIndex = 42;
            label10.Text = "Sub Location";
            // 
            // cmbSubFilter
            // 
            cmbSubFilter.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cmbSubFilter.FormattingEnabled = true;
            cmbSubFilter.Location = new Point(90, 120);
            cmbSubFilter.Name = "cmbSubFilter";
            cmbSubFilter.Size = new Size(209, 23);
            cmbSubFilter.TabIndex = 41;
            // 
            // btnSubLocFilter
            // 
            btnSubLocFilter.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSubLocFilter.BackColor = SystemColors.ActiveBorder;
            btnSubLocFilter.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubLocFilter.Location = new Point(305, 117);
            btnSubLocFilter.Name = "btnSubLocFilter";
            btnSubLocFilter.Size = new Size(140, 29);
            btnSubLocFilter.TabIndex = 43;
            btnSubLocFilter.Text = "Filter";
            btnSubLocFilter.UseVisualStyleBackColor = false;
            btnSubLocFilter.Click += btnSubLocFilter_Click;
            // 
            // dtpDateOfExpire
            // 
            dtpDateOfExpire.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpDateOfExpire.CalendarFont = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dtpDateOfExpire.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dtpDateOfExpire.Location = new Point(104, 394);
            dtpDateOfExpire.Name = "dtpDateOfExpire";
            dtpDateOfExpire.Size = new Size(216, 23);
            dtpDateOfExpire.TabIndex = 45;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Transparent;
            label7.Location = new Point(4, 400);
            label7.Name = "label7";
            label7.Size = new Size(83, 15);
            label7.TabIndex = 44;
            label7.Text = "Date Of Expire";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Transparent;
            label8.Location = new Point(13, 179);
            label8.Name = "label8";
            label8.Size = new Size(53, 15);
            label8.TabIndex = 46;
            label8.Text = "Location";
            // 
            // cmbLocation
            // 
            cmbLocation.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbLocation.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cmbLocation.FormattingEnabled = true;
            cmbLocation.Location = new Point(104, 176);
            cmbLocation.Name = "cmbLocation";
            cmbLocation.Size = new Size(216, 23);
            cmbLocation.TabIndex = 47;
            cmbLocation.SelectedIndexChanged += cmbLocation_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Transparent;
            label9.Location = new Point(13, 208);
            label9.Name = "label9";
            label9.Size = new Size(77, 15);
            label9.TabIndex = 48;
            label9.Text = "Sub Location";
            // 
            // cmbSubLocation
            // 
            cmbSubLocation.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbSubLocation.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cmbSubLocation.FormattingEnabled = true;
            cmbSubLocation.Location = new Point(103, 208);
            cmbSubLocation.Name = "cmbSubLocation";
            cmbSubLocation.Size = new Size(216, 23);
            cmbSubLocation.TabIndex = 49;
            // 
            // lblItemId
            // 
            lblItemId.AutoSize = true;
            lblItemId.Location = new Point(278, 8);
            lblItemId.Name = "lblItemId";
            lblItemId.Size = new Size(44, 15);
            lblItemId.TabIndex = 50;
            lblItemId.Text = "label10";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.Transparent;
            label12.Location = new Point(10, 499);
            label12.Name = "label12";
            label12.Size = new Size(41, 15);
            label12.TabIndex = 51;
            label12.Text = "Image";
            // 
            // pbItemPic
            // 
            pbItemPic.BackColor = Color.Gray;
            pbItemPic.BackgroundImageLayout = ImageLayout.Stretch;
            pbItemPic.BorderStyle = BorderStyle.FixedSingle;
            pbItemPic.Location = new Point(103, 498);
            pbItemPic.Name = "pbItemPic";
            pbItemPic.Size = new Size(216, 157);
            pbItemPic.SizeMode = PictureBoxSizeMode.StretchImage;
            pbItemPic.TabIndex = 52;
            pbItemPic.TabStop = false;
            // 
            // btnBrowse
            // 
            btnBrowse.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnBrowse.BackColor = SystemColors.ActiveBorder;
            btnBrowse.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBrowse.Location = new Point(216, 670);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(103, 29);
            btnBrowse.TabIndex = 47;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = false;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // Inventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(1369, 729);
            Controls.Add(btnBrowse);
            Controls.Add(pbItemPic);
            Controls.Add(label12);
            Controls.Add(lblItemId);
            Controls.Add(cmbSubLocation);
            Controls.Add(label9);
            Controls.Add(cmbLocation);
            Controls.Add(label8);
            Controls.Add(dtpDateOfExpire);
            Controls.Add(label7);
            Controls.Add(btnExportPdf);
            Controls.Add(btnExportExcel);
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
            Load += Inventory_Load;
            ((System.ComponentModel.ISupportInitialize)nudQty).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvItemDetails).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbItemPic).EndInit();
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
        private DateTimePicker dtpDateOfExpire;
        private Label label7;
        private Label label8;
        private ComboBox cmbLocation;
        private Label label9;
        private ComboBox cmbSubLocation;
        private Label lblItemId;
        private Label label11;
        private ComboBox cmbLocFilter;
        private Button btnLocFilter;
        private Label label10;
        private ComboBox cmbSubFilter;
        private Button btnSubLocFilter;
        private Label label12;
        private PictureBox pbItemPic;
        private Button btnBrowse;
    }
}