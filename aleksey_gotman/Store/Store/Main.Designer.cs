namespace Store
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvStore = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddtoCart = new System.Windows.Forms.Button();
            this.btnAddGoods = new System.Windows.Forms.Button();
            this.btnGotoCart = new System.Windows.Forms.Button();
            this.btnRemoveGoods = new System.Windows.Forms.Button();
            this.btnChangeGoods = new System.Windows.Forms.Button();
            this.btnAutorization = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStore)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStore
            // 
            this.dgvStore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStore.Location = new System.Drawing.Point(58, 29);
            this.dgvStore.Name = "dgvStore";
            this.dgvStore.Size = new System.Drawing.Size(746, 243);
            this.dgvStore.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(58, 320);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(137, 61);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(670, 320);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(134, 61);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddtoCart
            // 
            this.btnAddtoCart.Location = new System.Drawing.Point(364, 320);
            this.btnAddtoCart.Name = "btnAddtoCart";
            this.btnAddtoCart.Size = new System.Drawing.Size(147, 23);
            this.btnAddtoCart.TabIndex = 3;
            this.btnAddtoCart.Text = "Add to Cart";
            this.btnAddtoCart.UseVisualStyleBackColor = true;
            // 
            // btnAddGoods
            // 
            this.btnAddGoods.Location = new System.Drawing.Point(201, 320);
            this.btnAddGoods.Name = "btnAddGoods";
            this.btnAddGoods.Size = new System.Drawing.Size(157, 23);
            this.btnAddGoods.TabIndex = 4;
            this.btnAddGoods.Text = "Add Goods";
            this.btnAddGoods.UseVisualStyleBackColor = true;
            this.btnAddGoods.Click += new System.EventHandler(this.btnAddGoods_Click);
            // 
            // btnGotoCart
            // 
            this.btnGotoCart.Location = new System.Drawing.Point(517, 320);
            this.btnGotoCart.Name = "btnGotoCart";
            this.btnGotoCart.Size = new System.Drawing.Size(147, 61);
            this.btnGotoCart.TabIndex = 5;
            this.btnGotoCart.Text = "Go to Cart";
            this.btnGotoCart.UseVisualStyleBackColor = true;
            this.btnGotoCart.Click += new System.EventHandler(this.btnGotoCart_Click);
            // 
            // btnRemoveGoods
            // 
            this.btnRemoveGoods.Location = new System.Drawing.Point(201, 358);
            this.btnRemoveGoods.Name = "btnRemoveGoods";
            this.btnRemoveGoods.Size = new System.Drawing.Size(157, 23);
            this.btnRemoveGoods.TabIndex = 6;
            this.btnRemoveGoods.Text = "Remove Goods";
            this.btnRemoveGoods.UseVisualStyleBackColor = true;
            // 
            // btnChangeGoods
            // 
            this.btnChangeGoods.Location = new System.Drawing.Point(364, 358);
            this.btnChangeGoods.Name = "btnChangeGoods";
            this.btnChangeGoods.Size = new System.Drawing.Size(147, 23);
            this.btnChangeGoods.TabIndex = 7;
            this.btnChangeGoods.Text = "Change Goods";
            this.btnChangeGoods.UseVisualStyleBackColor = true;
            this.btnChangeGoods.Click += new System.EventHandler(this.btnChangeGoods_Click);
            // 
            // btnAutorization
            // 
            this.btnAutorization.Location = new System.Drawing.Point(364, 320);
            this.btnAutorization.Name = "btnAutorization";
            this.btnAutorization.Size = new System.Drawing.Size(137, 61);
            this.btnAutorization.TabIndex = 8;
            this.btnAutorization.Text = "Autorization";
            this.btnAutorization.UseVisualStyleBackColor = true;
            this.btnAutorization.Visible = false;
            this.btnAutorization.Click += new System.EventHandler(this.btnAutorization_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 451);
            this.Controls.Add(this.btnAutorization);
            this.Controls.Add(this.btnChangeGoods);
            this.Controls.Add(this.btnRemoveGoods);
            this.Controls.Add(this.btnGotoCart);
            this.Controls.Add(this.btnAddGoods);
            this.Controls.Add(this.btnAddtoCart);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvStore);
            this.Name = "Main";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStore;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddtoCart;
        private System.Windows.Forms.Button btnAddGoods;
        private System.Windows.Forms.Button btnGotoCart;
        private System.Windows.Forms.Button btnRemoveGoods;
        private System.Windows.Forms.Button btnChangeGoods;
        private System.Windows.Forms.Button btnAutorization;
    }
}

