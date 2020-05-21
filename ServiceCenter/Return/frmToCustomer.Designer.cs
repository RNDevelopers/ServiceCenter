namespace ServiceCenter.Return
{
    partial class frmToCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmToCustomer));
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvReturnItem = new System.Windows.Forms.DataGridView();
            this.clmSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmIssueDetailID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vcItemDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmvcUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIssuedQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAleadyReturnedQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDiscountedUnitValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAvailableQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmReturnQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIsAleadyReturned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotVal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.cmbInvoiceNo = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnItem)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(99, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 17);
            this.label9.TabIndex = 138;
            this.label9.Text = ":";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(15, 99);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 19);
            this.label12.TabIndex = 137;
            this.label12.Text = "Invoice No.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 37);
            this.label1.TabIndex = 182;
            this.label1.Text = "Return From Customer";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Teal;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(110)))), ((int)(((byte)(185)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(310, 97);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(82, 25);
            this.btnSearch.TabIndex = 215;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvReturnItem
            // 
            this.dgvReturnItem.AllowUserToAddRows = false;
            this.dgvReturnItem.AllowUserToDeleteRows = false;
            this.dgvReturnItem.AllowUserToOrderColumns = true;
            this.dgvReturnItem.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvReturnItem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReturnItem.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvReturnItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(58)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReturnItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReturnItem.ColumnHeadersHeight = 35;
            this.dgvReturnItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvReturnItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmSelect,
            this.clmIssueDetailID,
            this.clmItemID,
            this.clmItemCode,
            this.vcItemDescription,
            this.clmvcUnit,
            this.clmIssuedQty,
            this.clmAleadyReturnedQty,
            this.clmUnitPrice,
            this.clmDiscountedUnitValue,
            this.clmAvailableQty,
            this.clmReturnQty,
            this.clmIsAleadyReturned,
            this.clmTotVal});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReturnItem.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvReturnItem.EnableHeadersVisualStyles = false;
            this.dgvReturnItem.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvReturnItem.Location = new System.Drawing.Point(12, 142);
            this.dgvReturnItem.MultiSelect = false;
            this.dgvReturnItem.Name = "dgvReturnItem";
            this.dgvReturnItem.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvReturnItem.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvReturnItem.RowHeadersVisible = false;
            this.dgvReturnItem.RowHeadersWidth = 15;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvReturnItem.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvReturnItem.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvReturnItem.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvReturnItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReturnItem.Size = new System.Drawing.Size(955, 248);
            this.dgvReturnItem.TabIndex = 216;
            this.dgvReturnItem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReturnItem_CellClick);
            this.dgvReturnItem.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReturnItem_CellEndEdit);
            this.dgvReturnItem.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvReturnItem_DataBindingComplete);
            this.dgvReturnItem.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvReturnItem_EditingControlShowing);
            this.dgvReturnItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvReturnItem_KeyPress);
            // 
            // clmSelect
            // 
            this.clmSelect.HeaderText = "Select";
            this.clmSelect.Name = "clmSelect";
            this.clmSelect.Width = 40;
            // 
            // clmIssueDetailID
            // 
            this.clmIssueDetailID.DataPropertyName = "intIssueDetailID";
            this.clmIssueDetailID.HeaderText = "Issue Detail ID";
            this.clmIssueDetailID.Name = "clmIssueDetailID";
            this.clmIssueDetailID.Visible = false;
            // 
            // clmItemID
            // 
            this.clmItemID.DataPropertyName = "intItemID";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmItemID.DefaultCellStyle = dataGridViewCellStyle3;
            this.clmItemID.HeaderText = "Item ID";
            this.clmItemID.Name = "clmItemID";
            this.clmItemID.ReadOnly = true;
            this.clmItemID.Visible = false;
            this.clmItemID.Width = 5;
            // 
            // clmItemCode
            // 
            this.clmItemCode.DataPropertyName = "vcItemCode";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmItemCode.DefaultCellStyle = dataGridViewCellStyle4;
            this.clmItemCode.HeaderText = "Item Code";
            this.clmItemCode.Name = "clmItemCode";
            this.clmItemCode.ReadOnly = true;
            this.clmItemCode.Width = 120;
            // 
            // vcItemDescription
            // 
            this.vcItemDescription.DataPropertyName = "vcItemDescription";
            this.vcItemDescription.HeaderText = "Item Description";
            this.vcItemDescription.Name = "vcItemDescription";
            this.vcItemDescription.ReadOnly = true;
            this.vcItemDescription.Width = 300;
            // 
            // clmvcUnit
            // 
            this.clmvcUnit.DataPropertyName = "vcUnit";
            this.clmvcUnit.HeaderText = "Unit Size";
            this.clmvcUnit.Name = "clmvcUnit";
            this.clmvcUnit.Width = 70;
            // 
            // clmIssuedQty
            // 
            this.clmIssuedQty.DataPropertyName = "IssuedQty";
            this.clmIssuedQty.HeaderText = "Issued Qty";
            this.clmIssuedQty.Name = "clmIssuedQty";
            this.clmIssuedQty.ReadOnly = true;
            this.clmIssuedQty.Width = 70;
            // 
            // clmAleadyReturnedQty
            // 
            this.clmAleadyReturnedQty.DataPropertyName = "AleadyReturnedQty";
            this.clmAleadyReturnedQty.HeaderText = "Aleady Returned Qty";
            this.clmAleadyReturnedQty.Name = "clmAleadyReturnedQty";
            this.clmAleadyReturnedQty.ReadOnly = true;
            this.clmAleadyReturnedQty.Width = 80;
            // 
            // clmUnitPrice
            // 
            this.clmUnitPrice.DataPropertyName = "decUnitPrice";
            this.clmUnitPrice.HeaderText = "Unit Price";
            this.clmUnitPrice.Name = "clmUnitPrice";
            this.clmUnitPrice.ReadOnly = true;
            this.clmUnitPrice.Width = 80;
            // 
            // clmDiscountedUnitValue
            // 
            this.clmDiscountedUnitValue.DataPropertyName = "decDiscountedUnitValue";
            this.clmDiscountedUnitValue.HeaderText = "Discounted Price";
            this.clmDiscountedUnitValue.Name = "clmDiscountedUnitValue";
            this.clmDiscountedUnitValue.ReadOnly = true;
            this.clmDiscountedUnitValue.Width = 80;
            // 
            // clmAvailableQty
            // 
            this.clmAvailableQty.DataPropertyName = "decStockInHand";
            this.clmAvailableQty.HeaderText = "Available Qty";
            this.clmAvailableQty.Name = "clmAvailableQty";
            this.clmAvailableQty.Width = 55;
            // 
            // clmReturnQty
            // 
            this.clmReturnQty.DataPropertyName = "decReturnQty";
            this.clmReturnQty.HeaderText = "Return Qty";
            this.clmReturnQty.Name = "clmReturnQty";
            this.clmReturnQty.Width = 70;
            // 
            // clmIsAleadyReturned
            // 
            this.clmIsAleadyReturned.DataPropertyName = "IsAleadyReturned";
            this.clmIsAleadyReturned.HeaderText = "IsAleadyReturned";
            this.clmIsAleadyReturned.Name = "clmIsAleadyReturned";
            this.clmIsAleadyReturned.Visible = false;
            // 
            // clmTotVal
            // 
            this.clmTotVal.HeaderText = "TotVal";
            this.clmTotVal.Name = "clmTotVal";
            this.clmTotVal.Visible = false;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.OliveDrab;
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(110)))), ((int)(((byte)(185)))));
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Image = ((System.Drawing.Image)(resources.GetObject("btnReturn.Image")));
            this.btnReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturn.Location = new System.Drawing.Point(842, 399);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(120, 55);
            this.btnReturn.TabIndex = 218;
            this.btnReturn.Text = "       Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.IndianRed;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(110)))), ((int)(((byte)(185)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(710, 398);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 55);
            this.btnClear.TabIndex = 217;
            this.btnClear.Text = "      Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // cmbInvoiceNo
            // 
            this.cmbInvoiceNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbInvoiceNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbInvoiceNo.FormattingEnabled = true;
            this.cmbInvoiceNo.Location = new System.Drawing.Point(116, 99);
            this.cmbInvoiceNo.MaxLength = 40;
            this.cmbInvoiceNo.Name = "cmbInvoiceNo";
            this.cmbInvoiceNo.Size = new System.Drawing.Size(188, 21);
            this.cmbInvoiceNo.TabIndex = 253;
            this.cmbInvoiceNo.SelectionChangeCommitted += new System.EventHandler(this.cmbInvoiceNo_SelectionChangeCommitted);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(45, 423);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(118, 15);
            this.label17.TabIndex = 255;
            this.label17.Text = "Already Return Items";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightPink;
            this.panel2.Location = new System.Drawing.Point(19, 420);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(20, 20);
            this.panel2.TabIndex = 254;
            // 
            // frmToCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(67)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(979, 466);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cmbInvoiceNo);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dgvReturnItem);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label12);
            this.Name = "frmToCustomer";
            this.Text = "Return From Customer";
            this.Load += new System.EventHandler(this.frmToCustomer_Load);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btnSearch, 0);
            this.Controls.SetChildIndex(this.dgvReturnItem, 0);
            this.Controls.SetChildIndex(this.btnClear, 0);
            this.Controls.SetChildIndex(this.btnReturn, 0);
            this.Controls.SetChildIndex(this.cmbInvoiceNo, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.label17, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvReturnItem;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cmbInvoiceNo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIssueDetailID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn vcItemDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmvcUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIssuedQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAleadyReturnedQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDiscountedUnitValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAvailableQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmReturnQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIsAleadyReturned;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotVal;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel2;
    }
}