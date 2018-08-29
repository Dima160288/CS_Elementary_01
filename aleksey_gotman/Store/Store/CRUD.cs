using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Store
{
    class CRUD
    {
        static void DBConnect()
        {
            string cs = "URI=file:test.db";

            using (SQLiteConnection con = new SQLiteConnection(cs))
            {
                con.Open();

                

                con.Close();
            }
        }
        static List<string> DBDownload(string stm, SQLiteConnection con)
        {
            List<string> output = new List<string>();
            
            using (SQLiteCommand cmd = new SQLiteCommand(stm, con))
            {
                using (SQLiteDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        int i = 0;
                        //output.Add(rdr.GetString());
                        i++;
                    }
                }
            }
            return output;
        }

    }
}
