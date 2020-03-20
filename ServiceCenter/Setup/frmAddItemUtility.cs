using ServiceCenter.Common;
using ServiceCenter.DBConnection;
using ServiceCenter.Entities;
using ServiceCenter.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace ServiceCenter.Setup
{
    public partial class frmAddItemUtility : BaseUI
    {


        private List<ItemEntity> GlobleAPIEntity; 
        private List<ItemEntity> GlobleSAE; 
        private List<ItemEntity> GlobleMeasureUnitDetails; 
        private List<ItemEntity> GlobleMeasureSizes;

        private List<ItemEntity> GloblelAPISelectedItem= new List<ItemEntity>();

        private ItemEntity objItemEntity;

        public frmAddItemUtility()
        {
            InitializeComponent();
            SetFormName();
        }

        private void frmAddItemUtility_Load(object sender, EventArgs e)
        {
            GetMeasureUnit();
            GetMeasureUnitDetails();
            GetAPI();
            GetSAE();
        }

        private void GetMeasureUnit()
        {
            Execute objExecute = new Execute();
            DataTable dt = (DataTable)objExecute.Executes("spGetMeasureUnit", ReturnType.DataTable, CommandType.StoredProcedure);

            cmbMeasureUnit.DataSource = dt;
            cmbMeasureUnit.DisplayMember = "vcMeasureUnit";
            cmbMeasureUnit.ValueMember = "intMeasureUnitID";
            cmbMeasureUnit.SelectedIndex = -1;
        }

        public void GetMeasureUnitDetails()
        {
            DataTable dt = new DataTable();
            List<ItemEntity> lstItemEntity = new List<ItemEntity>();
            try
            {
                Execute objExecute = new Execute();
                string Query = "[dbo].[spGetMeasureUnit]";
                SqlParameter[] para = new SqlParameter[]
                  {

                  };

                dt = (DataTable)objExecute.Executes(Query, ReturnType.DataTable, para, CommandType.StoredProcedure);


                foreach (DataRow dr in dt.Rows)
                {
                    ItemEntity objBrandEntity = new ItemEntity
                    {
                        intMeasureUnitID = Convert.ToInt32(dr["intMeasureUnitID"]),
                        vcMeasureUnit = dr["vcMeasureUnit"].ToString(),
                        vcMeasureUnitDesc = dr["vcMeasureUnitDesc"].ToString(),
                    };

                    lstItemEntity.Add(objBrandEntity);
                }

                dgvMeasureDetails.DataSource = null;
                dgvMeasureDetails.AutoGenerateColumns = false;
                dgvMeasureDetails.DataSource = lstItemEntity.ToList();

                GlobleMeasureUnitDetails = lstItemEntity;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void GetAPI()
        {
            DataTable dt = new DataTable();
            List<ItemEntity> lstItemEntity = new List<ItemEntity>();
            try
            {
                Execute objExecute = new Execute();
                string Query = "[dbo].[spGetAPI]";
                SqlParameter[] para = new SqlParameter[]
                  {

                  };

                dt = (DataTable)objExecute.Executes(Query, ReturnType.DataTable, para, CommandType.StoredProcedure);


                foreach (DataRow dr in dt.Rows)
                {
                    ItemEntity objBrandEntity = new ItemEntity
                    {
                        intAPIID = Convert.ToInt32(dr["intAPIID"]),
                        vcAPI = dr["vcAPI"].ToString(),

                    };

                    lstItemEntity.Add(objBrandEntity);
                }

                dgvAPI.DataSource = null;
                dgvAPI.AutoGenerateColumns = false;
                dgvAPI.DataSource = lstItemEntity.ToList();

                GlobleAPIEntity = lstItemEntity;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void GetSAE()
        {
            DataTable dt = new DataTable();
            List<ItemEntity> lstItemEntity = new List<ItemEntity>();
            try
            {
                Execute objExecute = new Execute();
                string Query = "[dbo].[spGetSAE]";
                SqlParameter[] para = new SqlParameter[]
                  {

                  };

                dt = (DataTable)objExecute.Executes(Query, ReturnType.DataTable, para, CommandType.StoredProcedure);


                foreach (DataRow dr in dt.Rows)
                {
                    ItemEntity objBrandEntity = new ItemEntity
                    {
                        intSAEID = Convert.ToInt32(dr["intSAEID"]),
                        vcSAE = dr["vcSAE"].ToString(),

                    };

                    lstItemEntity.Add(objBrandEntity);
                }

                dgvSAE.DataSource = null;
                dgvSAE.AutoGenerateColumns = false;
                dgvSAE.DataSource = lstItemEntity.ToList();

                GlobleSAE = lstItemEntity.ToList();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvAPI_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvAPI.Columns[e.ColumnIndex] == clmbtnUpdate)
            {
                int id = Convert.ToInt32(dgvAPI.Rows[dgvAPI.CurrentCell.RowIndex].Cells[clmAPIID.Name].Value);
            }
        }

        private void cmbMeasureUnit_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetMeasureSize();
        }

        public void GetMeasureSize()
        {
            DataTable dt = new DataTable();
            List<ItemEntity> lstItemEntity = new List<ItemEntity>();
            try
            {
                Execute objExecute = new Execute();
                string Query = "[dbo].[spGetPackingMethods]";
                SqlParameter[] para = new SqlParameter[]
                  {
                      Execute.AddParameter("@intMeasureUnitID",Convert.ToInt32(cmbMeasureUnit.SelectedValue)),
                  };

                dt = (DataTable)objExecute.Executes(Query, ReturnType.DataTable, para, CommandType.StoredProcedure);


                foreach (DataRow dr1 in dt.Rows)
                {
                    ItemEntity objMeasure = new ItemEntity
                    {
                        intPackingMethodID = Convert.ToInt32(dr1["intPackingMethodID"]),
                        decQty = Convert.ToInt32(dr1["decQty"]),
                        vcMeasureUnit = dr1["vcMeasureUnit"].ToString(),
                    };

                    lstItemEntity.Add(objMeasure);
                }

                dgvMeasureSize.DataSource = null;
                dgvMeasureSize.AutoGenerateColumns = false;
                dgvMeasureSize.DataSource = lstItemEntity.ToList();

                GlobleMeasureSizes = lstItemEntity;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSaveAPI_Click(object sender, EventArgs e)
        {
            if (GlobleAPIEntity == null)
            {
                GlobleAPIEntity = new List<ItemEntity>();
            }

            if (GlobleAPIEntity.Find(x => x.vcAPI == (txtAPI.Text.ToUpper())) != null)
            {
                MessageBox.Show("You can't Add Same API!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAPI.Text = string.Empty;
                txtAPI.Focus();
                return;
            }


            DialogResult dr = MessageBox.Show("Are You Sure Want to Add New API ?", "CONFIRM", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {

                Execute objExecute = new Execute();
                SqlParameter[] param = new SqlParameter[]
                   {
                    Execute.AddParameter("@vcSAE",txtSAE.Text.Trim().ToUpper()),
                   };

                int NoOfRowsEffected = objExecute.Executes("spSaveSAE", param, CommandType.StoredProcedure);

                if (NoOfRowsEffected < 0)
                {
                    MessageBox.Show("Save..");
                    txtSAE.Text = string.Empty;
                    GetAPI();
                }
                else
                {
                    MessageBox.Show("Cant't Save..");
                }
            }
        }

        private void btnSaveSAE_Click(object sender, EventArgs e)
        {

            if (GlobleSAE == null)
            {
                GlobleSAE = new List<ItemEntity>();
            }

            if (GlobleSAE.Find(x => x.vcSAE == (txtSAE.Text.ToUpper())) != null)
            {
                MessageBox.Show("You can't Add Same API!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSAE.Text = string.Empty;
                txtSAE.Focus();
                return;
            }


            DialogResult dr = MessageBox.Show("Are You Sure Want to Add New SAE ?", "CONFIRM", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {

                Execute objExecute = new Execute();
                SqlParameter[] param = new SqlParameter[]
                   {
                    Execute.AddParameter("@vcAPI",txtAPI.Text.Trim().ToUpper()),
                   };

                int NoOfRowsEffected = objExecute.Executes("spSaveAPI", param, CommandType.StoredProcedure);

                if (NoOfRowsEffected < 0)
                {
                    MessageBox.Show("Save..");
                    txtSAE.Text = string.Empty;
                    GetSAE();
                }
                else
                {
                    MessageBox.Show("Cant't Save..");
                }
            }
        }

        private void txtMeasureUnitSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnSaveUnitSize_Click(object sender, EventArgs e)
        {
            if (cmbMeasureUnit.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the Measure Unit!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txtMeasureUnitSize.Text == string.Empty)
            {
                MessageBox.Show("Please enter the unit size!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (GlobleMeasureSizes == null)
            {
                GlobleMeasureSizes = new List<ItemEntity>();
            }

            if (GlobleMeasureSizes.Find(x => x.decQty == Convert.ToInt32(txtMeasureUnitSize.Text.ToUpper())) != null)
            {
                MessageBox.Show("You can't Add Same Size!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMeasureUnitSize.Text = string.Empty;
                txtMeasureUnitSize.Focus();
                return;
            }

            DialogResult dr = MessageBox.Show("Are You Sure Want to Add New Unit Size?", "CONFIRM", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            decimal MeasureUnitSize = Convert.ToDecimal(txtMeasureUnitSize.Text.ToString());

            if (dr == DialogResult.Yes)
            {

                Execute objExecute = new Execute();
                SqlParameter[] param = new SqlParameter[]
                   {
                    Execute.AddParameter("@decQty",MeasureUnitSize),
                    Execute.AddParameter("@intMeasureUnitID",Convert.ToInt32(cmbMeasureUnit.SelectedValue)),
                   };

                int NoOfRowsEffected = objExecute.Executes("spSavePackingMethods", param, CommandType.StoredProcedure);

                if (NoOfRowsEffected < 0)
                {
                    MessageBox.Show("Save..");
                    txtMeasureUnitSize.Text = string.Empty;
                    GetMeasureSize();
                }
                else
                {
                    MessageBox.Show("Cant't Save..");
                }
            }
        }

        private void btnMeasureDecSave_Click(object sender, EventArgs e)
        {

            if (txtMeasureCode.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Measure Code!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txtMeasureDesc.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Measure Description!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (GlobleMeasureUnitDetails == null)
            {
                GlobleMeasureUnitDetails = new List<ItemEntity>();
            }

            if (GlobleMeasureUnitDetails.Find(x => x.vcMeasureUnit == (txtMeasureCode.Text.ToUpper())) != null)
            {
                MessageBox.Show("You can't Add Same API!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMeasureCode.Text = string.Empty;
                txtMeasureCode.Focus();
                return;
            }

            DialogResult dr = MessageBox.Show("Are You Sure Want to Add New Measure Unit ?", "CONFIRM", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {

                Execute objExecute = new Execute();
                SqlParameter[] param = new SqlParameter[]
                   {
                    Execute.AddParameter("@vcMeasureUnit",txtMeasureCode.Text.Trim().ToUpper()),
                    Execute.AddParameter("@vcMeasureUnitDesc",txtMeasureDesc.Text.Trim().ToUpper()),
                   };

                int NoOfRowsEffected = objExecute.Executes("spSaveMeasureUnit", param, CommandType.StoredProcedure);

                if (NoOfRowsEffected < 0)
                {
                    MessageBox.Show("Save..");
                    txtMeasureCode.Text = string.Empty;
                    txtMeasureDesc.Text = string.Empty;
                    GetMeasureUnitDetails();
                    GetMeasureUnit();
                }
                else
                {
                    MessageBox.Show("Cant't Save..");
                }
            }

        }
    }

}

