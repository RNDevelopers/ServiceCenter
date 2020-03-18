using ServiceCenter.Common;
using ServiceCenter.Customer;
using ServiceCenter.DBConnection;
using ServiceCenter.Entities;
using ServiceCenter.Enums;
using ServiceCenter.ErrorLog;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ServiceCenter.Setup
{
    public partial class frmIssues : BaseUI
    {
        public int intCustomerID { get; set; }
        public string vcVehicleNo { get; set; }
        public string intVehicleNo { get; set; }
        public string FullVehicleNO { get; set; }

        public decimal TotalDiscountedPrice { get; set; }

        public decimal MeterialsTotal { get; set; }
        public decimal ServiceTotal { get; set; }
        public decimal OtherCharges { get; set; }

        private int intPaymentMethodID { get; set; }

        public bool isServiceApply { get; set; }

        private BrandEntity objBrandEntity;
        private ItemEntity objItemEntity;
        private ItemEntity objIssueItemEntity;
        private List<ItemEntity> GlobalList;
        private List<ItemEntity> GlobalSelectedItemList = new List<ItemEntity>();
        private List<ServiceEntity> GlobalListService;
        private List<ServiceEntity> GlobalListServicelSelectedList = new List<ServiceEntity>();
        private List<ServiceEntity> lstServiceSave;
        private List<ServiceEntity> lstItemIssue;

        //public ItemEntity objIssueItemEntity;

        private bool IsServiceApply = true;

        public frmIssues()
        {
            InitializeComponent();
            SetFormName();

            GetService();

            rbtCash.Checked = true;
        }

        public void GetService()
        {
            Execute objExecute = new Execute();
            DataTable dt = (DataTable)objExecute.Executes("spGetService", ReturnType.DataTable, CommandType.StoredProcedure);


            cmbService.DataSource = dt;
            cmbService.DisplayMember = "vcServiceName";
            cmbService.ValueMember = "intServiceID";
            cmbService.SelectedIndex = -1;
        }

        #region
        public void GetCustomerInfo()
        {
            lblCustomerName.Text = string.Empty;
            lblPhoneNo.Text = string.Empty;


            if (txtIntVehicle.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Vehical No");
                return;
            }
            if (txtvcVehicle.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Vehical No");
                return;
            }

            vcVehicleNo = txtvcVehicle.Text.ToUpper();
            intVehicleNo = txtIntVehicle.Text.ToString();
            FullVehicleNO = vcVehicleNo + '-' + intVehicleNo;

            Execute objExecute = new Execute();
            string Query = "[dbo].[spGetCustomerInfo]";
            SqlParameter[] para = new SqlParameter[]
              {
                      Execute.AddParameter("@vcVehicleNo",FullVehicleNO)

              };
            DataSet ds = (DataSet)objExecute.Executes(Query, ReturnType.DataSet, para, CommandType.StoredProcedure);

            if (ds.Tables[0].Rows.Count > 0)
            {
                intCustomerID = Convert.ToInt32(ds.Tables[0].Rows[0]["intCustomerID"].ToString());
                lblCustomerName.Text = ds.Tables[0].Rows[0]["vcCustomerName"].ToString();
                lblPhoneNo.Text = ds.Tables[0].Rows[0]["intContactNo"].ToString();
            }
            else
            {
                MessageBox.Show("Please Register Customer");

                frmAddCustomer obj = new frmAddCustomer();
                obj.Show();
            }
        }
        #endregion

        private void txtIntVehicle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GetCustomerInfo();
            }
        }

        private void txtIntVehicle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtvcVehicle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GetCustomerInfo();
            }

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmAddCustomer obj = new frmAddCustomer();
            obj.Show();
        }

        public void spGetAllItemIssueAddBranWise()
        {
            try
            {
                Execute objExecute = new Execute();
                string Query = "[dbo].[spGetAllItemIssueAddBranWise]";
                SqlParameter[] para = new SqlParameter[]
                  {
                      Execute.AddParameter("@intBrandID",Convert.ToInt32(cmbBrand.SelectedValue)),
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
                        vcUnit = dr["vcUnit"].ToString(),
                        decUnitPrice = (decimal)dr["decUnitPrice"],
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
                Logger.LoggError(ex, "GetAllItemIssueAdd");
            }

        }

        private void frmIssues_Load(object sender, EventArgs e)
        {
            spGetAllItemIssueAddBranWise();

            GetServiceAdd();

            SetFormatting();

            GetBrand();

            intPaymentMethodID = 1;
        }

        private void GetBrand()
        {

            List<BrandEntity> lstBrand = new List<BrandEntity>();

            Execute objExecute = new Execute();
            DataTable dt = (DataTable)objExecute.Executes("spGetBrand", ReturnType.DataTable, CommandType.StoredProcedure);

            foreach (DataRow dr in dt.Rows)
            {
                objBrandEntity = new BrandEntity();
                objBrandEntity.intBrandID = Convert.ToInt32(dr["intBrandID"]);
                objBrandEntity.vcName = dr["vcName"].ToString();
                lstBrand.Add(objBrandEntity);
            }

            objBrandEntity.intBrandID = 0;
            objBrandEntity.vcName = "--All Brand--";

            lstBrand.Insert(0, objBrandEntity);

            cmbBrand.DataSource = lstBrand;
            cmbBrand.DisplayMember = "vcName";
            cmbBrand.ValueMember = "intBrandID";
            cmbBrand.SelectedIndex = 0;
        }

        private void SetFormatting()
        {
            dgvItemIssue.Columns[clmValue.Name].DefaultCellStyle.Format = "#,##0.00";
            dgvItemIssue.Columns[clmDiscountedValue.Name].DefaultCellStyle.Format = "#,##0.00";
            dgvItemIssue.Columns[clmUnitPrice.Name].DefaultCellStyle.Format = "#,##0.00";


            dgvService.Columns[clmServicePrice.Name].DefaultCellStyle.Format = "#,##0.00";
            dgvService.Columns[clmValueService.Name].DefaultCellStyle.Format = "#,##0.00";
            dgvService.Columns[clmDiscountedService.Name].DefaultCellStyle.Format = "#,##0.00";

            dgvAddItem.Columns[clmAddItemUnitPrice.Name].DefaultCellStyle.Format = "#,##0.00";

            dgvItemIssue.Columns[clmIssueQty.Name].DefaultCellStyle.BackColor = Color.LightGreen;
            dgvItemIssue.Columns[clmDiscount.Name].DefaultCellStyle.BackColor = Color.Khaki;

            dgvService.Columns[clmServicePrice.Name].DefaultCellStyle.BackColor = Color.LightGreen;
            dgvService.Columns[clmDiscountService.Name].DefaultCellStyle.BackColor = Color.Khaki;


        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvAddItem.DataSource = GlobalList.FindAll(x => x.vcItemCode.Trim().ToLower().Contains(txtSearch.Text.Trim().ToLower()));
        }

        private void txtDecSearch_TextChanged(object sender, EventArgs e)
        {
            dgvAddItem.DataSource = GlobalList.FindAll(x => x.vcItemDescription.Trim().ToLower().Contains(txtDecSearch.Text.Trim().ToLower()));
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GetCustomerInfo();


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            #region
            try
            {
                if (lblCustomerName.Text == string.Empty)
                {
                    MessageBox.Show("Please select the Customer");
                    return;
                }

                if (dgvItemIssue.Rows.Count == 0)
                {
                    DialogResult dr = MessageBox.Show("Are You Sure won't to use Items ?", "CONFIRM", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                    if (dr == DialogResult.Yes)
                    {
                        if (chkApplyService.Checked == true)
                        {
                            if ((dgvService.Rows.Count == 0) && (lblOtherVal.Text == "0.00"))
                            {
                                MessageBox.Show("Please Add Service Charge or other Value");
                                return;
                            }
                            else
                            {
                                List<ServiceEntity> lstServiceSave = new List<ServiceEntity>();

                                Execute objExecute = new Execute();
                                SqlParameter[] param = new SqlParameter[]
                               {
                                      Execute.AddParameter("@intCustomerID", intCustomerID),
                                      Execute.AddParameter("@intPaymentMethodID", intPaymentMethodID),
                                      Execute.AddParameter("@isServiceApply", true),
                                      Execute.AddParameter("@isItemOnly", false),
                               };

                                int intIssueHeaderID = objExecute.ExecuteIdentity("spSaveIssueHeader", param, CommandType.StoredProcedure);

                                int NoOfRowsEffected = 0;

                                foreach (DataGridViewRow dr1 in dgvService.Rows)
                                {
                                    ServiceEntity objServiceEntity = new ServiceEntity
                                    {
                                        intIssueHeaderID = intIssueHeaderID,
                                        intServiceID = Convert.ToInt32(dr1.Cells[clmServiceID.Name].Value.ToString()),
                                        decPrice = Convert.ToDecimal(dr1.Cells[clmServicePrice.Name].Value.ToString()),
                                        decDiscountedValue = Convert.ToDecimal(dr1.Cells[clmDiscountedService.Name].Value.ToString()),
                                        decTotal = Convert.ToDecimal(TotalDiscountedPrice)
                                    };
                                    lstServiceSave.Add(objServiceEntity);
                                }

                                foreach (ServiceEntity item in lstServiceSave)
                                {
                                    Execute objExecuteX = new Execute();
                                    SqlParameter[] paramX = new SqlParameter[]
                                 {
                                          Execute.AddParameter("@intIssueHeaderID",item.intIssueHeaderID),
                                          Execute.AddParameter("@intServiceID",item.intServiceID),
                                          Execute.AddParameter("@decServicePrice",item.decPrice),
                                          Execute.AddParameter("@decDiscountedValue",item.decDiscountedValue),
                                          Execute.AddParameter("@decTotal",item.decTotal),
                                 };

                                    NoOfRowsEffected = objExecuteX.Executes("spSaveIssueServiceCharges", paramX, CommandType.StoredProcedure);

                                }

                                if (NoOfRowsEffected <= 2)
                                {
                                    MessageBox.Show("Save..");   //Report/////////////////////////////////////
                                    clear();
                                    return;
                                }
                                else
                                {
                                    MessageBox.Show("Data Saving Error");
                                }

                                //MessageBox.Show("Service charge ONLY SAVE.............");
                                //return;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Item Add to Grid");
                        return;
                    }
                }

                if (chkApplyService.Checked == true)
                {
                    if ((dgvService.Rows.Count == 0) && (lblOtherVal.Text == "0.00"))
                    {
                        MessageBox.Show("Please Add Service Charge or other Value");
                        return;
                    }
                    else
                    {
                        foreach (DataGridViewRow row in dgvItemIssue.Rows)
                        {
                            if (Convert.ToBoolean(row.Cells[dgvItemIssue.Columns[clmIssueQty.Name].Index].Value == null) || (Convert.ToInt32(row.Cells[dgvItemIssue.Columns[clmIssueQty.Name].Index].Value) == 0))
                            {
                                MessageBox.Show("Please Enter Issue Qty");
                                return;
                            }
                        }

                        lstServiceSave = new List<ServiceEntity>();

                        lstItemIssue = new List<ServiceEntity>();

                        Execute objExecute = new Execute();
                        SqlParameter[] param = new SqlParameter[]
                       {
                                       Execute.AddParameter("@intCustomerID", intCustomerID),
                                       Execute.AddParameter("@intPaymentMethodID", intPaymentMethodID),
                                       Execute.AddParameter("@isServiceApply", true),
                                       Execute.AddParameter("@isItemOnly", true),
                       };

                        int intIssueHeaderID = objExecute.ExecuteIdentity("spSaveIssueHeader", param, CommandType.StoredProcedure);

                        int NoOfRowsEffected = 0;

                        ServiceEntity objIssueItemEntity = new ServiceEntity();

                        ServiceEntity objIssueServiceEntity = new ServiceEntity();

                        foreach (DataGridViewRow dr3 in dgvItemIssue.Rows)
                        {
                            objIssueItemEntity = new ServiceEntity
                            {
                                intIssueHeaderID = intIssueHeaderID,
                                intItemID = Convert.ToInt32(dr3.Cells[clmItemID1.Name].Value.ToString()),
                                decUnitPrice = Convert.ToDecimal(dr3.Cells[clmUnitPrice.Name].Value.ToString()),
                                Issueqty = Convert.ToDecimal(dr3.Cells[clmIssueQty.Name].Value.ToString()),
                                decMeterialsTotal = Convert.ToDecimal(MeterialsTotal),
                                decDiscountedValue = Convert.ToDecimal(dr3.Cells[clmDiscountedValue.Name].Value.ToString()),
                            };

                            lstItemIssue.Add(objIssueItemEntity);
                        }

                        foreach (DataGridViewRow dr4 in dgvService.Rows)
                        {
                            objIssueServiceEntity = new ServiceEntity
                            {
                                intIssueHeaderID = intIssueHeaderID,
                                intServiceID = Convert.ToInt32(dr4.Cells[clmServiceID.Name].Value.ToString()),
                                decPrice = Convert.ToDecimal(dr4.Cells[clmServicePrice.Name].Value.ToString()),
                                decTotal = Convert.ToDecimal(TotalDiscountedPrice),
                                decDiscountedValue = Convert.ToDecimal(dr4.Cells[clmDiscountedService.Name].Value.ToString()),
                            };

                            lstServiceSave.Add(objIssueServiceEntity);

                        }
                        //foreach (DataGridViewRow dr4 in dgvService.Rows)
                        //{
                        //    //for (int i = 0; i < dgvService.Rows.Count; i++)
                        //    //{
                        //     objIssueItemEntity = new ServiceEntity();

                        //        objIssueItemEntity.intServiceID = Convert.ToInt32(dr4.Cells[clmServiceID.Name].Value.ToString());
                        //        objIssueItemEntity.decPrice = Convert.ToDecimal(dr4.Cells[clmServicePrice.Name].Value.ToString());
                        //        objIssueItemEntity.decTotal = Convert.ToDecimal(TotalDiscountedPrice);
                        //    //}

                        //    lstAllIssueSave.Add(objIssueItemEntity);
                        //}



                        //var mergedList = lstAllIssueSave.Concat(lstItemIssue).ToList();

                        ////objIssueItemEntity.lstItemIssue = lstItemIssue;
                        //objIssueItemEntity.lstAllIssueSave = mergedList;

                        //objIssueItemEntity.lstAllIssueSave = lstAllIssueSave.ToList();

                        foreach (ServiceEntity item in lstItemIssue)
                        {
                            Execute objExecuteX = new Execute();
                            SqlParameter[] paramX = new SqlParameter[]
                            {
                                          Execute.AddParameter("@intIssueHeaderID",item.intIssueHeaderID),
                                          Execute.AddParameter("@intItemID",item.intItemID),
                                          Execute.AddParameter("@decUnitPrice",item.decUnitPrice),
                                          Execute.AddParameter("@decIssuedQty",item.Issueqty),
                                          Execute.AddParameter("@decMeterialsTotal",item.decMeterialsTotal),
                                          Execute.AddParameter("@decDiscountedValue",item.decDiscountedValue),

                            };

                            NoOfRowsEffected = objExecuteX.Executes("spSaveIssueItem", paramX, CommandType.StoredProcedure);

                        }

                        foreach (ServiceEntity item in lstServiceSave)
                        {
                            Execute objExecuteX = new Execute();
                            SqlParameter[] paramX = new SqlParameter[]
                            {

                                          Execute.AddParameter("@intIssueHeaderID",item.intIssueHeaderID),
                                          Execute.AddParameter("@intServiceID",item.intServiceID),
                                          Execute.AddParameter("@decServicePrice",item.decPrice),
                                          Execute.AddParameter("@decTotal",item.decTotal),
                                          Execute.AddParameter("@decDiscountedValue",item.decDiscountedValue),

                            };

                            NoOfRowsEffected = objExecuteX.Executes("spSaveIssueServiceCharges", paramX, CommandType.StoredProcedure);

                        }

                        if ((NoOfRowsEffected <= 3) && (NoOfRowsEffected <= 2))
                        {
                            MessageBox.Show("Save..");   //Report/////////////////////////////////////
                            clear();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Data Saving Error");
                        }


                        MessageBox.Show("all save.............");
                        return;
                    }
                }

                if (chkApplyService.Checked == false)
                {
                    if (dgvItemIssue.Rows.Count == 0)
                    {
                        MessageBox.Show("Please Item Add to Grid");
                        return;
                    }
                    else
                    {

                        foreach (DataGridViewRow row in dgvItemIssue.Rows)
                        {
                            if (Convert.ToBoolean(row.Cells[dgvItemIssue.Columns[clmIssueQty.Name].Index].Value == null) || (Convert.ToInt32(row.Cells[dgvItemIssue.Columns[clmIssueQty.Name].Index].Value) == 0))
                            {
                                MessageBox.Show("Please Enter Issue Qty");
                                return;
                            }
                        }

                        List<ServiceEntity> lstServiceSave = new List<ServiceEntity>();

                        Execute objExecute = new Execute();
                        SqlParameter[] param = new SqlParameter[]
                       {
                                      Execute.AddParameter("@intCustomerID", intCustomerID),
                                      Execute.AddParameter("@intPaymentMethodID", intPaymentMethodID),
                                      Execute.AddParameter("@isServiceApply", false),
                                      Execute.AddParameter("@isItemOnly", true),
                       };

                        int intIssueHeaderID = objExecute.ExecuteIdentity("spSaveIssueHeader", param, CommandType.StoredProcedure);

                        int NoOfRowsEffected = 0;


                        foreach (DataGridViewRow dr2 in dgvItemIssue.Rows)
                        {
                            ServiceEntity objIssueItemEntity = new ServiceEntity
                            {
                                intIssueHeaderID = intIssueHeaderID,
                                intItemID = Convert.ToInt32(dr2.Cells[clmItemID1.Name].Value.ToString()),
                                decUnitPrice = Convert.ToDecimal(dr2.Cells[clmUnitPrice.Name].Value.ToString()),
                                Issueqty = Convert.ToDecimal(dr2.Cells[clmIssueQty.Name].Value.ToString()),
                                decMeterialsTotal = Convert.ToDecimal(MeterialsTotal),
                                decDiscountedValue = Convert.ToDecimal(dr2.Cells[clmDiscountedValue.Name].Value.ToString()),
                            };

                            lstServiceSave.Add(objIssueItemEntity);
                        }

                        foreach (ServiceEntity item in lstServiceSave)
                        {
                            Execute objExecuteX = new Execute();
                            SqlParameter[] paramX = new SqlParameter[]
                         {
                                          Execute.AddParameter("@intIssueHeaderID",item.intIssueHeaderID),
                                          Execute.AddParameter("@intItemID",item.intItemID),
                                          Execute.AddParameter("@decUnitPrice",item.decUnitPrice),
                                          Execute.AddParameter("@decIssuedQty",item.Issueqty),
                                          Execute.AddParameter("@decMeterialsTotal",item.decMeterialsTotal),
                                          Execute.AddParameter("@decDiscountedValue",item.decDiscountedValue),
                         };

                            NoOfRowsEffected = objExecuteX.Executes("spSaveIssueItem", paramX, CommandType.StoredProcedure);

                        }

                        if (NoOfRowsEffected <= 3)
                        {
                            MessageBox.Show("Save..");   //Report/////////////////////////////////////
                            clear();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Data Saving Error");
                        }


                        MessageBox.Show("Item only save.............");
                        return;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            #endregion   ////////// Save Button //////////////////
        }

        private void chkApplyService_CheckedChanged(object sender, EventArgs e)
        {


            if (chkApplyService.Checked)
            {
                cmbService.Enabled = true;
                btnServicesAdd.Enabled = true;
                txtOtherChargers.Enabled = true;
                txtOtherValue.Enabled = true;
                btnOtherAdd.Enabled = true;
                dgvService.Enabled = true;

                btnDeleteOtherCharge.Enabled = true;

                lblSC.Enabled = true;
                lblOC.Enabled = true;
                lblV.Enabled = true;

                IsServiceApply = true;
            }
            else
            {
                cmbService.Enabled = false;
                btnServicesAdd.Enabled = false;
                txtOtherChargers.Enabled = false;
                txtOtherValue.Enabled = false;
                btnOtherAdd.Enabled = false;
                dgvService.Enabled = false;

                btnDeleteOtherCharge.Enabled = false;


                GlobalListServicelSelectedList.Clear();
                dgvService.DataSource = null;
                cmbService.SelectedIndex = -1;

                lblSC.Enabled = false;
                lblOC.Enabled = false;
                lblV.Enabled = false;

                ServiceTotal = 0;
                OtherCharges = 0;
                UpdateTotalPrice();

                IsServiceApply = false;

            }
        }

        private void dgvAddItem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int CheckQtyZero = Convert.ToInt32(dgvAddItem.Rows[dgvAddItem.CurrentCell.RowIndex].Cells[clmdecStockInHand.Name].Value);

                if (CheckQtyZero <= 0)
                {
                    MessageBox.Show("Stock Over");
                    return;
                }

                int id = Convert.ToInt32(dgvAddItem.Rows[dgvAddItem.CurrentCell.RowIndex].Cells[clmItemID.Name].Value);

                if (dgvItemIssue.Rows.Count > 0)
                {
                    if (GlobalSelectedItemList.Find(x => x.intItemID == id) != null)
                    {
                        MessageBox.Show("You can't select Same Item!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }



                ItemEntity obj = GlobalList.Find(x => x.intItemID == id);

                GlobalSelectedItemList.Add(obj);
                dgvItemIssue.AutoGenerateColumns = false;
                dgvItemIssue.DataSource = GlobalSelectedItemList.ToList();

                CalculateItemPrice();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Data Loading Error");
                Logger.LoggError(ex, "dgvAddItem_CellDoubleClick");
            }
        }

        private void dgvItemIssue_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //int id = Convert.ToInt32(dgvItemIssue.Rows[dgvItemIssue.CurrentCell.RowIndex].Cells[clmItemID1.Name].Value);
            //GlobalSelectedItemList.RemoveAll(x => x.intItemID == id);
            //dgvItemIssue.DataSource = GlobalSelectedItemList.ToList();
        }

        private void dgvItemIssue_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            CalculateItemPrice();
        }

        private void CalculateItemPrice()
        {
            decimal Discount = 0;
            decimal unitPrice = 0;
            decimal totDiscout = 0;
            decimal IndexDiscount = 0;
            decimal Qty = 0;
            decimal Val = 0;
            decimal x = 0;
            int id = 0;
            decimal CurrentStock = 0;

            foreach (DataGridViewRow row in dgvItemIssue.Rows)
            {

                if (Convert.ToBoolean(row.Cells[dgvItemIssue.Columns[clmDiscount.Name].Index].Value == null))
                {
                    row.Cells[dgvItemIssue.Columns[clmDiscount.Name].Index].Value = 0;
                }
                else
                {
                    Discount = (Convert.ToDecimal(row.Cells[dgvItemIssue.Columns[clmDiscount.Name].Index].Value));
                }

                Qty = (Convert.ToDecimal(row.Cells[dgvItemIssue.Columns[clmIssueQty.Name].Index].Value));
                unitPrice = (Convert.ToDecimal(row.Cells[dgvItemIssue.Columns[clmUnitPrice.Name].Index].Value));
                id = (Convert.ToInt32(row.Cells[dgvItemIssue.Columns[clmItemID1.Name].Index].Value));
                IndexDiscount = (Convert.ToDecimal(row.Cells[dgvItemIssue.Columns[clmDiscount.Name].Index].Value));
                CurrentStock = (Convert.ToDecimal(row.Cells[dgvItemIssue.Columns[clmCurrentStock.Name].Index].Value));

                //Cehck the Balance Qty
                if (Qty > CurrentStock)
                {
                    MessageBox.Show("Check Current Stock");
                    decimal empty = 0;
                    row.Cells[dgvItemIssue.Columns[clmIssueQty.Name].Index].Value = empty;
                    return;
                }


                ItemEntity obj = GlobalSelectedItemList.Find(xx => xx.intItemID == id);
                int index = GlobalSelectedItemList.IndexOf(obj);


                GlobalSelectedItemList[index].decUnitPrice = unitPrice;
                GlobalSelectedItemList[index].Issueqty = Qty;
                GlobalSelectedItemList[index].Discount = IndexDiscount;



                Val = Qty * unitPrice;

                row.Cells[dgvItemIssue.Columns[clmValue.Name].Index].Value = Val;

                x = (Val * Discount) / 100;
                totDiscout = totDiscout + (Val - x);
                row.Cells[dgvItemIssue.Columns[clmDiscountedValue.Name].Index].Value = (Val - x);

            }

            lblMeterialsTotal.Text = totDiscout.ToString("#,##0.00");
            MeterialsTotal = totDiscout;
            TotalDiscountedPrice = ServiceTotal + MeterialsTotal + OtherCharges;
            lblTotal.Text = TotalDiscountedPrice.ToString("#,##0.00");
        }

        private void dgvItemIssue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvItemIssue.Columns[e.ColumnIndex] == clmbtnDelete)
            {

                int index = dgvItemIssue.Rows.Count - 1;

                if (index == 0)
                {

                    int id = Convert.ToInt32(dgvItemIssue.Rows[dgvItemIssue.CurrentCell.RowIndex].Cells[clmItemID1.Name].Value);

                    decimal MeterialsTotal = 0;
                    decimal TotalDiscountedPrice = 0;
                    lblMeterialsTotal.Text = MeterialsTotal.ToString("#,##0.00");
                    lblTotal.Text = TotalDiscountedPrice.ToString("#,##0.00");

                    UpdateTotalPrice();

                    GlobalSelectedItemList.RemoveAll(x => x.intItemID == id);

                    dgvItemIssue.DataSource = GlobalSelectedItemList.ToList();

                    CalculateItemPrice();
                }
                else
                {
                    int id = Convert.ToInt32(dgvItemIssue.Rows[dgvItemIssue.CurrentCell.RowIndex].Cells[clmItemID1.Name].Value);

                    GlobalSelectedItemList.RemoveAll(x => x.intItemID == id);

                    dgvItemIssue.DataSource = GlobalSelectedItemList.ToList();

                    UpdateTotalPrice();
                    CalculateItemPrice();
                }

            }
        }

        private void btnServicesAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbService.SelectedIndex == -1)
                {
                    MessageBox.Show("Please Select the Service", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (GlobalListServicelSelectedList.Find(x => x.intServiceID == Convert.ToInt32(cmbService.SelectedValue)) != null)
                {
                    MessageBox.Show("You can't select Same Serive", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ServiceEntity obj = GlobalListService.Find(x => x.intServiceID == Convert.ToInt32(cmbService.SelectedValue));

                GlobalListServicelSelectedList.Add(obj);
                dgvService.AutoGenerateColumns = false;
                dgvService.DataSource = GlobalListServicelSelectedList.ToList();

                ServiceGridCal();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Data Loading Error");
                Logger.LoggError(ex, "btnServicesAdd_Click");
            }
        }

        private void GetServiceAdd()
        {
            try
            {
                Execute objExecute = new Execute();
                string Query = "[dbo].[spGetServiceDetails]";
                SqlParameter[] para = new SqlParameter[]
                  {

                  };
                DataTable dt = (DataTable)objExecute.Executes(Query, ReturnType.DataTable, para, CommandType.StoredProcedure);

                ServiceEntity objServiceEntity;
                List<ServiceEntity> lstGetServiceAdd = new List<ServiceEntity>();


                foreach (DataRow dr in dt.Rows)
                {
                    objServiceEntity = new ServiceEntity
                    {
                        intServiceID = (int)dr["intServiceID"],
                        vcServiceName = dr["vcServiceName"].ToString(),
                        decPrice = (decimal)dr["decPrice"],
                    };

                    lstGetServiceAdd.Add(objServiceEntity);
                }

                GlobalListService = lstGetServiceAdd.ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Data Loading Error");
                Logger.LoggError(ex, "GetServiceAdd");
            }
        }

        private void dgvService_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvService.Columns[e.ColumnIndex] == clmbtnDeleteService)
            {

                int index = dgvService.Rows.Count - 1;

                if (index == 0)
                {
                    int id = Convert.ToInt32(dgvService.Rows[dgvService.CurrentCell.RowIndex].Cells[clmServiceID.Name].Value);

                    decimal DiscountedVal = 0;
                    decimal ServiceTotal = 0;
                    decimal TotalDiscountedPrice = 0;

                    ServiceTotal = ServiceTotal - DiscountedVal;
                    lblServiceChargeTot.Text = ServiceTotal.ToString("#,##0.00");

                    lblTotal.Text = TotalDiscountedPrice.ToString("#,##0.00");
                    GlobalListServicelSelectedList.RemoveAll(x => x.intServiceID == id);

                    GlobalListServicelSelectedList.Clear();
                    dgvService.DataSource = null;

                    //  UpdateTotalPrice();
                    dgvService.DataSource = GlobalListServicelSelectedList.ToList();

                    CalculateItemPrice();

                    ServiceGridCal();
                }
                else
                {
                    int id = Convert.ToInt32(dgvService.Rows[dgvService.CurrentCell.RowIndex].Cells[clmServiceID.Name].Value);

                    decimal DiscountedVal = Convert.ToDecimal(dgvService.Rows[dgvService.CurrentCell.RowIndex].Cells[clmDiscountedService.Name].Value);

                    ServiceTotal = ServiceTotal - DiscountedVal;

                    lblServiceChargeTot.Text = ServiceTotal.ToString("#,##0.00");

                    // UpdateTotalPrice();
                    GlobalListServicelSelectedList.RemoveAll(x => x.intServiceID == id);
                    UpdateTotalPrice();
                    dgvService.DataSource = GlobalListServicelSelectedList.ToList();

                    ServiceGridCal();
                }

            }
        }

        private void dgvService_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            ServiceGridCal();
        }

        private void UpdateTotalPrice()
        {
            TotalDiscountedPrice = ServiceTotal + MeterialsTotal + OtherCharges;
            lblTotal.Text = TotalDiscountedPrice.ToString("#,##0.00");
            lblServiceChargeTot.Text = ServiceTotal.ToString("#,##0.00");
            lblOtherVal.Text = OtherCharges.ToString("#,##0.00");

        }

        private void ServiceGridCal()
        {
            decimal Discount = 0;
            decimal ServicePrice = 0;
            decimal totDiscout = 0;
            decimal x = 0;

            foreach (DataGridViewRow row in dgvService.Rows)
            {

                if (Convert.ToBoolean(row.Cells[dgvService.Columns[clmDiscountService.Name].Index].Value == null))
                {
                    row.Cells[dgvService.Columns[clmDiscountService.Name].Index].Value = 0;
                }
                else
                {
                    Discount = (Convert.ToDecimal(row.Cells[dgvService.Columns[clmDiscountService.Name].Index].Value));
                }

                ServicePrice = (Convert.ToDecimal(row.Cells[dgvService.Columns[clmServicePrice.Name].Index].Value));


                row.Cells[dgvService.Columns[clmValueService.Name].Index].Value = ServicePrice;

                x = (ServicePrice * Discount) / 100;
                totDiscout = totDiscout + (ServicePrice - x);
                row.Cells[dgvService.Columns[clmDiscountedService.Name].Index].Value = (ServicePrice - x);
            }

            lblServiceChargeTot.Text = totDiscout.ToString("#,##0.00");
            ServiceTotal = totDiscout;
            TotalDiscountedPrice = ServiceTotal + MeterialsTotal + OtherCharges;
            lblTotal.Text = TotalDiscountedPrice.ToString("#,##0.00");
        }

        private void btnOntherClick()
        {
            decimal decOtherCharges = 0;

            if (txtOtherChargers.Text.ToString() == string.Empty)
            {
                MessageBox.Show("please Enter service charge Descrpition");
                txtOtherChargers.Focus();
                return;

            }
            if (txtOtherValue.Text.ToString() == string.Empty)
            {
                MessageBox.Show("please Enter service charge Value");
                txtOtherValue.Focus();
                return;
            }

            decOtherCharges = Convert.ToDecimal(txtOtherValue.Text.ToString());

            lblOtherVal.Text = decOtherCharges.ToString("#,##0.00");

            if (txtOtherValue.Text.ToString() == string.Empty)
            {
                OtherCharges = 0;
            }
            else
            {
                OtherCharges = (Convert.ToDecimal(txtOtherValue.Text.ToString()));
            }

            txtOtherValue.Text = string.Empty;

            UpdateTotalPrice();
        }

        private void btnOtherAdd_Click(object sender, EventArgs e)
        {
            btnOntherClick();
        }

        private void btnOtherCharge_Click(object sender, EventArgs e)
        {
            OtherCharges = 0;
            txtOtherChargers.Text = string.Empty;
            lblOtherVal.Text = ServiceTotal.ToString("#,##0.00");
            UpdateTotalPrice();
        }

        private void txtOtherValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
              (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void dgvItemIssue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void dgvService_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void dgvItemIssue_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvItemIssue.CurrentCell.ColumnIndex == 7 || dgvItemIssue.CurrentCell.ColumnIndex == 9)
            {
                e.Control.KeyPress += new KeyPressEventHandler(dgvItemIssue_KeyPress);
            }

        }

        private void dgvService_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvService.CurrentCell.ColumnIndex == 3 || dgvService.CurrentCell.ColumnIndex == 4)
            {
                e.Control.KeyPress += new KeyPressEventHandler(dgvService_KeyPress);
            }
        }

        private void txtOtherValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOntherClick();
            }
        }

        private void rbtCash_CheckedChanged(object sender, EventArgs e)
        {
            intPaymentMethodID = 1;
        }

        private void rbtCard_CheckedChanged(object sender, EventArgs e)
        {
            intPaymentMethodID = 2;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        public void clear()
        {

            GlobalSelectedItemList.Clear();

            dgvItemIssue.DataSource = null;
            dgvService.DataSource = null;

            dgvAddItem.DataSource = null;
            GlobalList.Clear();


            vcVehicleNo = string.Empty;
            intVehicleNo = string.Empty;
            FullVehicleNO = string.Empty;

            intCustomerID = 0;
            lblCustomerName.Text = string.Empty;
            lblCustomerName.Text = string.Empty;
            lblPhoneNo.Text = string.Empty;

            lblMeterialsTotal.Text = "0.00";
            lblServiceChargeTot.Text = "0.00";
            lblOtherVal.Text = "0.00";
            lblTotal.Text = "0.00";

            txtvcVehicle.Text = string.Empty;
            txtIntVehicle.Text = string.Empty;


            GlobalListService.Clear();
            GlobalListServicelSelectedList.Clear();

            dgvService.DataSource = null;
            cmbService.SelectedIndex = -1;


            TotalDiscountedPrice = 0;
            MeterialsTotal = 0;
            ServiceTotal = 0;
            OtherCharges = 0;

            //lstServiceSave = null;
            //lstServiceSave.Clear();
            //lstItemIssue.Clear();

            spGetAllItemIssueAddBranWise();
            GetServiceAdd();

            SetFormatting();

            chkApplyService.Checked = true;
            rbtCash.Checked = true;
            intPaymentMethodID = 1;
            txtOtherChargers.Text = "Other Chargers :- ";

        }

        private void dgvAddItem_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvAddItem.Rows)
            {
                if (Convert.ToInt32(row.Cells[clmdecStockInHand.Name].Value) <= 5)
                {
                    row.DefaultCellStyle.BackColor = Color.LightPink;
           
                }
                

                if (Convert.ToInt32(row.Cells[clmdecStockInHand.Name].Value) <= 2)
                {
                    row.DefaultCellStyle.BackColor = Color.IndianRed;

                }
            }

        }

        private void cmbBrand_SelectionChangeCommitted(object sender, EventArgs e)
        {
            spGetAllItemIssueAddBranWise();
        }
    }
}
