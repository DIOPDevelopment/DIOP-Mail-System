﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIOP_Mail
{
    public partial class Login : Form
    {
        public static string email;
        public static string pass;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            email = txtUsername.Text;
            pass = txtPassword.Text;
            this.Hide();
            Form1 main = new Form1();
            main.Show();
        }
    }
}
