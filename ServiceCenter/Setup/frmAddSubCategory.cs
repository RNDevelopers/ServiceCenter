using ServiceCenter.Common;
using ServiceCenter.DBConnection;
using ServiceCenter.Enums;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ServiceCenter.Setup
{
    public partial class frmAddSubCategory : BaseUI
    {
        public int intSubCategoryID;

        public frmAddSubCategory()
        {
            InitializeComponent();
            this.SetFormName();

            GetMainCategory();

        }

        public void GetMainCategory()
        {
            Execute objExecute = new Execute();
            DataTable dt = (DataTable)objExecute.Executes("spGetMainCategory", ReturnType.DataTable, CommandType.StoredProcedure);

            cmbMainCategory.DataSource = dt;
            cmbMainCategory.DisplayMember = "vcMainCategoryName";
            cmbMainCategory.ValueMember = "intMainCategoryID";
            cmbMainCategory.SelectedIndex = -1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveSubCategory();
        }

        public void LoadGrid()
        {
            Execute objExecute = new Execute();
            string Query = "[dbo].[spGetSubCat]";
            SqlParameter[] para = new SqlParameter[]
              {
                      Execute.AddParameter("@intMainCategoryID",Convert.ToInt32(cmbMainCategory.SelectedValue))

              };
            DataTable dt = (DataTable)objExecute.Executes(Query, ReturnType.DataTable, para, CommandType.StoredProcedure);

            dgvAddSubCategory.DataSource = dt;
        }

        public void SaveSubCategory()
        {
            DialogResult dr = MessageBox.Show("Are You Sure Want to Add Sub Category ?", "CONFIRM", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {

                Execute objExecute = new Execute();
                SqlParameter[] param = new SqlParameter[]
                   {
                     Execute.AddParameter("@intMainCategoryID",Convert.ToInt32(cmbMainCategory.SelectedValue)),
                     Execute.AddParameter("@vcSubCategoryName",txtSubCategory.Text.Trim().ToUpper()),
                   };

                int NoOfRowsEffected = objExecute.Executes("SaveSubCategory", param, CommandType.StoredProcedure);

                if (NoOfRowsEffected < 0)
                {
                    MessageBox.Show("Save..");
                    LoadGrid();
                    txtSubCategory.Text = String.Empty;
                }
                else
                {
                    MessageBox.Show("Cant't Save..");
                }
            }
        }

        private void frmAddSubCategory_Load(object sender, EventArgs e)
        {
           
        }

        private void cmbMainCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void txtSubCategory_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                SaveSubCategory();
            }
        }

        private void dgvAddSubCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                if (dgvAddSubCategory.Columns[e.ColumnIndex] == clmbtnDelete)
                {
                    intSubCategoryID = Convert.ToInt32(dgvAddSubCategory.Rows[e.RowIndex].Cells[clmintSubCategoryID.Name].Value);

                    DialogResult dr = MessageBox.Show("Are you sure want to Delete in this SubCategory ?", "CONFIRMATION", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                    if (dr == DialogResult.Yes)
                    {
                        Execute objExecute = new Execute();
                        SqlParameter[] param = new SqlParameter[]
                           {
                          Execute.AddParameter("@intSubCategoryID",intSubCategoryID),
                           };

                        int NoOfRowsEffected = objExecute.Executes("spDeleteSubcategory", param, CommandType.StoredProcedure);

                        if (NoOfRowsEffected < 0)
                        {

                            MessageBox.Show("Successfully DELETE !");
                            LoadGrid();

                        }
                        else
                        {
                            MessageBox.Show("SubCategory DELETE Process Error !");
                        }

                    }
                }
            }
        }
    }
}
