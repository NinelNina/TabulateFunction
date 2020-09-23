using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TabulateFunction
{
    class Solution
    {
        public double Calculate(double X0, double XN, double HX,  bool minimum, bool maximum, bool average)
        {
            double yMax = -10000;
            double yMin = 10000;
            double count = (XN - X0 + 1) / HX;
            double sum = 0;
            double avg = 0;

            if (minimum)
            {
                for (double i = X0; i <= XN; i += HX)
                {
                    if (Function(i) < yMin)
                    {
                        yMin = Function(i);
                    }
                }

                return yMin;
            }
            else if (maximum)
            {
                for (double i = X0; i <= XN; i += HX)
                {
                    if (Function(i) > yMax)
                    {
                        yMax = Function(i);
                    }
                }

                return yMax;
            }
            else
            {
                
                for (double i = X0; i <= XN; i += HX) 
                { 
                    sum += Function(i);
                }
                avg = sum / count;

                return avg;
            }
        }

        private double Function(double x) 
        {
            return 2*(x*x-25)*(x*x - 25) + 10;
        }
    }
}
