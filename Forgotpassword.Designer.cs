namespace Human_Resource_MS
{
    partial class Forgotpassword
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
            sendbtn = new Button();
            verifybtn = new Button();
            label1 = new Label();
            label2 = new Label();
            emailtxt = new TextBox();
            codetxt = new TextBox();
            SuspendLayout();
            // 
            // sendbtn
            // 
<<<<<<< HEAD
            sendbtn.Cursor = Cursors.Hand;
            sendbtn.ForeColor = Color.FromArgb(192, 0, 192);
            sendbtn.Location = new Point(760, 60);
            sendbtn.Margin = new Padding(5, 4, 5, 4);
            sendbtn.Name = "sendbtn";
            sendbtn.Size = new Size(153, 41);
=======
            sendbtn.Location = new Point(468, 43);
            sendbtn.Name = "sendbtn";
            sendbtn.Size = new Size(94, 29);
>>>>>>> 2adca6f05eda8829eacf3a13eecb1414628bd47d
            sendbtn.TabIndex = 0;
            sendbtn.Text = "Send";
            sendbtn.UseVisualStyleBackColor = true;
            sendbtn.Click += sendbtn_Click;
            // 
            // verifybtn
            // 
<<<<<<< HEAD
            verifybtn.Cursor = Cursors.Hand;
            verifybtn.ForeColor = Color.FromArgb(192, 0, 192);
            verifybtn.Location = new Point(760, 162);
            verifybtn.Margin = new Padding(5, 4, 5, 4);
            verifybtn.Name = "verifybtn";
            verifybtn.Size = new Size(153, 41);
=======
            verifybtn.Location = new Point(468, 116);
            verifybtn.Name = "verifybtn";
            verifybtn.Size = new Size(94, 29);
>>>>>>> 2adca6f05eda8829eacf3a13eecb1414628bd47d
            verifybtn.TabIndex = 1;
            verifybtn.Text = "Verify";
            verifybtn.UseVisualStyleBackColor = true;
            verifybtn.Click += verifybtn_Click;
            // 
            // label1
            // 
<<<<<<< HEAD
            label1.AllowDrop = true;
            label1.AutoSize = true;
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(58, 65);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(123, 28);
=======
            label1.AutoSize = true;
            label1.Location = new Point(36, 47);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
>>>>>>> 2adca6f05eda8829eacf3a13eecb1414628bd47d
            label1.TabIndex = 2;
            label1.Text = "Enter Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
<<<<<<< HEAD
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(58, 162);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(242, 28);
=======
            label2.Location = new Point(36, 116);
            label2.Name = "label2";
            label2.Size = new Size(161, 20);
>>>>>>> 2adca6f05eda8829eacf3a13eecb1414628bd47d
            label2.TabIndex = 3;
            label2.Text = "Enter Verification Code";
            // 
            // emailtxt
            // 
<<<<<<< HEAD
            emailtxt.Location = new Point(367, 62);
            emailtxt.Margin = new Padding(5, 4, 5, 4);
            emailtxt.Name = "emailtxt";
            emailtxt.Size = new Size(345, 35);
=======
            emailtxt.Location = new Point(226, 44);
            emailtxt.Name = "emailtxt";
            emailtxt.Size = new Size(214, 27);
>>>>>>> 2adca6f05eda8829eacf3a13eecb1414628bd47d
            emailtxt.TabIndex = 4;
            // 
            // codetxt
            // 
<<<<<<< HEAD
            codetxt.Location = new Point(367, 158);
            codetxt.Margin = new Padding(5, 4, 5, 4);
            codetxt.Name = "codetxt";
            codetxt.Size = new Size(201, 35);
=======
            codetxt.Location = new Point(226, 113);
            codetxt.Name = "codetxt";
            codetxt.Size = new Size(125, 27);
>>>>>>> 2adca6f05eda8829eacf3a13eecb1414628bd47d
            codetxt.TabIndex = 5;
            // 
            // Forgotpassword
            // 
<<<<<<< HEAD
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 0, 192);
            ClientSize = new Size(954, 274);
=======
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 196);
>>>>>>> 2adca6f05eda8829eacf3a13eecb1414628bd47d
            Controls.Add(codetxt);
            Controls.Add(emailtxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(verifybtn);
            Controls.Add(sendbtn);
<<<<<<< HEAD
            Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Forgotpassword";
            StartPosition = FormStartPosition.CenterScreen;
=======
            Name = "Forgotpassword";
>>>>>>> 2adca6f05eda8829eacf3a13eecb1414628bd47d
            Text = "Forgotpassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button sendbtn;
        private Button verifybtn;
        private Label label1;
        private Label label2;
        private TextBox emailtxt;
        private TextBox codetxt;
    }
}