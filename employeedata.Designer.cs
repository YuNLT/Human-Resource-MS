namespace Human_Resource_MS
{
    partial class employeedata
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            empidtxt = new TextBox();
            empnametxt = new TextBox();
            empnrctxt = new TextBox();
            empaddresstxt = new TextBox();
            label5 = new Label();
            label6 = new Label();
            empphonetxt = new TextBox();
            gendercbo = new ComboBox();
            empdg = new DataGridView();
            label7 = new Label();
            empemailtxt = new TextBox();
            label8 = new Label();
            label10 = new Label();
            label11 = new Label();
            jobtitletxt = new TextBox();
            empstatustxt = new ComboBox();
            newbtn = new Button();
            savebtn = new Button();
            updatebtn = new Button();
            deletebtn = new Button();
            backbtn = new Button();
            printbtn = new Button();
            empphoto = new PictureBox();
            addphotobtn = new Button();
            label12 = new Label();
            depcbo = new ComboBox();
            empbirthdtp = new DateTimePicker();
            label9 = new Label();
            hireDatedtp = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)empdg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)empphoto).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(278, 61);
            label1.Name = "label1";
            label1.Size = new Size(111, 23);
            label1.TabIndex = 0;
            label1.Text = "Employee ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(278, 131);
            label2.Name = "label2";
            label2.Size = new Size(140, 23);
            label2.TabIndex = 1;
            label2.Text = "Employee Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(278, 204);
            label3.Name = "label3";
            label3.Size = new Size(45, 23);
            label3.TabIndex = 2;
            label3.Text = "NRC";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(278, 282);
            label4.Name = "label4";
            label4.Size = new Size(74, 23);
            label4.TabIndex = 3;
            label4.Text = "Address";
            // 
            // empidtxt
            // 
            empidtxt.Location = new Point(451, 50);
            empidtxt.Multiline = true;
            empidtxt.Name = "empidtxt";
            empidtxt.Size = new Size(155, 49);
            empidtxt.TabIndex = 4;
            // 
            // empnametxt
            // 
            empnametxt.Location = new Point(451, 115);
            empnametxt.Multiline = true;
            empnametxt.Name = "empnametxt";
            empnametxt.Size = new Size(314, 57);
            empnametxt.TabIndex = 5;
            // 
            // empnrctxt
            // 
            empnrctxt.Location = new Point(451, 192);
            empnrctxt.Multiline = true;
            empnrctxt.Name = "empnrctxt";
            empnrctxt.Size = new Size(314, 52);
            empnrctxt.TabIndex = 6;
            // 
            // empaddresstxt
            // 
            empaddresstxt.Location = new Point(451, 269);
            empaddresstxt.Multiline = true;
            empaddresstxt.Name = "empaddresstxt";
            empaddresstxt.Size = new Size(312, 49);
            empaddresstxt.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(807, 58);
            label5.Name = "label5";
            label5.Size = new Size(68, 23);
            label5.TabIndex = 8;
            label5.Text = "Gender";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(807, 301);
            label6.Name = "label6";
            label6.Size = new Size(59, 23);
            label6.TabIndex = 9;
            label6.Text = "Phone";
            // 
            // empphonetxt
            // 
            empphonetxt.Location = new Point(914, 279);
            empphonetxt.Multiline = true;
            empphonetxt.Name = "empphonetxt";
            empphonetxt.Size = new Size(187, 53);
            empphonetxt.TabIndex = 11;
            // 
            // gendercbo
            // 
            gendercbo.FormattingEnabled = true;
            gendercbo.Items.AddRange(new object[] { "M", "F" });
            gendercbo.Location = new Point(914, 53);
            gendercbo.Name = "gendercbo";
            gendercbo.Size = new Size(71, 31);
            gendercbo.TabIndex = 12;
            // 
            // empdg
            // 
            empdg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            empdg.Location = new Point(12, 483);
            empdg.Name = "empdg";
            empdg.RowHeadersWidth = 51;
            empdg.Size = new Size(1650, 296);
            empdg.TabIndex = 13;
            empdg.CellClick += empdg_CellClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(807, 213);
            label7.Name = "label7";
            label7.Size = new Size(54, 23);
            label7.TabIndex = 14;
            label7.Text = "Email";
            // 
            // empemailtxt
            // 
            empemailtxt.Location = new Point(914, 199);
            empemailtxt.Multiline = true;
            empemailtxt.Name = "empemailtxt";
            empemailtxt.Size = new Size(288, 45);
            empemailtxt.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1237, 213);
            label8.Name = "label8";
            label8.Size = new Size(108, 23);
            label8.TabIndex = 16;
            label8.Text = "Department";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(1237, 135);
            label10.Name = "label10";
            label10.Size = new Size(60, 23);
            label10.TabIndex = 18;
            label10.Text = "Status";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(1237, 58);
            label11.Name = "label11";
            label11.Size = new Size(80, 23);
            label11.TabIndex = 20;
            label11.Text = "Job Title";
            // 
            // jobtitletxt
            // 
            jobtitletxt.Location = new Point(1355, 55);
            jobtitletxt.Multiline = true;
            jobtitletxt.Name = "jobtitletxt";
            jobtitletxt.Size = new Size(275, 38);
            jobtitletxt.TabIndex = 21;
            // 
            // empstatustxt
            // 
            empstatustxt.FormattingEnabled = true;
            empstatustxt.Items.AddRange(new object[] { "Active", "Resigned" });
            empstatustxt.Location = new Point(1355, 141);
            empstatustxt.Name = "empstatustxt";
            empstatustxt.Size = new Size(214, 31);
            empstatustxt.TabIndex = 23;
            // 
            // newbtn
            // 
            newbtn.Cursor = Cursors.Hand;
            newbtn.Location = new Point(361, 399);
            newbtn.Name = "newbtn";
            newbtn.Size = new Size(109, 41);
            newbtn.TabIndex = 24;
            newbtn.Text = "New";
            newbtn.UseVisualStyleBackColor = true;
            newbtn.Click += newbtn_Click;
            // 
            // savebtn
            // 
            savebtn.Cursor = Cursors.Hand;
            savebtn.Location = new Point(538, 398);
            savebtn.Name = "savebtn";
            savebtn.Size = new Size(104, 42);
            savebtn.TabIndex = 25;
            savebtn.Text = "Save";
            savebtn.UseVisualStyleBackColor = true;
            savebtn.Click += savebtn_Click;
            // 
            // updatebtn
            // 
            updatebtn.Cursor = Cursors.Hand;
            updatebtn.Location = new Point(718, 397);
            updatebtn.Name = "updatebtn";
            updatebtn.Size = new Size(104, 43);
            updatebtn.TabIndex = 26;
            updatebtn.Text = "Update";
            updatebtn.UseVisualStyleBackColor = true;
            updatebtn.Click += updatebtn_Click;
            // 
            // deletebtn
            // 
            deletebtn.Cursor = Cursors.Hand;
            deletebtn.Location = new Point(923, 397);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(104, 41);
            deletebtn.TabIndex = 27;
            deletebtn.Text = "Delete";
            deletebtn.UseVisualStyleBackColor = true;
            deletebtn.Click += deletebtn_Click;
            // 
            // backbtn
            // 
            backbtn.Cursor = Cursors.Hand;
            backbtn.Location = new Point(1123, 394);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(104, 44);
            backbtn.TabIndex = 28;
            backbtn.Text = "Back";
            backbtn.UseVisualStyleBackColor = true;
            backbtn.Click += backbtn_Click;
            // 
            // printbtn
            // 
            printbtn.Location = new Point(1319, 397);
            printbtn.Name = "printbtn";
            printbtn.Size = new Size(127, 41);
            printbtn.TabIndex = 29;
            printbtn.Text = "Print";
            printbtn.UseVisualStyleBackColor = true;
            // 
            // empphoto
            // 
            empphoto.BackColor = Color.White;
            empphoto.Location = new Point(48, 50);
            empphoto.Name = "empphoto";
            empphoto.Size = new Size(151, 150);
            empphoto.TabIndex = 30;
            empphoto.TabStop = false;
            // 
            // addphotobtn
            // 
            addphotobtn.Cursor = Cursors.Hand;
            addphotobtn.Location = new Point(146, 399);
            addphotobtn.Name = "addphotobtn";
            addphotobtn.Size = new Size(159, 40);
            addphotobtn.TabIndex = 31;
            addphotobtn.Text = "Add Photo";
            addphotobtn.UseVisualStyleBackColor = true;
            addphotobtn.Click += addphotobtn_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(807, 135);
            label12.Name = "label12";
            label12.Size = new Size(79, 23);
            label12.TabIndex = 32;
            label12.Text = "Birthday";
            // 
            // depcbo
            // 
            depcbo.FormattingEnabled = true;
            depcbo.Location = new Point(1355, 213);
            depcbo.Name = "depcbo";
            depcbo.Size = new Size(275, 31);
            depcbo.TabIndex = 34;
            // 
            // empbirthdtp
            // 
            empbirthdtp.Location = new Point(914, 131);
            empbirthdtp.Name = "empbirthdtp";
            empbirthdtp.Size = new Size(288, 30);
            empbirthdtp.TabIndex = 35;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1237, 295);
            label9.Name = "label9";
            label9.Size = new Size(87, 23);
            label9.TabIndex = 36;
            label9.Text = "Hire Date";
            // 
            // hireDatedtp
            // 
            hireDatedtp.Location = new Point(1355, 289);
            hireDatedtp.Name = "hireDatedtp";
            hireDatedtp.Size = new Size(277, 30);
            hireDatedtp.TabIndex = 37;
            // 
            // employeedata
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1675, 776);
            Controls.Add(hireDatedtp);
            Controls.Add(label9);
            Controls.Add(empbirthdtp);
            Controls.Add(depcbo);
            Controls.Add(label12);
            Controls.Add(addphotobtn);
            Controls.Add(empphoto);
            Controls.Add(printbtn);
            Controls.Add(backbtn);
            Controls.Add(deletebtn);
            Controls.Add(updatebtn);
            Controls.Add(savebtn);
            Controls.Add(newbtn);
            Controls.Add(empstatustxt);
            Controls.Add(jobtitletxt);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(empemailtxt);
            Controls.Add(label7);
            Controls.Add(empdg);
            Controls.Add(gendercbo);
            Controls.Add(empphonetxt);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(empaddresstxt);
            Controls.Add(empnrctxt);
            Controls.Add(empnametxt);
            Controls.Add(empidtxt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "employeedata";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee Data";
            Load += employeedata_Load;
            ((System.ComponentModel.ISupportInitialize)empdg).EndInit();
            ((System.ComponentModel.ISupportInitialize)empphoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox empidtxt;
        private TextBox empnametxt;
        private TextBox empnrctxt;
        private TextBox empaddresstxt;
        private Label label5;
        private Label label6;
        private TextBox empphonetxt;
        private ComboBox gendercbo;
        private DataGridView empdg;
        private Label label7;
        private TextBox empemailtxt;
        private Label label8;
        private Label label10;
        private Label label11;
        private TextBox jobtitletxt;
        private ComboBox empstatustxt;
        private Button newbtn;
        private Button savebtn;
        private Button updatebtn;
        private Button deletebtn;
        private Button backbtn;
        private Button printbtn;
        private PictureBox empphoto;
        private Button addphotobtn;
        private Label label12;
        private ComboBox depcbo;
        private DateTimePicker empbirthdtp;
        private Label label9;
        private DateTimePicker hireDatedtp;
    }
}