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

            if (txtvcVehicle.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Vehical No");
                return;
            }
            else if (txtIntVehicle.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Vehical No");
                return; 
            }
            else if (txtName.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Name");
                return;
            }
            else if (txtAddress.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Address");
                return;
            }
            else if (txtCity.Text == string.Empty)
            {
                MessageBox.Show("Please Enter City");
                return;
            }
            else if (txtContactNo.Text == string.Empty)
            {
                MessageBox.Show("Please Enter contact No");
                return;
            }
         
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

        private void txtIntVehicle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
              (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

    }
}
