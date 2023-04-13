using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEA___Projectile_Motion
{
    static class Values
    {
        public struct Points
        {
            public int X;
            public int Y;
        }
        public static double MaxTime;
        public static double MaxDistancex;
        public static double MaxDistancey;
        public static double scalexDistance;
        public static double scaleyDistance;
        public static double pixelDistancex;
        public static double pixelDistancey;

        private static List<double[]> undoStack = new List<double[]>();
        private static int undoPointer = -1;
        private static List<double[]> redoStack = new List<double[]>();
        private static int redoPointer = -1;

        public  static Points cursorPoint = new Points();
        public static List<Points> points = new List<Points>();
        public static (double, double, double) Cartesian;
        public static void setMaxTime(double time)
        {
            MaxTime = time;
        }
        public static void setMaxDistance(double distancex, double distancey)
        {
            MaxDistancex = distancex;
            MaxDistancey = distancey;
            setScalexDistance();
            setScaleyDistance();
        }


        public static void setScalexDistance()
        {
            if (MaxDistancex / 1000 < 1)
            {
                string distance = MaxDistancex.ToString("G1");
                double tempdistance = Convert.ToDouble(distance);
                if (tempdistance < MaxDistancex)
                {
                    tempdistance = tempdistance * 1.5;
                    distance = tempdistance.ToString("G2");
                    scalexDistance = Convert.ToDouble(distance);
                }
                else
                {
                    scalexDistance = tempdistance;
                }
            }
            else
            {
                string distance = MaxDistancex.ToString("G2");
                double tempdistance = Convert.ToDouble(distance);
                if (tempdistance < MaxDistancex)
                {
                    tempdistance = tempdistance + (tempdistance / 2);
                    distance = tempdistance.ToString("G3");
                    scalexDistance = Convert.ToDouble(distance);
                }
                else
                {
                    scalexDistance = tempdistance;
                }
            }          
        }

        public static void setScalexDistanceReal(double yscale)
        {
            scalexDistance = yscale;
        }

        public static void setScaleyDistance()
        {
            if (MaxDistancey / 1000 < 1)
            {
                string distance = MaxDistancey.ToString("G1");
                double tempdistance = Convert.ToDouble(distance);
                if (tempdistance < MaxDistancey)
                {
                    tempdistance = tempdistance + (tempdistance / 2);
                    distance = tempdistance.ToString("G2");
                    scaleyDistance = Convert.ToDouble(distance);
                }
                else
                {
                    scaleyDistance = tempdistance;
                }
            }
            else
            {
                string distance = MaxDistancey.ToString("G2");
                double tempdistance = Convert.ToDouble(distance);
                if (tempdistance < MaxDistancey)
                {
                    tempdistance = tempdistance + (tempdistance / 2);
                    distance = tempdistance.ToString("G3");
                    scaleyDistance = Convert.ToDouble(distance);
                }
                else
                {
                    scaleyDistance = tempdistance;
                }
            }
        }

        public static void setScaleyDistanceReal(double xScale)
        {
            scaleyDistance = xScale;
        }

        public static void setPixelDistancex(int length)
        {
            pixelDistancex = scalexDistance / length;
        }
        public static void setPixelDistancey(int length)
        {
            pixelDistancey = scaleyDistance / length;
        }
        public static void setCartesian(double a, double b, double c)
        {
            Cartesian.Item1 = a;
            Cartesian.Item2 = b;
            Cartesian.Item3 = c;
        }

        public static void setPoints()
        {
            int i = Draw.originx;
            int counter = 0;
            while (Projectile.pixelHeight(i - Draw.originx, Draw.originy) <= Draw.originy && i <= Draw.originx + Draw.xaxisLength && counter < (Draw.xaxisLength / 2))
            {
                int y1 = Projectile.pixelHeight(i - Draw.originx, Draw.originy);

                if (y1 <= Draw.originy)
                {
                    points.Add(new Points() { X = i, Y = y1 });
                }              
                i = i + 2;
                counter++;
            }
            int x = Projectile.pixelLength(0 , Draw.originx);
            points.Add(new Points() { X = x, Y = Draw.originy });
        }

        public static void setCursorPoint()
        {
            cursorPoint.X = Cursor.Position.X;
            cursorPoint.Y = Cursor.Position.Y;
        }

        public static void undoStackPush(double[] inputs)
        {
            undoPointer = undoPointer + 1;
            undoStack.Add(inputs);
        }

        public static void redoStackPush(double[] inputs)
        {
            redoPointer = redoPointer + 1;
            redoStack.Add(inputs);
        }

        public static void undoStackPop()
        {
            undoStack.RemoveAt(undoPointer);
            undoPointer = undoPointer - 1;
        }

        public static void redoStackPop()
        {
            redoStack.RemoveAt(redoPointer);
            redoPointer = redoPointer - 1;
        }

        public static double[] undoStackPeek()
        {
            return undoStack[undoPointer];
        }

        public static double[] redoStackPeek()
        {
            return redoStack[redoPointer];
        }
    }
}
