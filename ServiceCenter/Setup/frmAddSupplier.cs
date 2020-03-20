using ServiceCenter.Common;
using ServiceCenter.DBConnection;
using ServiceCenter.Entities;
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

namespace ServiceCenter.Setup
{
    public partial class frmAddSupplier : BaseUI
    {
        SupplierEntity objSupplierEntity;

        public frmAddSupplier()
        {
            InitializeComponent();
            this.SetFormName();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveSupplier();

        }

        public void SaveSupplier() 
        {

            try
            {
                if (txtSuppilerName.Text == string.Empty)
                {
                    MessageBox.Show("Please Enter the Supplier Name");
                    return;
                }
                else if (txtContactNo.Text == string.Empty)
                {
                    MessageBox.Show("Please Enter the Contact No Name");
                    return;
                }



                int ContactNo = Convert.ToInt32(txtContactNo.Text);

                SupplierEntity objSupplierEntity = new SupplierEntity
                {
                    vcSupplierName = txtSuppilerName.Text.Trim().ToUpper(),
                    vcAddress = txtAddress.Text.Trim().ToUpper(),
                    vcCity = txtCity.Text.Trim().ToUpper(),
                    intContactNo = ContactNo,
                    vcEmail = txtEmail.Text.Trim(),
                };

                Execute objExecute = new Execute();
                SqlParameter[] param = new SqlParameter[]
                   {
                    Execute.AddParameter("@vcSupplierName",objSupplierEntity.vcSupplierName),
                    Execute.AddParameter("@vcAddress",objSupplierEntity.vcAddress),
                    Execute.AddParameter("@vcCity",objSupplierEntity.vcCity),
                    Execute.AddParameter("@intContactNo",objSupplierEntity.intContactNo),
                    Execute.AddParameter("@vcEmail",objSupplierEntity.vcEmail),

                   };

                int NoOfRowsEffected = objExecute.Executes("spSaveSupplier", param, CommandType.StoredProcedure);

                if (NoOfRowsEffected < 0)
                {
                    MessageBox.Show("Save..");
                    clear();
                }
                else
                {
                    MessageBox.Show("Cant't Save..");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cant't Save.. Please Contact the Developer");
                Logger.LoggError(ex, "SaveSupplier()");
            }


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void clear()
        {
            txtSuppilerName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtContactNo.Text = string.Empty;
            txtEmail.Text = string.Empty;

        }
    }
}
