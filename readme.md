
*Files to look at*:

* [DesignerForm1.cs](./CS/DashboardDesigner_ControlAccess/DesignerForm1.cs) (VB: [DesignerForm1.vb](./VB/DashboardDesigner_ControlAccess/DesignerForm1.vb))

# How to Access the Underlying Controls of the Dashboard Items


This example demonstrates how to customize the controls used to visualize data in the dashboard items at runtime.

The following options are changed:

* [Grid](https://docs.devexpress.com/Dashboard/15150): The [DashboardDesigner.DashboardItemControlUpdated](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardDesigner.DashboardItemControlUpdated) event is handled to change **font**.
* [Chart](https://docs.devexpress.com/Dashboard/14719): The [DashboardDesigner.DashboardItemControlUpdated](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardDesigner.DashboardItemControlUpdated) event is handled to change the **background color** of the chart pane.
* [Pivot](https://docs.devexpress.com/Dashboard/15266): Cell values related to "Mountain" products are **hidden**. The [PivotGridControl.CustomCellValue](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotGridControl.CustomCellValue), [DashboardDesigner.DashboardItemControlCreated](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardDesigner.DashboardItemControlCreated) and [DashboardItemBeforeControlDisposed](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardDesigner.DashboardItemBeforeControlDisposed) events are handled.

![screenshot](/images/screenshot.png)

**See also:**

- [Access to Underlying Controls](https://docs.devexpress.com/Dashboard/401095/)