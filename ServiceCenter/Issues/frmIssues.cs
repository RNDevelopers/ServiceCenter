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
using System.Transactions;
using ServiceCenter.Report;
using CrystalDecisions.CrystalReports.Engine;

namespace ServiceCenter.Setup
{
    public partial class frmIssues : BaseUI
    {
        public int intCustomerID { get; set; }
        public string vcVehicleNo { get; set; }
        public string intVehicleNo { get; set; }
        public string FullVehicleNO { get; set; }
        private int  intIssueHeaderID { get; set; }
        public decimal TotalDiscountedPrice { get; set; }

        public decimal MeterialsTotal { get; set; }
        public decimal ServiceTotal { get; set; }
        public decimal OtherCharges { get; set; }

        private int intPaymentMethodID { get; set; }

        public bool isServiceApply { get; set; }
        private bool IsCheckVehical = true;

        private int CustomerIDScopeID { get; set; }

        private string milage { get; set; }

        private ServiceEntity objServiceEntity;
        private SupplierEntity objSupplierEntity;
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

            cmbPhoneNo.Enabled = true;
            txtCustomerName.Enabled = true;
        }

        public void GetService()
        {
            List<ServiceEntity> lstService = new List<ServiceEntity>();

            Execute objExecute = new Execute();
            DataTable dt = (DataTable)objExecute.Executes("spGetService", ReturnType.DataTable, CommandType.StoredProcedure);

            foreach (DataRow dr in dt.Rows)
            {
                objServiceEntity = new ServiceEntity
                {
                    intServiceID = Convert.ToInt32(dr["intServiceID"]),
                    vcServiceName = dr["vcServiceName"].ToString()
                };
                lstService.Add(objServiceEntity);
            }

            cmbService.DataSource = dt;
            cmbService.DisplayMember = "vcServiceName";
            cmbService.ValueMember = "intServiceID";
            cmbService.SelectedIndex = -1;
        }

        #region
        public void GetCustomerInfo()
        {


            if (IsCheckVehical == true)
            {

                if (txtvcVehicle.Text == string.Empty)
                {
                    MessageBox.Show("Please Enter Vehicle No");
                    return;
                }
                else if (txtIntVehicle.Text == string.Empty)
                {
                    MessageBox.Show("Please Enter Vehicle No");
                    return;
                }

                vcVehicleNo = txtvcVehicle.Text.ToUpper();
                intVehicleNo = txtIntVehicle.Text.ToString();
                FullVehicleNO = vcVehicleNo + '-' + intVehicleNo;

                Execute objExecute = new Execute();
                string Query = "[dbo].[spGetCustomerInfo]";
                SqlParameter[] para = new SqlParameter[]
                  {
                      Execute.AddParameter("@vcVehicleNo",FullVehicleNO),

                  };
                DataSet ds = (DataSet)objExecute.Executes(Query, ReturnType.DataSet, para, CommandType.StoredProcedure);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    intCustomerID = Convert.ToInt32(ds.Tables[0].Rows[0]["intCustomerID"].ToString());
                    txtCustomerName.Text = ds.Tables[0].Rows[0]["vcCustomerName"].ToString();
                    cmbPhoneNo.SelectedIndex = -1;
                    cmbPhoneNo.Text = string.Empty;
                    cmbPhoneNo.SelectedText = ds.Tables[0].Rows[0]["intContactNo"].ToString();
                }
                else
                {
                    if (MessageBox.Show("Please Register Customer", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        frmAddCustomer obj = new frmAddCustomer(vcVehicleNo, intVehicleNo);
                        obj.ShowDialog();

                    }

                   //  GetCustomerInfo();
                   
                }

            }
            else
            {

                if (Convert.ToBoolean(cmbPhoneNo.Text == string.Empty))
                {
                    MessageBox.Show("Please enter the Phone Number");
                    cmbPhoneNo.Focus();
                    return;
                }


                Execute objExecute = new Execute();
                string Query = "[dbo].[spGetCustomerInfoContactWise]";
                SqlParameter[] para = new SqlParameter[]
                  {
                      Execute.AddParameter("@intContactNo",Convert.ToInt32(cmbPhoneNo.SelectedValue)),

                  };
                DataSet ds = (DataSet)objExecute.Executes(Query, ReturnType.DataSet, para, CommandType.StoredProcedure);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    intCustomerID = Convert.ToInt32(ds.Tables[0].Rows[0]["intCustomerID"].ToString());
                    txtCustomerName.Text = ds.Tables[0].Rows[0]["vcCustomerName"].ToString();
                    txtCustomerName.Enabled = false;
                }
                else
                {
                    txtCustomerName.Enabled = true;

                    if (txtCustomerName.Text == string.Empty)
                    {
                        MessageBox.Show("Customer Not Found...! Please Enter Customer Name");
                        txtCustomerName.Focus();
                        return;
                    }

                    int ContactNo = Convert.ToInt32(cmbPhoneNo.Text);

                    Execute objExecuteX = new Execute();
                    SqlParameter[] param = new SqlParameter[]
                       {
                          Execute.AddParameter("@intContactNo",ContactNo),
                          Execute.AddParameter("@vcCustomerName",txtCustomerName.Text.Trim().ToUpper()),
                       };

                    int? CustomerID;
                    CustomerID = objExecuteX.ExecuteIdentity("spSaveCustomerPhoneNo", param, CommandType.StoredProcedure);

                    if (CustomerID != null)
                    {
                        MessageBox.Show("Customer Saved successfully");
                        intCustomerID = Convert.ToInt32(CustomerID);
                        btnSearch.Enabled = false;
                        cmbPhoneNo.Enabled = false;
                        txtCustomerName.Enabled = false;
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Cant't Save..");
                        return;
                    }

                }
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

                        decDiscountedUnitValue = (decimal)dr["decUnitPriceDiscounted"],
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

            GetPhoneNumber();

            intPaymentMethodID = 1;
        }

        private void GetBrand()
        {

            List<BrandEntity> lstBrand = new List<BrandEntity>();

            Execute objExecute = new Execute();
            DataTable dt = (DataTable)objExecute.Executes("spGetBrand", ReturnType.DataTable, CommandType.StoredProcedure);

            objBrandEntity = new BrandEntity
            {
                intBrandID = 0,
                vcName = "--All Brand--"

            };

            lstBrand.Add(objBrandEntity);

            foreach (DataRow dr in dt.Rows)
            {
                objBrandEntity = new BrandEntity
                {
                    intBrandID = Convert.ToInt32(dr["intBrandID"]),
                    vcName = dr["vcName"].ToString()
                };
                lstBrand.Add(objBrandEntity);
            }

            cmbBrand.DataSource = lstBrand;
            cmbBrand.DisplayMember = "vcName";
            cmbBrand.ValueMember = "intBrandID";
            cmbBrand.SelectedIndex = 0;
        }

        private void GetPhoneNumber()
        {

            List<SupplierEntity> lstCustomer = new List<SupplierEntity>();

            Execute objExecute = new Execute();
            DataTable dt = (DataTable)objExecute.Executes("spGetPhoneNumer", ReturnType.DataTable, CommandType.StoredProcedure);

            foreach (DataRow dr in dt.Rows)
            {
                objSupplierEntity = new SupplierEntity
                {
                    intContactNo = Convert.ToInt32(dr["intContactNo"])
                };

                lstCustomer.Add(objSupplierEntity);
            }

            cmbPhoneNo.DataSource = lstCustomer;
            cmbPhoneNo.DisplayMember = "intContactNo";
            cmbPhoneNo.ValueMember = "intContactNo";
            cmbPhoneNo.SelectedIndex = -1;

        }

        private void SetFormatting()
        {
            dgvItemIssue.Columns[clmValue.Name].DefaultCellStyle.Format = "#,##0.00";
            dgvItemIssue.Columns[clmDiscountedPrice.Name].DefaultCellStyle.Format = "#,##0.00";
            dgvItemIssue.Columns[clmUnitPrice.Name].DefaultCellStyle.Format = "#,##0.00";


            dgvService.Columns[clmServicePrice.Name].DefaultCellStyle.Format = "#,##0.00";



            dgvAddItem.Columns[clmAddItemUnitPrice.Name].DefaultCellStyle.Format = "#,##0.00";

            dgvItemIssue.Columns[clmIssueQty.Name].DefaultCellStyle.BackColor = Color.LightGreen;
            dgvItemIssue.Columns[clmDiscountedPrice.Name].DefaultCellStyle.BackColor = Color.Khaki;

            dgvService.Columns[clmServicePrice.Name].DefaultCellStyle.BackColor = Color.LightGreen;



        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvAddItem.DataSource = GlobalList.FindAll(x => x.vcItemCode.Trim().ToLower().Contains(txtCodeSearch.Text.Trim().ToLower()));
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
                

            try
            {
                if (txtCustomerName.Text == string.Empty)
                {
                    MessageBox.Show("Please Select the Customer");
                    return;
                }
                if (dgvItemIssue.Rows.Count <= 0 && dgvService.Rows.Count <= 0)
                {
                    MessageBox.Show("Please Add Item or Service");
                    return;
                }

                foreach (DataGridViewRow row in dgvItemIssue.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[dgvItemIssue.Columns[clmIssueQty.Name].Index].Value == null) || (Convert.ToInt32(row.Cells[dgvItemIssue.Columns[clmIssueQty.Name].Index].Value) == 0))
                    {
                        MessageBox.Show("Please Enter Issue Qty");
                        return;
                    }
                }

                ///////////////// trans begin
                ///
                using (TransactionScope ts = new TransactionScope())
                {

                    Execute objExecute = new Execute();
                    SqlParameter[] param = new SqlParameter[]
                    {
                    Execute.AddParameter("@intCustomerID", intCustomerID),
                    Execute.AddParameter("@intPaymentMethodID", intPaymentMethodID)
                    };

                     intIssueHeaderID = objExecute.ExecuteIdentity("spSaveIssueHeader", param, CommandType.StoredProcedure);

                    //int ItemIssueNoOfRowsEffected = 0;

                    if (dgvItemIssue.Rows.Count > 0)
                    {
                        foreach (DataGridViewRow drItemIssue in dgvItemIssue.Rows)
                        {
                            Execute objExecuteX = new Execute();
                            SqlParameter[] paramX = new SqlParameter[]
                            {
                            Execute.AddParameter("@intIssueHeaderID",intIssueHeaderID),
                            Execute.AddParameter("@intItemID",Convert.ToInt32(drItemIssue.Cells[clmItemID1.Name].Value)),
                            Execute.AddParameter("@decUnitPrice",Convert.ToDecimal(drItemIssue.Cells[clmUnitPrice.Name].Value)),
                            Execute.AddParameter("@decIssuedQty",Convert.ToDecimal(drItemIssue.Cells[clmIssueQty.Name].Value)),
                            Execute.AddParameter("@decDiscountedValue",Convert.ToDecimal(drItemIssue.Cells[clmDiscountedPrice.Name].Value)),

                            };

                            objExecuteX.Executes("spSaveIssueItem", paramX, CommandType.StoredProcedure);
                            //ItemIssueNoOfRowsEffected++;
                        }
                    }

                    //int ServiceNoOfRowsEffected = 0;

                    if (dgvService.Rows.Count > 0)
                    {
                        foreach (DataGridViewRow drvService in dgvService.Rows)
                        {
                            Execute objExecuteX = new Execute();
                            SqlParameter[] paramX = new SqlParameter[]
                            {
                            Execute.AddParameter("@intIssueHeaderID",intIssueHeaderID),
                            Execute.AddParameter("@intServiceID",Convert.ToInt32(drvService.Cells[clmServiceID.Name].Value)),
                            Execute.AddParameter("@decServicePrice",Convert.ToDecimal(drvService.Cells[clmServicePrice.Name].Value)),
                            Execute.AddParameter("@vcServiceDec",(drvService.Cells[clmServiceDescription.Name].Value.ToString())),
                            };

                            objExecuteX.Executes("spSaveIssueServiceCharges", paramX, CommandType.StoredProcedure);
                            //ServiceNoOfRowsEffected++;
                        }
                    }
                    ts.Complete();
                }

            
                MessageBox.Show("Saved Successfully");

             


                if(txtMilege.Text.Trim() == string.Empty)
                {
                    milage = "";
                }

                milage = txtMilege.Text.Trim();

                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;

                ///Report///////////////////////////////////////////////////
                ///
                rptIssue rpt = new rptIssue();
                ReportDocument rptDoc = new ReportDocument();

                rptDoc = rpt;

                Execute objExecuteXX = new Execute();
                string Query = "[dbo].[spGetIssueBillDetails]";
                SqlParameter[] para = new SqlParameter[]
                  {
                      Execute.AddParameter("@intIssueHeaderID",intIssueHeaderID)

                  };
                DataTable dt = (DataTable)objExecuteXX.Executes(Query, ReturnType.DataTable, para, CommandType.StoredProcedure);

                rpt.SetDataSource(dt);
                rpt.SetParameterValue("XXXMilege", milage);
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;

                frmReportViewer objfrmReportViewer = new frmReportViewer(rptDoc);
                objfrmReportViewer.Show();

                //rptDoc.PrintToPrinter(1, true, 0, 0);

                clear();

                //////////////////////////////




                #region
                ////if (txtCustomerName.Text == string.Empty)
                ////{
                ////    MessageBox.Show("Please select the Customer");
                ////    return;
                ////}

                ////if (dgvItemIssue.Rows.Count == 0)
                ////{
                ////    DialogResult dr = MessageBox.Show("Are You Sure won't to use Items ?", "CONFIRM", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                ////    if (dr == DialogResult.Yes)
                ////    {
                ////        if (chkApplyService.Checked == true)
                ////        {
                ////            if ((dgvService.Rows.Count == 0) && (lblOtherVal.Text == "0.00"))
                ////            {
                ////                MessageBox.Show("Please Add Service Charge or other Value");
                ////                return;
                ////            }
                ////            else
                ////            {
                ////                List<ServiceEntity> lstServiceSave = new List<ServiceEntity>();

                ////                Execute objExecute = new Execute();
                ////                SqlParameter[] param = new SqlParameter[]
                ////               {
                ////                      Execute.AddParameter("@intCustomerID", intCustomerID),
                ////                      Execute.AddParameter("@intPaymentMethodID", intPaymentMethodID),
                ////                      Execute.AddParameter("@isServiceApply", true),
                ////                      Execute.AddParameter("@isItemOnly", false),
                ////               };

                ////                int intIssueHeaderID = objExecute.ExecuteIdentity("spSaveIssueHeader", param, CommandType.StoredProcedure);

                ////                int NoOfRowsEffected = 0;

                ////                foreach (DataGridViewRow dr1 in dgvService.Rows)
                ////                {
                ////                    ServiceEntity objServiceEntity = new ServiceEntity
                ////                    {
                ////                        intIssueHeaderID = intIssueHeaderID,
                ////                        intServiceID = Convert.ToInt32(dr1.Cells[clmServiceID.Name].Value.ToString()),
                ////                        decPrice = Convert.ToDecimal(dr1.Cells[clmServicePrice.Name].Value.ToString()),
                ////                        decDiscountedValue = Convert.ToDecimal(dr1.Cells[clmDiscountedService.Name].Value.ToString()),
                ////                        decTotal = Convert.ToDecimal(TotalDiscountedPrice)
                ////                    };
                ////                    lstServiceSave.Add(objServiceEntity);
                ////                }

                ////                foreach (ServiceEntity item in lstServiceSave)
                ////                {
                ////                    Execute objExecuteX = new Execute();
                ////                    SqlParameter[] paramX = new SqlParameter[]
                ////                 {
                ////                          Execute.AddParameter("@intIssueHeaderID",item.intIssueHeaderID),
                ////                          Execute.AddParameter("@intServiceID",item.intServiceID),
                ////                          Execute.AddParameter("@decServicePrice",item.decPrice),
                ////                          Execute.AddParameter("@decDiscountedValue",item.decDiscountedValue),
                ////                          Execute.AddParameter("@decTotal",item.decTotal),
                ////                 };

                ////                    NoOfRowsEffected = objExecuteX.Executes("spSaveIssueServiceCharges", paramX, CommandType.StoredProcedure);

                ////                }

                ////                if (NoOfRowsEffected <= 2)
                ////                {
                ////                    MessageBox.Show("Save..");   //Report/////////////////////////////////////
                ////                    clear();
                ////                    return;
                ////                }
                ////                else
                ////                {
                ////                    MessageBox.Show("Data Saving Error");
                ////                }

                ////                //MessageBox.Show("Service charge ONLY SAVE.............");
                ////                //return;
                ////            }
                ////        }
                ////    }
                ////    else
                ////    {
                ////        MessageBox.Show("Please Item Add to Grid");
                ////        return;
                ////    }
                ////}

                ////if (chkApplyService.Checked == true)
                ////{
                ////    if ((dgvService.Rows.Count == 0) && (lblOtherVal.Text == "0.00"))
                ////    {
                ////        MessageBox.Show("Please Add Service Charge or other Value");
                ////        return;
                ////    }
                ////    else
                ////    {
                ////        foreach (DataGridViewRow row in dgvItemIssue.Rows)
                ////        {
                ////            if (Convert.ToBoolean(row.Cells[dgvItemIssue.Columns[clmIssueQty.Name].Index].Value == null) || (Convert.ToInt32(row.Cells[dgvItemIssue.Columns[clmIssueQty.Name].Index].Value) == 0))
                ////            {
                ////                MessageBox.Show("Please Enter Issue Qty");
                ////                return;
                ////            }
                ////        }

                ////        lstServiceSave = new List<ServiceEntity>();

                ////        lstItemIssue = new List<ServiceEntity>();

                ////        Execute objExecute = new Execute();
                ////        SqlParameter[] param = new SqlParameter[]
                ////       {
                ////                       Execute.AddParameter("@intCustomerID", intCustomerID),
                ////                       Execute.AddParameter("@intPaymentMethodID", intPaymentMethodID),
                ////                       Execute.AddParameter("@isServiceApply", true),
                ////                       Execute.AddParameter("@isItemOnly", true),
                ////       };

                ////        int intIssueHeaderID = objExecute.ExecuteIdentity("spSaveIssueHeader", param, CommandType.StoredProcedure);

                ////        int NoOfRowsEffected = 0;

                ////        ServiceEntity objIssueItemEntity = new ServiceEntity();

                ////        ServiceEntity objIssueServiceEntity = new ServiceEntity();

                ////        foreach (DataGridViewRow dr3 in dgvItemIssue.Rows)
                ////        {
                ////            objIssueItemEntity = new ServiceEntity
                ////            {
                ////                intIssueHeaderID = intIssueHeaderID,
                ////                intItemID = Convert.ToInt32(dr3.Cells[clmItemID1.Name].Value.ToString()),
                ////                decUnitPrice = Convert.ToDecimal(dr3.Cells[clmUnitPrice.Name].Value.ToString()),
                ////                Issueqty = Convert.ToDecimal(dr3.Cells[clmIssueQty.Name].Value.ToString()),
                ////                decMeterialsTotal = Convert.ToDecimal(MeterialsTotal),
                ////                decDiscountedValue = Convert.ToDecimal(dr3.Cells[clmDiscountedValue.Name].Value.ToString()),
                ////            };

                ////            lstItemIssue.Add(objIssueItemEntity);
                ////        }

                ////        foreach (DataGridViewRow dr4 in dgvService.Rows)
                ////        {
                ////            objIssueServiceEntity = new ServiceEntity
                ////            {
                ////                intIssueHeaderID = intIssueHeaderID,
                ////                intServiceID = Convert.ToInt32(dr4.Cells[clmServiceID.Name].Value.ToString()),
                ////                decPrice = Convert.ToDecimal(dr4.Cells[clmServicePrice.Name].Value.ToString()),
                ////                decTotal = Convert.ToDecimal(TotalDiscountedPrice),
                ////                decDiscountedValue = Convert.ToDecimal(dr4.Cells[clmDiscountedService.Name].Value.ToString()),
                ////            };

                ////            lstServiceSave.Add(objIssueServiceEntity);

                ////        }

                ////        foreach (ServiceEntity item in lstItemIssue)
                ////        {
                ////            Execute objExecuteX = new Execute();
                ////            SqlParameter[] paramX = new SqlParameter[]
                ////            {
                ////                          Execute.AddParameter("@intIssueHeaderID",item.intIssueHeaderID),
                ////                          Execute.AddParameter("@intItemID",item.intItemID),
                ////                          Execute.AddParameter("@decUnitPrice",item.decUnitPrice),
                ////                          Execute.AddParameter("@decIssuedQty",item.Issueqty),
                ////                          Execute.AddParameter("@decMeterialsTotal",item.decMeterialsTotal),
                ////                          Execute.AddParameter("@decDiscountedValue",item.decDiscountedValue),

                ////            };

                ////            NoOfRowsEffected = objExecuteX.Executes("spSaveIssueItem", paramX, CommandType.StoredProcedure);

                ////        }

                ////        foreach (ServiceEntity item in lstServiceSave)
                ////        {
                ////            Execute objExecuteX = new Execute();
                ////            SqlParameter[] paramX = new SqlParameter[]
                ////            {

                ////                          Execute.AddParameter("@intIssueHeaderID",item.intIssueHeaderID),
                ////                          Execute.AddParameter("@intServiceID",item.intServiceID),
                ////                          Execute.AddParameter("@decServicePrice",item.decPrice),
                ////                          Execute.AddParameter("@decTotal",item.decTotal),
                ////                          Execute.AddParameter("@decDiscountedValue",item.decDiscountedValue),

                ////            };

                ////            NoOfRowsEffected = objExecuteX.Executes("spSaveIssueServiceCharges", paramX, CommandType.StoredProcedure);

                ////        }

                ////        if ((NoOfRowsEffected <= 3) && (NoOfRowsEffected <= 2))
                ////        {
                ////            MessageBox.Show("Save..");   //Report/////////////////////////////////////
                ////            clear();
                ////            return;
                ////        }
                ////        else
                ////        {
                ////            MessageBox.Show("Data Saving Error");
                ////        }


                ////        MessageBox.Show("all save.............");
                ////        return;
                ////    }
                ////}

                ////if (chkApplyService.Checked == false)
                ////{
                ////    if (dgvItemIssue.Rows.Count == 0)
                ////    {
                ////        MessageBox.Show("Please Item Add to Grid");
                ////        return;
                ////    }
                ////    else
                ////    {

                ////        foreach (DataGridViewRow row in dgvItemIssue.Rows)
                ////        {
                ////            if (Convert.ToBoolean(row.Cells[dgvItemIssue.Columns[clmIssueQty.Name].Index].Value == null) || (Convert.ToInt32(row.Cells[dgvItemIssue.Columns[clmIssueQty.Name].Index].Value) == 0))
                ////            {
                ////                MessageBox.Show("Please Enter Issue Qty");
                ////                return;
                ////            }
                ////        }

                ////        List<ServiceEntity> lstServiceSave = new List<ServiceEntity>();

                ////        Execute objExecute = new Execute();
                ////        SqlParameter[] param = new SqlParameter[]
                ////       {
                ////                      Execute.AddParameter("@intCustomerID", intCustomerID),
                ////                      Execute.AddParameter("@intPaymentMethodID", intPaymentMethodID),
                ////                      Execute.AddParameter("@isServiceApply", false),
                ////                      Execute.AddParameter("@isItemOnly", true),
                ////       };

                ////        int intIssueHeaderID = objExecute.ExecuteIdentity("spSaveIssueHeader", param, CommandType.StoredProcedure);

                ////        int NoOfRowsEffected = 0;


                ////        foreach (DataGridViewRow dr2 in dgvItemIssue.Rows)
                ////        {
                ////            ServiceEntity objIssueItemEntity = new ServiceEntity
                ////            {
                ////                intIssueHeaderID = intIssueHeaderID,
                ////                intItemID = Convert.ToInt32(dr2.Cells[clmItemID1.Name].Value.ToString()),
                ////                decUnitPrice = Convert.ToDecimal(dr2.Cells[clmUnitPrice.Name].Value.ToString()),
                ////                Issueqty = Convert.ToDecimal(dr2.Cells[clmIssueQty.Name].Value.ToString()),
                ////                decMeterialsTotal = Convert.ToDecimal(MeterialsTotal),
                ////                decDiscountedValue = Convert.ToDecimal(dr2.Cells[clmDiscountedValue.Name].Value.ToString()),
                ////            };

                ////            lstServiceSave.Add(objIssueItemEntity);
                ////        }

                ////        foreach (ServiceEntity item in lstServiceSave)
                ////        {
                ////            Execute objExecuteX = new Execute();
                ////            SqlParameter[] paramX = new SqlParameter[]
                ////         {
                ////                          Execute.AddParameter("@intIssueHeaderID",item.intIssueHeaderID),
                ////                          Execute.AddParameter("@intItemID",item.intItemID),
                ////                          Execute.AddParameter("@decUnitPrice",item.decUnitPrice),
                ////                          Execute.AddParameter("@decIssuedQty",item.Issueqty),
                ////                          Execute.AddParameter("@decMeterialsTotal",item.decMeterialsTotal),
                ////                          Execute.AddParameter("@decDiscountedValue",item.decDiscountedValue),
                ////         };

                ////            NoOfRowsEffected = objExecuteX.Executes("spSaveIssueItem", paramX, CommandType.StoredProcedure);

                ////        }

                ////        if (NoOfRowsEffected <= 3)
                ////        {
                ////            MessageBox.Show("Save..");   //Report/////////////////////////////////////
                ////            clear();
                ////            return;
                ////        }
                ////        else
                ////        {
                ////            MessageBox.Show("Data Saving Error");
                ////        }


                ////        MessageBox.Show("Item only save.............");
                ////        return;
                ////    }
                ////}
                #endregion //  // Ramod Fools
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data Saving Error");
                Logger.LoggError(ex, "btnSave_Click");
            }
            ////////// Save Button //////////////////
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
            decimal DiscountedPrice = 0;
            decimal unitPrice = 0;
            decimal totDiscout = 0;
            //decimal IndexDiscount = 0;
            decimal Qty = 0;
            decimal Val = 0;
            decimal x = 0;
            int id = 0;
            decimal CurrentStock = 0;

            foreach (DataGridViewRow row in dgvItemIssue.Rows)
            {


                //DiscountedPrice = (Convert.ToDecimal(dgvItemIssue.Rows[dgvItemIssue.CurrentCell.RowIndex].Cells[clmDiscountedPrice.Name].Value));


                Qty = (Convert.ToDecimal(row.Cells[dgvItemIssue.Columns[clmIssueQty.Name].Index].Value));
                unitPrice = (Convert.ToDecimal(row.Cells[dgvItemIssue.Columns[clmUnitPrice.Name].Index].Value));
                id = (Convert.ToInt32(row.Cells[dgvItemIssue.Columns[clmItemID1.Name].Index].Value));
                DiscountedPrice = (Convert.ToDecimal(row.Cells[dgvItemIssue.Columns[clmDiscountedPrice.Name].Index].Value));
                CurrentStock = (Convert.ToDecimal(row.Cells[dgvItemIssue.Columns[clmCurrentStock.Name].Index].Value));
                // totDiscout = (Convert.ToDecimal(row.Cells[dgvItemIssue.Columns[clmValue.Name].Index].Value));

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

                GlobalSelectedItemList[index].Issueqty = Qty;
                GlobalSelectedItemList[index].DiscountedPrice = DiscountedPrice;

                Val = Qty * DiscountedPrice;

                row.Cells[dgvItemIssue.Columns[clmValue.Name].Index].Value = Val;

                totDiscout += (Convert.ToDecimal(row.Cells[dgvItemIssue.Columns[clmValue.Name].Index].Value));

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

                    GlobalSelectedItemList.Clear();

                    dgvItemIssue.DataSource = null;
                    spGetAllItemIssueAddBranWise();

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

                //ServiceEntity obj = new ServiceEntity();

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


                    if (id == 1)
                    {
                        btnOtherAdd.Enabled = true;
                        txtOtherValue.Enabled = true;
                        txtOtherChargers.Enabled = true;
                    }

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

                    decimal DiscountedVal = Convert.ToDecimal(dgvService.Rows[dgvService.CurrentCell.RowIndex].Cells[clmServicePrice.Name].Value);

                    ServiceTotal = ServiceTotal - DiscountedVal;

                    lblServiceChargeTot.Text = ServiceTotal.ToString("#,##0.00");


                    GlobalListServicelSelectedList.RemoveAll(x => x.intServiceID == id);

                    if (id == 1)
                    {
                        btnOtherAdd.Enabled = true;
                        txtOtherValue.Enabled = true;
                        txtOtherChargers.Enabled = true;
                    }

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


        }

        private void ServiceGridCal()
        {
            decimal DiscountedServicePrice = 0;
            decimal ServicePrice = 0;
            decimal totDiscout = 0;
            decimal x = 0;

            foreach (DataGridViewRow row in dgvService.Rows)
            {

                DiscountedServicePrice += (Convert.ToDecimal(row.Cells[dgvService.Columns[clmServicePrice.Name].Index].Value));
            }

            lblServiceChargeTot.Text = DiscountedServicePrice.ToString("#,##0.00");
            ServiceTotal = DiscountedServicePrice;
            TotalDiscountedPrice = ServiceTotal + MeterialsTotal + OtherCharges;
            lblTotal.Text = TotalDiscountedPrice.ToString("#,##0.00");
        }

        private void btnOtherAdd_Click()
        {
            if (txtOtherChargers.Text == string.Empty)
            {
                MessageBox.Show("please Enter service charge Descrpition");
                txtOtherChargers.Focus();
                return;
            }

            if (txtOtherValue.Text == string.Empty) 
            {
                MessageBox.Show("Please Enter Value");
                txtOtherValue.Focus();
                return;
            }

            if (GlobalListServicelSelectedList.Find(x => x.intServiceID == 1) != null)
            {
                MessageBox.Show("You can't add onther Serive", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ServiceEntity obj = new ServiceEntity();
            obj.intServiceID = 1;
            obj.vcServiceName = txtOtherChargers.Text;
            obj.decPrice = Convert.ToDecimal(txtOtherValue.Text);

         
            GlobalListServicelSelectedList.Add(obj);
            dgvService.AutoGenerateColumns = false;

            dgvService.DataSource = GlobalListServicelSelectedList.ToList();

            ServiceGridCal();

            btnOtherAdd.Enabled = false;
            txtOtherValue.Enabled = false;
            txtOtherValue.Text = string.Empty;
            txtOtherChargers.Text = string.Empty;
            txtOtherChargers.Enabled = false;
        }


        private void btnOtherAdd_Click(object sender, EventArgs e)
        {
            btnOtherAdd_Click();
        }

        private void btnOtherCharge_Click(object sender, EventArgs e)
        {
            OtherCharges = 0;
            txtOtherChargers.Text = string.Empty;
  
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
            if (dgvService.CurrentCell.ColumnIndex == 3)
            {
                e.Control.KeyPress += new KeyPressEventHandler(dgvService_KeyPress);
            }
        }

        private void txtOtherValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOtherAdd_Click();
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

            lblMeterialsTotal.Text = "0.00";
            lblServiceChargeTot.Text = "0.00";

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
            GetBrand();
            SetFormatting();

            chkApplyService.Checked = true;
            rbtCash.Checked = true;
            intPaymentMethodID = 1;
            txtOtherChargers.Text = "Other Chargers ";
            txtOtherValue.Text = string.Empty;

            txtCustomerName.Text = string.Empty;
            cmbPhoneNo.Text = string.Empty;

            btnSearch.Enabled = true;
            cmbPhoneNo.Enabled = true;

            txtMilege.Text = string.Empty;

            chkVehicle.Checked = true;
            IsCheckVehical = true;

            btnOtherAdd.Enabled = true;
            txtOtherValue.Enabled = true;
            txtOtherChargers.Enabled = true;
        }

        private void dgvAddItem_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvAddItem.Rows)
            {
                if (Convert.ToInt32(row.Cells[clmdecStockInHand.Name].Value) <= 5)
                {
                    row.DefaultCellStyle.BackColor = Color.AntiqueWhite;

                }

                if (Convert.ToInt32(row.Cells[clmdecStockInHand.Name].Value) <= 2)
                {
                    row.DefaultCellStyle.BackColor = Color.LightPink;

                }
            }

        }

        private void cmbBrand_SelectionChangeCommitted(object sender, EventArgs e)
        {
            spGetAllItemIssueAddBranWise();
        }

        private void chkVehicle_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVehicle.Checked == true)
            {
                txtvcVehicle.Enabled = true;
                txtIntVehicle.Enabled = true;
                IsCheckVehical = true;

                cmbPhoneNo.Enabled = false;
                txtCustomerName.Enabled = false;



                txtCustomerName.Text = string.Empty;
                cmbPhoneNo.Text = string.Empty;

                cmbPhoneNo.Enabled = true;
                btnSearch.Enabled = true;
                
            }
            else
            {
                txtvcVehicle.Enabled = false;
                txtIntVehicle.Enabled = false;


                IsCheckVehical = false;

                cmbPhoneNo.Enabled = true;
                txtCustomerName.Enabled = true;

                txtCustomerName.Text = string.Empty;
                cmbPhoneNo.Text = string.Empty;

                cmbPhoneNo.Enabled = true;

                txtIntVehicle.Text = string.Empty;
                txtvcVehicle.Text = string.Empty;

                btnSearch.Enabled = true;
            }
        }

        private void cmbPhoneNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (cmbPhoneNo.Text == "" && e.KeyChar == '0')
            {
                e.Handled = true;
                return;
            }
        }

        private void txtMilege_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void cmbPhoneNo_Click(object sender, EventArgs e)
        {
           GetPhoneNumber();
            txtCustomerName.Text = string.Empty;
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtDecSearch.Text = string.Empty;
        }

        private void txtDecSearch_Click(object sender, EventArgs e)
        {
            txtCodeSearch.Text = string.Empty;
        }

        private void cmbService_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
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
        }

        private void txtCustomerName_Leave(object sender, EventArgs e)
        {
            if (txtCustomerName.Text == string.Empty)
            {
                return;
            }
            else
            {
                if (MessageBox.Show("Please Register the Customer?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    GetCustomerInfo();
                }
                else
                {
                    txtCustomerName.Text = string.Empty;
                }
            }

        }

        private void cmbPhoneNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCustomerName.Text = string.Empty;
                GetCustomerInfo();
            }
        }

        private void dgvItemIssue_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //MessageBox.Show("Yesssss");
        }
    }
}
