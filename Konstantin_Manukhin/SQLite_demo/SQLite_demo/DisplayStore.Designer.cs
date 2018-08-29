using System;
using System.Windows.Forms;

namespace SQLite_demo
{
    partial class DisplayStore
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
            this.sqlSpatialFunctionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ButtonRefresh = new System.Windows.Forms.Button();
            this.ViewStore = new System.Windows.Forms.ListView();
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnRating = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ButtonAddProduct = new System.Windows.Forms.Button();
            this.ButtonDeleteProduct = new System.Windows.Forms.Button();
            this.ButtonUpdateProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sqlSpatialFunctionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlSpatialFunctionsBindingSource
            // 
            this.sqlSpatialFunctionsBindingSource.DataSource = typeof(System.Data.Entity.SqlServer.SqlSpatialFunctions);
            // 
            // ButtonRefresh
            // 
            this.ButtonRefresh.Location = new System.Drawing.Point(480, 345);
            this.ButtonRefresh.Name = "ButtonRefresh";
            this.ButtonRefresh.Size = new System.Drawing.Size(142, 23);
            this.ButtonRefresh.TabIndex = 1;
            this.ButtonRefresh.Text = "Refresh";
            this.ButtonRefresh.UseVisualStyleBackColor = true;
            this.ButtonRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // ViewStore
            // 
            this.ViewStore.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnCategory,
            this.columnName,
            this.columnDescription,
            this.columnPrice,
            this.columnRating,
            this.columnQuantity});
            this.ViewStore.Location = new System.Drawing.Point(20, 20);
            this.ViewStore.Name = "ViewStore";
            this.ViewStore.Size = new System.Drawing.Size(602, 319);
            this.ViewStore.TabIndex = 2;
            this.ViewStore.UseCompatibleStateImageBehavior = false;
            this.ViewStore.View = System.Windows.Forms.View.Details;
            this.ViewStore.SelectedIndexChanged += new System.EventHandler(this.ViewStore_SelectedIndexChanged);
            this.ViewStore.DoubleClick += new System.EventHandler(this.ViewStore_DoubleClick);
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            this.columnName.Width = 69;
            // 
            // columnCategory
            // 
            this.columnCategory.Text = "Category";
            this.columnCategory.Width = 91;
            // 
            // columnDescription
            // 
            this.columnDescription.Text = "Description";
            this.columnDescription.Width = 158;
            // 
            // columnPrice
            // 
            this.columnPrice.Text = "Price";
            this.columnPrice.Width = 88;
            // 
            // columnRating
            // 
            this.columnRating.Text = "Rating";
            this.columnRating.Width = 68;
            // 
            // columnQuantity
            // 
            this.columnQuantity.Text = "Quantity";
            this.columnQuantity.Width = 61;
            // 
            // ButtonAddProduct
            // 
            this.ButtonAddProduct.Location = new System.Drawing.Point(360, 345);
            this.ButtonAddProduct.Name = "ButtonAddProduct";
            this.ButtonAddProduct.Size = new System.Drawing.Size(114, 23);
            this.ButtonAddProduct.TabIndex = 3;
            this.ButtonAddProduct.Text = "Add Product";
            this.ButtonAddProduct.UseVisualStyleBackColor = true;
            this.ButtonAddProduct.Click += new System.EventHandler(this.ButtonAddProduct_Click);
            // 
            // ButtonDeleteProduct
            // 
            this.ButtonDeleteProduct.Location = new System.Drawing.Point(237, 345);
            this.ButtonDeleteProduct.Name = "ButtonDeleteProduct";
            this.ButtonDeleteProduct.Size = new System.Drawing.Size(117, 23);
            this.ButtonDeleteProduct.TabIndex = 4;
            this.ButtonDeleteProduct.Text = "Delete Product";
            this.ButtonDeleteProduct.UseVisualStyleBackColor = true;
            this.ButtonDeleteProduct.Click += new System.EventHandler(this.ButtonDeleteProduct_Click);
            // 
            // ButtonUpdateProduct
            // 
            this.ButtonUpdateProduct.Location = new System.Drawing.Point(125, 345);
            this.ButtonUpdateProduct.Name = "ButtonUpdateProduct";
            this.ButtonUpdateProduct.Size = new System.Drawing.Size(106, 23);
            this.ButtonUpdateProduct.TabIndex = 5;
            this.ButtonUpdateProduct.Text = "Update Product";
            this.ButtonUpdateProduct.UseVisualStyleBackColor = true;
            // 
            // DisplayStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(646, 380);
            this.Controls.Add(this.ButtonUpdateProduct);
            this.Controls.Add(this.ButtonDeleteProduct);
            this.Controls.Add(this.ButtonAddProduct);
            this.Controls.Add(this.ViewStore);
            this.Controls.Add(this.ButtonRefresh);
            this.MaximizeBox = false;
            this.Name = "DisplayStore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Store";
            this.Load += new System.EventHandler(this.DisplayStore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sqlSpatialFunctionsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        //private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        #endregion
        private System.Windows.Forms.BindingSource sqlSpatialFunctionsBindingSource;
        private System.Windows.Forms.Button ButtonRefresh;
        public ListView ViewStore;
        private ColumnHeader columnName;
        private ColumnHeader columnCategory;
        private ColumnHeader columnDescription;
        private ColumnHeader columnPrice;
        private ColumnHeader columnRating;
        private Button ButtonAddProduct;
        private Button ButtonDeleteProduct;
        private ColumnHeader columnID;
        private Button ButtonUpdateProduct;
        private ColumnHeader columnQuantity;
    }
}