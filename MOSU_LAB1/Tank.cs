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

        private GainBlock gain1;
        private GainBlock gain2;
        private GainBlock gain3;
        private GainBlock gain4;

        private double Gin = 0;
        private double Gout = 4;

        public double Y { get { return y; } }
        public double X2 { get { return x2; } set { x2 = xlimit.Calc(value); } }
        public double X3 { get { return x3; } set { x3 = xlimit.Calc(value); } }

        public double GIN { get { return Gin; } set { Gin = xlimit.Calc(value); } }
        public double GOUT { get { return Gout; } set { Gout = xlimit.Calc(value); } }


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

        public Tank(double dt, double t, double K1, double K2, double K3, double K4)
        {
            this.dt = dt;
            tank = new ComplexBlock();
            tank.Add(new DelayBlock(dt, 1)); //запізнення
            tank.Add(new GainBlock(1 / T));// підсилення 
            tank.Add(new LimitedIntBlock(dt, 0, 100)); //інтегрування
            tank.Add(new NoiseBlock(5));

            gain1 = new GainBlock(K1);
            gain2 = new GainBlock(K2);
            gain3 = new GainBlock(K3);
            gain4 = new GainBlock(K4);

         }
         
        public double Calc()
        {
         
            y = tank.Calc(gain1.Calc(Gin) + gain2.Calc(x2) + gain3.Calc(x3) + gain4.Calc(Gout));
          
            return y;
        }


    }
}
