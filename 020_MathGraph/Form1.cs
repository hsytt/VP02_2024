﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace _020_MathGraph
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            chart1.ChartAreas[0].BackColor = Color.Black;

            //x축
            chart1.ChartAreas[0].AxisX.Minimum = -20;
            chart1.ChartAreas[0].AxisX.Maximum = 20;
            chart1.ChartAreas[0].AxisX.Interval = 2;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Gray;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            //y축
            chart1.ChartAreas[0].AxisY.Minimum = -2;
            chart1.ChartAreas[0].AxisY.Maximum = 2;
            chart1.ChartAreas[0].AxisY.Interval = 0.5;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.Gray;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            //Series 설정 : sin(x)/x
            chart1.Series[0].ChartType = SeriesChartType.Line;
            chart1.Series[0].Color = Color.LightGreen;
            chart1.Series[0].BorderWidth = 2;
            chart1.Series[0].LegendText = "sin(x)/x";

            //Series 하나 추가
            if(chart1.Series.Count == 1)
            {
                chart1.Series.Add("Cos");
            }            

            //Series 설정 : Cos(x)/x
            chart1.Series[1].ChartType = SeriesChartType.Line;
            chart1.Series[1].Color = Color.Orange;
            chart1.Series[1].BorderWidth = 2;
            chart1.Series[1].LegendText = "Cos(x)/x";

            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();

            for (double x = -20; x <= 20; x += 0.1)
            {
                double y = Math.Sin(x) / x;
                chart1.Series[0].Points.AddXY(x, y);

                y = Math.Cos(x) / x;
                chart1.Series[1].Points.AddXY(x, y); //Series["Cos"] = Series[1]
            }

        }
    }
}
