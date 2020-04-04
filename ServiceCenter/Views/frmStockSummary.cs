using CrystalDecisions.CrystalReports.Engine;
using ServiceCenter.Common;
using ServiceCenter.DBConnection;
using ServiceCenter.Entities;
using ServiceCenter.Enums;
using ServiceCenter.ErrorLog;
using ServiceCenter.Report;
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

namespace ServiceCenter.Views
{
    public partial class frmStockSummary : BaseUI
    {

        private BrandEntity objBrandEntity;
        private List<ItemEntity> GlobalList;

        public frmStockSummary()
        {
            InitializeComponent();
            SetFormName();

            GetBrand();
        }


        private void btnPrint_Click(object sender, EventArgs e)
        {
            Report();
        }


        private void Report()
        {
            rptStockSummary rpt = new rptStockSummary();
            ReportDocument rptDoc = new ReportDocument();

            rptDoc = rpt;

            Execute objExecute = new Execute();
            string Query = "[dbo].[spGetStockSummeryDetails]";
            SqlParameter[] para = new SqlParameter[]
              {
                      Execute.AddParameter("@intBrandID",Convert.ToInt32(cmbBrand.SelectedValue)),
              };
            DataTable dt = (DataTable)objExecute.Executes(Query, ReturnType.DataTable, para, CommandType.StoredProcedure);

            rpt.SetDataSource(dt);

            frmReportViewer objfrmReportViewer = new frmReportViewer(rptDoc);
            objfrmReportViewer.Show();

        }

        public void GetStockSummeryDetails()
        {
            try
            {
                Execute objExecute = new Execute();
                string Query = "[dbo].[spGetStockSummeryDetails]";
                SqlParameter[] para = new SqlParameter[]
                  {
                      Execute.AddParameter("@intBrandID",Convert.ToInt32(cmbBrand.SelectedValue)),
                  };
                DataTable dt = (DataTable)objExecute.Executes(Query, ReturnType.DataTable, para, CommandType.StoredProcedure);

                ItemEntity objItemEntity;
                List<ItemEntity> lstGetItemAdd = new List<ItemEntity>();


                foreach (DataRow dr in dt.Rows)
                {
                    objItemEntity = new ItemEntity
                    {
                        intItemID = (int)dr["intItemID"],
                        vcItemCode = dr["vcItemCode"].ToString(),
                        vcItemDescription = dr["vcItemDescription"].ToString(),
                        vcEngineType = dr["vcEngineType"].ToString(),
                        decStockInHand = (decimal)dr["decStockInHand"],
                        vcSubCategoryName = dr["vcSubCategoryName"].ToString(),
                        vcUnit = dr["vcUnit"].ToString(),
                        decUnitPrice = (decimal)dr["decUnitPrice"],

                        decDiscountedUnitValue = (decimal)dr["decUnitPriceDiscounted"],
                    };

                    lstGetItemAdd.Add(objItemEntity);
                }

                dgvAddItem.DataSource = null;
                dgvAddItem.AutoGenerateColumns = false;
                dgvAddItem.DataSource = lstGetItemAdd;

                GlobalList = lstGetItemAdd.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data Loading Error");
                Logger.LoggError(ex, "GetAllItemIssueAdd");
            }

        }

        private void GetBrand()
        {

            List<BrandEntity> lstBrand = new List<BrandEntity>();

            Execute objExecute = new Execute();
            DataTable dt = (DataTable)objExecute.Executes("spGetBrand", ReturnType.DataTable, CommandType.StoredProcedure);

            objBrandEntity = new BrandEntity
            {
                intBrandID = 0,
                vcName = "--All Brand--"

            };

            lstBrand.Add(objBrandEntity);

            foreach (DataRow dr in dt.Rows)
            {
                objBrandEntity = new BrandEntity
                {
                    intBrandID = Convert.ToInt32(dr["intBrandID"]),
                    vcName = dr["vcName"].ToString()
                };
                lstBrand.Add(objBrandEntity);
            }

            cmbBrand.DataSource = lstBrand;
            cmbBrand.DisplayMember = "vcName";
            cmbBrand.ValueMember = "intBrandID";
            cmbBrand.SelectedIndex = 0;
        }

        private void frmStockSummary_Load(object sender, EventArgs e)
        {
            GetStockSummeryDetails();
        }

        private void cmbBrand_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetStockSummeryDetails();
        }

        private void txtCodeSearch_TextChanged(object sender, EventArgs e)
        {
            dgvAddItem.DataSource = GlobalList.FindAll(x => x.vcItemCode.Trim().ToLower().Contains(txtCodeSearch.Text.Trim().ToLower()));
        }

        private void txtDecSearch_TextChanged(object sender, EventArgs e)
        {
            dgvAddItem.DataSource = GlobalList.FindAll(x => x.vcItemDescription.Trim().ToLower().Contains(txtDecSearch.Text.Trim().ToLower()));
        }

        private void txtCodeSearch_Click(object sender, EventArgs e)
        {
            txtDecSearch.Text = string.Empty;
        }

        private void txtDecSearch_Click(object sender, EventArgs e)
        {
            txtCodeSearch.Text = string.Empty;
        }
    }
}
