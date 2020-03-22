using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceCenter.Common
{
    public partial class frmReportViewer : Form
    {
        bool PrintAtOnce = false;
        ToolStripButton objToolStripButton;
        ReportDocument RptReportDocument;
        bool IsPrint = false;
        public frmReportViewer()
        {
            InitializeComponent();
        }

        public frmReportViewer(ReportDocument rptReportDocument)
        {
            try
            {
                InitializeComponent();
                SetDBLogonForReport(rptReportDocument);
                crystalReportViewer1.ReportSource = rptReportDocument;
                crystalReportViewer1.ShowRefreshButton = false;
                RptReportDocument = rptReportDocument;

            }
            catch (Exception ex)
            {
                this.ClearGC();
                throw ex;
            }

        }

        public frmReportViewer(ReportDocument rptReportDocument, bool CanPrint, bool canExport)
        {
            try
            {
                InitializeComponent();
                SetDBLogonForReport(rptReportDocument);
                crystalReportViewer1.ReportSource = rptReportDocument;
                RptReportDocument = rptReportDocument;
                crystalReportViewer1.ShowExportButton = canExport;
                crystalReportViewer1.ShowPrintButton = CanPrint;
                crystalReportViewer1.ShowRefreshButton = false;
            }
            catch (Exception ex)
            {
                this.ClearGC();
                throw ex;
            }
        }

        public frmReportViewer(ReportDocument rptReportDocument, int intWorkOrderID)
        {
            try
            {
                InitializeComponent();
                RptReportDocument = rptReportDocument;
                SetDBLogonForReport(rptReportDocument);
                crystalReportViewer1.ReportSource = rptReportDocument;
                crystalReportViewer1.DisplayToolbar = false;
                crystalReportViewer1.ShowPrintButton = false;
                crystalReportViewer1.ShowRefreshButton = false;
                objToolStripButton = new ToolStripButton();
                objToolStripButton.Text = "Print";
                objToolStripButton.Name = intWorkOrderID.ToString();
                Size aa = new Size(50, 30);
                objToolStripButton.Size = aa;
            }
            catch (Exception ex)
            {
                this.ClearGC();
                throw ex;
            }
        }

        #region change the report data server according to app.config
        ConnectionInfo getConnectionInfo()
        {
            ConnectionInfo ConnInfo = new ConnectionInfo();
            SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnStr"].ToString());
            ConnInfo.UserID = "ramod";
            ConnInfo.Password = "123";
            ConnInfo.ServerName = con.DataSource;
            ConnInfo.DatabaseName = con.Database;
            return ConnInfo;
        }
        private void SetDBLogonForReport(ReportDocument reportDocument)
        {
            ConnectionInfo connectionInfo = getConnectionInfo();
            Tables tables = reportDocument.Database.Tables;
            foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
            {
                TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                tableLogonInfo.ConnectionInfo = connectionInfo;
                table.ApplyLogOnInfo(tableLogonInfo);
            }
        }
        #endregion

        private void frmReportViewer_Load(object sender, EventArgs e)
        {

        }

        private void frmReportViewer_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.ClearGC();
        }

        private void ClearGC()
        {
            string reportname = RptReportDocument.FilePath;
            RptReportDocument.Close();
            RptReportDocument.Dispose();
            GC.Collect();
            File.Delete(reportname);
        }
    }

}
