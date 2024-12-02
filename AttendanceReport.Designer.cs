namespace Human_Resource_MS
{
    partial class AttendanceReport
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            label1 = new Label();
            startdatedtp = new DateTimePicker();
            generatebtn = new Button();
            attendancereportdg = new DataGridView();
            attendancechart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            exportbtn = new Button();
            label2 = new Label();
            enddatedtp = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)attendancereportdg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)attendancechart).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 48);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(91, 23);
            label1.TabIndex = 0;
            label1.Text = "Start date";
            // 
            // startdatedtp
            // 
            startdatedtp.Location = new Point(177, 48);
            startdatedtp.Name = "startdatedtp";
            startdatedtp.Size = new Size(250, 30);
            startdatedtp.TabIndex = 1;
            // 
            // generatebtn
            // 
            generatebtn.Cursor = Cursors.Hand;
            generatebtn.Location = new Point(970, 33);
            generatebtn.Name = "generatebtn";
            generatebtn.Size = new Size(95, 45);
            generatebtn.TabIndex = 2;
            generatebtn.Text = "Generate";
            generatebtn.UseVisualStyleBackColor = true;
            generatebtn.Click += generatebtn_Click;
            // 
            // attendancereportdg
            // 
            attendancereportdg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            attendancereportdg.Location = new Point(64, 172);
            attendancereportdg.Name = "attendancereportdg";
            attendancereportdg.RowHeadersWidth = 51;
            attendancereportdg.Size = new Size(557, 394);
            attendancereportdg.TabIndex = 3;
            // 
            // attendancechart
            // 
            chartArea1.Name = "ChartArea1";
            attendancechart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            attendancechart.Legends.Add(legend1);
            attendancechart.Location = new Point(692, 172);
            attendancechart.Name = "attendancechart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            attendancechart.Series.Add(series1);
            attendancechart.Size = new Size(400, 395);
            attendancechart.TabIndex = 4;
            attendancechart.Text = "chart1";
            // 
            // exportbtn
            // 
            exportbtn.Location = new Point(970, 97);
            exportbtn.Name = "exportbtn";
            exportbtn.Size = new Size(108, 45);
            exportbtn.TabIndex = 5;
            exportbtn.Text = "Export";
            exportbtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(520, 47);
            label2.Name = "label2";
            label2.Size = new Size(83, 23);
            label2.TabIndex = 6;
            label2.Text = "End Date";
            // 
            // enddatedtp
            // 
            enddatedtp.Location = new Point(652, 48);
            enddatedtp.Name = "enddatedtp";
            enddatedtp.Size = new Size(250, 30);
            enddatedtp.TabIndex = 7;
            // 
            // AttendanceReport
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1140, 579);
            Controls.Add(enddatedtp);
            Controls.Add(label2);
            Controls.Add(exportbtn);
            Controls.Add(attendancechart);
            Controls.Add(attendancereportdg);
            Controls.Add(generatebtn);
            Controls.Add(startdatedtp);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "AttendanceReport";
            Text = "AttendanceReport";
            ((System.ComponentModel.ISupportInitialize)attendancereportdg).EndInit();
            ((System.ComponentModel.ISupportInitialize)attendancechart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker startdatedtp;
        private Button generatebtn;
        private DataGridView attendancereportdg;
        private System.Windows.Forms.DataVisualization.Charting.Chart attendancechart;
        private Button exportbtn;
        private Label label2;
        private DateTimePicker enddatedtp;
    }
}