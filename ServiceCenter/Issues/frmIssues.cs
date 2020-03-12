using ServiceCenter.Common;
using ServiceCenter.Customer;
using ServiceCenter.DBConnection;
using ServiceCenter.Entities;
using ServiceCenter.Enums;
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

        List<ItemEntity> lstItems;

        public frmIssues()
        {
            InitializeComponent();
            SetFormName();
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

        public void GetAllItemDetails()
        {
            Execute objExecute = new Execute();
            lstItems = new List<ItemEntity>();
            string Query = "[dbo].[spGetAllItemDetails]";
            SqlParameter[] para = new SqlParameter[]
              {
                     // Execute.AddParameter("@intBrandID",Convert.ToInt32(cmbBrand.SelectedValue))

              };
            DataTable dt = (DataTable)objExecute.Executes(Query, ReturnType.DataTable, para, CommandType.StoredProcedure);

            foreach (DataRow dr in dt.Rows)
            {
                ItemEntity objItemEntity = new ItemEntity
                {
                    intItemID = Convert.ToInt32(dr["intItemID"]),
                    vcItemCode = dr["vcItemCode"].ToString(),
                    vcSubCategoryName = dr["vcSubCategoryName"].ToString(),
                    vcItemDescription = dr["vcItemDescription"].ToString(),
                    vcUnit = dr["vcUnit"].ToString(),
                    decUnitPrice = Convert.ToDecimal(dr["decUnitPrice"]),
                };

                lstItems.Add(objItemEntity);
            }

            dgvAddItem.DataSource = null;
            dgvAddItem.AutoGenerateColumns = false;
            dgvAddItem.DataSource = lstItems.ToList();

        }

        private void frmIssues_Load(object sender, EventArgs e)
        {
            GetAllItemDetails();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvAddItem.DataSource = lstItems.FindAll(x => x.vcItemCode.Trim().ToLower().StartsWith(txtSearch.Text.Trim().ToLower()));
        }

        private void txtDecSearch_TextChanged(object sender, EventArgs e)
        {
            dgvAddItem.DataSource = lstItems.FindAll(x => x.vcItemDescription.Trim().ToLower().Contains(txtDecSearch.Text.Trim().ToLower()));
        }
    }
}
