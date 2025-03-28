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
            this.modelTimer = new System.Windows.Forms.Timer(this.components);
            this.bt_start = new System.Windows.Forms.Button();
            this.bt_stop = new System.Windows.Forms.Button();
            this.model_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.model_chart)).BeginInit();
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
            this.bt_start.Location = new System.Drawing.Point(24, 608);
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
            this.bt_stop.Location = new System.Drawing.Point(822, 608);
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
            this.model_chart.Location = new System.Drawing.Point(12, 286);
            this.model_chart.Name = "model_chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Temp";
            this.model_chart.Series.Add(series1);
            this.model_chart.Size = new System.Drawing.Size(884, 300);
            this.model_chart.TabIndex = 2;
            this.model_chart.Text = "chart1";
            this.model_chart.Click += new System.EventHandler(this.model_chart_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 666);
            this.Controls.Add(this.model_chart);
            this.Controls.Add(this.bt_stop);
            this.Controls.Add(this.bt_start);
            this.Name = "MainForm";
            this.Text = "Model";
            ((System.ComponentModel.ISupportInitialize)(this.model_chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer modelTimer;
        private System.Windows.Forms.Button bt_start;
        private System.Windows.Forms.Button bt_stop;
        private System.Windows.Forms.DataVisualization.Charting.Chart model_chart;
    }
}

