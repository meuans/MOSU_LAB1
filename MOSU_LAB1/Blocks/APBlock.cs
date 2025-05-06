using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOSU_LAB1.Blocks
{
    public class APBlock : BaseBlock
    {

        private double dt;

        private double T;

        private double prevX;

        public APBlock(double dt, double T)
        {

            this.dt = dt;

            this.T = T;

        }

        public override double Calc(double x)
        {

            var y = (dt * x + T * prevX) / (T + dt);

            prevX = y;

            return y;

        }

    }
}
