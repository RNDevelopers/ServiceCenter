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
    public partial class frmAssignSubCategoryBrand : BaseUI
    {

        List<CategoryEntity> GlobleCategoryEntity;

        public frmAssignSubCategoryBrand()
        {
            InitializeComponent();
            this.SetFormName();
        }

        public void GetBrand()
        {
            Execute objExecute = new Execute();
            DataTable dt = (DataTable)objExecute.Executes("spGetBrand", ReturnType.DataTable, CommandType.StoredProcedure);

            cmbBrand.DataSource = dt;
            cmbBrand.DisplayMember = "vcName";
            cmbBrand.ValueMember = "intBrandID";
            cmbBrand.SelectedIndex = -1;
        }

        public void GetAllSubCat()
        {
            Execute objExecute = new Execute();
            DataTable dt = (DataTable)objExecute.Executes("spGetAllSubCat", ReturnType.DataTable, CommandType.StoredProcedure);

            cmbSubCat.DataSource = dt;
            cmbSubCat.DisplayMember = "vcSubCategoryName";
            cmbSubCat.ValueMember = "intSubCategoryID";
            cmbSubCat.SelectedIndex = -1;
        }

        private void frmAssignSubCategoryBrand_Load(object sender, EventArgs e)
        {
            GetBrand();
            GetAllSubCat();
        }

        private void cmbBrand_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetBrandWiseSubCat();
        }

        public void GetBrandWiseSubCat()
        {
            Execute objExecute = new Execute();
            List<CategoryEntity> lstCategory = new List<CategoryEntity>();
            string Query = "[dbo].[spGetBrandWiseSubCat]";
            SqlParameter[] para = new SqlParameter[]
              {
                      Execute.AddParameter("@intBrandID",Convert.ToInt32(cmbBrand.SelectedValue))

              };
            DataTable dt = (DataTable)objExecute.Executes(Query, ReturnType.DataTable, para, CommandType.StoredProcedure);

            foreach (DataRow dr in dt.Rows)
            {
                CategoryEntity objCategoryEntity = new CategoryEntity
                {
                    intSubCatDetailsID = Convert.ToInt32(dr["intSubCatDetailsID"]),
                    intSubCatID = Convert.ToInt32(dr["intSubCatID"]),
                    intBrandID = Convert.ToInt32(dr["intBrandID"]),
                    vcSubCategoryName = dr["vcSubCategoryName"].ToString(),
                };

                lstCategory.Add(objCategoryEntity);
            }

            dgvSubCat.DataSource = null;
            dgvSubCat.AutoGenerateColumns = false;
            dgvSubCat.DataSource = lstCategory.ToList();

            GlobleCategoryEntity = lstCategory;

        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            if (cmbBrand.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the Brand");
                return;
            }
            else if (cmbSubCat.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the SubCategory");
                return;
            }

            if (GlobleCategoryEntity == null)
            {
                GlobleCategoryEntity = new List<CategoryEntity>();
            }

            if (GlobleCategoryEntity.Find(x => x.intSubCatID == Convert.ToInt32(cmbSubCat.SelectedValue)) != null)
            {
                MessageBox.Show("You can't Assgin SubCategory", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbSubCat.SelectedIndex = -1;
                return;
            }


            DialogResult dr = MessageBox.Show("Are You Sure Want to Assgin SubCategory ?", "CONFIRM", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {

                Execute objExecute = new Execute();
                SqlParameter[] param = new SqlParameter[]
                   {
                     Execute.AddParameter("@intBrandID",Convert.ToInt32(cmbBrand.SelectedValue)),
                     Execute.AddParameter("@intSubCatID",Convert.ToInt32(cmbSubCat.SelectedValue)),
                   };

                int NoOfRowsEffected = objExecute.Executes("SaveSubCatDetails", param, CommandType.StoredProcedure);

                if (NoOfRowsEffected < 0)
                {
                    MessageBox.Show("Save..");
                    GetBrandWiseSubCat();
                    cmbSubCat.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("Cant't Save..");
                    cmbSubCat.SelectedIndex = -1;
                }
            }
        }
    }
}
