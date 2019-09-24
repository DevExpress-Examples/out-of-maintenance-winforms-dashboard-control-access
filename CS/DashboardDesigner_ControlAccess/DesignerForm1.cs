using DevExpress.XtraCharts;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPivotGrid;
using System.Drawing;

namespace DashboardDesigner_ControlAccess
{
    public partial class DesignerForm1: DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public DesignerForm1() {
            InitializeComponent();
            dashboardDesigner.CreateRibbon();
            dashboardDesigner.LoadDashboard(@"..\..\Dashboards\dashboard1.xml");
        }

        private void dashboardDesigner_DashboardItemControlCreated(object sender, DevExpress.DashboardWin.DashboardItemControlEventArgs e) {
            if(e.DashboardItemName == "pivotDashboardItem1") {
                PivotGridControl pivotGridControl = e.PivotGridControl;
                pivotGridControl.CustomCellValue += PivotGridControl_CustomCellValue; ;
            }
        }

        private void PivotGridControl_CustomCellValue(object sender, PivotCellValueEventArgs e) {
            if (e.RowField == null) return;
            if (e.GetFieldValue(e.RowField).ToString().Contains("Mountain"))
                e.Value = "###";
        }

        private void dashboardDesigner_DashboardItemControlUpdated(object sender, DevExpress.DashboardWin.DashboardItemControlEventArgs e) {
            if(e.DashboardItemName == "gridDashboardItem1") {
                GridView gridView = e.GridControl.MainView as GridView;
                gridView.Appearance.Row.Font = new Font("Arial", 10);
            }
            if(e.DashboardItemName == "chartDashboardItem1") {
                ChartControl chartControl = e.ChartControl;
                ((XYDiagram)chartControl.Diagram).Panes[0].BackColor = Color.AliceBlue;
            }
        }

        private void dashboardDesigner_DashboardItemBeforeControlDisposed(object sender, DevExpress.DashboardWin.DashboardItemControlEventArgs e) {
            if(e.DashboardItemName == "pivotDashboardItem1") {
                PivotGridControl pivotGridControl = e.PivotGridControl;
                pivotGridControl.CustomCellValue -= PivotGridControl_CustomCellValue;
            }
        }
    }
}
