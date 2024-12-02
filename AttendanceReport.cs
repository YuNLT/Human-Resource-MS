using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Human_Resource_MS
{
    public partial class AttendanceReport : Form
    {
        private string connectionstring = "Data Source=LAPTOP-NFU692OK\\LOCALDB;Initial Catalog=dblogin;Persist Security Info=True;User ID=sa;Password=p@ssw0rd;Encrypt=True;Trust Server Certificate=True";
        public AttendanceReport()
        {
            InitializeComponent();
            startdatedtp.Value = DateTime.Now.AddMonths(-1);
            enddatedtp.Value = DateTime.Now;
        }

        private void LoadAbsentData(DateTime startDate, DateTime endDate)
        {
            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT E.emp_id, E.emp_name, A.attendance_date, L.leave_type " +
                    "FROM tblattendance A " +
                    "JOIN tblemployee E ON A.emp_id = E.emp_id " +
                    "LEFT JOIN tblleave L ON A.leave_id = L.leave_id " +
                    "WHERE A.attendance_status = 'Absent' AND A.attendance_date BETWEEN @StartDate AND @EndDate ", conn);
                da.SelectCommand.Parameters.AddWithValue("@StartDate", startDate);
                da.SelectCommand.Parameters.AddWithValue("@EndDate", endDate);

                DataTable dt = new DataTable();
                da.Fill(dt);
                attendancereportdg.DataSource = dt;
            }
        }

        private void GenerateAttendanceChart()
        {
            attendancechart.Series.Clear();
            Series series = new Series("Absenteeism");
            series.ChartType = SeriesChartType.Line;

            var absentCountByDate = new Dictionary<DateTime, int>();

            foreach (DataGridViewRow row in attendancereportdg.Rows)
            {
                if (!row.IsNewRow)
                { 
                    if (row.Cells["attendance_date"].Value != null)
                    {
                    DateTime date = Convert.ToDateTime(row.Cells["attendance_date"].Value);
                    if (absentCountByDate.ContainsKey(date))
                        {
                            absentCountByDate[date]++;
                        }
                        else
                        {
                            absentCountByDate[date]= 1;
                        }
                    }
                }
            }

            foreach(var entry in absentCountByDate)
            {
                series.Points.AddXY(entry.Key, entry.Value);
            }
            attendancechart.Series.Add(series);

            attendancechart.Titles.Clear();
            attendancechart.Titles.Add("Absenteeism trends");
            attendancechart.ChartAreas[0].AxisX.Title = "Date";
            attendancechart.ChartAreas[0].AxisY.Title = "Numbers of Absent";
            attendancechart.ChartAreas[0].AxisX.LabelStyle.Format = "dd-MM-yy";
            attendancechart.ChartAreas[0].AxisX.Interval = 1;
            attendancechart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Days;
        }

        private void generatebtn_Click(object sender, EventArgs e)
        {
            DateTime startDate = startdatedtp.Value;
            DateTime endDate = enddatedtp.Value;
            LoadAbsentData(startDate, endDate);
            GenerateAttendanceChart();
        }
    }
}
