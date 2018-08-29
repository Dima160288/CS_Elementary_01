using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace SQLite_demo
{
    public class GetProduct
    {
       public List<Product> listProduct = new List<Product>(); //Создаем лист для работы
        DbConnect connect = new DbConnect();
        SQLiteDataReader dataReader;

        public List<Product> RetrieveProduct()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connect.connectionString))
            {
                try
                {
                    connection.Open();
                    SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM product", connection);
                    dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        listProduct.Add(new Product(  //добавление данных из БД в приложение                       
                                                  //Category, Name, Description, Price, Rating, Quantity
                            dataReader.GetInt32(dataReader.GetOrdinal("ID")),
                            dataReader.GetString(dataReader.GetOrdinal("category")),
                            dataReader.GetString(dataReader.GetOrdinal("name")),
                            dataReader.GetString(dataReader.GetOrdinal("description")),
                            dataReader.GetDouble(dataReader.GetOrdinal("price")),
                            dataReader.GetDouble(dataReader.GetOrdinal("rating")),
                            dataReader.GetInt32(dataReader.GetOrdinal("quantity"))));
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    throw;
                }
            }
            return listProduct;
        }



        //public void View(List<Product> list)
        //{
        //    foreach (Product dr in list)   //Заполнение таблицы ListView
        //    {
        //        ListViewItem item = new ListViewItem(dr.ID.ToString());
        //        //item.SubItems.Add(dr.ID.ToString());
        //        item.SubItems.Add(dr.Name.ToString());
        //        item.SubItems.Add(dr.Category.ToString());
        //        item.SubItems.Add(dr.Description.ToString());
        //        item.SubItems.Add(dr.Price.ToString());
        //        item.SubItems.Add(dr.Rating.ToString());
        //        item.SubItems.Add(dr.Quantity.ToString());
        //       // ViewStore.Items.Add(item);
        //    }
        //}
        

    }

}
