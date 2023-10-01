namespace InventoryManagement
{
    partial class Category
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
            label1 = new Label();
            lblCategoryId = new Label();
            lblCatId = new Label();
            label2 = new Label();
            txtItemName = new TextBox();
            dgvCategory = new DataGridView();
            btnClose = new Button();
            btnSave = new Button();
            btnEdit = new Button();
            label3 = new Label();
            lblCategoryIdBeingEdited = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCategory).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(116, 21);
            label1.Name = "label1";
            label1.Size = new Size(267, 32);
            label1.TabIndex = 0;
            label1.Text = "Category Management";
            // 
            // lblCategoryId
            // 
            lblCategoryId.AutoSize = true;
            lblCategoryId.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCategoryId.ForeColor = Color.White;
            lblCategoryId.Location = new Point(152, 90);
            lblCategoryId.Name = "lblCategoryId";
            lblCategoryId.Size = new Size(19, 21);
            lblCategoryId.TabIndex = 23;
            lblCategoryId.Text = "0";
            // 
            // lblCatId
            // 
            lblCatId.AutoSize = true;
            lblCatId.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCatId.ForeColor = Color.Transparent;
            lblCatId.Location = new Point(12, 90);
            lblCatId.Name = "lblCatId";
            lblCatId.Size = new Size(97, 21);
            lblCatId.TabIndex = 22;
            lblCatId.Text = "Category Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(12, 133);
            label2.Name = "label2";
            label2.Size = new Size(125, 21);
            label2.TabIndex = 24;
            label2.Text = "Category Name";
            // 
            // txtItemName
            // 
            txtItemName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtItemName.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtItemName.Location = new Point(152, 127);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(344, 33);
            txtItemName.TabIndex = 25;
            // 
            // dgvCategory
            // 
            dgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategory.Location = new Point(12, 179);
            dgvCategory.Name = "dgvCategory";
            dgvCategory.RowTemplate.Height = 25;
            dgvCategory.Size = new Size(484, 257);
            dgvCategory.TabIndex = 26;
            // 
            // btnClose
            // 
            btnClose.BackColor = SystemColors.ActiveBorder;
            btnClose.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = SystemColors.ActiveCaptionText;
            btnClose.Location = new Point(342, 464);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(154, 55);
            btnClose.TabIndex = 28;
            btnClose.Text = "CLOSE";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click_1;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.ActiveBorder;
            btnSave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = SystemColors.ActiveCaptionText;
            btnSave.Location = new Point(12, 464);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(147, 55);
            btnSave.TabIndex = 27;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.ActiveBorder;
            btnEdit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.ForeColor = SystemColors.ActiveCaptionText;
            btnEdit.Location = new Point(178, 464);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(147, 55);
            btnEdit.TabIndex = 29;
            btnEdit.Text = "EDIT";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(434, 9);
            label3.Name = "label3";
            label3.Size = new Size(0, 21);
            label3.TabIndex = 30;
            // 
            // lblCategoryIdBeingEdited
            // 
            lblCategoryIdBeingEdited.AutoSize = true;
            lblCategoryIdBeingEdited.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCategoryIdBeingEdited.ForeColor = Color.DimGray;
            lblCategoryIdBeingEdited.Location = new Point(434, 9);
            lblCategoryIdBeingEdited.Name = "lblCategoryIdBeingEdited";
            lblCategoryIdBeingEdited.Size = new Size(19, 21);
            lblCategoryIdBeingEdited.TabIndex = 31;
            lblCategoryIdBeingEdited.Text = "0";
            // 
            // Category
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(508, 531);
            Controls.Add(lblCategoryIdBeingEdited);
            Controls.Add(label3);
            Controls.Add(btnEdit);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(dgvCategory);
            Controls.Add(txtItemName);
            Controls.Add(label2);
            Controls.Add(lblCategoryId);
            Controls.Add(lblCatId);
            Controls.Add(label1);
            Name = "Category";
            Text = "Category Management";
            Load += Category_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblCategoryId;
        private Label lblCatId;
        private Label label2;
        private TextBox txtItemName;
        private DataGridView dgvCategory;
        private Button btnClose;
        private Button btnSave;
        private Button btnEdit;
        private Label label3;
        private Label lblCategoryIdBeingEdited;
    }
}