using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEA___Projectile_Motion
{
    static class Projectile
    {
        public static (double, double, double) trajectory(double initialVel, int initialAngle, double initialHeight, int velUnits, int heightUnits)
        {
            switch (velUnits)
            {
                case 0:
                    break;

                case 1:
                    initialVel = initialVel / 3600;
                    break;

                case 2:                    
                    initialVel = initialVel * 1000;
                    break;

                case 3:
                    initialVel = (initialVel * 1000) / 3600;
                    break;

                default:
                    break;

            }

            switch (heightUnits)
            {
                case 0:
                    initialHeight = initialHeight / 100;
                    break;

                case 1:
                    break;

                case 2:
                    initialHeight = initialHeight * 1000;
                    break;

                default:
                    break;
            }

            double initialVelHor = initialVel * MATHS.cos(initialAngle);
            double initialVelVert = initialVel * MATHS.sin(initialAngle);

            return cartesian(initialVelHor, initialVelVert, initialHeight);
        }

        public static (double, double, double) trajectory(double initialVelHor, double initialVelVert, double initialHeight, int velUnits, int heightUnits)
        {
            switch (velUnits)
            {
                case 0:
                    break;

                case 1:
                    initialVelVert = initialVelVert / 3600;
                    initialVelHor = initialVelHor / 3600;
                    break;

                case 2:
                    initialVelVert = initialVelVert * 1000;
                    initialVelHor = initialVelHor * 1000;
                    break;

                case 3:
                    initialVelVert = (initialVelVert * 1000) / 3600;
                    initialVelHor = (initialVelHor * 1000) / 3600;
                    break;

                default:
                    break;

            }

            switch (heightUnits)
            {
                case 0:
                    initialHeight = initialHeight / 100;
                    break;

                case 1:
                    break;

                case 2:
                    initialHeight = initialHeight * 1000;
                    break;

                default:
                    break;
            }

            return cartesian(initialVelHor, initialVelVert, initialHeight);
        }

        private static (double, double, double) cartesian(double initialVelHor, double initialVelVert, double initialHeight)
        {
            double t = 1.0 / initialVelHor;
            double xsquared = -4.905 * MATHS.power(t, 2);
            double x = initialVelVert * t;
            double c = initialHeight;

            return (xsquared, x, c);
        }

        public static double time(double initialHorVel, double xCoord)
        {
            return (xCoord / initialHorVel);
        }

        public static (double, double, double) maxtimeanddistance(double initialVelVert, double initialVelHor, double initialHeight, int velUnits, int heightUnits)
        {
            switch (velUnits)
            {
                case 0:
                    break;

                case 1:
                    initialVelVert = initialVelVert / 3600;
                    initialVelHor = initialVelHor / 3600;
                    break;

                case 2:
                    initialVelVert = initialVelVert * 1000;
                    initialVelHor = initialVelHor * 1000;
                    break;

                case 3:
                    initialVelVert = (initialVelVert * 1000) / 3600;
                    initialVelHor = (initialVelHor * 1000) / 3600;
                    break;

                default:
                    break;

            }
            switch (heightUnits)
            {
                case 0:
                    initialHeight = initialHeight / 100;
                    break;

                case 1:
                    break;

                case 2:
                    initialHeight = initialHeight * 1000;
                    break;

                default:
                    break;
            }

            double s = 0 - initialHeight;
            // s = initialvelvert * t  -4.905t^2    4.905t^2 - Uvt + s = 0
            double t1 = (initialVelVert + MATHS.newtonRoot(MATHS.power((-1 * initialVelVert), 2) - (4 * 4.905 * s), 2)) / (9.81);
            double t2 = (initialVelVert - MATHS.newtonRoot(MATHS.power((-1 * initialVelVert), 2) - (4 * 4.905 * s), 2)) / (9.81);
            double time;
            double distancex;
            double distancey;

            if (t1 < 0)
            {
                distancex = initialVelHor * t2;
                time = t2;
            }
            else
            {
                distancex = initialVelHor * t1;
                time = t1;
            }

            distancey = (MATHS.power(initialVelVert, 2) / 9.81) - ((4.905 * MATHS.power(initialVelVert, 2)) / MATHS.power(9.81, 2)) + initialHeight;
            return (time, distancex, distancey);
        }
        public static (double, double, double) maxtimeanddistance(double initialVel, int initialAngle, double initialHeight,  int velUnits, int heightUnits)
        {
            switch (velUnits)
            {
                case 0:
                    break;

                case 1:
                    initialVel = initialVel / 3600;
                    break;

                case 2:
                    initialVel = initialVel * 1000;
                    break;

                case 3:
                    initialVel = (initialVel * 1000) / 3600;
                    break;

                default:
                    break;

            }

            switch (heightUnits)
            {
                case 0:
                    initialHeight = initialHeight / 100;
                    break;

                case 1:
                    break;

                case 2:
                    initialHeight = initialHeight * 1000;
                    break;

                default:
                    break;
            }

            double initialVelVert = initialVel * MATHS.sin(initialAngle);
            double initialVelHor = initialVel * MATHS.cos(initialAngle);

            double s = 0 - initialHeight;
            double t1 = (initialVelVert + MATHS.newtonRoot(MATHS.power((-1 * initialVelVert), 2) - (4 * 4.905 * s), 2)) / (9.81);
            double t2 = (initialVelVert - MATHS.newtonRoot(MATHS.power((-1 * initialVelVert), 2) - (4 * 4.905 * s), 2)) / (9.81);
            double time;
            double distancex;
            double distancey;

            if (t1 < 0)
            {
                distancex = initialVelHor * t2;
                time = t2;
            }
            else
            {
                distancex = initialVelHor * t1;
                time = t1;
            }

            distancey = (MATHS.power(initialVelVert, 2) / 9.81) - ((4.905 * MATHS.power(initialVelVert, 2)) / MATHS.power(9.81, 2)) + initialHeight;
            return (time, distancex, distancey);
        }

        public static int pixelHeight(int pixel, int start)
        {
            double x = pixel * Values.pixelDistancex;
            double height = (Values.Cartesian.Item1 * MATHS.power(x, 2) + (Values.Cartesian.Item2 * x) + Values.Cartesian.Item3);
            if (Values.pixelDistancey == 0)
            {
                height = 0;
            }
            else
            {
                height = height / Values.pixelDistancey;
            }
            int y = start - Convert.ToInt32(height);

            return y;

        }

        public static int pixelLength(int pixel, int start)
        {
            double length;
            double y = pixel * Values.pixelDistancey;
            double length1 = (-Values.Cartesian.Item2 + (MATHS.newtonRoot(MATHS.power(Values.Cartesian.Item2, 2) - (4 * Values.Cartesian.Item1 * (Values.Cartesian.Item3 - y)), 2))) / (2* Values.Cartesian.Item1);
            double length2 = (-Values.Cartesian.Item2 - (MATHS.newtonRoot(MATHS.power(Values.Cartesian.Item2, 2) - (4 * Values.Cartesian.Item1 * (Values.Cartesian.Item3 - y)), 2))) / (2 * Values.Cartesian.Item1);
            if (length1 <= 0)
            {
                length = length2;
            }
            else
            {
                length = length1;
            }
            
            if (Values.pixelDistancex == 0)
            {
                length = 0;
            }
            else
            {
                length = length / Values.pixelDistancex;
            }
            int x = start + Convert.ToInt32(length);

            return x;
        }


        public static double currentVertVel(double initialVel, double time)
        {
            return (initialVel + (-9.81 * time));
        }

        public static double trackDistance(int x)
        {
            double distance = (x - Draw.originx) * Values.pixelDistancex;
            return distance;
        }

        public static double trackHeight(int y)
        {
            double height = (Draw.originy - y) * Values.pixelDistancey;
            return height;
        }

        public static double trackTime(double x, double vel)
        {
            double time = x / vel;
            return time;
        }

        public static double gradient(double x)
        {
            double gradient = (2 * Values.Cartesian.Item1 * x) + Values.Cartesian.Item2;
            return gradient;
        }

        public static int trackAngle(double x, double y)
        {
            double grad = gradient(x);
            double angle = MATHS.arctan(grad);
            angle = MATHS.ToDegrees(angle);
            return Convert.ToInt32(angle);
        }

        public static double trackVerticalVel(int angle, double horVel)
        {
            double verticalVel = horVel * MATHS.tan(angle);
            return verticalVel;
        }

        public static double trackResultantVel(double y, double x)
        {
            double resultant = MATHS.newtonRoot(MATHS.power(y, 2) + MATHS.power(x, 2), 2);
            return resultant;
        }

        public static (double,double) tangent(int x, int y)
        {
            double distance = trackDistance(x);
            double height = trackHeight(y);
            double m = gradient(distance);

            double c = height - (m * distance);

            return (m, c);
        }

    }
}

