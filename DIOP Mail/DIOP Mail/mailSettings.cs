using System;
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
    public partial class mailSettings : Form
    {
        /*public static string port;
        public static string SMTP;
        public static bool SSL;*/

        public string Port { get; set; }
        public string SMTP { set; get; }
        public bool Ssl { get; set; }


        public mailSettings()
        {
            InitializeComponent();
            this.Port = txtPort.Text;
            this.SMTP = txtSMTP.Text;
            this.Ssl = chkSSL.Checked;
            
        }


        private void mailSettings_Load(object sender, EventArgs e)
        {
            this.Port = txtPort.Text;
            this.SMTP = txtSMTP.Text;
            this.Ssl = chkSSL.Checked;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 main = new Form1();
            main.Show();
        }
    }
}
