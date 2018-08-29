using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.ComponentModel;
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
using System.Windows.Shapes;

namespace Common
{
    /// <summary>
    /// Логика взаимодействия для WindowRec.xaml
    /// </summary>
    public partial class WindowRec : Window
    {

        public WindowRec()
        {
            InitializeComponent();
        }

        public void FillGrid()
        {
            DB.SetDataGridSourse(ref DGProdsRec, "Select * from Products order by ProdID");

            DGProdsRec.Columns[0].Header = "ProdID";
            DGProdsRec.Columns[1].Header = "ProdName";
            DGProdsRec.Columns[2].Header = "Quty";
            DGProdsRec.Columns[3].Header = "Price";
        }

        private void btn_AddRecProd_Click(object sender, RoutedEventArgs e)
        {
            string ProdID;
            string sql;
            string email = Login.UserID;

            if (DGProdsRec.SelectedItems.Count == 0) return;
            ProdID = ((DataRowView)DGProdsRec.SelectedItems[0]).Row["ProdID"].ToString();

            sql = "select ProdID,ProdName,0 as Qty from Products where ProdID = '" + ProdID + "'";

            //DB.SetDataGridSourse(ref DGRec, sql);

            string[] Data = new string[DB.GetRecordSet(sql).FieldCount];
            string[] DataHeaders = new string[3] { "ProdID", "ProdName", "Qty" };

            SQLiteDataReader sqReader = DB.GetRecordSet(sql);

            while (sqReader.Read())
            {
                for(int i = 0;i< DB.GetRecordSet(sql).FieldCount;i++)
                {
                    Data[i] = sqReader.GetValue(i).ToString();

                    DataGridTextColumn col1 = new DataGridTextColumn();
                    DGRec.Columns.Add(col1);
                    col1.Binding = new Binding(DataHeaders[i]);
                    col1.Header = DataHeaders[i];


                }

            DGRec./*ItemsSource = Data;*/Items.Add(Data);
            }

            

            /*DGRec.Columns[0].Header = "ProdID";
            DGRec.Columns[1].Header = "ProdName";
            DGRec.Columns[2].Header = "Qty";*/

        }

        private void SaveRec_Click(object sender, RoutedEventArgs e)
        {
            string ProdID;
            string Qty;
            string sql;

            ProdID = ((DataRowView)DGRec.SelectedItems[0]).Row["ProdID"].ToString();
            Qty = ((DataRowView)DGRec.SelectedItems[0]).Row["Qty"].ToString();

            sql = "update Products set Qty=Qty+ '" + Qty + "' where Prodid='"+ ProdID + "'";

            DB.GetSingleSet(sql);

        }

        private void ExitRec_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

