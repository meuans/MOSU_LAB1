using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOSU_LAB1.Blocks
{
     

    public class DiffBlock : BaseBlock
    {
        private double prevX;
        private double dt;

        public DiffBlock(double dt)
        {
            this.dt = dt;
        }

        public override double Calc(double x)
        {
            var y = (x - prevX) / dt;
            prevX = x;
            return y;
        }
    }
}
