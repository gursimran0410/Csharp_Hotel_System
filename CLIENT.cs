using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Csharp_Hotel_System
{
    class CLIENT
    {
        Connect conn = new Connect();
        public bool insertClient(String fname,String lname,String phone,String country)
        {
            MySqlCommand command = new MySqlCommand();
            String insertQuery = "";
            command.CommandText = insertQuery;
            command.Connection = conn.GetConnection();

            return true;
        }
    }
}
