namespace ServiceCenter
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnView = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnIssues = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.slidePlane = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnReceive = new System.Windows.Forms.Button();
            this.btnSetUp = new System.Windows.Forms.Button();
            this.contextMenuStrip_Setup = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addCompanySupplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMainCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSubCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAssignSubCategoryBrand = new System.Windows.Forms.ToolStripMenuItem();
            this.addBrandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddItemUtility = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuServiceCharges = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip_Returt = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuFromCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuToSupplier = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip_Customer = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip_View = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnubtnReceivesView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnubtnIssuesView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnustockView = new System.Windows.Forms.ToolStripMenuItem();
            this.customersViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerReturnViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip_Report = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuGoodsView = new System.Windows.Forms.ToolStripMenuItem();
            this.issuesViewReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip_Setup.SuspendLayout();
            this.contextMenuStrip_Returt.SuspendLayout();
            this.panel2.SuspendLayout();
            this.contextMenuStrip_Customer.SuspendLayout();
            this.contextMenuStrip_View.SuspendLayout();
            this.contextMenuStrip_Report.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnView);
            this.panel1.Controls.Add(this.btnCustomer);
            this.panel1.Controls.Add(this.btnIssues);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.slidePlane);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnReport);
            this.panel1.Controls.Add(this.btnReturn);
            this.panel1.Controls.Add(this.btnReceive);
            this.panel1.Controls.Add(this.btnSetUp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 750);
            this.panel1.TabIndex = 154;
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnView.FlatAppearance.BorderSize = 0;
            this.btnView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(110)))), ((int)(((byte)(185)))));
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.Color.White;
            this.btnView.Image = global::ServiceCenter.Properties.Resources.report_30px;
            this.btnView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnView.Location = new System.Drawing.Point(9, 376);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(154, 56);
            this.btnView.TabIndex = 159;
            this.btnView.Text = "     View";
            this.btnView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomer.FlatAppearance.BorderSize = 0;
            this.btnCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(110)))), ((int)(((byte)(185)))));
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.White;
            this.btnCustomer.Image = global::ServiceCenter.Properties.Resources.user_24px;
            this.btnCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.Location = new System.Drawing.Point(10, 138);
            this.btnCustomer.Margin = new System.Windows.Forms.Padding(0);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(154, 56);
            this.btnCustomer.TabIndex = 158;
            this.btnCustomer.Text = "     Customer";
            this.btnCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnIssues
            // 
            this.btnIssues.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnIssues.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIssues.FlatAppearance.BorderSize = 0;
            this.btnIssues.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(110)))), ((int)(((byte)(185)))));
            this.btnIssues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssues.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssues.ForeColor = System.Drawing.Color.White;
            this.btnIssues.Image = global::ServiceCenter.Properties.Resources.upload_24px;
            this.btnIssues.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIssues.Location = new System.Drawing.Point(10, 258);
            this.btnIssues.Name = "btnIssues";
            this.btnIssues.Size = new System.Drawing.Size(154, 56);
            this.btnIssues.TabIndex = 157;
            this.btnIssues.Text = "      Issues";
            this.btnIssues.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIssues.UseVisualStyleBackColor = false;
            this.btnIssues.Click += new System.EventHandler(this.btnIssues_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ServiceCenter.Properties.Resources.fiat_500_100px;
            this.pictureBox1.Location = new System.Drawing.Point(20, -6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.pictureBox1.Size = new System.Drawing.Size(124, 78);
            this.pictureBox1.TabIndex = 156;
            this.pictureBox1.TabStop = false;
            // 
            // slidePlane
            // 
            this.slidePlane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.slidePlane.Location = new System.Drawing.Point(3, 78);
            this.slidePlane.Margin = new System.Windows.Forms.Padding(2);
            this.slidePlane.Name = "slidePlane";
            this.slidePlane.Size = new System.Drawing.Size(8, 56);
            this.slidePlane.TabIndex = 155;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(110)))), ((int)(((byte)(185)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = global::ServiceCenter.Properties.Resources.rounded_up_24px;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(10, 513);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(154, 56);
            this.btnLogout.TabIndex = 156;
            this.btnLogout.Text = "     Log out";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Visible = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(110)))), ((int)(((byte)(185)))));
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Image = global::ServiceCenter.Properties.Resources.report_30px;
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(10, 445);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(154, 56);
            this.btnReport.TabIndex = 155;
            this.btnReport.Text = "     Report";
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(110)))), ((int)(((byte)(185)))));
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Image = global::ServiceCenter.Properties.Resources.undo_30px;
            this.btnReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturn.Location = new System.Drawing.Point(10, 318);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(154, 56);
            this.btnReturn.TabIndex = 151;
            this.btnReturn.Text = "     Return";
            this.btnReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnReceive
            // 
            this.btnReceive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReceive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReceive.FlatAppearance.BorderSize = 0;
            this.btnReceive.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(110)))), ((int)(((byte)(185)))));
            this.btnReceive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceive.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceive.ForeColor = System.Drawing.Color.White;
            this.btnReceive.Image = global::ServiceCenter.Properties.Resources.download_24px;
            this.btnReceive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReceive.Location = new System.Drawing.Point(10, 198);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(154, 56);
            this.btnReceive.TabIndex = 150;
            this.btnReceive.Text = "     Receive";
            this.btnReceive.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReceive.UseVisualStyleBackColor = false;
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);
            // 
            // btnSetUp
            // 
            this.btnSetUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSetUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetUp.FlatAppearance.BorderSize = 0;
            this.btnSetUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSetUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(110)))), ((int)(((byte)(185)))));
            this.btnSetUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetUp.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetUp.ForeColor = System.Drawing.Color.White;
            this.btnSetUp.Image = global::ServiceCenter.Properties.Resources.plus_math_30px;
            this.btnSetUp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetUp.Location = new System.Drawing.Point(10, 78);
            this.btnSetUp.Name = "btnSetUp";
            this.btnSetUp.Size = new System.Drawing.Size(154, 56);
            this.btnSetUp.TabIndex = 149;
            this.btnSetUp.Text = "     Set Up";
            this.btnSetUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetUp.UseVisualStyleBackColor = true;
            this.btnSetUp.Click += new System.EventHandler(this.button3_Click);
            // 
            // contextMenuStrip_Setup
            // 
            this.contextMenuStrip_Setup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.contextMenuStrip_Setup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.contextMenuStrip_Setup.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip_Setup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCompanySupplierToolStripMenuItem,
            this.addMainCategoryToolStripMenuItem,
            this.addSubCategoryToolStripMenuItem,
            this.mnuAssignSubCategoryBrand,
            this.addBrandToolStripMenuItem,
            this.addItemsToolStripMenuItem,
            this.mnuAddItemUtility,
            this.mnuEditItem,
            this.mnuServiceCharges});
            this.contextMenuStrip_Setup.Name = "contextMenuStrip_Setup";
            this.contextMenuStrip_Setup.ShowImageMargin = false;
            this.contextMenuStrip_Setup.Size = new System.Drawing.Size(201, 202);
            // 
            // addCompanySupplierToolStripMenuItem
            // 
            this.addCompanySupplierToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.addCompanySupplierToolStripMenuItem.Name = "addCompanySupplierToolStripMenuItem";
            this.addCompanySupplierToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.addCompanySupplierToolStripMenuItem.Text = "Add Supplier";
            this.addCompanySupplierToolStripMenuItem.Click += new System.EventHandler(this.addCompanySupplierToolStripMenuItem_Click);
            // 
            // addMainCategoryToolStripMenuItem
            // 
            this.addMainCategoryToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.addMainCategoryToolStripMenuItem.Name = "addMainCategoryToolStripMenuItem";
            this.addMainCategoryToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.addMainCategoryToolStripMenuItem.Text = "Add Main Category";
            this.addMainCategoryToolStripMenuItem.Click += new System.EventHandler(this.addMainCategoryToolStripMenuItem_Click);
            // 
            // addSubCategoryToolStripMenuItem
            // 
            this.addSubCategoryToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addSubCategoryToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.addSubCategoryToolStripMenuItem.Name = "addSubCategoryToolStripMenuItem";
            this.addSubCategoryToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.addSubCategoryToolStripMenuItem.Text = "Add Sub Category";
            this.addSubCategoryToolStripMenuItem.Click += new System.EventHandler(this.addSubCategoryToolStripMenuItem_Click);
            // 
            // mnuAssignSubCategoryBrand
            // 
            this.mnuAssignSubCategoryBrand.ForeColor = System.Drawing.Color.White;
            this.mnuAssignSubCategoryBrand.Name = "mnuAssignSubCategoryBrand";
            this.mnuAssignSubCategoryBrand.Size = new System.Drawing.Size(200, 22);
            this.mnuAssignSubCategoryBrand.Text = "Assign Sub Category Brand ";
            this.mnuAssignSubCategoryBrand.Click += new System.EventHandler(this.mnuAssignSubCategoryBrand_Click);
            // 
            // addBrandToolStripMenuItem
            // 
            this.addBrandToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.addBrandToolStripMenuItem.Name = "addBrandToolStripMenuItem";
            this.addBrandToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.addBrandToolStripMenuItem.Text = "Add Brand";
            this.addBrandToolStripMenuItem.Click += new System.EventHandler(this.addBrandToolStripMenuItem_Click);
            // 
            // addItemsToolStripMenuItem
            // 
            this.addItemsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.addItemsToolStripMenuItem.Name = "addItemsToolStripMenuItem";
            this.addItemsToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.addItemsToolStripMenuItem.Text = "Add Items";
            this.addItemsToolStripMenuItem.Click += new System.EventHandler(this.addItemsToolStripMenuItem_Click);
            // 
            // mnuAddItemUtility
            // 
            this.mnuAddItemUtility.ForeColor = System.Drawing.Color.White;
            this.mnuAddItemUtility.Name = "mnuAddItemUtility";
            this.mnuAddItemUtility.Size = new System.Drawing.Size(200, 22);
            this.mnuAddItemUtility.Text = "Add Item Utility";
            this.mnuAddItemUtility.Click += new System.EventHandler(this.mnuAddItemUtility_Click);
            // 
            // mnuEditItem
            // 
            this.mnuEditItem.ForeColor = System.Drawing.Color.White;
            this.mnuEditItem.Name = "mnuEditItem";
            this.mnuEditItem.Size = new System.Drawing.Size(200, 22);
            this.mnuEditItem.Text = "Edit Item";
            this.mnuEditItem.Click += new System.EventHandler(this.mnuEditItem_Click);
            // 
            // mnuServiceCharges
            // 
            this.mnuServiceCharges.ForeColor = System.Drawing.Color.White;
            this.mnuServiceCharges.Name = "mnuServiceCharges";
            this.mnuServiceCharges.Size = new System.Drawing.Size(200, 22);
            this.mnuServiceCharges.Text = "Add Service Charges";
            this.mnuServiceCharges.Click += new System.EventHandler(this.mnuServiceCharges_Click);
            // 
            // contextMenuStrip_Returt
            // 
            this.contextMenuStrip_Returt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.contextMenuStrip_Returt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.contextMenuStrip_Returt.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip_Returt.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFromCustomer,
            this.mnuToSupplier});
            this.contextMenuStrip_Returt.Name = "contextMenuStrip_Returt";
            this.contextMenuStrip_Returt.ShowImageMargin = false;
            this.contextMenuStrip_Returt.Size = new System.Drawing.Size(136, 48);
            // 
            // mnuFromCustomer
            // 
            this.mnuFromCustomer.ForeColor = System.Drawing.Color.White;
            this.mnuFromCustomer.Name = "mnuFromCustomer";
            this.mnuFromCustomer.Size = new System.Drawing.Size(135, 22);
            this.mnuFromCustomer.Text = "From Customer";
            this.mnuFromCustomer.Click += new System.EventHandler(this.mnuFromCustomer_Click);
            // 
            // mnuToSupplier
            // 
            this.mnuToSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mnuToSupplier.ForeColor = System.Drawing.Color.White;
            this.mnuToSupplier.Name = "mnuToSupplier";
            this.mnuToSupplier.Size = new System.Drawing.Size(135, 22);
            this.mnuToSupplier.Text = "To Supplier";
            this.mnuToSupplier.Click += new System.EventHandler(this.mnuToSupplier_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(166, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1184, 55);
            this.panel2.TabIndex = 155;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(4, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 46);
            this.label1.TabIndex = 156;
            this.label1.Text = "Nihal Auto Car Max";
            // 
            // contextMenuStrip_Customer
            // 
            this.contextMenuStrip_Customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.contextMenuStrip_Customer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.contextMenuStrip_Customer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCustomerToolStripMenuItem});
            this.contextMenuStrip_Customer.Name = "contextMenuStrip_Customer";
            this.contextMenuStrip_Customer.ShowImageMargin = false;
            this.contextMenuStrip_Customer.Size = new System.Drawing.Size(129, 26);
            // 
            // addCustomerToolStripMenuItem
            // 
            this.addCustomerToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.addCustomerToolStripMenuItem.Name = "addCustomerToolStripMenuItem";
            this.addCustomerToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.addCustomerToolStripMenuItem.Text = "Add Customer";
            // 
            // contextMenuStrip_View
            // 
            this.contextMenuStrip_View.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.contextMenuStrip_View.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.contextMenuStrip_View.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnubtnReceivesView,
            this.mnubtnIssuesView,
            this.mnustockView,
            this.customersViewToolStripMenuItem,
            this.customerReturnViewToolStripMenuItem});
            this.contextMenuStrip_View.Name = "contextMenuStrip_View";
            this.contextMenuStrip_View.ShowImageMargin = false;
            this.contextMenuStrip_View.Size = new System.Drawing.Size(190, 114);
            // 
            // mnubtnReceivesView
            // 
            this.mnubtnReceivesView.ForeColor = System.Drawing.Color.White;
            this.mnubtnReceivesView.Name = "mnubtnReceivesView";
            this.mnubtnReceivesView.Size = new System.Drawing.Size(189, 22);
            this.mnubtnReceivesView.Text = "Receives View";
            this.mnubtnReceivesView.Click += new System.EventHandler(this.mnubtnReceivesView_Click);
            // 
            // mnubtnIssuesView
            // 
            this.mnubtnIssuesView.ForeColor = System.Drawing.Color.White;
            this.mnubtnIssuesView.Name = "mnubtnIssuesView";
            this.mnubtnIssuesView.Size = new System.Drawing.Size(189, 22);
            this.mnubtnIssuesView.Text = "Issues View";
            this.mnubtnIssuesView.Click += new System.EventHandler(this.mnubtnIssuesView_Click);
            // 
            // mnustockView
            // 
            this.mnustockView.ForeColor = System.Drawing.Color.White;
            this.mnustockView.Name = "mnustockView";
            this.mnustockView.Size = new System.Drawing.Size(189, 22);
            this.mnustockView.Text = "Stock View";
            this.mnustockView.Click += new System.EventHandler(this.mnustockView_Click);
            // 
            // customersViewToolStripMenuItem
            // 
            this.customersViewToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.customersViewToolStripMenuItem.Name = "customersViewToolStripMenuItem";
            this.customersViewToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.customersViewToolStripMenuItem.Text = "Customers View";
            this.customersViewToolStripMenuItem.Click += new System.EventHandler(this.customersViewToolStripMenuItem_Click);
            // 
            // customerReturnViewToolStripMenuItem
            // 
            this.customerReturnViewToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.customerReturnViewToolStripMenuItem.Name = "customerReturnViewToolStripMenuItem";
            this.customerReturnViewToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.customerReturnViewToolStripMenuItem.Text = "Customer Return View(*)";
            this.customerReturnViewToolStripMenuItem.Visible = false;
            this.customerReturnViewToolStripMenuItem.Click += new System.EventHandler(this.customerReturnViewToolStripMenuItem_Click);
            // 
            // contextMenuStrip_Report
            // 
            this.contextMenuStrip_Report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.contextMenuStrip_Report.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGoodsView,
            this.issuesViewReportToolStripMenuItem});
            this.contextMenuStrip_Report.Name = "contextMenuStrip_Report";
            this.contextMenuStrip_Report.ShowImageMargin = false;
            this.contextMenuStrip_Report.Size = new System.Drawing.Size(150, 48);
            // 
            // mnuGoodsView
            // 
            this.mnuGoodsView.ForeColor = System.Drawing.Color.White;
            this.mnuGoodsView.Name = "mnuGoodsView";
            this.mnuGoodsView.Size = new System.Drawing.Size(149, 22);
            this.mnuGoodsView.Text = "Goods View Report";
            this.mnuGoodsView.Click += new System.EventHandler(this.mnuGoodsView_Click);
            // 
            // issuesViewReportToolStripMenuItem
            // 
            this.issuesViewReportToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.issuesViewReportToolStripMenuItem.Name = "issuesViewReportToolStripMenuItem";
            this.issuesViewReportToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.issuesViewReportToolStripMenuItem.Text = "Issues View Report ";
            this.issuesViewReportToolStripMenuItem.Click += new System.EventHandler(this.issuesViewReportToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1350, 750);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainWindow";
            this.Text = "Nihal Auto Car Wax";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip_Setup.ResumeLayout(false);
            this.contextMenuStrip_Returt.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.contextMenuStrip_Customer.ResumeLayout(false);
            this.contextMenuStrip_View.ResumeLayout(false);
            this.contextMenuStrip_Report.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSetUp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnReceive;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel slidePlane;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_Setup;
        private System.Windows.Forms.ToolStripMenuItem addCompanySupplierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMainCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSubCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBrandToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_Returt;
        private System.Windows.Forms.ToolStripMenuItem mnuFromCustomer;
        private System.Windows.Forms.ToolStripMenuItem mnuToSupplier;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnIssues;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.ToolStripMenuItem addItemsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_Customer;
        private System.Windows.Forms.ToolStripMenuItem addCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAssignSubCategoryBrand;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_View;
        private System.Windows.Forms.ToolStripMenuItem mnubtnReceivesView;
        private System.Windows.Forms.ToolStripMenuItem mnubtnIssuesView;
        private System.Windows.Forms.ToolStripMenuItem mnuAddItemUtility;
        private System.Windows.Forms.ToolStripMenuItem mnuEditItem;
        private System.Windows.Forms.ToolStripMenuItem mnuServiceCharges;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_Report;
        private System.Windows.Forms.ToolStripMenuItem mnuGoodsView;
        private System.Windows.Forms.ToolStripMenuItem mnustockView;
        private System.Windows.Forms.ToolStripMenuItem customersViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issuesViewReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerReturnViewToolStripMenuItem;
    }
}

