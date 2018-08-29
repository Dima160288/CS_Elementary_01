namespace Store
{
    partial class frmShop
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
            this.btnAutorization = new System.Windows.Forms.Button();
            this.btnChangeGoods = new System.Windows.Forms.Button();
            this.btnRemoveGoods = new System.Windows.Forms.Button();
            this.btnGotoCart = new System.Windows.Forms.Button();
            this.btnAddGoods = new System.Windows.Forms.Button();
            this.btnAddtoCart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvStore = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStore)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAutorization
            // 
            this.btnAutorization.Location = new System.Drawing.Point(375, 280);
            this.btnAutorization.Name = "btnAutorization";
            this.btnAutorization.Size = new System.Drawing.Size(130, 60);
            this.btnAutorization.TabIndex = 17;
            this.btnAutorization.Text = "Autorization";
            this.btnAutorization.UseVisualStyleBackColor = true;
            this.btnAutorization.Visible = false;
            this.btnAutorization.Click += new System.EventHandler(this.btnAutorization_Click);
            // 
            // btnChangeGoods
            // 
            this.btnChangeGoods.Location = new System.Drawing.Point(375, 315);
            this.btnChangeGoods.Name = "btnChangeGoods";
            this.btnChangeGoods.Size = new System.Drawing.Size(130, 25);
            this.btnChangeGoods.TabIndex = 16;
            this.btnChangeGoods.Text = "Change Goods";
            this.btnChangeGoods.UseVisualStyleBackColor = true;
            this.btnChangeGoods.Click += new System.EventHandler(this.btnChangeGoods_Click);
            // 
            // btnRemoveGoods
            // 
            this.btnRemoveGoods.Location = new System.Drawing.Point(220, 315);
            this.btnRemoveGoods.Name = "btnRemoveGoods";
            this.btnRemoveGoods.Size = new System.Drawing.Size(130, 25);
            this.btnRemoveGoods.TabIndex = 15;
            this.btnRemoveGoods.Text = "Remove Goods";
            this.btnRemoveGoods.UseVisualStyleBackColor = true;
            this.btnRemoveGoods.Click += new System.EventHandler(this.btnRemoveGoods_Click);
            // 
            // btnGotoCart
            // 
            this.btnGotoCart.Location = new System.Drawing.Point(530, 280);
            this.btnGotoCart.Name = "btnGotoCart";
            this.btnGotoCart.Size = new System.Drawing.Size(130, 60);
            this.btnGotoCart.TabIndex = 14;
            this.btnGotoCart.Text = "Go to Cart";
            this.btnGotoCart.UseVisualStyleBackColor = true;
            this.btnGotoCart.Click += new System.EventHandler(this.btnGotoCart_Click);
            // 
            // btnAddGoods
            // 
            this.btnAddGoods.Location = new System.Drawing.Point(220, 280);
            this.btnAddGoods.Name = "btnAddGoods";
            this.btnAddGoods.Size = new System.Drawing.Size(130, 25);
            this.btnAddGoods.TabIndex = 13;
            this.btnAddGoods.Text = "Add Goods";
            this.btnAddGoods.UseVisualStyleBackColor = true;
            this.btnAddGoods.Click += new System.EventHandler(this.btnAddGoods_Click);
            // 
            // btnAddtoCart
            // 
            this.btnAddtoCart.Location = new System.Drawing.Point(375, 280);
            this.btnAddtoCart.Name = "btnAddtoCart";
            this.btnAddtoCart.Size = new System.Drawing.Size(130, 25);
            this.btnAddtoCart.TabIndex = 12;
            this.btnAddtoCart.Text = "Add to Cart";
            this.btnAddtoCart.UseVisualStyleBackColor = true;
            this.btnAddtoCart.Click += new System.EventHandler(this.btnAddtoCart_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(685, 280);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(130, 60);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(65, 280);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(130, 60);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgvStore
            // 
            this.dgvStore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStore.Location = new System.Drawing.Point(65, 20);
            this.dgvStore.Name = "dgvStore";
            this.dgvStore.Size = new System.Drawing.Size(750, 250);
            this.dgvStore.TabIndex = 9;
            // 
            // frmShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 361);
            this.Controls.Add(this.btnAutorization);
            this.Controls.Add(this.btnChangeGoods);
            this.Controls.Add(this.btnRemoveGoods);
            this.Controls.Add(this.btnGotoCart);
            this.Controls.Add(this.btnAddGoods);
            this.Controls.Add(this.btnAddtoCart);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvStore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmShop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shop";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAutorization;
        private System.Windows.Forms.Button btnChangeGoods;
        private System.Windows.Forms.Button btnRemoveGoods;
        private System.Windows.Forms.Button btnGotoCart;
        private System.Windows.Forms.Button btnAddGoods;
        private System.Windows.Forms.Button btnAddtoCart;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvStore;
    }
}