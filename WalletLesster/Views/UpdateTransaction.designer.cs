﻿
namespace WalletLesster.Views
{
    partial class UpdateTransaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateTransaction));
            this.panelTransactions = new System.Windows.Forms.Panel();
            this.txtAmount = new System.Windows.Forms.NumericUpDown();
            this.rbExpense = new System.Windows.Forms.RadioButton();
            this.rbIncome = new System.Windows.Forms.RadioButton();
            this.cbxRecurrence = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMerchant = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dpTransDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.panelTip = new System.Windows.Forms.Panel();
            this.lblTip = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnUpdateTransaction = new System.Windows.Forms.Button();
            this.loader = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).BeginInit();
            this.panelTip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loader)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTransactions
            // 
            this.panelTransactions.AutoScroll = true;
            this.panelTransactions.BackColor = System.Drawing.Color.White;
            this.panelTransactions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTransactions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTransactions.Controls.Add(this.txtAmount);
            this.panelTransactions.Controls.Add(this.rbExpense);
            this.panelTransactions.Controls.Add(this.rbIncome);
            this.panelTransactions.Controls.Add(this.cbxRecurrence);
            this.panelTransactions.Controls.Add(this.label5);
            this.panelTransactions.Controls.Add(this.label2);
            this.panelTransactions.Controls.Add(this.cmbCategory);
            this.panelTransactions.Controls.Add(this.label3);
            this.panelTransactions.Controls.Add(this.cmbMerchant);
            this.panelTransactions.Controls.Add(this.label4);
            this.panelTransactions.Controls.Add(this.dpTransDate);
            this.panelTransactions.Controls.Add(this.label6);
            this.panelTransactions.Location = new System.Drawing.Point(17, 11);
            this.panelTransactions.Name = "panelTransactions";
            this.panelTransactions.Size = new System.Drawing.Size(1115, 122);
            this.panelTransactions.TabIndex = 14;
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.Color.White;
            this.txtAmount.DecimalPlaces = 2;
            this.txtAmount.Location = new System.Drawing.Point(667, 59);
            this.txtAmount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(120, 22);
            this.txtAmount.TabIndex = 58;
            this.txtAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            this.rbIncome.CheckedChanged += new System.EventHandler(this.rbIncome_CheckedChanged);
            // 
            // cbxRecurrence
            // 
            this.cbxRecurrence.AutoSize = true;
            this.cbxRecurrence.BackColor = System.Drawing.Color.Transparent;
            this.cbxRecurrence.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cbxRecurrence.Font = new System.Drawing.Font("Poppins SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxRecurrence.Location = new System.Drawing.Point(962, 32);
            this.cbxRecurrence.Name = "cbxRecurrence";
            this.cbxRecurrence.Size = new System.Drawing.Size(98, 46);
            this.cbxRecurrence.TabIndex = 54;
            this.cbxRecurrence.Text = "Recurrence";
            this.cbxRecurrence.UseVisualStyleBackColor = false;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Poppins SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(822, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 25);
            this.label2.TabIndex = 46;
            this.label2.Text = "Date";
            // 
            // cmbCategory
            // 
            this.cmbCategory.BackColor = System.Drawing.Color.White;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(453, 58);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(184, 24);
            this.cmbCategory.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Poppins SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(238, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 47;
            this.label3.Text = "Merchant";
            // 
            // cmbMerchant
            // 
            this.cmbMerchant.BackColor = System.Drawing.Color.White;
            this.cmbMerchant.FormattingEnabled = true;
            this.cmbMerchant.ItemHeight = 16;
            this.cmbMerchant.Location = new System.Drawing.Point(239, 58);
            this.cmbMerchant.Name = "cmbMerchant";
            this.cmbMerchant.Size = new System.Drawing.Size(184, 24);
            this.cmbMerchant.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Poppins SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(448, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 25);
            this.label4.TabIndex = 48;
            this.label4.Text = "Category";
            // 
            // dpTransDate
            // 
            this.dpTransDate.CalendarFont = new System.Drawing.Font("Poppins SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpTransDate.CalendarForeColor = System.Drawing.Color.Plum;
            this.dpTransDate.CalendarMonthBackground = System.Drawing.Color.Plum;
            this.dpTransDate.CalendarTitleBackColor = System.Drawing.Color.Plum;
            this.dpTransDate.CalendarTitleForeColor = System.Drawing.Color.Plum;
            this.dpTransDate.CalendarTrailingForeColor = System.Drawing.Color.Plum;
            this.dpTransDate.Checked = false;
            this.dpTransDate.CustomFormat = "";
            this.dpTransDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpTransDate.Location = new System.Drawing.Point(824, 58);
            this.dpTransDate.Name = "dpTransDate";
            this.dpTransDate.Size = new System.Drawing.Size(122, 22);
            this.dpTransDate.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Poppins SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(664, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 25);
            this.label6.TabIndex = 50;
            this.label6.Text = "Amount";
            // 
            // panelTip
            // 
            this.panelTip.BackColor = System.Drawing.Color.White;
            this.panelTip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTip.Controls.Add(this.lblTip);
            this.panelTip.Controls.Add(this.pictureBox1);
            this.panelTip.Location = new System.Drawing.Point(27, 79);
            this.panelTip.Name = "panelTip";
            this.panelTip.Size = new System.Drawing.Size(1148, 66);
            this.panelTip.TabIndex = 12;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(15, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 70);
            this.label1.TabIndex = 11;
            this.label1.Text = "Update Transaction";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(32)))), ((int)(((byte)(81)))));
            this.panel3.Controls.Add(this.btnUpdateTransaction);
            this.panel3.Controls.Add(this.loader);
            this.panel3.Location = new System.Drawing.Point(0, 344);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1208, 90);
            this.panel3.TabIndex = 13;
            // 
            // btnUpdateTransaction
            // 
            this.btnUpdateTransaction.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateTransaction.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdateTransaction.BackgroundImage")));
            this.btnUpdateTransaction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdateTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdateTransaction.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateTransaction.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateTransaction.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateTransaction.Image")));
            this.btnUpdateTransaction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateTransaction.Location = new System.Drawing.Point(910, 11);
            this.btnUpdateTransaction.Name = "btnUpdateTransaction";
            this.btnUpdateTransaction.Padding = new System.Windows.Forms.Padding(5);
            this.btnUpdateTransaction.Size = new System.Drawing.Size(261, 61);
            this.btnUpdateTransaction.TabIndex = 1;
            this.btnUpdateTransaction.Text = "Update transaction";
            this.btnUpdateTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateTransaction.UseVisualStyleBackColor = false;
            this.btnUpdateTransaction.Click += new System.EventHandler(this.UpdateTransactionData);
            // 
            // loader
            // 
            this.loader.BackColor = System.Drawing.Color.Transparent;
            this.loader.Image = ((System.Drawing.Image)(resources.GetObject("loader.Image")));
            this.loader.Location = new System.Drawing.Point(1052, -6);
            this.loader.Name = "loader";
            this.loader.Size = new System.Drawing.Size(191, 95);
            this.loader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loader.TabIndex = 2;
            this.loader.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(32)))), ((int)(((byte)(81)))));
            this.panel1.Controls.Add(this.panelTransactions);
            this.panel1.Location = new System.Drawing.Point(27, 157);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1148, 144);
            this.panel1.TabIndex = 15;
            // 
            // UpdateTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1201, 428);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1219, 475);
            this.MinimumSize = new System.Drawing.Size(1219, 475);
            this.Name = "UpdateTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Transaction";
            this.Activated += new System.EventHandler(this.UpdateTransaction_Activated);
            this.panelTransactions.ResumeLayout(false);
            this.panelTransactions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).EndInit();
            this.panelTip.ResumeLayout(false);
            this.panelTip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.loader)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTransactions;
        private System.Windows.Forms.Panel panelTip;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnUpdateTransaction;
        private System.Windows.Forms.NumericUpDown txtAmount;
        private System.Windows.Forms.RadioButton rbExpense;
        private System.Windows.Forms.RadioButton rbIncome;
        private System.Windows.Forms.CheckBox cbxRecurrence;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMerchant;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dpTransDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox loader;
        private System.Windows.Forms.Panel panel1;
    }
}