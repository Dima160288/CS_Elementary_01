﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlockingGUIFlow
{
    public class MyForm : Form
    {
        private readonly Label label;
        private readonly Button button;

        public MyForm()
        {
            label = new Label { Size = new Size(ClientSize.Width, 30) };
            button = new Button
            {
                Location = new Point(0, label.Bottom),
                Text = "Start",
                Size = label.Size
            };
            button.Click += MakeWork;
            Controls.Add(label);
            Controls.Add(button);
        }

        void MakeWork(object sender, EventArgs e)
        {
            button.Enabled = false;
            Thread.Sleep(5000);
            label.Text = "Complete";
            button.Enabled = true;
        }

        public static void Main()
        {
            Application.Run(new MyForm());
        }
    }
}
