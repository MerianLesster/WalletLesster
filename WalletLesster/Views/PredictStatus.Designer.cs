
namespace WalletLesster.Views
{
    partial class PredictStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PredictStatus));
            this.panelTip = new System.Windows.Forms.Panel();
            this.lblTip = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlPredictionResult = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pictureBoxStatus = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dpPredictDate = new System.Windows.Forms.DateTimePicker();
            this.btnPredictStatus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPredictedAmount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelTip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.pnlPredictionResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStatus)).BeginInit();
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
            this.panelTip.TabIndex = 30;
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTip.Location = new System.Drawing.Point(81, 17);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(785, 35);
            this.lblTip.TabIndex = 1;
            this.lblTip.Text = "predict your financial status at a future date based on your expense patterns.";
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
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Poppins", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Cyan;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(301, 67);
            this.lblTitle.TabIndex = 31;
            this.lblTitle.Text = "Predict Status";
            // 
            // pnlPredictionResult
            // 
            this.pnlPredictionResult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlPredictionResult.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlPredictionResult.BackgroundImage")));
            this.pnlPredictionResult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPredictionResult.Controls.Add(this.label3);
            this.pnlPredictionResult.Controls.Add(this.label2);
            this.pnlPredictionResult.Controls.Add(this.lblPredictedAmount);
            this.pnlPredictionResult.Controls.Add(this.lblStatus);
            this.pnlPredictionResult.Location = new System.Drawing.Point(65, 299);
            this.pnlPredictionResult.Name = "pnlPredictionResult";
            this.pnlPredictionResult.Size = new System.Drawing.Size(939, 191);
            this.pnlPredictionResult.TabIndex = 32;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Poppins", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(489, 100);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(170, 60);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Expense";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxStatus
            // 
            this.pictureBoxStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxStatus.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxStatus.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxStatus.Image")));
            this.pictureBoxStatus.Location = new System.Drawing.Point(273, 535);
            this.pictureBoxStatus.Name = "pictureBoxStatus";
            this.pictureBoxStatus.Size = new System.Drawing.Size(584, 311);
            this.pictureBoxStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxStatus.TabIndex = 33;
            this.pictureBoxStatus.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(32)))), ((int)(((byte)(81)))));
            this.panel1.Controls.Add(this.dpPredictDate);
            this.panel1.Controls.Add(this.btnPredictStatus);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(65, 179);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(939, 100);
            this.panel1.TabIndex = 34;
            // 
            // dpPredictDate
            // 
            this.dpPredictDate.CalendarFont = new System.Drawing.Font("Poppins SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpPredictDate.CalendarForeColor = System.Drawing.Color.Plum;
            this.dpPredictDate.CalendarMonthBackground = System.Drawing.Color.Plum;
            this.dpPredictDate.CalendarTitleBackColor = System.Drawing.Color.Plum;
            this.dpPredictDate.CalendarTitleForeColor = System.Drawing.Color.Plum;
            this.dpPredictDate.CalendarTrailingForeColor = System.Drawing.Color.Plum;
            this.dpPredictDate.Checked = false;
            this.dpPredictDate.CustomFormat = "";
            this.dpPredictDate.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpPredictDate.Location = new System.Drawing.Point(51, 49);
            this.dpPredictDate.Name = "dpPredictDate";
            this.dpPredictDate.Size = new System.Drawing.Size(380, 32);
            this.dpPredictDate.TabIndex = 54;
            // 
            // btnPredictStatus
            // 
            this.btnPredictStatus.BackColor = System.Drawing.Color.Transparent;
            this.btnPredictStatus.BackgroundImage = global::WalletLesster.Properties.Resources.green_btn;
            this.btnPredictStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPredictStatus.FlatAppearance.BorderSize = 0;
            this.btnPredictStatus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPredictStatus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPredictStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPredictStatus.Font = new System.Drawing.Font("Poppins SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPredictStatus.ForeColor = System.Drawing.Color.White;
            this.btnPredictStatus.Image = ((System.Drawing.Image)(resources.GetObject("btnPredictStatus.Image")));
            this.btnPredictStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPredictStatus.Location = new System.Drawing.Point(672, 37);
            this.btnPredictStatus.Name = "btnPredictStatus";
            this.btnPredictStatus.Padding = new System.Windows.Forms.Padding(5, 5, 15, 5);
            this.btnPredictStatus.Size = new System.Drawing.Size(244, 44);
            this.btnPredictStatus.TabIndex = 52;
            this.btnPredictStatus.Text = "Predict Status";
            this.btnPredictStatus.UseVisualStyleBackColor = false;
            this.btnPredictStatus.Click += new System.EventHandler(this.btnPredictStatus_Click);
            this.btnPredictStatus.MouseLeave += new System.EventHandler(this.btnPredictStatus_MouseLeave);
            this.btnPredictStatus.MouseHover += new System.EventHandler(this.btnPredictStatus_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(46, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 30);
            this.label1.TabIndex = 53;
            this.label1.Text = "Date";
            // 
            // lblPredictedAmount
            // 
            this.lblPredictedAmount.AutoSize = true;
            this.lblPredictedAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblPredictedAmount.Font = new System.Drawing.Font("Poppins", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPredictedAmount.ForeColor = System.Drawing.Color.White;
            this.lblPredictedAmount.Location = new System.Drawing.Point(489, 25);
            this.lblPredictedAmount.Name = "lblPredictedAmount";
            this.lblPredictedAmount.Size = new System.Drawing.Size(168, 60);
            this.lblPredictedAmount.TabIndex = 1;
            this.lblPredictedAmount.Text = "Amount";
            this.lblPredictedAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Poppins", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(91, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(356, 60);
            this.label2.TabIndex = 2;
            this.label2.Text = "Predicted Expense:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Poppins", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(298, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 60);
            this.label3.TabIndex = 3;
            this.label3.Text = "Status:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PredictStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1076, 858);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBoxStatus);
            this.Controls.Add(this.pnlPredictionResult);
            this.Controls.Add(this.panelTip);
            this.Controls.Add(this.lblTitle);
            this.DoubleBuffered = true;
            this.Name = "PredictStatus";
            this.Text = "PredictStatus";
            this.panelTip.ResumeLayout(false);
            this.panelTip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.pnlPredictionResult.ResumeLayout(false);
            this.pnlPredictionResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStatus)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTip;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlPredictionResult;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.PictureBox pictureBoxStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPredictStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dpPredictDate;
        private System.Windows.Forms.Label lblPredictedAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}