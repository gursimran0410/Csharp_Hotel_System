namespace Csharp_Hotel_System
{
    partial class ManageClientsForm
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
            this.Edit = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.ClearFields = new System.Windows.Forms.Button();
            this.AddNewClient = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CountryText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PhoneText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LNText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FNText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IDText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.Controls.Add(this.Edit);
            this.panel1.Controls.Add(this.Remove);
            this.panel1.Controls.Add(this.ClearFields);
            this.panel1.Controls.Add(this.AddNewClient);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.CountryText);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.PhoneText);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.LNText);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.FNText);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.IDText);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 509);
            this.panel1.TabIndex = 0;
            // 
            // Edit
            // 
            this.Edit.Font = new System.Drawing.Font("AR JULIAN", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit.Location = new System.Drawing.Point(132, 359);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(88, 35);
            this.Edit.TabIndex = 7;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Remove
            // 
            this.Remove.Font = new System.Drawing.Font("AR JULIAN", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remove.Location = new System.Drawing.Point(239, 359);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(89, 35);
            this.Remove.TabIndex = 6;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
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
            // AddNewClient
            // 
            this.AddNewClient.Font = new System.Drawing.Font("AR JULIAN", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewClient.Location = new System.Drawing.Point(7, 359);
            this.AddNewClient.Name = "AddNewClient";
            this.AddNewClient.Size = new System.Drawing.Size(107, 35);
            this.AddNewClient.TabIndex = 4;
            this.AddNewClient.Text = "Add New Client";
            this.AddNewClient.UseVisualStyleBackColor = true;
            this.AddNewClient.Click += new System.EventHandler(this.AddNewClient_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(372, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(510, 359);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // CountryText
            // 
            this.CountryText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountryText.Location = new System.Drawing.Point(124, 284);
            this.CountryText.Name = "CountryText";
            this.CountryText.Size = new System.Drawing.Size(204, 26);
            this.CountryText.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Country :";
            // 
            // PhoneText
            // 
            this.PhoneText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneText.Location = new System.Drawing.Point(124, 240);
            this.PhoneText.Name = "PhoneText";
            this.PhoneText.Size = new System.Drawing.Size(204, 26);
            this.PhoneText.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Phone :";
            // 
            // LNText
            // 
            this.LNText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNText.Location = new System.Drawing.Point(124, 196);
            this.LNText.Name = "LNText";
            this.LNText.Size = new System.Drawing.Size(204, 26);
            this.LNText.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Last Name :";
            // 
            // FNText
            // 
            this.FNText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FNText.Location = new System.Drawing.Point(124, 154);
            this.FNText.Name = "FNText";
            this.FNText.Size = new System.Drawing.Size(204, 26);
            this.FNText.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "First Name :";
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
            this.label2.Location = new System.Drawing.Point(78, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID :";
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
            this.label1.Text = "Manage Clients";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ManageClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 509);
            this.Controls.Add(this.panel1);
            this.Name = "ManageClientsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageClientsForm";
            this.Load += new System.EventHandler(this.ManageClientsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button ClearFields;
        private System.Windows.Forms.Button AddNewClient;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox CountryText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PhoneText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox LNText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FNText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IDText;
        private System.Windows.Forms.Label label2;
    }
}