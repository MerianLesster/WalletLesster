
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
            this.btnPredictStatus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dpPredictDate = new System.Windows.Forms.DateTimePicker();
            this.panelTip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.pnlPredictionResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStatus)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTip
            // 
            this.panelTip.BackColor = System.Drawing.Color.White;
            this.panelTip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTip.Controls.Add(this.lblTip);
            this.panelTip.Controls.Add(this.pictureBox5);
            this.panelTip.Location = new System.Drawing.Point(12, 81);
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
            this.lblTitle.Location = new System.Drawing.Point(12, 22);
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
            this.pnlPredictionResult.Controls.Add(this.lblStatus);
            this.pnlPredictionResult.Location = new System.Drawing.Point(179, 309);
            this.pnlPredictionResult.Name = "pnlPredictionResult";
            this.pnlPredictionResult.Size = new System.Drawing.Size(737, 191);
            this.pnlPredictionResult.TabIndex = 32;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Poppins", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(34, 43);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(300, 106);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Expense";
            // 
            // pictureBoxStatus
            // 
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
            this.panel1.Controls.Add(this.btnPredictStatus);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dpPredictDate);
            this.panel1.Location = new System.Drawing.Point(65, 179);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(939, 100);
            this.panel1.TabIndex = 34;
            // 
            // btnPredictStatus
            // 
            this.btnPredictStatus.BackColor = System.Drawing.Color.Transparent;
            this.btnPredictStatus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPredictStatus.BackgroundImage")));
            this.btnPredictStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPredictStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPredictStatus.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPredictStatus.ForeColor = System.Drawing.Color.Black;
            this.btnPredictStatus.Image = ((System.Drawing.Image)(resources.GetObject("btnPredictStatus.Image")));
            this.btnPredictStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPredictStatus.Location = new System.Drawing.Point(647, 21);
            this.btnPredictStatus.Name = "btnPredictStatus";
            this.btnPredictStatus.Padding = new System.Windows.Forms.Padding(5);
            this.btnPredictStatus.Size = new System.Drawing.Size(261, 61);
            this.btnPredictStatus.TabIndex = 52;
            this.btnPredictStatus.Text = "Predict Status";
            this.btnPredictStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPredictStatus.UseVisualStyleBackColor = false;
            this.btnPredictStatus.Click += new System.EventHandler(this.btnPredictStatus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 25);
            this.label1.TabIndex = 53;
            this.label1.Text = "Date";
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
            this.dpPredictDate.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpPredictDate.Location = new System.Drawing.Point(51, 49);
            this.dpPredictDate.Name = "dpPredictDate";
            this.dpPredictDate.Size = new System.Drawing.Size(325, 27);
            this.dpPredictDate.TabIndex = 54;
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
    }
}