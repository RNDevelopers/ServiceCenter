using ServiceCenter.Common;
using ServiceCenter.DBConnection;
using ServiceCenter.Enums;
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
    public partial class frmIssuesView : BaseUI
    {
        public frmIssuesView()
        {
            InitializeComponent();
            SetFormName();
        }


        private void GetIssueNo()
        {
            Execute objExecute = new Execute();
            string Query = "[dbo].[spGetDateWiseIssueNo]";
            SqlParameter[] para = new SqlParameter[]
              {
                   Execute.AddParameter("@dtFrom",dtFrom.Value.Date),
                   Execute.AddParameter("@dtTo",dtTo.Value.Date)

              };
            DataTable dt = (DataTable)objExecute.Executes(Query, ReturnType.DataTable, para, CommandType.StoredProcedure);

            cmbIssueNo.DataSource = dt;
            cmbIssueNo.DisplayMember = "vcIssueNo";
            cmbIssueNo.ValueMember = "intIssueHeaderID";
            cmbIssueNo.SelectedIndex = -1;

        }

        private void dtFrom_CloseUp(object sender, EventArgs e)
        {
            GetIssueNo();
        }

        private void dtTo_CloseUp(object sender, EventArgs e)
        {
            GetIssueNo();
        }

        private void cmbIssueNo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LableFill();
            GridLoad();
        }
         
        private void GridLoad()
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;

            Execute objExecuteXX = new Execute();
            string Query = "[dbo].[spGetIssueBillDetails]";
            SqlParameter[] para = new SqlParameter[]
              {

                  Execute.AddParameter("@intIssueHeaderID",Convert.ToInt32(cmbIssueNo.SelectedValue)),

              };
            DataTable dt = (DataTable)objExecuteXX.Executes(Query, ReturnType.DataTable, para, CommandType.StoredProcedure);

            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;

            dgvIssueItem.DataSource = null;
            dgvIssueItem.AutoGenerateColumns = false;
            dgvIssueItem.DataSource = dt;

        }


        private void LableFill()
        {

            lblContactNo.Text = String.Empty;
            lblIssueDate.Text = String.Empty;

            Execute objExecute = new Execute();
            string Query = "[dbo].[spGetIssueLableinfo]";
            SqlParameter[] para = new SqlParameter[]
              {
                     Execute.AddParameter("@intIssueHeaderID",Convert.ToInt32(cmbIssueNo.SelectedValue)),

              };
            DataSet ds = (DataSet)objExecute.Executes(Query, ReturnType.DataSet, para, CommandType.StoredProcedure);

            if (ds.Tables[0].Rows.Count > 0)
            {
                int ContactNo = Convert.ToInt32(ds.Tables[0].Rows[0]["intContactNo"].ToString());

                lblContactNo.Text = ContactNo.ToString();
                DateTime IssueDate;
                IssueDate = Convert.ToDateTime(ds.Tables[0].Rows[0]["dtIssueDate"].ToString());
                lblIssueDate.Text = IssueDate.ToString("MM/dd/yyyy");

            }

        }
    }
}
