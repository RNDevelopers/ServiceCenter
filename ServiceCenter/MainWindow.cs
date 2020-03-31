using ServiceCenter.Common;
using ServiceCenter.Customer;
using ServiceCenter.Return;
using ServiceCenter.Setup;
using ServiceCenter.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceCenter
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
           // this.SetFormName();
            //slidepline move
            slidePlane.Height = btnSetUp.Height;
            slidePlane.Top = btnSetUp.Top;

            this.IsMdiContainer = true;

        }

            bool flag = false;

        private void Form1_MouseDown(object sender, MouseEventArgs e)

        {

            flag = true;

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)

        {

            //Check if Flag is True ??? if so then make form position same

            //as Cursor position

            if (flag == true)

            {

                this.Location = Cursor.Position;

            }

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)

        {

            flag = false;

        }


        private void button1_Click(object sender, EventArgs e)
        {
           frmAddSupplier obj = new frmAddSupplier();
            obj.MdiParent = this;
            obj.Show(); 
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAddBrand obj = new frmAddBrand();
            obj.MdiParent = this;
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Setup button
            slidePlane.Height = btnSetUp.Height;
            slidePlane.Top = btnSetUp.Top;

            contextMenuStrip_Setup.Show(btnSetUp,btnSetUp.Right, btnSetUp.Left);
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            //Receive button

            slidePlane.Height = btnSetUp.Height;
            slidePlane.Top = btnReceive.Top;

            frmReceive obj = new frmReceive();
            obj.MdiParent = this;
            obj.Show();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            //return button danmama meka danna epa qa aru... passe demu qa meka ain karamu neda ???
            slidePlane.Height = btnReturn.Height;
            slidePlane.Top = btnReturn.Top;

            contextMenuStrip_Returt.Show(btnReturn, btnReturn.Right, btnSetUp.Left);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            //report button
            slidePlane.Height = btnSetUp.Height;
            slidePlane.Top = btnReport.Top;

            contextMenuStrip_Report.Show(btnReport, btnReturn.Right, btnSetUp.Left);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //logout button 
            slidePlane.Height = btnSetUp.Height;
            slidePlane.Top = btnLogout.Top;
        }

        private void addBrandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddBrand obj = new frmAddBrand();
            obj.MdiParent = this;
            obj.Show();
        }

        private void addCompanySupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddSupplier obj = new frmAddSupplier();
            obj.MdiParent = this;
            obj.Show();
        }

        private void addMainCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddMainCategory obj = new frmAddMainCategory();
            obj.MdiParent = this;
            obj.Show();
        }

        private void addSubCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddSubCategory obj = new frmAddSubCategory();
            obj.MdiParent = this;
            obj.Show();
        }

        private void btnIssues_Click(object sender, EventArgs e)
        {
            //issues button
            slidePlane.Height = btnSetUp.Height;
            slidePlane.Top = btnIssues.Top;

            frmIssues obj = new frmIssues();
            obj.MdiParent = this;
            obj.Show();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            ////add customer button
            slidePlane.Height = btnSetUp.Height;
            slidePlane.Top = btnCustomer.Top;

            string  vcName = null;
            string vcCar = null;
            frmAddCustomer obj = new frmAddCustomer(vcName, vcCar);
            obj.MdiParent = this;
            obj.Show();
        }

        private void addItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //add Item
            frmAddItem obj = new frmAddItem();
            obj.MdiParent = this;
            obj.Show();
        }

        private void mnuAssignSubCategoryBrand_Click(object sender, EventArgs e)
        {
            frmAssignSubCategoryBrand obj = new frmAssignSubCategoryBrand();
            obj.MdiParent = this;
            obj.Show();
        }

        private void mnuFromCustomer_Click(object sender, EventArgs e)
        {
            frmToCustomer obj = new frmToCustomer();
            obj.MdiParent = this;
            obj.Show();
        }

        private void mnuToSupplier_Click(object sender, EventArgs e)
        {
            frmToSupplier obj = new frmToSupplier();
            obj.MdiParent = this;
            obj.Show();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            slidePlane.Height = btnView.Height;
            slidePlane.Top = btnView.Top;

            contextMenuStrip_View.Show(btnView, btnView.Right, btnView.Left);
        }

        private void mnubtnReceivesView_Click(object sender, EventArgs e)
        {

        }

        private void mnubtnIssuesView_Click(object sender, EventArgs e)
        {

        }

        private void mnuAddItemUtility_Click(object sender, EventArgs e)
        {
            frmAddItemUtility obj = new frmAddItemUtility();
            obj.MdiParent = this;
            obj.Show();
        }

        private void mnuEditItem_Click(object sender, EventArgs e)
        {
            frmViewItem obj = new frmViewItem();
            obj.MdiParent = this;
            obj.Show();
        }

        private void mnuServiceCharges_Click(object sender, EventArgs e)
        {
            frmAddServiceCharge obj = new frmAddServiceCharge();
            obj.MdiParent = this;
            obj.Show();
        }

        private void mnuGoodsView_Click(object sender, EventArgs e)
        {
            frmGoodsDetails obj = new frmGoodsDetails();
            obj.MdiParent = this;
            obj.Show();
        }
    }
}
