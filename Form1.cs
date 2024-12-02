using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.SqlClient;
namespace Human_Resource_MS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-NFU692OK\\LOCALDB;Initial Catalog=dblogin;Persist Security Info=True;User ID=sa;Password=p@ssw0rd;Encrypt=True;Trust Server Certificate=True");
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tbllogin WHERE username = '" + usernametxt.Text + "' AND password = '" + passwordtxt.Text + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login Success", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Connection Denied!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logincb_CheckedChanged(object sender, EventArgs e)
        {
            passwordtxt.PasswordChar = logincb.Checked ? '\0' : '*';
        }

        private void loginll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forgotpassword sc = new Forgotpassword();
            this.Hide();
            sc.Show();
        }
    }
}
