using System;
using System.Web.UI;
using DevExpress.XtraCharts;
using DevExpress.XtraCharts.Web;
// ...

namespace RunTimeWebChart {
    public partial class _Default : Page {

        protected void ASPxButton1_Click(object sender, EventArgs e) {
            WebChartControl chart = new WebChartControl();

            // Add the chart to the form. Note that a chart isn't initialized,
            // until it's added to the form's collection of controls.
            this.Page.Form.Controls.Add(chart);

            // Create the first side-by-side bar series and add points to it.
            Series series1 = new Series("Bar Series", ViewType.Bar);
            series1.Points.Add(new SeriesPoint("I", new double[] { 10 }));
            series1.Points.Add(new SeriesPoint("II", new double[] { 12 }));
            series1.Points.Add(new SeriesPoint("III", new double[] { 14 }));
            series1.Points.Add(new SeriesPoint("IV", new double[] { 17 }));

            // Create the second side-by-side bar series and add points to it.
            Series series2 = new Series("Line Series", ViewType.Line);
            series2.Points.Add(new SeriesPoint("I", new double[] { 15 }));
            series2.Points.Add(new SeriesPoint("II", new double[] { 18 }));
            series2.Points.Add(new SeriesPoint("III", new double[] { 25 }));
            series2.Points.Add(new SeriesPoint("IV", new double[] { 33 }));

            // Add the series to the chart.
            chart.Series.AddRange(new Series[] { series1, series2 });

            // Hide the legend (if necessary).
            chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;

            // Rotate the diagram (if necessary).
            ((XYDiagram)chart.Diagram).Rotated = true;
  
        }
    }
}
