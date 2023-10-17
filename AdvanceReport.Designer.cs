namespace InventoryManagement
{
    partial class Advance_Report
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
            groupBox1 = new GroupBox();
            btnSearch = new Button();
            btnExcelExport = new Button();
            btnPdfExport = new Button();
            label1 = new Label();
            label9 = new Label();
            btnClose = new Button();
            cmbSubLocation = new ComboBox();
            label8 = new Label();
            cmbLocation = new ComboBox();
            label7 = new Label();
            dtpExpiryTo = new DateTimePicker();
            dtpExpiryFrom = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            cmbCategory = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dtpEnterTo = new DateTimePicker();
            dtpEnterFrom = new DateTimePicker();
            dgvStockDetails = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStockDetails).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(btnExcelExport);
            groupBox1.Controls.Add(btnPdfExport);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(btnClose);
            groupBox1.Controls.Add(cmbSubLocation);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(cmbLocation);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(dtpExpiryTo);
            groupBox1.Controls.Add(dtpExpiryFrom);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cmbCategory);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dtpEnterTo);
            groupBox1.Controls.Add(dtpEnterFrom);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(12, 16);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1345, 212);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "FilterBy";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(937, 37);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(109, 56);
            btnSearch.TabIndex = 23;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnExcelExport
            // 
            btnExcelExport.Location = new Point(1219, 146);
            btnExcelExport.Name = "btnExcelExport";
            btnExcelExport.Size = new Size(109, 56);
            btnExcelExport.TabIndex = 22;
            btnExcelExport.Text = "Excel Export";
            btnExcelExport.UseVisualStyleBackColor = true;
            // 
            // btnPdfExport
            // 
            btnPdfExport.Location = new Point(1219, 84);
            btnPdfExport.Name = "btnPdfExport";
            btnPdfExport.Size = new Size(109, 56);
            btnPdfExport.TabIndex = 21;
            btnPdfExport.Text = "PDF Export";
            btnPdfExport.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(407, 88);
            label1.Name = "label1";
            label1.Size = new Size(23, 19);
            label1.TabIndex = 20;
            label1.Text = "To";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.White;
            label9.Location = new Point(407, 57);
            label9.Name = "label9";
            label9.Size = new Size(41, 19);
            label9.TabIndex = 19;
            label9.Text = "From";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(1219, 20);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(109, 56);
            btnClose.TabIndex = 18;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // cmbSubLocation
            // 
            cmbSubLocation.FormattingEnabled = true;
            cmbSubLocation.Location = new Point(809, 131);
            cmbSubLocation.Name = "cmbSubLocation";
            cmbSubLocation.Size = new Size(237, 25);
            cmbSubLocation.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.White;
            label8.Location = new Point(715, 137);
            label8.Name = "label8";
            label8.Size = new Size(84, 19);
            label8.TabIndex = 16;
            label8.Text = "SubLocation";
            // 
            // cmbLocation
            // 
            cmbLocation.FormattingEnabled = true;
            cmbLocation.Location = new Point(458, 131);
            cmbLocation.Name = "cmbLocation";
            cmbLocation.Size = new Size(237, 25);
            cmbLocation.TabIndex = 15;
            cmbLocation.SelectedIndexChanged += cmbLocation_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(387, 134);
            label7.Name = "label7";
            label7.Size = new Size(61, 19);
            label7.TabIndex = 14;
            label7.Text = "Location";
            // 
            // dtpExpiryTo
            // 
            dtpExpiryTo.Location = new Point(458, 82);
            dtpExpiryTo.Name = "dtpExpiryTo";
            dtpExpiryTo.Size = new Size(237, 25);
            dtpExpiryTo.TabIndex = 13;
            // 
            // dtpExpiryFrom
            // 
            dtpExpiryFrom.Location = new Point(458, 51);
            dtpExpiryFrom.Name = "dtpExpiryFrom";
            dtpExpiryFrom.Size = new Size(237, 25);
            dtpExpiryFrom.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(458, 26);
            label6.Name = "label6";
            label6.Size = new Size(78, 19);
            label6.TabIndex = 11;
            label6.Text = "Expiry Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(44, 26);
            label5.Name = "label5";
            label5.Size = new Size(89, 19);
            label5.TabIndex = 10;
            label5.Text = "Entered Date";
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(119, 134);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(237, 25);
            cmbCategory.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(44, 134);
            label4.Name = "label4";
            label4.Size = new Size(65, 19);
            label4.TabIndex = 8;
            label4.Text = "Category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(44, 88);
            label3.Name = "label3";
            label3.Size = new Size(23, 19);
            label3.TabIndex = 7;
            label3.Text = "To";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(44, 57);
            label2.Name = "label2";
            label2.Size = new Size(41, 19);
            label2.TabIndex = 6;
            label2.Text = "From";
            // 
            // dtpEnterTo
            // 
            dtpEnterTo.Location = new Point(119, 82);
            dtpEnterTo.Name = "dtpEnterTo";
            dtpEnterTo.Size = new Size(237, 25);
            dtpEnterTo.TabIndex = 5;
            // 
            // dtpEnterFrom
            // 
            dtpEnterFrom.Location = new Point(119, 51);
            dtpEnterFrom.Name = "dtpEnterFrom";
            dtpEnterFrom.Size = new Size(237, 25);
            dtpEnterFrom.TabIndex = 4;
            // 
            // dgvStockDetails
            // 
            dgvStockDetails.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvStockDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStockDetails.Location = new Point(12, 234);
            dgvStockDetails.Name = "dgvStockDetails";
            dgvStockDetails.RowTemplate.Height = 25;
            dgvStockDetails.Size = new Size(1345, 472);
            dgvStockDetails.TabIndex = 5;
            // 
            // Advance_Report
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(1369, 729);
            Controls.Add(groupBox1);
            Controls.Add(dgvStockDetails);
            ForeColor = Color.DimGray;
            Name = "Advance_Report";
            Text = "Advance_Report";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStockDetails).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnClose;
        private ComboBox cmbSubLocation;
        private Label label8;
        private ComboBox cmbLocation;
        private Label label7;
        private DateTimePicker dtpExpiryTo;
        private DateTimePicker dtpExpiryFrom;
        private Label label6;
        private Label label5;
        private ComboBox cmbCategory;
        private Label label4;
        private Label label3;
        private Label label2;
        private DateTimePicker dtpEnterTo;
        private DateTimePicker dtpEnterFrom;
        private DataGridView dgvStockDetails;
        private Button btnSearch;
        private Button btnExcelExport;
        private Button btnPdfExport;
        private Label label1;
        private Label label9;
    }
}