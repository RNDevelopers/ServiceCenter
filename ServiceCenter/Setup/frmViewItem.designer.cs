namespace ServiceCenter.Setup
{
    partial class frmViewItem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvViewItemList = new System.Windows.Forms.DataGridView();
            this.txtDecSearch = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clmItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vcItemDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmvcUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEngineType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmdecUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.decStockInHand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmbtnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmbtnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewItemList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvViewItemList
            // 
            this.dgvViewItemList.AllowUserToAddRows = false;
            this.dgvViewItemList.AllowUserToDeleteRows = false;
            this.dgvViewItemList.AllowUserToOrderColumns = true;
            this.dgvViewItemList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvViewItemList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvViewItemList.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvViewItemList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(58)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvViewItemList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvViewItemList.ColumnHeadersHeight = 35;
            this.dgvViewItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvViewItemList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmItemID,
            this.clmItemCode,
            this.vcItemDescription,
            this.clmvcUnit,
            this.clmEngineType,
            this.clmdecUnitPrice,
            this.decStockInHand,
            this.clmbtnEdit,
            this.clmbtnDelete});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvViewItemList.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvViewItemList.EnableHeadersVisualStyles = false;
            this.dgvViewItemList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvViewItemList.Location = new System.Drawing.Point(16, 107);
            this.dgvViewItemList.MultiSelect = false;
            this.dgvViewItemList.Name = "dgvViewItemList";
            this.dgvViewItemList.ReadOnly = true;
            this.dgvViewItemList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvViewItemList.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvViewItemList.RowHeadersVisible = false;
            this.dgvViewItemList.RowHeadersWidth = 15;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvViewItemList.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvViewItemList.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvViewItemList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvViewItemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvViewItemList.Size = new System.Drawing.Size(902, 357);
            this.dgvViewItemList.TabIndex = 223;
            this.dgvViewItemList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViewItemList_CellClick);
            // 
            // txtDecSearch
            // 
            this.txtDecSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtDecSearch.Location = new System.Drawing.Point(500, 76);
            this.txtDecSearch.MaxLength = 4;
            this.txtDecSearch.Name = "txtDecSearch";
            this.txtDecSearch.Size = new System.Drawing.Size(418, 25);
            this.txtDecSearch.TabIndex = 222;
            this.txtDecSearch.TextChanged += new System.EventHandler(this.txtDecSearch_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(344, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(166, 19);
            this.label13.TabIndex = 221;
            this.label13.Text = "Search Item Description :";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtSearch.Location = new System.Drawing.Point(135, 77);
            this.txtSearch.MaxLength = 4;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(203, 25);
            this.txtSearch.TabIndex = 220;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 19);
            this.label3.TabIndex = 219;
            this.label3.Text = "Search Item Code :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 37);
            this.label1.TabIndex = 224;
            this.label1.Text = "View Items";
            // 
            // clmItemID
            // 
            this.clmItemID.DataPropertyName = "intItemID";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmItemID.DefaultCellStyle = dataGridViewCellStyle3;
            this.clmItemID.HeaderText = "Item ID";
            this.clmItemID.MinimumWidth = 3;
            this.clmItemID.Name = "clmItemID";
            this.clmItemID.ReadOnly = true;
            this.clmItemID.Visible = false;
            this.clmItemID.Width = 3;
            // 
            // clmItemCode
            // 
            this.clmItemCode.DataPropertyName = "vcItemCode";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmItemCode.DefaultCellStyle = dataGridViewCellStyle4;
            this.clmItemCode.HeaderText = "Item Code";
            this.clmItemCode.Name = "clmItemCode";
            this.clmItemCode.ReadOnly = true;
            this.clmItemCode.Width = 135;
            // 
            // vcItemDescription
            // 
            this.vcItemDescription.DataPropertyName = "vcItemDescription";
            this.vcItemDescription.HeaderText = "Item Description";
            this.vcItemDescription.Name = "vcItemDescription";
            this.vcItemDescription.ReadOnly = true;
            this.vcItemDescription.Width = 350;
            // 
            // clmvcUnit
            // 
            this.clmvcUnit.DataPropertyName = "vcUnit";
            this.clmvcUnit.HeaderText = "Unit";
            this.clmvcUnit.Name = "clmvcUnit";
            this.clmvcUnit.ReadOnly = true;
            this.clmvcUnit.Width = 50;
            // 
            // clmEngineType
            // 
            this.clmEngineType.DataPropertyName = "vcEngineType";
            this.clmEngineType.HeaderText = "Engine Type";
            this.clmEngineType.Name = "clmEngineType";
            this.clmEngineType.ReadOnly = true;
            // 
            // clmdecUnitPrice
            // 
            this.clmdecUnitPrice.DataPropertyName = "decUnitPrice";
            this.clmdecUnitPrice.HeaderText = "Price";
            this.clmdecUnitPrice.Name = "clmdecUnitPrice";
            this.clmdecUnitPrice.ReadOnly = true;
            this.clmdecUnitPrice.Width = 85;
            // 
            // decStockInHand
            // 
            this.decStockInHand.DataPropertyName = "decStockInHand";
            this.decStockInHand.HeaderText = "Balance Stock ";
            this.decStockInHand.Name = "decStockInHand";
            this.decStockInHand.ReadOnly = true;
            this.decStockInHand.Width = 50;
            // 
            // clmbtnEdit
            // 
            this.clmbtnEdit.HeaderText = "Edit";
            this.clmbtnEdit.Name = "clmbtnEdit";
            this.clmbtnEdit.ReadOnly = true;
            this.clmbtnEdit.Text = "";
            this.clmbtnEdit.Width = 75;
            // 
            // clmbtnDelete
            // 
            this.clmbtnDelete.HeaderText = "Delete";
            this.clmbtnDelete.Name = "clmbtnDelete";
            this.clmbtnDelete.ReadOnly = true;
            this.clmbtnDelete.Text = "";
            this.clmbtnDelete.Width = 45;
            // 
            // frmViewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(67)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(930, 481);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvViewItemList);
            this.Controls.Add(this.txtDecSearch);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label3);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmViewItem";
            this.Text = "frmViewItem";
            this.Load += new System.EventHandler(this.frmViewItem_Load);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtSearch, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.txtDecSearch, 0);
            this.Controls.SetChildIndex(this.dgvViewItemList, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewItemList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvViewItemList;
        private System.Windows.Forms.TextBox txtDecSearch;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn vcItemDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmvcUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEngineType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmdecUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn decStockInHand;
        private System.Windows.Forms.DataGridViewButtonColumn clmbtnEdit;
        private System.Windows.Forms.DataGridViewButtonColumn clmbtnDelete;
    }
}