Imports DevExpress.XtraCharts
Imports DevExpress.XtraGauges.Core.Drawing
Imports DevExpress.XtraGauges.Win.Gauges.Circular
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

        Private Sub dashboardDesigner_DashboardItemControlCreated(ByVal sender As Object,
                                                                  ByVal e As DevExpress.DashboardWin.DashboardItemControlEventArgs) _
                                                                  Handles dashboardDesigner.DashboardItemControlCreated
            ' For all Pivot items in the dashboard:
            If e.DashboardItemName = "pivotDashboardItem1" Then
                Dim pivotGridControl As PivotGridControl = e.PivotGridControl
                AddHandler pivotGridControl.CustomCellValue, AddressOf PivotGridControl_CustomCellValue

            End If
        End Sub

        Private Sub PivotGridControl_CustomCellValue(ByVal sender As Object, ByVal e As PivotCellValueEventArgs)
            If e.RowField Is Nothing Then
                Return
            End If
            If e.GetFieldValue(e.RowField).ToString().Contains("Mountain") Then
                e.Value = "###"
            End If
        End Sub

        Private Sub dashboardDesigner_DashboardItemControlUpdated(ByVal sender As Object,
                                                                  ByVal e As DevExpress.DashboardWin.DashboardItemControlEventArgs) _
                                                                  Handles dashboardDesigner.DashboardItemControlUpdated
            ' For all Grid items in the dashboard:
            If e.GridControl IsNot Nothing Then
                Dim gridView As GridView = TryCast(e.GridControl.MainView, GridView)
                gridView.Appearance.Row.Font = New Font("Arial", 10)
            End If
            ' For all Pivot items in the dashboard:
            If e.DashboardItemName = "chartDashboardItem1" Then
                Dim chartControl As ChartControl = e.ChartControl
                CType(chartControl.Diagram, XYDiagram).Panes(0).BackColor = Color.LightYellow
            End If
            ' For a specific Gauge item in the dashboard:
            If e.DashboardItemName = "gaugeDashboardItem1" Then
                Dim gauge = TryCast(e.GaugeControl.Gauges(0), CircularGauge)
                gauge.Labels(0).AppearanceBackground.ContentBrush = New SolidBrushObject(Color.LightGreen)
                gauge.Labels(0).Text = "Custom Revenue Label"
                gauge.Labels(0).AppearanceText.Font = New Font("Tahoma", 16)
                gauge.Scales(0).MajorTickCount = 8
            End If
        End Sub

        Private Sub dashboardDesigner_DashboardItemBeforeControlDisposed(ByVal sender As Object,
                                                                         ByVal e As DevExpress.DashboardWin.DashboardItemControlEventArgs) _
                                                                         Handles dashboardDesigner.DashboardItemBeforeControlDisposed
            If e.DashboardItemName = "pivotDashboardItem1" Then
                Dim pivotGridControl As PivotGridControl = e.PivotGridControl
                RemoveHandler pivotGridControl.CustomCellValue, AddressOf PivotGridControl_CustomCellValue
            End If
        End Sub
    End Class
End Namespace
