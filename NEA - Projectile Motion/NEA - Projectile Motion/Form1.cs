using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace NEA___Projectile_Motion
{
    public partial class ProjectileMotion : Form
    {
        public ProjectileMotion()
        {
            InitializeComponent();
            ControlSettings();
            WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            int screenheight = Screen.PrimaryScreen.Bounds.Height;
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            
        }

        private void ControlSettings()
        {
            checkInitialVel.Checked = true;
            InitialVelHorUpDown.ReadOnly = true;
            InitialVelHorUpDown.Value = 0;
            comboInitialHor.Enabled = false;

            InitialVelVertUpDown.ReadOnly = true;
            InitialVelVertUpDown.Value = 0;
            comboInitialVert.Enabled = false;

            checkInitialVel.Enabled = false;


            InitialVelUpDown.Controls[0].Visible = false;
            InitialVelHorUpDown.Controls[0].Visible = false;
            InitialVelVertUpDown.Controls[0].Visible = false;
            InitialAngleUpDown.Controls[0].Visible = false;
            InitialHeightUpDown.Controls[0].Visible = false;


            comboInitialVel.SelectedIndex = 0;
            comboInitialHor.SelectedIndex = 0;
            comboInitialVert.SelectedIndex = 0;
            comboInitialHeight.SelectedIndex = 1;

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void ProjectileMotion_Paint(object sender, PaintEventArgs e)
        {
            Label[] detailLbls = new Label[7];
            detailLbls[0] = vertVellbl;
            detailLbls[1] = horVellbl;
            detailLbls[2] = vellbl;
            detailLbls[3] = anglelbl;
            detailLbls[4] = timelbl;
            detailLbls[5] = heightlbl;
            detailLbls[6] = distancelbl;

            Draw.drawGraph(e);
            Draw.traceline(detailLbls, sender, e);
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;

            switch (m.Msg)
            {
                case WM_SYSCOMMAND:
                    int command = m.WParam.ToInt32() & 0xfff0;
                    if (command == SC_MOVE)
                        return;
                    break;
            }
            base.WndProc(ref m);
        }

        private void checkInitialVel_CheckedChanged(object sender, EventArgs e)
        {
            if (checkInitialVel.Checked == true)
            {
                InitialVelHorUpDown.ReadOnly = true;
                InitialVelHorUpDown.Value = 0;
                comboInitialHor.Enabled = false;

                InitialVelVertUpDown.ReadOnly = true;
                InitialVelVertUpDown.Value = 0;
                comboInitialVert.Enabled = false;

                checkInitialVel.Enabled = false;

                checkInitialVelHor.Enabled = true;
                checkInitialVelHor.Checked = false;

                InitialVelUpDown.ReadOnly = false;
                comboInitialVel.Enabled = true;

                InitialAngleUpDown.ReadOnly = false;
            }
        }

        private void checkInitialVelHor_CheckedChanged(object sender, EventArgs e)
        {
            if (checkInitialVelHor.Checked == true)
            {


                InitialVelUpDown.ReadOnly = true;
                InitialVelUpDown.Value = 0;
                comboInitialVel.Enabled = false;

                InitialAngleUpDown.ReadOnly = true;
                InitialAngleUpDown.Value = 0;

                checkInitialVelHor.Enabled = false;

                checkInitialVel.Enabled = true;
                checkInitialVel.Checked = false;

                InitialVelHorUpDown.ReadOnly = false;
                comboInitialHor.Enabled = true;

                InitialVelVertUpDown.ReadOnly = false;
                comboInitialVert.Enabled = true;
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if ((InitialVelUpDown.Value > 0) || (InitialVelHorUpDown.Value > 0 && InitialVelVertUpDown.Value > 0))
            {
                
                if (checkInitialVel.Checked == true && InitialAngleUpDown.Value == 0 && InitialHeightUpDown.Value == 0)
                {
                    MessageBox.Show("You cannot have an angle of 0 at ground level", "Error!");
                }
                else
                {
                    double[] inputs = new double[9];
                    Values.points.Clear();
                    (double, double, double) cartesianEquation;
                    (double, double, double) maxtimeanddistance;
                    if (checkInitialVel.Checked == true)
                    {
                        cartesianEquation = Projectile.trajectory(Convert.ToDouble(InitialVelUpDown.Value), Convert.ToInt32(InitialAngleUpDown.Value), Convert.ToInt32(InitialHeightUpDown.Value), comboInitialVel.SelectedIndex, comboInitialHeight.SelectedIndex);
                        maxtimeanddistance = Projectile.maxtimeanddistance(Convert.ToDouble(InitialVelUpDown.Value), Convert.ToInt32(InitialAngleUpDown.Value), Convert.ToDouble(InitialHeightUpDown.Value), comboInitialVel.SelectedIndex, comboInitialHeight.SelectedIndex);
                        inputs[0] = 0;
                        inputs[1] = Convert.ToDouble(InitialVelUpDown.Value);
                        inputs[2] = Convert.ToDouble(InitialAngleUpDown.Value);
                        inputs[5] = Convert.ToDouble(InitialHeightUpDown.Value);
                        int comboVel;
                        switch (comboInitialVel.SelectedIndex)
                        {
                            case (1):
                                comboVel = 1;
                                break;
                            case (2):
                                comboVel = 2;
                                break;
                            case (3):
                                comboVel = 3;
                                break;
                            default:
                                comboVel = 0;
                                break;
                        }
                        inputs[6] = Convert.ToDouble(comboVel);
                        int comboheight;
                        switch (comboInitialHeight.SelectedIndex)
                        {
                            case (0):
                                comboheight = 0;
                                break;
                            case (2):
                                comboheight = 2;
                                break;
                            default:
                                comboheight = 1;
                                break;
                        }
                        inputs[8] = Convert.ToDouble(comboheight);

                    }
                    else
                    {
                        cartesianEquation = Projectile.trajectory(Convert.ToDouble(InitialVelHorUpDown.Value), Convert.ToDouble(InitialVelVertUpDown.Value), Convert.ToInt32(InitialHeightUpDown.Value), comboInitialHor.SelectedIndex, comboInitialHeight.SelectedIndex);
                        maxtimeanddistance = Projectile.maxtimeanddistance(Convert.ToDouble(InitialVelVertUpDown.Value), Convert.ToDouble(InitialVelHorUpDown.Value), Convert.ToDouble(InitialHeightUpDown.Value), comboInitialVert.SelectedIndex, comboInitialHeight.SelectedIndex); ;
                        inputs[0] = 1;
                        inputs[3] = Convert.ToDouble(InitialVelHorUpDown.Value);
                        inputs[4] = Convert.ToDouble(InitialVelVertUpDown.Value);
                        inputs[5] = Convert.ToDouble(InitialHeightUpDown.Value);
                        int comboVel;
                        switch (comboInitialVel.SelectedIndex)
                        {
                            case (1):
                                comboVel = 1;
                                break;
                            case (2):
                                comboVel = 2;
                                break;
                            case (3):
                                comboVel = 3;
                                break;
                            default:
                                comboVel = 0;
                                break;
                        }
                        inputs[7] = Convert.ToDouble(comboVel);
                        int comboheight;
                        switch (comboInitialHeight.SelectedIndex)
                        {
                            case (0):
                                comboheight = 0;
                                break;
                            case (2):
                                comboheight = 2;
                                break;
                            default:
                                comboheight = 1;
                                break;
                        }
                        inputs[8] = Convert.ToDouble(comboheight);
                    }
                    Values.setMaxTime(maxtimeanddistance.Item1);
                    if (parabCheck.Checked == true)
                    {
                        Values.setMaxDistance(maxtimeanddistance.Item2, maxtimeanddistance.Item3);
                        if (Values.scalexDistance >= Values.scaleyDistance)
                        {
                            Values.setScaleyDistanceReal(Values.scalexDistance);
                        }
                        else
                        {
                            Values.setScalexDistanceReal(Values.scaleyDistance);
                        }
                    }
                    else
                    {
                        Values.setMaxDistance(maxtimeanddistance.Item2, maxtimeanddistance.Item3);
                    }
                    Values.setCartesian(cartesianEquation.Item1, cartesianEquation.Item2, cartesianEquation.Item3);
                    Values.setPixelDistancex(Draw.xaxisLength);
                    Values.setPixelDistancey(Draw.yaxisLength);
                    Values.setPoints();
                    Cartesianlbl.Text = "Cartesian Equation: " + ("y = (" + MATHS.lblStandardForm(cartesianEquation.Item1) + ")x^2 + (" + MATHS.lblStandardForm(cartesianEquation.Item2) + ")x + " + MATHS.lblStandardForm(cartesianEquation.Item3));

                    Values.undoStackPush(inputs);
                }
                
            }
            else
            {
                MessageBox.Show("Please enter non 0 values", "Error!");
            }

        }

        private void comboInitialHor_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboInitialVert.SelectedIndex = comboInitialHor.SelectedIndex;
        }

        private void comboInitialVert_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboInitialHor.SelectedIndex = comboInitialVert.SelectedIndex;
        }

        private void drawTimer_Tick(object sender, EventArgs e)
        {
            Refresh();
        }

        private void parabCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (parabCheck.Checked == true)
            {
                if (Values.scalexDistance >= Values.scaleyDistance)
                {
                    Values.setScaleyDistanceReal(Values.scalexDistance);
                }
                else
                {
                    Values.setScalexDistanceReal(Values.scaleyDistance);
                }
            }
            else
            {
                Values.setScalexDistance();
                Values.setScaleyDistance();
            }
            btnCalculate_Click(sender, e);
        }

        private void undobtn_Click(object sender, EventArgs e)
        {
            try
            {
                double[] inputs = Values.undoStackPeek();

                Values.redoStackPush(inputs);
                Values.undoStackPop();
            }
            catch
            {
                Values.redoStackPop();
                MessageBox.Show("No previous graphs", "Error!");
            }

            try
            {
                double[] inputs = Values.undoStackPeek();

                if (inputs[0] == 1)
                {
                    checkInitialVelHor.Checked = true;
                    InitialVelHorUpDown.Value = Convert.ToDecimal(inputs[3]);
                    InitialVelVertUpDown.Value = Convert.ToDecimal(inputs[4]);
                    InitialHeightUpDown.Value = Convert.ToDecimal(inputs[5]);
                    comboInitialHor.SelectedIndex = Convert.ToInt32(inputs[7]);
                    comboInitialVert.SelectedIndex = Convert.ToInt32(inputs[7]);
                    comboInitialHeight.SelectedIndex = Convert.ToInt32(inputs[8]);
                    Values.undoStackPop();
                    btnCalculate_Click(sender, e);
                }

                else if (inputs[0] == 0)
                {
                    checkInitialVel.Checked = true;
                    InitialVelUpDown.Value = Convert.ToDecimal(inputs[1]);
                    InitialAngleUpDown.Value = Convert.ToDecimal(inputs[2]);
                    InitialHeightUpDown.Value = Convert.ToDecimal(inputs[5]);
                    comboInitialVel.SelectedIndex = Convert.ToInt32(inputs[6]);
                    comboInitialHeight.SelectedIndex = Convert.ToInt32(inputs[8]);
                    Values.undoStackPop();
                    btnCalculate_Click(sender, e);
                }
            }
            catch
            {
                btnCalculate_Click(sender, e);
                Values.redoStackPop();
                MessageBox.Show("No previous graphs", "Error!");
            }       
        }

        private void redobtn_Click(object sender, EventArgs e)
        {
            try
            {
                double[] inputs = Values.redoStackPeek();

                if (inputs[0] == 1)
                {
                    checkInitialVelHor.Checked = true;
                    InitialVelHorUpDown.Value = Convert.ToDecimal(inputs[3]);
                    InitialVelVertUpDown.Value = Convert.ToDecimal(inputs[4]);
                    InitialHeightUpDown.Value = Convert.ToDecimal(inputs[5]);
                    comboInitialHor.SelectedIndex = Convert.ToInt32(inputs[7]);
                    comboInitialVert.SelectedIndex = Convert.ToInt32(inputs[7]);
                    comboInitialHeight.SelectedIndex = Convert.ToInt32(inputs[8]);
                    Values.redoStackPop();
                    btnCalculate_Click(sender, e);
                }

                else if (inputs[0] == 0)
                {
                    checkInitialVel.Checked = true;
                    InitialVelUpDown.Value = Convert.ToDecimal(inputs[1]);
                    InitialAngleUpDown.Value = Convert.ToDecimal(inputs[2]);
                    InitialHeightUpDown.Value = Convert.ToDecimal(inputs[5]);
                    comboInitialVel.SelectedIndex = Convert.ToInt32(inputs[6]);
                    comboInitialHeight.SelectedIndex = Convert.ToInt32(inputs[8]);
                    Values.redoStackPop();
                    btnCalculate_Click(sender, e);
                }
            }
            catch
            {
                MessageBox.Show("At most recent graph", "Error!");
            }
        }
    }
}
