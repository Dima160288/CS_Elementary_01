using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CRUD;

namespace Common
{
    /// <summary>
    /// Логика взаимодействия для OrderStorage.xaml
    /// </summary>
    public partial class OrderStorage : Window
    {

        string orderUser = Login.UserID;


        public OrderStorage()
        {
            InitializeComponent();
        }

       



        public void FillGrid()
        {
            
            SqlLite sq = new SqlLite();
            sq.SetDataGridSourse(ref Dg1, "Select t1.orderid,t2.prodid,t2.qty from orders t1 join ordersD  t2 on t1.orderid=t2.orderid where t1.userid = '" + orderUser + "' and orderstate = 1 and t1.orderid in (select max(orderid) from orders where userid = '" + orderUser + "' and orderstate = 1) ");

            // если не указать имя - возьмет с sql, никаких варнингов.
         
        }


        private void btnChangeQty_Click(object sender, RoutedEventArgs e)
        {
        
            string sql;
            string prodid;
            string orderid;
            string qty;

            SqlLite sq = new SqlLite();

            if (Dg1.SelectedItems.Count == 0) return;
            prodid = ((DataRowView)Dg1.SelectedItems[0]).Row["ProdID"].ToString();
            orderid = ((DataRowView)Dg1.SelectedItems[0]).Row["OrderId"].ToString();
            qty = ((DataRowView)Dg1.SelectedItems[0]).Row["qty"].ToString();
            //clientID = (int)((DataRowView)DG.SelectedItems[0]).Row["ID"];

            sql = "update ordersd set qty = " + qty + " where prodid = " + prodid + " and orderid = " + orderid + " ";
            sq.GetSingleSet(sql);

        }

        private void btnCompleteOrder_Click(object sender, RoutedEventArgs e)
        {

            string sql;
            string orderid;
            SqlLite sq = new SqlLite();

            if (Dg1.SelectedItems.Count == 0) return;
        
            orderid = ((DataRowView)Dg1.SelectedItems[0]).Row["OrderId"].ToString();
          

            sql = "update orders set orderstate = 2 where orderid = " + orderid + "";
            sq.GetSingleSet(sql);

        }

    }





}
