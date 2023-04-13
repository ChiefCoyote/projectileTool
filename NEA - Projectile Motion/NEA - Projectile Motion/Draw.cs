using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEA___Projectile_Motion
{
    static class Draw
    {

        public static int screenheight = Screen.PrimaryScreen.Bounds.Height;
        public static int screenWidth = Screen.PrimaryScreen.Bounds.Width;

        public static int canvasTopLeftx = screenWidth / 100;
        public static int canvasTopLefty = screenheight / 100;
        public static int canvasHeight = 99 * (screenheight / 100);
        public static int canvasWidth = 14 * (screenWidth / 20);
        public static int originy = canvasHeight - (canvasHeight / 20);
        public static int originx = canvasWidth / 15;
        public static int yaxisLength = originy - (canvasHeight / 15);
        public static int xaxisLength = canvasWidth - (canvasWidth / 15);

        private static Pen BlackPen2 = new Pen(Color.Black, 2);
        private static Pen BlackPen3 = new Pen(Color.Black, 3);
        private static Brush WhiteBrush = new SolidBrush(Color.White);
        private static Brush BlackBrush = new SolidBrush(Color.Black);
        private static Brush RedBrush = new SolidBrush(Color.Red);
        private static Font scaleFont = new Font("Calibri", 8);


        public static void drawGraph(PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(BlackPen2, new Rectangle(canvasTopLeftx, canvasTopLefty, canvasWidth, canvasHeight));
            e.Graphics.FillRectangle(WhiteBrush, new Rectangle(canvasTopLeftx, canvasTopLefty, canvasWidth, canvasHeight));

            e.Graphics.DrawLine(BlackPen3, originx, originy - 1, originx, originy - yaxisLength);
            e.Graphics.DrawLine(BlackPen3, originx - 1, originy, originx + xaxisLength, originy);           
            graphScale(e);
            lineDraw(e);
        }

        private static void graphScale(PaintEventArgs e)
        {
            int markerx = 0;
            int markery = 0;
            if (yaxisLength / 10 < 125)
            {
                double scaleJump = Values.scaleyDistance / 20;
                for (int i = 1; i < 21; i++)
                {
                    markery = (yaxisLength / 20) * i;
                    e.Graphics.DrawLine(BlackPen3, originx, originy - markery, originx - 10, originy - markery);
                    string lblscale = MATHS.lblStandardForm(scaleJump * i);
                    e.Graphics.DrawString(lblscale, scaleFont, BlackBrush, canvasTopLeftx, originy - markery - 10);
                }
            }
            else
            {
                double scaleJump = Values.scaleyDistance / 10;
                for (int i = 1; i < 11; i++)
                {
                    markery = (yaxisLength / 10) * i;
                    e.Graphics.DrawLine(BlackPen3, originx, originy - markery, originx - 10, originy - markery);
                    string lblscale = MATHS.lblStandardForm(scaleJump * i);
                    e.Graphics.DrawString(lblscale, scaleFont, BlackBrush, canvasTopLeftx , originy - markery - 10);
                }
            }

            if (xaxisLength / 10 < 125)
            {
                double scaleJump = Values.scalexDistance / 20;
                for (int i = 1; i < 21; i++)
                {
                    markerx = (xaxisLength / 20) * i;
                    e.Graphics.DrawLine(BlackPen3, originx + markerx, originy, originx + markerx, originy + 10);
                    string lblscale = MATHS.lblStandardForm(scaleJump * i);
                    e.Graphics.DrawString(lblscale, scaleFont, BlackBrush, originx + markerx - 10, originy + 12);
                }
            }
            else
            {
                double scaleJump = Values.scalexDistance / 10;
                for (int i = 1; i < 11; i++)
                {
                    markerx = (xaxisLength / 10) * i;
                    e.Graphics.DrawLine(BlackPen3, originx + markerx, originy, originx + markerx, originy + 10);
                    string lblscale = MATHS.lblStandardForm(scaleJump * i);
                    e.Graphics.DrawString(lblscale, scaleFont, BlackBrush, originx + markerx - 10, originy + 12);
                }
            }
        }

        public static void traceline(Label[] lables, object sender, PaintEventArgs e)
        {
            Values.setCursorPoint();
            int pos = 0;

            List<Values.Points> closePoints = new List<Values.Points>();
            foreach (Values.Points coord in Values.points)
            {
                if (Values.cursorPoint.X < (coord.X + 30) && Values.cursorPoint.X > (coord.X - 30) && Values.cursorPoint.Y - 23 < (coord.Y + 30) && Values.cursorPoint.Y - 23 > (coord.Y - 30))
                {
                    closePoints.Add(coord);
                }
            }
            double[] distance = new double[closePoints.Count];
            for (int i = 0; i < distance.Length; i++)
            {
                distance[i] = MATHS.newtonRoot(MATHS.power(closePoints[i].X - Values.cursorPoint.X, 2) + MATHS.power(closePoints[i].Y - Values.cursorPoint.Y + 23, 2), 2);

                if (distance[i] < distance[pos])
                {
                    pos = i;
                }
            }
            if (closePoints.Count > 0)
            {
                plotDot(closePoints[pos].X, closePoints[pos].Y, e);
                details(lables ,sender ,closePoints[pos]);
            }

        }

        private static void details(Label[] lables, object sender, Values.Points coord)
        {
            double verticalVel;
            double horizontalvel;
            double resultantvel;
            int angle;
            double time;
            double height;
            double distance;
            string lblverticalVel;
            string lblhorizontalvel;
            string lblresultantvel;
            string lbltime;
            string lblheight;
            string lbldistance;
            
            distance = Projectile.trackDistance(coord.X);
            lbldistance = MATHS.lblStandardForm(distance);
            lables[6].Text = "Distance Travelled: " + lbldistance + "m";

            height = Projectile.trackHeight(coord.Y);
            lblheight = MATHS.lblStandardForm(height);
            lables[5].Text = "Height: " + lblheight + "m";

            horizontalvel = MATHS.newtonRoot((-4.905 / Values.Cartesian.Item1), 2);
            lblhorizontalvel = MATHS.lblStandardForm(horizontalvel);
            lables[1].Text = "Horizontal Velocity: " + lblhorizontalvel + "ms^-1";

            time = Projectile.trackTime(distance, horizontalvel);
            lbltime = MATHS.lblStandardForm(time);
            lables[4].Text = "Time spent in motion: " + lbltime + " seconds";

            angle = Projectile.trackAngle(distance, height);
            lables[3].Text = "Angle: " + angle + " degrees";

            verticalVel = Projectile.trackVerticalVel(angle, horizontalvel);
            lblverticalVel = MATHS.lblStandardForm(verticalVel);
            lables[0].Text = "Vertical Velocity: " + lblverticalVel + "ms^-1";

            resultantvel = Projectile.trackResultantVel(verticalVel, horizontalvel);
            lblresultantvel = MATHS.lblStandardForm(resultantvel);
            lables[2].Text = "Resultant Velocity: " + lblresultantvel + "ms^-1";

            
        }

        private static void plotDot(int x, int y, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(BlackBrush, x - 4, y - 4, 8, 8);
        }

        private static void lineDraw(PaintEventArgs e)
        {
            for (int i = 0; i < (Values.points.Count-1); i++)
            {
                plotLine(Values.points[i].X, Values.points[i].Y, Values.points[i + 1].X, Values.points[i + 1].Y, e);
            }
        }

        private static void plot(int x, int y, PaintEventArgs e)

        {
            e.Graphics.FillRectangle(BlackBrush, x, y, 1, 1);
        }



        private static void plotLine(int xstart, int ystart, int xend, int yend, PaintEventArgs e)

        {

            if (MATHS.mag(yend - ystart) < MATHS.mag(xend - xstart))
            {
                if (xstart > xend)
                {
                    plotLineShallow(xend, yend, xstart, ystart, e);
                }

                else
                {
                    plotLineShallow(xstart, ystart, xend, yend, e);
                }
            }

            else
            {
                if (ystart > yend)
                {
                    plotLineSteep(xend, yend, xstart, ystart, e);
                }

                else
                {
                    plotLineSteep(xstart, ystart, xend, yend, e);
                }
            }
        }

        private static void plotLineShallow(int xstart, int ystart, int xend, int yend, PaintEventArgs e)
        {
            int xDifference = xend - xstart;
            int yDifference = yend - ystart;
            int gradient = 1;

            if (yDifference < 0)
            {
                gradient = -1;
                yDifference = -yDifference;
            }

            int decision = (2 * yDifference) - xDifference;
            int y = ystart;


            for (int x = xstart; x < xend + 1; x++)
            {
                plot(x, y, e);

                if (decision > 0)
                {
                    y = y + gradient;
                    decision = decision + (2 * (yDifference - xDifference));
                }

                else
                {
                    decision = decision + (2 * yDifference);
                }
            }
        }



        private static void plotLineSteep(int xstart, int ystart, int xend, int yend, PaintEventArgs e)
        {
            int xdifference = xend - xstart;

            int ydifference = yend - ystart;

            int gradient = 1;

            if (xdifference < 0)
            {
                gradient = -1;
                xdifference = -xdifference;
            }

            int decision = (2 * xdifference) - ydifference;

            int x = xstart;


            for (int y = ystart; y < yend + 1; y++)
            {
                plot(x, y, e);

                if (decision > 0)
                {
                    x = x + gradient;
                    decision = decision + (2 * (xdifference - ydifference));
                }

                else
                {
                    decision = decision + (2 * xdifference);
                }
            }

        }
    }
}
