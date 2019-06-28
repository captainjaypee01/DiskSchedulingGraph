namespace DiskSchedulingGraph
{
    partial class Form1
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
            this.chartDisk = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.cb_diskSchedule = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_totalHead = new System.Windows.Forms.TextBox();
            this.txt_track8 = new System.Windows.Forms.TextBox();
            this.txt_track7 = new System.Windows.Forms.TextBox();
            this.txt_track6 = new System.Windows.Forms.TextBox();
            this.txt_track5 = new System.Windows.Forms.TextBox();
            this.txt_track4 = new System.Windows.Forms.TextBox();
            this.txt_track3 = new System.Windows.Forms.TextBox();
            this.txt_track2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_track1 = new System.Windows.Forms.TextBox();
            this.txt_headmovement = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartDisk)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartDisk
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDisk.ChartAreas.Add(chartArea1);
            this.chartDisk.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend1.Name = "Legend1";
            this.chartDisk.Legends.Add(legend1);
            this.chartDisk.Location = new System.Drawing.Point(0, 147);
            this.chartDisk.Name = "chartDisk";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "tracks";
            series1.YValuesPerPoint = 6;
            this.chartDisk.Series.Add(series1);
            this.chartDisk.Size = new System.Drawing.Size(831, 381);
            this.chartDisk.TabIndex = 0;
            this.chartDisk.Text = "chart1";
            this.chartDisk.Click += new System.EventHandler(this.Chart1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.cb_diskSchedule);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_totalHead);
            this.panel1.Controls.Add(this.txt_track8);
            this.panel1.Controls.Add(this.txt_track7);
            this.panel1.Controls.Add(this.txt_track6);
            this.panel1.Controls.Add(this.txt_track5);
            this.panel1.Controls.Add(this.txt_track4);
            this.panel1.Controls.Add(this.txt_track3);
            this.panel1.Controls.Add(this.txt_track2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_track1);
            this.panel1.Controls.Add(this.txt_headmovement);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(831, 141);
            this.panel1.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(71, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Disk Scheduling";
            // 
            // cb_diskSchedule
            // 
            this.cb_diskSchedule.FormattingEnabled = true;
            this.cb_diskSchedule.Items.AddRange(new object[] {
            "FCFS",
            "SSTF",
            "SCAN(UP)",
            "SCAN(DOWN)",
            "C-SCAN(UP)",
            "C-SCAN(DOWN)",
            "LOOK(UP)",
            "LOOK(DOWN)",
            "C-LOOK(UP)",
            "C-LOOK(DOWN)"});
            this.cb_diskSchedule.Location = new System.Drawing.Point(169, 25);
            this.cb_diskSchedule.Name = "cb_diskSchedule";
            this.cb_diskSchedule.Size = new System.Drawing.Size(100, 21);
            this.cb_diskSchedule.TabIndex = 13;
            this.cb_diskSchedule.SelectedIndexChanged += new System.EventHandler(this.Cb_diskSchedule_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(663, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "RESET";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(744, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "GENERATEE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(473, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(190, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "-------------------------------------------------------------";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(44, 119);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Total Head Movement";
            this.label12.Click += new System.EventHandler(this.Label10_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(660, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Track 8";
            this.label10.Click += new System.EventHandler(this.Label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(660, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Track 7";
            this.label9.Click += new System.EventHandler(this.Label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(482, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Track 6";
            this.label8.Click += new System.EventHandler(this.Label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(482, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Track 5";
            this.label7.Click += new System.EventHandler(this.Label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(482, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Track 4";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(298, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Track 3";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Track 2";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Track 1";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Starting Track";
            // 
            // txt_totalHead
            // 
            this.txt_totalHead.Enabled = false;
            this.txt_totalHead.Location = new System.Drawing.Point(169, 112);
            this.txt_totalHead.Name = "txt_totalHead";
            this.txt_totalHead.Size = new System.Drawing.Size(100, 20);
            this.txt_totalHead.TabIndex = 9;
            // 
            // txt_track8
            // 
            this.txt_track8.Location = new System.Drawing.Point(728, 52);
            this.txt_track8.Name = "txt_track8";
            this.txt_track8.Size = new System.Drawing.Size(100, 20);
            this.txt_track8.TabIndex = 9;
            // 
            // txt_track7
            // 
            this.txt_track7.Location = new System.Drawing.Point(728, 26);
            this.txt_track7.Name = "txt_track7";
            this.txt_track7.Size = new System.Drawing.Size(100, 20);
            this.txt_track7.TabIndex = 8;
            // 
            // txt_track6
            // 
            this.txt_track6.Location = new System.Drawing.Point(550, 77);
            this.txt_track6.Name = "txt_track6";
            this.txt_track6.Size = new System.Drawing.Size(100, 20);
            this.txt_track6.TabIndex = 7;
            // 
            // txt_track5
            // 
            this.txt_track5.Location = new System.Drawing.Point(550, 51);
            this.txt_track5.Name = "txt_track5";
            this.txt_track5.Size = new System.Drawing.Size(100, 20);
            this.txt_track5.TabIndex = 6;
            this.txt_track5.TextChanged += new System.EventHandler(this.Txt_track5_TextChanged);
            // 
            // txt_track4
            // 
            this.txt_track4.Location = new System.Drawing.Point(550, 25);
            this.txt_track4.Name = "txt_track4";
            this.txt_track4.Size = new System.Drawing.Size(100, 20);
            this.txt_track4.TabIndex = 5;
            // 
            // txt_track3
            // 
            this.txt_track3.Location = new System.Drawing.Point(366, 77);
            this.txt_track3.Name = "txt_track3";
            this.txt_track3.Size = new System.Drawing.Size(100, 20);
            this.txt_track3.TabIndex = 4;
            // 
            // txt_track2
            // 
            this.txt_track2.Location = new System.Drawing.Point(366, 51);
            this.txt_track2.Name = "txt_track2";
            this.txt_track2.Size = new System.Drawing.Size(100, 20);
            this.txt_track2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "-------------------------------------------------------------";
            // 
            // txt_track1
            // 
            this.txt_track1.Location = new System.Drawing.Point(366, 25);
            this.txt_track1.Name = "txt_track1";
            this.txt_track1.Size = new System.Drawing.Size(100, 20);
            this.txt_track1.TabIndex = 1;
            // 
            // txt_headmovement
            // 
            this.txt_headmovement.Location = new System.Drawing.Point(169, 62);
            this.txt_headmovement.Name = "txt_headmovement";
            this.txt_headmovement.Size = new System.Drawing.Size(100, 20);
            this.txt_headmovement.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 528);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chartDisk);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chartDisk)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartDisk;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_track8;
        private System.Windows.Forms.TextBox txt_track7;
        private System.Windows.Forms.TextBox txt_track6;
        private System.Windows.Forms.TextBox txt_track5;
        private System.Windows.Forms.TextBox txt_track4;
        private System.Windows.Forms.TextBox txt_track3;
        private System.Windows.Forms.TextBox txt_track2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_track1;
        private System.Windows.Forms.TextBox txt_headmovement;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_totalHead;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cb_diskSchedule;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

