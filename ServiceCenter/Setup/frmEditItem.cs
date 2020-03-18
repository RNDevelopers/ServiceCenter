using ServiceCenter.Common;
using ServiceCenter.DBConnection;
using ServiceCenter.Entities;
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
    public partial class frmEditItem : BaseUI
    {

        public int DetailsFromItemID { get; set; }
        public int intItemInfo { get; set; }

        private ItemEntity objItemEntity;
        private List<ItemEntity> GlobalList;
        private List<ItemEntity> GlobalSelectedItemList = new List<ItemEntity>();


        public frmEditItem()
        {
            InitializeComponent();

        }

        private void frmEditItem_Load(object sender, EventArgs e)
        {
            GetCustomerInfo();
        }

        public void GetCustomerInfo()
        {

            DetailsFromItemID = Convert.ToInt32(txtItemID.Text.ToUpper());

            string OIL;
            decimal unitprice;
            decimal stockHand;

            Execute objExecute = new Execute();
            string Query = "[dbo].[spGetItemInfo]";
            SqlParameter[] para = new SqlParameter[]
              {
                      Execute.AddParameter("@intItemID ",DetailsFromItemID)

              };
            DataSet ds = (DataSet)objExecute.Executes(Query, ReturnType.DataSet, para, CommandType.StoredProcedure);

            if (ds.Tables[0].Rows.Count > 0)
            {
                intItemInfo = Convert.ToInt32(ds.Tables[0].Rows[0]["intItemID"].ToString());
                unitprice = Convert.ToDecimal(ds.Tables[0].Rows[0]["decUnitPrice"].ToString());
                txtUnitPrice.Text = unitprice.ToString();
                stockHand = Convert.ToDecimal(ds.Tables[0].Rows[0]["decStockInHand"].ToString());
                lblStockInHand.Text = stockHand.ToString();
                txtItemCode.Text = ds.Tables[0].Rows[0]["vcItemCode"].ToString();
                txtDec.Text = ds.Tables[0].Rows[0]["vcItemDescription"].ToString();

                lblBrandName.Text = ds.Tables[0].Rows[0]["vcBrandName"].ToString();
                lblMainCategory.Text = ds.Tables[0].Rows[0]["vcMainCategoryName"].ToString();
                lblSubCategory.Text = ds.Tables[0].Rows[0]["vcSubCategoryName"].ToString();
                lblMUnit.Text = ds.Tables[0].Rows[0]["vcMeasureUnitDesc"].ToString();
                lblMUSize.Text = ds.Tables[0].Rows[0]["vcUnit"].ToString();
                lblAPIGrade.Text = ds.Tables[0].Rows[0]["vcAPI"].ToString();
                lblSAEGrade.Text = ds.Tables[0].Rows[0]["vcSAE"].ToString();
                lblEngineType.Text = ds.Tables[0].Rows[0]["vcEngineType"].ToString();


                if (lblMainCategory.Text == "OIL")
                {
                    txtItemCode.ReadOnly = true;
                }

            }
            else
            {
                MessageBox.Show("Please Register Customer");
                //txtvcVehicle.Focus();

            }
        }

        private void btnUpdateItem_Click(object sender, EventArgs e)
        {
            
        }

        //update
        //public void UpdateItem()
        //{
        //    DialogResult dr = MessageBox.Show("Are You Sure Want to Add Item ?", "CONFIRM", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

        //    if (dr == DialogResult.Yes)
        //    {

        //        Execute objExecute = new Execute();
        //        SqlParameter[] param = new SqlParameter[]
        //           {
        //            Execute.AddParameter("@IntPackingMethodID",Convert.ToInt32(cmbUnitQty.SelectedValue)),
        //            Execute.AddParameter("@decStockInHand",Convert.ToDecimal(txtStockHand.Text.Trim())),
        //            Execute.AddParameter("@decUnitPrice",Convert.ToDecimal(txtUnitPrice.Text.Trim())),
        //            Execute.AddParameter("@vcItemCode",txtItemCode.Text.ToUpper()),
        //            Execute.AddParameter("@vcItemDescription",txtDec.Text.ToUpper())
        //           };

        //        int NoOfRowsEffected = objExecute.Executes("spSaveItem", param, CommandType.StoredProcedure);

        //        if (NoOfRowsEffected < 0)
        //        {
        //            MessageBox.Show("Save..");
        //            Clear();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Cant't Save..");
        //        }


        //    }


        public void Clear()
        {
            lblBrandName.Text = string.Empty;
            lblMainCategory.Text = string.Empty;
            lblSubCategory.Text = string.Empty;
            lblMUnit.Text = string.Empty;
            lblMUSize.Text = string.Empty;
            lblStockInHand.Text = string.Empty;
            lblAPIGrade.Text = string.Empty;
            lblSAEGrade.Text = string.Empty;
            lblEngineType.Text = string.Empty;
            txtUnitPrice.Text = string.Empty;
            txtItemCode.Text = string.Empty;
            txtDec.Text = string.Empty;

        }

        private void btnAddNewItem_Click(object sender, EventArgs e)
        {
            frmAddItem obj = new frmAddItem();
            obj.Show();
        }
    }
}
