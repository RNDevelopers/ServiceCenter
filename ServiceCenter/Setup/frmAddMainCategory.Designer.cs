namespace ServiceCenter.Setup
{
    partial class frmAddMainCategory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAddMainCategory = new System.Windows.Forms.DataGridView();
            this.clmMainCategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMainCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmbtnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtMainCategoryName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddMainCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAddMainCategory
            // 
            this.dgvAddMainCategory.AllowUserToAddRows = false;
            this.dgvAddMainCategory.AllowUserToDeleteRows = false;
            this.dgvAddMainCategory.AllowUserToOrderColumns = true;
            this.dgvAddMainCategory.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAddMainCategory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAddMainCategory.BackgroundColor = System.Drawing.Color.White;
            this.dgvAddMainCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAddMainCategory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAddMainCategory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(58)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAddMainCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAddMainCategory.ColumnHeadersHeight = 35;
            this.dgvAddMainCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAddMainCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmMainCategoryID,
            this.clmMainCategoryName,
            this.clmbtnDelete});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAddMainCategory.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAddMainCategory.EnableHeadersVisualStyles = false;
            this.dgvAddMainCategory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvAddMainCategory.Location = new System.Drawing.Point(12, 173);
            this.dgvAddMainCategory.MultiSelect = false;
            this.dgvAddMainCategory.Name = "dgvAddMainCategory";
            this.dgvAddMainCategory.ReadOnly = true;
            this.dgvAddMainCategory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvAddMainCategory.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAddMainCategory.RowHeadersVisible = false;
            this.dgvAddMainCategory.RowHeadersWidth = 15;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAddMainCategory.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAddMainCategory.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvAddMainCategory.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAddMainCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAddMainCategory.Size = new System.Drawing.Size(398, 304);
            this.dgvAddMainCategory.TabIndex = 120;
            this.dgvAddMainCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAddMainCategory_CellClick);
            // 
            // clmMainCategoryID
            // 
            this.clmMainCategoryID.DataPropertyName = "intMainCategoryID";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmMainCategoryID.DefaultCellStyle = dataGridViewCellStyle3;
            this.clmMainCategoryID.HeaderText = "intMainCategoryID";
            this.clmMainCategoryID.Name = "clmMainCategoryID";
            this.clmMainCategoryID.ReadOnly = true;
            this.clmMainCategoryID.Visible = false;
            this.clmMainCategoryID.Width = 150;
            // 
            // clmMainCategoryName
            // 
            this.clmMainCategoryName.DataPropertyName = "vcMainCategoryName";
            this.clmMainCategoryName.HeaderText = "Category Name";
            this.clmMainCategoryName.Name = "clmMainCategoryName";
            this.clmMainCategoryName.ReadOnly = true;
            this.clmMainCategoryName.Width = 250;
            // 
            // clmbtnDelete
            // 
            this.clmbtnDelete.HeaderText = "Press to Delete";
            this.clmbtnDelete.Name = "clmbtnDelete";
            this.clmbtnDelete.ReadOnly = true;
            this.clmbtnDelete.Width = 150;
            // 
            // txtMainCategoryName
            // 
            this.txtMainCategoryName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtMainCategoryName.Location = new System.Drawing.Point(156, 100);
            this.txtMainCategoryName.Name = "txtMainCategoryName";
            this.txtMainCategoryName.Size = new System.Drawing.Size(251, 25);
            this.txtMainCategoryName.TabIndex = 115;
            this.txtMainCategoryName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMainCategoryName_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(139, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 17);
            this.label2.TabIndex = 114;
            this.label2.Text = ":";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 37);
            this.label1.TabIndex = 121;
            this.label1.Text = "Add Main Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(19, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 19);
            this.label5.TabIndex = 123;
            this.label5.Text = "Category Name";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(110)))), ((int)(((byte)(185)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(336, 132);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(71, 35);
            this.btnSave.TabIndex = 143;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAddMainCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(67)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(422, 500);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAddMainCategory);
            this.Controls.Add(this.txtMainCategoryName);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmAddMainCategory";
            this.Text = "Add Main Category";
            this.Load += new System.EventHandler(this.frmAddMainCategory_Load);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtMainCategoryName, 0);
            this.Controls.SetChildIndex(this.dgvAddMainCategory, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddMainCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvAddMainCategory;
        private System.Windows.Forms.TextBox txtMainCategoryName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMainCategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMainCategoryName;
        private System.Windows.Forms.DataGridViewButtonColumn clmbtnDelete;
    }
}