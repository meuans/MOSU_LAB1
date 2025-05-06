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
        private Tank tank;
    
        

        public MainForm()
        {
            InitializeComponent();
            tank = new Tank(dt, 10, 1, 1, 1, -2);
           
        }

       

        private void bt_start_Click(object sender, EventArgs e)
        {
            modelTimer.Start();
            model_chart.Series[0].Points.Clear();   //чистимо графік
            time = 0;   
        }

        private void bt_stop_Click(object sender, EventArgs e)
        {
            modelTimer.Stop();
        }

        private void modelTimer_Tick(object sender, EventArgs e)
        {
           
            model_chart.Series[0].Points.AddXY(time, tank.Y);
            model_chart.Series[1].Points.AddXY(time, tank.X2);
            model_chart.Series[2].Points.AddXY(time, tank.X3);
            tank.Calc();
            time += dt;
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
            --tank.X2;
            tbx2.Text = tank.X2.ToString("F2");
        }

        private void btnUp2_Click(object sender, EventArgs e)
        {
            ++tank.X2;
            tbx2.Text = tank.X2.ToString("F2");
        }

        private void btnDn3_Click(object sender, EventArgs e)
        {
            --tank.X3;
            tbx3.Text = tank.X3.ToString("F2");

        }

        private void btnUp3_Click(object sender, EventArgs e)
        {
            ++tank.X3;
            tbx3.Text = tank.X3.ToString("F2");
        }

      
    }
}
