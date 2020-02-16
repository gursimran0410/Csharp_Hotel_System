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
    public partial class ManageRoomsForm : Form
    {
        public ManageRoomsForm()
        {
            InitializeComponent();
        }
        ROOM room = new ROOM();
        private void ManageRoomsForm_Load(object sender, EventArgs e)
        {
            comboBoxRoomtype.DataSource = room.roomTypeList();
            comboBoxRoomtype.DisplayMember = "label";
            comboBoxRoomtype.ValueMember = "category_id";

            dataGridView1.DataSource = room.getroom();
        }
        private void AddNewRoom_Click(object sender, EventArgs e)
        {
            try
            {
                int number = Convert.ToInt32(IDText.Text);
                int type = Convert.ToInt32(comboBoxRoomtype.SelectedValue.ToString());
                String phone = PhoneText.Text;
                String Free = "";
                if(radioButtonyes.Checked)
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
                else if(radioButtonNo.Checked)
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
            catch(Exception exe)
            {
                MessageBox.Show("Values are empty", "Empty Value Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }         
        }
        private void EditRoom_Click(object sender, EventArgs e)
        {
            try
            {
                int number = Convert.ToInt32(IDText.Text);
                int type = Convert.ToInt32(comboBoxRoomtype.SelectedValue.ToString());
                String phone = PhoneText.Text;
                String Free = "";
                if (radioButtonyes.Checked)
                {
                    Free = "Yes";
                    if (room.EditRoom(number, type, phone, Free))
                    {
                        dataGridView1.DataSource = room.getroom();
                        MessageBox.Show("Room has been edited", "Edit Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Room has not been edited", "Edit Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (radioButtonNo.Checked)
                {
                    Free = "No";
                    if (room.EditRoom(number, type, phone, Free))
                    {
                        dataGridView1.DataSource = room.getroom();
                        MessageBox.Show("Room has been edited", "Edit Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Room has not been edited", "Edit Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch(Exception exe)
            {
                MessageBox.Show("Values are Empty", "Empty Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void RemoveRoom_Click(object sender, EventArgs e)
        {
            try
            {
                int number = Convert.ToInt32(IDText.Text);
                if (room.removeRoom(number))
                {
                    dataGridView1.DataSource = room.getroom();
                    MessageBox.Show("Room has been removed", "Remove Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Rooms has not been removed", "Remove Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }catch(Exception exe)
            {
                MessageBox.Show("Values are Empty", "Empty Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearFields_Click(object sender, EventArgs e)
        {
            IDText.Text = "";
            comboBoxRoomtype.SelectedIndex = 0;
            PhoneText.Text = "";
        }
        //display selected row data from datagridview to textboxes
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDText.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            comboBoxRoomtype.SelectedValue = dataGridView1.CurrentRow.Cells[1].Value;
            PhoneText.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
