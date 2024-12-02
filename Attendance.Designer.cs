namespace Human_Resource_MS
{
    partial class Attendance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Savebtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            clearbtn = new Button();
            empidcbo = new ComboBox();
            empnametxt = new TextBox();
            statuscbo = new ComboBox();
            attendancedtp = new DateTimePicker();
            leavecbo = new ComboBox();
            attendancegd = new DataGridView();
            attendanceidcbo = new TextBox();
            deletebtn = new Button();
            ((System.ComponentModel.ISupportInitialize)attendancegd).BeginInit();
            SuspendLayout();
            // 
            // Savebtn
            // 
            Savebtn.Location = new Point(553, 213);
            Savebtn.Name = "Savebtn";
            Savebtn.Size = new Size(131, 43);
            Savebtn.TabIndex = 0;
            Savebtn.Text = "Save";
            Savebtn.UseVisualStyleBackColor = true;
            Savebtn.Click += Savebtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 63);
            label1.Name = "label1";
            label1.Size = new Size(111, 23);
            label1.TabIndex = 1;
            label1.Text = "Employee ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 143);
            label2.Name = "label2";
            label2.Size = new Size(140, 23);
            label2.TabIndex = 2;
            label2.Text = "Employee Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 223);
            label3.Name = "label3";
            label3.Size = new Size(125, 23);
            label3.TabIndex = 3;
            label3.Text = "Attendance ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(71, 299);
            label4.Name = "label4";
            label4.Size = new Size(60, 23);
            label4.TabIndex = 4;
            label4.Text = "Status";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(575, 63);
            label5.Name = "label5";
            label5.Size = new Size(48, 23);
            label5.TabIndex = 5;
            label5.Text = "Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(575, 143);
            label6.Name = "label6";
            label6.Size = new Size(55, 23);
            label6.TabIndex = 6;
            label6.Text = "Leave";
            // 
            // clearbtn
            // 
            clearbtn.Cursor = Cursors.Hand;
            clearbtn.Location = new Point(739, 213);
            clearbtn.Name = "clearbtn";
            clearbtn.Size = new Size(128, 43);
            clearbtn.TabIndex = 7;
            clearbtn.Text = "Clear";
            clearbtn.UseVisualStyleBackColor = true;
            clearbtn.Click += clearbtn_Click;
            // 
            // empidcbo
            // 
            empidcbo.FormattingEnabled = true;
            empidcbo.Location = new Point(232, 65);
            empidcbo.Name = "empidcbo";
            empidcbo.Size = new Size(215, 31);
            empidcbo.TabIndex = 8;
            empidcbo.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // empnametxt
            // 
            empnametxt.Location = new Point(232, 143);
            empnametxt.Name = "empnametxt";
            empnametxt.Size = new Size(291, 30);
            empnametxt.TabIndex = 9;
            empnametxt.Leave += empnametxt_Leave;
            // 
            // statuscbo
            // 
            statuscbo.FormattingEnabled = true;
            statuscbo.Items.AddRange(new object[] { "Present", "Absent" });
            statuscbo.Location = new Point(232, 299);
            statuscbo.Name = "statuscbo";
            statuscbo.Size = new Size(214, 31);
            statuscbo.TabIndex = 11;
            statuscbo.SelectedIndexChanged += statuscbo_SelectedIndexChanged;
            // 
            // attendancedtp
            // 
            attendancedtp.Location = new Point(653, 62);
            attendancedtp.Name = "attendancedtp";
            attendancedtp.Size = new Size(250, 30);
            attendancedtp.TabIndex = 12;
            // 
            // leavecbo
            // 
            leavecbo.FormattingEnabled = true;
            leavecbo.Location = new Point(653, 135);
            leavecbo.Name = "leavecbo";
            leavecbo.Size = new Size(247, 31);
            leavecbo.TabIndex = 13;
            // 
            // attendancegd
            // 
            attendancegd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            attendancegd.Location = new Point(71, 412);
            attendancegd.Name = "attendancegd";
            attendancegd.RowHeadersWidth = 51;
            attendancegd.Size = new Size(805, 249);
            attendancegd.TabIndex = 14;
            attendancegd.CellClick += attendancegd_CellClick;
            // 
            // attendanceidcbo
            // 
            attendanceidcbo.Location = new Point(232, 220);
            attendanceidcbo.Name = "attendanceidcbo";
            attendanceidcbo.Size = new Size(160, 30);
            attendanceidcbo.TabIndex = 15;
            // 
            // deletebtn
            // 
            deletebtn.Cursor = Cursors.Hand;
            deletebtn.Location = new Point(653, 312);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(117, 34);
            deletebtn.TabIndex = 16;
            deletebtn.Text = "Delete";
            deletebtn.UseVisualStyleBackColor = true;
            deletebtn.Click += deletebtn_Click;
            // 
            // Attendance
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 696);
            Controls.Add(deletebtn);
            Controls.Add(attendanceidcbo);
            Controls.Add(attendancegd);
            Controls.Add(leavecbo);
            Controls.Add(attendancedtp);
            Controls.Add(statuscbo);
            Controls.Add(empnametxt);
            Controls.Add(empidcbo);
            Controls.Add(clearbtn);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Savebtn);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Attendance";
            Text = "Attendance";
            Load += Attendance_Load;
            ((System.ComponentModel.ISupportInitialize)attendancegd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Savebtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button clearbtn;
        private ComboBox empidcbo;
        private TextBox empnametxt;
        private ComboBox statuscbo;
        private DateTimePicker attendancedtp;
        private ComboBox leavecbo;
        private DataGridView attendancegd;
        private TextBox attendanceidcbo;
        private Button deletebtn;
    }
}