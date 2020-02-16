namespace Csharp_Hotel_System
{
    partial class ManageRoomsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxRoomtype = new System.Windows.Forms.ComboBox();
            this.EditRoom = new System.Windows.Forms.Button();
            this.RemoveRoom = new System.Windows.Forms.Button();
            this.ClearFields = new System.Windows.Forms.Button();
            this.AddNewRoom = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PhoneText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IDText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonyes = new System.Windows.Forms.RadioButton();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboBoxRoomtype);
            this.panel1.Controls.Add(this.EditRoom);
            this.panel1.Controls.Add(this.RemoveRoom);
            this.panel1.Controls.Add(this.ClearFields);
            this.panel1.Controls.Add(this.AddNewRoom);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.PhoneText);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.IDText);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 509);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.radioButtonNo);
            this.panel3.Controls.Add(this.radioButtonyes);
            this.panel3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(124, 242);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(204, 19);
            this.panel3.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Free :";
            // 
            // comboBoxRoomtype
            // 
            this.comboBoxRoomtype.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRoomtype.FormattingEnabled = true;
            this.comboBoxRoomtype.Location = new System.Drawing.Point(124, 154);
            this.comboBoxRoomtype.Name = "comboBoxRoomtype";
            this.comboBoxRoomtype.Size = new System.Drawing.Size(204, 26);
            this.comboBoxRoomtype.TabIndex = 8;
            // 
            // EditRoom
            // 
            this.EditRoom.Font = new System.Drawing.Font("AR JULIAN", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditRoom.Location = new System.Drawing.Point(132, 359);
            this.EditRoom.Name = "EditRoom";
            this.EditRoom.Size = new System.Drawing.Size(88, 35);
            this.EditRoom.TabIndex = 7;
            this.EditRoom.Text = "Edit";
            this.EditRoom.UseVisualStyleBackColor = true;
            this.EditRoom.Click += new System.EventHandler(this.EditRoom_Click);
            // 
            // RemoveRoom
            // 
            this.RemoveRoom.Font = new System.Drawing.Font("AR JULIAN", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveRoom.Location = new System.Drawing.Point(239, 359);
            this.RemoveRoom.Name = "RemoveRoom";
            this.RemoveRoom.Size = new System.Drawing.Size(89, 35);
            this.RemoveRoom.TabIndex = 6;
            this.RemoveRoom.Text = "Remove";
            this.RemoveRoom.UseVisualStyleBackColor = true;
            this.RemoveRoom.Click += new System.EventHandler(this.RemoveRoom_Click);
            // 
            // ClearFields
            // 
            this.ClearFields.Font = new System.Drawing.Font("AR JULIAN", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearFields.Location = new System.Drawing.Point(82, 419);
            this.ClearFields.Name = "ClearFields";
            this.ClearFields.Size = new System.Drawing.Size(172, 37);
            this.ClearFields.TabIndex = 5;
            this.ClearFields.Text = "Clear Fields";
            this.ClearFields.UseVisualStyleBackColor = true;
            this.ClearFields.Click += new System.EventHandler(this.ClearFields_Click);
            // 
            // AddNewRoom
            // 
            this.AddNewRoom.Font = new System.Drawing.Font("AR JULIAN", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewRoom.Location = new System.Drawing.Point(7, 359);
            this.AddNewRoom.Name = "AddNewRoom";
            this.AddNewRoom.Size = new System.Drawing.Size(107, 35);
            this.AddNewRoom.TabIndex = 4;
            this.AddNewRoom.Text = "Add New Room";
            this.AddNewRoom.UseVisualStyleBackColor = true;
            this.AddNewRoom.Click += new System.EventHandler(this.AddNewRoom_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(372, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(510, 359);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // PhoneText
            // 
            this.PhoneText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneText.Location = new System.Drawing.Point(124, 197);
            this.PhoneText.Name = "PhoneText";
            this.PhoneText.Size = new System.Drawing.Size(204, 26);
            this.PhoneText.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Phone :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Room Type :";
            // 
            // IDText
            // 
            this.IDText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDText.Location = new System.Drawing.Point(124, 113);
            this.IDText.Name = "IDText";
            this.IDText.Size = new System.Drawing.Size(204, 26);
            this.IDText.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Room No. :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Firebrick;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1003, 96);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Gabriola", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(894, 96);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Rooms";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButtonyes
            // 
            this.radioButtonyes.AutoSize = true;
            this.radioButtonyes.Checked = true;
            this.radioButtonyes.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonyes.Location = new System.Drawing.Point(22, 1);
            this.radioButtonyes.Name = "radioButtonyes";
            this.radioButtonyes.Size = new System.Drawing.Size(44, 18);
            this.radioButtonyes.TabIndex = 0;
            this.radioButtonyes.Text = "Yes";
            this.radioButtonyes.UseVisualStyleBackColor = true;
            // 
            // radioButtonNo
            // 
            this.radioButtonNo.AutoSize = true;
            this.radioButtonNo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonNo.Location = new System.Drawing.Point(115, 1);
            this.radioButtonNo.Name = "radioButtonNo";
            this.radioButtonNo.Size = new System.Drawing.Size(38, 18);
            this.radioButtonNo.TabIndex = 1;
            this.radioButtonNo.Text = "No";
            this.radioButtonNo.UseVisualStyleBackColor = true;
            // 
            // ManageRoomsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 509);
            this.Controls.Add(this.panel1);
            this.Name = "ManageRoomsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageRoomsForm";
            this.Load += new System.EventHandler(this.ManageRoomsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button EditRoom;
        private System.Windows.Forms.Button RemoveRoom;
        private System.Windows.Forms.Button ClearFields;
        private System.Windows.Forms.Button AddNewRoom;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox PhoneText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IDText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxRoomtype;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radioButtonNo;
        private System.Windows.Forms.RadioButton radioButtonyes;
    }
}