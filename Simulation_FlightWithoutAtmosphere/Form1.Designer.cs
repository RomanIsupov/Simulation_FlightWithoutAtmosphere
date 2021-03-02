
namespace Simulation_FlightWithoutAtmosphere
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btStart = new System.Windows.Forms.Button();
            this.edHeight = new System.Windows.Forms.NumericUpDown();
            this.edSpeed = new System.Windows.Forms.NumericUpDown();
            this.edAngle = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btPause = new System.Windows.Forms.Button();
            this.labTime = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labTime);
            this.panel1.Controls.Add(this.btPause);
            this.panel1.Controls.Add(this.btStart);
            this.panel1.Controls.Add(this.edHeight);
            this.panel1.Controls.Add(this.edSpeed);
            this.panel1.Controls.Add(this.edAngle);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 0;
            // 
            // btStart
            // 
            this.btStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btStart.Location = new System.Drawing.Point(204, 12);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(80, 47);
            this.btStart.TabIndex = 6;
            this.btStart.Text = "Старт!";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // edHeight
            // 
            this.edHeight.Location = new System.Drawing.Point(82, 70);
            this.edHeight.Name = "edHeight";
            this.edHeight.Size = new System.Drawing.Size(98, 20);
            this.edHeight.TabIndex = 5;
            // 
            // edSpeed
            // 
            this.edSpeed.Location = new System.Drawing.Point(82, 39);
            this.edSpeed.Name = "edSpeed";
            this.edSpeed.Size = new System.Drawing.Size(98, 20);
            this.edSpeed.TabIndex = 4;
            this.edSpeed.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // edAngle
            // 
            this.edAngle.Location = new System.Drawing.Point(84, 12);
            this.edAngle.Name = "edAngle";
            this.edAngle.Size = new System.Drawing.Size(96, 20);
            this.edAngle.TabIndex = 3;
            this.edAngle.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Высота:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Скорость:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Угол:";
            // 
            // chart1
            // 
            chartArea3.AxisX.Maximum = 25D;
            chartArea3.AxisX.Minimum = 0D;
            chartArea3.AxisY.Maximum = 6D;
            chartArea3.AxisY.Minimum = 0D;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart1.Location = new System.Drawing.Point(0, 100);
            this.chart1.Name = "chart1";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(800, 350);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btPause
            // 
            this.btPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btPause.Location = new System.Drawing.Point(290, 12);
            this.btPause.Name = "btPause";
            this.btPause.Size = new System.Drawing.Size(80, 47);
            this.btPause.TabIndex = 7;
            this.btPause.Text = "Пауза";
            this.btPause.UseVisualStyleBackColor = true;
            this.btPause.Click += new System.EventHandler(this.btPause_Click);
            // 
            // labTime
            // 
            this.labTime.AutoSize = true;
            this.labTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labTime.Location = new System.Drawing.Point(205, 74);
            this.labTime.Name = "labTime";
            this.labTime.Size = new System.Drawing.Size(91, 16);
            this.labTime.TabIndex = 8;
            this.labTime.Text = "Time: 0.00 s";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.NumericUpDown edHeight;
        private System.Windows.Forms.NumericUpDown edSpeed;
        private System.Windows.Forms.NumericUpDown edAngle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btPause;
        private System.Windows.Forms.Label labTime;
    }
}

