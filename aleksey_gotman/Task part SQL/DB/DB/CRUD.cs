using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace DB
{
    public static class CRUD
    {
        static string ConPath = "Store.db";
        static SQLiteConnection con;
        public static SQLiteConnection Con { get { return con; } } //Вспомагательная строка для тестов

        /// <summary>
        /// Открытие соединения с БД
        /// Вызывать при открытии программы. Вызов и дальнейшую работу делать в try catch
        /// </summary>
        public static void ConnectionOpen()
        {
            con = new SQLiteConnection(@"Data Source=" + ConPath);
            con.Open();
        }

        /// <summary>
        /// Закрытие соединения с БД
        /// Вызывать при ВСЕХ вариантах завершения программы
        /// </summary>
        public static void Close()
        {
            con.Close();
        }

        /// <summary>
        /// Авторизация
        /// Автоматически записывает данные в клас юзера
        /// </summary>
        /// <param email="email"></param>
        /// <param password="pass"></param>
        /// <returns></returns>
        public static bool Login(string email, string pass)
        {
            SQLiteCommand com = new SQLiteCommand(@"SELECT IdUser FROM Users WHERE Email LIKE '" + email + "' AND Pass LIKE '" + pass + "'", con);
            var id = com.ExecuteScalar();
            int i = 0;
            i = Convert.ToInt32(id);
            if (i == 0)
                return false;
            com = new SQLiteCommand(@"SELECT IsAdmin FROM Users WHERE IdUser LIKE '" + i + "'", con);
            var status = com.ExecuteScalar();
            int s = Convert.ToInt32(status);
            //TODO: передать данные о пользователе в класc User
            return true;
        }

        /// <summary>
        /// Проверка на наличие Email в базе
        /// Возвращает bool есть ли такая запись в базе
        /// </summary>
        /// <param email="email"></param>
        /// <returns></returns>
        public static bool AreRegisterd(string email)
        {
            SQLiteCommand com = new SQLiteCommand(@"SELECT COUNT (*) FROM Users WHERE Email LIKE '" + email + "'", con);
            var count = com.ExecuteScalar();
            int c = Convert.ToInt32(count);
            if (c == 0)
                return false;
            else
                return true;
        }

        /// <summary>
        /// Запись в БД нового пользователя
        /// </summary>
        /// <param email="email"></param>
        /// <param password="pass"></param>
        public static void Registration(string email, string pass)
        {
            SQLiteCommand com = new SQLiteCommand(@"INSERT INTO 'Users' ('Email', 'Pass', 'IsAdmin') VALUES ('" + email + "', '" + pass + "', 1);", con);
            com.ExecuteNonQuery();
        }

        /// <summary>
        /// Загрузка всех товаров из БД
        /// Можно использовать для обновления данных из БД
        /// </summary>
        public static void GetProductsData()
        {
            ProductList.list = new List<Product>();
            SQLiteCommand com = new SQLiteCommand(@"SELECT * FROM Products", con);
            SQLiteDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                ProductList.list.Add(new Product(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetValue(3), reader.GetInt32(4), reader.GetInt32(5), reader.GetInt32(6)));
            }
        }

        /// <summary>
        /// Добавление продукта в БД
        /// После добавления НЕОБХОДИМО обновить данные из БД и обновить вьюшку
        /// </summary>
        /// <param productName="name"></param>
        /// <param category="category"></param>
        /// <param price="price"></param>
        /// <param rate="rate"></param>
        /// <param count="count"></param>
        /// <param description="description"></param>
        public static void AddProductToDb(string name, string category, double price, double rate, int count, string description = "")
        {
            int priceI = (int)(price * 100);
            int rateI = (int)(rate * 100);
            SQLiteCommand com = new SQLiteCommand(@"INSERT INTO 'Products' ('Name', 'Category', 'Description', 'Count', 'Price', 'Rate') VALUES ('" + name + "', '" + category + "', '" + description + "', '" + count + "', '" + priceI + "', '" + rateI + "');", con);
            com.ExecuteNonQuery();
        }

        /// <summary>
        /// Удаление товара из базы по его Id
        /// </summary>
        /// <param idProduct="id"></param>
        public static void DeleteProductFromDb(int id)
        {
            SQLiteCommand com = new SQLiteCommand(@"DELETE FROM Products WHERE IdProduct LIKE '" + id + "'", con);
            com.ExecuteNonQuery();
        }

        /// <summary>
        /// Изменение кол-ва на складе
        /// </summary>
        /// <param Массив id="id"></param>
        /// <param Новые данные кол-ва="data"></param>
        public static void ChangeCount(int[] id, int[] data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                SQLiteCommand com = new SQLiteCommand(@"UPDATE Products SET Count = '" + data[i] + "' WHERE IdProduct LIKE '" + id[i] + "'", con);
                com.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Изменение всех данных продукта
        /// если данные в ячейке менять не нужно в передаваемом обьекте заполнить из прошлого
        /// </summary>
        /// <param Массив продуктов="p"></param>
        public static void ChangeProducts(Product[] p)
        {
            int priceI;
            int rateI;
            for (int i = 0; i < p.Length; i++)
            {
                priceI = (int)(p[i].Price * 100);
                rateI = (int)(p[i].Rate * 100);
                SQLiteCommand com = new SQLiteCommand(@"UPDATE Products SET Name = '" + p[i].Name + "', Category = '" + p[i].Category + "', Description = '" + p[i].Description + "', Prise = '" + priceI + "', Rate = '" + rateI + "', Count = '" + p[i].Count + "'  WHERE IdProduct LIKE '" + p[i].Id + "'", con);
                com.ExecuteNonQuery();
            }

        }
    }
}
