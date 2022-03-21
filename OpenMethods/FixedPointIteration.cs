﻿using System;
using Utils;

namespace OpenMethods
{
    public class FixedPointIterationService : Functions 
    {
        private double xr;
        private double xrold;
        private double ea;

        private double G(double x)
        {
            return Math.Pow(Math.E, -x);
        }

        public double Fixpt(double x0, double es, int imax)
        {
            Console.WriteLine($" i  |   Xi   |   Ea\n");

            xr = x0;
            for (int i = 0; i <= imax; i++)
            {
                xrold = xr;
                xr = Round(G(xrold),6);
                
                if (xr != 0)
                {
                    ea = Round(ApproximateError(xr,  xrold), 6);
                }

                Console.WriteLine($"  {i}   |   {xr}   |   {ea}\n");

                if (ea < es)
                {
                    break;
                }
            }
            return xr;
        }
    }
}