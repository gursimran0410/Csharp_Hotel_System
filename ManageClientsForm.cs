﻿using System;
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
    }
}
