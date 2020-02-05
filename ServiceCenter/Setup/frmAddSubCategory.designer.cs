namespace ServiceCenter.Setup
{
    partial class frmAddSubCategory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMainCategory = new System.Windows.Forms.ComboBox();
            this.cmbBrand = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSubCategory = new System.Windows.Forms.TextBox();
            this.dgvAddSubCategory = new System.Windows.Forms.DataGridView();
            this.clmBatchID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBatchNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmbtnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddSubCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 19);
            this.label5.TabIndex = 130;
            this.label5.Text = "Main Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 37);
            this.label1.TabIndex = 128;
            this.label1.Text = "Add Sub Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 17);
            this.label2.TabIndex = 126;
            this.label2.Text = ":";
            // 
            // cmbMainCategory
            // 
            this.cmbMainCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMainCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMainCategory.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmbMainCategory.FormattingEnabled = true;
            this.cmbMainCategory.Location = new System.Drawing.Point(158, 99);
            this.cmbMainCategory.Name = "cmbMainCategory";
            this.cmbMainCategory.Size = new System.Drawing.Size(187, 25);
            this.cmbMainCategory.TabIndex = 131;
            // 
            // cmbBrand
            // 
            this.cmbBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBrand.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmbBrand.FormattingEnabled = true;
            this.cmbBrand.Location = new System.Drawing.Point(158, 137);
            this.cmbBrand.Name = "cmbBrand";
            this.cmbBrand.Size = new System.Drawing.Size(188, 25);
            this.cmbBrand.TabIndex = 134;
            this.cmbBrand.SelectionChangeCommitted += new System.EventHandler(this.cmbBrand_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 19);
            this.label3.TabIndex = 133;
            this.label3.Text = "Brand";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(134, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 17);
            this.label6.TabIndex = 132;
            this.label6.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(134, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 17);
            this.label7.TabIndex = 137;
            this.label7.Text = ":";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(21, 211);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 19);
            this.label10.TabIndex = 136;
            this.label10.Text = "Sub Category";
            // 
            // txtSubCategory
            // 
            this.txtSubCategory.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtSubCategory.Location = new System.Drawing.Point(156, 208);
            this.txtSubCategory.Name = "txtSubCategory";
            this.txtSubCategory.Size = new System.Drawing.Size(188, 25);
            this.txtSubCategory.TabIndex = 135;
            // 
            // dgvAddSubCategory
            // 
            this.dgvAddSubCategory.AllowUserToAddRows = false;
            this.dgvAddSubCategory.AllowUserToDeleteRows = false;
            this.dgvAddSubCategory.AllowUserToOrderColumns = true;
            this.dgvAddSubCategory.AllowUserToResizeRows = false;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAddSubCategory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvAddSubCategory.BackgroundColor = System.Drawing.Color.White;
            this.dgvAddSubCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAddSubCategory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAddSubCategory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(58)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAddSubCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dgvAddSubCategory.ColumnHeadersHeight = 35;
            this.dgvAddSubCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAddSubCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmBatchID,
            this.clmBatchNo,
            this.clmStartDate,
            this.clmbtnEdit});
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAddSubCategory.DefaultCellStyle = dataGridViewCellStyle26;
            this.dgvAddSubCategory.EnableHeadersVisualStyles = false;
            this.dgvAddSubCategory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvAddSubCategory.Location = new System.Drawing.Point(17, 287);
            this.dgvAddSubCategory.MultiSelect = false;
            this.dgvAddSubCategory.Name = "dgvAddSubCategory";
            this.dgvAddSubCategory.ReadOnly = true;
            this.dgvAddSubCategory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvAddSubCategory.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dgvAddSubCategory.RowHeadersVisible = false;
            this.dgvAddSubCategory.RowHeadersWidth = 15;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAddSubCategory.RowsDefaultCellStyle = dataGridViewCellStyle28;
            this.dgvAddSubCategory.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvAddSubCategory.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAddSubCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAddSubCategory.Size = new System.Drawing.Size(379, 295);
            this.dgvAddSubCategory.TabIndex = 138;
            // 
            // clmBatchID
            // 
            this.clmBatchID.DataPropertyName = "BatchID";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmBatchID.DefaultCellStyle = dataGridViewCellStyle24;
            this.clmBatchID.HeaderText = "BatchID";
            this.clmBatchID.Name = "clmBatchID";
            this.clmBatchID.ReadOnly = true;
            this.clmBatchID.Visible = false;
            this.clmBatchID.Width = 150;
            // 
            // clmBatchNo
            // 
            this.clmBatchNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmBatchNo.DataPropertyName = "BatchNo";
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmBatchNo.DefaultCellStyle = dataGridViewCellStyle25;
            this.clmBatchNo.HeaderText = "Batch No";
            this.clmBatchNo.Name = "clmBatchNo";
            this.clmBatchNo.ReadOnly = true;
            this.clmBatchNo.Width = 250;
            // 
            // clmStartDate
            // 
            this.clmStartDate.DataPropertyName = "StartDate";
            this.clmStartDate.HeaderText = "Start Date";
            this.clmStartDate.Name = "clmStartDate";
            this.clmStartDate.ReadOnly = true;
            this.clmStartDate.Width = 160;
            // 
            // clmbtnEdit
            // 
            this.clmbtnEdit.HeaderText = "Press to Edit";
            this.clmbtnEdit.Name = "clmbtnEdit";
            this.clmbtnEdit.ReadOnly = true;
            this.clmbtnEdit.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(170)))), ((int)(((byte)(231)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(110)))), ((int)(((byte)(185)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(317, 246);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(71, 35);
            this.btnSave.TabIndex = 141;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbUnit
            // 
            this.cmbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbUnit.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Location = new System.Drawing.Point(159, 173);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(134, 25);
            this.cmbUnit.TabIndex = 145;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 19);
            this.label9.TabIndex = 144;
            this.label9.Text = "Unit";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(134, 177);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(11, 17);
            this.label11.TabIndex = 143;
            this.label11.Text = ":";
            // 
            // frmAddSubCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 610);
            this.Controls.Add(this.cmbUnit);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvAddSubCategory);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtSubCategory);
            this.Controls.Add(this.cmbBrand);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbMainCategory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmAddSubCategory";
            this.Text = "Add Sub Category";
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.cmbMainCategory, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.cmbBrand, 0);
            this.Controls.SetChildIndex(this.txtSubCategory, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.dgvAddSubCategory, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.cmbUnit, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddSubCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMainCategory;
        private System.Windows.Forms.ComboBox cmbBrand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSubCategory;
        private System.Windows.Forms.DataGridView dgvAddSubCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBatchID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBatchNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStartDate;
        private System.Windows.Forms.DataGridViewButtonColumn clmbtnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
    }
}