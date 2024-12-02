using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Human_Resource_MS.Properties;


namespace Human_Resource_MS
{
    public partial class HopePage : Form
    {
        public HopePage()
        {
            InitializeComponent();
            InitializePanels();
        }

        private void InitializePanels()
        {
            flowLayoutPanel1.Controls.Clear();
        }

        private void AddPicturestoPanels(string imagePath, string targetForm)
        {
            try
            {
                PictureBox picturebox = new PictureBox
                {
                    Image = Image.FromFile(imagePath),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Width = 150,
                    Height = 100,
                    Margin = new Padding(10),
                    Tag = targetForm

                };
                picturebox.Click += (sender, args) => OpenForm((sender as PictureBox).Tag.ToString());
                flowLayoutPanel1.Controls.Add(picturebox);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}");
            }
        }

        private void OpenForm(String formName)
        {
            Form formToOpen = null;

            switch (formName)
            {
                case "employeedata":
                    formToOpen = new employeedata();
                    break;
                case "Salarydetails":
                    formToOpen = new Salarydetails();
                    break;
                case "Attendance":
                    formToOpen = new Attendance();
                    break;
                default:
                    MessageBox.Show("Invalid form selection");
                    return;
            }
            formToOpen.ShowDialog();
        }

        private void empmsbtn_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            AddPicturestoPanels(@"C:\Users\Admin\Desktop\coding\Human Resource management Syatem\Human Resource MS\Resources\employeereport.png", "employeedata");
            AddPicturestoPanels(@"C:\Users\Admin\Desktop\coding\Human Resource management Syatem\Human Resource MS\Resources\attendance.png", "Attendance");
        }

        private void salarymsbtn_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            AddPicturestoPanels(@"C:\Users\Admin\Desktop\coding\Human Resource management Syatem\Human Resource MS\Resources\salarydetails.png", "Salarydetails");
        }

        private void depmsbtn_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
        }

        private void reportsbtn_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
