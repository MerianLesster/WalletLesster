
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
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.walletLessterDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.walletLessterDatabaseDataSet = new WalletLesster.WalletLessterDatabaseDataSet();
            this.transactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionsTableAdapter = new WalletLesster.WalletLessterDatabaseDataSetTableAdapters.TransactionsTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.walletLessterDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.walletLessterDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTip
            // 
            this.panelTip.BackColor = System.Drawing.Color.White;
            this.panelTip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTip.Controls.Add(this.lblTip);
            this.panelTip.Controls.Add(this.pictureBox5);
            this.panelTip.Location = new System.Drawing.Point(12, 68);
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
            this.btnAddTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddTransaction.BackColor = System.Drawing.Color.AliceBlue;
            this.btnAddTransaction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddTransaction.Font = new System.Drawing.Font("Poppins SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTransaction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(32)))), ((int)(((byte)(81)))));
            this.btnAddTransaction.Location = new System.Drawing.Point(16, 229);
            this.btnAddTransaction.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddTransaction.Name = "btnAddTransaction";
            this.btnAddTransaction.Size = new System.Drawing.Size(284, 83);
            this.btnAddTransaction.TabIndex = 14;
            this.btnAddTransaction.Text = "Add Transaction +";
            this.btnAddTransaction.UseVisualStyleBackColor = false;
            this.btnAddTransaction.Click += new System.EventHandler(this.ShowAddTransaction);
            // 
            // dgvTransaction
            // 
            this.dgvTransaction.AllowUserToAddRows = false;
            this.dgvTransaction.AllowUserToOrderColumns = true;
            this.dgvTransaction.AllowUserToResizeColumns = false;
            this.dgvTransaction.AllowUserToResizeRows = false;
            this.dgvTransaction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvTransaction.AutoGenerateColumns = false;
            this.dgvTransaction.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(32)))), ((int)(((byte)(81)))));
            this.dgvTransaction.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTransaction.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Type,
            this.Merchant,
            this.Category,
            this.Amount,
            this.Date,
            this.Recurrence,
            this.Update,
            this.Delete});
            this.dgvTransaction.DataSource = this.walletLessterDatabaseDataSetBindingSource;
            this.dgvTransaction.GridColor = System.Drawing.Color.Aqua;
            this.dgvTransaction.Location = new System.Drawing.Point(40, 354);
            this.dgvTransaction.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvTransaction.Name = "dgvTransaction";
            this.dgvTransaction.ReadOnly = true;
            this.dgvTransaction.RowHeadersWidth = 51;
            this.dgvTransaction.RowTemplate.Height = 24;
            this.dgvTransaction.Size = new System.Drawing.Size(1017, 469);
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
            this.Type.Width = 125;
            // 
            // Merchant
            // 
            this.Merchant.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Merchant.DataPropertyName = "Merchant";
            this.Merchant.HeaderText = "Merchant";
            this.Merchant.MinimumWidth = 6;
            this.Merchant.Name = "Merchant";
            this.Merchant.ReadOnly = true;
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
            // walletLessterDatabaseDataSetBindingSource
            // 
            this.walletLessterDatabaseDataSetBindingSource.DataMember = "Transactions";
            this.walletLessterDatabaseDataSetBindingSource.DataSource = this.walletLessterDatabaseDataSet;
            // 
            // walletLessterDatabaseDataSet
            // 
            this.walletLessterDatabaseDataSet.DataSetName = "WalletLessterDatabaseDataSet";
            this.walletLessterDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transactionsBindingSource
            // 
            this.transactionsBindingSource.DataMember = "Transactions";
            this.transactionsBindingSource.DataSource = this.walletLessterDatabaseDataSet;
            // 
            // transactionsTableAdapter
            // 
            this.transactionsTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(316, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 58);
            this.button1.TabIndex = 18;
            this.button1.Text = "refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(628, 140);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(429, 207);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // ManageTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1076, 858);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelTip);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvTransaction);
            this.Controls.Add(this.btnAddTransaction);
            this.Name = "ManageTransactions";
            this.Text = "ManageTransactions";
            this.Activated += new System.EventHandler(this.ManageTransactions_Activated);
            this.Load += new System.EventHandler(this.ManageTransactions_Load);
            this.panelTip.ResumeLayout(false);
            this.panelTip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.walletLessterDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.walletLessterDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTip;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btnAddTransaction;
        private System.Windows.Forms.DataGridView dgvTransaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Merchant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Recurrence;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.BindingSource walletLessterDatabaseDataSetBindingSource;
        private WalletLessterDatabaseDataSet walletLessterDatabaseDataSet;
        private System.Windows.Forms.BindingSource transactionsBindingSource;
        private WalletLessterDatabaseDataSetTableAdapters.TransactionsTableAdapter transactionsTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}