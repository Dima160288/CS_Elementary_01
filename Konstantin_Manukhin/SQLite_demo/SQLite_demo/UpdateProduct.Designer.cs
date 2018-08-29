namespace SQLite_demo
{
    partial class UpdateProduct
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
            this.textID = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.textCategory = new System.Windows.Forms.TextBox();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.textRating = new System.Windows.Forms.TextBox();
            this.textQuantity = new System.Windows.Forms.TextBox();
            this.ButtonCommitUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(119, 21);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(133, 20);
            this.textID.TabIndex = 0;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(119, 47);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(133, 20);
            this.textName.TabIndex = 1;
            // 
            // textDescription
            // 
            this.textDescription.Location = new System.Drawing.Point(119, 99);
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(133, 20);
            this.textDescription.TabIndex = 2;
            // 
            // textCategory
            // 
            this.textCategory.Location = new System.Drawing.Point(119, 73);
            this.textCategory.Name = "textCategory";
            this.textCategory.Size = new System.Drawing.Size(133, 20);
            this.textCategory.TabIndex = 3;
            // 
            // textPrice
            // 
            this.textPrice.Location = new System.Drawing.Point(119, 125);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(133, 20);
            this.textPrice.TabIndex = 4;
            // 
            // textRating
            // 
            this.textRating.Location = new System.Drawing.Point(119, 151);
            this.textRating.Name = "textRating";
            this.textRating.Size = new System.Drawing.Size(133, 20);
            this.textRating.TabIndex = 5;
            // 
            // textQuantity
            // 
            this.textQuantity.Location = new System.Drawing.Point(119, 177);
            this.textQuantity.Name = "textQuantity";
            this.textQuantity.Size = new System.Drawing.Size(133, 20);
            this.textQuantity.TabIndex = 6;
            // 
            // ButtonCommitUpdate
            // 
            this.ButtonCommitUpdate.Location = new System.Drawing.Point(157, 203);
            this.ButtonCommitUpdate.Name = "ButtonCommitUpdate";
            this.ButtonCommitUpdate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonCommitUpdate.Size = new System.Drawing.Size(95, 23);
            this.ButtonCommitUpdate.TabIndex = 7;
            this.ButtonCommitUpdate.Text = "Update";
            this.ButtonCommitUpdate.UseVisualStyleBackColor = true;
            this.ButtonCommitUpdate.Click += new System.EventHandler(this.ButtonCommitUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Category:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Price:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Rating:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Quantity:";
            // 
            // UpdateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 238);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonCommitUpdate);
            this.Controls.Add(this.textQuantity);
            this.Controls.Add(this.textRating);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.textCategory);
            this.Controls.Add(this.textDescription);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textID);
            this.Name = "UpdateProduct";
            this.Text = "UpdateProduct";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UpdateProduct_FormClosing);
            this.Load += new System.EventHandler(this.UpdateProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textDescription;
        private System.Windows.Forms.TextBox textCategory;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.TextBox textRating;
        private System.Windows.Forms.TextBox textQuantity;
        private System.Windows.Forms.Button ButtonCommitUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}