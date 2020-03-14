using ServiceCenter.Common;
using ServiceCenter.DBConnection;
using ServiceCenter.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceCenter.Return
{
    public partial class frmToSupplier : BaseUI
    {
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



    }
}
