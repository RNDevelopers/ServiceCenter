using ServiceCenter.Common;
using ServiceCenter.DBConnection;
using ServiceCenter.Enums;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ServiceCenter.Setup
{
    public partial class frmAddSubCategory : BaseUI
    {
        public frmAddSubCategory()
        {
            InitializeComponent();
            this.SetFormName();

            GetMainCategory();
            GetBrand();
            GetItemUnit();

            //from Ramod

            //fromn nethsara
        }

        //public void GetCompany()
        //{
        //    Execute objExecute = new Execute();
        //    DataTable dt = (DataTable)objExecute.Executes("spGetAllCompany", ReturnType.DataTable, CommandType.StoredProcedure);

        //    cmbCompanyName.DataSource = dt;
        //    cmbCompanyName.DisplayMember = "vcCompanyName";
        //    cmbCompanyName.ValueMember = "intCompanyID";
        //    cmbCompanyName.SelectedIndex = -1;
        //}

        public void GetMainCategory()
        {
            Execute objExecute = new Execute();
            DataTable dt = (DataTable)objExecute.Executes("spGetMainCategory", ReturnType.DataTable, CommandType.StoredProcedure);

            cmbMainCategory.DataSource = dt;
            cmbMainCategory.DisplayMember = "vcMainCategoryName";
            cmbMainCategory.ValueMember = "intMainCategoryID";
            cmbMainCategory.SelectedIndex = -1;
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

        public void GetItemUnit()
        {
            Execute objExecute = new Execute();
            DataTable dt = (DataTable)objExecute.Executes("spGetItemUnit", ReturnType.DataTable, CommandType.StoredProcedure);

            cmbUnit.DataSource = dt;
            cmbUnit.DisplayMember = "vcUnitDesc";
            cmbUnit.ValueMember = "intUnitID";
            cmbUnit.SelectedIndex = -1;
        }

        private void cmbBrand_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtSubCategory.Text = (cmbBrand.Text.ToString() + ' ' + '-' + ' ');
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveSubCategory();
        }

        public void SaveSubCategory()
        {
            DialogResult dr = MessageBox.Show("Are You Sure Want to Add Sub Category ?", "CONFIRM", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {

                Execute objExecute = new Execute();
                SqlParameter[] param = new SqlParameter[]
                   {
                   // Execute.AddParameter("@MainCategoryName",Text.Trim()),
                  //   Execute.AddParameter("@vcItemCode",txtCategoryCode.Text.Trim()),
                     Execute.AddParameter("@intMainCategoryID",Convert.ToInt32(cmbMainCategory.SelectedValue)),
                     Execute.AddParameter("@intBrandID",Convert.ToInt32(cmbBrand.SelectedValue)),
                     Execute.AddParameter("@intUnitID",Convert.ToInt32(cmbUnit.SelectedValue)),
                     Execute.AddParameter("@vcSubCategoryName",txtSubCategory.Text.Trim().ToUpper()),
                   };

                int NoOfRowsEffected = objExecute.Executes("SaveSubCategory", param, CommandType.StoredProcedure);

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
