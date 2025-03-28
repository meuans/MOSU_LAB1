using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOSU_LAB1.Blocks
{
    public class LimitedIntBlock : BaseBlock
    {

        private double prev = 0;

        private double dt;

        private double sum = 0;

        public double Min { get; set; }
        public double Max { get; set; }

        public  LimitedIntBlock(double dt)
        {

            this.dt = dt;

        }

        public LimitedIntBlock(double dt, double min, double max)
        {
            Min = min;
            Max = max;
            this.dt = dt;

        }

        public override double Calc(double x)
        {

            sum += (prev + x) * dt / 2;
            sum = (sum > Max) ? Max : sum;
            sum = (sum < Min) ? Min : sum;

            prev = x;

            return sum;

        }

    }
}
