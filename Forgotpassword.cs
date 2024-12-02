using System;
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

namespace Human_Resource_MS
{
    public partial class Forgotpassword : Form
    {
        string randomCode;
        public static string to;
        public Forgotpassword()
        {
            InitializeComponent();
        }

        private void sendbtn_Click(object sender, EventArgs e)
        {
            string from, pass, messagebody;
            Random random = new Random();
            randomCode = (random.Next(999999)).ToString();
            MailMessage message = new MailMessage();
            to = (emailtxt.Text).ToString();
            from = "yunilarthinn@gmail.com";
            pass = "admin";
            messagebody = "Your verification code is " + randomCode;
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messagebody;
            message.Subject = "Password verification code";
            SmtpClient smtp = new SmtpClient("Smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                smtp.Send(message);
                MessageBox.Show("code sent successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void verifybtn_Click(object sender, EventArgs e)
        {
            if (randomCode == (codetxt.Text).ToString())
            {
                to = emailtxt.Text;
                Recheckpassword rp = new Recheckpassword();
                this.Hide();
                rp.Show();
            }
            else
            {
                MessageBox.Show("Wrong Verification Code");
            }
        }
    }
}
