using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLite_demo
{
    public partial class UpdateProduct : Form
    {
        DisplayStore store = new DisplayStore();
        public UpdateProduct(ListViewItem item)
        {
                InitializeComponent();
                textID.Text = item.SubItems[0].Text;
                textCategory.Text = item.SubItems[1].Text;
                textName.Text = item.SubItems[2].Text;
                textDescription.Text = item.SubItems[3].Text;
                textPrice.Text = item.SubItems[4].Text;
                textRating.Text = item.SubItems[5].Text;
                textQuantity.Text = item.SubItems[6].Text;         
        }

        private void ButtonCommitUpdate_Click(object sender, EventArgs e)
        {
            store.Update(Convert.ToInt32(textID.Text), textCategory.Text, textName.Text, textDescription.Text, Convert.ToDouble(textPrice.Text),
                Convert.ToDouble(textRating.Text), Convert.ToInt32(textQuantity.Text));
        }

        private void UpdateProduct_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void UpdateProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
