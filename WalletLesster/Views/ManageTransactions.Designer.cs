
namespace WalletLesster.Views
{
    partial class ManageTransactions
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageTransactions));
            this.panelTip = new System.Windows.Forms.Panel();
            this.lblTip = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnAddTransaction = new System.Windows.Forms.Button();
            this.dgvTransaction = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Merchant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Recurrence = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MerchantId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.transactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.walletLessterDBTransactionDataSet = new WalletLesster.WalletLessterDBTransactionDataSet();
            this.lblTitle = new System.Windows.Forms.Label();
            this.transactionsTableAdapter = new WalletLesster.WalletLessterDBTransactionDataSetTableAdapters.TransactionsTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbMerchant = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxRecurrence = new System.Windows.Forms.CheckBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.cmbTransType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCSV = new System.Windows.Forms.Button();
            this.panelTip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.walletLessterDBTransactionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTip
            // 
            this.panelTip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelTip.BackColor = System.Drawing.Color.White;
            this.panelTip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTip.Controls.Add(this.lblTip);
            this.panelTip.Controls.Add(this.pictureBox5);
            this.panelTip.Location = new System.Drawing.Point(20, 73);
            this.panelTip.Name = "panelTip";
            this.panelTip.Size = new System.Drawing.Size(1045, 66);
            this.panelTip.TabIndex = 16;
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTip.Location = new System.Drawing.Point(81, 17);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(71, 35);
            this.lblTip.TabIndex = 1;
            this.lblTip.Text = "Tips....";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(3, 1);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(62, 61);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // btnAddTransaction
            // 
            this.btnAddTransaction.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAddTransaction.BackColor = System.Drawing.Color.Transparent;
            this.btnAddTransaction.BackgroundImage = global::WalletLesster.Properties.Resources.yellow_btn;
            this.btnAddTransaction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddTransaction.FlatAppearance.BorderSize = 0;
            this.btnAddTransaction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAddTransaction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTransaction.Font = new System.Drawing.Font("Poppins SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTransaction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(32)))), ((int)(((byte)(81)))));
            this.btnAddTransaction.Image = ((System.Drawing.Image)(resources.GetObject("btnAddTransaction.Image")));
            this.btnAddTransaction.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddTransaction.Location = new System.Drawing.Point(776, 240);
            this.btnAddTransaction.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddTransaction.Name = "btnAddTransaction";
            this.btnAddTransaction.Padding = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.btnAddTransaction.Size = new System.Drawing.Size(242, 46);
            this.btnAddTransaction.TabIndex = 14;
            this.btnAddTransaction.Text = "Add Transaction";
            this.btnAddTransaction.UseVisualStyleBackColor = false;
            this.btnAddTransaction.Click += new System.EventHandler(this.ShowAddTransaction);
            this.btnAddTransaction.MouseLeave += new System.EventHandler(this.btnAddTransaction_MouseLeave);
            this.btnAddTransaction.MouseHover += new System.EventHandler(this.btnAddTransaction_MouseHover);
            // 
            // dgvTransaction
            // 
            this.dgvTransaction.AllowUserToAddRows = false;
            this.dgvTransaction.AllowUserToOrderColumns = true;
            this.dgvTransaction.AllowUserToResizeRows = false;
            this.dgvTransaction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvTransaction.AutoGenerateColumns = false;
            this.dgvTransaction.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(32)))), ((int)(((byte)(81)))));
            this.dgvTransaction.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTransaction.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Type,
            this.Merchant,
            this.Category,
            this.Amount,
            this.Date,
            this.Recurrence,
            this.Description,
            this.userIdDataGridViewTextBoxColumn,
            this.CategoryId,
            this.MerchantId,
            this.Update,
            this.Delete});
            this.dgvTransaction.DataSource = this.transactionsBindingSource;
            this.dgvTransaction.GridColor = System.Drawing.Color.Aqua;
            this.dgvTransaction.Location = new System.Drawing.Point(52, 456);
            this.dgvTransaction.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvTransaction.Name = "dgvTransaction";
            this.dgvTransaction.ReadOnly = true;
            this.dgvTransaction.RowHeadersVisible = false;
            this.dgvTransaction.RowHeadersWidth = 51;
            this.dgvTransaction.RowTemplate.Height = 24;
            this.dgvTransaction.Size = new System.Drawing.Size(976, 385);
            this.dgvTransaction.TabIndex = 15;
            this.dgvTransaction.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransaction_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 90;
            // 
            // Merchant
            // 
            this.Merchant.DataPropertyName = "Merchant";
            this.Merchant.HeaderText = "Merchant";
            this.Merchant.MinimumWidth = 6;
            this.Merchant.Name = "Merchant";
            this.Merchant.ReadOnly = true;
            this.Merchant.Width = 125;
            // 
            // Category
            // 
            this.Category.DataPropertyName = "Category";
            this.Category.HeaderText = "Category";
            this.Category.MinimumWidth = 6;
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Width = 125;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "Amount";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 125;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 125;
            // 
            // Recurrence
            // 
            this.Recurrence.DataPropertyName = "Recurrence";
            this.Recurrence.HeaderText = "Recurrence";
            this.Recurrence.MinimumWidth = 6;
            this.Recurrence.Name = "Recurrence";
            this.Recurrence.ReadOnly = true;
            this.Recurrence.Width = 125;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
            this.userIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            this.userIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.userIdDataGridViewTextBoxColumn.Visible = false;
            this.userIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // CategoryId
            // 
            this.CategoryId.DataPropertyName = "CategoryId";
            this.CategoryId.HeaderText = "CategoryId";
            this.CategoryId.MinimumWidth = 6;
            this.CategoryId.Name = "CategoryId";
            this.CategoryId.ReadOnly = true;
            this.CategoryId.Visible = false;
            this.CategoryId.Width = 125;
            // 
            // MerchantId
            // 
            this.MerchantId.DataPropertyName = "MerchantId";
            this.MerchantId.HeaderText = "MerchantId";
            this.MerchantId.MinimumWidth = 6;
            this.MerchantId.Name = "MerchantId";
            this.MerchantId.ReadOnly = true;
            this.MerchantId.Visible = false;
            this.MerchantId.Width = 125;
            // 
            // Update
            // 
            this.Update.HeaderText = "Update";
            this.Update.MinimumWidth = 6;
            this.Update.Name = "Update";
            this.Update.ReadOnly = true;
            this.Update.Text = "Update";
            this.Update.UseColumnTextForButtonValue = true;
            this.Update.Width = 80;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 80;
            // 
            // transactionsBindingSource
            // 
            this.transactionsBindingSource.DataMember = "Transactions";
            this.transactionsBindingSource.DataSource = this.walletLessterDBTransactionDataSet;
            // 
            // walletLessterDBTransactionDataSet
            // 
            this.walletLessterDBTransactionDataSet.DataSetName = "WalletLessterDBTransactionDataSet";
            this.walletLessterDBTransactionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Poppins", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Cyan;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(456, 67);
            this.lblTitle.TabIndex = 29;
            this.lblTitle.Text = "Manage Transactions";
            // 
            // transactionsTableAdapter
            // 
            this.transactionsTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(51, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(922, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnClearFilter.BackColor = System.Drawing.Color.Transparent;
            this.btnClearFilter.BackgroundImage = global::WalletLesster.Properties.Resources.purple_btn;
            this.btnClearFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClearFilter.FlatAppearance.BorderSize = 0;
            this.btnClearFilter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClearFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClearFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearFilter.Font = new System.Drawing.Font("Poppins Medium", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearFilter.ForeColor = System.Drawing.Color.White;
            this.btnClearFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnClearFilter.Image")));
            this.btnClearFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClearFilter.Location = new System.Drawing.Point(814, 23);
            this.btnClearFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(149, 33);
            this.btnClearFilter.TabIndex = 68;
            this.btnClearFilter.Text = "Clear Filter";
            this.btnClearFilter.UseVisualStyleBackColor = false;
            this.btnClearFilter.Click += new System.EventHandler(this.ClearFilter);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(32)))), ((int)(((byte)(81)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.cmbMerchant);
            this.panel1.Controls.Add(this.btnClearFilter);
            this.panel1.Controls.Add(this.btnFilter);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbxRecurrence);
            this.panel1.Controls.Add(this.cmbCategory);
            this.panel1.Controls.Add(this.cmbTransType);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(52, 357);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(976, 86);
            this.panel1.TabIndex = 69;
            // 
            // cmbMerchant
            // 
            this.cmbMerchant.BackColor = System.Drawing.Color.White;
            this.cmbMerchant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMerchant.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMerchant.FormattingEnabled = true;
            this.cmbMerchant.Items.AddRange(new object[] {
            "Select Merchant"});
            this.cmbMerchant.Location = new System.Drawing.Point(192, 39);
            this.cmbMerchant.Name = "cmbMerchant";
            this.cmbMerchant.Size = new System.Drawing.Size(165, 31);
            this.cmbMerchant.TabIndex = 78;
            // 
            // btnFilter
            // 
            this.btnFilter.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnFilter.BackColor = System.Drawing.Color.Transparent;
            this.btnFilter.BackgroundImage = global::WalletLesster.Properties.Resources.purple_btn;
            this.btnFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Poppins Medium", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnFilter.Image")));
            this.btnFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFilter.Location = new System.Drawing.Point(683, 23);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(125, 33);
            this.btnFilter.TabIndex = 70;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.FilterTransactions);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(189, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 77;
            this.label3.Text = "Merchant";
            // 
            // cbxRecurrence
            // 
            this.cbxRecurrence.AutoSize = true;
            this.cbxRecurrence.BackColor = System.Drawing.Color.Transparent;
            this.cbxRecurrence.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cbxRecurrence.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxRecurrence.ForeColor = System.Drawing.Color.White;
            this.cbxRecurrence.Location = new System.Drawing.Point(559, 10);
            this.cbxRecurrence.Name = "cbxRecurrence";
            this.cbxRecurrence.Size = new System.Drawing.Size(96, 46);
            this.cbxRecurrence.TabIndex = 74;
            this.cbxRecurrence.Text = "Recurrence";
            this.cbxRecurrence.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cbxRecurrence.UseVisualStyleBackColor = false;
            // 
            // cmbCategory
            // 
            this.cmbCategory.BackColor = System.Drawing.Color.White;
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Font = new System.Drawing.Font("Poppins", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Select Category"});
            this.cmbCategory.Location = new System.Drawing.Point(382, 39);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(165, 31);
            this.cmbCategory.TabIndex = 73;
            // 
            // cmbTransType
            // 
            this.cmbTransType.BackColor = System.Drawing.Color.White;
            this.cmbTransType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTransType.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTransType.FormattingEnabled = true;
            this.cmbTransType.Items.AddRange(new object[] {
            "Income",
            "Expense"});
            this.cmbTransType.Location = new System.Drawing.Point(12, 39);
            this.cmbTransType.Name = "cmbTransType";
            this.cmbTransType.Size = new System.Drawing.Size(155, 31);
            this.cmbTransType.TabIndex = 72;
            this.cmbTransType.SelectedIndexChanged += new System.EventHandler(this.cmbTransType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(381, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 69;
            this.label2.Text = "Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 25);
            this.label1.TabIndex = 68;
            this.label1.Text = "Type";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Cyan;
            this.label4.Location = new System.Drawing.Point(51, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 30);
            this.label4.TabIndex = 70;
            this.label4.Text = "Filters";
            // 
            // btnCSV
            // 
            this.btnCSV.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCSV.BackColor = System.Drawing.Color.Transparent;
            this.btnCSV.BackgroundImage = global::WalletLesster.Properties.Resources.orange_btn;
            this.btnCSV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCSV.FlatAppearance.BorderSize = 0;
            this.btnCSV.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCSV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCSV.Font = new System.Drawing.Font("Poppins SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCSV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(32)))), ((int)(((byte)(81)))));
            this.btnCSV.Image = ((System.Drawing.Image)(resources.GetObject("btnCSV.Image")));
            this.btnCSV.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCSV.Location = new System.Drawing.Point(776, 294);
            this.btnCSV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCSV.Name = "btnCSV";
            this.btnCSV.Padding = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.btnCSV.Size = new System.Drawing.Size(242, 46);
            this.btnCSV.TabIndex = 71;
            this.btnCSV.Text = "Export to CSV";
            this.btnCSV.UseVisualStyleBackColor = false;
            this.btnCSV.Click += new System.EventHandler(this.ExportToCSV);
            // 
            // ManageTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1076, 858);
            this.Controls.Add(this.btnCSV);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvTransaction);
            this.Controls.Add(this.panelTip);
            this.Controls.Add(this.btnAddTransaction);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitle);
            this.DoubleBuffered = true;
            this.Name = "ManageTransactions";
            this.Text = "ManageTransactions";
            this.Activated += new System.EventHandler(this.ManageTransactions_Activated);
            this.Load += new System.EventHandler(this.ManageTransactions_Load);
            this.panelTip.ResumeLayout(false);
            this.panelTip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.walletLessterDBTransactionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTip;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btnAddTransaction;
        private System.Windows.Forms.DataGridView dgvTransaction;
        private System.Windows.Forms.Label lblTitle;
        private WalletLessterDBTransactionDataSet walletLessterDBTransactionDataSet;
        private System.Windows.Forms.BindingSource transactionsBindingSource;
        private WalletLessterDBTransactionDataSetTableAdapters.TransactionsTableAdapter transactionsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Merchant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Recurrence;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MerchantId;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClearFilter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbxRecurrence;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ComboBox cmbTransType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ComboBox cmbMerchant;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCSV;
    }
}