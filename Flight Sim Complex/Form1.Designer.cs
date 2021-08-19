namespace Simulation_Lab3
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inputHeight = new System.Windows.Forms.NumericUpDown();
            this.inputAngle = new System.Windows.Forms.NumericUpDown();
            this.inputSpeed = new System.Windows.Forms.NumericUpDown();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.inputSize = new System.Windows.Forms.NumericUpDown();
            this.inputWeight = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inputHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Height:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Angle:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Speed:";
            // 
            // inputHeight
            // 
            this.inputHeight.Location = new System.Drawing.Point(63, 28);
            this.inputHeight.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.inputHeight.Name = "inputHeight";
            this.inputHeight.Size = new System.Drawing.Size(120, 20);
            this.inputHeight.TabIndex = 3;
            // 
            // inputAngle
            // 
            this.inputAngle.Location = new System.Drawing.Point(63, 80);
            this.inputAngle.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.inputAngle.Name = "inputAngle";
            this.inputAngle.Size = new System.Drawing.Size(120, 20);
            this.inputAngle.TabIndex = 4;
            // 
            // inputSpeed
            // 
            this.inputSpeed.Location = new System.Drawing.Point(63, 132);
            this.inputSpeed.Name = "inputSpeed";
            this.inputSpeed.Size = new System.Drawing.Size(120, 20);
            this.inputSpeed.TabIndex = 5;
            // 
            // chart1
            // 
            chartArea3.AxisX.Maximum = 100D;
            chartArea3.AxisX.Minimum = 0D;
            chartArea3.AxisY.Maximum = 20D;
            chartArea3.AxisY.Minimum = 0D;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(19, 177);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(561, 368);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(420, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Launch";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(210, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Time: 0";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(420, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Pause";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(210, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Size:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(210, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Weight:";
            // 
            // inputSize
            // 
            this.inputSize.DecimalPlaces = 2;
            this.inputSize.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.inputSize.Location = new System.Drawing.Point(260, 28);
            this.inputSize.Name = "inputSize";
            this.inputSize.Size = new System.Drawing.Size(120, 20);
            this.inputSize.TabIndex = 12;
            // 
            // inputWeight
            // 
            this.inputWeight.Location = new System.Drawing.Point(260, 80);
            this.inputWeight.Name = "inputWeight";
            this.inputWeight.Size = new System.Drawing.Size(120, 20);
            this.inputWeight.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(345, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Distance: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 566);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.inputWeight);
            this.Controls.Add(this.inputSize);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.inputSpeed);
            this.Controls.Add(this.inputAngle);
            this.Controls.Add(this.inputHeight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.inputHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputWeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown inputHeight;
        private System.Windows.Forms.NumericUpDown inputAngle;
        private System.Windows.Forms.NumericUpDown inputSpeed;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown inputSize;
        private System.Windows.Forms.NumericUpDown inputWeight;
        private System.Windows.Forms.Label label7;
    }
}

