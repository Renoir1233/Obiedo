namespace Obiedo
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtSupplier;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label lblDateAdded;
        private System.Windows.Forms.DateTimePicker dtpDateAdded;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBoxData;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbSearchBy;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panelHeader = new Panel();
            lblSubtitle = new Label();
            lblTitle = new Label();
            groupBoxInput = new GroupBox();
            dtpDateAdded = new DateTimePicker();
            lblDateAdded = new Label();
            txtSupplier = new TextBox();
            lblSupplier = new Label();
            txtQuantity = new TextBox();
            lblQuantity = new Label();
            txtPrice = new TextBox();
            lblPrice = new Label();
            txtDescription = new TextBox();
            lblDescription = new Label();
            cmbCategory = new ComboBox();
            lblCategory = new Label();
            txtProductName = new TextBox();
            lblProductName = new Label();
            txtProductID = new TextBox();
            lblProductID = new Label();
            panelButtons = new Panel();
            btnClear = new Button();
            btnSearch = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            groupBoxData = new GroupBox();
            dataGridViewProducts = new DataGridView();
            panelSearch = new Panel();
            btnGo = new Button();
            cmbSearchBy = new ComboBox();
            txtSearch = new TextBox();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            panelHeader.SuspendLayout();
            groupBoxInput.SuspendLayout();
            panelButtons.SuspendLayout();
            groupBoxData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            panelSearch.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();

            // panelHeader
            panelHeader.BackColor = Color.SteelBlue;
            panelHeader.Controls.Add(lblSubtitle);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1316, 80);
            panelHeader.TabIndex = 0;
 
            // lblSubtitle
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.White;
            lblSubtitle.Location = new Point(23, 45);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(266, 23);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Track and Manage Your Inventory";

            // lblTitle
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(458, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Inventory Management System";

            // groupBoxInput
            groupBoxInput.BackColor = Color.FromArgb(245, 245, 245);
            groupBoxInput.Controls.Add(dtpDateAdded);
            groupBoxInput.Controls.Add(lblDateAdded);
            groupBoxInput.Controls.Add(txtSupplier);
            groupBoxInput.Controls.Add(lblSupplier);
            groupBoxInput.Controls.Add(txtQuantity);
            groupBoxInput.Controls.Add(lblQuantity);
            groupBoxInput.Controls.Add(txtPrice);
            groupBoxInput.Controls.Add(lblPrice);
            groupBoxInput.Controls.Add(txtDescription);
            groupBoxInput.Controls.Add(lblDescription);
            groupBoxInput.Controls.Add(cmbCategory);
            groupBoxInput.Controls.Add(lblCategory);
            groupBoxInput.Controls.Add(txtProductName);
            groupBoxInput.Controls.Add(lblProductName);
            groupBoxInput.Controls.Add(txtProductID);
            groupBoxInput.Controls.Add(lblProductID);
            groupBoxInput.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxInput.Location = new Point(12, 92);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Size = new Size(350, 380);
            groupBoxInput.TabIndex = 1;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Product Information";

            // dtpDateAdded
            dtpDateAdded.Enabled = false;
            dtpDateAdded.Font = new Font("Segoe UI", 9F);
            dtpDateAdded.Location = new Point(120, 330);
            dtpDateAdded.Name = "dtpDateAdded";
            dtpDateAdded.Size = new Size(200, 27);
            dtpDateAdded.TabIndex = 15;

            // lblDateAdded
            lblDateAdded.AutoSize = true;
            lblDateAdded.Font = new Font("Segoe UI", 9F);
            lblDateAdded.Location = new Point(25, 335);
            lblDateAdded.Name = "lblDateAdded";
            lblDateAdded.Size = new Size(93, 20);
            lblDateAdded.TabIndex = 14;
            lblDateAdded.Text = "Date Added:";

            // txtSupplier
            txtSupplier.Font = new Font("Segoe UI", 9F);
            txtSupplier.Location = new Point(120, 290);
            txtSupplier.Name = "txtSupplier";
            txtSupplier.Size = new Size(200, 27);
            txtSupplier.TabIndex = 13;

            // lblSupplier
            lblSupplier.AutoSize = true;
            lblSupplier.Font = new Font("Segoe UI", 9F);
            lblSupplier.Location = new Point(25, 295);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Size = new Size(67, 20);
            lblSupplier.TabIndex = 12;
            lblSupplier.Text = "Supplier:";

            // txtQuantity
            txtQuantity.Font = new Font("Segoe UI", 9F);
            txtQuantity.Location = new Point(120, 250);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(200, 27);
            txtQuantity.TabIndex = 11;

            // lblQuantity
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 9F);
            lblQuantity.Location = new Point(25, 255);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(68, 20);
            lblQuantity.TabIndex = 10;
            lblQuantity.Text = "Quantity:";

            // txtPrice
            txtPrice.Font = new Font("Segoe UI", 9F);
            txtPrice.Location = new Point(120, 210);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(200, 27);
            txtPrice.TabIndex = 9;

            // lblPrice
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 9F);
            lblPrice.Location = new Point(25, 215);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(44, 20);
            lblPrice.TabIndex = 8;
            lblPrice.Text = "Price:";

            // txtDescription
            txtDescription.Font = new Font("Segoe UI", 9F);
            txtDescription.Location = new Point(120, 130);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(200, 70);
            txtDescription.TabIndex = 7;
 
            // lblDescription
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 9F);
            lblDescription.Location = new Point(25, 135);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(88, 20);
            lblDescription.TabIndex = 6;
            lblDescription.Text = "Description:";

            // cmbCategory
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.Font = new Font("Segoe UI", 9F);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "Electronics", "Furniture", "Clothing", "Books", "Food", "Sports", "Toys", "Other" });
            cmbCategory.Location = new Point(120, 95);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(200, 28);
            cmbCategory.TabIndex = 5;

            // lblCategory
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 9F);
            lblCategory.Location = new Point(25, 100);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(72, 20);
            lblCategory.TabIndex = 4;
            lblCategory.Text = "Category:";

            // txtProductName
            txtProductName.Font = new Font("Segoe UI", 9F);
            txtProductName.Location = new Point(120, 60);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(200, 27);
            txtProductName.TabIndex = 3;

            // lblProductName
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Segoe UI", 9F);
            lblProductName.Location = new Point(25, 65);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(52, 20);
            lblProductName.TabIndex = 2;
            lblProductName.Text = "Name:";

            // txtProductID
            txtProductID.Enabled = false;
            txtProductID.Font = new Font("Segoe UI", 9F);
            txtProductID.Location = new Point(120, 25);
            txtProductID.Name = "txtProductID";
            txtProductID.ReadOnly = true;
            txtProductID.Size = new Size(200, 27);
            txtProductID.TabIndex = 1;
            txtProductID.TabStop = false;

            // lblProductID
            lblProductID.AutoSize = true;
            lblProductID.Font = new Font("Segoe UI", 9F);
            lblProductID.Location = new Point(25, 30);
            lblProductID.Name = "lblProductID";
            lblProductID.Size = new Size(82, 20);
            lblProductID.TabIndex = 0;
            lblProductID.Text = "Product ID:";

            // panelButtons
            panelButtons.Controls.Add(btnClear);
            panelButtons.Controls.Add(btnSearch);
            panelButtons.Controls.Add(btnDelete);
            panelButtons.Controls.Add(btnUpdate);
            panelButtons.Controls.Add(btnAdd);
            panelButtons.Location = new Point(12, 478);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(340, 60);
            panelButtons.TabIndex = 2;

            // btnClear
            btnClear.BackColor = Color.Gray;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(273, 10);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(60, 40);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
 
            // btnSearch
            btnSearch.BackColor = Color.CornflowerBlue;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(203, 10);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(64, 40);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;

            // btnDelete
            btnDelete.BackColor = Color.Firebrick;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(135, 10);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(62, 40);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;

            // btnUpdate
            btnUpdate.BackColor = Color.Goldenrod;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(61, 10);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(68, 40);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;

            // btnAdd
            btnAdd.BackColor = Color.ForestGreen;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(5, 10);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(50, 40);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;

            // groupBoxData
            groupBoxData.Controls.Add(dataGridViewProducts);
            groupBoxData.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxData.Location = new Point(372, 92);
            groupBoxData.Name = "groupBoxData";
            groupBoxData.Size = new Size(918, 517);
            groupBoxData.TabIndex = 3;
            groupBoxData.TabStop = false;
            groupBoxData.Text = "Inventory Records";

            // dataGridViewProducts
            dataGridViewProducts.AllowUserToAddRows = false;
            dataGridViewProducts.AllowUserToDeleteRows = false;
            dataGridViewProducts.AllowUserToResizeRows = false;
            dataGridViewProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProducts.BackgroundColor = Color.White;
            dataGridViewProducts.BorderStyle = BorderStyle.None;
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Dock = DockStyle.Fill;
            dataGridViewProducts.Location = new Point(3, 26);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.ReadOnly = true;
            dataGridViewProducts.RowHeadersVisible = false;
            dataGridViewProducts.RowHeadersWidth = 51;
            dataGridViewProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProducts.Size = new Size(912, 488);
            dataGridViewProducts.TabIndex = 0;
            dataGridViewProducts.CellClick += dataGridViewProducts_CellClick;

            // panelSearch
            panelSearch.Controls.Add(btnGo);
            panelSearch.Controls.Add(cmbSearchBy);
            panelSearch.Controls.Add(txtSearch);
            panelSearch.Location = new Point(372, 47);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new Size(577, 40);
            panelSearch.TabIndex = 4;

            // btnGo
            btnGo.BackColor = Color.SteelBlue;
            btnGo.FlatAppearance.BorderSize = 0;
            btnGo.FlatStyle = FlatStyle.Flat;
            btnGo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGo.ForeColor = Color.White;
            btnGo.Location = new Point(514, 5);
            btnGo.Name = "btnGo";
            btnGo.Size = new Size(60, 30);
            btnGo.TabIndex = 2;
            btnGo.Text = "GO";
            btnGo.UseVisualStyleBackColor = false;
            btnGo.Click += btnGo_Click;

            // cmbSearchBy
            cmbSearchBy.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSearchBy.Font = new Font("Segoe UI", 9F);
            cmbSearchBy.FormattingEnabled = true;
            cmbSearchBy.Items.AddRange(new object[] { "ProductName", "Category", "Supplier" });
            cmbSearchBy.Location = new Point(300, 5);
            cmbSearchBy.Name = "cmbSearchBy";
            cmbSearchBy.Size = new Size(208, 28);
            cmbSearchBy.TabIndex = 1;

            // txtSearch
            txtSearch.Font = new Font("Segoe UI", 9F);
            txtSearch.Location = new Point(5, 5);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search...";
            txtSearch.Size = new Size(289, 27);
            txtSearch.TabIndex = 0;

            // statusStrip1
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2, toolStripStatusLabel3 });
            statusStrip1.Location = new Point(0, 640);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1316, 30);
            statusStrip1.TabIndex = 5;
            statusStrip1.Text = "statusStrip1";

            // toolStripStatusLabel1
            toolStripStatusLabel1.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            toolStripStatusLabel1.BorderStyle = Border3DStyle.SunkenInner;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(54, 24);
            toolStripStatusLabel1.Text = "Ready";

            // toolStripStatusLabel2
            toolStripStatusLabel2.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            toolStripStatusLabel2.BorderStyle = Border3DStyle.SunkenInner;
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(118, 24);
            toolStripStatusLabel2.Text = "Total Records: 0";

            // toolStripStatusLabel3
            toolStripStatusLabel3.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            toolStripStatusLabel3.BorderStyle = Border3DStyle.SunkenInner;
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(162, 24);
            toolStripStatusLabel3.Text = "Last Updated: 00:00:00";

            // Form1
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1316, 670);
            Controls.Add(statusStrip1);
            Controls.Add(panelSearch);
            Controls.Add(groupBoxData);
            Controls.Add(panelButtons);
            Controls.Add(groupBoxInput);
            Controls.Add(panelHeader);
            Font = new Font("Segoe UI", 9F);
            ForeColor = Color.FromArgb(64, 64, 64);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory Management System";
            Load += Form1_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            groupBoxInput.ResumeLayout(false);
            groupBoxInput.PerformLayout();
            panelButtons.ResumeLayout(false);
            groupBoxData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }
    }
}