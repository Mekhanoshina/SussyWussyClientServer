﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEfotobudka_githubik.ceo
{
    public partial class CEO_management_misc : Form
    {
        public CEO_management_misc()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CEO_company_management form = new CEO_company_management();
            // Show the second form
            form.Show();
            // Optionally, hide the current form
            this.Hide();
        }
    }
}