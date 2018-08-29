namespace HW_thr_task5
{
    partial class Form1
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
            this.btnIsComplete = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnCallback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIsComplete
            // 
            this.btnIsComplete.Location = new System.Drawing.Point(341, 91);
            this.btnIsComplete.Name = "btnIsComplete";
            this.btnIsComplete.Size = new System.Drawing.Size(75, 23);
            this.btnIsComplete.TabIndex = 0;
            this.btnIsComplete.Text = "IsComplete";
            this.btnIsComplete.UseVisualStyleBackColor = true;
            this.btnIsComplete.Click += new System.EventHandler(this.btnIsComplete_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(174, 91);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(75, 23);
            this.btnEnd.TabIndex = 1;
            this.btnEnd.Text = "End";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnCallback
            // 
            this.btnCallback.Location = new System.Drawing.Point(497, 91);
            this.btnCallback.Name = "btnCallback";
            this.btnCallback.Size = new System.Drawing.Size(75, 23);
            this.btnCallback.TabIndex = 2;
            this.btnCallback.Text = "Callback";
            this.btnCallback.UseVisualStyleBackColor = true;
            this.btnCallback.Click += new System.EventHandler(this.btnCallback_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCallback);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnIsComplete);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIsComplete;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnCallback;
    }
}

