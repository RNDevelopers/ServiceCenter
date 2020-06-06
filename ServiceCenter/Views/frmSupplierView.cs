using ServiceCenter.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiceCenter.DBConnection;
using ServiceCenter.Entities;
using ServiceCenter.Enums;
using System.Data.SqlClient;
using ServiceCenter.ErrorLog;

namespace ServiceCenter.Views
{
    public partial class frmSupplierView : BaseUI 
    {
        public int intSupplierID;
        private List<SupplierEntity> GlobleList;


        public frmSupplierView()
        {
            InitializeComponent();

            gridLoad();
        }



        private void gridLoad()
        {
            try
            {
                Execute objExecute = new Execute();
                string Query = "[dbo].[spGetAllSupplierView]";
                SqlParameter[] para = new SqlParameter[]
                {

                };
                DataTable dt = (DataTable)objExecute.Executes(Query, ReturnType.DataTable, para, CommandType.StoredProcedure);

                SupplierEntity objSupplierEntity;
                List<SupplierEntity> lstSupplier = new List<SupplierEntity>();

                foreach (DataRow dr in dt.Rows)
                {
                    objSupplierEntity = new SupplierEntity
                    {
                        intSupplierID = (int)dr["intSupplierID"],
                        vcSupplierName = dr["vcSupplierName"].ToString(),
                        vcAddress = dr["vcAddress"].ToString(),
                        vcCity = dr["vcCity"].ToString(),
                        vcEmail = dr["vcEmail"].ToString(),
                        intContactNo = (int)dr["intContactNo"],
                    };

                    lstSupplier.Add(objSupplierEntity);
                }

                dgvSupplierView.DataSource = null;
                dgvSupplierView.AutoGenerateColumns = false;
                dgvSupplierView.DataSource = lstSupplier;

                GlobleList = lstSupplier.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data Loading Error");
                Logger.LoggError(ex, "GetAllSupplierView");
            }

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txtSupplierSearch_TextChanged(object sender, EventArgs e)
        {
            dgvSupplierView.DataSource = GlobleList.FindAll(x => x.vcSupplierName.Trim().ToLower().Contains(txtSupplierSearch.Text.Trim().ToLower()));
        }

        private void dgvSupplierView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            {
                if (dgvSupplierView.Columns[e.ColumnIndex] == clmbtnDeleteSupplier)
                {
                    intSupplierID = Convert.ToInt32(dgvSupplierView.Rows[e.RowIndex].Cells[clmintSupplierID.Name].Value);

                    DialogResult dr = MessageBox.Show("Are you sure want to Delete in this Brand ?", "CONFIRMATION", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                    if (dr == DialogResult.Yes)
                    {
                        Execute objExecute = new Execute();
                        SqlParameter[] param = new SqlParameter[]
                           {
                          Execute.AddParameter("@intSupplierID",intSupplierID),
                           };
                        //sp eka liyapan
                        int NoOfRowsEffected = objExecute.Executes("spDeleteSupplier", param, CommandType.StoredProcedure);

                        if (NoOfRowsEffected < 0)
                        {

                            MessageBox.Show("Successfully DELETE !");
                            gridLoad();
                        }
                        else
                        {
                            MessageBox.Show("Supplier DELETE Process Error !");
                        }

                    }
                }
            }
        }
    }
}
