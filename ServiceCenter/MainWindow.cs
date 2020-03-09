using ServiceCenter.Common;
using ServiceCenter.Customer;
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

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            //Receive button
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

            frmIssues obj = new frmIssues();
            obj.MdiParent = this;
            obj.Show();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            //add customer button
            frmAddCustomer obj = new frmAddCustomer();
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

    }
}
