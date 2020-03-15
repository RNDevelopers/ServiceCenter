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

        private ItemEntity objItemEntity;
        private List<ItemEntity> GlobalList;
        private List<ItemEntity> GlobalSelectedItemList = new List<ItemEntity>();

        public frmIssues()
        {
            InitializeComponent();
            SetFormName();

            GetService();
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

        public void GetCustomerInfo()
        {
            lblCustomerName.Text = String.Empty;
            lblPhoneNo.Text = String.Empty;

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
                //txtvcVehicle.Focus();
                btnRegister.Focus();
            }
        }

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

        public void GetAllItemIssueAdd()
        {
            try
            {
                Execute objExecute = new Execute();
                string Query = "[dbo].[spGetAllItemIssueAdd]";
                SqlParameter[] para = new SqlParameter[]
                  {

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
            GetAllItemIssueAdd();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvAddItem.DataSource = GlobalList.FindAll(x => x.vcItemCode.Trim().ToLower().StartsWith(txtSearch.Text.Trim().ToLower()));
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

        }

        private void chkApplyService_CheckedChanged(object sender, EventArgs e)
        {
            if (chkApplyService.Checked)
            {
                cmbService.Enabled = true;
                btnAdd.Enabled = true;
                txtOtherChargers.Enabled = true;
                txtOtherValue.Enabled = true;
                btnOtherAdd.Enabled = true;
                dgvService.Enabled = true;
            }
            else
            {
                cmbService.Enabled = false;
                btnAdd.Enabled = false;
                txtOtherChargers.Enabled = false;
                txtOtherValue.Enabled = false;
                btnOtherAdd.Enabled = false;
                dgvService.Enabled = false;
            }
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
                dgvItemIssue.AutoGenerateColumns = false;
                dgvItemIssue.DataSource = GlobalSelectedItemList.ToList();

            }
            catch (Exception)
            {

                throw;
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

            lblTotal.Text = totDiscout.ToString("#,##0.00");

        }

        private void dgvItemIssue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvItemIssue.Columns[e.ColumnIndex] == clmbtnDelete)
            {
                int id = Convert.ToInt32(dgvItemIssue.Rows[dgvItemIssue.CurrentCell.RowIndex].Cells[clmItemID1.Name].Value);
                GlobalSelectedItemList.RemoveAll(x => x.intItemID == id);
                dgvItemIssue.DataSource = GlobalSelectedItemList.ToList();

            }
        }
    }
}
