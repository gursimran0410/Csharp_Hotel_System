﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Csharp_Hotel_System
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            Connect conn = new Connect();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            String query = "SELECT * FROM `user` WHERE `username`= @usn AND `password`= @pass";

            command.CommandText = query;
            command.Connection = conn.GetConnection();

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = UText.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = PText.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.Hide();
                Main_Form mform = new Main_Form();
                mform.Show();
            }
            else
            {
                if (UText.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Enter your Username to login", "Empty Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (PText.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Enter your Password to login", "Empty Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Enter Correct Username OR Password", "Credentials Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
