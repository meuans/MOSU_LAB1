using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOSU_LAB1.Blocks
{
    public class LimitedIntBlock : BaseBlock
    {

        private double prevX = 0;

        private double dt;

        private double sum = 0;

        public double Min { get; set; }
        public double Max { get; set; }

        public  LimitedIntBlock(double dt)
        {

            this.dt = dt;

        }

        public LimitedIntBlock(double dt, double downLimit, double upLimit)
        {
            this.dt = dt;
            Max = upLimit;
            Min = downLimit;
           
          

        }

        public override double Calc(double x)
        {

            sum += (prevX + x) * dt / 2;
            sum = (sum > Max) ? Max : sum;
            sum = (sum < Min) ? Min : sum;

            prevX = x;

            return sum;

        }

    }
}
