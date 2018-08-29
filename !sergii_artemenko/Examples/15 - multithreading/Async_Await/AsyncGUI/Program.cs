using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncGUI
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

        void MakeWorkInThread()
        {
            Thread.Sleep(5000);
            //label.Text = "Complete"; // Операции с контролами можно совершать только из GUI-потока
            BeginInvoke(new Action(() => label.Text = "Complete")); // ← это можно делать так

        }

        void MakeWork(object sender, EventArgs e)
        {
            new Action(MakeWorkInThread).BeginInvoke(null, null);
            // Не нужно путать BeginInvoke у делегата (асинхронный запуск операции в другом потоке)
            // и у формы (асинхронный запуск операции в GUI-потоке этой формы)
        }


        public static void Main()
        {
            Application.Run(new MyForm());
        }

    }
}
