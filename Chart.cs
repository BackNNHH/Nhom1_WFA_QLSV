using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Nhom1_WFA_QLSV
{
    public class AverageScoreChart
    {
        private Chart chart;
        private Series dailySeries;

        public AverageScoreChart(Chart chartControl)
        {
            chart = chartControl;
            InitializeChart();
        }

        private void InitializeChart()
        {
            chart.Series.Clear();
            chart.ChartAreas.Clear();
            chart.Titles.Clear();

            // Thêm vùng vẽ biểu đồ
            ChartArea chartArea = new ChartArea("MainArea")
            {
                AxisX = { Interval = 1 }
            };
            chart.ChartAreas.Add(chartArea);

            dailySeries = new Series("Điểm trung bình của tất cả viên theo ngày")
            {
                ChartType = SeriesChartType.Line,
                BorderWidth = 3,
                Color = System.Drawing.Color.Blue,
                MarkerStyle = MarkerStyle.Circle,
                MarkerSize = 8
            };

            chart.Series.Add(dailySeries);
            chart.Titles.Add("Biến động điểm trung bình của tất cả sinh viên theo ngày");
        }

        public void SetDailyAverageData(Dictionary<string, double> dailyAverages)
        {
            dailySeries.Points.Clear();
            int index = 0;
            foreach (var entry in dailyAverages)
            {
                DataPoint point = new DataPoint(index, entry.Value)
                {
                    AxisLabel = entry.Key   
                };
                dailySeries.Points.Add(point);
                index++;
            }
        }
    }
}
