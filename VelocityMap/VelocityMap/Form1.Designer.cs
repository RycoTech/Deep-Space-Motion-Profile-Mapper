﻿namespace VelocityMap
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Field = new System.Windows.Forms.TabPage();
            this.mainField = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Data = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.DistancePlot = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.VelocityPlot = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.AnglePlot = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.save = new System.Windows.Forms.Button();
            this.apply = new System.Windows.Forms.Button();
            this.maxVelocity = new System.Windows.Forms.TextBox();
            this.timeSample = new System.Windows.Forms.TextBox();
            this.trackWidth = new System.Windows.Forms.TextBox();
            this.AccelRate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ClearCP = new System.Windows.Forms.Button();
            this.CTRE = new System.Windows.Forms.CheckBox();
            this.wheel = new System.Windows.Forms.TextBox();
            this.tolerence = new System.Windows.Forms.TextBox();
            this.offset = new System.Windows.Forms.TextBox();
            this.cpLoad = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.isntaVel = new System.Windows.Forms.CheckBox();
            this.invert = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SpeedLimit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.smoothness = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.deploy = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.TextBox();
            this.ipadd = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.profilename = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertAboveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertBelowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Direction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controlPoints = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.Field.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainField)).BeginInit();
            this.Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DistancePlot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VelocityPlot)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnglePlot)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.controlPoints)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.Field);
            this.tabControl1.Controls.Add(this.Data);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(464, 1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(797, 916);
            this.tabControl1.TabIndex = 1;
            // 
            // Field
            // 
            this.Field.Controls.Add(this.mainField);
            this.Field.Location = new System.Drawing.Point(4, 25);
            this.Field.Margin = new System.Windows.Forms.Padding(1);
            this.Field.Name = "Field";
            this.Field.Padding = new System.Windows.Forms.Padding(1);
            this.Field.Size = new System.Drawing.Size(789, 887);
            this.Field.TabIndex = 0;
            this.Field.Text = "Field";
            this.Field.UseVisualStyleBackColor = true;
            // 
            // mainField
            // 
            this.mainField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.mainField.ChartAreas.Add(chartArea1);
            this.mainField.Location = new System.Drawing.Point(1, 1);
            this.mainField.Name = "mainField";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.mainField.Series.Add(series1);
            this.mainField.Size = new System.Drawing.Size(787, 885);
            this.mainField.TabIndex = 4;
            this.mainField.Text = "chart2";
            this.mainField.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mainField_MouseClick);
            this.mainField.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainField_MouseDown);
            this.mainField.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainField_MouseMove);
            // 
            // Data
            // 
            this.Data.Controls.Add(this.splitContainer1);
            this.Data.Location = new System.Drawing.Point(4, 25);
            this.Data.Margin = new System.Windows.Forms.Padding(1);
            this.Data.Name = "Data";
            this.Data.Padding = new System.Windows.Forms.Padding(1);
            this.Data.Size = new System.Drawing.Size(672, 887);
            this.Data.TabIndex = 1;
            this.Data.Text = "Data";
            this.Data.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(1, 1);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(1);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.DistancePlot);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.VelocityPlot);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(670, 885);
            this.splitContainer1.SplitterDistance = 428;
            this.splitContainer1.TabIndex = 3;
            // 
            // DistancePlot
            // 
            chartArea2.Name = "ChartArea1";
            this.DistancePlot.ChartAreas.Add(chartArea2);
            this.DistancePlot.Dock = System.Windows.Forms.DockStyle.Top;
            this.DistancePlot.Location = new System.Drawing.Point(0, 0);
            this.DistancePlot.Name = "DistancePlot";
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series1";
            this.DistancePlot.Series.Add(series2);
            this.DistancePlot.Size = new System.Drawing.Size(670, 427);
            this.DistancePlot.TabIndex = 2;
            this.DistancePlot.Text = "chart2";
            // 
            // VelocityPlot
            // 
            chartArea3.Name = "ChartArea1";
            this.VelocityPlot.ChartAreas.Add(chartArea3);
            this.VelocityPlot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.VelocityPlot.Location = new System.Drawing.Point(0, 3);
            this.VelocityPlot.Name = "VelocityPlot";
            this.VelocityPlot.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            series3.ChartArea = "ChartArea1";
            series3.Name = "Series1";
            this.VelocityPlot.Series.Add(series3);
            this.VelocityPlot.Size = new System.Drawing.Size(670, 450);
            this.VelocityPlot.TabIndex = 1;
            this.VelocityPlot.Text = "chart2";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.AnglePlot);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(672, 887);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "More Data";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // AnglePlot
            // 
            chartArea4.Name = "ChartArea1";
            this.AnglePlot.ChartAreas.Add(chartArea4);
            this.AnglePlot.Dock = System.Windows.Forms.DockStyle.Top;
            this.AnglePlot.Location = new System.Drawing.Point(3, 3);
            this.AnglePlot.Name = "AnglePlot";
            series4.ChartArea = "ChartArea1";
            series4.Name = "Series1";
            this.AnglePlot.Series.Add(series4);
            this.AnglePlot.Size = new System.Drawing.Size(666, 431);
            this.AnglePlot.TabIndex = 3;
            this.AnglePlot.Text = "chart2";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(21, 152);
            this.save.Margin = new System.Windows.Forms.Padding(1);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(86, 21);
            this.save.TabIndex = 3;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.Save_Click);
            // 
            // apply
            // 
            this.apply.Location = new System.Drawing.Point(19, 110);
            this.apply.Margin = new System.Windows.Forms.Padding(1);
            this.apply.Name = "apply";
            this.apply.Size = new System.Drawing.Size(231, 34);
            this.apply.TabIndex = 3;
            this.apply.Text = "Apply";
            this.apply.UseVisualStyleBackColor = true;
            this.apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // maxVelocity
            // 
            this.maxVelocity.Location = new System.Drawing.Point(179, 17);
            this.maxVelocity.Margin = new System.Windows.Forms.Padding(1);
            this.maxVelocity.Name = "maxVelocity";
            this.maxVelocity.Size = new System.Drawing.Size(71, 22);
            this.maxVelocity.TabIndex = 4;
            this.maxVelocity.Text = "1000";
            this.maxVelocity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timeSample
            // 
            this.timeSample.Location = new System.Drawing.Point(179, 424);
            this.timeSample.Margin = new System.Windows.Forms.Padding(1);
            this.timeSample.Name = "timeSample";
            this.timeSample.Size = new System.Drawing.Size(71, 22);
            this.timeSample.TabIndex = 4;
            this.timeSample.Text = "10";
            this.timeSample.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.timeSample.Visible = false;
            // 
            // trackWidth
            // 
            this.trackWidth.Location = new System.Drawing.Point(179, 443);
            this.trackWidth.Margin = new System.Windows.Forms.Padding(1);
            this.trackWidth.Name = "trackWidth";
            this.trackWidth.Size = new System.Drawing.Size(71, 22);
            this.trackWidth.TabIndex = 4;
            this.trackWidth.Text = "838";
            this.trackWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.trackWidth.Visible = false;
            // 
            // AccelRate
            // 
            this.AccelRate.Location = new System.Drawing.Point(179, 462);
            this.AccelRate.Margin = new System.Windows.Forms.Padding(1);
            this.AccelRate.Name = "AccelRate";
            this.AccelRate.Size = new System.Drawing.Size(71, 22);
            this.AccelRate.TabIndex = 4;
            this.AccelRate.Text = "80";
            this.AccelRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AccelRate.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Max Velocity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 424);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Time (ms)";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 443);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Track Width";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 462);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Accel Filter (FL1)";
            this.label4.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(53, 312);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(1);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(133, 21);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Limit Max Speed";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            // 
            // ClearCP
            // 
            this.ClearCP.Location = new System.Drawing.Point(164, 175);
            this.ClearCP.Margin = new System.Windows.Forms.Padding(1);
            this.ClearCP.Name = "ClearCP";
            this.ClearCP.Size = new System.Drawing.Size(86, 21);
            this.ClearCP.TabIndex = 3;
            this.ClearCP.Text = "Clear";
            this.ClearCP.UseVisualStyleBackColor = true;
            this.ClearCP.Click += new System.EventHandler(this.ClearCP_Click);
            // 
            // CTRE
            // 
            this.CTRE.AutoSize = true;
            this.CTRE.Checked = true;
            this.CTRE.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CTRE.Location = new System.Drawing.Point(21, 75);
            this.CTRE.Margin = new System.Windows.Forms.Padding(1);
            this.CTRE.Name = "CTRE";
            this.CTRE.Size = new System.Drawing.Size(111, 21);
            this.CTRE.TabIndex = 6;
            this.CTRE.Text = "CTRE output";
            this.CTRE.UseVisualStyleBackColor = true;
            // 
            // wheel
            // 
            this.wheel.Location = new System.Drawing.Point(205, 73);
            this.wheel.Margin = new System.Windows.Forms.Padding(1);
            this.wheel.Name = "wheel";
            this.wheel.Size = new System.Drawing.Size(45, 22);
            this.wheel.TabIndex = 4;
            this.wheel.Text = "4";
            this.wheel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tolerence
            // 
            this.tolerence.Enabled = false;
            this.tolerence.Location = new System.Drawing.Point(138, 331);
            this.tolerence.Margin = new System.Windows.Forms.Padding(1);
            this.tolerence.Name = "tolerence";
            this.tolerence.Size = new System.Drawing.Size(71, 22);
            this.tolerence.TabIndex = 7;
            this.tolerence.Text = "660";
            this.tolerence.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tolerence.Visible = false;
            // 
            // offset
            // 
            this.offset.Enabled = false;
            this.offset.Location = new System.Drawing.Point(138, 350);
            this.offset.Margin = new System.Windows.Forms.Padding(1);
            this.offset.Name = "offset";
            this.offset.Size = new System.Drawing.Size(71, 22);
            this.offset.TabIndex = 8;
            this.offset.Text = "50";
            this.offset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.offset.Visible = false;
            // 
            // cpLoad
            // 
            this.cpLoad.Location = new System.Drawing.Point(164, 152);
            this.cpLoad.Margin = new System.Windows.Forms.Padding(1);
            this.cpLoad.Name = "cpLoad";
            this.cpLoad.Size = new System.Drawing.Size(86, 21);
            this.cpLoad.TabIndex = 3;
            this.cpLoad.Text = "Load";
            this.cpLoad.UseVisualStyleBackColor = true;
            this.cpLoad.Click += new System.EventHandler(this.Load_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(18, 333);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Velocity Offset";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(18, 352);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Vel Tolerence";
            this.label6.Visible = false;
            // 
            // isntaVel
            // 
            this.isntaVel.Location = new System.Drawing.Point(58, 372);
            this.isntaVel.Margin = new System.Windows.Forms.Padding(1);
            this.isntaVel.Name = "isntaVel";
            this.isntaVel.Size = new System.Drawing.Size(99, 21);
            this.isntaVel.TabIndex = 6;
            this.isntaVel.Text = "Inst Velocity";
            this.isntaVel.UseVisualStyleBackColor = true;
            this.isntaVel.Visible = false;
            // 
            // invert
            // 
            this.invert.Location = new System.Drawing.Point(21, 175);
            this.invert.Margin = new System.Windows.Forms.Padding(1);
            this.invert.Name = "invert";
            this.invert.Size = new System.Drawing.Size(86, 21);
            this.invert.TabIndex = 3;
            this.invert.Text = "Invert";
            this.invert.UseVisualStyleBackColor = true;
            this.invert.Click += new System.EventHandler(this.Invert_Click);
            // 
            // SpeedLimit
            // 
            this.SpeedLimit.Location = new System.Drawing.Point(179, 481);
            this.SpeedLimit.Margin = new System.Windows.Forms.Padding(1);
            this.SpeedLimit.Name = "SpeedLimit";
            this.SpeedLimit.Size = new System.Drawing.Size(71, 22);
            this.SpeedLimit.TabIndex = 4;
            this.SpeedLimit.Text = "2.5";
            this.SpeedLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SpeedLimit.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 481);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Speed Limit Factor";
            this.label7.Visible = false;
            // 
            // smoothness
            // 
            this.smoothness.Location = new System.Drawing.Point(205, 45);
            this.smoothness.Margin = new System.Windows.Forms.Padding(1);
            this.smoothness.Name = "smoothness";
            this.smoothness.Size = new System.Drawing.Size(45, 22);
            this.smoothness.TabIndex = 8;
            this.smoothness.Text = "10";
            this.smoothness.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 48);
            this.label8.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Smoothing";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(136, 75);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(87, 17);
            this.Label9.TabIndex = 9;
            this.Label9.Text = "Wheel Size :";
            // 
            // deploy
            // 
            this.deploy.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deploy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.deploy.Location = new System.Drawing.Point(293, 25);
            this.deploy.Name = "deploy";
            this.deploy.Size = new System.Drawing.Size(140, 46);
            this.deploy.TabIndex = 11;
            this.deploy.Text = "Deploy";
            this.deploy.UseVisualStyleBackColor = true;
            this.deploy.Click += new System.EventHandler(this.deploy_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(290, 172);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 17);
            this.label11.TabIndex = 12;
            this.label11.Text = "Username:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(286, 235);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 17);
            this.label12.TabIndex = 13;
            this.label12.Text = "Ip-Address:";
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(346, 169);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(100, 22);
            this.user.TabIndex = 14;
            this.user.Text = "lvuser";
            // 
            // ipadd
            // 
            this.ipadd.Location = new System.Drawing.Point(346, 232);
            this.ipadd.Name = "ipadd";
            this.ipadd.Size = new System.Drawing.Size(100, 22);
            this.ipadd.TabIndex = 15;
            this.ipadd.Text = "10.35.39.2";
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(346, 201);
            this.pass.Name = "pass";
            this.pass.PasswordChar = '*';
            this.pass.Size = new System.Drawing.Size(100, 22);
            this.pass.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(290, 204);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 17);
            this.label13.TabIndex = 17;
            this.label13.Text = "Password:";
            // 
            // profilename
            // 
            this.profilename.Location = new System.Drawing.Point(346, 138);
            this.profilename.Name = "profilename";
            this.profilename.Size = new System.Drawing.Size(100, 22);
            this.profilename.TabIndex = 22;
            this.profilename.Text = "AUSA";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(279, 141);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 17);
            this.label15.TabIndex = 21;
            this.label15.Text = "Profile Name:";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.moveUpToolStripMenuItem,
            this.moveDownToolStripMenuItem,
            this.insertAboveToolStripMenuItem,
            this.insertBelowToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(162, 124);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.Delete_Click);
            // 
            // moveUpToolStripMenuItem
            // 
            this.moveUpToolStripMenuItem.Name = "moveUpToolStripMenuItem";
            this.moveUpToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.moveUpToolStripMenuItem.Text = "Move Up";
            this.moveUpToolStripMenuItem.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // moveDownToolStripMenuItem
            // 
            this.moveDownToolStripMenuItem.Name = "moveDownToolStripMenuItem";
            this.moveDownToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.moveDownToolStripMenuItem.Text = "Move Down";
            this.moveDownToolStripMenuItem.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // insertAboveToolStripMenuItem
            // 
            this.insertAboveToolStripMenuItem.Name = "insertAboveToolStripMenuItem";
            this.insertAboveToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.insertAboveToolStripMenuItem.Text = "Insert Above";
            this.insertAboveToolStripMenuItem.Click += new System.EventHandler(this.insertAbove_Click);
            // 
            // insertBelowToolStripMenuItem
            // 
            this.insertBelowToolStripMenuItem.Name = "insertBelowToolStripMenuItem";
            this.insertBelowToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.insertBelowToolStripMenuItem.Text = "Insert Below";
            this.insertBelowToolStripMenuItem.Click += new System.EventHandler(this.insertBelow_Click);
            // 
            // Direction
            // 
            this.Direction.Frozen = true;
            this.Direction.HeaderText = "Direction(+/-)";
            this.Direction.MaxInputLength = 1;
            this.Direction.Name = "Direction";
            this.Direction.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // y
            // 
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.y.DefaultCellStyle = dataGridViewCellStyle1;
            this.y.Frozen = true;
            this.y.HeaderText = "Y";
            this.y.Name = "y";
            this.y.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.y.Width = 58;
            // 
            // x
            // 
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.x.DefaultCellStyle = dataGridViewCellStyle2;
            this.x.Frozen = true;
            this.x.HeaderText = "X";
            this.x.Name = "x";
            this.x.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.x.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.x.Width = 58;
            // 
            // controlPoints
            // 
            this.controlPoints.AllowUserToResizeColumns = false;
            this.controlPoints.AllowUserToResizeRows = false;
            this.controlPoints.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.controlPoints.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.controlPoints.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.controlPoints.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.controlPoints.ColumnHeadersHeight = 20;
            this.controlPoints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.controlPoints.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.x,
            this.y,
            this.Direction});
            this.controlPoints.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.controlPoints.Location = new System.Drawing.Point(19, 204);
            this.controlPoints.Margin = new System.Windows.Forms.Padding(1);
            this.controlPoints.MultiSelect = false;
            this.controlPoints.Name = "controlPoints";
            this.controlPoints.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.controlPoints.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.controlPoints.RowHeadersWidth = 20;
            this.controlPoints.RowTemplate.Height = 40;
            this.controlPoints.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.controlPoints.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.controlPoints.Size = new System.Drawing.Size(231, 702);
            this.controlPoints.TabIndex = 2;
            this.controlPoints.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.controlPoints_CellEndEdit);
            this.controlPoints.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.controlPoints_CellMouseUp);
            this.controlPoints.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.controlPoints_RowStateChange);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1249, 916);
            this.Controls.Add(this.profilename);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.ipadd);
            this.Controls.Add(this.user);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.deploy);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.smoothness);
            this.Controls.Add(this.offset);
            this.Controls.Add(this.tolerence);
            this.Controls.Add(this.isntaVel);
            this.Controls.Add(this.CTRE);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wheel);
            this.Controls.Add(this.SpeedLimit);
            this.Controls.Add(this.AccelRate);
            this.Controls.Add(this.trackWidth);
            this.Controls.Add(this.timeSample);
            this.Controls.Add(this.maxVelocity);
            this.Controls.Add(this.invert);
            this.Controls.Add(this.apply);
            this.Controls.Add(this.ClearCP);
            this.Controls.Add(this.cpLoad);
            this.Controls.Add(this.save);
            this.Controls.Add(this.controlPoints);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Byting Bulldogs (3539) - Motion Profiler Creator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Field.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainField)).EndInit();
            this.Data.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DistancePlot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VelocityPlot)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AnglePlot)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.controlPoints)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Field;
        private System.Windows.Forms.TabPage Data;
        private System.Windows.Forms.DataVisualization.Charting.Chart VelocityPlot;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button apply;
        private System.Windows.Forms.DataVisualization.Charting.Chart mainField;
        private System.Windows.Forms.TextBox maxVelocity;
        private System.Windows.Forms.TextBox timeSample;
        private System.Windows.Forms.TextBox trackWidth;
        private System.Windows.Forms.TextBox AccelRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button ClearCP;
        private System.Windows.Forms.CheckBox CTRE;
        private System.Windows.Forms.TextBox wheel;
        private System.Windows.Forms.DataVisualization.Charting.Chart DistancePlot;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox tolerence;
        private System.Windows.Forms.TextBox offset;
        private System.Windows.Forms.Button cpLoad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox isntaVel;
        private System.Windows.Forms.Button invert;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox SpeedLimit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox smoothness;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Label9;
        private System.Windows.Forms.Button deploy;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.TextBox ipadd;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox profilename;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveDownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertAboveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertBelowToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataVisualization.Charting.Chart AnglePlot;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direction;
        private System.Windows.Forms.DataGridViewTextBoxColumn y;
        private System.Windows.Forms.DataGridViewTextBoxColumn x;
        private System.Windows.Forms.DataGridView controlPoints;
    }
}

