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
    public partial class frmAddCompany : BaseUI
    {
        CompanyEntity objCompanyEntity;

        public frmAddCompany()
        {
            InitializeComponent();
            this.SetFormName();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveCompany();
        }
         //from Raamod
         //edit 
        public void SaveCompany() 
        {
            CompanyEntity objCompanyEntity = new CompanyEntity
            {
                vcCompanyName = txtCompanyName.Text.Trim(),
                vcAddress = txtAddress.Text.Trim(),
                vcCity = txtCity.Text.Trim().ToUpper(),
                intContactNo = Convert.ToInt32(txtContactNo.Text.Trim()),
                vcEmail = txtEmail.Text.Trim(),
                vcSupplierName = txtSuppilerName.Text.Trim(),
                vcDesignature = txtDesignature.Text.Trim(),
            };

            Execute objExecute = new Execute();
            SqlParameter[] param = new SqlParameter[]
               {
                    Execute.AddParameter("@vcCompanyName",objCompanyEntity.vcCompanyName),
                    Execute.AddParameter("@vcAddress",objCompanyEntity.vcAddress),
                    Execute.AddParameter("@vcCity",objCompanyEntity.vcCity),
                    Execute.AddParameter("@intContactNo",objCompanyEntity.intContactNo),
                    Execute.AddParameter("@vcEmail",objCompanyEntity.vcEmail),
                    Execute.AddParameter("@vcSupplierName",objCompanyEntity.vcSupplierName),
                    Execute.AddParameter("@vcDesignature",objCompanyEntity.vcDesignature)
               };

            int NoOfRowsEffected =  objExecute.Executes("spSaveCompany", param, CommandType.StoredProcedure);

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
