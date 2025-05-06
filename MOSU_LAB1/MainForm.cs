using MOSU_LAB1.Blocks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOSU_LAB1
{
    public partial class MainForm : Form
    {
        private double dt = 1;
      
        private ControlSystem controlSystem;

        public MainForm()
        {
            InitializeComponent();
            controlSystem = new ControlSystem(dt);

            controlSystem.Setpoint = 30;
            controlSystem.Kp= 0.7;
            controlSystem.Ti = 100;
            controlSystem.Kd = 0;

        }

       

        private void bt_start_Click(object sender, EventArgs e)
        {
            controlSystem.Time = 0;
            modelTimer.Start();
            model_chart.Series[0].Points.Clear();   //чистимо графік
            model_chart.Series[1].Points.Clear();
            model_chart.Series[2].Points.Clear();
            model_chart.Series[3].Points.Clear();

            tbSetPoint.Text = controlSystem.Setpoint.ToString("F2");
            tbKp.Text = controlSystem.Kp.ToString("F2");
            tbTi.Text = controlSystem.Ti.ToString("F2");
            tbKd.Text = controlSystem.Kd.ToString("F2");

        }

        private void bt_stop_Click(object sender, EventArgs e)
        {
            modelTimer.Stop();
        }

        private void modelTimer_Tick(object sender, EventArgs e)
        {
           
            model_chart.Series[0].Points.AddXY(controlSystem.Time, controlSystem.Output);
            model_chart.Series[1].Points.AddXY(controlSystem.Time, controlSystem.Input2);
            model_chart.Series[2].Points.AddXY(controlSystem.Time, controlSystem.Input3);
            model_chart.Series[3].Points.AddXY(controlSystem.Time, controlSystem.E);
            lbY.Text = "Y: "+controlSystem.Output.ToString("F2");
            tbx2.Text = controlSystem.Input2.ToString("F2");
            tbx3.Text = controlSystem.Input3.ToString("F2");
            controlSystem.Calc();
            
        }

        private void model_chart_Click(object sender, EventArgs e)
        {

        }

        private void btnSpeed_Click(object sender, EventArgs e)
        {
            if (modelTimer.Interval == 100)
            {
                modelTimer.Interval = 1000;
                btnSpeed.Text = "x10";
               
            }


            else
            {
                modelTimer.Interval = 100;
                btnSpeed.Text = "x1";
              

            }
        }

        private void btnDn2_Click(object sender, EventArgs e)
        {
            --controlSystem.Input2;
            tbx2.Text = controlSystem.Input2.ToString("F2");
        }

        private void btnUp2_Click(object sender, EventArgs e)
        {
            ++controlSystem.Input2;
            tbx2.Text = controlSystem.Input2.ToString("F2");
        }

        private void btnDn3_Click(object sender, EventArgs e)
        {
            --controlSystem.Input3;
            tbx3.Text = controlSystem.Input3.ToString("F2");

        }

        private void btnUp3_Click(object sender, EventArgs e)
        {
            ++controlSystem.Input3;
            tbx3.Text = controlSystem.Input3.ToString("F2");
        }

        private void tbSetPoint_TextChanged(object sender, EventArgs e)
        {
            double x;
            if (Double.TryParse(tbSetPoint.Text, out x))
            {
                controlSystem.Setpoint = x;
            }

        }

        private void tbKp_TextChanged(object sender, EventArgs e)
        {
            double x;
            if (Double.TryParse(tbKp.Text, out x))
            {
                controlSystem.Kp = x;
            }
        }

        private void tbTi_TextChanged(object sender, EventArgs e)
        {
            double x;
            if (Double.TryParse(tbTi.Text, out x))
            {
                controlSystem.Ti = x;
            }
        }

        private void tbKd_TextChanged(object sender, EventArgs e)
        {
            double x;
            if (Double.TryParse(tbKd.Text, out x))
            {
                controlSystem.Kd = x;
            }
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            controlSystem.ManualMode = !controlSystem.ManualMode;
            btnAuto.Text = controlSystem.ManualMode ? "Manual" : "Auto";

            tbKp.Text = controlSystem.Kp.ToString("F2");
            tbTi.Text = controlSystem.Ti.ToString("F2");
            tbKd.Text = controlSystem.Kd.ToString("F2");
        }
    }
}
