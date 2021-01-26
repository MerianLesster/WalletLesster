
namespace WalletLesster.Views
{
    partial class TransactionReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionReport));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.walletLessterDBTransactionDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.walletLessterDBTransactionDataSet = new WalletLesster.WalletLessterDBTransactionDataSet();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDateFilter = new System.Windows.Forms.Button();
            this.rbExpense = new System.Windows.Forms.RadioButton();
            this.rbIncome = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTypeFilter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.dtFromDate = new System.Windows.Forms.DateTimePicker();
            this.dtToDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.walletLessterDBTransactionDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.walletLessterDBTransactionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // walletLessterDBTransactionDataSetBindingSource
            // 
            this.walletLessterDBTransactionDataSetBindingSource.DataSource = this.walletLessterDBTransactionDataSet;
            this.walletLessterDBTransactionDataSetBindingSource.Position = 0;
            // 
            // walletLessterDBTransactionDataSet
            // 
            this.walletLessterDBTransactionDataSet.DataSetName = "WalletLessterDBTransactionDataSet";
            this.walletLessterDBTransactionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(32)))), ((int)(((byte)(81)))));
            this.splitContainer1.Panel2.Controls.Add(this.reportViewer1);
            this.splitContainer1.Size = new System.Drawing.Size(1076, 858);
            this.splitContainer1.SplitterDistance = 115;
            this.splitContainer1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnDateFilter);
            this.panel1.Controls.Add(this.rbExpense);
            this.panel1.Controls.Add(this.rbIncome);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnTypeFilter);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.dtFromDate);
            this.panel1.Controls.Add(this.dtToDate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1076, 115);
            this.panel1.TabIndex = 8;
            // 
            // btnDateFilter
            // 
            this.btnDateFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDateFilter.BackColor = System.Drawing.Color.Transparent;
            this.btnDateFilter.BackgroundImage = global::WalletLesster.Properties.Resources.blue_btn;
            this.btnDateFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDateFilter.FlatAppearance.BorderSize = 0;
            this.btnDateFilter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDateFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDateFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDateFilter.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDateFilter.ForeColor = System.Drawing.Color.White;
            this.btnDateFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnDateFilter.Image")));
            this.btnDateFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDateFilter.Location = new System.Drawing.Point(554, 36);
            this.btnDateFilter.Name = "btnDateFilter";
            this.btnDateFilter.Padding = new System.Windows.Forms.Padding(5, 5, 10, 5);
            this.btnDateFilter.Size = new System.Drawing.Size(173, 43);
            this.btnDateFilter.TabIndex = 61;
            this.btnDateFilter.Text = "Filter by Date";
            this.btnDateFilter.UseVisualStyleBackColor = false;
            this.btnDateFilter.Click += new System.EventHandler(this.btnDateFilter_Click);
            this.btnDateFilter.MouseLeave += new System.EventHandler(this.btnDateFilter_MouseLeave);
            this.btnDateFilter.MouseHover += new System.EventHandler(this.btnDateFilter_MouseHover);
            // 
            // rbExpense
            // 
            this.rbExpense.AutoSize = true;
            this.rbExpense.BackColor = System.Drawing.Color.Transparent;
            this.rbExpense.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbExpense.ForeColor = System.Drawing.Color.White;
            this.rbExpense.Location = new System.Drawing.Point(123, 73);
            this.rbExpense.Name = "rbExpense";
            this.rbExpense.Size = new System.Drawing.Size(104, 34);
            this.rbExpense.TabIndex = 60;
            this.rbExpense.Text = "Expense";
            this.rbExpense.UseVisualStyleBackColor = false;
            // 
            // rbIncome
            // 
            this.rbIncome.AutoSize = true;
            this.rbIncome.BackColor = System.Drawing.Color.Transparent;
            this.rbIncome.Checked = true;
            this.rbIncome.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbIncome.ForeColor = System.Drawing.Color.White;
            this.rbIncome.Location = new System.Drawing.Point(14, 73);
            this.rbIncome.Name = "rbIncome";
            this.rbIncome.Size = new System.Drawing.Size(99, 34);
            this.rbIncome.TabIndex = 59;
            this.rbIncome.TabStop = true;
            this.rbIncome.Text = "Income";
            this.rbIncome.UseVisualStyleBackColor = false;
            this.rbIncome.CheckedChanged += new System.EventHandler(this.rbIncome_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Poppins SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Cyan;
            this.label5.Location = new System.Drawing.Point(11, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 30);
            this.label5.TabIndex = 58;
            this.label5.Text = "Type of transaction";
            // 
            // btnTypeFilter
            // 
            this.btnTypeFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTypeFilter.BackColor = System.Drawing.Color.Transparent;
            this.btnTypeFilter.BackgroundImage = global::WalletLesster.Properties.Resources.pink_btn;
            this.btnTypeFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTypeFilter.FlatAppearance.BorderSize = 0;
            this.btnTypeFilter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnTypeFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnTypeFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTypeFilter.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTypeFilter.ForeColor = System.Drawing.Color.White;
            this.btnTypeFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnTypeFilter.Image")));
            this.btnTypeFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTypeFilter.Location = new System.Drawing.Point(741, 37);
            this.btnTypeFilter.Name = "btnTypeFilter";
            this.btnTypeFilter.Padding = new System.Windows.Forms.Padding(5, 5, 10, 5);
            this.btnTypeFilter.Size = new System.Drawing.Size(174, 43);
            this.btnTypeFilter.TabIndex = 7;
            this.btnTypeFilter.Text = "Filter by Type";
            this.btnTypeFilter.UseVisualStyleBackColor = false;
            this.btnTypeFilter.Click += new System.EventHandler(this.btnTypeFilter_Click);
            this.btnTypeFilter.MouseLeave += new System.EventHandler(this.btnTypeFilter_MouseLeave);
            this.btnTypeFilter.MouseHover += new System.EventHandler(this.btnTypeFilter_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(11, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "From Date:";
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.BackgroundImage = global::WalletLesster.Properties.Resources.orange_btn;
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReset.Location = new System.Drawing.Point(929, 37);
            this.btnReset.Name = "btnReset";
            this.btnReset.Padding = new System.Windows.Forms.Padding(5, 5, 15, 5);
            this.btnReset.Size = new System.Drawing.Size(135, 43);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            this.btnReset.MouseLeave += new System.EventHandler(this.btnReset_MouseLeave);
            this.btnReset.MouseHover += new System.EventHandler(this.btnReset_MouseHover);
            // 
            // dtFromDate
            // 
            this.dtFromDate.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFromDate.Location = new System.Drawing.Point(124, 19);
            this.dtFromDate.Name = "dtFromDate";
            this.dtFromDate.Size = new System.Drawing.Size(130, 27);
            this.dtFromDate.TabIndex = 3;
            // 
            // dtToDate
            // 
            this.dtToDate.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtToDate.Location = new System.Drawing.Point(354, 19);
            this.dtToDate.Name = "dtToDate";
            this.dtToDate.Size = new System.Drawing.Size(126, 27);
            this.dtToDate.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Poppins SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(265, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "To Date:";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "WL_TransactionDataSet";
            reportDataSource1.Value = this.walletLessterDBTransactionDataSetBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WalletLesster.Report.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1076, 739);
            this.reportViewer1.TabIndex = 0;
            // 
            // TransactionReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 858);
            this.Controls.Add(this.splitContainer1);
            this.DoubleBuffered = true;
            this.Name = "TransactionReport";
            this.Text = "TransactionReport";
            this.Load += new System.EventHandler(this.TransactionReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.walletLessterDBTransactionDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.walletLessterDBTransactionDataSet)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DateTimePicker dtToDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtFromDate;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.BindingSource walletLessterDBTransactionDataSetBindingSource;
        private WalletLessterDBTransactionDataSet walletLessterDBTransactionDataSet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTypeFilter;
        private System.Windows.Forms.RadioButton rbExpense;
        private System.Windows.Forms.RadioButton rbIncome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDateFilter;
    }
}