using CrystalDecisions.CrystalReports.Engine;
using ServiceCenter.Common;
using ServiceCenter.DBConnection;
using ServiceCenter.Enums;
using ServiceCenter.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceCenter.Views
{
    public partial class frmGoodsDetails : BaseUI
    {
        public frmGoodsDetails()
        {
            InitializeComponent();
            SetFormName();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            Report();
        }

        private void Report()
        {
            rptGoodsDetails rpt = new rptGoodsDetails();
            ReportDocument rptDoc = new ReportDocument();
     
            rptDoc = rpt;


            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;

            Execute objExecuteXX = new Execute();
            string Query = "[dbo].[spGetGoodsDetailsReport]";
            SqlParameter[] para = new SqlParameter[]
              {
                      Execute.AddParameter("@dtFrom",dtFrom.Value.Date),
                      Execute.AddParameter("@dtTo",dtTo.Value.Date)

              };
            DataTable dt = (DataTable)objExecuteXX.Executes(Query, ReturnType.DataTable, para, CommandType.StoredProcedure);

            if (dt != null && dt.Rows.Count > 0)
            {
                rpt.SetDataSource(dt);

                rpt.SetParameterValue("XXXFromDate", dtFrom.Value.Date);
                rpt.SetParameterValue("XXXToDate", dtTo.Value.Date);

                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;

                frmReportViewer objfrmReportViewer = new frmReportViewer(rptDoc);
                objfrmReportViewer.Show();



            }
            else {

                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
                MessageBox.Show("No Data For Selected Time Period");
            }
  


        }
    }
}
