using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOSU_LAB1.Blocks
{
    public class PIDBlock : BaseBlock
    {
        private double prev = 0;
        private double dt;
       
        private double intSum = 0;
        private double ki = 0.000001; // підтримуючий елемент
        public double Kp { get; set; }

        public double K { get; set; } = 1; 
        public double Kd { get; set; } = 0;

        public double UpLimit { get; set; } = 100;
        public double DownLimit { get; set; } = 0;

        public bool ManualMode { get; set; } = false;
        public double UManual { get; set; }
       


        public double Ti
        {
            get { return 1 / ki; }
            set{
                if (value == 0) ki = double.MaxValue;
                else ki = 1 / value;
            }
        }

        public double Ki { get { return ki; } set { ki = value; } }

        public PIDBlock(double dt)
        {
            this.dt = dt;
        }

        public override double Calc(double x)
        {

            if (ManualMode)
            {
                intSum = (UManual - K * x - Kd * (x - prev) / dt) / ki; 
            }
            else
            {
                intSum += (prev + x) * dt / 2;
            }  

          

            var u = K * x + ki * intSum + Kd * (x - prev) / dt;
            var limited = false;
            if (u > UpLimit)
            {
                u = UpLimit;
                limited = true;
            }
            if (u < DownLimit)
            {
                u = DownLimit;
                limited = true;
            }
            if (ki != 0 && limited)
            {
                intSum = (u - K * x - Kd * (x - prev) / dt) / ki;
            }
            prev = x;

           

            return u;
        }
    }
}
