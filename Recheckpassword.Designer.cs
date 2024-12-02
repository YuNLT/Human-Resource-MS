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
            newpasswordtxt.BackColor = Color.MintCream;
            newpasswordtxt.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newpasswordtxt.Location = new Point(278, 39);
            newpasswordtxt.Multiline = true;
            newpasswordtxt.Name = "newpasswordtxt";
            newpasswordtxt.Size = new Size(216, 51);
            newpasswordtxt.TabIndex = 0;
            // 
            // confirmpasswordtxt
            // 
            confirmpasswordtxt.BackColor = Color.MintCream;
            confirmpasswordtxt.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            confirmpasswordtxt.Location = new Point(278, 110);
            confirmpasswordtxt.Multiline = true;
            confirmpasswordtxt.Name = "confirmpasswordtxt";
            confirmpasswordtxt.Size = new Size(216, 55);
            confirmpasswordtxt.TabIndex = 1;
            // 
            // resetbtn
            // 
            resetbtn.BackColor = Color.FromArgb(0, 192, 192);
            resetbtn.Cursor = Cursors.Hand;
            resetbtn.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resetbtn.ForeColor = Color.Transparent;
            resetbtn.Location = new Point(278, 189);
            resetbtn.Name = "resetbtn";
            resetbtn.Size = new Size(94, 42);
            resetbtn.TabIndex = 2;
            resetbtn.Text = "Reset";
            resetbtn.UseVisualStyleBackColor = false;
            resetbtn.Click += resetbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Bernard MT Condensed", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(44, 56);
            label1.Name = "label1";
            label1.Size = new Size(183, 24);
            label1.TabIndex = 3;
            label1.Text = "Enter New Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.System;
            label2.Font = new Font("Bernard MT Condensed", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(44, 121);
            label2.Name = "label2";
            label2.Size = new Size(206, 24);
            label2.TabIndex = 4;
            label2.Text = "Confirm New Password";
            // 
            // newloginbtn
            // 
            newloginbtn.BackColor = Color.FromArgb(0, 192, 192);
            newloginbtn.Cursor = Cursors.Hand;
            newloginbtn.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newloginbtn.ForeColor = Color.Transparent;
            newloginbtn.Location = new Point(400, 189);
            newloginbtn.Name = "newloginbtn";
            newloginbtn.Size = new Size(94, 42);
            newloginbtn.TabIndex = 5;
            newloginbtn.Text = "Login";
            newloginbtn.UseVisualStyleBackColor = false;
            newloginbtn.Click += newloginbtn_Click;
            // 
            // Recheckpassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(545, 254);
            Controls.Add(newloginbtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(resetbtn);
            Controls.Add(confirmpasswordtxt);
            Controls.Add(newpasswordtxt);
            Name = "Recheckpassword";
            StartPosition = FormStartPosition.CenterScreen;
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