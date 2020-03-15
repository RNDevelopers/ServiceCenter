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
using System.Windows.Forms;

namespace ServiceCenter.Return
{
    public partial class frmToSupplier : BaseUI
    {
        public frmToSupplier()
        {
            InitializeComponent();
            SetFormName();

            GetSupplier();
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

        public void GetGRNNo()
        {
            Execute objExecute = new Execute();
            string Query = "[dbo].[spGetGRNNo]";
            SqlParameter[] para = new SqlParameter[]
              {
                      Execute.AddParameter("@intSupplierID",Convert.ToInt32(cmbSupplier.SelectedValue)),

              };
            DataTable dt = (DataTable)objExecute.Executes(Query, ReturnType.DataTable, para, CommandType.StoredProcedure);

            cmbGRNNo.DataSource = dt;
            cmbGRNNo.DisplayMember = "vcGRNNo";
            cmbGRNNo.ValueMember = "intGRNHeaderID";
            cmbGRNNo.SelectedIndex = -1;

        }

        private void frmToSupplier_Load(object sender, EventArgs e)
        {

        }

        private void cmbSupplier_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetGRNNo();
        }

        public void LoadGrid()
        {
            try
            {
                Execute objExecute = new Execute();
                string Query = "[dbo].[spGetReturnToSupplierDetails]";
                SqlParameter[] para = new SqlParameter[]
                  {
                      Execute.AddParameter("@intGRNHeaderID",Convert.ToInt32(cmbGRNNo.SelectedValue)),
                  };
                DataTable dt = (DataTable)objExecute.Executes(Query, ReturnType.DataTable, para, CommandType.StoredProcedure);

                ItemEntity objItemEntity;
                List<ItemEntity> lstGetItemAdd = new List<ItemEntity>();


                foreach (DataRow dr in dt.Rows)
                {
                    objItemEntity = new ItemEntity
                    {
                        intGRNDetailID = (int)dr["intGRNDetailID"],
                        vcItemCode = dr["vcItemCode"].ToString(),
                        vcItemDescription = dr["vcItemDescription"].ToString(),
                        decStockInHand = (decimal)dr["decStockInHand"],
                        GRNqty = (decimal)dr["decGRNQty"],

                    };

                    lstGetItemAdd.Add(objItemEntity);
                }

                dgvReturnItem.DataSource = null;
                dgvReturnItem.AutoGenerateColumns = false;
                dgvReturnItem.DataSource = lstGetItemAdd;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Data Loading Error");
                Logger.LoggError(ex, "LoadGrid");
            }

        }

        private void cmbGRNNo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {

        }
    }
}
