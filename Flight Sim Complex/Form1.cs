using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Simulation_Lab3
{
    public partial class Form1 : Form
    {
        Flight flight;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = "Time: 0";
            label7.Text = "Distance: 0";
            if (!timer1.Enabled)
            {
                chart1.Series[0].Points.Clear();
                flight = new Flight(inputHeight.Value, inputSpeed.Value, inputAngle.Value, inputSize.Value, inputWeight.Value);
                chart1.Series[0].Points.AddXY(flight.X, flight.Y);
                timer1.Start();
            }
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            flight.NextStep();
            label4.Text = "Time: " + flight.T;
            label7.Text = "Distance: " + flight.X;
            chart1.Series[0].Points.AddXY(flight.X, flight.Y);
            if (flight.Y <= 0)
            {
                timer1.Stop();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }
    }
}
