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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
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
            this.bt_start.Location = new System.Drawing.Point(24, 696);
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
            this.bt_stop.Location = new System.Drawing.Point(911, 696);
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
            chartArea2.Name = "ChartArea1";
            this.model_chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.model_chart.Legends.Add(legend2);
            this.model_chart.Location = new System.Drawing.Point(12, 413);
            this.model_chart.Name = "model_chart";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.LegendText = "Рівень";
            series4.Name = "Level";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.LegendText = "x2";
            series5.Name = "x2";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.LegendText = "x3";
            series6.Name = "x3";
            this.model_chart.Series.Add(series4);
            this.model_chart.Series.Add(series5);
            this.model_chart.Series.Add(series6);
            this.model_chart.Size = new System.Drawing.Size(978, 277);
            this.model_chart.TabIndex = 2;
            this.model_chart.Text = "chart1";
            this.model_chart.Click += new System.EventHandler(this.model_chart_Click);
            // 
            // btnSpeed
            // 
            this.btnSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSpeed.Location = new System.Drawing.Point(120, 696);
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
            this.pictureBox1.Location = new System.Drawing.Point(217, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(373, 268);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnUp2
            // 
            this.btnUp2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUp2.Location = new System.Drawing.Point(170, 176);
            this.btnUp2.Name = "btnUp2";
            this.btnUp2.Size = new System.Drawing.Size(44, 32);
            this.btnUp2.TabIndex = 5;
            this.btnUp2.Text = "+";
            this.btnUp2.UseVisualStyleBackColor = true;
            this.btnUp2.Click += new System.EventHandler(this.btnUp2_Click);
            // 
            // btnDn2
            // 
            this.btnDn2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDn2.Location = new System.Drawing.Point(12, 176);
            this.btnDn2.Name = "btnDn2";
            this.btnDn2.Size = new System.Drawing.Size(44, 32);
            this.btnDn2.TabIndex = 6;
            this.btnDn2.Text = "-";
            this.btnDn2.UseVisualStyleBackColor = true;
            this.btnDn2.Click += new System.EventHandler(this.btnDn2_Click);
            // 
            // tbx2
            // 
            this.tbx2.Location = new System.Drawing.Point(64, 176);
            this.tbx2.Name = "tbx2";
            this.tbx2.Size = new System.Drawing.Size(100, 26);
            this.tbx2.TabIndex = 7;
            // 
            // tbx3
            // 
            this.tbx3.Location = new System.Drawing.Point(383, 372);
            this.tbx3.Name = "tbx3";
            this.tbx3.Size = new System.Drawing.Size(100, 26);
            this.tbx3.TabIndex = 10;
            // 
            // btnDn3
            // 
            this.btnDn3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDn3.Location = new System.Drawing.Point(331, 369);
            this.btnDn3.Name = "btnDn3";
            this.btnDn3.Size = new System.Drawing.Size(44, 32);
            this.btnDn3.TabIndex = 9;
            this.btnDn3.Text = "-";
            this.btnDn3.UseVisualStyleBackColor = true;
            this.btnDn3.Click += new System.EventHandler(this.btnDn3_Click);
            // 
            // btnUp3
            // 
            this.btnUp3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUp3.Location = new System.Drawing.Point(489, 369);
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
            this.label1.Location = new System.Drawing.Point(99, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "x2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(419, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "x3";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 754);
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
    }
}

