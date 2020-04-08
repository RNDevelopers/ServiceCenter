using ServiceCenter.Common;
using ServiceCenter.DBConnection;
using ServiceCenter.Entities;
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

        List<BrandEntity> GlobleBrandEntity;
        BrandEntity objBrandEntity;

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
            if (GlobleBrandEntity == null)
            {
                GlobleBrandEntity = new List<BrandEntity>();
            }

            if (GlobleBrandEntity.Find(x => x.vcName == (txtBrand.Text.ToUpper())) != null)
            {
                MessageBox.Show("You can't Add Same Brand!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


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
            List<BrandEntity> lstBrandEntity = new List<BrandEntity>();
            try
            {
                Execute objExecute = new Execute();
                string Query = "[dbo].[spGetBrand]";
                SqlParameter[] para = new SqlParameter[]
                  {
   
                  };

                dt = (DataTable)objExecute.Executes(Query, ReturnType.DataTable, para, CommandType.StoredProcedure);


                foreach (DataRow dr in dt.Rows)
                {
                    BrandEntity objBrandEntity = new BrandEntity
                    {
                        intBrandID = Convert.ToInt32(dr["intBrandID"]),
                        vcName = dr["vcName"].ToString(),
                        IsActive = Convert.ToBoolean(dr["IsActive"]),
                    };

                    lstBrandEntity.Add(objBrandEntity);
                }

                dgvBrand.DataSource = null;
                dgvBrand.AutoGenerateColumns = false;
                dgvBrand.DataSource = lstBrandEntity.ToList();

                GlobleBrandEntity = lstBrandEntity;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());               
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
                         
                            MessageBox.Show("Successfully DELETE !");
                            GridLoad();
                        }
                        else
                        {
                            MessageBox.Show("Brand DELETE Process Error !");
                        }

                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void txtBrand_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                SaveBrand();
                Clear();
                GridLoad();
            }
        }
    }
}
