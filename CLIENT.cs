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
            String insertQuery = "INSERT INTO `clients`(`first_name`, `last_name`, `phone`, `country`) VALUES (@fnm,@lnm,@phn,@cnt)";
            command.CommandText = insertQuery;
            command.Connection = conn.GetConnection();

            command.Parameters.Add("@fnm", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lnm", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@cnt", MySqlDbType.VarChar).Value = country;

            conn.openconnection();

            if(command.ExecuteNonQuery() == 1)
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
        //Function to get clients list
        public DataTable getclients()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `clients`",conn.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }
        //function to edit clients list
        public bool EditClient(int id, String fname, String lname, String phone, String country)
        {
            MySqlCommand command = new MySqlCommand();
            String EditQuery = "UPDATE `clients` SET `first_name`= @fnm,`last_name`= @lnm,`phone`= @phn,`country`= @cnt WHERE `id`= @cid";
            command.CommandText = EditQuery;
            command.Connection = conn.GetConnection();

            command.Parameters.Add("@cid", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@fnm", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lnm", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@cnt", MySqlDbType.VarChar).Value = country;

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
        //function to remove clients data
        public bool removeClient(int id)
        {
            MySqlCommand command = new MySqlCommand();
            String removeQuery = "DELETE FROM `clients` WHERE `id` = @cid";
            command.CommandText = removeQuery;
            command.Connection = conn.GetConnection();

            command.Parameters.Add("@cid", MySqlDbType.Int32).Value = id;

            conn.openconnection();

            if(command.ExecuteNonQuery() == 1)
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
