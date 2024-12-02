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
            sendbtn.Location = new Point(468, 43);
            sendbtn.Name = "sendbtn";
            sendbtn.Size = new Size(94, 29);
            sendbtn.TabIndex = 0;
            sendbtn.Text = "Send";
            sendbtn.UseVisualStyleBackColor = true;
            sendbtn.Click += sendbtn_Click;
            // 
            // verifybtn
            // 
            verifybtn.Location = new Point(468, 116);
            verifybtn.Name = "verifybtn";
            verifybtn.Size = new Size(94, 29);
            verifybtn.TabIndex = 1;
            verifybtn.Text = "Verify";
            verifybtn.UseVisualStyleBackColor = true;
            verifybtn.Click += verifybtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 47);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 2;
            label1.Text = "Enter Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 116);
            label2.Name = "label2";
            label2.Size = new Size(161, 20);
            label2.TabIndex = 3;
            label2.Text = "Enter Verification Code";
            // 
            // emailtxt
            // 
            emailtxt.Location = new Point(226, 44);
            emailtxt.Name = "emailtxt";
            emailtxt.Size = new Size(214, 27);
            emailtxt.TabIndex = 4;
            // 
            // codetxt
            // 
            codetxt.Location = new Point(226, 113);
            codetxt.Name = "codetxt";
            codetxt.Size = new Size(125, 27);
            codetxt.TabIndex = 5;
            // 
            // Forgotpassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 196);
            Controls.Add(codetxt);
            Controls.Add(emailtxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(verifybtn);
            Controls.Add(sendbtn);
            Name = "Forgotpassword";
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