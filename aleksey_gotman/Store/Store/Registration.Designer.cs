namespace Store
{
    partial class Registration
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
            this.lblReg = new System.Windows.Forms.Label();
            this.btnRegisterReg = new System.Windows.Forms.Button();
            this.lblPasswordReg = new System.Windows.Forms.Label();
            this.txbPasswordReg = new System.Windows.Forms.TextBox();
            this.lblEmailReg = new System.Windows.Forms.Label();
            this.txbEmailReg = new System.Windows.Forms.TextBox();
            this.lblConfPassword = new System.Windows.Forms.Label();
            this.txbConfPassword = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblRegAlert = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblReg
            // 
            this.lblReg.AutoSize = true;
            this.lblReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblReg.Location = new System.Drawing.Point(205, 18);
            this.lblReg.Name = "lblReg";
            this.lblReg.Size = new System.Drawing.Size(95, 20);
            this.lblReg.TabIndex = 13;
            this.lblReg.Text = "Registration";
            // 
            // btnRegisterReg
            // 
            this.btnRegisterReg.Location = new System.Drawing.Point(152, 229);
            this.btnRegisterReg.Name = "btnRegisterReg";
            this.btnRegisterReg.Size = new System.Drawing.Size(105, 31);
            this.btnRegisterReg.TabIndex = 12;
            this.btnRegisterReg.Text = "Register";
            this.btnRegisterReg.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnRegisterReg.UseVisualStyleBackColor = true;
            this.btnRegisterReg.Click += new System.EventHandler(this.btnRegisterReg_Click);
            // 
            // lblPasswordReg
            // 
            this.lblPasswordReg.AutoSize = true;
            this.lblPasswordReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPasswordReg.Location = new System.Drawing.Point(68, 130);
            this.lblPasswordReg.Name = "lblPasswordReg";
            this.lblPasswordReg.Size = new System.Drawing.Size(78, 20);
            this.lblPasswordReg.TabIndex = 10;
            this.lblPasswordReg.Text = "Password";
            // 
            // txbPasswordReg
            // 
            this.txbPasswordReg.Location = new System.Drawing.Point(152, 130);
            this.txbPasswordReg.Name = "txbPasswordReg";
            this.txbPasswordReg.PasswordChar = '*';
            this.txbPasswordReg.Size = new System.Drawing.Size(235, 20);
            this.txbPasswordReg.TabIndex = 9;
            // 
            // lblEmailReg
            // 
            this.lblEmailReg.AutoSize = true;
            this.lblEmailReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEmailReg.Location = new System.Drawing.Point(79, 75);
            this.lblEmailReg.Name = "lblEmailReg";
            this.lblEmailReg.Size = new System.Drawing.Size(53, 20);
            this.lblEmailReg.TabIndex = 8;
            this.lblEmailReg.Text = "E-mail";
            // 
            // txbEmailReg
            // 
            this.txbEmailReg.Location = new System.Drawing.Point(152, 75);
            this.txbEmailReg.Name = "txbEmailReg";
            this.txbEmailReg.Size = new System.Drawing.Size(235, 20);
            this.txbEmailReg.TabIndex = 7;
            // 
            // lblConfPassword
            // 
            this.lblConfPassword.AutoSize = true;
            this.lblConfPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblConfPassword.Location = new System.Drawing.Point(12, 179);
            this.lblConfPassword.Name = "lblConfPassword";
            this.lblConfPassword.Size = new System.Drawing.Size(137, 20);
            this.lblConfPassword.TabIndex = 15;
            this.lblConfPassword.Text = "Confirm Password";
            // 
            // txbConfPassword
            // 
            this.txbConfPassword.Location = new System.Drawing.Point(152, 179);
            this.txbConfPassword.Name = "txbConfPassword";
            this.txbConfPassword.PasswordChar = '*';
            this.txbConfPassword.Size = new System.Drawing.Size(235, 20);
            this.txbConfPassword.TabIndex = 14;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(282, 229);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(105, 31);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "To Log In";
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblRegAlert
            // 
            this.lblRegAlert.AutoSize = true;
            this.lblRegAlert.Location = new System.Drawing.Point(149, 202);
            this.lblRegAlert.Name = "lblRegAlert";
            this.lblRegAlert.Size = new System.Drawing.Size(0, 13);
            this.lblRegAlert.TabIndex = 17;
            this.lblRegAlert.Visible = false;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 290);
            this.Controls.Add(this.lblRegAlert);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblConfPassword);
            this.Controls.Add(this.txbConfPassword);
            this.Controls.Add(this.lblReg);
            this.Controls.Add(this.btnRegisterReg);
            this.Controls.Add(this.lblPasswordReg);
            this.Controls.Add(this.txbPasswordReg);
            this.Controls.Add(this.lblEmailReg);
            this.Controls.Add(this.txbEmailReg);
            this.Name = "Registration";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReg;
        private System.Windows.Forms.Button btnRegisterReg;
        private System.Windows.Forms.Label lblPasswordReg;
        private System.Windows.Forms.TextBox txbPasswordReg;
        private System.Windows.Forms.Label lblEmailReg;
        private System.Windows.Forms.TextBox txbEmailReg;
        private System.Windows.Forms.Label lblConfPassword;
        private System.Windows.Forms.TextBox txbConfPassword;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblRegAlert;
    }
}