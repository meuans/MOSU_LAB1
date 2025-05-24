namespace MOSU_LAB1
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.modelTimer = new System.Windows.Forms.Timer(this.components);
            this.bt_start = new System.Windows.Forms.Button();
            this.bt_stop = new System.Windows.Forms.Button();
            this.model_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnSpeed = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUp2 = new System.Windows.Forms.Button();
            this.btnDn2 = new System.Windows.Forms.Button();
            this.tbx2 = new System.Windows.Forms.TextBox();
            this.tbx3 = new System.Windows.Forms.TextBox();
            this.btnDn3 = new System.Windows.Forms.Button();
            this.btnUp3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbSetPoint = new System.Windows.Forms.Label();
            this.lbKd = new System.Windows.Forms.Label();
            this.lbTi = new System.Windows.Forms.Label();
            this.lbKp = new System.Windows.Forms.Label();
            this.tbSetPoint = new System.Windows.Forms.TextBox();
            this.tbKd = new System.Windows.Forms.TextBox();
            this.tbTi = new System.Windows.Forms.TextBox();
            this.tbKp = new System.Windows.Forms.TextBox();
            this.lbY = new System.Windows.Forms.Label();
            this.btnAuto = new System.Windows.Forms.Button();
            this.btnOptimize = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.model_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // modelTimer
            // 
            this.modelTimer.Interval = 1000;
            this.modelTimer.Tick += new System.EventHandler(this.modelTimer_Tick);
            // 
            // bt_start
            // 
            this.bt_start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bt_start.Location = new System.Drawing.Point(26, 878);
            this.bt_start.Name = "bt_start";
            this.bt_start.Size = new System.Drawing.Size(79, 32);
            this.bt_start.TabIndex = 0;
            this.bt_start.Text = "START";
            this.bt_start.UseVisualStyleBackColor = true;
            this.bt_start.Click += new System.EventHandler(this.bt_start_Click);
            // 
            // bt_stop
            // 
            this.bt_stop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_stop.Location = new System.Drawing.Point(920, 878);
            this.bt_stop.Name = "bt_stop";
            this.bt_stop.Size = new System.Drawing.Size(79, 32);
            this.bt_stop.TabIndex = 1;
            this.bt_stop.Text = "STOP";
            this.bt_stop.UseVisualStyleBackColor = true;
            this.bt_stop.Click += new System.EventHandler(this.bt_stop_Click);
            // 
            // model_chart
            // 
            this.model_chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.model_chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.model_chart.Legends.Add(legend1);
            this.model_chart.Location = new System.Drawing.Point(12, 413);
            this.model_chart.Name = "model_chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.LegendText = "Рівень";
            series1.Name = "Level";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.LegendText = "x2";
            series2.Name = "x2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.LegendText = "x3";
            series3.Name = "x3";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "E";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Legend = "Legend1";
            series5.Name = "Before";
            series5.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Legend = "Legend1";
            series6.Name = "After";
            series6.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.model_chart.Series.Add(series1);
            this.model_chart.Series.Add(series2);
            this.model_chart.Series.Add(series3);
            this.model_chart.Series.Add(series4);
            this.model_chart.Series.Add(series5);
            this.model_chart.Series.Add(series6);
            this.model_chart.Size = new System.Drawing.Size(978, 459);
            this.model_chart.TabIndex = 2;
            this.model_chart.Text = "chart1";
            this.model_chart.Click += new System.EventHandler(this.model_chart_Click);
            // 
            // btnSpeed
            // 
            this.btnSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSpeed.Location = new System.Drawing.Point(143, 878);
            this.btnSpeed.Name = "btnSpeed";
            this.btnSpeed.Size = new System.Drawing.Size(55, 32);
            this.btnSpeed.TabIndex = 3;
            this.btnSpeed.Text = "x10";
            this.btnSpeed.UseVisualStyleBackColor = true;
            this.btnSpeed.Click += new System.EventHandler(this.btnSpeed_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MOSU_LAB1.Properties.Resources.Знімок_екрана_2025_03_28_140547;
            this.pictureBox1.Location = new System.Drawing.Point(581, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(373, 268);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnUp2
            // 
            this.btnUp2.Location = new System.Drawing.Point(534, 153);
            this.btnUp2.Name = "btnUp2";
            this.btnUp2.Size = new System.Drawing.Size(44, 32);
            this.btnUp2.TabIndex = 5;
            this.btnUp2.Text = "+";
            this.btnUp2.UseVisualStyleBackColor = true;
            this.btnUp2.Click += new System.EventHandler(this.btnUp2_Click);
            // 
            // btnDn2
            // 
            this.btnDn2.Location = new System.Drawing.Point(376, 153);
            this.btnDn2.Name = "btnDn2";
            this.btnDn2.Size = new System.Drawing.Size(44, 32);
            this.btnDn2.TabIndex = 6;
            this.btnDn2.Text = "-";
            this.btnDn2.UseVisualStyleBackColor = true;
            this.btnDn2.Click += new System.EventHandler(this.btnDn2_Click);
            // 
            // tbx2
            // 
            this.tbx2.Location = new System.Drawing.Point(428, 153);
            this.tbx2.Name = "tbx2";
            this.tbx2.Size = new System.Drawing.Size(100, 26);
            this.tbx2.TabIndex = 7;
            // 
            // tbx3
            // 
            this.tbx3.Location = new System.Drawing.Point(747, 349);
            this.tbx3.Name = "tbx3";
            this.tbx3.Size = new System.Drawing.Size(100, 26);
            this.tbx3.TabIndex = 10;
            // 
            // btnDn3
            // 
            this.btnDn3.Location = new System.Drawing.Point(695, 346);
            this.btnDn3.Name = "btnDn3";
            this.btnDn3.Size = new System.Drawing.Size(44, 32);
            this.btnDn3.TabIndex = 9;
            this.btnDn3.Text = "-";
            this.btnDn3.UseVisualStyleBackColor = true;
            this.btnDn3.Click += new System.EventHandler(this.btnDn3_Click);
            // 
            // btnUp3
            // 
            this.btnUp3.Location = new System.Drawing.Point(853, 346);
            this.btnUp3.Name = "btnUp3";
            this.btnUp3.Size = new System.Drawing.Size(44, 32);
            this.btnUp3.TabIndex = 8;
            this.btnUp3.Text = "+";
            this.btnUp3.UseVisualStyleBackColor = true;
            this.btnUp3.Click += new System.EventHandler(this.btnUp3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(463, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "x2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(783, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "x3";
            // 
            // lbSetPoint
            // 
            this.lbSetPoint.AutoSize = true;
            this.lbSetPoint.Location = new System.Drawing.Point(22, 51);
            this.lbSetPoint.Name = "lbSetPoint";
            this.lbSetPoint.Size = new System.Drawing.Size(70, 20);
            this.lbSetPoint.TabIndex = 13;
            this.lbSetPoint.Text = "SetPoint";
            // 
            // lbKd
            // 
            this.lbKd.AutoSize = true;
            this.lbKd.Location = new System.Drawing.Point(64, 217);
            this.lbKd.Name = "lbKd";
            this.lbKd.Size = new System.Drawing.Size(28, 20);
            this.lbKd.TabIndex = 14;
            this.lbKd.Text = "Kd";
            // 
            // lbTi
            // 
            this.lbTi.AutoSize = true;
            this.lbTi.Location = new System.Drawing.Point(71, 161);
            this.lbTi.Name = "lbTi";
            this.lbTi.Size = new System.Drawing.Size(21, 20);
            this.lbTi.TabIndex = 15;
            this.lbTi.Text = "Ti";
            // 
            // lbKp
            // 
            this.lbKp.AutoSize = true;
            this.lbKp.Location = new System.Drawing.Point(64, 104);
            this.lbKp.Name = "lbKp";
            this.lbKp.Size = new System.Drawing.Size(28, 20);
            this.lbKp.TabIndex = 16;
            this.lbKp.Text = "Kp";
            // 
            // tbSetPoint
            // 
            this.tbSetPoint.Location = new System.Drawing.Point(98, 51);
            this.tbSetPoint.Name = "tbSetPoint";
            this.tbSetPoint.Size = new System.Drawing.Size(100, 26);
            this.tbSetPoint.TabIndex = 17;
            this.tbSetPoint.TextChanged += new System.EventHandler(this.tbSetPoint_TextChanged);
            // 
            // tbKd
            // 
            this.tbKd.Location = new System.Drawing.Point(98, 217);
            this.tbKd.Name = "tbKd";
            this.tbKd.Size = new System.Drawing.Size(100, 26);
            this.tbKd.TabIndex = 18;
            this.tbKd.TextChanged += new System.EventHandler(this.tbKd_TextChanged);
            // 
            // tbTi
            // 
            this.tbTi.Location = new System.Drawing.Point(98, 158);
            this.tbTi.Name = "tbTi";
            this.tbTi.Size = new System.Drawing.Size(100, 26);
            this.tbTi.TabIndex = 19;
            this.tbTi.TextChanged += new System.EventHandler(this.tbTi_TextChanged);
            // 
            // tbKp
            // 
            this.tbKp.Location = new System.Drawing.Point(98, 104);
            this.tbKp.Name = "tbKp";
            this.tbKp.Size = new System.Drawing.Size(100, 26);
            this.tbKp.TabIndex = 20;
            this.tbKp.TextChanged += new System.EventHandler(this.tbKp_TextChanged);
            // 
            // lbY
            // 
            this.lbY.AutoSize = true;
            this.lbY.Location = new System.Drawing.Point(441, 39);
            this.lbY.Name = "lbY";
            this.lbY.Size = new System.Drawing.Size(50, 20);
            this.lbY.TabIndex = 21;
            this.lbY.Text = "Y: 0.0";
            // 
            // btnAuto
            // 
            this.btnAuto.Location = new System.Drawing.Point(98, 301);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(100, 31);
            this.btnAuto.TabIndex = 22;
            this.btnAuto.Text = "Auto";
            this.btnAuto.UseVisualStyleBackColor = true;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // btnOptimize
            // 
            this.btnOptimize.Location = new System.Drawing.Point(230, 300);
            this.btnOptimize.Name = "btnOptimize";
            this.btnOptimize.Size = new System.Drawing.Size(90, 32);
            this.btnOptimize.TabIndex = 23;
            this.btnOptimize.Text = "Optimize";
            this.btnOptimize.UseVisualStyleBackColor = true;
            this.btnOptimize.Click += new System.EventHandler(this.btnOptimize_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 1062);
            this.Controls.Add(this.btnOptimize);
            this.Controls.Add(this.btnAuto);
            this.Controls.Add(this.lbY);
            this.Controls.Add(this.tbKp);
            this.Controls.Add(this.tbTi);
            this.Controls.Add(this.tbKd);
            this.Controls.Add(this.tbSetPoint);
            this.Controls.Add(this.lbKp);
            this.Controls.Add(this.lbTi);
            this.Controls.Add(this.lbKd);
            this.Controls.Add(this.lbSetPoint);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx3);
            this.Controls.Add(this.btnDn3);
            this.Controls.Add(this.btnUp3);
            this.Controls.Add(this.tbx2);
            this.Controls.Add(this.btnDn2);
            this.Controls.Add(this.btnUp2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSpeed);
            this.Controls.Add(this.model_chart);
            this.Controls.Add(this.bt_stop);
            this.Controls.Add(this.bt_start);
            this.Name = "MainForm";
            this.Text = "Trunk";
            ((System.ComponentModel.ISupportInitialize)(this.model_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer modelTimer;
        private System.Windows.Forms.Button bt_start;
        private System.Windows.Forms.Button bt_stop;
        private System.Windows.Forms.DataVisualization.Charting.Chart model_chart;
        private System.Windows.Forms.Button btnSpeed;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnUp2;
        private System.Windows.Forms.Button btnDn2;
        private System.Windows.Forms.TextBox tbx2;
        private System.Windows.Forms.TextBox tbx3;
        private System.Windows.Forms.Button btnDn3;
        private System.Windows.Forms.Button btnUp3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbSetPoint;
        private System.Windows.Forms.Label lbKd;
        private System.Windows.Forms.Label lbTi;
        private System.Windows.Forms.Label lbKp;
        private System.Windows.Forms.TextBox tbSetPoint;
        private System.Windows.Forms.TextBox tbKd;
        private System.Windows.Forms.TextBox tbTi;
        private System.Windows.Forms.TextBox tbKp;
        private System.Windows.Forms.Label lbY;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.Button btnOptimize;
    }
}

