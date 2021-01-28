
namespace WalletLesster.Views
{
    partial class ManageMerchant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageMerchant));
            this.lblTip = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panelTip = new System.Windows.Forms.Panel();
            this.btnAddMerchant = new System.Windows.Forms.Button();
            this.dgvMerchant = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.merchantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.walletLessterDBMerchantDataSet = new WalletLesster.WalletLessterDBMerchantDataSet();
            this.lblTitle = new System.Windows.Forms.Label();
            this.merchantsTableAdapter = new WalletLesster.WalletLessterDBMerchantDataSetTableAdapters.MerchantsTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panelTip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMerchant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.merchantsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.walletLessterDBMerchantDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.panelTip.TabIndex = 36;
            // 
            // btnAddMerchant
            // 
            this.btnAddMerchant.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAddMerchant.BackColor = System.Drawing.Color.Transparent;
            this.btnAddMerchant.BackgroundImage = global::WalletLesster.Properties.Resources.yellow_btn;
            this.btnAddMerchant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddMerchant.FlatAppearance.BorderSize = 0;
            this.btnAddMerchant.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAddMerchant.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddMerchant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMerchant.Font = new System.Drawing.Font("Poppins SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMerchant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(32)))), ((int)(((byte)(81)))));
            this.btnAddMerchant.Image = ((System.Drawing.Image)(resources.GetObject("btnAddMerchant.Image")));
            this.btnAddMerchant.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddMerchant.Location = new System.Drawing.Point(784, 289);
            this.btnAddMerchant.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddMerchant.Name = "btnAddMerchant";
            this.btnAddMerchant.Padding = new System.Windows.Forms.Padding(5, 5, 15, 5);
            this.btnAddMerchant.Size = new System.Drawing.Size(242, 46);
            this.btnAddMerchant.TabIndex = 38;
            this.btnAddMerchant.Text = "Add Merchant  ";
            this.btnAddMerchant.UseVisualStyleBackColor = false;
            this.btnAddMerchant.Click += new System.EventHandler(this.ShowAddMerchantForm);
            this.btnAddMerchant.MouseLeave += new System.EventHandler(this.btnAddMerchant_MouseLeave);
            this.btnAddMerchant.MouseHover += new System.EventHandler(this.btnAddMerchant_MouseHover);
            // 
            // dgvMerchant
            // 
            this.dgvMerchant.AllowUserToAddRows = false;
            this.dgvMerchant.AllowUserToOrderColumns = true;
            this.dgvMerchant.AllowUserToResizeColumns = false;
            this.dgvMerchant.AllowUserToResizeRows = false;
            this.dgvMerchant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvMerchant.AutoGenerateColumns = false;
            this.dgvMerchant.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(32)))), ((int)(((byte)(81)))));
            this.dgvMerchant.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMerchant.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvMerchant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMerchant.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Name,
            this.Number,
            this.userIdDataGridViewTextBoxColumn,
            this.Update,
            this.Delete});
            this.dgvMerchant.DataSource = this.merchantsBindingSource;
            this.dgvMerchant.GridColor = System.Drawing.Color.Aqua;
            this.dgvMerchant.Location = new System.Drawing.Point(50, 442);
            this.dgvMerchant.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvMerchant.Name = "dgvMerchant";
            this.dgvMerchant.ReadOnly = true;
            this.dgvMerchant.RowHeadersWidth = 51;
            this.dgvMerchant.RowTemplate.Height = 24;
            this.dgvMerchant.Size = new System.Drawing.Size(976, 385);
            this.dgvMerchant.TabIndex = 35;
            this.dgvMerchant.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMerchant_CellContentClick);
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
            // Name
            // 
            this.Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Number
            // 
            this.Number.DataPropertyName = "Number";
            this.Number.HeaderText = "Mobile Number";
            this.Number.MinimumWidth = 6;
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Width = 250;
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
            // Update
            // 
            this.Update.HeaderText = "Update";
            this.Update.MinimumWidth = 6;
            this.Update.Name = "Update";
            this.Update.ReadOnly = true;
            this.Update.Text = "Update";
            this.Update.UseColumnTextForButtonValue = true;
            this.Update.Width = 125;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 125;
            // 
            // merchantsBindingSource
            // 
            this.merchantsBindingSource.DataMember = "Merchants";
            this.merchantsBindingSource.DataSource = this.walletLessterDBMerchantDataSet;
            // 
            // walletLessterDBMerchantDataSet
            // 
            this.walletLessterDBMerchantDataSet.DataSetName = "WalletLessterDBMerchantDataSet";
            this.walletLessterDBMerchantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Poppins", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Cyan;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(389, 67);
            this.lblTitle.TabIndex = 34;
            this.lblTitle.Text = "Manage Merchant";
            // 
            // merchantsTableAdapter
            // 
            this.merchantsTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(317, 145);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(429, 207);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(32)))), ((int)(((byte)(81)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.txtNumber);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.btnClearFilter);
            this.panel1.Controls.Add(this.btnFilter);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(50, 344);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(976, 86);
            this.panel1.TabIndex = 70;
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber.Location = new System.Drawing.Point(273, 39);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(232, 30);
            this.txtNumber.TabIndex = 80;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(14, 39);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(232, 30);
            this.txtName.TabIndex = 79;
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
            this.btnClearFilter.Location = new System.Drawing.Point(814, 21);
            this.btnClearFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(149, 46);
            this.btnClearFilter.TabIndex = 68;
            this.btnClearFilter.Text = "Clear Filter";
            this.btnClearFilter.UseVisualStyleBackColor = false;
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
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
            this.btnFilter.Location = new System.Drawing.Point(683, 21);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(125, 46);
            this.btnFilter.TabIndex = 70;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(268, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 25);
            this.label3.TabIndex = 77;
            this.label3.Text = "Mobile Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 25);
            this.label1.TabIndex = 68;
            this.label1.Text = "Name";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Cyan;
            this.label4.Location = new System.Drawing.Point(51, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 30);
            this.label4.TabIndex = 71;
            this.label4.Text = "Filters";
            // 
            // ManageMerchant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1076, 858);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelTip);
            this.Controls.Add(this.btnAddMerchant);
            this.Controls.Add(this.dgvMerchant);
            this.Controls.Add(this.lblTitle);
            this.DoubleBuffered = true;
            //this.Name = "ManageMerchant";
            this.Text = "ManageMerchant";
            this.Load += new System.EventHandler(this.ManageMerchant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panelTip.ResumeLayout(false);
            this.panelTip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMerchant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.merchantsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.walletLessterDBMerchantDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panelTip;
        private System.Windows.Forms.Button btnAddMerchant;
        private System.Windows.Forms.DataGridView dgvMerchant;
        private System.Windows.Forms.Label lblTitle;
        private WalletLessterDBMerchantDataSet walletLessterDBMerchantDataSet;
        private System.Windows.Forms.BindingSource merchantsBindingSource;
        private WalletLessterDBMerchantDataSetTableAdapters.MerchantsTableAdapter merchantsTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClearFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNumber;
    }
}