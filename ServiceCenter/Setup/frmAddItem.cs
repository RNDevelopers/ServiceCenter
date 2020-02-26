using ServiceCenter.Common;
using ServiceCenter.DBConnection;
using ServiceCenter.Enums;
using System;
using System.Data;
using System.Data.SqlClient;

namespace ServiceCenter.Setup
{
    public partial class frmAddItem : BaseUI
    {
        public frmAddItem()
        {
            InitializeComponent();
            SetFormName();
        }

        private void frmAddItem_Load(object sender, EventArgs e)
        {
            GetMainCategory();
            GetBrand();
            GetMeasureUnit();
        }
        public void GetMainCategory()
        {
            Execute objExecute = new Execute();
            DataTable dt = (DataTable)objExecute.Executes("spGetMainCategory", ReturnType.DataTable, CommandType.StoredProcedure);

            cmbMainCategory.DataSource = dt;
            cmbMainCategory.DisplayMember = "vcMainCategoryName";
            cmbMainCategory.ValueMember = "intMainCategoryID";
            cmbMainCategory.SelectedIndex = -1;
        }

        public void GetMeasureUnit()
        {
            Execute objExecute = new Execute();
            DataTable dt = (DataTable)objExecute.Executes("spGetMeasureUnit", ReturnType.DataTable, CommandType.StoredProcedure);

            cmbMeasureUnit.DataSource = dt;
            cmbMeasureUnit.DisplayMember = "vcMeasureUnit";
            cmbMeasureUnit.ValueMember = "intMeasureUnitID";
            cmbMeasureUnit.SelectedIndex = -1;
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

        private void cmbBrand_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetSubCat();
        }

        public void GetSubCat()
        {
            Execute objExecute = new Execute();
            string Query = "[dbo].[spGetBrandWiseSubCat]";
            SqlParameter[] para = new SqlParameter[]
              {
                      Execute.AddParameter("@intBrandID",Convert.ToInt32(cmbBrand.SelectedValue))

              };
            DataTable dt = (DataTable)objExecute.Executes(Query, ReturnType.DataTable, para, CommandType.StoredProcedure);

            cmbSubCat.DataSource = dt;
            cmbSubCat.DisplayMember = "vcSubCategoryName";
            cmbSubCat.ValueMember = "intSubCatDetailsID";
            cmbSubCat.SelectedIndex = -1;

        }

        private void cmbMeasureUnit_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetPackingMethods();
        }

        public void GetPackingMethods()
        {
            Execute objExecute = new Execute();
            string Query = "[dbo].[spGetPackingMethods]";
            SqlParameter[] para = new SqlParameter[]
              {
                      Execute.AddParameter("@intMeasureUnitID",Convert.ToInt32(cmbMeasureUnit.SelectedValue))

              };
            DataTable dt = (DataTable)objExecute.Executes(Query, ReturnType.DataTable, para, CommandType.StoredProcedure);

            cmbUnitQty.DataSource = dt;
            cmbUnitQty.DisplayMember = "decQty";
            cmbUnitQty.ValueMember = "intPackingMethodID";
            cmbUnitQty.SelectedIndex = -1;

        }

    }
}
