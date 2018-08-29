using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.Remoting.Messaging;

namespace ThreeButtons
{
    public partial class Form1 : Form
    {
        private delegate int MyDelegate(int num1, int num2);

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyDelegate add = new MyDelegate(Add);
            IAsyncResult addResult = add.BeginInvoke(5, 10, null, null);
            int result = add.EndInvoke(addResult);
            MessageBox.Show("5 + 10 = " + result);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyDelegate add = new MyDelegate(Add);
            IAsyncResult addResult = add.BeginInvoke(1, 6, null, null);
            if (addResult.IsCompleted)
            {
                int result = add.EndInvoke(addResult);
                MessageBox.Show("1 + 6 = " + result);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MyDelegate add = new MyDelegate(Add);
            AsyncCallback callback = new AsyncCallback(AddCompletion);
            IAsyncResult addResult = add.BeginInvoke(8, 9, callback, null);
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static void AddCompletion(IAsyncResult result)
        {
            var asyncResult = result as AsyncResult;
            var caller = (MyDelegate)asyncResult.AsyncDelegate;
            int sum = caller.EndInvoke(result);
            MessageBox.Show("8 + 9 = " + sum); 
        }
    }
}
