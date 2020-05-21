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
    public partial class frmCustomerReturnDetails : BaseUI
    {
        public frmCustomerReturnDetails()
        {
            InitializeComponent();
            SetFormName();
        }

        private void GetDateWiseCustomerReturnNO()
        {
            Execute objExecute = new Execute();
            string Query = "[dbo].[spGetDateWiseCustomerReturnNO]";
            SqlParameter[] para = new SqlParameter[]
              {
                   Execute.AddParameter("@dtFrom",dtFromDate.Value.Date),
                   Execute.AddParameter("@dtTo",dtToDate.Value.Date)

              };
            DataTable dt = (DataTable)objExecute.Executes(Query, ReturnType.DataTable, para, CommandType.StoredProcedure);

            cmbReturnNo.DataSource = dt;
            cmbReturnNo.DisplayMember = "vcCustomerReturnNo";
            cmbReturnNo.ValueMember = "intCustomerReturnHeaderID";
            cmbReturnNo.SelectedIndex = -1;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dtFromDate_CloseUp(object sender, EventArgs e)
        {
            GetDateWiseCustomerReturnNO();
        }

        private void dtToDate_CloseUp(object sender, EventArgs e)
        {
            GetDateWiseCustomerReturnNO();
        }

        private void cmbReturnNo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GridLoad();
        }

        private void LableFill()
        {

            lblContactNo.Text = String.Empty;
            lblIssueDate.Text = String.Empty;

            Execute objExecute = new Execute();
            string Query = "[dbo].[spGetIssueLableinfo]";
            SqlParameter[] para = new SqlParameter[]
              {
                     Execute.AddParameter("@intIssueHeaderID",Convert.ToInt32(cmbReturnNo.SelectedValue)),

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


        private void GridLoad()
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;

            Execute objExecuteXX = new Execute();
            string Query = "[dbo].[]";
            SqlParameter[] para = new SqlParameter[]
              {

                  Execute.AddParameter("@",Convert.ToInt32(cmbReturnNo.SelectedValue)),

              };
            DataTable dt = (DataTable)objExecuteXX.Executes(Query, ReturnType.DataTable, para, CommandType.StoredProcedure);

            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;

            dgvReturnItem.DataSource = null;
            dgvReturnItem.AutoGenerateColumns = false;
            dgvReturnItem.DataSource = dt;

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
