using MOSU_LAB1.Blocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOSU_LAB1
{
   public class Tank
   {
        private double dt = 1;
        private ComplexBlock tank;
        private LimitBlock xlimit = new LimitBlock(0, 100);
        
        private double y = 0;


        private double x2 = 0; //input2
        private double x3 = 0; //input3

        public double Y { get { return y; } }
        public double X2 { get { return x2; } set { x2 = xlimit.Calc(value); } }
        public double X3 { get { return x3; } set { x3 = xlimit.Calc(value); } }

        private double t = 1;
        public double T
        {
            get { return t; }
            set
            {
                if (value == 0) throw new Exception("T cant be 0");
                t = value;
            }
        }

        public double K1 { get; set; }
        public double K2 { get; set; }
        public double K3 { get; set; }
        public double K4 { get; set; }

        public Tank(double dt)
        {
            this.dt = dt;
            tank = new ComplexBlock();
            tank.Add(new DelayBlock(dt, 1)); //запізнення
            tank.Add(new GainBlock(1 / T));// підсилення 
            tank.Add(new LimitedIntBlock(dt, 0, 100)); //інтегрування
            tank.Add(new NoiseBlock(5));
           
        }
         
        public double Calc()
        {
         
            y = tank.Calc(x2 + x3);
          
            return y;
        }


    }
}
