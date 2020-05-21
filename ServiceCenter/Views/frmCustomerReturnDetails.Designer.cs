namespace ServiceCenter.Views
{
    partial class frmCustomerReturnDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtFromDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtToDate = new System.Windows.Forms.DateTimePicker();
            this.cmbReturnNo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvReturnItem = new System.Windows.Forms.DataGridView();
            this.clmIssueDetailID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vcItemDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmvcUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIssuedQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDiscountedUnitValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAvailableQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmReturnQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnItem)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(10, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 19);
            this.label5.TabIndex = 190;
            this.label5.Text = "From";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(72, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 17);
            this.label7.TabIndex = 189;
            this.label7.Text = ":";
            // 
            // dtFromDate
            // 
            this.dtFromDate.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFromDate.Location = new System.Drawing.Point(91, 47);
            this.dtFromDate.Name = "dtFromDate";
            this.dtFromDate.Size = new System.Drawing.Size(173, 25);
            this.dtFromDate.TabIndex = 188;
            this.dtFromDate.CloseUp += new System.EventHandler(this.dtFromDate_CloseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(281, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 19);
            this.label1.TabIndex = 193;
            this.label1.Text = "To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(311, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 17);
            this.label2.TabIndex = 192;
            this.label2.Text = ":";
            // 
            // dtToDate
            // 
            this.dtToDate.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtToDate.Location = new System.Drawing.Point(328, 47);
            this.dtToDate.Name = "dtToDate";
            this.dtToDate.Size = new System.Drawing.Size(173, 25);
            this.dtToDate.TabIndex = 191;
            this.dtToDate.CloseUp += new System.EventHandler(this.dtToDate_CloseUp);
            // 
            // cmbReturnNo
            // 
            this.cmbReturnNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReturnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbReturnNo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmbReturnNo.FormattingEnabled = true;
            this.cmbReturnNo.Location = new System.Drawing.Point(91, 96);
            this.cmbReturnNo.Name = "cmbReturnNo";
            this.cmbReturnNo.Size = new System.Drawing.Size(173, 25);
            this.cmbReturnNo.TabIndex = 196;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 19);
            this.label3.TabIndex = 195;
            this.label3.Text = "Return No.";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(71, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 17);
            this.label4.TabIndex = 194;
            this.label4.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(6, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 19);
            this.label6.TabIndex = 197;
            this.label6.Text = "Vehicle No.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(4, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 19);
            this.label8.TabIndex = 198;
            this.label8.Text = "Customer Name ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(5, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 19);
            this.label9.TabIndex = 199;
            this.label9.Text = "Contact No.";
            // 
            // dgvReturnItem
            // 
            this.dgvReturnItem.AllowUserToAddRows = false;
            this.dgvReturnItem.AllowUserToDeleteRows = false;
            this.dgvReturnItem.AllowUserToOrderColumns = true;
            this.dgvReturnItem.AllowUserToResizeRows = false;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvReturnItem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvReturnItem.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvReturnItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(58)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReturnItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvReturnItem.ColumnHeadersHeight = 35;
            this.dgvReturnItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvReturnItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIssueDetailID,
            this.clmItemID,
            this.clmItemCode,
            this.vcItemDescription,
            this.clmvcUnit,
            this.clmIssuedQty,
            this.clmUnitPrice,
            this.clmDiscountedUnitValue,
            this.clmAvailableQty,
            this.clmReturnQty});
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReturnItem.DefaultCellStyle = dataGridViewCellStyle19;
            this.dgvReturnItem.EnableHeadersVisualStyles = false;
            this.dgvReturnItem.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvReturnItem.Location = new System.Drawing.Point(8, 253);
            this.dgvReturnItem.MultiSelect = false;
            this.dgvReturnItem.Name = "dgvReturnItem";
            this.dgvReturnItem.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvReturnItem.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvReturnItem.RowHeadersVisible = false;
            this.dgvReturnItem.RowHeadersWidth = 15;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvReturnItem.RowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvReturnItem.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvReturnItem.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvReturnItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReturnItem.Size = new System.Drawing.Size(881, 248);
            this.dgvReturnItem.TabIndex = 217;
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
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmItemID.DefaultCellStyle = dataGridViewCellStyle17;
            this.clmItemID.HeaderText = "Item ID";
            this.clmItemID.Name = "clmItemID";
            this.clmItemID.ReadOnly = true;
            this.clmItemID.Visible = false;
            this.clmItemID.Width = 5;
            // 
            // clmItemCode
            // 
            this.clmItemCode.DataPropertyName = "vcItemCode";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmItemCode.DefaultCellStyle = dataGridViewCellStyle18;
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
            // frmCustomerReturnDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(67)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(901, 517);
            this.Controls.Add(this.dgvReturnItem);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbReturnNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtToDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtFromDate);
            this.Name = "frmCustomerReturnDetails";
            this.Text = "Customer Return Details";
            this.Controls.SetChildIndex(this.dtFromDate, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.dtToDate, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.cmbReturnNo, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.dgvReturnItem, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtFromDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtToDate;
        private System.Windows.Forms.ComboBox cmbReturnNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvReturnItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIssueDetailID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn vcItemDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmvcUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIssuedQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDiscountedUnitValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAvailableQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmReturnQty;
    }
}