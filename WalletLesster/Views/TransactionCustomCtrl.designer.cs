
namespace WalletLesster.Views
{
    partial class TransactionCustomCtrl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionCustomCtrl));
            this.btnRemove = new System.Windows.Forms.Button();
            this.cbxRecurrence = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMerchant = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rbIncome = new System.Windows.Forms.RadioButton();
            this.rbExpense = new System.Windows.Forms.RadioButton();
            this.txtAmount = new System.Windows.Forms.NumericUpDown();
            this.dpTransDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.White;
            this.btnRemove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemove.BackgroundImage")));
            this.btnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRemove.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(1034, 24);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(51, 53);
            this.btnRemove.TabIndex = 42;
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.removeTransaction);
            // 
            // cbxRecurrence
            // 
            this.cbxRecurrence.AutoSize = true;
            this.cbxRecurrence.BackColor = System.Drawing.Color.Transparent;
            this.cbxRecurrence.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cbxRecurrence.Location = new System.Drawing.Point(926, 28);
            this.cbxRecurrence.Name = "cbxRecurrence";
            this.cbxRecurrence.Size = new System.Drawing.Size(86, 38);
            this.cbxRecurrence.TabIndex = 41;
            this.cbxRecurrence.Text = "Recurrence";
            this.cbxRecurrence.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 17);
            this.label5.TabIndex = 34;
            this.label5.Text = "Type of transaction";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(786, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Date";
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(417, 54);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(184, 24);
            this.cmbCategory.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Merchant";
            // 
            // cmbMerchant
            // 
            this.cmbMerchant.FormattingEnabled = true;
            this.cmbMerchant.ItemHeight = 16;
            this.cmbMerchant.Location = new System.Drawing.Point(203, 54);
            this.cmbMerchant.Name = "cmbMerchant";
            this.cmbMerchant.Size = new System.Drawing.Size(184, 24);
            this.cmbMerchant.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(412, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "Category";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(628, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 35;
            this.label6.Text = "Amount";
            // 
            // rbIncome
            // 
            this.rbIncome.AutoSize = true;
            this.rbIncome.Checked = true;
            this.rbIncome.Location = new System.Drawing.Point(14, 56);
            this.rbIncome.Name = "rbIncome";
            this.rbIncome.Size = new System.Drawing.Size(74, 21);
            this.rbIncome.TabIndex = 43;
            this.rbIncome.TabStop = true;
            this.rbIncome.Text = "Income";
            this.rbIncome.UseVisualStyleBackColor = true;
            this.rbIncome.CheckedChanged += new System.EventHandler(this.rbIncome_CheckedChanged);
            // 
            // rbExpense
            // 
            this.rbExpense.AutoSize = true;
            this.rbExpense.Location = new System.Drawing.Point(94, 57);
            this.rbExpense.Name = "rbExpense";
            this.rbExpense.Size = new System.Drawing.Size(83, 21);
            this.rbExpense.TabIndex = 44;
            this.rbExpense.Text = "Expense";
            this.rbExpense.UseVisualStyleBackColor = true;
            // 
            // txtAmount
            // 
            this.txtAmount.DecimalPlaces = 2;
            this.txtAmount.Location = new System.Drawing.Point(631, 55);
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
            this.txtAmount.TabIndex = 45;
            this.txtAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            this.dpTransDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpTransDate.Location = new System.Drawing.Point(789, 54);
            this.dpTransDate.Name = "dpTransDate";
            this.dpTransDate.Size = new System.Drawing.Size(122, 22);
            this.dpTransDate.TabIndex = 52;
            // 
            // TransactionCustomCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.dpTransDate);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.rbExpense);
            this.Controls.Add(this.rbIncome);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.cbxRecurrence);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbMerchant);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Name = "TransactionCustomCtrl";
            this.Size = new System.Drawing.Size(1127, 105);
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.CheckBox cbxRecurrence;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMerchant;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbIncome;
        private System.Windows.Forms.RadioButton rbExpense;
        private System.Windows.Forms.NumericUpDown txtAmount;
        private System.Windows.Forms.DateTimePicker dpTransDate;
    }
}
