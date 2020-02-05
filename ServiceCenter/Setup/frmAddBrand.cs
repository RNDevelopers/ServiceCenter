using ServiceCenter.Common;
using ServiceCenter.DBConnection;
using ServiceCenter.Enums;
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
    public partial class frmAddBrand : BaseUI
    {

        public int intBrandID;

        public frmAddBrand()
        {
            InitializeComponent();
            this.SetFormName();
            GridLoad();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveBrand();
            Clear();
            GridLoad();
        }

        public void Clear()
        {
            txtBrand.Text = string.Empty;
        }

        public void SaveBrand()
        {
            DialogResult dr = MessageBox.Show("Are You Sure Want to Add New Brand ?", "CONFIRM", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {

                Execute objExecute = new Execute();
                SqlParameter[] param = new SqlParameter[]
                   {
                    Execute.AddParameter("@vcName",txtBrand.Text.Trim().ToUpper()),
                   };

                int NoOfRowsEffected = objExecute.Executes("spSaveBrand", param, CommandType.StoredProcedure);

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

        public void GridLoad()
        {
            DataTable dt = new DataTable();
            try
            {
                Execute objExecute = new Execute();
                string Query = "[dbo].[spGetBrand]";
                SqlParameter[] para = new SqlParameter[]
                  {
   
                  };

                dt = (DataTable)objExecute.Executes(Query, ReturnType.DataTable, para, CommandType.StoredProcedure);

                dgvBrand.DataSource = dt;
            }

            catch (Exception)
            {

               
            }

        }

        private void frmAddBrand_Load(object sender, EventArgs e)
        {

        }

        private void dgvBrand_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                if (dgvBrand.Columns[e.ColumnIndex] == clmbtnDelete)
                {
                    intBrandID = Convert.ToInt32(dgvBrand.Rows[e.RowIndex].Cells[clmBrandID.Name].Value);

                    DialogResult dr = MessageBox.Show("Are you sure want to Delete in this Brand ?", "CONFIRMATION", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                    if (dr == DialogResult.Yes)
                    {
                        Execute objExecute = new Execute();
                        SqlParameter[] param = new SqlParameter[]
                           {
                          Execute.AddParameter("@intBrandID",intBrandID),
                           };

                        int NoOfRowsEffected = objExecute.Executes("spDeleteBrand", param, CommandType.StoredProcedure);

                        if (NoOfRowsEffected < 0)
                        {
                            GridLoad();
                            MessageBox.Show("Successfully DELETE !");
                        }
                        else
                        {
                            MessageBox.Show("Brand DELETE Process Error !");
                        }

                    }
                }
            }
        }
    }
}
