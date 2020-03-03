using ServiceCenter.Common;
using ServiceCenter.DBConnection;
using ServiceCenter.Entities;
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
            SupplierEntity objSupplierEntity = new SupplierEntity
            {
                vcSupplierName = txtSuppilerName.Text.ToString(),
                vcAddress = txtAddress.Text.Trim().ToUpper(),
                vcCity = txtCity.Text.Trim().ToUpper(),
                intContactNo = Convert.ToInt32(txtContactNo.Text.Trim()),
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

            int NoOfRowsEffected =  objExecute.Executes("spSaveSupplier", param, CommandType.StoredProcedure);

            if (NoOfRowsEffected < 0)
            {
                MessageBox.Show("Save..");
            }
            else
            {
                MessageBox.Show("Cant't Save..");
            }

        }
    }
}
