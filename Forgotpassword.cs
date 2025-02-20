using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using Microsoft.Data.SqlClient;

namespace Human_Resource_MS
{
    public partial class Forgotpassword : Form
    {
        public Forgotpassword()
        {
            InitializeComponent();
        }
        private string? randomCode;
        private string connectionstring = "Data Source=LAPTOP-NFU692OK\\LOCALDB;Initial Catalog=dblogin;Persist Security Info=True;User ID=sa;Password=p@ssw0rd;Encrypt=True;Trust Server Certificate=True";
        private void sendbtn_Click(object sender, EventArgs e)
        {
            string inputUsername = emailtxt.Text.Trim();

            if (string.IsNullOrEmpty(inputUsername))
            {
                MessageBox.Show("Please enter a username.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (IsUsernameValid(inputUsername))
            {
                // Proceed with sending email
                string to = emailtxt.Text;
                string from = "yourmail@gmail.com";
                string pass = "TFApassword"; // Your app-specific password
                randomCode = GenerateVerificationCode(); // Replace with your code generation logic
                string messageBody = $"Your verification code for Human Resources Management Program is {randomCode}";

                SendEmail(to, from, pass, messageBody);
            }
            else
            {
                MessageBox.Show("Username not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsUsernameValid(string username)
        {
            string query = "SELECT COUNT(*) FROM tbllogin WHERE username = @Username";
            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        int count = (int)cmd.ExecuteScalar();
                        return count > 0; // Username exists if count > 0
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        private void SendEmail(string to, string from, string pass, string messageBody)
        {
            try
            {
                MailMessage message = new MailMessage
                {
                    From = new MailAddress(from),
                    Subject = "Password Verification Code",
                    Body = messageBody
                };
                message.To.Add(to);

                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.EnableSsl = true;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new NetworkCredential(from, pass);

                    smtp.Send(message);
                    MessageBox.Show("Code sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to send email: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GenerateVerificationCode()
        {
            Random random = new Random();
            return random.Next(100000, 999999).ToString(); // Generate a 6-digit code
        }
        private void verifybtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(codetxt.Text))
            {
                MessageBox.Show("Please enter the verification code.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Compare the entered code with the generated random code
            if (codetxt.Text.Trim() == randomCode)
            {
                string recipientEmail = emailtxt.Text.Trim();

                // Open the RecheckPassword form
                Recheckpassword rp = new Recheckpassword(recipientEmail);
                this.Hide();
                rp.Show();

                MessageBox.Show("Verification successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Wrong verification code. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
