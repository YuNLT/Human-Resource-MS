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
            sendbtn.Cursor = Cursors.Hand;
            sendbtn.ForeColor = Color.FromArgb(192, 0, 192);
            sendbtn.Location = new Point(760, 60);
            sendbtn.Margin = new Padding(5, 4, 5, 4);
            sendbtn.Name = "sendbtn";
            sendbtn.Size = new Size(153, 41);
            sendbtn.TabIndex = 0;
            sendbtn.Text = "Send";
            sendbtn.UseVisualStyleBackColor = true;
            sendbtn.Click += sendbtn_Click;
            // 
            // verifybtn
            // 
            verifybtn.Cursor = Cursors.Hand;
            verifybtn.ForeColor = Color.FromArgb(192, 0, 192);
            verifybtn.Location = new Point(760, 162);
            verifybtn.Margin = new Padding(5, 4, 5, 4);
            verifybtn.Name = "verifybtn";
            verifybtn.Size = new Size(153, 41);
            verifybtn.TabIndex = 1;
            verifybtn.Text = "Verify";
            verifybtn.UseVisualStyleBackColor = true;
            verifybtn.Click += verifybtn_Click;
            // 
            // label1
            // 
            label1.AllowDrop = true;
            label1.AutoSize = true;
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(58, 65);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(123, 28);
            label1.TabIndex = 2;
            label1.Text = "Enter Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(58, 162);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(242, 28);
            label2.TabIndex = 3;
            label2.Text = "Enter Verification Code";
            // 
            // emailtxt
            // 
            emailtxt.Location = new Point(367, 62);
            emailtxt.Margin = new Padding(5, 4, 5, 4);
            emailtxt.Name = "emailtxt";
            emailtxt.Size = new Size(345, 35);
            emailtxt.TabIndex = 4;
            // 
            // codetxt
            // 
            codetxt.Location = new Point(367, 158);
            codetxt.Margin = new Padding(5, 4, 5, 4);
            codetxt.Name = "codetxt";
            codetxt.Size = new Size(201, 35);
            codetxt.TabIndex = 5;
            // 
            // Forgotpassword
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 0, 192);
            ClientSize = new Size(954, 274);
            Controls.Add(codetxt);
            Controls.Add(emailtxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(verifybtn);
            Controls.Add(sendbtn);
            Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Forgotpassword";
            StartPosition = FormStartPosition.CenterScreen;
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