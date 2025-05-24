﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOSU_LAB1
{
    public static class Optimizer
    {


        public static string PointToString(double[] point, String caption = "")
        {
            string s = "";
            if (!String.IsNullOrEmpty(caption))
            {
                s += caption + " ";
            }
            for (int i = 0; i < point.Length; i++)
            {
                s += $"u[{i}]={point[i]} ";
            }
            return s;
        }
        public static void PrintPoint(double[] point, String caption = "")
        {
            if (!String.IsNullOrEmpty(caption))
            {
                Console.Write(caption + " ");
            }
            for (int i = 0; i < point.Length; i++)
            {
                Console.Write($"u[{i}]={point[i]} ");
            }
            Console.WriteLine();
        }

        public static int HookeJeeves(Func<double[], double> f, ref double[] point, double h = 10, double eps = 0.01, int maxStep = 1000)
        {
            int step = 0;
            double[] xb = (double[])point.Clone(), x1, xob;
            double fb = f(xb), f0, f1 = 0;

            do
            {
                f0 = fb;
                point = (double[])xb.Clone();
                x1 = (double[])point.Clone();

                for (int i = 0; i < point.Length; i++)
                {
                    x1[i] = point[i] + h;
                    f1 = f(x1);
                    if (f1 < f0)
                    {
                        point = (double[])x1.Clone();
                        f0 = f1;
                    }
                    else
                    {
                        x1[i] = point[i] - h;
                        f1 = f(x1);
                        if (f1 < f0)
                        {
                            point = (double[])x1.Clone();
                            f0 = f1;
                        }
                    }
                }

                if (f0 < fb)
                {
                    xob = (double[])xb.Clone();
                    for (int i = 0; i < point.Length; i++)
                    {
                        xb[i] = xob[i] + 2 * (point[i] - xob[i]);
                    }
                    fb = f(xb);
                    if (f0 < fb) h /= 10;
                }
                else
                {
                    h /= 10;
                }

                step++;
            }
            while (h > eps && step < maxStep);

            point = (double[])xb.Clone();
            return step;
        }
    }
}
