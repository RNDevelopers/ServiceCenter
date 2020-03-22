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
        string vcVehicleNotext;
        string intVehicleNotext;

        public string vcVehicleNo { get; set; }
        public string intVehicleNo { get; set; }
        public string FullVehicleNO { get; set; }

        private bool IsCheckVehical = true;

        public frmAddCustomer(string vcVehicleNo, string intVehicleNo)
        {
            InitializeComponent();
            this.SetFormName();
            this.vcVehicleNotext = vcVehicleNo;
            this.intVehicleNotext = intVehicleNo;

            txtvcVehicle.Text = vcVehicleNo;
            txtIntVehicle.Text = intVehicleNo;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveCustomer();
        }

        public void SaveCustomer()
        {
            if (IsCheckVehical == true)
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
                    Execute.AddParameter("@intContactNo",Convert.ToInt32(txtContactNo.Text))
                   };

                int NoOfRowsEffected = objExecute.Executes("spSaveCustomer", param, CommandType.StoredProcedure);

                if (NoOfRowsEffected < 0)
                {
                    MessageBox.Show("Save..");
                    this.Close();
                
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

        private void chkVehical_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVehicle.Checked == true)
            {
                txtvcVehicle.Enabled = true;
                txtIntVehicle.Enabled = true;
                 IsCheckVehical = true;
    }
            else
            {
                txtvcVehicle.Enabled = false;
                txtIntVehicle.Enabled = false;

                IsCheckVehical = false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtIntVehicle.Text = string.Empty;
            txtvcVehicle.Text = string.Empty;
            txtName.Text = string.Empty;

            txtAddress.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtContactNo.Text = string.Empty;
        }

        private void frmAddCustomer_Load(object sender, EventArgs e)
        {
            this.txtName.Focus();
        }

        private void txtContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
              (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
