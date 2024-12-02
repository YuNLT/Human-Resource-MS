using Microsoft.Data.SqlClient;
using System.Data;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace Human_Resource_MS
{
    public partial class employeedata : Form
    {
        private string connectionstring = "Data Source=LAPTOP-NFU692OK\\LOCALDB;Initial Catalog=dblogin;Persist Security Info=True;User ID=sa;Password=p@ssw0rd;Encrypt=True;Trust Server Certificate=True";
        public employeedata()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                string query = "SELECT * FROM tblemployee";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Bind DataTable to DataGridView
                empdg.DataSource = dt;
            }
        }

        private void ClearFields()
        {
            empidtxt.Text = "";
            empnametxt.Text = "";
            empnrctxt.Text = "";
            empaddresstxt.Text = "";
            gendercbo.SelectedIndex = -1;
            empbirthdtp.Text = "";
            empemailtxt.Text = "";
            empphonetxt.Text = "";
            jobtitletxt.Text = "";
            empstatustxt.Text = "";
            hireDatedtp.Text = "";
            empphoto.Image = null; // Clear PictureBox
        }

        private void LoadDepartments()
        {
            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                String query = "SELECT dep_id, dep_name FROM tbldepartment"; // Adjust table/column names as necessary
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Bind the ComboBox
                depcbo.DataSource = dt;
                depcbo.DisplayMember = "dep_name"; // Name to display
                depcbo.ValueMember = "dep_id";
            }
        }

        private void employeedata_Load(object sender, EventArgs e)
        {
            LoadDepartments();
            LoadData();
        }

        private void newbtn_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionstring))
                {
                    string query = @"
                INSERT INTO tblemployee 
                (emp_id, emp_name, dateofbirth, nationalid, emp_address, gender, dep_id, emp_email, emp_phone, jobtitle, emp_status, emp_photo, hire_date) 
                VALUES 
                (@emp_id, @emp_name, @dateofbirth, @nationalid, @emp_address, @gender, @dep_id, @emp_email, @emp_phone, @jobtitle, @emp_status, @emp_photo, @hire_date)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@emp_id", empidtxt.Text.Trim());
                        cmd.Parameters.AddWithValue("@emp_name", empnametxt.Text.Trim());
                        cmd.Parameters.AddWithValue("@dateofbirth", empbirthdtp.Value);
                        cmd.Parameters.AddWithValue("@nationalid", empnrctxt.Text.Trim());
                        cmd.Parameters.AddWithValue("@emp_address", empaddresstxt.Text.Trim());
                        cmd.Parameters.AddWithValue("@gender", gendercbo.Text);
                        cmd.Parameters.AddWithValue("@dep_id", depcbo.SelectedValue ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@emp_email", empemailtxt.Text.Trim());
                        cmd.Parameters.AddWithValue("@emp_phone", empphonetxt.Text.Trim());
                        cmd.Parameters.AddWithValue("@jobtitle", jobtitletxt.Text.Trim());
                        cmd.Parameters.AddWithValue("@emp_status", empstatustxt.Text.Trim());
                        cmd.Parameters.AddWithValue("@hire_date", hireDatedtp.Value);

                        if (empphoto.Image == null)
                        {
                            cmd.Parameters.Add("@emp_photo", SqlDbType.VarBinary).Value = DBNull.Value;
                        }
                        else
                        {
                            byte[]? imageBytes = ImageToByteArray(empphoto.Image);
                            cmd.Parameters.Add("@emp_photo", SqlDbType.VarBinary).Value = imageBytes;
                        }

                        // Open the connection and execute the query
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Employee saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No rows were affected. Please check your data.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                }

                LoadData();
                ClearFields();
            }
            catch (Exception ex)
            {
                // Handle and log errors
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                // Base query for updating the record
                string query = "UPDATE tblemployee SET emp_name = @emp_name, dateofbirth = @dateofbirth, nationalid = @nationalid, emp_address = @emp_address, " +
                               "gender = @gender, dep_id = @dep_id, emp_email = @emp_email, emp_phone = @emp_phone, jobtitle = @jobtitle, emp_status = @emp_status, " +
                               "hire_date = @hire_date, emp_photo = @emp_photo WHERE emp_id = @emp_id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Add parameters for the fields being updated
                    cmd.Parameters.AddWithValue("@emp_id", empidtxt.Text);
                    cmd.Parameters.AddWithValue("@emp_name", empnametxt.Text);
                    cmd.Parameters.AddWithValue("@dateofbirth", empbirthdtp.Value);
                    cmd.Parameters.AddWithValue("@nationalid", empnrctxt.Text);
                    cmd.Parameters.AddWithValue("@emp_address", empaddresstxt.Text);
                    cmd.Parameters.AddWithValue("@gender", gendercbo.Text);
                    cmd.Parameters.AddWithValue("@dep_id", depcbo.SelectedValue);
                    cmd.Parameters.AddWithValue("@emp_email", empemailtxt.Text);
                    cmd.Parameters.AddWithValue("@emp_phone", empphonetxt.Text);
                    cmd.Parameters.AddWithValue("@jobtitle", jobtitletxt.Text);
                    cmd.Parameters.AddWithValue("@emp_status", empstatustxt.Text);
                    cmd.Parameters.AddWithValue("@hire_date", hireDatedtp.Value);


                    if (empphoto.Image == null)
                    {
                        Console.WriteLine("No image provided! Using DBNull.");
                        cmd.Parameters.AddWithValue("@emp_photo", DBNull.Value);
                    }
                    else
                    {
                        Console.WriteLine("Processing Image...");
                        byte[]? imageBytes = ImageToByteArray(empphoto.Image);
                        cmd.Parameters.AddWithValue("@emp_photo", imageBytes);
                    }
                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Employee updated successfully!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error updating employee: {ex.Message}");
                    }
                }
            }
            LoadData();
            ClearFields();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                string query = "DELETE FROM tblemployee WHERE emp_id = @emp_id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@emp_id", empidtxt.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee deleted successfully!");
                }
            }

            LoadData();
            ClearFields();
        }

        // Convert Image to Byte Array for saving in the database
        private byte[]? ImageToByteArray(Image? image)
        {
            if (image == null)
                return null;

            using (MemoryStream ms = new MemoryStream())
            {
                using (var tempImage = new Bitmap(image)) // Clone the image
                {
                    tempImage.Save(ms, image.RawFormat ?? ImageFormat.Jpeg); // Save the cloned image and set default image format
                }
                return ms.ToArray();

            }
        }

        // Convert Byte Array to Image for displaying in PictureBox
        private Image? ByteArrayToImage(byte[] byteArray)
        {
            if (byteArray == null || byteArray.Length == 0)
                return null;
            try
            {
                using (MemoryStream ms = new MemoryStream(byteArray))
                {
                    return Image.FromStream(ms);
                }
            }
            catch (ExternalException ex)
            {
                // Log the error or handle it appropriately
                MessageBox.Show("Error converting byte array to image: " + ex.Message);
                return null;
            }
        }

        private void empdg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = empdg.Rows[e.RowIndex];

                // Populate form fields
                empidtxt.Text = row.Cells["emp_id"].Value.ToString();
                empnametxt.Text = row.Cells["emp_name"].Value.ToString();
                empbirthdtp.Text = row.Cells["dateofbirth"].Value.ToString();
                empnrctxt.Text = row.Cells["nationalid"].Value.ToString();
                empaddresstxt.Text = row.Cells["emp_address"].Value.ToString();
                gendercbo.Text = row.Cells["gender"].Value.ToString();
                if (row.Cells["dep_id"].Value != DBNull.Value)
                {
                    int depId = Convert.ToInt32(row.Cells["dep_id"].Value);
                    depcbo.SelectedValue = depId;
                }
                empemailtxt.Text = row.Cells["emp_email"].Value.ToString();
                empphonetxt.Text = row.Cells["emp_phone"].Value.ToString();
                jobtitletxt.Text = row.Cells["jobtitle"].Value.ToString();
                empstatustxt.Text = row.Cells["emp_status"].Value.ToString();
                hireDatedtp.Text = row.Cells["hire_date"].Value.ToString();

                // Load image into PictureBox
                if (row.Cells["emp_photo"].Value != DBNull.Value)
                {
                    byte[] imageBytes = (byte[])row.Cells["emp_photo"].Value;
                    empphoto.Image = ByteArrayToImage(imageBytes);

                    // Set the PictureBox's SizeMode to StretchImage
                    empphoto.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    empphoto.Image = null;
                }
            }
        }

        private void addphotobtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Display the image in the PictureBox
                    empphoto.Image = Image.FromFile(openFileDialog.FileName);

                    // Set the PictureBox's SizeMode to StretchImage
                    empphoto.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }

}
