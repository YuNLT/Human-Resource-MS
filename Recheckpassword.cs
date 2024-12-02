using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using Microsoft.Data.SqlClient;

namespace Human_Resource_MS
{
    public partial class Recheckpassword : Form
    {
        string username = Forgotpassword.to;
        public Recheckpassword()
        {
            InitializeComponent();
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            if (newpasswordtxt.Text == confirmpasswordtxt.Text)
            {
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-NFU692OK\\LOCALDB;Initial Catalog=dblogin;Persist Security Info=True;User ID=sa;Password=p@ssw0rd;Encrypt=True;Trust Server Certificate=True");
                SqlCommand cmd = new SqlCommand("UPDATE [dbo].[tbllogin]  SET ,[password] = '" + confirmpasswordtxt.Text + "' WHERE username = '" + username + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Reset password successfully");
            }
            else
            {
                MessageBox.Show("New password do not match. Please enter new password again.");
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
