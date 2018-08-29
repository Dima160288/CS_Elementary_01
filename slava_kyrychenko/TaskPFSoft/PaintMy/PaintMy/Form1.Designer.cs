namespace PaintMy
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
            this.DrawPanel = new System.Windows.Forms.Panel();
            this.btnCheckColor = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.colorDialogLine = new System.Windows.Forms.ColorDialog();
            this.buttonFillColor = new System.Windows.Forms.Button();
            this.trackBarThickness = new System.Windows.Forms.TrackBar();
            this.panelShape = new System.Windows.Forms.Panel();
            this.radioButtonCircle = new System.Windows.Forms.RadioButton();
            this.radioButtonPencil = new System.Windows.Forms.RadioButton();
            this.radioButtonRectangle = new System.Windows.Forms.RadioButton();
            this.radioButtonLine = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialogFill = new System.Windows.Forms.ColorDialog();
            this.panelThicknessLine = new System.Windows.Forms.Panel();
            this.labelThicknessLine = new System.Windows.Forms.Label();
            this.ProgressBarImageManipulation = new System.Windows.Forms.ProgressBar();
            this.buttonInvert = new System.Windows.Forms.Button();
            this.LabelCurrCoordinate = new System.Windows.Forms.Label();
            this.DrawPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThickness)).BeginInit();
            this.panelShape.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panelThicknessLine.SuspendLayout();
            this.SuspendLayout();
            // 
            // DrawPanel
            // 
            this.DrawPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DrawPanel.AutoScroll = true;
            this.DrawPanel.AutoSize = true;
            this.DrawPanel.BackColor = System.Drawing.Color.White;
            this.DrawPanel.Controls.Add(this.ProgressBarImageManipulation);
            this.DrawPanel.Cursor = System.Windows.Forms.Cursors.Cross;
            this.DrawPanel.Location = new System.Drawing.Point(131, 28);
            this.DrawPanel.Name = "DrawPanel";
            this.DrawPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DrawPanel.Size = new System.Drawing.Size(753, 542);
            this.DrawPanel.TabIndex = 0;
            this.DrawPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawPanel_Paint);
            this.DrawPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawPanel_MouseDown);
            this.DrawPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawPanel_MouseMove);
            this.DrawPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DrawPanel_MouseUp);
            // 
            // btnCheckColor
            // 
            this.btnCheckColor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCheckColor.ForeColor = System.Drawing.Color.White;
            this.btnCheckColor.Location = new System.Drawing.Point(0, 260);
            this.btnCheckColor.Name = "btnCheckColor";
            this.btnCheckColor.Size = new System.Drawing.Size(60, 35);
            this.btnCheckColor.TabIndex = 0;
            this.btnCheckColor.Text = "Choose LineColor";
            this.btnCheckColor.UseVisualStyleBackColor = false;
            this.btnCheckColor.Click += new System.EventHandler(this.btnCheckColor_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(-1, 332);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(125, 25);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // buttonFillColor
            // 
            this.buttonFillColor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonFillColor.ForeColor = System.Drawing.Color.White;
            this.buttonFillColor.Location = new System.Drawing.Point(64, 260);
            this.buttonFillColor.Name = "buttonFillColor";
            this.buttonFillColor.Size = new System.Drawing.Size(60, 35);
            this.buttonFillColor.TabIndex = 0;
            this.buttonFillColor.Text = "Choose FillColor";
            this.buttonFillColor.UseVisualStyleBackColor = false;
            this.buttonFillColor.Click += new System.EventHandler(this.buttonFillColor_Click);
            // 
            // trackBarThickness
            // 
            this.trackBarThickness.Location = new System.Drawing.Point(-1, 203);
            this.trackBarThickness.Minimum = 1;
            this.trackBarThickness.Name = "trackBarThickness";
            this.trackBarThickness.Size = new System.Drawing.Size(126, 45);
            this.trackBarThickness.TabIndex = 0;
            this.trackBarThickness.Value = 1;
            this.trackBarThickness.Scroll += new System.EventHandler(this.trackBarThickness_Scroll);
            // 
            // panelShape
            // 
            this.panelShape.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelShape.Controls.Add(this.radioButtonCircle);
            this.panelShape.Controls.Add(this.radioButtonPencil);
            this.panelShape.Controls.Add(this.radioButtonRectangle);
            this.panelShape.Controls.Add(this.radioButtonLine);
            this.panelShape.Location = new System.Drawing.Point(-1, 58);
            this.panelShape.Name = "panelShape";
            this.panelShape.Size = new System.Drawing.Size(126, 113);
            this.panelShape.TabIndex = 0;
            // 
            // radioButtonCircle
            // 
            this.radioButtonCircle.AutoSize = true;
            this.radioButtonCircle.Location = new System.Drawing.Point(3, 72);
            this.radioButtonCircle.Name = "radioButtonCircle";
            this.radioButtonCircle.Size = new System.Drawing.Size(51, 17);
            this.radioButtonCircle.TabIndex = 3;
            this.radioButtonCircle.Text = "Circle";
            this.radioButtonCircle.UseVisualStyleBackColor = true;
            this.radioButtonCircle.CheckedChanged += new System.EventHandler(this.radioButtonCircle_CheckedChanged);
            // 
            // radioButtonPencil
            // 
            this.radioButtonPencil.AutoSize = true;
            this.radioButtonPencil.Checked = true;
            this.radioButtonPencil.Location = new System.Drawing.Point(3, 3);
            this.radioButtonPencil.Name = "radioButtonPencil";
            this.radioButtonPencil.Size = new System.Drawing.Size(54, 17);
            this.radioButtonPencil.TabIndex = 0;
            this.radioButtonPencil.TabStop = true;
            this.radioButtonPencil.Text = "Pencil";
            this.radioButtonPencil.UseVisualStyleBackColor = true;
            this.radioButtonPencil.CheckedChanged += new System.EventHandler(this.radioButtonPencil_CheckedChanged);
            // 
            // radioButtonRectangle
            // 
            this.radioButtonRectangle.AutoSize = true;
            this.radioButtonRectangle.Location = new System.Drawing.Point(4, 49);
            this.radioButtonRectangle.Name = "radioButtonRectangle";
            this.radioButtonRectangle.Size = new System.Drawing.Size(74, 17);
            this.radioButtonRectangle.TabIndex = 2;
            this.radioButtonRectangle.Text = "Rectangle";
            this.radioButtonRectangle.UseVisualStyleBackColor = true;
            this.radioButtonRectangle.CheckedChanged += new System.EventHandler(this.radioButtonRectangle_CheckedChanged);
            // 
            // radioButtonLine
            // 
            this.radioButtonLine.AutoSize = true;
            this.radioButtonLine.Location = new System.Drawing.Point(4, 26);
            this.radioButtonLine.Name = "radioButtonLine";
            this.radioButtonLine.Size = new System.Drawing.Size(45, 17);
            this.radioButtonLine.TabIndex = 1;
            this.radioButtonLine.Text = "Line";
            this.radioButtonLine.UseVisualStyleBackColor = true;
            this.radioButtonLine.CheckedChanged += new System.EventHandler(this.radioButtonLine_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenu,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenu.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAsToolStripMenuItem.Text = "Save as ..";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.aboutToolStripMenuItem.Text = "About program";
            // 
            // panelThicknessLine
            // 
            this.panelThicknessLine.Controls.Add(this.labelThicknessLine);
            this.panelThicknessLine.Location = new System.Drawing.Point(0, 177);
            this.panelThicknessLine.Name = "panelThicknessLine";
            this.panelThicknessLine.Size = new System.Drawing.Size(125, 20);
            this.panelThicknessLine.TabIndex = 1;
            // 
            // labelThicknessLine
            // 
            this.labelThicknessLine.AutoSize = true;
            this.labelThicknessLine.Location = new System.Drawing.Point(95, 3);
            this.labelThicknessLine.Name = "labelThicknessLine";
            this.labelThicknessLine.Size = new System.Drawing.Size(18, 13);
            this.labelThicknessLine.TabIndex = 0;
            this.labelThicknessLine.Text = "x1";
            this.labelThicknessLine.UseMnemonic = false;
            // 
            // ProgressBarImageManipulation
            // 
            this.ProgressBarImageManipulation.ForeColor = System.Drawing.Color.GreenYellow;
            this.ProgressBarImageManipulation.Location = new System.Drawing.Point(132, 273);
            this.ProgressBarImageManipulation.Name = "ProgressBarImageManipulation";
            this.ProgressBarImageManipulation.Size = new System.Drawing.Size(475, 16);
            this.ProgressBarImageManipulation.TabIndex = 2;
            // 
            // buttonInvert
            // 
            this.buttonInvert.Location = new System.Drawing.Point(0, 301);
            this.buttonInvert.Name = "buttonInvert";
            this.buttonInvert.Size = new System.Drawing.Size(124, 25);
            this.buttonInvert.TabIndex = 0;
            this.buttonInvert.Text = "Invert";
            this.buttonInvert.UseVisualStyleBackColor = true;
            this.buttonInvert.Click += new System.EventHandler(this.buttonInvert_Click);
            // 
            // LabelCurrCoordinate
            // 
            this.LabelCurrCoordinate.AutoSize = true;
            this.LabelCurrCoordinate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabelCurrCoordinate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCurrCoordinate.Location = new System.Drawing.Point(4, 531);
            this.LabelCurrCoordinate.Name = "LabelCurrCoordinate";
            this.LabelCurrCoordinate.Size = new System.Drawing.Size(121, 22);
            this.LabelCurrCoordinate.TabIndex = 2;
            this.LabelCurrCoordinate.Text = "X:          Y:          ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(884, 562);
            this.Controls.Add(this.LabelCurrCoordinate);
            this.Controls.Add(this.buttonInvert);
            this.Controls.Add(this.panelThicknessLine);
            this.Controls.Add(this.panelShape);
            this.Controls.Add(this.trackBarThickness);
            this.Controls.Add(this.buttonFillColor);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCheckColor);
            this.Controls.Add(this.DrawPanel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Paint";
            this.DrawPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThickness)).EndInit();
            this.panelShape.ResumeLayout(false);
            this.panelShape.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelThicknessLine.ResumeLayout(false);
            this.panelThicknessLine.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel DrawPanel;
        private System.Windows.Forms.Button btnCheckColor;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ColorDialog colorDialogLine;
        private System.Windows.Forms.Button buttonFillColor;
        private System.Windows.Forms.TrackBar trackBarThickness;
        private System.Windows.Forms.Panel panelShape;
        private System.Windows.Forms.RadioButton radioButtonCircle;
        private System.Windows.Forms.RadioButton radioButtonPencil;
        private System.Windows.Forms.RadioButton radioButtonRectangle;
        private System.Windows.Forms.RadioButton radioButtonLine;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialogFill;
        private System.Windows.Forms.Panel panelThicknessLine;
        private System.Windows.Forms.Label labelThicknessLine;
        private System.Windows.Forms.ProgressBar ProgressBarImageManipulation;
        private System.Windows.Forms.Button buttonInvert;
        private System.Windows.Forms.Label LabelCurrCoordinate;
    }
}

