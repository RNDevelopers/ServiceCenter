﻿using ServiceCenter.Common;
using ServiceCenter.DBConnection;
using ServiceCenter.Enums;
using System;
using System.Data;

namespace ServiceCenter.Setup
{
    public partial class frmAddSubCategory : BaseUI
    {
        public frmAddSubCategory()
        {
            InitializeComponent();
            this.SetFormName();
            GetCompany();
            GetMainCategory();
            GetBrand();
            GetItemUnit();

            //from Ramod
        }

        public void GetCompany()
        {
            Execute objExecute = new Execute();
            DataTable dt = (DataTable)objExecute.Executes("spGetAllCompany", ReturnType.DataTable, CommandType.StoredProcedure);

            cmbCompanyName.DataSource = dt;
            cmbCompanyName.DisplayMember = "vcCompanyName";
            cmbCompanyName.ValueMember = "intCompanyID";
            cmbCompanyName.SelectedIndex = -1;
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

        public void GetBrand()
        {
            Execute objExecute = new Execute();
            DataTable dt = (DataTable)objExecute.Executes("spGetBrand", ReturnType.DataTable, CommandType.StoredProcedure);

            cmbBrand.DataSource = dt;
            cmbBrand.DisplayMember = "vcName";
            cmbBrand.ValueMember = "intBrandID";
            cmbBrand.SelectedIndex = -1;
        }

        public void GetItemUnit()
        {
            Execute objExecute = new Execute();
            DataTable dt = (DataTable)objExecute.Executes("spGetItemUnit", ReturnType.DataTable, CommandType.StoredProcedure);

            cmbUnit.DataSource = dt;
            cmbUnit.DisplayMember = "vcUnitDesc";
            cmbUnit.ValueMember = "intUnitID";
            cmbUnit.SelectedIndex = -1;
        }

        private void cmbBrand_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtSubCategory.Text = (cmbBrand.Text.ToString() + ' ' + '-' + ' ');
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
