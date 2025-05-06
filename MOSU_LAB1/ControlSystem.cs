using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MOSU_LAB1.Blocks
{
    public class ControlSystem
    {
        private double dt; // період дискретизації 

        private Tank tank;
        private PIDBlock pid;

        private LimitBlock xLimit = new LimitBlock(0, 100);
        private LimitBlock levelLimit = new LimitBlock(0, 10);

        public ControlSystem(double dt) { 
            this.dt = dt;
            tank = new Tank (dt, 10, 1, 1, 1, -10); //dt, t, K1, K2, K3, K4
            pid = new PIDBlock(dt);


        }

        public double Time { get; set; } = 0;


        public double Input2 { get { return tank.X2; } set { tank.X2 = value; } }
        public double Input3 { get { return tank.X3; } set { tank.X3 = value; } }

        public double Output { get{ return tank.Y; } }

        public double Kp { get { return pid.Kp; } set { pid.Kp = value; } }
        public double Ki { get { return pid.Ki; } set { pid.Ki = value; } } 
        public double Kd { get { return pid.Kd; } set { pid.Kd = value; } }
        public double Ti { get { return pid.Ti; } set { pid.Ti = value; } }

      

        public double E;//змінна розбалансу 

        public double Setpoint { get; set; }
        public bool ManualMode { get { return pid.ManualMode; } set { pid.ManualMode = value; } }
        public double Calc()
        {
           var z = tank.Calc();
           E = Setpoint - z;
           var u = pid.Calc(E);
            if (!ManualMode) 
            {
                Input2 = u; // Автоматичний режим: регулятор керує
            }
            else 
            {
                pid.UManual = Input2; // Ручний режим  людина керує, регулятор "підлаштовується"
            }

             Time += dt;

            return Output;
        }
    }
}
