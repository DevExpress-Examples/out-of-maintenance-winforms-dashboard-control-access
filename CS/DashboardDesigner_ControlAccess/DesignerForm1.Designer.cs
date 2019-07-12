namespace DashboardDesigner_ControlAccess
{
    partial class DesignerForm1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.dashboardBarAndDockingController1 = new DevExpress.DashboardWin.Native.DashboardBarAndDockingController(this.components);
            this.dashboardDesigner = new DevExpress.DashboardWin.DashboardDesigner();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardBarAndDockingController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardDesigner)).BeginInit();
            this.SuspendLayout();
            // 
            // dashboardBarAndDockingController1
            // 
            this.dashboardBarAndDockingController1.PropertiesBar.AllowLinkLighting = false;
            this.dashboardBarAndDockingController1.PropertiesDocking.ViewStyle = DevExpress.XtraBars.Docking2010.Views.DockingViewStyle.Classic;
            // 
            // dashboardDesigner
            // 
            this.dashboardDesigner.AllowMaximizeAnimation = true;
            this.dashboardDesigner.AllowMaximizeDashboardItems = true;
            this.dashboardDesigner.AllowPrintDashboard = true;
            this.dashboardDesigner.AllowPrintDashboardItems = true;
            this.dashboardDesigner.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dashboardDesigner.Appearance.Options.UseBackColor = true;
            this.dashboardDesigner.BarAndDockingController = this.dashboardBarAndDockingController1;
            this.dashboardDesigner.DataSourceWizard.ShowConnectionsFromAppConfig = true;
            this.dashboardDesigner.DataSourceWizard.SqlWizardSettings.DatabaseCredentialsSavingBehavior = DevExpress.DataAccess.Wizard.SensitiveInfoSavingBehavior.Prompt;
            this.dashboardDesigner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardDesigner.Location = new System.Drawing.Point(0, 0);
            this.dashboardDesigner.Name = "dashboardDesigner";
            this.dashboardDesigner.Size = new System.Drawing.Size(1200, 600);
            this.dashboardDesigner.TabIndex = 0;
            this.dashboardDesigner.UseNeutralFilterMode = true;
            this.dashboardDesigner.DashboardItemControlUpdated += new DevExpress.DashboardWin.DashboardItemControlUpdatedEventHandler(this.dashboardDesigner_DashboardItemControlUpdated);
            this.dashboardDesigner.DashboardItemControlCreated += new DevExpress.DashboardWin.DashboardItemControlCreatedEventHandler(this.dashboardDesigner_DashboardItemControlCreated);
            this.dashboardDesigner.DashboardItemBeforeControlDisposed += new DevExpress.DashboardWin.DashboardItemBeforeControlDisposedEventHandler(this.dashboardDesigner_DashboardItemBeforeControlDisposed);
            // 
            // DesignerForm1
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.dashboardDesigner);
            this.Name = "DesignerForm1";
            this.Text = "Dashboard Designer";
            ((System.ComponentModel.ISupportInitialize)(this.dashboardBarAndDockingController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardDesigner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.DashboardWin.DashboardDesigner dashboardDesigner;
        private DevExpress.DashboardWin.Native.DashboardBarAndDockingController dashboardBarAndDockingController1;
    }
}