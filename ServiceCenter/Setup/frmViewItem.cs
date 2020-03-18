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
    public partial class frmViewItem : BaseUI
    {
        public int intCustomerID { get; set; }
        public string vcVehicleNo { get; set; }
        public string intVehicleNo { get; set; }
        public string FullVehicleNO { get; set; }


        private ItemEntity objItemEntity;
        private List<ItemEntity> GlobalList;
        private List<ItemEntity> GlobalSelectedItemList = new List<ItemEntity>();


        public frmViewItem()
        {
            InitializeComponent();
            GetService();
         
        }

        public void GetService()
        {
            Execute objExecute = new Execute();
            DataTable dt = (DataTable)objExecute.Executes("spGetService", ReturnType.DataTable, CommandType.StoredProcedure);

        }
        private void frmViewItem_Load(object sender, EventArgs e)
        {
            GetAllItemViewItem();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvViewItemList.DataSource = GlobalList.FindAll(x => x.vcItemCode.Trim().ToLower().StartsWith(txtSearch.Text.Trim().ToLower()));
        }

        public void GetAllItemViewItem()
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

                dgvViewItemList.DataSource = null;
                dgvViewItemList.AutoGenerateColumns = false;
                dgvViewItemList.DataSource = lstGetItemAdd;

                GlobalList = lstGetItemAdd.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data Loading Error");
                Logger.LoggError(ex, "GetAllItemIssueAdd");
            }

        }

        private void dgvViewItemList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtDecSearch_TextChanged(object sender, EventArgs e)
        {
            dgvViewItemList.DataSource = GlobalList.FindAll(x => x.vcItemDescription.Trim().ToLower().Contains(txtDecSearch.Text.Trim().ToLower()));
        }

        private void dgvViewItemList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                if (dgvViewItemList.Columns[e.ColumnIndex] == clmbtnEdit)
                {
                    frmEditItem obj = new frmEditItem();
                    obj.txtItemID.Text = dgvViewItemList.SelectedRows[0].Cells[0].Value.ToString();
                    obj.ShowDialog();
                }
            }
        }
    }
}
