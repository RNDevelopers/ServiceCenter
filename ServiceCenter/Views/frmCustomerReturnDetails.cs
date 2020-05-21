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
    }
}
