namespace Store
{
    partial class frmRegistration
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
            this.lblConfPassword = new System.Windows.Forms.Label();
            this.txbConfPassword = new System.Windows.Forms.TextBox();
            this.lblPasswordReg = new System.Windows.Forms.Label();
            this.txbPasswordReg = new System.Windows.Forms.TextBox();
            this.lblEmailReg = new System.Windows.Forms.Label();
            this.txbEmailReg = new System.Windows.Forms.TextBox();
            this.lblRegAlert = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRegisterReg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblReg
            // 
            this.lblReg.AutoSize = true;
            this.lblReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblReg.Location = new System.Drawing.Point(210, 9);
            this.lblReg.Name = "lblReg";
            this.lblReg.Size = new System.Drawing.Size(95, 20);
            this.lblReg.TabIndex = 14;
            this.lblReg.Text = "Registration";
            // 
            // lblConfPassword
            // 
            this.lblConfPassword.AutoSize = true;
            this.lblConfPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblConfPassword.Location = new System.Drawing.Point(12, 120);
            this.lblConfPassword.Name = "lblConfPassword";
            this.lblConfPassword.Size = new System.Drawing.Size(121, 17);
            this.lblConfPassword.TabIndex = 21;
            this.lblConfPassword.Text = "Confirm Password";
            // 
            // txbConfPassword
            // 
            this.txbConfPassword.Location = new System.Drawing.Point(140, 120);
            this.txbConfPassword.Name = "txbConfPassword";
            this.txbConfPassword.PasswordChar = '*';
            this.txbConfPassword.Size = new System.Drawing.Size(235, 20);
            this.txbConfPassword.TabIndex = 20;
            // 
            // lblPasswordReg
            // 
            this.lblPasswordReg.AutoSize = true;
            this.lblPasswordReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPasswordReg.Location = new System.Drawing.Point(35, 81);
            this.lblPasswordReg.Name = "lblPasswordReg";
            this.lblPasswordReg.Size = new System.Drawing.Size(69, 17);
            this.lblPasswordReg.TabIndex = 19;
            this.lblPasswordReg.Text = "Password";
            // 
            // txbPasswordReg
            // 
            this.txbPasswordReg.Location = new System.Drawing.Point(140, 80);
            this.txbPasswordReg.Name = "txbPasswordReg";
            this.txbPasswordReg.PasswordChar = '*';
            this.txbPasswordReg.Size = new System.Drawing.Size(235, 20);
            this.txbPasswordReg.TabIndex = 18;
            // 
            // lblEmailReg
            // 
            this.lblEmailReg.AutoSize = true;
            this.lblEmailReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEmailReg.Location = new System.Drawing.Point(46, 41);
            this.lblEmailReg.Name = "lblEmailReg";
            this.lblEmailReg.Size = new System.Drawing.Size(47, 17);
            this.lblEmailReg.TabIndex = 17;
            this.lblEmailReg.Text = "E-mail";
            // 
            // txbEmailReg
            // 
            this.txbEmailReg.Location = new System.Drawing.Point(140, 40);
            this.txbEmailReg.Name = "txbEmailReg";
            this.txbEmailReg.Size = new System.Drawing.Size(235, 20);
            this.txbEmailReg.TabIndex = 16;
            // 
            // lblRegAlert
            // 
            this.lblRegAlert.AutoSize = true;
            this.lblRegAlert.Location = new System.Drawing.Point(137, 155);
            this.lblRegAlert.Name = "lblRegAlert";
            this.lblRegAlert.Size = new System.Drawing.Size(0, 13);
            this.lblRegAlert.TabIndex = 24;
            this.lblRegAlert.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(270, 180);
            this.btnBack.MaximumSize = new System.Drawing.Size(105, 30);
            this.btnBack.MinimumSize = new System.Drawing.Size(105, 30);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(105, 30);
            this.btnBack.TabIndex = 23;
            this.btnBack.Text = "To Log In";
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnRegisterReg
            // 
            this.btnRegisterReg.Location = new System.Drawing.Point(140, 180);
            this.btnRegisterReg.Name = "btnRegisterReg";
            this.btnRegisterReg.Size = new System.Drawing.Size(105, 30);
            this.btnRegisterReg.TabIndex = 22;
            this.btnRegisterReg.Text = "Register";
            this.btnRegisterReg.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnRegisterReg.UseVisualStyleBackColor = true;
            this.btnRegisterReg.Click += new System.EventHandler(this.btnRegisterReg_Click);
            // 
            // frmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 231);
            this.Controls.Add(this.lblRegAlert);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRegisterReg);
            this.Controls.Add(this.lblConfPassword);
            this.Controls.Add(this.txbConfPassword);
            this.Controls.Add(this.lblPasswordReg);
            this.Controls.Add(this.txbPasswordReg);
            this.Controls.Add(this.lblEmailReg);
            this.Controls.Add(this.txbEmailReg);
            this.Controls.Add(this.lblReg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReg;
        private System.Windows.Forms.Label lblConfPassword;
        private System.Windows.Forms.TextBox txbConfPassword;
        private System.Windows.Forms.Label lblPasswordReg;
        private System.Windows.Forms.TextBox txbPasswordReg;
        private System.Windows.Forms.Label lblEmailReg;
        private System.Windows.Forms.TextBox txbEmailReg;
        private System.Windows.Forms.Label lblRegAlert;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnRegisterReg;
    }
}