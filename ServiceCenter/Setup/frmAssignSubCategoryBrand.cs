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

namespace ServiceCenter.Setup
{
    public partial class frmAssignSubCategoryBrand : BaseUI
    {
        public frmAssignSubCategoryBrand()
        {
            InitializeComponent();
            this.SetFormName();
        }

        public void GetBrand()
        {
            Execute objExecute = new Execute();
            DataTable dt = (DataTable)objExecute.Executes("spGetBrand", ReturnType.DataTable, CommandType.StoredProcedure);

            cmbBrand.DataSource = dt;
            cmbBrand.DisplayMember = "vcName";
            cmbBrand.ValueMember = "intBrandID";
            cmbBrand.SelectedIndex = -1;
        }

        public void GetAllSubCat()
        {
            Execute objExecute = new Execute();
            DataTable dt = (DataTable)objExecute.Executes("spGetAllSubCat", ReturnType.DataTable, CommandType.StoredProcedure);

            cmbSubCat.DataSource = dt;
            cmbSubCat.DisplayMember = "vcSubCategoryName";
            cmbSubCat.ValueMember = "intSubCategoryID";
            cmbSubCat.SelectedIndex = -1;
        }

        private void frmAssignSubCategoryBrand_Load(object sender, EventArgs e)
        {
            GetBrand();
            GetAllSubCat();
        }

        private void cmbBrand_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetBrandWiseSubCat();
        }

        public void GetBrandWiseSubCat()
        {
            Execute objExecute = new Execute();
            string Query = "[dbo].[spGetBrandWiseSubCat]";
            SqlParameter[] para = new SqlParameter[]
              {
                      Execute.AddParameter("@intBrandID",Convert.ToInt32(cmbBrand.SelectedValue))

              };
            DataTable dt = (DataTable)objExecute.Executes(Query, ReturnType.DataTable, para, CommandType.StoredProcedure);

            dgvSubCat.DataSource = null;
            dgvSubCat.AutoGenerateColumns = false;
            dgvSubCat.DataSource = dt;

        }

        private void btnAssign_Click(object sender, EventArgs e)
        {

        }
    }
}
