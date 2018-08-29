using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD;

namespace Common
{
    class Login
    {
        public static string UserID;
     //   public static string Email;

        static public bool CheckUser(string email, string PW)
        {
            string sql;
            SqlLite sq = new SqlLite();

            

            sql = " select ifnull(UserID,0) as UserID from UsersLogin where email = '" + email + "' and PW = '" + PW + "' ";

            UserID = Convert.ToString(sq.GetSingleSet(sql));

           if (UserID == "")
                return false;
           else
                return true;
                
        }

    }
}
