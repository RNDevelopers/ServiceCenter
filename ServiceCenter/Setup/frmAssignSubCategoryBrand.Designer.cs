namespace ServiceCenter.Setup
{
    partial class frmAssignSubCategoryBrand
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
            this.cmbSubCat = new System.Windows.Forms.ComboBox();
            this.cmbBrand = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSubcat = new System.Windows.Forms.Label();
            this.btnAssign = new System.Windows.Forms.Button();
            this.dgvSubCat = new System.Windows.Forms.DataGridView();
            this.clmSubCatDetailsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSubCatID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBrandID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSubCatName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubCat)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSubCat
            // 
            this.cmbSubCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSubCat.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmbSubCat.FormattingEnabled = true;
            this.cmbSubCat.Location = new System.Drawing.Point(160, 85);
            this.cmbSubCat.Name = "cmbSubCat";
            this.cmbSubCat.Size = new System.Drawing.Size(188, 25);
            this.cmbSubCat.TabIndex = 167;
            // 
            // cmbBrand
            // 
            this.cmbBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBrand.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmbBrand.FormattingEnabled = true;
            this.cmbBrand.Location = new System.Drawing.Point(160, 47);
            this.cmbBrand.Name = "cmbBrand";
            this.cmbBrand.Size = new System.Drawing.Size(188, 25);
            this.cmbBrand.TabIndex = 166;
            this.cmbBrand.SelectionChangeCommitted += new System.EventHandler(this.cmbBrand_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 19);
            this.label3.TabIndex = 165;
            this.label3.Text = "Brand";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(136, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 17);
            this.label6.TabIndex = 164;
            this.label6.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(136, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 17);
            this.label7.TabIndex = 163;
            this.label7.Text = ":";
            // 
            // lblSubcat
            // 
            this.lblSubcat.AutoSize = true;
            this.lblSubcat.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubcat.ForeColor = System.Drawing.Color.White;
            this.lblSubcat.Location = new System.Drawing.Point(23, 90);
            this.lblSubcat.Name = "lblSubcat";
            this.lblSubcat.Size = new System.Drawing.Size(94, 19);
            this.lblSubcat.TabIndex = 162;
            this.lblSubcat.Text = "Sub Category";
            // 
            // btnAssign
            // 
            this.btnAssign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAssign.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAssign.FlatAppearance.BorderSize = 0;
            this.btnAssign.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(110)))), ((int)(((byte)(185)))));
            this.btnAssign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssign.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssign.ForeColor = System.Drawing.Color.White;
            this.btnAssign.Location = new System.Drawing.Point(268, 127);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(80, 32);
            this.btnAssign.TabIndex = 168;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = false;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // dgvSubCat
            // 
            this.dgvSubCat.AllowUserToAddRows = false;
            this.dgvSubCat.AllowUserToDeleteRows = false;
            this.dgvSubCat.AllowUserToOrderColumns = true;
            this.dgvSubCat.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSubCat.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSubCat.BackgroundColor = System.Drawing.Color.White;
            this.dgvSubCat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSubCat.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSubCat.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(58)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSubCat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSubCat.ColumnHeadersHeight = 35;
            this.dgvSubCat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSubCat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmSubCatDetailsID,
            this.clmSubCatID,
            this.clmBrandID,
            this.clmSubCatName});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSubCat.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSubCat.EnableHeadersVisualStyles = false;
            this.dgvSubCat.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvSubCat.Location = new System.Drawing.Point(13, 165);
            this.dgvSubCat.MultiSelect = false;
            this.dgvSubCat.Name = "dgvSubCat";
            this.dgvSubCat.ReadOnly = true;
            this.dgvSubCat.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvSubCat.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSubCat.RowHeadersVisible = false;
            this.dgvSubCat.RowHeadersWidth = 15;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSubCat.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvSubCat.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvSubCat.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSubCat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubCat.Size = new System.Drawing.Size(340, 269);
            this.dgvSubCat.TabIndex = 169;
            // 
            // clmSubCatDetailsID
            // 
            this.clmSubCatDetailsID.DataPropertyName = "intSubCatDetailsID";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmSubCatDetailsID.DefaultCellStyle = dataGridViewCellStyle3;
            this.clmSubCatDetailsID.HeaderText = "SubCatDetailsID";
            this.clmSubCatDetailsID.Name = "clmSubCatDetailsID";
            this.clmSubCatDetailsID.ReadOnly = true;
            this.clmSubCatDetailsID.Visible = false;
            this.clmSubCatDetailsID.Width = 150;
            // 
            // clmSubCatID
            // 
            this.clmSubCatID.DataPropertyName = "intSubCatID";
            this.clmSubCatID.HeaderText = "SubCatID";
            this.clmSubCatID.Name = "clmSubCatID";
            this.clmSubCatID.ReadOnly = true;
            this.clmSubCatID.Visible = false;
            // 
            // clmBrandID
            // 
            this.clmBrandID.DataPropertyName = "intBrandID";
            this.clmBrandID.HeaderText = "BrandID";
            this.clmBrandID.Name = "clmBrandID";
            this.clmBrandID.ReadOnly = true;
            this.clmBrandID.Visible = false;
            // 
            // clmSubCatName
            // 
            this.clmSubCatName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmSubCatName.DataPropertyName = "vcSubCategoryName";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmSubCatName.DefaultCellStyle = dataGridViewCellStyle4;
            this.clmSubCatName.HeaderText = "Sub Category Name";
            this.clmSubCatName.Name = "clmSubCatName";
            this.clmSubCatName.ReadOnly = true;
            this.clmSubCatName.Width = 360;
            // 
            // frmAssignSubCategoryBrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(67)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(378, 466);
            this.Controls.Add(this.dgvSubCat);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.cmbSubCat);
            this.Controls.Add(this.cmbBrand);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblSubcat);
            this.Name = "frmAssignSubCategoryBrand";
            this.Text = "Assign SubCategory Brand";
            this.Load += new System.EventHandler(this.frmAssignSubCategoryBrand_Load);
            this.Controls.SetChildIndex(this.lblSubcat, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.cmbBrand, 0);
            this.Controls.SetChildIndex(this.cmbSubCat, 0);
            this.Controls.SetChildIndex(this.btnAssign, 0);
            this.Controls.SetChildIndex(this.dgvSubCat, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubCat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSubCat;
        private System.Windows.Forms.ComboBox cmbBrand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblSubcat;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.DataGridView dgvSubCat;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSubCatDetailsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSubCatID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBrandID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSubCatName;
    }
}