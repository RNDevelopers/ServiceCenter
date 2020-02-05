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
    public partial class frmAddMainCategory : BaseUI
    {
        public frmAddMainCategory()
        {
            InitializeComponent();    
            this.SetFormName();
            GridLoad();
        }

 
        private void frmAddMainCategory_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveMainCategory();
            GridLoad();
            Clear();
        }

        public void Clear()
        {
            txtMainCategoryName.Text = string.Empty;
            txtCategoryCode.Text = string.Empty;
        }


        public void GridLoad()
        {
            DataTable dt = new DataTable();
            try
            {
                Execute objExecute = new Execute();
                string Query = "[dbo].[spGetMainCategory]";
                SqlParameter[] para = new SqlParameter[]
                  {

                  };

                dt = (DataTable)objExecute.Executes(Query, ReturnType.DataTable, para, CommandType.StoredProcedure);

                dgvAddMainCategory.DataSource = dt;
            }

            catch (Exception)
            {

                throw;
            }

        }

        public void SaveMainCategory()
        {
            DialogResult dr = MessageBox.Show("Are You Sure Want to Add Main Category ?", "CONFIRM", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {

                Execute objExecute = new Execute();
                SqlParameter[] param = new SqlParameter[]
                   {
                    Execute.AddParameter("@MainCategoryName",txtMainCategoryName.Text.Trim()),
                     Execute.AddParameter("@vcItemCode",txtCategoryCode.Text.Trim()),
                   };

                int NoOfRowsEffected = objExecute.Executes("SaveMainCategory", param, CommandType.StoredProcedure);

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

        private void txtCategoryCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}
