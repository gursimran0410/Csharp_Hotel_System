using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Csharp_Hotel_System
{
    class RESERVATION
    {
        Connect conn = new Connect();
        //function to get all reservations
        public DataTable getAllReserv()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `reservations`", conn.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }
        public bool addreserv(int number, int ClientID, DateTime dateIN, DateTime dateOUT)
        {
            MySqlCommand command = new MySqlCommand();
            String insertQuery = "INSERT INTO `reservations`(`roomNumber`, `ClientID`, `DateIN`, `DateOUT`) VALUES (@rn,@ci,@di,@do)";
            command.CommandText = insertQuery;
            command.Connection = conn.GetConnection();

            command.Parameters.Add("@rn", MySqlDbType.VarChar).Value = number;
            command.Parameters.Add("@ci", MySqlDbType.VarChar).Value = ClientID;
            command.Parameters.Add("@di", MySqlDbType.VarChar).Value = dateIN;
            command.Parameters.Add("@do", MySqlDbType.VarChar).Value = dateOUT;

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
        public bool EditReserv(int reservationID, int number, int ClientID, DateTime dateIN, DateTime dateOUT)
        {
            MySqlCommand command = new MySqlCommand();
            String EditQuery = "UPDATE `reservations` SET `roomNumber`=@rn,`ClientID`=@ci,`DateIN`=@di,`DateOUT`=@do WHERE `reservID`=@rsv";
            command.CommandText = EditQuery;
            command.Connection = conn.GetConnection();

            command.Parameters.Add("@rsv", MySqlDbType.VarChar).Value = reservationID;
            command.Parameters.Add("@rn", MySqlDbType.VarChar).Value = number;
            command.Parameters.Add("@ci", MySqlDbType.VarChar).Value = ClientID;
            command.Parameters.Add("@di", MySqlDbType.VarChar).Value = dateIN;
            command.Parameters.Add("@do", MySqlDbType.VarChar).Value = dateOUT;

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
        public bool removereserv(int reservationID)
        {
            MySqlCommand command = new MySqlCommand();
            String removeQuery = "DELETE FROM `reservations` WHERE `reservID` = @rsv";
            command.CommandText = removeQuery;
            command.Connection = conn.GetConnection();

            command.Parameters.Add("@rsv", MySqlDbType.Int32).Value = reservationID;

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
