﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
namespace DIOP_Mail
{
    public partial class Form1 : Form
    {
        NetworkCredential login;
        SmtpClient client;
        MailMessage msg;
        mailSettings settings;
        public Form1()
        {
            InitializeComponent();
            this.settings = new mailSettings();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            
        }
        private static void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show(string.Format("{0} send canceled.", e.UserState), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (e.Error != null)
            {
                MessageBox.Show(string.Format("{0} {1}", e.UserState, e.Error), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Your message has been sent.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.settings = new mailSettings();
            settings.Show();
        }

        private void btnSend_Click_1(object sender, EventArgs e)
        {
            string txtSMTP = settings.SMTP;
            string txtPort = settings.Port;
            bool useSSL = settings.Ssl;
            string email = Login.email;
            string pass = Login.pass;

            login = new NetworkCredential(email, pass);
            client = new SmtpClient(txtSMTP);
            client.Port = Convert.ToInt32(txtPort);
            client.EnableSsl = useSSL;
            client.Credentials = login;
            msg = new MailMessage { From = new MailAddress(email + txtSMTP.Replace("smtp.", "@"), "DIOP Development", Encoding.UTF8) };
            msg.To.Add(new MailAddress(txtTO.Text));
            if (!string.IsNullOrEmpty(txtCC.Text))
                msg.To.Add(new MailAddress(txtCC.Text));
            msg.Subject = txtSubject.Text;
            msg.Body = txtMessage.Text;
            msg.BodyEncoding = Encoding.UTF8;
            msg.IsBodyHtml = true;
            msg.Priority = MailPriority.Normal;
            msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            client.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);
            string userstate = "Sending...";
            client.SendAsync(msg, userstate);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            mailSettings settings = new mailSettings();
            settings.Show();

        }
    }
}
