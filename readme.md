
*Files to look at*:

* [DesignerForm1.cs](./CS/DashboardDesigner_ControlAccess/DesignerForm1.cs) (VB: [DesignerForm1.vb](./VB/DashboardDesigner_ControlAccess/DesignerForm1.vb))

# How to access API of underlying controls in the WinForms Designer


The following example demonstrates how to customize controls used to visualize data within dashboard items at runtime using [DashboardViewer](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer)'s API. 

In this example, the following options are changed:
- **Grid**: The font of data rows' text is changed in the underlying grid control in the [DashboardDesigner.DashboardItemControlUpdated](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardDesigner.DashboardItemControlUpdated) event.
- **Chart**: The background color of the chart's pane is changed in the [DashboardDesigner.DashboardItemControlUpdated](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardDesigner.DashboardItemControlUpdated) event handler.
- **Pivot**: Values of data cells in the underlying pivot grid control are customized using the [PivotGridControl.CustomCellValue](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotGridControl.CustomCellValue) event. Subscription and unsubscription to/from the CustomCellValue event are performed in the [DashboardDesigner.DashboardItemControlCreated](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardDesigner.DashboardItemControlCreated) and [DashboardItemBeforeControlDisposed](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardDesigner.DashboardItemBeforeControlDisposed) event handlers respectively.

## See Also
- [Access to Underlying Controls](https://docs.devexpress.com/Dashboard/401095/)