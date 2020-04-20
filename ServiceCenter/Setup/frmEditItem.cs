using ServiceCenter.Common;
using ServiceCenter.DBConnection;
using ServiceCenter.Entities;
using ServiceCenter.Enums;
using ServiceCenter.ErrorLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace ServiceCenter.Setup
{
    public partial class frmEditItem : BaseUI
    {
        private DateTime dt;

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
                stockHand = Convert.ToInt32(ds.Tables[0].Rows[0]["decStockInHand"]);
                txtStockInHand.Text = stockHand.ToString();
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

                dt = Convert.ToDateTime(ds.Tables[0].Rows[0]["dtEnteredDate"].ToString());
               

                if (lblMainCategory.Text == "OIL")
                {
                    txtItemCode.ReadOnly = true;
                }
                else
                {
                    labelAPI.Text = string.Empty;
                    labeldot.Text = string.Empty;
                    labelSAE.Text = string.Empty;
                    labelSAEbot.Text = string.Empty;
                    labelENGING.Text = string.Empty;
                    labelEnginedot.Text = string.Empty;
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
            UpdateItem();

        }


        public void UpdateItem()
        {
            try
            {
                using (TransactionScope ts = new TransactionScope())
                {
                    DialogResult dr = MessageBox.Show("Are You Sure Want to Update Item ?", "CONFIRM", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                    if (dr == DialogResult.Yes)
                    {
                        Execute objExecute = new Execute();
                        SqlParameter[] param = new SqlParameter[]
                           {
                               Execute.AddParameter("@intItemID",Convert.ToInt32(txtItemID.Text.Trim())),
                               Execute.AddParameter("@decStockInHand",Convert.ToDecimal(txtStockInHand.Text.Trim())),
                               Execute.AddParameter("@decUnitPrice",Convert.ToDecimal(txtUnitPrice.Text.Trim())),
                               Execute.AddParameter("@vcItemCode",txtItemCode.Text.ToUpper()),
                               Execute.AddParameter("@vcItemDescription",txtDec.Text.ToUpper()),
                               Execute.AddParameter("@dtEnteredDate",Convert.ToDateTime(dt))
                           };

                           objExecute.Executes("spEditItem", param, CommandType.StoredProcedure);
                           MessageBox.Show("Update Item..");
                           Clear();

                    }
                    ts.Complete();
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data Updating Error");
                Logger.LoggError(ex, "btnSave_Click");
            }
        }


        public void Clear()
        {
            lblBrandName.Text = string.Empty;
            lblMainCategory.Text = string.Empty;
            lblSubCategory.Text = string.Empty;
            lblMUnit.Text = string.Empty;
            lblMUSize.Text = string.Empty;
            txtStockInHand.Text = string.Empty;
            lblAPIGrade.Text = string.Empty;
            lblSAEGrade.Text = string.Empty;
            lblEngineType.Text = string.Empty;
            txtUnitPrice.Text = string.Empty;
            txtItemCode.Text = string.Empty;
            txtDec.Text = string.Empty;

            labelAPI.Text = string.Empty;
            labeldot.Text = string.Empty;
            labelSAE.Text = string.Empty;
            labelSAEbot.Text = string.Empty;
            labelENGING.Text = string.Empty;
            labelEnginedot.Text = string.Empty;

        }

        private void btnAddNewItem_Click(object sender, EventArgs e)
        {
            frmAddItem obj = new frmAddItem();
            obj.Show();
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {

        }
    }
}
