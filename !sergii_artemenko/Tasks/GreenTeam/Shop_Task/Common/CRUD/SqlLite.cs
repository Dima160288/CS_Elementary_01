using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data;
using System.Windows.Controls;
using System.Data.SQLite;

namespace CRUD
{

    public class SqlLite : ICRUD
    {

        private static SQLiteConnection con;  // Используем private static с целью сохранения коннекта на всё время работы программы, но при этом скрываем от вмешательства из вне класса.
        private string sql;

		/// <summary>
        /// Устанавливает подключение к базе на время работы приложения
        /// </summary>
        /// <param name="ConnString">Строка подключения\путь к бд.</param>
        public bool SetConnection(string ConnString)
        {

            if (con == null)
            {
                con = new SQLiteConnection(ConnString);
                try
                {
                    con.Open();
                    return true;
                }
                catch (Exception err)
                {
                    return false;
                }

            }
            else
                return true;
        }

		/// <summary>
        /// Закрывает подключение к БД
        /// </summary>
        public void CloseConnection()
        {

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

		/// <summary>
        /// INSERT данных в базу.
        /// </summary>
        /// <param name="TableName">Название обновляемой таблицы</param>
		/// <param name="Values">Перечень значений для вставки </param>
		/// <param name="Insfields">Перечень полей для вставки, необязателен</param>
        public void Create(string TableName, string Values, string Insfields = "")
        {
            sql = "INSERT INTO " + TableName;
            if (Insfields != "") sql = sql + "(" + Insfields + ")";

            sql = sql + " select " + Values;

            ExecuteSql(sql);
        }

		/// <summary>
        /// Select данных из базы.
        /// </summary>
        /// <param name="TableName">Название таблицы</param>
		/// <param name="fields">Перечень полей </param>
		/// <param name="sqlWhere"> Условие запроса, Where писать не нужно</param>
        public void Read(string TableName, string fields = "", string sqlWhere = "")
        {
            sql = "Select ";
            if (fields != "") sql = sql + "(" + fields + ")";
            else sql = sql + " * ";

            sql = sql + " FROM " + TableName;

            if (sqlWhere != "") sql = sql + " WHERE " + sqlWhere;

            ExecuteSql(sql);
        }

		/// <summary>
        /// Update данных в базе.
        /// </summary>
        /// <param name="TableName">Название таблицы</param>
		/// <param name="Setfields"> Условие для SET, строка вида Field = Value, Field = Value </param>
		/// <param name="sqlWhere"> Условие апдейта, Where писать не нужно</param>
        public void Update(string TableName, string Setfields, string sqlWhere = "")
        {
            sql = "UPDATE ";
            sql = sql + " SET  " + Setfields;
            if (sqlWhere != "") sql = sql + " WHERE " + sqlWhere;

            ExecuteSql(sql);
        }

		
		/// <summary>
        /// Update данных в базе.
        /// </summary>
        /// <param name="TableName">Название таблицы</param>
		/// <param name="sqlWhere"> Условие удаления, where не требуется</param>
        public void Delete(string TableName, string sqlWhere = "")
        {
            sql = "DELETE FROM " + TableName + " WHERE 1=1 ";
            if (sqlWhere != "") sql = sql + " and " + sqlWhere;

            ExecuteSql(sql);
        }

        /// <summary>
        /// Выполняет полученную sql строку, значения не возвращает
        /// </summary>
        public void ExecuteSql(string sql)
        {
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            
			try
                {
					cmd.ExecuteNonQuery();
                }
                catch (Exception err)
                {
                   MessageBox.Show("Ошибка обращения к базе данных! ");  //+ err.ToString()
            }
				
        }

        /// <summary>
        ///  возвращается набор данных(SQLiteDataReader) полученный из запроса
        /// </summary>
        public SQLiteDataReader GetRecordSet(string sql)
        {
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            SQLiteDataReader reader = null;

            return reader = cmd.ExecuteReader();  // можно подумать что бы возвращать не объект SQLiteDataReader а набраный из него список. Что бы не подклю
        }

		/// <summary>
        /// возвращает одну строку(первую), для коротких проверок
        /// </summary>
        public Object GetSingleSet(string sql)
        {
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            return cmd.ExecuteScalar();
        }

		/// <summary>
        /// Заполняет полученую гриду из SQLLite согласно запроса
        /// </summary>
        /// <param name="DGridName">Ссылка на DataGrid</param>
		/// <param name="sql">Запрос селекта</param>
        public void SetDataGridSourse(ref DataGrid DGridName, string sql)
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
