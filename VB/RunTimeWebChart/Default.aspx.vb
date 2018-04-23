Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.XtraCharts
Imports DevExpress.XtraCharts.Web
' ...

Namespace RunTimeWebChart
	Partial Public Class _Default
		Inherits Page

		Protected Sub ASPxButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim chart As New WebChartControl()

			' Add the chart to the form. Note that a chart isn't initialized,
			' until it's added to the form's collection of controls.
			Me.Page.Form.Controls.Add(chart)

			' Create the first side-by-side bar series and add points to it.
			Dim series1 As New Series("Bar Series", ViewType.Bar)
			series1.Points.Add(New SeriesPoint("I", New Double() { 10 }))
			series1.Points.Add(New SeriesPoint("II", New Double() { 12 }))
			series1.Points.Add(New SeriesPoint("III", New Double() { 14 }))
			series1.Points.Add(New SeriesPoint("IV", New Double() { 17 }))

			' Create the second side-by-side bar series and add points to it.
			Dim series2 As New Series("Line Series", ViewType.Line)
			series2.Points.Add(New SeriesPoint("I", New Double() { 15 }))
			series2.Points.Add(New SeriesPoint("II", New Double() { 18 }))
			series2.Points.Add(New SeriesPoint("III", New Double() { 25 }))
			series2.Points.Add(New SeriesPoint("IV", New Double() { 33 }))

			' Add the series to the chart.
			chart.Series.AddRange(New Series() { series1, series2 })

			' Hide the legend (if necessary).
			chart.Legend.Visible = False

			' Rotate the diagram (if necessary).
			CType(chart.Diagram, XYDiagram).Rotated = True

		End Sub
	End Class
End Namespace
