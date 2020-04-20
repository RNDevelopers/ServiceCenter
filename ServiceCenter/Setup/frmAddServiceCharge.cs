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
using System.Transactions;
using System.Windows.Forms;

namespace ServiceCenter.Setup
{
    public partial class frmAddServiceCharge : BaseUI
    {

        public int ServiceID { get; set; }

        List<ServiceEntity> GlobleBrandEntity;
        ServiceEntity objBrandEntity;

        public frmAddServiceCharge()
        {
            InitializeComponent();
            SetFormName();
            GridLoad();
            btnUpdate.Visible = false;

        }

        public void saveAddServiceCharge()
        {
            if (txtServiceDec.Text == null || txtServiceDec.Text == "" || txtPrice.Text == null || txtPrice.Text == "")
            {
                MessageBox.Show("There is Empty value");
            }
            else
            {

                if (GlobleBrandEntity == null)
                {
                    GlobleBrandEntity = new List<ServiceEntity>();
                }

                if (GlobleBrandEntity.Find(x => x.vcServiceName == (txtServiceDec.Text.ToUpper())) != null)
                {
                    MessageBox.Show("You can't Add Same Service!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                DialogResult dr = MessageBox.Show("Are You Sure Want to Add New Service ?", "CONFIRM", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {

                    Execute objExecute = new Execute();
                    SqlParameter[] param = new SqlParameter[]
                       {
                    Execute.AddParameter("@vcServiceName",txtServiceDec.Text.Trim().ToUpper()),
                    Execute.AddParameter("@decPrice",Convert.ToInt32( txtPrice.Text))
                       };

                    int NoOfRowsEffected = objExecute.Executes("spSaveServiceCharges", param, CommandType.StoredProcedure);

                    if (NoOfRowsEffected < 0)
                    {
                        MessageBox.Show("Save..");
                        GridLoad();
                        txtServiceDec.Text = string.Empty;
                        txtPrice.Text = string.Empty;

                    }
                    else
                    {
                        MessageBox.Show("Cant't Save..");
                    }
                }

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveAddServiceCharge();
        }

        public void GridLoad()
        {
            DataTable dt = new DataTable();
            List<ServiceEntity> lstServiceEntity = new List<ServiceEntity>();
            try
            {
                Execute objExecute = new Execute();
                string Query = "[dbo].[spGetService]";
                SqlParameter[] para = new SqlParameter[]
                  {

                  };

                dt = (DataTable)objExecute.Executes(Query, ReturnType.DataTable, para, CommandType.StoredProcedure);


                foreach (DataRow dr in dt.Rows)
                {
                    ServiceEntity objServiceEntity = new ServiceEntity
                    {
                        intServiceID = Convert.ToInt32(dr["intServiceID"]),
                        vcServiceName = dr["vcServiceName"].ToString(),
                        decPrice = Convert.ToDecimal(dr["decPrice"]),
                    };

                    lstServiceEntity.Add(objServiceEntity);
                }

                dgvAddServiceChange.DataSource = null;
                dgvAddServiceChange.AutoGenerateColumns = false;
                dgvAddServiceChange.DataSource = lstServiceEntity.ToList();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void dgvAddServiceChange_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            try
            {
                //Delete Column
                if (dgvAddServiceChange.Columns[e.ColumnIndex] == clmbtnDelete)
                {
                    btnUpdate.Visible = true;
                    btnUpdate.Visible = false;

                    ServiceID = Convert.ToInt32(dgvAddServiceChange.Rows[e.RowIndex].Cells[clmServiceID.Name].Value);

                    DialogResult dr = MessageBox.Show("Are you sure want to Delete in this Service ?", "CONFIRMATION", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                    if (dr == DialogResult.Yes)
                    {
                        
                        Execute objExecute = new Execute();
                        SqlParameter[] param = new SqlParameter[]
                        {
                            Execute.AddParameter("@intServiceID",ServiceID),
                        };
                        int NoOfRowsEffected = objExecute.Executes("spDeleteService", param, CommandType.StoredProcedure);

                        if (NoOfRowsEffected < 0)
                        {
                            MessageBox.Show("Successfully DELETE !");
                            GridLoad();
                            btnSave.Visible = true;
                            btnUpdate.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("Item DELETE Process Error !");
                        }

                    }
                }

                //edit column

               // btnSave.Visible = false;
               // btnUpdate.Visible = true;

                if (dgvAddServiceChange.Columns[e.ColumnIndex] == clmbtnEdit)
                {
                    decimal ServicePrice;
                   

                    ServiceID = Convert.ToInt32(dgvAddServiceChange.Rows[e.RowIndex].Cells[clmServiceID.Name].Value);
                    
                    {
                        Execute objExecute = new Execute();
                        string Query = "[dbo].[spGetServiceToEdit]";
                        SqlParameter[] paramt = new SqlParameter[]
                        {
                            Execute.AddParameter("@intServiceID",ServiceID)
                        };
                        DataSet ds = (DataSet)objExecute.Executes(Query, ReturnType.DataSet, paramt, CommandType.StoredProcedure);

                        if (ds.Tables[0].Rows.Count > 0)
                        {
                          
                            txtServiceDec.Text = ds.Tables[0].Rows[0]["vcServiceName"].ToString();
                            ServicePrice = Convert.ToDecimal(ds.Tables[0].Rows[0]["decPrice"].ToString());
                            txtPrice.Text = ServicePrice.ToString();

                        }

                        btnSave.Visible = false;
                        btnUpdate.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data Deleting Error");
                Logger.LoggError(ex, "dgvAddServiceChange_CellClick");
            }


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateService();
        }

        public void updateService()
        {

            try
            {   //spUpdateService

                using (TransactionScope ts = new TransactionScope())
                {
                    DialogResult dr = MessageBox.Show("Update The Service ?", "CONFIRM", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    
                    if (dr == DialogResult.Yes)
                    {
                        Execute objExecute = new Execute();
                        SqlParameter[] param = new SqlParameter[]
                        {
                               Execute.AddParameter("@intServiceID",ServiceID),
                               Execute.AddParameter("@vcServiceName",txtServiceDec.Text.Trim()),
                               Execute.AddParameter("@decPrice",Convert.ToDecimal(txtPrice.Text.Trim()))

                        };

                        objExecute.Executes("[spUpdateServiceCharges]", param, CommandType.StoredProcedure);
                        MessageBox.Show("Update Item..");

                        txtServiceDec.Text = string.Empty;
                        txtPrice.Text = string.Empty;
                        btnSave.Visible = true;
                        btnUpdate.Visible = false;

                        GridLoad();
                    }
                    ts.Complete();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data Updating Error");
                Logger.LoggError(ex, "btnUpdate_Click");
            }
        }

        private void txtPrice_KeyUp(object sender, KeyEventArgs e)
        {
            if ((txtPrice.Text == String.Empty) && (txtServiceDec.Text==String.Empty))
            {
                btnSave.Visible = true;
                btnUpdate.Visible = false;
            }
        }
        
        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if(btnSave.Visible==true)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    saveAddServiceCharge();
                }
            }
            else
            {
                if (e.KeyCode == Keys.Enter)
                {
                    updateService();
                }
            }
            
        }

        private void txtServiceDec_KeyUp(object sender, KeyEventArgs e)
        {
            if ((txtPrice.Text == String.Empty) && (txtServiceDec.Text == String.Empty))
            {
                btnSave.Visible = true;
                btnUpdate.Visible = false;
            }
        }
    }
}
