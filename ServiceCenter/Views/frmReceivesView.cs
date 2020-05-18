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


        private void GridLoad()
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;

            Execute objExecuteXX = new Execute();
            string Query = "[dbo].[spGetReceivesDetailsReport]";
            SqlParameter[] para = new SqlParameter[]
              {
                      Execute.AddParameter("@dtFrom",dtFrom.Value.Date),
                      Execute.AddParameter("@dtTo",dtTo.Value.Date)

              };
            DataTable dt = (DataTable)objExecuteXX.Executes(Query, ReturnType.DataTable, para, CommandType.StoredProcedure);


            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;

            dgvReceivesView.DataSource = null;
            dgvReceivesView.DataSource = dt;


        }

        private void dtFrom_CloseUp(object sender, EventArgs e)
        {
            GridLoad();
        }

        private void dtTo_CloseUp(object sender, EventArgs e)
        {
            GridLoad();
        }
    }
}
