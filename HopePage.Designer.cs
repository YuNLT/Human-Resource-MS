namespace Human_Resource_MS
{
    partial class HopePage
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
            panel1 = new Panel();
            logoutbtn = new Button();
            reportsbtn = new Button();
            depmsbtn = new Button();
            salarymsbtn = new Button();
            empmsbtn = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(logoutbtn);
            panel1.Controls.Add(reportsbtn);
            panel1.Controls.Add(depmsbtn);
            panel1.Controls.Add(salarymsbtn);
            panel1.Controls.Add(empmsbtn);
            panel1.Location = new Point(28, 38);
            panel1.Name = "panel1";
            panel1.Size = new Size(376, 474);
            panel1.TabIndex = 0;
            // 
            // logoutbtn
            // 
            logoutbtn.BackColor = SystemColors.ActiveCaption;
            logoutbtn.Location = new Point(188, 362);
            logoutbtn.Name = "logoutbtn";
            logoutbtn.Size = new Size(132, 52);
            logoutbtn.TabIndex = 4;
            logoutbtn.Text = "Log Out";
            logoutbtn.UseVisualStyleBackColor = false;
            logoutbtn.Click += logoutbtn_Click;
            // 
            // reportsbtn
            // 
            reportsbtn.BackColor = SystemColors.ActiveCaption;
            reportsbtn.Location = new Point(29, 266);
            reportsbtn.Name = "reportsbtn";
            reportsbtn.Size = new Size(291, 52);
            reportsbtn.TabIndex = 3;
            reportsbtn.Text = "Reports";
            reportsbtn.UseVisualStyleBackColor = false;
            reportsbtn.Click += reportsbtn_Click;
            // 
            // depmsbtn
            // 
            depmsbtn.BackColor = SystemColors.ActiveCaption;
            depmsbtn.Location = new Point(29, 181);
            depmsbtn.Name = "depmsbtn";
            depmsbtn.Size = new Size(291, 52);
            depmsbtn.TabIndex = 2;
            depmsbtn.Text = "Department Management";
            depmsbtn.UseVisualStyleBackColor = false;
            depmsbtn.Click += depmsbtn_Click;
            // 
            // salarymsbtn
            // 
            salarymsbtn.BackColor = SystemColors.ActiveCaption;
            salarymsbtn.Location = new Point(29, 102);
            salarymsbtn.Name = "salarymsbtn";
            salarymsbtn.Size = new Size(291, 52);
            salarymsbtn.TabIndex = 1;
            salarymsbtn.Text = "Salary Management";
            salarymsbtn.UseVisualStyleBackColor = false;
            salarymsbtn.Click += salarymsbtn_Click;
            // 
            // empmsbtn
            // 
            empmsbtn.BackColor = SystemColors.ActiveCaption;
            empmsbtn.Location = new Point(29, 24);
            empmsbtn.Name = "empmsbtn";
            empmsbtn.Size = new Size(291, 52);
            empmsbtn.TabIndex = 0;
            empmsbtn.Text = "Employee Management";
            empmsbtn.UseVisualStyleBackColor = false;
            empmsbtn.Click += empmsbtn_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.FromArgb(255, 128, 128);
            flowLayoutPanel1.Location = new Point(430, 38);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(408, 474);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // HopePage
            // 
            AutoScaleDimensions = new SizeF(13F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(877, 555);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "HopePage";
            Text = "HopePage";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button empmsbtn;
        private Button logoutbtn;
        private Button reportsbtn;
        private Button depmsbtn;
        private Button salarymsbtn;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}