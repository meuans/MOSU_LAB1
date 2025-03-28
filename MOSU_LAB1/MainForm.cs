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
        private ComplexBlock boiler;
        private double time = 0;
        private double y = 0;

        public MainForm()
        {
            InitializeComponent();
            boiler = new ComplexBlock();
            boiler.Add(new DelayBlock(dt,2)); //запізнення
            boiler.Add(new GainBlock(5));// підсилення 
            boiler.Add(new APBlock(dt, 10));
            boiler.Add(new APBlock(dt, 10));
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
           
            model_chart.Series[0].Points.AddXY(time, y);
            y = boiler.Calc(1);
            time += dt;
        }

        private void model_chart_Click(object sender, EventArgs e)
        {

        }
    }
}
