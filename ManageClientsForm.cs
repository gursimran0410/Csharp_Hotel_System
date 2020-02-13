using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_Hotel_System
{
    public partial class ManageClientsForm : Form
    {
        CLIENT client = new CLIENT();
        public ManageClientsForm()
        {
            InitializeComponent();
        }

        private void ClearFields_Click(object sender, EventArgs e)
        {
            IDText.Text = "";
            FNText.Text = "";
            LNText.Text = "";
            PhoneText.Text = "";
            CountryText.Text = "";
        }

        private void AddNewClient_Click(object sender, EventArgs e)
        {
            String fname = FNText.Text;
            String lname = LNText.Text;
            String phone = PhoneText.Text;
            String country = CountryText.Text;

            if(fname.Trim().Equals("") || lname.Trim().Equals("") || phone.Trim().Equals("") || country.Trim().Equals(""))
            {
                MessageBox.Show("Error - New Client Not Inserted Successfully", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean insertClient = client.insertClient(fname, lname, phone, country);
                if (insertClient)
                {
                    dataGridView1.DataSource = client.getclients();
                    MessageBox.Show("New Client Inserted Successfully", "Add Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error - New Client Not Inserted Successfully", "Client Add", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ManageClientsForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = client.getclients();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            int id;
            String fname = FNText.Text;
            String lname = LNText.Text;
            String phone = PhoneText.Text;
            String country = CountryText.Text;

            try
            {
                id = Convert.ToInt32(IDText.Text);
                if (fname.Trim().Equals("") || lname.Trim().Equals("") || phone.Trim().Equals("") || country.Trim().Equals(""))
                {
                    MessageBox.Show("Error - New Client Not Edit Successfully", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Boolean EditClient = client.EditClient(id, fname, lname, phone, country);
                    if (EditClient)
                    {
                        dataGridView1.DataSource = client.getclients();
                        MessageBox.Show("New Client Edited Successfully", "Edit Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error - New Client Not edited Successfully", "Client Edit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch(Exception exe)
            {
                MessageBox.Show(exe.Message, "ID Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDText.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            FNText.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            LNText.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            PhoneText.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            CountryText.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            int id;
            String fname = FNText.Text;
            String lname = LNText.Text;
            String phone = PhoneText.Text;
            String country = CountryText.Text;

            try
            {
                id = Convert.ToInt32(IDText.Text);
                if (fname.Trim().Equals("") || lname.Trim().Equals("") || phone.Trim().Equals("") || country.Trim().Equals(""))
                {
                    MessageBox.Show("Error - New Client Not Edit Successfully", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Boolean EditClient = client.removeClient(id);
                    if (EditClient)
                    {
                        dataGridView1.DataSource = client.getclients();
                        MessageBox.Show("Client Removed Successfully", "Remove Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Error - Client Not Removed Successfully", "Client Removed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }catch(Exception exe)
            {
                MessageBox.Show(exe.Message, "ID Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
