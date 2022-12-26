using DevExpress.XtraCharts;
using DevExpress.XtraGauges.Core.Drawing;
using DevExpress.XtraGauges.Win.Gauges.Circular;
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
            if (e.PivotGridControl != null) {
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
            if(e.GridControl!= null) {
                GridView gridView = e.GridControl.MainView as GridView;
                gridView.Appearance.Row.Font = new Font("Arial", 10);
            }
            if(e.DashboardItemName == "chartDashboardItem1") {
                ChartControl chartControl = e.ChartControl;
                ((XYDiagram)chartControl.Diagram).Panes[0].BackColor = Color.LightYellow;
            }
            if (e.DashboardItemName == "gaugeDashboardItem1") {
                var gauge = e.GaugeControl.Gauges[0] as CircularGauge;
                gauge.Labels[0].AppearanceBackground.ContentBrush = new SolidBrushObject(Color.LightGreen);
                gauge.Labels[0].Text = "Custom Revenue Label";
                gauge.Labels[0].AppearanceText.Font = new Font("Tahoma", 16);
                gauge.Scales[0].MajorTickCount = 8;
            }
        }

        private void dashboardDesigner_DashboardItemBeforeControlDisposed(object sender, DevExpress.DashboardWin.DashboardItemControlEventArgs e) {
            if(e.PivotGridControl != null) {
                PivotGridControl pivotGridControl = e.PivotGridControl;
                pivotGridControl.CustomCellValue -= PivotGridControl_CustomCellValue;
            }
        }
    }
}
