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
    public partial class ManageReservationsForm : Form
    {
        RESERVATION reserv = new RESERVATION();
        ROOM room = new ROOM();
        public ManageReservationsForm()
        {
            InitializeComponent();
        }

        private void ClearFields_Click(object sender, EventArgs e)
        {
            IDText.Text = "";
            FNText.Text = "";
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            dateTimePickerIN.Value = DateTime.Now;
            dateTimePickerOUT.Value = DateTime.Now;
        }

        private void ManageReservationsForm_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = room.roomTypeList();
            comboBox1.DisplayMember = "label";
            comboBox1.ValueMember = "category_id";
        }

        private void AddNewRoom_Click(object sender, EventArgs e)
        {
            try
            {
                int number = Convert.ToInt32(IDText.Text);
                int ClientID = Convert.ToInt32(FNText.Text);
                int comboBox1 = Convert.ToInt32(comboBox1.SelectedValue.ToString());
                String Free = "";
                if (radioButtonyes.Checked)
                {
                    Free = "Yes";
                    if (room.addroom(number, type, phone, Free))
                    {
                        dataGridView1.DataSource = room.getroom();
                        MessageBox.Show("Room Added Succesfully", "Add Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Room not added", "Add Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (radioButtonNo.Checked)
                {
                    Free = "No";
                    if (room.addroom(number, type, phone, Free))
                    {
                        dataGridView1.DataSource = room.getroom();
                        MessageBox.Show("Room Added Succesfully", "Add Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Room not added", "Add Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception exe)
            {
                MessageBox.Show("Values are empty", "Empty Value Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
