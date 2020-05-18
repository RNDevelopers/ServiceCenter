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

namespace ServiceCenter.Views
{
    public partial class frmCustomersView : BaseUI
    {

        private List<CustomerEntity> GlobalList;

        public frmCustomersView()
        {
            InitializeComponent();
            SetFormName();

            GridLoad();
        }


        private void GridLoad()
        {
            try
            {
                Execute objExecute = new Execute();
                string Query = "[dbo].[spGetAllCustomerView]";
                SqlParameter[] para = new SqlParameter[]
                  {
                 
                  };
                DataTable dt = (DataTable)objExecute.Executes(Query, ReturnType.DataTable, para, CommandType.StoredProcedure);

                CustomerEntity objCustomerEntity;
                List<CustomerEntity> lstCustomer = new List<CustomerEntity>();


                foreach (DataRow dr in dt.Rows)
                {
                    objCustomerEntity = new CustomerEntity
                    {
                        intCustomerID = (int)dr["intCustomerID"],
                        vcVehicleNo = dr["vcVehicleNo"].ToString(),
                        vcCustomerName = dr["vcCustomerName"].ToString(),
                        vcAddress = dr["vcAddress"].ToString(),
                        vcCity = dr["vcCity"].ToString(),
                        intContactNo = (int)dr["intContactNo"],
                    };

                    lstCustomer.Add(objCustomerEntity);
                }

                dgvCustomerView.DataSource = null;
                dgvCustomerView.AutoGenerateColumns = false;
                dgvCustomerView.DataSource = lstCustomer;

                GlobalList = lstCustomer.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data Loading Error");
                Logger.LoggError(ex, "GetAllItemIssueAdd");
            }

        }

        private void txtCodeSearch_TextChanged(object sender, EventArgs e)
        {
            dgvCustomerView.DataSource = GlobalList.FindAll(x => x.vcVehicleNo.Trim().ToLower().Contains(txtVehicleSearch.Text.Trim().ToLower()));
        }

        private void txtNameSearch_TextChanged(object sender, EventArgs e)
        {
            dgvCustomerView.DataSource = GlobalList.FindAll(x => x.vcCustomerName.Trim().ToLower().Contains(txtNameSearch.Text.Trim().ToLower()));
        }

        private void txtVehicleSearch_Click(object sender, EventArgs e)
        {
            txtNameSearch.Text = string.Empty;
        }

        private void txtNameSearch_Click(object sender, EventArgs e)
        {
            txtVehicleSearch.Text = string.Empty;
        }
    }
}
