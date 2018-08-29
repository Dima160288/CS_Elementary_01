using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_thr_task5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIsComplete_Click(object sender, EventArgs e)
        {
            var myDelegate = new Action(Compute);
            
            IAsyncResult asyncResult = myDelegate.BeginInvoke(null, null);
            

            while (!asyncResult.IsCompleted)
            {
                btnIsComplete.BackColor = Color.Yellow;
                Thread.Sleep(100);
            }

            btnIsComplete.BackColor = Color.Green;
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            //Form1 frmMain;
            //frmMain = new Form1();
            var myDelegate = new Action(Compute);
            IAsyncResult asyncResult = myDelegate.BeginInvoke(null, null);

            //frmMain.

            btnEnd.BackColor = Color.Yellow;
            myDelegate.EndInvoke(asyncResult);
            btnEnd.BackColor = Color.Green;
        }

        private void btnCallback_Click(object sender, EventArgs e)
        {
            var myDelegate = new Action(Compute);

            var callback = new AsyncCallback(HandleCompletion);

            IAsyncResult asyncResult = myDelegate.BeginInvoke(callback, "Hello world");
            btnCallback.BackColor = Color.Yellow;
        }

        static void Compute()
        {
            int i = 2;
            while (i < 256)
            {
                i = i * i;
            }
            Thread.Sleep(1000);
        }

        static void HandleCompletion(IAsyncResult asyncResult)
        {

            Form1 form = new Form1();
           
            MessageBox.Show("Callback");
        }

    }




}


