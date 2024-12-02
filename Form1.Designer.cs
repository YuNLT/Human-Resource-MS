namespace Human_Resource_MS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            loginbtn = new Button();
            groupBox1 = new GroupBox();
            logincb = new CheckBox();
            label2 = new Label();
            label3 = new Label();
            passwordtxt = new TextBox();
            label1 = new Label();
            usernametxt = new TextBox();
            loginpb = new PictureBox();
            cancelbtn = new Button();
            loginll = new LinkLabel();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)loginpb).BeginInit();
            SuspendLayout();
            // 
            // loginbtn
            // 
            loginbtn.BackColor = SystemColors.MenuHighlight;
            loginbtn.Cursor = Cursors.Hand;
            loginbtn.FlatStyle = FlatStyle.Popup;
            loginbtn.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            loginbtn.ForeColor = Color.White;
            loginbtn.Location = new Point(129, 189);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(92, 37);
            loginbtn.TabIndex = 0;
            loginbtn.Text = "Login";
            loginbtn.UseVisualStyleBackColor = false;
            loginbtn.Click += loginbtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(logincb);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(passwordtxt);
            groupBox1.Controls.Add(loginbtn);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(usernametxt);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(212, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(452, 274);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login";
            // 
            // logincb
            // 
            logincb.AutoSize = true;
            logincb.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            logincb.ForeColor = SystemColors.Highlight;
            logincb.Location = new Point(129, 151);
            logincb.Name = "logincb";
            logincb.Size = new Size(145, 24);
            logincb.TabIndex = 18;
            logincb.Text = "Show Password";
            logincb.UseVisualStyleBackColor = true;
            logincb.CheckedChanged += logincb_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(15, 103);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 17;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AllowDrop = true;
            label3.AutoEllipsis = true;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(67, 23);
            label3.Name = "label3";
            label3.Size = new Size(305, 25);
            label3.TabIndex = 16;
            label3.Text = "Human Resources Management System";
            label3.UseCompatibleTextRendering = true;
            // 
            // passwordtxt
            // 
            passwordtxt.Location = new Point(129, 103);
            passwordtxt.Name = "passwordtxt";
            passwordtxt.PasswordChar = '*';
            passwordtxt.Size = new Size(312, 27);
            passwordtxt.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(15, 59);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // usernametxt
            // 
            usernametxt.Location = new Point(129, 59);
            usernametxt.Name = "usernametxt";
            usernametxt.Size = new Size(312, 27);
            usernametxt.TabIndex = 5;
            // 
            // loginpb
            // 
            loginpb.BackColor = Color.Transparent;
            loginpb.BorderStyle = BorderStyle.Fixed3D;
            loginpb.Image = Properties.Resources.hr;
            loginpb.Location = new Point(12, 22);
            loginpb.Name = "loginpb";
            loginpb.Size = new Size(194, 264);
            loginpb.SizeMode = PictureBoxSizeMode.Zoom;
            loginpb.TabIndex = 2;
            loginpb.TabStop = false;
            // 
            // cancelbtn
            // 
            cancelbtn.BackColor = SystemColors.MenuHighlight;
            cancelbtn.Cursor = Cursors.Hand;
            cancelbtn.FlatStyle = FlatStyle.Popup;
            cancelbtn.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            cancelbtn.ForeColor = Color.Transparent;
            cancelbtn.Location = new Point(517, 201);
            cancelbtn.Name = "cancelbtn";
            cancelbtn.Size = new Size(93, 37);
            cancelbtn.TabIndex = 3;
            cancelbtn.Text = "Cancel";
            cancelbtn.UseVisualStyleBackColor = false;
            cancelbtn.Click += cancelbtn_Click;
            // 
            // loginll
            // 
            loginll.AutoSize = true;
            loginll.Location = new Point(414, 254);
            loginll.Name = "loginll";
            loginll.Size = new Size(125, 20);
            loginll.TabIndex = 4;
            loginll.TabStop = true;
            loginll.Text = "Forgot Password?";
            loginll.LinkClicked += loginll_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(667, 298);
            Controls.Add(loginll);
            Controls.Add(cancelbtn);
            Controls.Add(loginpb);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)loginpb).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loginbtn;
        private GroupBox groupBox1;
        private TextBox passwordtxt;
        private Label label1;
        private TextBox usernametxt;
        private Label label3;
        private Label label2;
        private PictureBox loginpb;
        private CheckBox logincb;
        private Button cancelbtn;
        private LinkLabel loginll;
    }
}
