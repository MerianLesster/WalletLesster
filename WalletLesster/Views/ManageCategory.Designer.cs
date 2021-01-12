
namespace WalletLesster.Views
{
    partial class ManageCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageCategory));
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvCategory = new System.Windows.Forms.DataGridView();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.walletLessterDBCategoryDataSet = new WalletLesster.WalletLessterDBCategoryDataSet();
            this.panelTip = new System.Windows.Forms.Panel();
            this.lblTip = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddCategoty = new System.Windows.Forms.Button();
            this.categoriesTableAdapter = new WalletLesster.WalletLessterDBCategoryDataSetTableAdapters.CategoriesTableAdapter();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.walletLessterDBCategoryDataSet)).BeginInit();
            this.panelTip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Poppins", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Cyan;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(382, 67);
            this.lblTitle.TabIndex = 28;
            this.lblTitle.Text = "Manage Category";
            // 
            // dgvCategory
            // 
            this.dgvCategory.AllowUserToAddRows = false;
            this.dgvCategory.AllowUserToOrderColumns = true;
            this.dgvCategory.AllowUserToResizeColumns = false;
            this.dgvCategory.AllowUserToResizeRows = false;
            this.dgvCategory.AutoGenerateColumns = false;
            this.dgvCategory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(32)))), ((int)(((byte)(81)))));
            this.dgvCategory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCategory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Type,
            this.Name,
            this.userIdDataGridViewTextBoxColumn,
            this.Update,
            this.Delete});
            this.dgvCategory.DataSource = this.categoriesBindingSource;
            this.dgvCategory.GridColor = System.Drawing.Color.Aqua;
            this.dgvCategory.Location = new System.Drawing.Point(37, 382);
            this.dgvCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.ReadOnly = true;
            this.dgvCategory.RowHeadersWidth = 51;
            this.dgvCategory.RowTemplate.Height = 24;
            this.dgvCategory.Size = new System.Drawing.Size(1017, 436);
            this.dgvCategory.TabIndex = 29;
            this.dgvCategory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategory_CellContentClick);
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.walletLessterDBCategoryDataSet;
            // 
            // walletLessterDBCategoryDataSet
            // 
            this.walletLessterDBCategoryDataSet.DataSetName = "WalletLessterDBCategoryDataSet";
            this.walletLessterDBCategoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelTip
            // 
            this.panelTip.BackColor = System.Drawing.Color.White;
            this.panelTip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTip.Controls.Add(this.lblTip);
            this.panelTip.Controls.Add(this.pictureBox5);
            this.panelTip.Location = new System.Drawing.Point(24, 66);
            this.panelTip.Name = "panelTip";
            this.panelTip.Size = new System.Drawing.Size(1045, 66);
            this.panelTip.TabIndex = 30;
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
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(635, 138);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(429, 207);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(355, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 58);
            this.button1.TabIndex = 33;
            this.button1.Text = "refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddCategoty
            // 
            this.btnAddCategoty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCategoty.BackColor = System.Drawing.Color.AliceBlue;
            this.btnAddCategoty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddCategoty.Font = new System.Drawing.Font("Poppins SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCategoty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(32)))), ((int)(((byte)(81)))));
            this.btnAddCategoty.Location = new System.Drawing.Point(54, 248);
            this.btnAddCategoty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddCategoty.Name = "btnAddCategoty";
            this.btnAddCategoty.Size = new System.Drawing.Size(284, 83);
            this.btnAddCategoty.TabIndex = 32;
            this.btnAddCategoty.Text = "Add Category +";
            this.btnAddCategoty.UseVisualStyleBackColor = false;
            this.btnAddCategoty.Click += new System.EventHandler(this.ShowAddCategoryForm);
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
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
            // Name
            // 
            this.Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
            this.userIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            this.userIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.userIdDataGridViewTextBoxColumn.Visible = false;
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
            // ManageCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1076, 858);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddCategoty);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelTip);
            this.Controls.Add(this.dgvCategory);
            this.Controls.Add(this.lblTitle);
            //this.Name = "ManageCategory";
            this.Text = "ManageCategory";
            this.Load += new System.EventHandler(this.ManageCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.walletLessterDBCategoryDataSet)).EndInit();
            this.panelTip.ResumeLayout(false);
            this.panelTip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvCategory;
        private System.Windows.Forms.Panel panelTip;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAddCategoty;
        private WalletLessterDBCategoryDataSet walletLessterDBCategoryDataSet;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private WalletLessterDBCategoryDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}