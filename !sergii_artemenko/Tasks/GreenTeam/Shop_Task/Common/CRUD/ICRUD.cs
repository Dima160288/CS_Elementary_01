using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    interface ICRUD
    {
        bool SetConnection(string ConnString);
        void CloseConnection();
        void Create(string TableName, string Values, string Insfields = "");
        void Read(string TableName, string fields = "", string sqlWhere = "");
        void Update(string TableName, string Setfields = "", string sqlWhere = "");
        void Delete(string TableName, string sqlWhere = "");
    }
}
