namespace Store
{
    partial class frmCart
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
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.nudCountToBuy = new System.Windows.Forms.NumericUpDown();
            this.lblCountToBuyLabel = new System.Windows.Forms.Label();
            this.lblRateData = new System.Windows.Forms.Label();
            this.LblRateLabel = new System.Windows.Forms.Label();
            this.lblPriceData = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDescriptionData = new System.Windows.Forms.Label();
            this.lblDescriptionLabel = new System.Windows.Forms.Label();
            this.lblProductNameData = new System.Windows.Forms.Label();
            this.lblProductNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountToBuy)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(150, 200);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 20);
            this.btnRemove.TabIndex = 32;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(270, 200);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 20);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(20, 200);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(75, 20);
            this.btnBuy.TabIndex = 30;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // nudCountToBuy
            // 
            this.nudCountToBuy.Location = new System.Drawing.Point(140, 168);
            this.nudCountToBuy.Name = "nudCountToBuy";
            this.nudCountToBuy.Size = new System.Drawing.Size(55, 20);
            this.nudCountToBuy.TabIndex = 29;
            this.nudCountToBuy.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblCountToBuyLabel
            // 
            this.lblCountToBuyLabel.AutoSize = true;
            this.lblCountToBuyLabel.Location = new System.Drawing.Point(20, 170);
            this.lblCountToBuyLabel.Name = "lblCountToBuyLabel";
            this.lblCountToBuyLabel.Size = new System.Drawing.Size(71, 13);
            this.lblCountToBuyLabel.TabIndex = 28;
            this.lblCountToBuyLabel.Text = "Count to Buy:";
            // 
            // lblRateData
            // 
            this.lblRateData.AutoSize = true;
            this.lblRateData.Location = new System.Drawing.Point(137, 140);
            this.lblRateData.Name = "lblRateData";
            this.lblRateData.Size = new System.Drawing.Size(34, 13);
            this.lblRateData.TabIndex = 25;
            this.lblRateData.Text = "Blank";
            // 
            // LblRateLabel
            // 
            this.LblRateLabel.AutoSize = true;
            this.LblRateLabel.Location = new System.Drawing.Point(20, 140);
            this.LblRateLabel.Name = "LblRateLabel";
            this.LblRateLabel.Size = new System.Drawing.Size(33, 13);
            this.LblRateLabel.TabIndex = 26;
            this.LblRateLabel.Text = "Rate:";
            // 
            // lblPriceData
            // 
            this.lblPriceData.AutoSize = true;
            this.lblPriceData.Location = new System.Drawing.Point(137, 110);
            this.lblPriceData.Name = "lblPriceData";
            this.lblPriceData.Size = new System.Drawing.Size(34, 13);
            this.lblPriceData.TabIndex = 23;
            this.lblPriceData.Text = "Blank";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(20, 110);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(34, 13);
            this.lblPrice.TabIndex = 24;
            this.lblPrice.Text = "Price:";
            // 
            // lblDescriptionData
            // 
            this.lblDescriptionData.AutoSize = true;
            this.lblDescriptionData.Location = new System.Drawing.Point(137, 80);
            this.lblDescriptionData.Name = "lblDescriptionData";
            this.lblDescriptionData.Size = new System.Drawing.Size(34, 13);
            this.lblDescriptionData.TabIndex = 21;
            this.lblDescriptionData.Text = "Blank";
            // 
            // lblDescriptionLabel
            // 
            this.lblDescriptionLabel.AutoSize = true;
            this.lblDescriptionLabel.Location = new System.Drawing.Point(20, 80);
            this.lblDescriptionLabel.Name = "lblDescriptionLabel";
            this.lblDescriptionLabel.Size = new System.Drawing.Size(63, 13);
            this.lblDescriptionLabel.TabIndex = 22;
            this.lblDescriptionLabel.Text = "Description:";
            // 
            // lblProductNameData
            // 
            this.lblProductNameData.AutoSize = true;
            this.lblProductNameData.Location = new System.Drawing.Point(137, 50);
            this.lblProductNameData.Name = "lblProductNameData";
            this.lblProductNameData.Size = new System.Drawing.Size(34, 13);
            this.lblProductNameData.TabIndex = 19;
            this.lblProductNameData.Text = "Blank";
            // 
            // lblProductNameLabel
            // 
            this.lblProductNameLabel.AutoSize = true;
            this.lblProductNameLabel.Location = new System.Drawing.Point(20, 50);
            this.lblProductNameLabel.Name = "lblProductNameLabel";
            this.lblProductNameLabel.Size = new System.Drawing.Size(78, 13);
            this.lblProductNameLabel.TabIndex = 20;
            this.lblProductNameLabel.Text = "Product Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(127, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Goods in Cart:";
            // 
            // frmCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 241);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.nudCountToBuy);
            this.Controls.Add(this.lblCountToBuyLabel);
            this.Controls.Add(this.lblRateData);
            this.Controls.Add(this.LblRateLabel);
            this.Controls.Add(this.lblPriceData);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblDescriptionData);
            this.Controls.Add(this.lblDescriptionLabel);
            this.Controls.Add(this.lblProductNameData);
            this.Controls.Add(this.lblProductNameLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(380, 280);
            this.MinimumSize = new System.Drawing.Size(380, 280);
            this.Name = "frmCart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cart";
            ((System.ComponentModel.ISupportInitialize)(this.nudCountToBuy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.NumericUpDown nudCountToBuy;
        private System.Windows.Forms.Label lblCountToBuyLabel;
        private System.Windows.Forms.Label lblRateData;
        private System.Windows.Forms.Label LblRateLabel;
        private System.Windows.Forms.Label lblPriceData;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDescriptionData;
        private System.Windows.Forms.Label lblDescriptionLabel;
        private System.Windows.Forms.Label lblProductNameData;
        private System.Windows.Forms.Label lblProductNameLabel;
        private System.Windows.Forms.Label label1;
    }
}