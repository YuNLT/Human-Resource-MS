using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Web;
using Microsoft.Data.SqlClient;

namespace Human_Resource_MS
{
    public partial class Recheckpassword : Form
    {
        private string? username;
        public Recheckpassword(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            if (newpasswordtxt.Text == confirmpasswordtxt.Text)
            {
                string connectionString = "Data Source=LAPTOP-NFU692OK\\LOCALDB;Initial Catalog=dblogin;Persist Security Info=True;User ID=sa;Password=p@ssw0rd;Encrypt=True;Trust Server Certificate=True";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "UPDATE [dbo].[tbllogin] SET [password] = @Password WHERE username = @Username";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Password", confirmpasswordtxt.Text);
                        cmd.Parameters.AddWithValue("@Username", username);

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Password reset successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("New password does not match. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void newloginbtn_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }
    }
}
