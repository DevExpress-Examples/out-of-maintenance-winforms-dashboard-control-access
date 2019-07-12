Imports DevExpress.XtraCharts
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraPivotGrid
Imports System.Drawing

Namespace DashboardDesigner_ControlAccess
	Partial Public Class DesignerForm1
		Inherits DevExpress.XtraBars.Ribbon.RibbonForm

		Public Sub New()
			InitializeComponent()
			dashboardDesigner.CreateRibbon()
			dashboardDesigner.LoadDashboard("..\..\Dashboards\dashboard1.xml")
		End Sub

		Private Sub dashboardDesigner_DashboardItemControlCreated(ByVal sender As Object, ByVal e As DevExpress.DashboardWin.DashboardItemControlEventArgs) Handles dashboardDesigner.DashboardItemControlCreated
			If e.DashboardItemName = "pivotDashboardItem1" Then
				Dim pivotGridControl As PivotGridControl = e.PivotGridControl
				AddHandler pivotGridControl.CustomCellValue, AddressOf PivotGridControl_CustomCellValue

			End If
		End Sub

		Private Sub PivotGridControl_CustomCellValue(ByVal sender As Object, ByVal e As PivotCellValueEventArgs)
			If e.Value IsNot Nothing AndAlso CDbl(e.Value) < 200000 Then
				e.Value = 0
			End If
		End Sub

		Private Sub dashboardDesigner_DashboardItemControlUpdated(ByVal sender As Object, ByVal e As DevExpress.DashboardWin.DashboardItemControlEventArgs) Handles dashboardDesigner.DashboardItemControlUpdated
			If e.DashboardItemName = "gridDashboardItem1" Then
				Dim gridView As GridView = TryCast(e.GridControl.MainView, GridView)
				gridView.Appearance.Row.Font = New Font("Arial", 10)
			End If
			If e.DashboardItemName = "chartDashboardItem1" Then
				Dim chartControl As ChartControl = e.ChartControl
				CType(chartControl.Diagram, XYDiagram).Panes(0).BackColor = Color.AliceBlue
			End If
		End Sub

		Private Sub dashboardDesigner_DashboardItemBeforeControlDisposed(ByVal sender As Object, ByVal e As DevExpress.DashboardWin.DashboardItemControlEventArgs) Handles dashboardDesigner.DashboardItemBeforeControlDisposed
			If e.DashboardItemName = "pivotDashboardItem1" Then
				Dim pivotGridControl As PivotGridControl = e.PivotGridControl
				RemoveHandler pivotGridControl.CustomCellValue, AddressOf PivotGridControl_CustomCellValue
			End If
		End Sub
	End Class
End Namespace
