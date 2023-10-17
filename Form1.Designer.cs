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
            btnAdvReport = new Button();
            button2 = new Button();
            button1 = new Button();
            btnAddCategory = new Button();
            btnAddUser = new Button();
            btnAddItem = new Button();
            label1 = new Label();
            btnLogout = new Button();
            dgvStockDetails = new DataGridView();
            lblHelp = new Label();
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            dateTimePicker3 = new DateTimePicker();
            dateTimePicker4 = new DateTimePicker();
            label7 = new Label();
            comboBox2 = new ComboBox();
            label8 = new Label();
            comboBox3 = new ComboBox();
            btnSearch = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStockDetails).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(btnAdvReport);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnAddCategory);
            panel1.Controls.Add(btnAddUser);
            panel1.Controls.Add(btnAddItem);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnLogout);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(216, 729);
            panel1.TabIndex = 0;
            // 
            // btnAdvReport
            // 
            btnAdvReport.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnAdvReport.AutoSize = true;
            btnAdvReport.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdvReport.Location = new Point(25, 406);
            btnAdvReport.Name = "btnAdvReport";
            btnAdvReport.Size = new Size(167, 53);
            btnAdvReport.TabIndex = 8;
            btnAdvReport.Text = "Advance Report";
            btnAdvReport.UseVisualStyleBackColor = true;
            btnAdvReport.Click += button3_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button2.AutoSize = true;
            button2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(25, 347);
            button2.Name = "button2";
            button2.Size = new Size(167, 53);
            button2.TabIndex = 7;
            button2.Text = "Manage Sub Location";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button1.AutoSize = true;
            button1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(25, 288);
            button1.Name = "button1";
            button1.Size = new Size(167, 53);
            button1.TabIndex = 6;
            button1.Text = "Manage Location";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnAddCategory
            // 
            btnAddCategory.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnAddCategory.AutoSize = true;
            btnAddCategory.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddCategory.Location = new Point(25, 229);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(167, 53);
            btnAddCategory.TabIndex = 5;
            btnAddCategory.Text = "Manage Category";
            btnAddCategory.UseVisualStyleBackColor = true;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // btnAddUser
            // 
            btnAddUser.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnAddUser.AutoSize = true;
            btnAddUser.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddUser.Location = new Point(25, 469);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(167, 53);
            btnAddUser.TabIndex = 4;
            btnAddUser.Text = "Company Update";
            btnAddUser.UseVisualStyleBackColor = true;
            // 
            // btnAddItem
            // 
            btnAddItem.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnAddItem.AutoSize = true;
            btnAddItem.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddItem.Location = new Point(25, 170);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(167, 53);
            btnAddItem.TabIndex = 3;
            btnAddItem.Text = "Manage Item";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(29, 25);
            label1.Name = "label1";
            label1.Size = new Size(160, 64);
            label1.TabIndex = 2;
            label1.Text = "Fixed Asset \r\nManagement";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnLogout.AutoSize = true;
            btnLogout.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.Location = new Point(25, 691);
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
            dgvStockDetails.Location = new Point(238, 230);
            dgvStockDetails.Name = "dgvStockDetails";
            dgvStockDetails.RowTemplate.Height = 25;
            dgvStockDetails.Size = new Size(1109, 472);
            dgvStockDetails.TabIndex = 1;
            // 
            // lblHelp
            // 
            lblHelp.AutoSize = true;
            lblHelp.ForeColor = SystemColors.ButtonHighlight;
            lblHelp.Location = new Point(982, 709);
            lblHelp.Name = "lblHelp";
            lblHelp.Size = new Size(366, 15);
            lblHelp.TabIndex = 2;
            lblHelp.Text = "Software By EasyPack Solutions. For Customer Support - 0777217731";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(comboBox3);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(dateTimePicker4);
            groupBox1.Controls.Add(dateTimePicker3);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(238, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1109, 212);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "FilterBy";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(88, 134);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(237, 25);
            comboBox1.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(13, 134);
            label4.Name = "label4";
            label4.Size = new Size(65, 19);
            label4.TabIndex = 8;
            label4.Text = "Category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(13, 88);
            label3.Name = "label3";
            label3.Size = new Size(23, 19);
            label3.TabIndex = 7;
            label3.Text = "To";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(13, 57);
            label2.Name = "label2";
            label2.Size = new Size(41, 19);
            label2.TabIndex = 6;
            label2.Text = "From";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(88, 82);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(237, 25);
            dateTimePicker2.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(88, 51);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(237, 25);
            dateTimePicker1.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(13, 26);
            label5.Name = "label5";
            label5.Size = new Size(89, 19);
            label5.TabIndex = 10;
            label5.Text = "Entered Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(356, 26);
            label6.Name = "label6";
            label6.Size = new Size(78, 19);
            label6.TabIndex = 11;
            label6.Text = "Expiry Date";
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(356, 51);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(237, 25);
            dateTimePicker3.TabIndex = 12;
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.Location = new Point(356, 82);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(237, 25);
            dateTimePicker4.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(356, 134);
            label7.Name = "label7";
            label7.Size = new Size(61, 19);
            label7.TabIndex = 14;
            label7.Text = "Location";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(427, 131);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(237, 25);
            comboBox2.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.White;
            label8.Location = new Point(333, 177);
            label8.Name = "label8";
            label8.Size = new Size(84, 19);
            label8.TabIndex = 16;
            label8.Text = "SubLocation";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(427, 171);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(237, 25);
            comboBox3.TabIndex = 17;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(706, 51);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(109, 56);
            btnSearch.TabIndex = 18;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // FrmDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(1369, 729);
            Controls.Add(groupBox1);
            Controls.Add(lblHelp);
            Controls.Add(dgvStockDetails);
            Controls.Add(panel1);
            Name = "FrmDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            FormClosed += FrmDashboard_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStockDetails).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private Label lblHelp;
        private GroupBox groupBox1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnAdvReport;
        private Button btnSearch;
        private ComboBox comboBox3;
        private Label label8;
        private ComboBox comboBox2;
        private Label label7;
        private DateTimePicker dateTimePicker4;
        private DateTimePicker dateTimePicker3;
        private Label label6;
        private Label label5;
    }
}