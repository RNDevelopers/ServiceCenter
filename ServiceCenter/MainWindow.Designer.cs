﻿namespace ServiceCenter
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
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.addBrandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip_Returt = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fromCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toSupplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip_Setup.SuspendLayout();
            this.contextMenuStrip_Returt.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
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
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 733);
            this.panel1.TabIndex = 154;
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
            this.btnCustomer.Location = new System.Drawing.Point(13, 170);
            this.btnCustomer.Margin = new System.Windows.Forms.Padding(0);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(205, 69);
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
            this.btnIssues.Location = new System.Drawing.Point(13, 318);
            this.btnIssues.Margin = new System.Windows.Forms.Padding(4);
            this.btnIssues.Name = "btnIssues";
            this.btnIssues.Size = new System.Drawing.Size(205, 69);
            this.btnIssues.TabIndex = 157;
            this.btnIssues.Text = "      Issues";
            this.btnIssues.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIssues.UseVisualStyleBackColor = false;
            this.btnIssues.Click += new System.EventHandler(this.btnIssues_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ServiceCenter.Properties.Resources.fiat_500_100px;
            this.pictureBox1.Location = new System.Drawing.Point(26, -8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.pictureBox1.Size = new System.Drawing.Size(165, 96);
            this.pictureBox1.TabIndex = 156;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // slidePlane
            // 
            this.slidePlane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.slidePlane.Location = new System.Drawing.Point(4, 96);
            this.slidePlane.Name = "slidePlane";
            this.slidePlane.Size = new System.Drawing.Size(10, 69);
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
            this.btnLogout.Location = new System.Drawing.Point(13, 550);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(205, 69);
            this.btnLogout.TabIndex = 156;
            this.btnLogout.Text = "     Log out";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = false;
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
            this.btnReport.Location = new System.Drawing.Point(13, 471);
            this.btnReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(205, 69);
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
            this.btnReturn.Location = new System.Drawing.Point(13, 392);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(205, 69);
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
            this.btnReceive.Location = new System.Drawing.Point(13, 244);
            this.btnReceive.Margin = new System.Windows.Forms.Padding(4);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(205, 69);
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
            this.btnSetUp.Location = new System.Drawing.Point(13, 96);
            this.btnSetUp.Margin = new System.Windows.Forms.Padding(4);
            this.btnSetUp.Name = "btnSetUp";
            this.btnSetUp.Size = new System.Drawing.Size(205, 69);
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
            this.addBrandToolStripMenuItem,
            this.addItemsToolStripMenuItem});
            this.contextMenuStrip_Setup.Name = "contextMenuStrip_Setup";
            this.contextMenuStrip_Setup.Size = new System.Drawing.Size(239, 124);
            this.contextMenuStrip_Setup.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // addCompanySupplierToolStripMenuItem
            // 
            this.addCompanySupplierToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.addCompanySupplierToolStripMenuItem.Name = "addCompanySupplierToolStripMenuItem";
            this.addCompanySupplierToolStripMenuItem.Size = new System.Drawing.Size(238, 24);
            this.addCompanySupplierToolStripMenuItem.Text = "Add Company Supplier";
            this.addCompanySupplierToolStripMenuItem.Click += new System.EventHandler(this.addCompanySupplierToolStripMenuItem_Click);
            // 
            // addMainCategoryToolStripMenuItem
            // 
            this.addMainCategoryToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.addMainCategoryToolStripMenuItem.Name = "addMainCategoryToolStripMenuItem";
            this.addMainCategoryToolStripMenuItem.Size = new System.Drawing.Size(238, 24);
            this.addMainCategoryToolStripMenuItem.Text = "Add Main Category";
            this.addMainCategoryToolStripMenuItem.Click += new System.EventHandler(this.addMainCategoryToolStripMenuItem_Click);
            // 
            // addSubCategoryToolStripMenuItem
            // 
            this.addSubCategoryToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addSubCategoryToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.addSubCategoryToolStripMenuItem.Name = "addSubCategoryToolStripMenuItem";
            this.addSubCategoryToolStripMenuItem.Size = new System.Drawing.Size(238, 24);
            this.addSubCategoryToolStripMenuItem.Text = "Add Sub Category";
            this.addSubCategoryToolStripMenuItem.Click += new System.EventHandler(this.addSubCategoryToolStripMenuItem_Click);
            // 
            // addBrandToolStripMenuItem
            // 
            this.addBrandToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.addBrandToolStripMenuItem.Name = "addBrandToolStripMenuItem";
            this.addBrandToolStripMenuItem.Size = new System.Drawing.Size(238, 24);
            this.addBrandToolStripMenuItem.Text = "Add Brand";
            this.addBrandToolStripMenuItem.Click += new System.EventHandler(this.addBrandToolStripMenuItem_Click);
            // 
            // addItemsToolStripMenuItem
            // 
            this.addItemsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.addItemsToolStripMenuItem.Name = "addItemsToolStripMenuItem";
            this.addItemsToolStripMenuItem.Size = new System.Drawing.Size(238, 24);
            this.addItemsToolStripMenuItem.Text = "Add Items";
            this.addItemsToolStripMenuItem.Click += new System.EventHandler(this.addItemsToolStripMenuItem_Click);
            // 
            // contextMenuStrip_Returt
            // 
            this.contextMenuStrip_Returt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.contextMenuStrip_Returt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.contextMenuStrip_Returt.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip_Returt.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fromCustomerToolStripMenuItem,
            this.toSupplierToolStripMenuItem});
            this.contextMenuStrip_Returt.Name = "contextMenuStrip_Returt";
            this.contextMenuStrip_Returt.Size = new System.Drawing.Size(188, 52);
            // 
            // fromCustomerToolStripMenuItem
            // 
            this.fromCustomerToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fromCustomerToolStripMenuItem.Name = "fromCustomerToolStripMenuItem";
            this.fromCustomerToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.fromCustomerToolStripMenuItem.Text = "From Customer";
            // 
            // toSupplierToolStripMenuItem
            // 
            this.toSupplierToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toSupplierToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.toSupplierToolStripMenuItem.Name = "toSupplierToolStripMenuItem";
            this.toSupplierToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.toSupplierToolStripMenuItem.Text = "To Supplier";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(222, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(950, 88);
            this.panel2.TabIndex = 155;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(548, 59);
            this.label1.TabIndex = 156;
            this.label1.Text = "Nihal Car Service and Wax";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1172, 765);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip_Setup.ResumeLayout(false);
            this.contextMenuStrip_Returt.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem fromCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toSupplierToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnIssues;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.ToolStripMenuItem addItemsToolStripMenuItem;
    }
}

