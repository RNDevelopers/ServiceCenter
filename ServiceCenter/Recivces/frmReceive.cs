using CrystalDecisions.CrystalReports.Engine;
using ServiceCenter.Common;
using ServiceCenter.DBConnection;
using ServiceCenter.Entities;
using ServiceCenter.Enums;
using ServiceCenter.ErrorLog;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace ServiceCenter.Setup
{
    public partial class frmReceive : BaseUI
    {
        public int intItemID { get; set; }

        private ItemEntity objItemEntity;
        private List<ItemEntity> GlobalList;
        private ItemEntity objItem;

        public frmReceive()
        {
            InitializeComponent();
            SetFormName();

            GetSupplier();
            GetBrand();
            GetMainCategory();
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

        public void GetSupplier()
        {
            Execute objExecute = new Execute();
            DataTable dt = (DataTable)objExecute.Executes("spGetSuppliers", ReturnType.DataTable, CommandType.StoredProcedure);

            cmbSupplier.DataSource = dt;
            cmbSupplier.DisplayMember = "vcSupplierName";
            cmbSupplier.ValueMember = "intSupplierID";
            cmbSupplier.SelectedIndex = -1;
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

        public void GetBrandAndMainWiseSubCat()
        {
            Execute objExecute = new Execute();
            string Query = "[dbo].[spGetBrandAndMainWiseSubCat]";
            SqlParameter[] para = new SqlParameter[]
              {
                      Execute.AddParameter("@intBrandID",Convert.ToInt32(cmbBrand.SelectedValue)),
                      Execute.AddParameter("@intMainCategoryID",Convert.ToInt32(cmbMainCategory.SelectedValue))

              };
            DataTable dt = (DataTable)objExecute.Executes(Query, ReturnType.DataTable, para, CommandType.StoredProcedure);

            cmbSubCat.DataSource = dt;
            cmbSubCat.DisplayMember = "vcSubCategoryName";
            cmbSubCat.ValueMember = "intSubCatDetailsID";
            cmbSubCat.SelectedIndex = -1;

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        public void LoadAddItem()
        {
            try
            {
                Execute objExecute = new Execute();
                string Query = "[dbo].[spGetItemGRNadd]";
                SqlParameter[] para = new SqlParameter[]
                  {
                      Execute.AddParameter("@intBrandID",Convert.ToInt32(cmbBrand.SelectedValue)),
                      Execute.AddParameter("@intSubCatDetailsID",Convert.ToInt32(cmbSubCat.SelectedValue))

                  };
                DataTable dt = (DataTable)objExecute.Executes(Query, ReturnType.DataTable, para, CommandType.StoredProcedure);

                ItemEntity objItemEntity;
                List<ItemEntity> lstGetItemAdd = new List<ItemEntity>();


                foreach (DataRow dr in dt.Rows)
                {
                    objItemEntity = new ItemEntity
                    {
                        intItemID = (int)dr["intItemID"],
                        vcItemCode = dr["vcItemCode"].ToString(),
                        vcItemDescription = dr["vcItemDescription"].ToString(),
                        decStockInHand = (decimal)dr["decStockInHand"]
                    };

                    lstGetItemAdd.Add(objItemEntity);
                }


                dgvAddItem.DataSource = null;
                dgvAddItem.AutoGenerateColumns = false;
                dgvAddItem.DataSource = lstGetItemAdd;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data Loading Error");
                Logger.LoggError(ex, "LoadAddItem");
            }

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

        private void cmbSubCat_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadAddItem();
        }

        private void cmbBrand_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //GetSubCat();
            cmbMainCategory.SelectedIndex = -1;
        }

        private void dgvAddItem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {


                intItemID = Convert.ToInt32(dgvAddItem.Rows[e.RowIndex].Cells[clmItemID.Name].Value);

                Execute objExecute = new Execute();
                string Query = "[dbo].[spGetItemDetails]";
                SqlParameter[] para = new SqlParameter[]
                  {
                      Execute.AddParameter("@intItemID",intItemID),

                  };
                DataTable dt = (DataTable)objExecute.Executes(Query, ReturnType.DataTable, para, CommandType.StoredProcedure);

                List<ItemEntity> lstGetItemGRN = new List<ItemEntity>();

                //if (lstGetItemGRN.Find(x => x.intItemID == GlobalList.IndexOf) != null)
                //{
                //    MessageBox.Show("You can't select Same Item!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    return;
                //}

                // List<ItemEntity> GlobalList = new List<ItemEntity>();

                foreach (DataRow dr in dt.Rows)
                {
                    objItemEntity = new ItemEntity();
                    dgvGRN.Rows.Add();
                    objItemEntity.intItemID = (int)dr["intItemID"];
                    objItemEntity.vcItemCode = dr["vcItemCode"].ToString();
                    objItemEntity.vcSubCategoryName = dr["vcSubCategoryName"].ToString();
                    objItemEntity.vcItemDescription = dr["vcItemDescription"].ToString();
                    objItemEntity.vcUnit = dr["vcUnit"].ToString();
                    objItemEntity.decUnitPrice = (decimal)dr["decUnitPrice"];

                    lstGetItemGRN.Add(objItemEntity);

                }

                foreach (ItemEntity objItem in lstGetItemGRN)
                {
                    dgvGRN["clmItemID1", dgvGRN.Rows.Count - 1].Value = objItem.intItemID;
                    dgvGRN["clmItemCode1", dgvGRN.Rows.Count - 1].Value = objItem.vcItemCode;
                    dgvGRN["clmSubCategoryName", dgvGRN.Rows.Count - 1].Value = objItem.vcSubCategoryName;
                    dgvGRN["clmItemDesc", dgvGRN.Rows.Count - 1].Value = objItem.vcItemDescription;
                    dgvGRN["clmUnit", dgvGRN.Rows.Count - 1].Value = objItem.vcUnit;
                    dgvGRN["clmUnitPrice", dgvGRN.Rows.Count - 1].Value = objItem.decUnitPrice;

                }

                GlobalList = lstGetItemGRN.ToList();

                //if (lstGetItemGRN.Count > 0)
                //{
                //    dgvGRN.AutoGenerateColumns = false;
                //    dgvGRN.DataSource = lstGetItemGRN.ToList();
                //}

                //lstGetItemGRN.Clear();

            }
            catch (Exception)
            {

                throw;
            }

        }

        private void cmbMainCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetSubCat();
        }

        private void dgvGRN_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgvGRN.Rows)
            {
                row.Cells[dgvGRN.Columns[clmValue.Name].Index].Value = (Convert.ToDecimal(row.Cells[dgvGRN.Columns[clmGRNQty.Name].Index].Value) * Convert.ToDecimal(row.Cells[dgvGRN.Columns[clmUnitPrice.Name].Index].Value));

                CalculateDiscountedPrice();
                SumOfDiscountedValue();
            }
        }

        private void CalculateDiscountedPrice()
        {
            double Discount = 0;
            double unitPrice = 0;
            double totDiscout = 0;
            double Qty = 0;
            double Val = 0;
            double x = 0;

            foreach (DataGridViewRow row in dgvGRN.Rows)
            {
                Discount = (Convert.ToDouble(row.Cells[dgvGRN.Columns[clmDiscount.Name].Index].Value));
                Qty = (Convert.ToDouble(row.Cells[dgvGRN.Columns[clmGRNQty.Name].Index].Value));
                unitPrice = (Convert.ToDouble(row.Cells[dgvGRN.Columns[clmUnitPrice.Name].Index].Value));

                Val = Qty * unitPrice;

                x = (Val * Discount) / 100;
                totDiscout = Val - x;
                row.Cells[dgvGRN.Columns[clmDiscountedValue.Name].Index].Value = totDiscout;
            }

        }

        private void SumOfDiscountedValue()
        {

            double Tot = 0;

           
            foreach (DataGridViewRow row in dgvGRN.Rows)
            {
                double SumOfDisPrice = (Convert.ToDouble(row.Cells[dgvGRN.Columns[clmDiscountedValue.Name].Index].Value));

                Tot += SumOfDisPrice;

      
            }

            lblTotal.Text = Tot.ToString("#,##0.00");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                List<GRNEntity> lstGRNSave = new List<GRNEntity>();

                Execute objExecute = new Execute();
                SqlParameter[] param = new SqlParameter[]
               {
                    Execute.AddParameter("@intSupplierID", Convert.ToInt32(cmbSupplier.SelectedValue))
               };

                int intGRNHeaderID = objExecute.ExecuteIdentity("spSaveGRNHeader", param, CommandType.StoredProcedure);

                foreach (DataGridViewRow dr in dgvGRN.Rows)
                {
                    GRNEntity objGRNEntity = new GRNEntity
                    {
                        intGRNHeaderID = intGRNHeaderID,
                        intItemID = Convert.ToInt32(dr.Cells[clmItemID1.Name].Value.ToString()),
                        decGRNQty = Convert.ToDecimal(dr.Cells[clmGRNQty.Name].Value.ToString()),
                        decUnitPrice = Convert.ToDecimal(dr.Cells[clmUnitPrice.Name].Value.ToString()),
                        decDiscount = Convert.ToDecimal(dr.Cells[clmDiscount.Name].Value.ToString()),
                        decTotal = Convert.ToDecimal(dr.Cells[clmValue.Name].Value.ToString())
                    };
                    lstGRNSave.Add(objGRNEntity);
                }

                foreach (GRNEntity item in lstGRNSave)
                {
                    Execute objExecuteX = new Execute();
                    SqlParameter[] paramX = new SqlParameter[]
                 {
                    Execute.AddParameter("@intGRNHeaderID",item.intGRNHeaderID),
                    Execute.AddParameter("@intItemID",item.intItemID),
                    Execute.AddParameter("@decGRNQty",item.decGRNQty),
                    Execute.AddParameter("@decUnitPrice",item.decUnitPrice),
                    Execute.AddParameter("@decDiscount",item.decDiscount),
                    Execute.AddParameter("@decDiscount",item.decTotal),
                 };

                    objExecuteX.Executes("spSaveGRNDetails", paramX, CommandType.StoredProcedure);

                }
                MessageBox.Show("Save.......");

            }
            catch (Exception)
            {

                throw;
            }

        }

        public void GetReport()
        {
            ReportDocument rptDoc = new ReportDocument();


        }

        private void dgvGRN_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvGRN.CurrentCell.ColumnIndex == 6 || dgvGRN.CurrentCell.ColumnIndex == 8)
            {
                e.Control.KeyPress += new KeyPressEventHandler(dgvGRN_KeyPress);
            }

        }

        private void dgvGRN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
    }
}