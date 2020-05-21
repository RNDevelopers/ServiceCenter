namespace ServiceCenter.Views
{
    partial class frmReceivesView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvReceivesView = new System.Windows.Forms.DataGridView();
            this.clmItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vcItemDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmvcUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGRNQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDiscountedUnitValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbGRNNo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblSupName = new System.Windows.Forms.Label();
            this.lblGRNDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceivesView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(282, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 19);
            this.label1.TabIndex = 205;
            this.label1.Text = "To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(312, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 17);
            this.label2.TabIndex = 204;
            this.label2.Text = ":";
            // 
            // dtTo
            // 
            this.dtTo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTo.Location = new System.Drawing.Point(329, 104);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(173, 25);
            this.dtTo.TabIndex = 203;
            this.dtTo.CloseUp += new System.EventHandler(this.dtTo_CloseUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(11, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 19);
            this.label5.TabIndex = 202;
            this.label5.Text = "From";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(73, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 17);
            this.label7.TabIndex = 201;
            this.label7.Text = ":";
            // 
            // dtFrom
            // 
            this.dtFrom.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFrom.Location = new System.Drawing.Point(92, 104);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(173, 25);
            this.dtFrom.TabIndex = 200;
            this.dtFrom.CloseUp += new System.EventHandler(this.dtFrom_CloseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 45);
            this.label3.TabIndex = 248;
            this.label3.Text = "Receives View";
            // 
            // dgvReceivesView
            // 
            this.dgvReceivesView.AllowUserToAddRows = false;
            this.dgvReceivesView.AllowUserToDeleteRows = false;
            this.dgvReceivesView.AllowUserToOrderColumns = true;
            this.dgvReceivesView.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvReceivesView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvReceivesView.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvReceivesView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(58)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReceivesView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvReceivesView.ColumnHeadersHeight = 35;
            this.dgvReceivesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvReceivesView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmItemCode,
            this.vcItemDescription,
            this.clmBrand,
            this.clmvcUnit,
            this.clmGRNQty,
            this.clmUnitPrice,
            this.clmDiscountedUnitValue,
            this.clmTotalPrice});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReceivesView.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvReceivesView.EnableHeadersVisualStyles = false;
            this.dgvReceivesView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvReceivesView.Location = new System.Drawing.Point(13, 240);
            this.dgvReceivesView.MultiSelect = false;
            this.dgvReceivesView.Name = "dgvReceivesView";
            this.dgvReceivesView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvReceivesView.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvReceivesView.RowHeadersVisible = false;
            this.dgvReceivesView.RowHeadersWidth = 15;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvReceivesView.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvReceivesView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvReceivesView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvReceivesView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReceivesView.Size = new System.Drawing.Size(923, 353);
            this.dgvReceivesView.TabIndex = 250;
            // 
            // clmItemCode
            // 
            this.clmItemCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmItemCode.DataPropertyName = "vcItemCode";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmItemCode.DefaultCellStyle = dataGridViewCellStyle9;
            this.clmItemCode.HeaderText = "Item Code";
            this.clmItemCode.Name = "clmItemCode";
            this.clmItemCode.ReadOnly = true;
            // 
            // vcItemDescription
            // 
            this.vcItemDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.vcItemDescription.DataPropertyName = "vcItemDescription";
            this.vcItemDescription.HeaderText = "Item Description";
            this.vcItemDescription.Name = "vcItemDescription";
            this.vcItemDescription.ReadOnly = true;
            // 
            // clmBrand
            // 
            this.clmBrand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmBrand.DataPropertyName = "vcBrand";
            this.clmBrand.HeaderText = "Brand";
            this.clmBrand.Name = "clmBrand";
            // 
            // clmvcUnit
            // 
            this.clmvcUnit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmvcUnit.DataPropertyName = "vcUnit";
            this.clmvcUnit.HeaderText = "Unit Size";
            this.clmvcUnit.Name = "clmvcUnit";
            // 
            // clmGRNQty
            // 
            this.clmGRNQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmGRNQty.DataPropertyName = "GRNQty";
            this.clmGRNQty.HeaderText = "GRN Qty";
            this.clmGRNQty.Name = "clmGRNQty";
            this.clmGRNQty.ReadOnly = true;
            // 
            // clmUnitPrice
            // 
            this.clmUnitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmUnitPrice.DataPropertyName = "decUnitPrice";
            this.clmUnitPrice.HeaderText = "Unit Price";
            this.clmUnitPrice.Name = "clmUnitPrice";
            this.clmUnitPrice.ReadOnly = true;
            // 
            // clmDiscountedUnitValue
            // 
            this.clmDiscountedUnitValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmDiscountedUnitValue.DataPropertyName = "Discount";
            this.clmDiscountedUnitValue.HeaderText = "Discount";
            this.clmDiscountedUnitValue.Name = "clmDiscountedUnitValue";
            this.clmDiscountedUnitValue.ReadOnly = true;
            // 
            // clmTotalPrice
            // 
            this.clmTotalPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmTotalPrice.DataPropertyName = "TotalPrice";
            this.clmTotalPrice.HeaderText = "Total Price";
            this.clmTotalPrice.Name = "clmTotalPrice";
            // 
            // cmbGRNNo
            // 
            this.cmbGRNNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGRNNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbGRNNo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmbGRNNo.FormattingEnabled = true;
            this.cmbGRNNo.Location = new System.Drawing.Point(92, 156);
            this.cmbGRNNo.Name = "cmbGRNNo";
            this.cmbGRNNo.Size = new System.Drawing.Size(173, 25);
            this.cmbGRNNo.TabIndex = 253;
            this.cmbGRNNo.SelectionChangeCommitted += new System.EventHandler(this.cmbGRNNo_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(7, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 252;
            this.label4.Text = "GRN No.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(72, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 17);
            this.label6.TabIndex = 251;
            this.label6.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(282, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 19);
            this.label8.TabIndex = 255;
            this.label8.Text = "Supplier ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(347, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 17);
            this.label9.TabIndex = 254;
            this.label9.Text = ":";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(8, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 19);
            this.label10.TabIndex = 257;
            this.label10.Text = "GRN Date ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(73, 204);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(11, 17);
            this.label11.TabIndex = 256;
            this.label11.Text = ":";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(76, 204);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(11, 17);
            this.label12.TabIndex = 258;
            this.label12.Text = ":";
            // 
            // lblSupName
            // 
            this.lblSupName.AutoSize = true;
            this.lblSupName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupName.ForeColor = System.Drawing.Color.White;
            this.lblSupName.Location = new System.Drawing.Point(363, 160);
            this.lblSupName.Name = "lblSupName";
            this.lblSupName.Size = new System.Drawing.Size(0, 19);
            this.lblSupName.TabIndex = 259;
            // 
            // lblGRNDate
            // 
            this.lblGRNDate.AutoSize = true;
            this.lblGRNDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGRNDate.ForeColor = System.Drawing.Color.White;
            this.lblGRNDate.Location = new System.Drawing.Point(90, 202);
            this.lblGRNDate.Name = "lblGRNDate";
            this.lblGRNDate.Size = new System.Drawing.Size(0, 19);
            this.lblGRNDate.TabIndex = 260;
            // 
            // frmReceivesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(67)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(948, 605);
            this.Controls.Add(this.dgvReceivesView);
            this.Controls.Add(this.lblGRNDate);
            this.Controls.Add(this.lblSupName);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbGRNNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtTo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtFrom);
            this.Name = "frmReceivesView";
            this.Text = "Receives View ";
            this.Controls.SetChildIndex(this.dtFrom, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.dtTo, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.cmbGRNNo, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.lblSupName, 0);
            this.Controls.SetChildIndex(this.lblGRNDate, 0);
            this.Controls.SetChildIndex(this.dgvReceivesView, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceivesView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvReceivesView;
        private System.Windows.Forms.ComboBox cmbGRNNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn vcItemDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmvcUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGRNQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDiscountedUnitValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotalPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblSupName;
        private System.Windows.Forms.Label lblGRNDate;
    }
}