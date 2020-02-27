using ServiceCenter.Common;
using ServiceCenter.DBConnection;
using ServiceCenter.Enums;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveItem();
        }

        public void SaveItem()
        {
            DialogResult dr = MessageBox.Show("Are You Sure Want to Add Item ?", "CONFIRM", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {

                Execute objExecute = new Execute();
                SqlParameter[] param = new SqlParameter[]
                   {
                    Execute.AddParameter("@intMainCategoryID",Convert.ToInt32(cmbMainCategory.SelectedValue)),
                    Execute.AddParameter("@intBrandID",Convert.ToInt32(cmbBrand.SelectedValue)),
                    Execute.AddParameter("@intSubCatDetailsID",Convert.ToInt32(cmbSubCat.SelectedValue)),
                    Execute.AddParameter("@IntPackingMethodID",Convert.ToInt32(cmbUnitQty.SelectedValue)),
                    Execute.AddParameter("@decStockInHand",Convert.ToDecimal(txtStockHand.Text.Trim())),
                    Execute.AddParameter("@decUnitPrice",Convert.ToDecimal(txtUnitPrice.Text.Trim())),
                    Execute.AddParameter("@vcItemCode",txtItemCode.Text.ToUpper()),
                    Execute.AddParameter("@vcItemDescription",txtDec.Text.ToUpper())
                   };

                int NoOfRowsEffected = objExecute.Executes("spSaveItem", param, CommandType.StoredProcedure);

                if (NoOfRowsEffected < 0)
                {
                    MessageBox.Show("Save..");
                }
                else
                {
                    MessageBox.Show("Cant't Save..");
                }
            }
        }
    }
}
