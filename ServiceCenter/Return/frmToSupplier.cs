﻿using CrystalDecisions.CrystalReports.Engine;
using ServiceCenter.Common;
using ServiceCenter.DBConnection;
using ServiceCenter.Entities;
using ServiceCenter.Enums;
using ServiceCenter.ErrorLog;
using ServiceCenter.Report;
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

namespace ServiceCenter.Return
{
    public partial class frmToSupplier : BaseUI
    {
        private int intSupplierReturnHeaderID { get; set; }

        private GRNEntity objGRNEntity;

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

            List<GRNEntity> lstGRNNo = new List<GRNEntity>();


            Execute objExecute = new Execute();
            string Query = "[dbo].[spGetGRNNo]";
            SqlParameter[] para = new SqlParameter[]
              {
                      Execute.AddParameter("@intSupplierID",Convert.ToInt32(cmbSupplier.SelectedValue)),

              };
            DataTable dt = (DataTable)objExecute.Executes(Query, ReturnType.DataTable, para, CommandType.StoredProcedure);

            foreach (DataRow dr in dt.Rows)
            {
                objGRNEntity = new GRNEntity
                {
                    intGRNHeaderID = Convert.ToInt32(dr["intGRNHeaderID"]),
                    vcGRNNo = dr["vcGRNNo"].ToString()
                };

                lstGRNNo.Add(objGRNEntity);
            }

            cmbGRNNo.DataSource = lstGRNNo;
            cmbGRNNo.DisplayMember = "vcGRNNo";
            cmbGRNNo.ValueMember = "intGRNHeaderID";
            cmbGRNNo.SelectedIndex = -1;

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
                        vcUnit = dr["vcUnit"].ToString(),
                        decDiscountedUnitValue = (decimal)dr["decDiscountedUnitValue"],
                        decStockInHand = (int)dr["decStockInHand"],
                        GRNqty = (int)dr["decGRNQty"],
                        AleadyReturnedQty = (int)dr["AleadyReturnedQty"],
                        IsAleadyReturned = (int)dr["IsAleadyReturned"],
                    };

                    lstGetItemAdd.Add(objItemEntity);
                }

                dgvReturnItem.DataSource = null;
                dgvReturnItem.AutoGenerateColumns = false;
                dgvReturnItem.DataSource = lstGetItemAdd.ToList();

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

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Save();
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
                 intSupplierReturnHeaderID = objExecute.ExecuteIdentity("spSaveSupplierReturnHeader", param, CommandType.StoredProcedure);


                foreach (DataGridViewRow drReturnItem in dgvReturnItem.Rows)
                {
                    if (Convert.ToBoolean(drReturnItem.Cells[clmSelect.Name].Value) == true)
                    {
                        Execute objExecuteX = new Execute();
                        SqlParameter[] paramX = new SqlParameter[]
                        {
                                Execute.AddParameter("@intSupplierReturnHeaderID",intSupplierReturnHeaderID),
                                Execute.AddParameter("@intGRNDetailID",Convert.ToInt32(drReturnItem.Cells[clmGRNDetailID.Name].Value)),
                                Execute.AddParameter("@decReturnQty",Convert.ToDecimal(drReturnItem.Cells[clmReturnQty.Name].Value)),
                        };

                        objExecuteX.Executes("spSaveSupplierReturnDetails", paramX, CommandType.StoredProcedure);
                    }
                }

                ts.Complete();
            }

            MessageBox.Show("Returned Successfully");

            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;

            ///Report///////////////////////////////////////////////////
            ///
            rptSupplierReturn rpt = new rptSupplierReturn();
            ReportDocument rptDoc = new ReportDocument();

            rptDoc = rpt;

            Execute objExecuteXX = new Execute();
            string Query = "[dbo].[spGetSupplierReturnBillDetails]";
            SqlParameter[] para = new SqlParameter[]
              {
                      Execute.AddParameter("@intSupplierReturnHeaderID",intSupplierReturnHeaderID)

              };
            DataTable dt = (DataTable)objExecuteXX.Executes(Query, ReturnType.DataTable, para, CommandType.StoredProcedure);

            rpt.SetDataSource(dt);

            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;

            frmReportViewer objfrmReportViewer = new frmReportViewer(rptDoc);
            objfrmReportViewer.Show();


            //should print
            //rptDoc.PrintToPrinter(1, true, 0, 0);


            //////////////////////////////



            LoadGrid();/// Testing Purpose

        }

        private void Clear()
        {
            cmbSupplier.SelectedIndex = -1;
            cmbGRNNo.SelectedIndex = 1;
            dgvReturnItem.DataSource = null;
        }

        private void dgvReturnItem_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Validation();
        }

        private void Validation()
        {
            decimal ReturnQty = 0; 
            decimal AvailableQty = 0;
            decimal ReceivedQty = 0;

            foreach (DataGridViewRow row in dgvReturnItem.Rows)
            {
                ReceivedQty = (Convert.ToDecimal(dgvReturnItem.Rows[dgvReturnItem.CurrentCell.RowIndex].Cells[clmReceivedQty.Name].Value));
                AvailableQty = (Convert.ToDecimal(dgvReturnItem.Rows[dgvReturnItem.CurrentCell.RowIndex].Cells[clmAvailableQty.Name].Value));
                ReturnQty = (Convert.ToDecimal(dgvReturnItem.Rows[dgvReturnItem.CurrentCell.RowIndex].Cells[clmReturnQty.Name].Value));

                if (ReturnQty <= AvailableQty)
                {                    
                    if (ReturnQty > ReceivedQty)
                    {
                        MessageBox.Show("Please Check Recived Qty");
                        decimal empty = 0;
                        dgvReturnItem.Rows[dgvReturnItem.CurrentCell.RowIndex].Cells[clmReturnQty.Name].Value = empty;
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Please Check Available Qty");
                    decimal empty = 0;
                    dgvReturnItem.Rows[dgvReturnItem.CurrentCell.RowIndex].Cells[clmReturnQty.Name].Value = empty;
                    return;
                }
            }
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

        private void dgvReturnItem_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvReturnItem.CurrentCell.ColumnIndex == 10)
            {
                e.Control.KeyPress += new KeyPressEventHandler(dgvReturnItem_KeyPress);
            }
        }

        private void dgvReturnItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void cmbGRNNo_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void cmbGRNNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadGrid();
            }
        }


    }
}
