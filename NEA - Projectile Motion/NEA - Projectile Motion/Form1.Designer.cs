
namespace NEA___Projectile_Motion
{
    partial class ProjectileMotion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectileMotion));
            this.inputTabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.comboInitialHeight = new System.Windows.Forms.ComboBox();
            this.parabCheck = new System.Windows.Forms.CheckBox();
            this.InitialAngleLbl = new System.Windows.Forms.Label();
            this.comboInitialHor = new System.Windows.Forms.ComboBox();
            this.comboInitialVert = new System.Windows.Forms.ComboBox();
            this.comboInitialVel = new System.Windows.Forms.ComboBox();
            this.InitialHeightLabel = new System.Windows.Forms.Label();
            this.InitialHeightUpDown = new System.Windows.Forms.NumericUpDown();
            this.InitialAngleLabel = new System.Windows.Forms.Label();
            this.InitialAngleUpDown = new System.Windows.Forms.NumericUpDown();
            this.InitialVelVertLabel = new System.Windows.Forms.Label();
            this.InitialVelVertUpDown = new System.Windows.Forms.NumericUpDown();
            this.InitialVelHorLabel = new System.Windows.Forms.Label();
            this.InitialVelHorUpDown = new System.Windows.Forms.NumericUpDown();
            this.checkInitialVelHor = new System.Windows.Forms.CheckBox();
            this.initialVelLable = new System.Windows.Forms.Label();
            this.InitialVelUpDown = new System.Windows.Forms.NumericUpDown();
            this.checkInitialVel = new System.Windows.Forms.CheckBox();
            this.Cartesianlbl = new System.Windows.Forms.Label();
            this.timelbl = new System.Windows.Forms.Label();
            this.vertVellbl = new System.Windows.Forms.Label();
            this.horVellbl = new System.Windows.Forms.Label();
            this.vellbl = new System.Windows.Forms.Label();
            this.anglelbl = new System.Windows.Forms.Label();
            this.distancelbl = new System.Windows.Forms.Label();
            this.heightlbl = new System.Windows.Forms.Label();
            this.Yaxislbl = new System.Windows.Forms.Label();
            this.Xaxislbl = new System.Windows.Forms.Label();
            this.drawTimer = new System.Windows.Forms.Timer(this.components);
            this.undobtn = new System.Windows.Forms.Button();
            this.redobtn = new System.Windows.Forms.Button();
            this.inputTabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InitialHeightUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InitialAngleUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InitialVelVertUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InitialVelHorUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InitialVelUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // inputTabs
            // 
            this.inputTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputTabs.Controls.Add(this.tabPage1);
            this.inputTabs.Font = new System.Drawing.Font("Calibri", 10F);
            this.inputTabs.Location = new System.Drawing.Point(1249, 3);
            this.inputTabs.Name = "inputTabs";
            this.inputTabs.SelectedIndex = 0;
            this.inputTabs.Size = new System.Drawing.Size(494, 437);
            this.inputTabs.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.btnCalculate);
            this.tabPage1.Controls.Add(this.comboInitialHeight);
            this.tabPage1.Controls.Add(this.parabCheck);
            this.tabPage1.Controls.Add(this.InitialAngleLbl);
            this.tabPage1.Controls.Add(this.comboInitialHor);
            this.tabPage1.Controls.Add(this.comboInitialVert);
            this.tabPage1.Controls.Add(this.comboInitialVel);
            this.tabPage1.Controls.Add(this.InitialHeightLabel);
            this.tabPage1.Controls.Add(this.InitialHeightUpDown);
            this.tabPage1.Controls.Add(this.InitialAngleLabel);
            this.tabPage1.Controls.Add(this.InitialAngleUpDown);
            this.tabPage1.Controls.Add(this.InitialVelVertLabel);
            this.tabPage1.Controls.Add(this.InitialVelVertUpDown);
            this.tabPage1.Controls.Add(this.InitialVelHorLabel);
            this.tabPage1.Controls.Add(this.InitialVelHorUpDown);
            this.tabPage1.Controls.Add(this.checkInitialVelHor);
            this.tabPage1.Controls.Add(this.initialVelLable);
            this.tabPage1.Controls.Add(this.InitialVelUpDown);
            this.tabPage1.Controls.Add(this.checkInitialVel);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(486, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Projectile 1";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalculate.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnCalculate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCalculate.Location = new System.Drawing.Point(215, 350);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(99, 28);
            this.btnCalculate.TabIndex = 23;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // comboInitialHeight
            // 
            this.comboInitialHeight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboInitialHeight.Font = new System.Drawing.Font("Calibri", 10F);
            this.comboInitialHeight.FormattingEnabled = true;
            this.comboInitialHeight.Items.AddRange(new object[] {
            "cm",
            "m",
            "km"});
            this.comboInitialHeight.Location = new System.Drawing.Point(310, 262);
            this.comboInitialHeight.Name = "comboInitialHeight";
            this.comboInitialHeight.Size = new System.Drawing.Size(60, 32);
            this.comboInitialHeight.TabIndex = 20;
            // 
            // parabCheck
            // 
            this.parabCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.parabCheck.AutoSize = true;
            this.parabCheck.Font = new System.Drawing.Font("Calibri", 14F);
            this.parabCheck.Location = new System.Drawing.Point(23, 305);
            this.parabCheck.Name = "parabCheck";
            this.parabCheck.Size = new System.Drawing.Size(251, 39);
            this.parabCheck.TabIndex = 16;
            this.parabCheck.Text = "Realistic trajectory";
            this.parabCheck.UseVisualStyleBackColor = true;
            this.parabCheck.CheckedChanged += new System.EventHandler(this.parabCheck_CheckedChanged);
            // 
            // InitialAngleLbl
            // 
            this.InitialAngleLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InitialAngleLbl.AutoSize = true;
            this.InitialAngleLbl.Location = new System.Drawing.Point(375, 28);
            this.InitialAngleLbl.Name = "InitialAngleLbl";
            this.InitialAngleLbl.Size = new System.Drawing.Size(17, 24);
            this.InitialAngleLbl.TabIndex = 19;
            this.InitialAngleLbl.Text = "°";
            // 
            // comboInitialHor
            // 
            this.comboInitialHor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboInitialHor.Font = new System.Drawing.Font("Calibri", 10F);
            this.comboInitialHor.FormattingEnabled = true;
            this.comboInitialHor.Items.AddRange(new object[] {
            "m/s",
            "m/hr",
            "km/s",
            "km/hr"});
            this.comboInitialHor.Location = new System.Drawing.Point(184, 159);
            this.comboInitialHor.Name = "comboInitialHor";
            this.comboInitialHor.Size = new System.Drawing.Size(60, 32);
            this.comboInitialHor.TabIndex = 18;
            this.comboInitialHor.SelectedIndexChanged += new System.EventHandler(this.comboInitialHor_SelectedIndexChanged);
            // 
            // comboInitialVert
            // 
            this.comboInitialVert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboInitialVert.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboInitialVert.Font = new System.Drawing.Font("Calibri", 10F);
            this.comboInitialVert.FormattingEnabled = true;
            this.comboInitialVert.Items.AddRange(new object[] {
            "m/s",
            "m/hr",
            "km/s",
            "km/hr"});
            this.comboInitialVert.Location = new System.Drawing.Point(378, 159);
            this.comboInitialVert.Name = "comboInitialVert";
            this.comboInitialVert.Size = new System.Drawing.Size(60, 32);
            this.comboInitialVert.TabIndex = 17;
            this.comboInitialVert.SelectedIndexChanged += new System.EventHandler(this.comboInitialVert_SelectedIndexChanged);
            // 
            // comboInitialVel
            // 
            this.comboInitialVel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboInitialVel.Font = new System.Drawing.Font("Calibri", 10F);
            this.comboInitialVel.FormattingEnabled = true;
            this.comboInitialVel.Items.AddRange(new object[] {
            "m/s",
            "m/hr",
            "km/s",
            "km/hr"});
            this.comboInitialVel.Location = new System.Drawing.Point(184, 28);
            this.comboInitialVel.Name = "comboInitialVel";
            this.comboInitialVel.Size = new System.Drawing.Size(60, 32);
            this.comboInitialVel.TabIndex = 6;
            // 
            // InitialHeightLabel
            // 
            this.InitialHeightLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InitialHeightLabel.AutoSize = true;
            this.InitialHeightLabel.Location = new System.Drawing.Point(166, 238);
            this.InitialHeightLabel.Name = "InitialHeightLabel";
            this.InitialHeightLabel.Size = new System.Drawing.Size(116, 24);
            this.InitialHeightLabel.TabIndex = 16;
            this.InitialHeightLabel.Text = "Initial Height";
            // 
            // InitialHeightUpDown
            // 
            this.InitialHeightUpDown.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.InitialHeightUpDown.DecimalPlaces = 3;
            this.InitialHeightUpDown.Font = new System.Drawing.Font("Calibri", 12F);
            this.InitialHeightUpDown.Location = new System.Drawing.Point(169, 258);
            this.InitialHeightUpDown.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.InitialHeightUpDown.Name = "InitialHeightUpDown";
            this.InitialHeightUpDown.Size = new System.Drawing.Size(120, 37);
            this.InitialHeightUpDown.TabIndex = 15;
            // 
            // InitialAngleLabel
            // 
            this.InitialAngleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InitialAngleLabel.AutoSize = true;
            this.InitialAngleLabel.Location = new System.Drawing.Point(249, 6);
            this.InitialAngleLabel.Name = "InitialAngleLabel";
            this.InitialAngleLabel.Size = new System.Drawing.Size(109, 24);
            this.InitialAngleLabel.TabIndex = 13;
            this.InitialAngleLabel.Text = "Initial Angle";
            // 
            // InitialAngleUpDown
            // 
            this.InitialAngleUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InitialAngleUpDown.Font = new System.Drawing.Font("Calibri", 12F);
            this.InitialAngleUpDown.Location = new System.Drawing.Point(252, 26);
            this.InitialAngleUpDown.Maximum = new decimal(new int[] {
            89,
            0,
            0,
            0});
            this.InitialAngleUpDown.Name = "InitialAngleUpDown";
            this.InitialAngleUpDown.Size = new System.Drawing.Size(120, 37);
            this.InitialAngleUpDown.TabIndex = 12;
            // 
            // InitialVelVertLabel
            // 
            this.InitialVelVertLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InitialVelVertLabel.AutoSize = true;
            this.InitialVelVertLabel.Location = new System.Drawing.Point(249, 135);
            this.InitialVelVertLabel.Name = "InitialVelVertLabel";
            this.InitialVelVertLabel.Size = new System.Drawing.Size(193, 24);
            this.InitialVelVertLabel.TabIndex = 10;
            this.InitialVelVertLabel.Text = "Initial Vertical Velocity";
            // 
            // InitialVelVertUpDown
            // 
            this.InitialVelVertUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InitialVelVertUpDown.DecimalPlaces = 3;
            this.InitialVelVertUpDown.Font = new System.Drawing.Font("Calibri", 12F);
            this.InitialVelVertUpDown.Location = new System.Drawing.Point(252, 155);
            this.InitialVelVertUpDown.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.InitialVelVertUpDown.Name = "InitialVelVertUpDown";
            this.InitialVelVertUpDown.Size = new System.Drawing.Size(120, 37);
            this.InitialVelVertUpDown.TabIndex = 9;
            // 
            // InitialVelHorLabel
            // 
            this.InitialVelHorLabel.AutoSize = true;
            this.InitialVelHorLabel.Location = new System.Drawing.Point(55, 135);
            this.InitialVelHorLabel.Name = "InitialVelHorLabel";
            this.InitialVelHorLabel.Size = new System.Drawing.Size(219, 24);
            this.InitialVelHorLabel.TabIndex = 7;
            this.InitialVelHorLabel.Text = "Initial Horizontal Velocity";
            // 
            // InitialVelHorUpDown
            // 
            this.InitialVelHorUpDown.DecimalPlaces = 3;
            this.InitialVelHorUpDown.Font = new System.Drawing.Font("Calibri", 12F);
            this.InitialVelHorUpDown.Location = new System.Drawing.Point(58, 155);
            this.InitialVelHorUpDown.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.InitialVelHorUpDown.Name = "InitialVelHorUpDown";
            this.InitialVelHorUpDown.Size = new System.Drawing.Size(120, 37);
            this.InitialVelHorUpDown.TabIndex = 6;
            // 
            // checkInitialVelHor
            // 
            this.checkInitialVelHor.AutoSize = true;
            this.checkInitialVelHor.Location = new System.Drawing.Point(37, 168);
            this.checkInitialVelHor.Name = "checkInitialVelHor";
            this.checkInitialVelHor.Size = new System.Drawing.Size(22, 21);
            this.checkInitialVelHor.TabIndex = 5;
            this.checkInitialVelHor.UseVisualStyleBackColor = true;
            this.checkInitialVelHor.CheckedChanged += new System.EventHandler(this.checkInitialVelHor_CheckedChanged);
            // 
            // initialVelLable
            // 
            this.initialVelLable.AutoSize = true;
            this.initialVelLable.Location = new System.Drawing.Point(55, 6);
            this.initialVelLable.Name = "initialVelLable";
            this.initialVelLable.Size = new System.Drawing.Size(127, 24);
            this.initialVelLable.TabIndex = 4;
            this.initialVelLable.Text = "Initial Velocity";
            // 
            // InitialVelUpDown
            // 
            this.InitialVelUpDown.DecimalPlaces = 3;
            this.InitialVelUpDown.Font = new System.Drawing.Font("Calibri", 12F);
            this.InitialVelUpDown.Location = new System.Drawing.Point(58, 26);
            this.InitialVelUpDown.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.InitialVelUpDown.Name = "InitialVelUpDown";
            this.InitialVelUpDown.Size = new System.Drawing.Size(120, 37);
            this.InitialVelUpDown.TabIndex = 3;
            // 
            // checkInitialVel
            // 
            this.checkInitialVel.AutoSize = true;
            this.checkInitialVel.Location = new System.Drawing.Point(37, 39);
            this.checkInitialVel.Name = "checkInitialVel";
            this.checkInitialVel.Size = new System.Drawing.Size(22, 21);
            this.checkInitialVel.TabIndex = 2;
            this.checkInitialVel.UseVisualStyleBackColor = true;
            this.checkInitialVel.CheckedChanged += new System.EventHandler(this.checkInitialVel_CheckedChanged);
            // 
            // Cartesianlbl
            // 
            this.Cartesianlbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Cartesianlbl.AutoSize = true;
            this.Cartesianlbl.BackColor = System.Drawing.SystemColors.Control;
            this.Cartesianlbl.Font = new System.Drawing.Font("Calibri", 14F);
            this.Cartesianlbl.Location = new System.Drawing.Point(1255, 564);
            this.Cartesianlbl.Name = "Cartesianlbl";
            this.Cartesianlbl.Size = new System.Drawing.Size(238, 35);
            this.Cartesianlbl.TabIndex = 6;
            this.Cartesianlbl.Text = "Cartesian Equation:";
            // 
            // timelbl
            // 
            this.timelbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.timelbl.AutoSize = true;
            this.timelbl.BackColor = System.Drawing.SystemColors.Control;
            this.timelbl.Font = new System.Drawing.Font("Calibri", 14F);
            this.timelbl.Location = new System.Drawing.Point(1255, 775);
            this.timelbl.Name = "timelbl";
            this.timelbl.Size = new System.Drawing.Size(271, 35);
            this.timelbl.TabIndex = 7;
            this.timelbl.Text = "Time spent in motion: ";
            // 
            // vertVellbl
            // 
            this.vertVellbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.vertVellbl.AutoSize = true;
            this.vertVellbl.BackColor = System.Drawing.SystemColors.Control;
            this.vertVellbl.Font = new System.Drawing.Font("Calibri", 14F);
            this.vertVellbl.Location = new System.Drawing.Point(1254, 613);
            this.vertVellbl.Name = "vertVellbl";
            this.vertVellbl.Size = new System.Drawing.Size(211, 35);
            this.vertVellbl.TabIndex = 8;
            this.vertVellbl.Text = "Vertical Velocity: ";
            // 
            // horVellbl
            // 
            this.horVellbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.horVellbl.AutoSize = true;
            this.horVellbl.BackColor = System.Drawing.SystemColors.Control;
            this.horVellbl.Font = new System.Drawing.Font("Calibri", 14F);
            this.horVellbl.Location = new System.Drawing.Point(1254, 661);
            this.horVellbl.Name = "horVellbl";
            this.horVellbl.Size = new System.Drawing.Size(241, 35);
            this.horVellbl.TabIndex = 9;
            this.horVellbl.Text = "Horizontal Velocity: ";
            // 
            // vellbl
            // 
            this.vellbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.vellbl.AutoSize = true;
            this.vellbl.BackColor = System.Drawing.SystemColors.Control;
            this.vellbl.Font = new System.Drawing.Font("Calibri", 14F);
            this.vellbl.Location = new System.Drawing.Point(1255, 715);
            this.vellbl.Name = "vellbl";
            this.vellbl.Size = new System.Drawing.Size(232, 35);
            this.vellbl.TabIndex = 10;
            this.vellbl.Text = "Resultant Velocity: ";
            // 
            // anglelbl
            // 
            this.anglelbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.anglelbl.AutoSize = true;
            this.anglelbl.BackColor = System.Drawing.SystemColors.Control;
            this.anglelbl.Font = new System.Drawing.Font("Calibri", 14F);
            this.anglelbl.Location = new System.Drawing.Point(1564, 715);
            this.anglelbl.Name = "anglelbl";
            this.anglelbl.Size = new System.Drawing.Size(93, 35);
            this.anglelbl.TabIndex = 11;
            this.anglelbl.Text = "Angle: ";
            // 
            // distancelbl
            // 
            this.distancelbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.distancelbl.AutoSize = true;
            this.distancelbl.BackColor = System.Drawing.SystemColors.Control;
            this.distancelbl.Font = new System.Drawing.Font("Calibri", 14F);
            this.distancelbl.Location = new System.Drawing.Point(1497, 833);
            this.distancelbl.Name = "distancelbl";
            this.distancelbl.Size = new System.Drawing.Size(234, 35);
            this.distancelbl.TabIndex = 12;
            this.distancelbl.Text = "Distance Travelled: ";
            // 
            // heightlbl
            // 
            this.heightlbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.heightlbl.AutoSize = true;
            this.heightlbl.BackColor = System.Drawing.SystemColors.Control;
            this.heightlbl.Font = new System.Drawing.Font("Calibri", 14F);
            this.heightlbl.Location = new System.Drawing.Point(1255, 833);
            this.heightlbl.Name = "heightlbl";
            this.heightlbl.Size = new System.Drawing.Size(103, 35);
            this.heightlbl.TabIndex = 13;
            this.heightlbl.Text = "Height: ";
            // 
            // Yaxislbl
            // 
            this.Yaxislbl.AutoSize = true;
            this.Yaxislbl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Yaxislbl.Font = new System.Drawing.Font("Calibri", 12F);
            this.Yaxislbl.Location = new System.Drawing.Point(50, 30);
            this.Yaxislbl.Name = "Yaxislbl";
            this.Yaxislbl.Size = new System.Drawing.Size(116, 29);
            this.Yaxislbl.TabIndex = 14;
            this.Yaxislbl.Text = "Height (m)";
            // 
            // Xaxislbl
            // 
            this.Xaxislbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Xaxislbl.AutoSize = true;
            this.Xaxislbl.BackColor = System.Drawing.Color.Transparent;
            this.Xaxislbl.Font = new System.Drawing.Font("Calibri", 12F);
            this.Xaxislbl.Location = new System.Drawing.Point(1097, 886);
            this.Xaxislbl.Name = "Xaxislbl";
            this.Xaxislbl.Size = new System.Drawing.Size(136, 29);
            this.Xaxislbl.TabIndex = 15;
            this.Xaxislbl.Text = "Distance (m)";
            // 
            // drawTimer
            // 
            this.drawTimer.Enabled = true;
            this.drawTimer.Interval = 10;
            this.drawTimer.Tick += new System.EventHandler(this.drawTimer_Tick);
            // 
            // undobtn
            // 
            this.undobtn.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.undobtn.Location = new System.Drawing.Point(1335, 502);
            this.undobtn.Name = "undobtn";
            this.undobtn.Size = new System.Drawing.Size(97, 38);
            this.undobtn.TabIndex = 17;
            this.undobtn.Text = "UNDO";
            this.undobtn.UseVisualStyleBackColor = true;
            this.undobtn.Click += new System.EventHandler(this.undobtn_Click);
            // 
            // redobtn
            // 
            this.redobtn.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redobtn.Location = new System.Drawing.Point(1549, 502);
            this.redobtn.Name = "redobtn";
            this.redobtn.Size = new System.Drawing.Size(97, 38);
            this.redobtn.TabIndex = 18;
            this.redobtn.Text = "REDO";
            this.redobtn.UseVisualStyleBackColor = true;
            this.redobtn.Click += new System.EventHandler(this.redobtn_Click);
            // 
            // ProjectileMotion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1746, 958);
            this.Controls.Add(this.redobtn);
            this.Controls.Add(this.undobtn);
            this.Controls.Add(this.Xaxislbl);
            this.Controls.Add(this.Yaxislbl);
            this.Controls.Add(this.heightlbl);
            this.Controls.Add(this.distancelbl);
            this.Controls.Add(this.anglelbl);
            this.Controls.Add(this.vellbl);
            this.Controls.Add(this.horVellbl);
            this.Controls.Add(this.vertVellbl);
            this.Controls.Add(this.timelbl);
            this.Controls.Add(this.Cartesianlbl);
            this.Controls.Add(this.inputTabs);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1598, 858);
            this.Name = "ProjectileMotion";
            this.Text = "Projectile Motion";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ProjectileMotion_Paint);
            this.inputTabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InitialHeightUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InitialAngleUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InitialVelVertUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InitialVelHorUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InitialVelUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl inputTabs;
        private System.Windows.Forms.CheckBox checkInitialVel;
        private System.Windows.Forms.NumericUpDown InitialVelUpDown;
        private System.Windows.Forms.Label InitialVelHorLabel;
        private System.Windows.Forms.NumericUpDown InitialVelHorUpDown;
        private System.Windows.Forms.CheckBox checkInitialVelHor;
        private System.Windows.Forms.Label initialVelLable;
        private System.Windows.Forms.Label InitialVelVertLabel;
        private System.Windows.Forms.NumericUpDown InitialVelVertUpDown;
        private System.Windows.Forms.Label InitialAngleLabel;
        private System.Windows.Forms.NumericUpDown InitialAngleUpDown;
        private System.Windows.Forms.Label InitialHeightLabel;
        private System.Windows.Forms.NumericUpDown InitialHeightUpDown;
        private System.Windows.Forms.ComboBox comboInitialVel;
        private System.Windows.Forms.ComboBox comboInitialHor;
        private System.Windows.Forms.ComboBox comboInitialVert;
        private System.Windows.Forms.Label InitialAngleLbl;
        private System.Windows.Forms.ComboBox comboInitialHeight;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label Cartesianlbl;
        private System.Windows.Forms.Label timelbl;
        private System.Windows.Forms.Label vertVellbl;
        private System.Windows.Forms.Label horVellbl;
        private System.Windows.Forms.Label vellbl;
        private System.Windows.Forms.Label anglelbl;
        private System.Windows.Forms.Label distancelbl;
        private System.Windows.Forms.Label heightlbl;
        private System.Windows.Forms.Label Yaxislbl;
        private System.Windows.Forms.Label Xaxislbl;
        private System.Windows.Forms.Timer drawTimer;
        private System.Windows.Forms.CheckBox parabCheck;
        private System.Windows.Forms.Button undobtn;
        private System.Windows.Forms.Button redobtn;
    }
}

