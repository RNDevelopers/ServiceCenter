using ServiceCenter.Common;
using ServiceCenter.DBConnection;
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

namespace ServiceCenter.Customer
{
    public partial class frmAddCustomer : BaseUI
    {

        public string vcVehicleNo { get; set; }
        public string intVehicleNo { get; set; }
        public string FullVehicleNO { get; set; }

        public frmAddCustomer()
        {
            InitializeComponent();
            this.SetFormName();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveCustomer();
        }

        public void SaveCustomer()
        {
            vcVehicleNo = txtvcVehicle.Text.ToUpper();
            intVehicleNo = txtIntVehicle.Text.ToString();
            FullVehicleNO = vcVehicleNo + '-' + intVehicleNo;

            DialogResult dr = MessageBox.Show("Are You Sure Want to Add Customer ?", "CONFIRM", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {

                Execute objExecute = new Execute();
                SqlParameter[] param = new SqlParameter[]
                   {
                    Execute.AddParameter("@vcVehicleNo",FullVehicleNO),
                    Execute.AddParameter("@vcCustomerName",txtName.Text.ToUpper()),
                    Execute.AddParameter("@vcAddress",txtAddress.Text.ToUpper()),
                    Execute.AddParameter("@vcCity",txtCity.Text.ToUpper()),
                    Execute.AddParameter("@intContactNo",Convert.ToInt32(txtContactNo.Text.ToString()))
                   };

                int NoOfRowsEffected = objExecute.Executes("spSaveCustomer", param, CommandType.StoredProcedure);

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
}
