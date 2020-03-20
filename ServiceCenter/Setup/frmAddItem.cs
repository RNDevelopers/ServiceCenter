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

        public string ItemCode { get; set; }


        public Nullable<int> intAPIID { get; set; }
        public Nullable<int> intSAEID { get; set; }
        public Nullable<int> intEngineTypeID { get; set; }


        public frmAddItem()
        {
            InitializeComponent();
            SetFormName();

            cmbAPI.Enabled = false;
            cmbSAE.Enabled = false;
            cmbEngineType.Enabled = false;
        }

        private void frmAddItem_Load(object sender, EventArgs e)
        {
            cmbAPI.Visible = false;
            cmbSAE.Visible = false;
            cmbEngineType.Visible = false;


            lbl1.Visible = false;
            lbl11.Visible = false;
            lbl2.Visible = false;
            lbl22.Visible = false;
            lbl3.Visible = false;
            lbl33.Visible = false;


            GetMainCategory();
            GetBrand();
            GetMeasureUnit();

            GetAPI();
            GetSAE();
            GetEngineType();

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



        //==============================================================================
        public void GetEngineType()
        {
            Execute objExecute = new Execute();
            DataTable dt = (DataTable)objExecute.Executes("spGetEngineType", ReturnType.DataTable, CommandType.StoredProcedure);

            cmbEngineType.DataSource = dt;
            cmbEngineType.DisplayMember = "vcEngineType";
            cmbEngineType.ValueMember = "intEngineTypeID";
            cmbEngineType.SelectedIndex = -1;
        }
        public void GetAPI()
        {
            Execute objExecute = new Execute();
            DataTable dt = (DataTable)objExecute.Executes("spGetAPI", ReturnType.DataTable, CommandType.StoredProcedure);

            cmbAPI.DataSource = dt;
            cmbAPI.DisplayMember = "vcAPI";
            cmbAPI.ValueMember = "intAPIID"; 
            cmbAPI.SelectedIndex = -1;
        }
        public void GetSAE()
        {
            Execute objExecute = new Execute();
            DataTable dt = (DataTable)objExecute.Executes("spGetSAE", ReturnType.DataTable, CommandType.StoredProcedure);

            cmbSAE.DataSource = dt;
            cmbSAE.DisplayMember = "vcSAE";
            cmbSAE.ValueMember = "intSAEID"; 
            cmbSAE.SelectedIndex = -1;
        }
        
        //========================================================================================



        private void cmbBrand_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //GetSubCat();
            cmbMainCategory.SelectedIndex = -1;
        }

        public void GetSubCat()
        {
            Execute objExecute = new Execute();
            string Query = "[dbo].[spGetBrandAndMainWiseSubCat]";
            SqlParameter[] para = new SqlParameter[]
              {
                      Execute.AddParameter("@intBrandID",Convert.ToInt32(cmbBrand.SelectedValue)),
                      Execute.AddParameter("@intMainCategoryID",Convert.ToInt32(cmbMainCategory.SelectedValue)),

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

            if (cmbBrand.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select the Brand");
                return;
            }
            else if(cmbMainCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select the Main Category");
                return;
            }
            else if (cmbSubCat.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select the Sub Category");
                return;
            }
            else if (cmbMeasureUnit.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select the Measure Unit");
                return;
            }
            else if (cmbUnitQty.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select the Unit Size");
                return;
            }

            if (cmbAPI.SelectedIndex == -1)
            {
                intAPIID = null;
            }
            if (cmbSAE.SelectedIndex == -1)
            {
                intSAEID = null;
            }
            if (cmbEngineType.SelectedIndex == -1)
            {
                intEngineTypeID = null;
            }
            else
            { 
            intAPIID = Convert.ToInt32(cmbAPI.SelectedValue);
            intSAEID = Convert.ToInt32(cmbSAE.SelectedValue);
            intEngineTypeID = Convert.ToInt32(cmbEngineType.SelectedValue);
            }

            DialogResult dr = MessageBox.Show("Are You Sure Want to Add Item ?", "CONFIRM", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
               
                Execute objExecute = new Execute();
                SqlParameter[] param = new SqlParameter[]
                   {
                    Execute.AddParameter("@intMainCategoryID",Convert.ToInt32(cmbMainCategory.SelectedValue)),
                    Execute.AddParameter("@intSubCatDetailsID",Convert.ToInt32(cmbSubCat.SelectedValue)),
                    Execute.AddParameter("@intBrandID",Convert.ToInt32(cmbBrand.SelectedValue)),

                    Execute.AddParameter("@intAPIID",intAPIID ==null?DBNull.Value : (object) intAPIID),
                    Execute.AddParameter("@intSAEID",intSAEID ==null?DBNull.Value : (object) intSAEID),
                    Execute.AddParameter("@intEngineTypeID",intEngineTypeID ==null?DBNull.Value : (object) intEngineTypeID),

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
                    Clear();
                }
                else
                {
                    MessageBox.Show("Cant't Save..");
                }
            }
        }

        public void Clear()
        {
            txtUnitPrice.Text = string.Empty;
            txtItemCode.Text = string.Empty;
            txtDec.Text = string.Empty;
        }

        private void txtItemCode_Click(object sender, EventArgs e)
        {
            if (cmbMainCategory.SelectedIndex == 0)
            {
                ItemCode = cmbAPI.Text.ToString() + '-' + cmbSAE.Text.ToString() + '-' + cmbUnitQty.Text.ToString() + cmbMeasureUnit.Text.ToString();
                txtItemCode.Text = ItemCode;
                txtItemCode.ReadOnly = true;
            }
           
        }

        private void cmbMainCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbMainCategory.SelectedIndex == 0)
            {
                cmbAPI.Visible = true;
                cmbSAE.Visible = true;
                cmbEngineType.Visible = true;

                lbl1.Visible = true;
                lbl11.Visible = true;
                lbl2.Visible = true;
                lbl22.Visible = true;
                lbl3.Visible = true;
                lbl33.Visible = true;
      

            }
            else
            {
                cmbAPI.Visible = false;
                cmbSAE.Visible = false;
                cmbEngineType.Visible = false;


                lbl1.Visible = false;
                lbl11.Visible = false;
                lbl2.Visible = false;
                lbl22.Visible = false;
                lbl3.Visible = false;
                lbl33.Visible = false;

            }
            GetSubCat();
        }

        private void txtStockHand_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetMeasureUnit();
            GetAPI();
            GetSAE();
            GetBrand();
        }
    }
}
