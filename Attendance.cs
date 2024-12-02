using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using Microsoft.Data.SqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using Microsoft.VisualBasic;

namespace Human_Resource_MS
{
    public partial class Attendance : Form
    {
        private string connectionstring = "Data Source=LAPTOP-NFU692OK\\LOCALDB;Initial Catalog=dblogin;Persist Security Info=True;User ID=sa;Password=p@ssw0rd;Encrypt=True;Trust Server Certificate=True";
        public Attendance()
        {
            InitializeComponent();
            LoadAttendanceData();
            LoadEmployeeID();
            LoadLeaveTypes();
            InitializeAttendanceID();
        }

        private void ClearField()
        {
            empidcbo.SelectedIndex = -1;
            empnametxt.Text = "";
            statuscbo.SelectedIndex = -1;
            leavecbo.SelectedIndex = -1;
        }

        private void LoadAttendanceData()
        {
            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT A.attendance_id, E.emp_id, E.emp_name, A.attendance_date, A.attendance_status, L.leave_type " +
                    "FROM tblattendance A " +
                    "JOIN tblemployee E ON A.emp_id = E.emp_id " +
                    "LEFT JOIN tblleave L ON A.leave_id = L.leave_id ", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                attendancegd.DataSource = dt;
            }
        }

        private void LoadEmployeeID()
        {
            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT emp_id, emp_name FROM tblemployee", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                empidcbo.DataSource = dt;
                empidcbo.DisplayMember = "emp_id";
                empidcbo.ValueMember = "emp_id";
            }
        }

        private void LoadLeaveTypes()
        {
            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT leave_id, leave_type FROM tblleave", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                leavecbo.DataSource = dt;
                leavecbo.DisplayMember = "leave_type";
                leavecbo.ValueMember = "leave_id";
            }
        }
        private void InitializeAttendanceID()
        {
            attendanceidcbo.ReadOnly = true;
            attendanceidcbo.Text = GetNextAttendanceID().ToString();
        }

        private int? GetNextAttendanceID()
        {
            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT ISNULL(MAX(attendance_id), 0) + 1 FROM tblattendance", conn);
                return (int)cmd.ExecuteScalar();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (empidcbo.SelectedValue != null && empidcbo.SelectedValue is DataRowView)
            {
                var selectedRow = (DataRowView)empidcbo.SelectedValue;
                int employeeid = (int)selectedRow["emp_id"];
                using (SqlConnection conn = new SqlConnection(connectionstring))
                {
                    SqlCommand cmd = new SqlCommand("SELECT emp_name FROM tblemployee WHERE emp_id = @emp_id", conn);
                    cmd.Parameters.AddWithValue("@emp_id", employeeid);
                    conn.Open();
                    empnametxt.Text = cmd.ExecuteScalar()?.ToString();
                }
            }
            else if (empidcbo.SelectedValue != null)
            {
                int employeeid = (int)empidcbo.SelectedValue;
                using (SqlConnection conn = new SqlConnection(connectionstring))
                {
                    SqlCommand cmd = new SqlCommand("SELECT emp_name FROM tblemployee WHERE emp_id = @emp_id", conn);
                    cmd.Parameters.AddWithValue("@emp_id", employeeid);
                    conn.Open();
                    empnametxt.Text = cmd.ExecuteScalar()?.ToString();
                }
            }
        }

        private void statuscbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            leavecbo.Enabled = statuscbo.SelectedItem?.ToString() == "Absent";
            if (statuscbo.SelectedItem?.ToString() == "Present")
            {
                leavecbo.SelectedIndex = -1;
            }

        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            int empid = (int)empidcbo.SelectedValue;
            DateTime date = attendancedtp.Value;
            string status = statuscbo.SelectedItem?.ToString();
            int? leaveid = status == "Absent" ? (int?)leavecbo.SelectedValue : null;

            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO tblattendance(emp_id, attendance_date, attendance_status, leave_id) VALUES (@emp_id, @attendance_date, @attendance_status, @leave_id)", conn);
                cmd.Parameters.AddWithValue("@emp_id", empid);
                cmd.Parameters.AddWithValue("@attendance_date", date);
                cmd.Parameters.AddWithValue("@attendance_status", status);
                cmd.Parameters.AddWithValue("@leave_id", leaveid.HasValue ? (object)leaveid.Value : DBNull.Value);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Attendance record saved successfully.");
                ClearForm();
                LoadAttendanceData();
            }
        }

        private void ClearForm()
        {
            empidcbo.SelectedIndex = -1;
            empnametxt.Clear();
            statuscbo.SelectedIndex = -1;
            attendancedtp.Value = DateTime.Now;
            leavecbo.SelectedIndex = -1;
            InitializeAttendanceID();
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            ClearForm();
            LoadAttendanceData();
        }

        private void Attendance_Load(object sender, EventArgs e)
        {
            LoadAttendanceData();
        }

        private void attendancegd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = attendancegd.Rows[e.RowIndex];
                empidcbo.Text = row.Cells["emp_id"].Value.ToString();
                empnametxt.Text = row.Cells["emp_name"].Value.ToString();
                attendanceidcbo.Text = row.Cells["attendance_id"].Value.ToString();
                statuscbo.Text = row.Cells["attendance_status"].Value.ToString();
                attendancedtp.Text = row.Cells["attendance_date"].Value.ToString();
                leavecbo.Text = row.Cells["leave_type"].Value.ToString();
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                string query = "DELETE FROM tblattendance WHERE attendance_id = @attendance_id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@attendance_id", attendanceidcbo.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Attendance deleted successfully!");
                }
            }
            LoadAttendanceData();
            ClearField();
        }

        private void empnametxt_Leave(object sender, EventArgs e)
        {
            string employeename = empnametxt.Text.Trim();
            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                SqlCommand cmd = new SqlCommand (" SELECT emp_id FROM tblemployee WHERE emp_name = @emp_name", conn);
                cmd.Parameters.AddWithValue("@emp_name", employeename);
                conn.Open();
                empidcbo.Text = cmd.ExecuteScalar()?.ToString();
            }
        }
    }
}
