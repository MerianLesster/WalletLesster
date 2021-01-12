
namespace WalletLesster.Views
{
    partial class AddUpdateCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUpdateCategory));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTransactions = new System.Windows.Forms.Panel();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.rbExpense = new System.Windows.Forms.RadioButton();
            this.rbIncome = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAddUpdateCategory = new System.Windows.Forms.Button();
            this.loader = new System.Windows.Forms.PictureBox();
            this.panelTip = new System.Windows.Forms.Panel();
            this.lblTip = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panelTransactions.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loader)).BeginInit();
            this.panelTip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(32)))), ((int)(((byte)(81)))));
            this.panel1.Controls.Add(this.panelTransactions);
            this.panel1.Location = new System.Drawing.Point(23, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(722, 144);
            this.panel1.TabIndex = 19;
            // 
            // panelTransactions
            // 
            this.panelTransactions.AutoScroll = true;
            this.panelTransactions.BackColor = System.Drawing.Color.White;
            this.panelTransactions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTransactions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTransactions.Controls.Add(this.txtCategoryName);
            this.panelTransactions.Controls.Add(this.rbExpense);
            this.panelTransactions.Controls.Add(this.rbIncome);
            this.panelTransactions.Controls.Add(this.label5);
            this.panelTransactions.Controls.Add(this.label4);
            this.panelTransactions.Location = new System.Drawing.Point(17, 11);
            this.panelTransactions.Name = "panelTransactions";
            this.panelTransactions.Size = new System.Drawing.Size(691, 122);
            this.panelTransactions.TabIndex = 14;
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(261, 59);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(356, 22);
            this.txtCategoryName.TabIndex = 58;
            // 
            // rbExpense
            // 
            this.rbExpense.AutoSize = true;
            this.rbExpense.BackColor = System.Drawing.Color.Transparent;
            this.rbExpense.Location = new System.Drawing.Point(130, 61);
            this.rbExpense.Name = "rbExpense";
            this.rbExpense.Size = new System.Drawing.Size(83, 21);
            this.rbExpense.TabIndex = 57;
            this.rbExpense.Text = "Expense";
            this.rbExpense.UseVisualStyleBackColor = false;
            // 
            // rbIncome
            // 
            this.rbIncome.AutoSize = true;
            this.rbIncome.BackColor = System.Drawing.Color.Transparent;
            this.rbIncome.Checked = true;
            this.rbIncome.Location = new System.Drawing.Point(50, 60);
            this.rbIncome.Name = "rbIncome";
            this.rbIncome.Size = new System.Drawing.Size(74, 21);
            this.rbIncome.TabIndex = 56;
            this.rbIncome.TabStop = true;
            this.rbIncome.Text = "Income";
            this.rbIncome.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Poppins SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 25);
            this.label5.TabIndex = 49;
            this.label5.Text = "Type of transaction";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Poppins SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(256, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 25);
            this.label4.TabIndex = 48;
            this.label4.Text = "Category";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Poppins", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Cyan;
            this.lblTitle.Location = new System.Drawing.Point(11, 3);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(481, 70);
            this.lblTitle.TabIndex = 16;
            this.lblTitle.Text = "Add/Update Category";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(32)))), ((int)(((byte)(81)))));
            this.panel3.Controls.Add(this.btnAddUpdateCategory);
            this.panel3.Controls.Add(this.loader);
            this.panel3.Location = new System.Drawing.Point(-4, 336);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(781, 90);
            this.panel3.TabIndex = 18;
            // 
            // btnAddUpdateCategory
            // 
            this.btnAddUpdateCategory.BackColor = System.Drawing.Color.Transparent;
            this.btnAddUpdateCategory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddUpdateCategory.BackgroundImage")));
            this.btnAddUpdateCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddUpdateCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddUpdateCategory.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUpdateCategory.ForeColor = System.Drawing.Color.Black;
            this.btnAddUpdateCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnAddUpdateCategory.Image")));
            this.btnAddUpdateCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddUpdateCategory.Location = new System.Drawing.Point(414, 19);
            this.btnAddUpdateCategory.Name = "btnAddUpdateCategory";
            this.btnAddUpdateCategory.Padding = new System.Windows.Forms.Padding(5);
            this.btnAddUpdateCategory.Size = new System.Drawing.Size(261, 61);
            this.btnAddUpdateCategory.TabIndex = 1;
            this.btnAddUpdateCategory.Text = "Update Category";
            this.btnAddUpdateCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddUpdateCategory.UseVisualStyleBackColor = false;
            this.btnAddUpdateCategory.Click += new System.EventHandler(this.AddUpdateCategoryAction);
            // 
            // loader
            // 
            this.loader.BackColor = System.Drawing.Color.Transparent;
            this.loader.Image = ((System.Drawing.Image)(resources.GetObject("loader.Image")));
            this.loader.Location = new System.Drawing.Point(556, 2);
            this.loader.Name = "loader";
            this.loader.Size = new System.Drawing.Size(191, 95);
            this.loader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loader.TabIndex = 2;
            this.loader.TabStop = false;
            // 
            // panelTip
            // 
            this.panelTip.BackColor = System.Drawing.Color.White;
            this.panelTip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTip.Controls.Add(this.lblTip);
            this.panelTip.Controls.Add(this.pictureBox1);
            this.panelTip.Location = new System.Drawing.Point(23, 71);
            this.panelTip.Name = "panelTip";
            this.panelTip.Size = new System.Drawing.Size(722, 66);
            this.panelTip.TabIndex = 17;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // AddUpdateCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(775, 428);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelTip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1219, 475);
            this.Name = "AddUpdateCategory";
            this.Text = "AddUpdateCategory";
            this.Activated += new System.EventHandler(this.AddUpdateCategory_Activated);
            this.panel1.ResumeLayout(false);
            this.panelTransactions.ResumeLayout(false);
            this.panelTransactions.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.loader)).EndInit();
            this.panelTip.ResumeLayout(false);
            this.panelTip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelTransactions;
        private System.Windows.Forms.RadioButton rbExpense;
        private System.Windows.Forms.RadioButton rbIncome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddUpdateCategory;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox loader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelTip;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.TextBox txtCategoryName;
    }
}