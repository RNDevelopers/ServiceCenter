using ServiceCenter.Common;
using ServiceCenter.Setup;
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
    public partial class MainWindow : BaseUI
    {
        public MainWindow()
        {
            InitializeComponent();
            this.SetFormName();
            //slidepline move
            slidePlane.Height = btnSetUp.Height;
            slidePlane.Top = btnSetUp.Top;

        }

        private void button1_Click(object sender, EventArgs e)
        {
           frmAddCompany obj = new frmAddCompany();
           obj.Show();           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAddBrand obj = new frmAddBrand();
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Setup button
            slidePlane.Height = btnSetUp.Height;
            slidePlane.Top = btnSetUp.Top;

            contextMenuStrip_Setup.Show(btnSetUp,btnSetUp.Right, btnSetUp.Left);
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            //Receive button
            frmReceive obj = new frmReceive();
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
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //logout button 
            slidePlane.Height = btnSetUp.Height;
            slidePlane.Top = btnLogout.Top;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void addBrandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddBrand obj = new frmAddBrand();
            obj.Show();
        }

        private void addCompanySupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddCompany obj = new frmAddCompany();
            obj.Show();
        }

        private void addMainCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddMainCategory obj = new frmAddMainCategory();
            obj.Show();
        }

        private void addSubCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddSubCategory obj = new frmAddSubCategory();
            obj.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnIssues_Click(object sender, EventArgs e)
        {
            //issues button
            slidePlane.Height = btnSetUp.Height;
            slidePlane.Top = btnIssues.Top;
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            //add customer button
            frmCustomerRegister obj = new frmCustomerRegister();
            obj.Show();
        }

        private void addItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //add Item
            frmAddItem obj = new frmAddItem();
            obj.Show();
        }
    }
}
