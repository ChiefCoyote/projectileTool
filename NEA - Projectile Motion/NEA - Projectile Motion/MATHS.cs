using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEA___Projectile_Motion
{
    static class MATHS
    {
        public static double PI = Getpi();

        public static double power(double x ,int y)
        {
            if (y == 1)
            {
                return x;
            }
            else if (y == 0)
            {
                return 1;
            }
            else if (y < 0)
            {
                return 1 / power(x, (y * -1));
            }
            else
            {
                return x * power(x, y - 1);
            }
        }

        public static double power(double x, int numer, int denom)
        {
            if (denom == 2)
            {
                return power(newtonRoot(x, 2), numer);
            }
            else
            {
                return power(Math.Pow(x, 1 / denom), numer);
            }
        }

        public static double newtonRoot(double A, int n)
        {
            //Newton Raphson
            double x = 2.0;
            for (int i = 0; i < 20; i++)
            {
                x = (((n - 1.0) / n) * x) + (A / (n * power(x, n - 1)));
            }
            return x;
        }


        public static int factorial(int x)
        {

            //If finding factorial of 0, it will return 1
            if (x == 0)
            {
                return 1;
            }
            int fact = x;

            if (x > 1)
            {
                return (fact * factorial(x - 1));
            }
            else
            {
                return 1;
            }
        }

        private static double Getpi()
        {
            //Mclaurens series for arctan, which gives PI/4
            double pi = 1;
            for (int i = 3; i < 1000000; i = i + 4)
            {
                pi = pi - (1.0 / i) + (1.0 / (i + 2));
            }
            pi = Convert.ToDouble(decimal.Round(Convert.ToDecimal(pi * 4), 5));
            return pi;
        }

        public static double sin(double x)
        {

            if (x > 45)
            {
                double sinx = cos(90 - x);
                return sinx;
            }
            else
            {
                x = x * (PI / 180);
                double sinx = x;
                for (int i = 3; i < 30; i = i + 4)
                {
                    sinx = sinx - (power(x, i) / factorial(i)) + (power(x, i + 2) / factorial(i + 2));
                }
                sinx = Convert.ToDouble(decimal.Round(Convert.ToDecimal(sinx), 5));
                return sinx;
            }            
        }

        public static double cos(double x)
        {
            if (x > 45)
            {
                double cosx = sin(90 - x);
                return cosx;
            }
            else
            {
                x = x * (PI / 180);
                double cosx = 1;
                for (int i = 2; i < 30; i = i + 4)
                {
                    cosx = cosx - (power(x, i) / factorial(i)) + (power(x, i + 2) / factorial(i + 2));
                }
                cosx = Convert.ToDouble(decimal.Round(Convert.ToDecimal(cosx), 5));
                return cosx;
            }            
        }

        public static double tan(double x)
        {
            double tanx = Convert.ToDouble(decimal.Round(Convert.ToDecimal(sin(x) / cos(x)), 5));
            return tanx;
        }

        public static double arcsin(double x)
        {
            double arcsinx = arctan(x / (newtonRoot((1 - power(x, 2)), 2)));
            arcsinx = ToDegrees(arcsinx);
            return Convert.ToDouble(decimal.Round(Convert.ToDecimal(arcsinx), 1));
        }


        public static double arccos(double x)
        {
            double arccosx = arctan(newtonRoot((1 - power(x, 2)), 2) / x);
            arccosx = ToDegrees(arccosx);
            return Convert.ToDouble(decimal.Round(Convert.ToDecimal(arccosx), 1));
        }

        public static double arctan(double x)
        {
            if (x < 0)
            {
                double arctanx = arctan(x * -1) * -1;
                return arctanx;
            }
            if (x > 1)
            {
                double arctanx = (PI / 2) - arctan(1 / x); ;
                return arctanx;
            }
            if (x > (2 - newtonRoot(3, 2)))
            {
                double arctanx = (PI / 6) + (arctan(((newtonRoot(3, 2) * x) - 1) / (newtonRoot(3, 2) + x)));
                return arctanx;
            }
            double atanx = x;
            for (int i = 3; i < 50; i = i + 4)
            {
                atanx = atanx - (power(x, i) / i) + (power(x, (i + 2)) / (i + 2));
            }
            return atanx;
        }

        public static double ToDegrees(double x)
        {
            return x * (180 / PI);
        }

        public static double ToRadians(double x)
        {
            return x * (PI / 180);
        }

        public static double natLog(double x)
        {
            double natLogx = x;
            for (int i = 2; i < 40; i = i + 2)
            {
                natLogx = natLogx - (power(x, i) / i) + (power(x, i + 1) / (i + 1));
            }
            return natLogx;
        }

        public static double mag(double x)
        {
            if (x < 0)
            {
                x = x * -1;
            }
            return x;
        }

        public static double log10(double x)
        {
            double logx = Math.Log(x) / Math.Log(10);
            return logx;
        }

        public static int standardExponent(double x)
        {
            int exponent = Convert.ToInt32(decimal.Truncate(Convert.ToDecimal(log10(x))));
            if (exponent < 0)
            {
                exponent = exponent - 1;
            }
            return exponent;
        }

        public static double standardMantissa(double x)
        {
            double mantissa = x / power(10, standardExponent(x));
            return mantissa;
        }

        public static double sigfig(double num, int SF)
        {
            int exponent = standardExponent(num);
            double mantissa = standardMantissa(num);
            mantissa = Convert.ToDouble(decimal.Round(Convert.ToDecimal(mantissa), SF - 1));
            double rounded = mantissa * power(10, exponent);
            return rounded;
        }

        public static (double,int) standardForm(double x)
        {
            double mantissa = standardMantissa(x);
            int exponent = standardExponent(x);
            return (mantissa, exponent);
        }

        public static (double, int) standardForm(double x, int y)
        {
            double rounded = sigfig(x, y);
            double mantissa = standardMantissa(rounded);
            int exponent = standardExponent(rounded);
            return (mantissa, exponent);
        }

        public static string lblStandardForm(double x)
        {
            string lbl;
            if (x >= 10000)
            {
                lbl = Convert.ToString(standardForm(x, 3).Item1) + " x10^" + Convert.ToString(standardForm(x, 3).Item2);
            }
            else if (x <= -10000)
            {
                lbl = "-" + lblStandardForm(-x);
            }

            else if (x < 10000 && x >= 1)
            {
                lbl = Convert.ToString(decimal.Round(Convert.ToDecimal(x), 3));
            }
            else if (x > -10000 && x <= -1)
            {
                lbl = "-" + lblStandardForm(-x);
            }

            else if (x > 0.001 && x < 1)
            {
                lbl = Convert.ToString(sigfig(x, 3));
            }
            else if (x < -0.001 && x > -1)
            {
                lbl = "-" + lblStandardForm(-x);
            }

            else if (x > 0 && x < 0.001)
            {
                lbl = Convert.ToString(standardForm(x, 3).Item1 + " x10^" + Convert.ToString(standardForm(x, 3).Item2));
            }
            else if (x < 0 && x > -0.001)
            {
                lbl = "-" + lblStandardForm(-x);
            }

            else
            {
                lbl = "0";
            }
            return lbl;
        }
    }
}
