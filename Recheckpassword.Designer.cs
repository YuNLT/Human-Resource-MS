namespace Human_Resource_MS
{
    partial class Recheckpassword
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
            newpasswordtxt = new TextBox();
            confirmpasswordtxt = new TextBox();
            resetbtn = new Button();
            label1 = new Label();
            label2 = new Label();
            newloginbtn = new Button();
            SuspendLayout();
            // 
            // newpasswordtxt
            // 
            newpasswordtxt.Location = new Point(278, 55);
            newpasswordtxt.Name = "newpasswordtxt";
            newpasswordtxt.Size = new Size(191, 27);
            newpasswordtxt.TabIndex = 0;
            // 
            // confirmpasswordtxt
            // 
            confirmpasswordtxt.Location = new Point(278, 118);
            confirmpasswordtxt.Name = "confirmpasswordtxt";
            confirmpasswordtxt.Size = new Size(191, 27);
            confirmpasswordtxt.TabIndex = 1;
            // 
            // resetbtn
            // 
            resetbtn.Location = new Point(278, 184);
            resetbtn.Name = "resetbtn";
            resetbtn.Size = new Size(94, 29);
            resetbtn.TabIndex = 2;
            resetbtn.Text = "Reset";
            resetbtn.UseVisualStyleBackColor = true;
            resetbtn.Click += resetbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 55);
            label1.Name = "label1";
            label1.Size = new Size(142, 20);
            label1.TabIndex = 3;
            label1.Text = "Enter New Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 121);
            label2.Name = "label2";
            label2.Size = new Size(161, 20);
            label2.TabIndex = 4;
            label2.Text = "Confirm New Password";
            // 
            // newloginbtn
            // 
            newloginbtn.Location = new Point(400, 184);
            newloginbtn.Name = "newloginbtn";
            newloginbtn.Size = new Size(94, 29);
            newloginbtn.TabIndex = 5;
            newloginbtn.Text = "Login";
            newloginbtn.UseVisualStyleBackColor = true;
            newloginbtn.Click += newloginbtn_Click;
            // 
            // Recheckpassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 254);
            Controls.Add(newloginbtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(resetbtn);
            Controls.Add(confirmpasswordtxt);
            Controls.Add(newpasswordtxt);
            Name = "Recheckpassword";
            Text = "Recheckpassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox newpasswordtxt;
        private TextBox confirmpasswordtxt;
        private Button resetbtn;
        private Label label1;
        private Label label2;
        private Button newloginbtn;
    }
}