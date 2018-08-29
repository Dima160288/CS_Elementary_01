namespace SQLite_demo
{
    partial class AddProduct
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
            this.textCategory = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.textRating = new System.Windows.Forms.TextBox();
            this.textQuantity = new System.Windows.Forms.TextBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.Rating = new System.Windows.Forms.Label();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.ButtonAddProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textCategory
            // 
            this.textCategory.Location = new System.Drawing.Point(97, 54);
            this.textCategory.Name = "textCategory";
            this.textCategory.Size = new System.Drawing.Size(182, 20);
            this.textCategory.TabIndex = 1;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(97, 80);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(182, 20);
            this.textName.TabIndex = 2;
            // 
            // textDescription
            // 
            this.textDescription.Location = new System.Drawing.Point(97, 106);
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(182, 20);
            this.textDescription.TabIndex = 3;
            // 
            // textPrice
            // 
            this.textPrice.Location = new System.Drawing.Point(97, 132);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(182, 20);
            this.textPrice.TabIndex = 4;
            // 
            // textRating
            // 
            this.textRating.Location = new System.Drawing.Point(97, 158);
            this.textRating.Name = "textRating";
            this.textRating.Size = new System.Drawing.Size(182, 20);
            this.textRating.TabIndex = 5;
            // 
            // textQuantity
            // 
            this.textQuantity.Location = new System.Drawing.Point(97, 184);
            this.textQuantity.Name = "textQuantity";
            this.textQuantity.Size = new System.Drawing.Size(182, 20);
            this.textQuantity.TabIndex = 6;
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(42, 57);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(49, 13);
            this.CategoryLabel.TabIndex = 7;
            this.CategoryLabel.Text = "Category";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(56, 83);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 8;
            this.NameLabel.Text = "Name";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(31, 109);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.DescriptionLabel.TabIndex = 9;
            this.DescriptionLabel.Text = "Description";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(56, 135);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(31, 13);
            this.PriceLabel.TabIndex = 10;
            this.PriceLabel.Text = "Price";
            // 
            // Rating
            // 
            this.Rating.AutoSize = true;
            this.Rating.Location = new System.Drawing.Point(53, 161);
            this.Rating.Name = "Rating";
            this.Rating.Size = new System.Drawing.Size(38, 13);
            this.Rating.TabIndex = 11;
            this.Rating.Text = "Rating";
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Location = new System.Drawing.Point(45, 187);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(46, 13);
            this.QuantityLabel.TabIndex = 12;
            this.QuantityLabel.Text = "Quantity";
            // 
            // ButtonAddProduct
            // 
            this.ButtonAddProduct.Location = new System.Drawing.Point(204, 210);
            this.ButtonAddProduct.Name = "ButtonAddProduct";
            this.ButtonAddProduct.Size = new System.Drawing.Size(75, 23);
            this.ButtonAddProduct.TabIndex = 13;
            this.ButtonAddProduct.Text = "Add Product";
            this.ButtonAddProduct.UseVisualStyleBackColor = true;
            this.ButtonAddProduct.Click += new System.EventHandler(this.ButtonAddProduct_Click);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 274);
            this.Controls.Add(this.ButtonAddProduct);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.Rating);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.textQuantity);
            this.Controls.Add(this.textRating);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.textDescription);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textCategory);
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textCategory;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textDescription;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.TextBox textRating;
        private System.Windows.Forms.TextBox textQuantity;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label Rating;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.Button ButtonAddProduct;
    }
}