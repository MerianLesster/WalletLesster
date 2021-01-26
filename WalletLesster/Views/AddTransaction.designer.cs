
namespace WalletLesster.Views
{
    partial class AddTransaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTransaction));
            this.panelTransactions = new System.Windows.Forms.Panel();
            this.panelTip = new System.Windows.Forms.Panel();
            this.lblTip = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAddAnother = new System.Windows.Forms.Button();
            this.btnSaveTransaction = new System.Windows.Forms.Button();
            this.panelTip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTransactions
            // 
            this.panelTransactions.AutoScroll = true;
            this.panelTransactions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(32)))), ((int)(((byte)(81)))));
            this.panelTransactions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTransactions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTransactions.Location = new System.Drawing.Point(24, 135);
            this.panelTransactions.Name = "panelTransactions";
            this.panelTransactions.Size = new System.Drawing.Size(1148, 553);
            this.panelTransactions.TabIndex = 10;
            // 
            // panelTip
            // 
            this.panelTip.BackColor = System.Drawing.Color.White;
            this.panelTip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTip.Controls.Add(this.lblTip);
            this.panelTip.Controls.Add(this.pictureBox1);
            this.panelTip.Location = new System.Drawing.Point(24, 63);
            this.panelTip.Name = "panelTip";
            this.panelTip.Size = new System.Drawing.Size(1148, 66);
            this.panelTip.TabIndex = 8;
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
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 70);
            this.label1.TabIndex = 7;
            this.label1.Text = "Add Transaction";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(32)))), ((int)(((byte)(81)))));
            this.panel3.Controls.Add(this.btnAddAnother);
            this.panel3.Controls.Add(this.btnSaveTransaction);
            this.panel3.Location = new System.Drawing.Point(-1, 704);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1208, 88);
            this.panel3.TabIndex = 9;
            // 
            // btnAddAnother
            // 
            this.btnAddAnother.BackColor = System.Drawing.Color.Transparent;
            this.btnAddAnother.BackgroundImage = global::WalletLesster.Properties.Resources.yellow_btn;
            this.btnAddAnother.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddAnother.FlatAppearance.BorderSize = 0;
            this.btnAddAnother.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAddAnother.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddAnother.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAnother.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAnother.ForeColor = System.Drawing.Color.White;
            this.btnAddAnother.Image = ((System.Drawing.Image)(resources.GetObject("btnAddAnother.Image")));
            this.btnAddAnother.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddAnother.Location = new System.Drawing.Point(689, 8);
            this.btnAddAnother.Name = "btnAddAnother";
            this.btnAddAnother.Padding = new System.Windows.Forms.Padding(5, 5, 15, 5);
            this.btnAddAnother.Size = new System.Drawing.Size(232, 54);
            this.btnAddAnother.TabIndex = 3;
            this.btnAddAnother.Text = "Add another";
            this.btnAddAnother.UseVisualStyleBackColor = false;
            this.btnAddAnother.Click += new System.EventHandler(this.AddAnotherTransaction);
            this.btnAddAnother.MouseLeave += new System.EventHandler(this.btnAddAnother_MouseLeave);
            this.btnAddAnother.MouseHover += new System.EventHandler(this.btnAddAnother_MouseHover);
            // 
            // btnSaveTransaction
            // 
            this.btnSaveTransaction.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveTransaction.BackgroundImage = global::WalletLesster.Properties.Resources.green_btn;
            this.btnSaveTransaction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaveTransaction.FlatAppearance.BorderSize = 0;
            this.btnSaveTransaction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSaveTransaction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSaveTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveTransaction.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveTransaction.ForeColor = System.Drawing.Color.White;
            this.btnSaveTransaction.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveTransaction.Image")));
            this.btnSaveTransaction.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveTransaction.Location = new System.Drawing.Point(927, 8);
            this.btnSaveTransaction.Name = "btnSaveTransaction";
            this.btnSaveTransaction.Padding = new System.Windows.Forms.Padding(1, 5, 5, 5);
            this.btnSaveTransaction.Size = new System.Drawing.Size(246, 54);
            this.btnSaveTransaction.TabIndex = 1;
            this.btnSaveTransaction.Text = "Save transaction";
            this.btnSaveTransaction.UseVisualStyleBackColor = false;
            this.btnSaveTransaction.Click += new System.EventHandler(this.btnSaveTransaction_Click);
            this.btnSaveTransaction.MouseLeave += new System.EventHandler(this.btnSaveTransaction_MouseLeave);
            this.btnSaveTransaction.MouseHover += new System.EventHandler(this.btnSaveTransaction_MouseHover);
            // 
            // AddTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1201, 773);
            this.Controls.Add(this.panelTransactions);
            this.Controls.Add(this.panelTip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1219, 820);
            this.MinimumSize = new System.Drawing.Size(1219, 820);
            this.Name = "AddTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Transaction";
            this.panelTip.ResumeLayout(false);
            this.panelTip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnSaveTransaction;
        private System.Windows.Forms.Button btnAddAnother;
    }
}