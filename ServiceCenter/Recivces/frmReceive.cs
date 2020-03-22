using CrystalDecisions.CrystalReports.Engine;
using ServiceCenter.Common;
using ServiceCenter.DBConnection;
using ServiceCenter.Entities;
using ServiceCenter.Enums;
using ServiceCenter.ErrorLog;
using ServiceCenter.Report;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Transactions;
using System.Windows.Forms;

namespace ServiceCenter.Setup
{
    public partial class frmReceive : BaseUI
    {
        public int intItemID { get; set; }

        public decimal TotalPrice { get; set; }

        private int intGRNHeaderID { get; set; }

        private ItemEntity objItemEntity;
        private List<ItemEntity> GlobalList;
        private List<ItemEntity> GlobalSelectedItemList = new List<ItemEntity>();

        private List<ItemEntity> lstGetItemGRN = new List<ItemEntity>();

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
                        vcEngineType = dr["vcEngineType"].ToString(),
                        decStockInHand = (decimal)dr["decStockInHand"],
                        vcSubCategoryName = dr["vcSubCategoryName"].ToString(),
                        vcUnit = dr["vcUnit"].ToString()

                    };

                    lstGetItemAdd.Add(objItemEntity);
                }

                dgvAddItem.DataSource = null;
                dgvAddItem.AutoGenerateColumns = false;
                dgvAddItem.DataSource = lstGetItemAdd;

                GlobalList = lstGetItemAdd.ToList();
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
            lstGetItemGRN.Clear();
            dgvAddItem.DataSource = null;
            cmbMainCategory.SelectedIndex = -1;
            cmbSubCat.SelectedIndex = -1;
        }

        private void dgvAddItem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                int id = Convert.ToInt32(dgvAddItem.Rows[dgvAddItem.CurrentCell.RowIndex].Cells[clmItemID.Name].Value);

                if (GlobalSelectedItemList.Find(x => x.intItemID == id) != null)
                {
                    MessageBox.Show("You can't select Same Item!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ItemEntity obj = GlobalList.Find(x => x.intItemID == id);

                GlobalSelectedItemList.Add(obj);
                dgvGRN.AutoGenerateColumns = false;
                dgvGRN.DataSource = GlobalSelectedItemList.ToList();

                CalculateDiscountedPrice();
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
            CalculateDiscountedPrice();
        }

        private void CalculateDiscountedPrice()
        {
            decimal Discount = 0;
            decimal unitPrice = 0;
            decimal totDiscout = 0;
            decimal IndexDiscount = 0;
            decimal Qty = 0;
            decimal Val = 0;
            decimal x = 0;
            int id = 0;

            decimal Value = 0;
            decimal ValueDiscounted = 0;

            foreach (DataGridViewRow row in dgvGRN.Rows)
            {

                if (Convert.ToBoolean(row.Cells[dgvGRN.Columns[clmDiscount.Name].Index].Value == null))
                {
                    row.Cells[dgvGRN.Columns[clmDiscount.Name].Index].Value = 0;
                }
                else
                {
                    Discount = (Convert.ToDecimal(row.Cells[dgvGRN.Columns[clmDiscount.Name].Index].Value));
                }


                Qty = (Convert.ToDecimal(row.Cells[dgvGRN.Columns[clmGRNQty.Name].Index].Value));
                unitPrice = (Convert.ToDecimal(row.Cells[dgvGRN.Columns[clmUnitPrice.Name].Index].Value));
                id = (Convert.ToInt32(row.Cells[dgvGRN.Columns[clmItemID1.Name].Index].Value));
                IndexDiscount = (Convert.ToDecimal(row.Cells[dgvGRN.Columns[clmDiscount.Name].Index].Value));

                Value = (Convert.ToDecimal(row.Cells[dgvGRN.Columns[clmValue.Name].Index].Value));
                ValueDiscounted = (Convert.ToDecimal(row.Cells[dgvGRN.Columns[clmDiscountedValue.Name].Index].Value));


                ItemEntity obj = GlobalSelectedItemList.Find(xx => xx.intItemID == id);
                int index = GlobalSelectedItemList.IndexOf(obj);


                GlobalSelectedItemList[index].decUnitPrice = unitPrice;
                GlobalSelectedItemList[index].GRNqty = Qty;
                GlobalSelectedItemList[index].Discount = IndexDiscount;

                GlobalSelectedItemList[index].value = Value;
                GlobalSelectedItemList[index].Discounted = ValueDiscounted;

                Val = Qty * unitPrice;

                row.Cells[dgvGRN.Columns[clmValue.Name].Index].Value = Val;

                x = (Val * Discount) / 100;
                totDiscout = totDiscout + (Val - x);
                row.Cells[dgvGRN.Columns[clmDiscountedValue.Name].Index].Value = (Val - x);

            }

            lblTotal.Text = totDiscout.ToString("#,##0.00");

            TotalPrice = totDiscout;

            lblTotal.Text = TotalPrice.ToString("#,##0.00");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbSupplier.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select the Supplier");
                    return;
                }
                else if (cmbBrand.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select the Brand");
                    return;
                }
                else if (cmbMainCategory.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select the Main Category");
                    return;
                }
                else if (cmbSubCat.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select the Sub Category");
                    return;
                }

                if (dgvGRN.Rows.Count == 0)
                {
                    MessageBox.Show("Please Item Add to Grid");
                    return;
                }

                foreach (DataGridViewRow row in dgvGRN.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[dgvGRN.Columns[clmGRNQty.Name].Index].Value == null) || (Convert.ToInt32(row.Cells[dgvGRN.Columns[clmGRNQty.Name].Index].Value) == 0))
                    {
                        MessageBox.Show("Please Enter GRN Qty");
                        return;
                    }
                    if (Convert.ToBoolean(row.Cells[dgvGRN.Columns[clmUnitPrice.Name].Index].Value == null) || (Convert.ToInt32(row.Cells[dgvGRN.Columns[clmUnitPrice.Name].Index].Value) == 0))
                    {
                        MessageBox.Show("Please Enter Unit Price Qty");
                        return;
                    }

                }

                using (TransactionScope ts = new TransactionScope())
                {
                    intGRNHeaderID = 0;
                    List<GRNEntity> lstGRNSave = new List<GRNEntity>();

                    Execute objExecute = new Execute();
                    SqlParameter[] param = new SqlParameter[]
                       {
                    Execute.AddParameter("@intSupplierID", Convert.ToInt32(cmbSupplier.SelectedValue))
                       };

                     intGRNHeaderID = objExecute.ExecuteIdentity("spSaveGRNHeader", param, CommandType.StoredProcedure);

                    foreach (DataGridViewRow dr in dgvGRN.Rows)
                    {
                        GRNEntity objGRNEntity = new GRNEntity
                        {
                            intGRNHeaderID = intGRNHeaderID,
                            intItemID = Convert.ToInt32(dr.Cells[clmItemID1.Name].Value.ToString()),
                            decGRNQty = Convert.ToDecimal(dr.Cells[clmGRNQty.Name].Value.ToString()),
                            decUnitPrice = Convert.ToDecimal(dr.Cells[clmUnitPrice.Name].Value.ToString()),
                            decDiscountedValue = Convert.ToDecimal(dr.Cells[clmDiscountedValue.Name].Value.ToString()),
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
                    Execute.AddParameter("@decDiscountedValue",item.decDiscountedValue),
                     };

                        objExecuteX.Executes("spSaveGRNDetails", paramX, CommandType.StoredProcedure);
                    }

                    ts.Complete();
                }

                MessageBox.Show("Save..");

                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;

                ///Report///////////////////////////////////////////////////
                ///
                rptGRN rpt = new rptGRN();
                ReportDocument rptDoc = new ReportDocument();

                rptDoc = rpt;

                Execute objExecuteXX = new Execute();
                string Query = "[dbo].[spGetGRNReportDetails]";
                SqlParameter[] para = new SqlParameter[]
                  {
                      Execute.AddParameter("@intGRNHeaderID",intGRNHeaderID)
                     
                  };
                DataTable dt = (DataTable)objExecuteXX.Executes(Query, ReturnType.DataTable, para, CommandType.StoredProcedure);

                rpt.SetDataSource(dt);

                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;

                frmReportViewer objfrmReportViewer = new frmReportViewer(rptDoc);
                objfrmReportViewer.Show();

                //  rptDoc.PrintToPrinter(1, true, 0, 0);

                clear();

                //////////////////////////////


            }
            catch (Exception ex)
            {
                MessageBox.Show("Data Saving Error");
                Logger.LoggError(ex, "btnSave_Click");
            }

        }

        private void clear()
        {
            dgvGRN.DataSource = null;
            dgvAddItem.DataSource = null;
            cmbSupplier.SelectedIndex = -1;
            cmbBrand.SelectedIndex = -1;
            cmbMainCategory.SelectedIndex = -1;
            cmbSubCat.SelectedIndex = -1;
            GlobalSelectedItemList.Clear();
            lstGetItemGRN.Clear();
            TotalPrice = 0;
            lblTotal.Text = string.Empty;
            
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

        private void SetFormatting()
        {
            dgvGRN.Columns[clmValue.Name].DefaultCellStyle.Format = "#,##0.00";
            dgvGRN.Columns[clmDiscountedValue.Name].DefaultCellStyle.Format = "#,##0.00";

            dgvGRN.Columns[clmGRNQty.Name].DefaultCellStyle.BackColor = Color.LightGreen;
            dgvGRN.Columns[clmUnitPrice.Name].DefaultCellStyle.BackColor = Color.LightBlue;
            dgvGRN.Columns[clmDiscount.Name].DefaultCellStyle.BackColor = Color.Khaki;
        }

        private void frmReceive_Load(object sender, EventArgs e)
        {
            SetFormatting();
        }

        private void dgvGRN_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dgvGRN.CurrentCell.ColumnIndex == 7) // zero-based
            {
                if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
                {
                    MessageBox.Show("Please Enter GRN Qty");
                    return;
                }
            }
            else
            {
                //return;
            }

        }

        private void cmbMainCategory_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            lstGetItemGRN.Clear();
            dgvAddItem.DataSource = null;
            GetSubCat();
        }

        private void dgvGRN_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            //int id = Convert.ToInt32(dgvGRN.Rows[dgvGRN.CurrentCell.RowIndex].Cells[clmItemID1.Name].Value);

            //GlobalSelectedItemList.RemoveAll(x => x.intItemID == id);

            //dgvGRN.DataSource = GlobalSelectedItemList.ToList();
        }

        private void dgvGRN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvGRN.Columns[e.ColumnIndex] == clmbtnDelete)
            {
                int index = dgvGRN.Rows.Count - 1;

                if (index == 0)
                {
                    int id = Convert.ToInt32(dgvGRN.Rows[dgvGRN.CurrentCell.RowIndex].Cells[clmItemID1.Name].Value);

                    GlobalSelectedItemList.RemoveAll(x => x.intItemID == id);

                    dgvGRN.DataSource = GlobalSelectedItemList.ToList();


                    decimal DiscountedVal = 0; ;
                    decimal TotalPrice = 0;
                    TotalPrice = TotalPrice - DiscountedVal;
                    lblTotal.Text = TotalPrice.ToString("#,##0.00");

                    CalculateDiscountedPrice();
                }
                else
                {
                    int id = Convert.ToInt32(dgvGRN.Rows[dgvGRN.CurrentCell.RowIndex].Cells[clmItemID1.Name].Value);

                    decimal DiscountedVal = Convert.ToDecimal(dgvGRN.Rows[dgvGRN.CurrentCell.RowIndex].Cells[clmDiscountedValue.Name].Value);
                    TotalPrice = TotalPrice - DiscountedVal;
                    lblTotal.Text = TotalPrice.ToString("#,##0.00");

                    GlobalSelectedItemList.RemoveAll(x => x.intItemID == id);

                    dgvGRN.DataSource = GlobalSelectedItemList.ToList();

                    CalculateDiscountedPrice();
                }

            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }
    }
}