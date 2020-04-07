using ServiceCenter.Common;
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
using System.Transactions;
using System.Windows.Forms;

namespace ServiceCenter.Return
{
    public partial class frmToCustomer : BaseUI
    {
        private IssueEntity objSupplierEntity;

        public frmToCustomer()
        {
            InitializeComponent();
            SetFormName();
        }

        private void frmToCustomer_Load(object sender, EventArgs e)
        {
            GetInvoiceNo();

        }

        private void GetInvoiceNo()
        {
            List<IssueEntity> lstInvoiceNo = new List<IssueEntity>();

            Execute objExecute = new Execute();
            DataTable dt = (DataTable)objExecute.Executes("spGetInvoiceNo", ReturnType.DataTable, CommandType.StoredProcedure);

            foreach (DataRow dr in dt.Rows)
            {
                objSupplierEntity = new IssueEntity
                {
                    intIssueHeaderID = Convert.ToInt32(dr["intIssueHeaderID"]),
                    vcIssueNo = dr["vcIssueNo"].ToString()
                };

                lstInvoiceNo.Add(objSupplierEntity);
            }

            cmbInvoiceNo.DataSource = lstInvoiceNo;
            cmbInvoiceNo.DisplayMember = "vcIssueNo";
            cmbInvoiceNo.ValueMember = "intIssueHeaderID";
            cmbInvoiceNo.SelectedIndex = -1;

        }

        private void LoadGrid()
        {

            try
            {
                Execute objExecute = new Execute();
                string Query = "[dbo].[spGetReturnToCustomerDetails]";
                SqlParameter[] para = new SqlParameter[]
                  {
                      Execute.AddParameter("@intIssueHeaderID",Convert.ToInt32(cmbInvoiceNo.SelectedValue)),
                  };
                DataTable dt = (DataTable)objExecute.Executes(Query, ReturnType.DataTable, para, CommandType.StoredProcedure);


                IssueEntity objIssueEntity;
                List<IssueEntity> lstGetItem = new List<IssueEntity>();


                foreach (DataRow dr in dt.Rows)
                {
                    objIssueEntity = new IssueEntity
                    {
                        intIssueDetailID = (int)dr["intIssueDetailID"],
                        vcItemCode = dr["vcItemCode"].ToString(),
                        vcItemDescription = dr["vcItemDescription"].ToString(),
                        vcUnit = dr["vcUnit"].ToString(),
                        IssuedQty = (int)dr["IssuedQty"],
                        decUnitPrice = (decimal)dr["decUnitPrice"],
                        decDiscountedUnitValue = (decimal)dr["decDiscountedUnitValue"],
                        decStockInHand = (int)dr["decStockInHand"],
                        AleadyReturnedQty = (int)dr["AleadyReturnedQty"],
                        IsAleadyReturned = (int)dr["IsAleadyReturned"],
                    };

                    lstGetItem.Add(objIssueEntity);
                }

                dgvReturnItem.DataSource = null;
                dgvReturnItem.AutoGenerateColumns = false;
                dgvReturnItem.DataSource = lstGetItem.ToList();


                //set return Qty to 0 from grid load
                foreach (DataGridViewRow row in dgvReturnItem.Rows)
                {
                    for (int i = 0; i < dgvReturnItem.Rows.Count; i++)
                    {
                        row.Cells[dgvReturnItem.Columns[clmReturnQty.Name].Index].Value = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data Loading Error");
                Logger.LoggError(ex, "LoadGrid");

            }

        }

        private void Save()
        {
            if (dgvReturnItem.Rows.Count > 0)
            {
                bool IsSelect = false;

                foreach (DataGridViewRow dr in dgvReturnItem.Rows)
                {
                    if (Convert.ToBoolean(dr.Cells[clmSelect.Name].Value) == true)
                    {
                        IsSelect = true;
                        break;
                    }
                }
                if (!IsSelect)
                {
                    MessageBox.Show("Please Select the Return Item..!");
                    return;
                }
            }

            foreach (DataGridViewRow row in dgvReturnItem.Rows)
            {
                if (Convert.ToBoolean(row.Cells[clmSelect.Name].Value) == true)
                {
                    if (Convert.ToBoolean(row.Cells[dgvReturnItem.Columns[clmReturnQty.Name].Index].Value == null) || (Convert.ToInt32(row.Cells[dgvReturnItem.Columns[clmReturnQty.Name].Index].Value) == 0))
                    {
                        MessageBox.Show("Please Enter Return Qty");
                        return;
                    }
                }

            }

            using (TransactionScope ts = new TransactionScope())
            {

                Execute objExecute = new Execute();
                SqlParameter[] param = new SqlParameter[]
                {

                };
                int intCustomerReturnHeaderID = objExecute.ExecuteIdentity("spSaveCustomerReturnHeader", param, CommandType.StoredProcedure);


                foreach (DataGridViewRow drReturnItem in dgvReturnItem.Rows)
                {
                    if (Convert.ToBoolean(drReturnItem.Cells[clmSelect.Name].Value) == true)
                    {
                        Execute objExecuteX = new Execute();
                        SqlParameter[] paramX = new SqlParameter[]
                        {
                                Execute.AddParameter("@intCustomerReturnHeaderID",intCustomerReturnHeaderID),
                                Execute.AddParameter("@intIssueDetailID",Convert.ToInt32(drReturnItem.Cells[clmIssueDetailID.Name].Value)),
                                Execute.AddParameter("@decReturnQty",Convert.ToDecimal(drReturnItem.Cells[clmReturnQty.Name].Value)),
                        };

                        objExecuteX.Executes("spSaveCustomerReturnDetails", paramX, CommandType.StoredProcedure);
                    }
                }

                ts.Complete();
            }

            MessageBox.Show("Returned Successfully");

            LoadGrid();/// Testing Purpose
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                LoadGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data Loading Error");
                Logger.LoggError(ex, "btnSearch_Click");
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void cmbInvoiceNo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void dgvReturnItem_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvReturnItem.Columns[clmReturnQty.Name].DefaultCellStyle.BackColor = Color.LightGreen;


            foreach (DataGridViewRow row in dgvReturnItem.Rows)
            {
                if (Convert.ToInt32(row.Cells[clmIsAleadyReturned.Name].Value) == 1)
                {
                    row.DefaultCellStyle.BackColor = Color.LightPink;

                }
               
            }

        }

        private void Validation()
        {
            decimal ReturnQty = 0;
            decimal IssuedQty = 0;
            decimal AleadyReturnedQty = 0;
            decimal chkBal = 0;

            foreach (DataGridViewRow row in dgvReturnItem.Rows)
            {
                IssuedQty = (Convert.ToDecimal(dgvReturnItem.Rows[dgvReturnItem.CurrentCell.RowIndex].Cells[clmIssuedQty.Name].Value));
                AleadyReturnedQty = (Convert.ToDecimal(dgvReturnItem.Rows[dgvReturnItem.CurrentCell.RowIndex].Cells[clmAleadyReturnedQty.Name].Value));
                ReturnQty = (Convert.ToDecimal(dgvReturnItem.Rows[dgvReturnItem.CurrentCell.RowIndex].Cells[clmReturnQty.Name].Value));

                chkBal = IssuedQty - AleadyReturnedQty;


                if ((chkBal < ReturnQty))
                {
                    MessageBox.Show("Please Check Issued Qty OR Already Returned Qty");
                    decimal empty = 0;
                    dgvReturnItem.Rows[dgvReturnItem.CurrentCell.RowIndex].Cells[clmReturnQty.Name].Value = empty;
                    return;
                }
            }
        }

        private void dgvReturnItem_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Validation();
        }


    }
}
