namespace Store
{
    partial class frmChangeGood
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
            this.txbRate = new System.Windows.Forms.TextBox();
            this.txbPrice = new System.Windows.Forms.TextBox();
            this.txbCount = new System.Windows.Forms.TextBox();
            this.txbDescription = new System.Windows.Forms.TextBox();
            this.txbCategory = new System.Windows.Forms.TextBox();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txbProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbRate
            // 
            this.txbRate.Location = new System.Drawing.Point(112, 218);
            this.txbRate.Name = "txbRate";
            this.txbRate.Size = new System.Drawing.Size(170, 20);
            this.txbRate.TabIndex = 41;
            // 
            // txbPrice
            // 
            this.txbPrice.Location = new System.Drawing.Point(112, 178);
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.Size = new System.Drawing.Size(170, 20);
            this.txbPrice.TabIndex = 40;
            // 
            // txbCount
            // 
            this.txbCount.Location = new System.Drawing.Point(112, 138);
            this.txbCount.Name = "txbCount";
            this.txbCount.Size = new System.Drawing.Size(170, 20);
            this.txbCount.TabIndex = 39;
            // 
            // txbDescription
            // 
            this.txbDescription.Location = new System.Drawing.Point(112, 98);
            this.txbDescription.Name = "txbDescription";
            this.txbDescription.Size = new System.Drawing.Size(170, 20);
            this.txbDescription.TabIndex = 38;
            // 
            // txbCategory
            // 
            this.txbCategory.Location = new System.Drawing.Point(112, 58);
            this.txbCategory.Name = "txbCategory";
            this.txbCategory.Size = new System.Drawing.Size(170, 20);
            this.txbCategory.TabIndex = 37;
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(22, 221);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(30, 13);
            this.lblRate.TabIndex = 36;
            this.lblRate.Text = "Rate";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(22, 181);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 35;
            this.lblPrice.Text = "Price";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(22, 141);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(35, 13);
            this.lblCount.TabIndex = 34;
            this.lblCount.Text = "Count";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(22, 101);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 33;
            this.lblDescription.Text = "Description";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(22, 61);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(49, 13);
            this.lblCategory.TabIndex = 32;
            this.lblCategory.Text = "Category";
            // 
            // txbProductName
            // 
            this.txbProductName.Location = new System.Drawing.Point(112, 18);
            this.txbProductName.Name = "txbProductName";
            this.txbProductName.Size = new System.Drawing.Size(170, 20);
            this.txbProductName.TabIndex = 31;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(22, 21);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(75, 13);
            this.lblProductName.TabIndex = 30;
            this.lblProductName.Text = "Product Name";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(207, 268);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 25);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(25, 268);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 25);
            this.btnChange.TabIndex = 28;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // frmChangeGood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 311);
            this.Controls.Add(this.txbRate);
            this.Controls.Add(this.txbPrice);
            this.Controls.Add(this.txbCount);
            this.Controls.Add(this.txbDescription);
            this.Controls.Add(this.txbCategory);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.txbProductName);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnChange);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(320, 350);
            this.MinimumSize = new System.Drawing.Size(320, 350);
            this.Name = "frmChangeGood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Good";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbRate;
        private System.Windows.Forms.TextBox txbPrice;
        private System.Windows.Forms.TextBox txbCount;
        private System.Windows.Forms.TextBox txbDescription;
        private System.Windows.Forms.TextBox txbCategory;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txbProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnChange;
    }
}