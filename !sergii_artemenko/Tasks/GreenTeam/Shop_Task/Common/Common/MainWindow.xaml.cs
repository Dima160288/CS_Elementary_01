﻿using System;
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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool check;

        public MainWindow()
        {
            InitializeComponent();
            //Button_Click();
            
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            
            SqlLite sq = new SqlLite();
            sq.CloseConnection();
            this.Close();
        }

        public void FillGrid()
        {
            SqlLite sq = new SqlLite();

            sq.SetDataGridSourse(ref DG, "Select * from Products order by ProdID");

            // если не указать имя - возьмет с sql, никаких варнингов.
            DG.Columns[0].Header = "ProdID";
            DG.Columns[1].Header = "ProdName";
            DG.Columns[2].Header = "Quantity";
            DG.Columns[3].Header = "price";
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            string ProdID;
            string sql;
            string UserID = Login.UserID;

            SqlLite sq = new SqlLite();

            if (DG.SelectedItems.Count == 0) return;
            ProdID = ((DataRowView)DG.SelectedItems[0]).Row["ProdID"].ToString();
            //clientID = (int)((DataRowView)DG.SelectedItems[0]).Row["ID"];

            sql = "select OrderState from Orders where UserID = '" + UserID + "' and OrderState = 1";

            if (Convert.ToInt16(sq.GetSingleSet(sql)) == 1)
                check = true;
            else
                check = false;

            if (check == false)
            {
                sql = " Insert Into Orders(OrderID, OrderDate, UserID, OrderState) Select (Select IFNull(Max(OrderID)+1,1) From Orders) OrderID, DATETIME() OrderDate, '" + UserID + "' UserID, 1 OrderState";
                sq.GetSingleSet(sql);
                check = true;
            }

            sql = "Insert Into OrdersD(OrderID, SrcPosID, ProdID, qty) SELECT (SELECT MAX(OrderID) FROM Orders WHERE UserID = '" + UserID + "' AND OrderState = 1) OrderID, (SELECT IFNull(MAX(SrcPosID)+1,1) FROM OrdersD WHERE OrderID = (SELECT MAX(OrderID) FROM Orders WHERE UserID = '" + UserID + "' AND OrderState = 1)) SrcPosID, " + ProdID + " ProdID, 1 qty";
            sq.GetSingleSet(sql);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OrderStorage MW = new OrderStorage();

            MW.Show();
            MW.FillGrid();
            this.Close();
        }

        private void btnAddRec_Click(object sender, RoutedEventArgs e)
        {
            WindowRec Rec = new WindowRec();
            Rec.Show();
            Rec.FillGrid();
        }
    }
}
