using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Csharp_Hotel_System
{
    class ROOM
    {
        Connect conn = new Connect();
        public DataTable roomTypeList()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `rooms_category`",conn.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }
        public bool addroom(int number, int type, String phone, String free)
        {
            MySqlCommand command = new MySqlCommand();
            String insertQuery = "INSERT INTO `rooms`(`Number`, `Type`, `phone`, `free`) VALUES (@num,@tp,@phn,@fr)";
            command.CommandText = insertQuery;
            command.Connection = conn.GetConnection();

            command.Parameters.Add("@num", MySqlDbType.VarChar).Value = number;
            command.Parameters.Add("@tp", MySqlDbType.VarChar).Value = type;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@fr", MySqlDbType.VarChar).Value = free;

            conn.openconnection();

            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeconnection();
                return true;
            }
            else
            {
                conn.closeconnection();
                return false;
            }
        }
        public DataTable getroom()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `rooms`", conn.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }
        public bool EditRoom(int number, int type, String phone, String free)
        {
            MySqlCommand command = new MySqlCommand();
            String EditQuery = "UPDATE `rooms` SET `Type`=@tp,`phone`=@phn,`free`=@fr WHERE `Number`=@num";
            command.CommandText = EditQuery;
            command.Connection = conn.GetConnection();

            command.Parameters.Add("@num", MySqlDbType.VarChar).Value = number;
            command.Parameters.Add("@tp", MySqlDbType.VarChar).Value = type;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@fr", MySqlDbType.VarChar).Value = free;        

            conn.openconnection();

            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeconnection();
                return true;
            }
            else
            {
                conn.closeconnection();
                return false;
            }
        }
        public bool removeRoom(int number)
        {
            MySqlCommand command = new MySqlCommand();
            String removeQuery = "DELETE FROM `rooms` WHERE `Number` = @num";
            command.CommandText = removeQuery;
            command.Connection = conn.GetConnection();

            command.Parameters.Add("@num", MySqlDbType.Int32).Value = number;

            conn.openconnection();

            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeconnection();
                return true;
            }
            else
            {
                conn.closeconnection();
                return false;
            }
        }
    }
}
