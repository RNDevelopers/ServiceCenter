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
    public partial class frmReceivesView : BaseUI
    {
        public frmReceivesView()
        {
            InitializeComponent();
            SetFormName();
        }

        private void LableFill()
        {

            lblGRNDate.Text = String.Empty;
            lblSupName.Text = String.Empty;

            Execute objExecute = new Execute();
            string Query = "[dbo].[spGetGRNLableinfo]";
            SqlParameter[] para = new SqlParameter[]
              {
                     Execute.AddParameter("@intGRNHeaderID",Convert.ToInt32(cmbGRNNo.SelectedValue)),

              };
            DataSet ds = (DataSet)objExecute.Executes(Query, ReturnType.DataSet, para, CommandType.StoredProcedure);

            if (ds.Tables[0].Rows.Count > 0)
            {


                lblSupName.Text = ds.Tables[0].Rows[0]["vcSupplierName"].ToString();
                DateTime dtGRNdate;
                dtGRNdate = Convert.ToDateTime(ds.Tables[0].Rows[0]["dtGRNDate"].ToString());
                lblGRNDate.Text = dtGRNdate.ToString("MM/dd/yyyy");

            }

        }


        private void GridLoad()
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;

            Execute objExecuteXX = new Execute();
            string Query = "[dbo].[spGetReceivesDetailsReport]";
            SqlParameter[] para = new SqlParameter[]
              {

                  Execute.AddParameter("@intGRNHeaderID",Convert.ToInt32(cmbGRNNo.SelectedValue)),

              };
            DataTable dt = (DataTable)objExecuteXX.Executes(Query, ReturnType.DataTable, para, CommandType.StoredProcedure);

            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;

            dgvReceivesView.DataSource = null;
            dgvReceivesView.AutoGenerateColumns = false;
            dgvReceivesView.DataSource = dt;

        }

        private void GetGRNNo()
        {
            Execute objExecute = new Execute();
            string Query = "[dbo].[spGetDateWiseGRNNo]"; 
            SqlParameter[] para = new SqlParameter[]
              {
                   Execute.AddParameter("@dtFrom",dtFrom.Value.Date),
                   Execute.AddParameter("@dtTo",dtTo.Value.Date)

              };
            DataTable dt = (DataTable)objExecute.Executes(Query, ReturnType.DataTable, para, CommandType.StoredProcedure);

            cmbGRNNo.DataSource = dt;
            cmbGRNNo.DisplayMember = "vcGRNNo";
            cmbGRNNo.ValueMember = "intGRNHeaderID";
            cmbGRNNo.SelectedIndex = -1;

        }

        private void dtFrom_CloseUp(object sender, EventArgs e)
        {
            GetGRNNo();
        }

        private void dtTo_CloseUp(object sender, EventArgs e)
        {
            GetGRNNo();
        }

        private void cmbGRNNo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GridLoad();
            LableFill();
        }
    }
}
