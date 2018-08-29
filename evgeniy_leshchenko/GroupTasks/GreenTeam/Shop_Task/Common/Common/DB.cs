using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows;
using System.Data;
using System.Windows.Controls;

namespace Common
{
    static class DB 
    {
        public static SQLiteConnection con;

        public static void SetConn()
        {

            if (con == null)
            {
                con = new SQLiteConnection("Data Source=../../ShopDB.db");
                try
                {
                    con.Open();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.ToString());
                }
            }
        }

        public static void CloseConn()
        {

            if (con.State == ConnectionState.Open)
            {
                try
                {
                    con.Close();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.ToString());
                }

            }
        }

        // выполнение запроса, без возврата значения.
        public static void ExecuteSql(string sql)
        {

            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            cmd.ExecuteNonQuery();
        }

        // возвращается набор данных полученный из запроса.
        public static SQLiteDataReader GetRecordSet(string sql)
        {
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            SQLiteDataReader reader = null;

            return reader = cmd.ExecuteReader();
        }

        // возвращает одну строку(первую)
        public static Object GetSingleSet(string sql)
        {
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            return cmd.ExecuteScalar();
        }

        //Заполняет гриду из SQLLite согласно запроса
        public static void SetDataGridSourse( ref DataGrid DGridName, string sql)
        {
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            cmd.ExecuteNonQuery();

            SQLiteDataAdapter mAdapter = new SQLiteDataAdapter(cmd);
            DataTable LocalTable = new DataTable("LocalTable"); // Создаем таблицу в которую помещаем результат запроса
            mAdapter.Fill(LocalTable);
          
            DGridName.ItemsSource = LocalTable.DefaultView; // Эта таблица будет источником данных для DG. Через адаптер можно также обновлять данные по гриде, если в основе одна таблица. Если несколько, нужно будет руками писать обновление.
           // mAdapter.Update(mTable);
            
        }

    }
}
