namespace ServiceCenter.Views
{
    partial class frmSupplierView
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
            this.dgvSupplierView = new System.Windows.Forms.DataGridView();
            this.txtSupplierSearch = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clmintSupplierID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vcCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmContactNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmbtnDeleteSupplier = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplierView)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSupplierView
            // 
            this.dgvSupplierView.AllowUserToAddRows = false;
            this.dgvSupplierView.AllowUserToDeleteRows = false;
            this.dgvSupplierView.AllowUserToOrderColumns = true;
            this.dgvSupplierView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSupplierView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSupplierView.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgvSupplierView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(58)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSupplierView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSupplierView.ColumnHeadersHeight = 35;
            this.dgvSupplierView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSupplierView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmintSupplierID,
            this.clmSupplierName,
            this.clmAddress,
            this.vcCity,
            this.clmContactNo,
            this.clmEmail,
            this.clmbtnDeleteSupplier});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSupplierView.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSupplierView.EnableHeadersVisualStyles = false;
            this.dgvSupplierView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvSupplierView.Location = new System.Drawing.Point(28, 148);
            this.dgvSupplierView.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSupplierView.MultiSelect = false;
            this.dgvSupplierView.Name = "dgvSupplierView";
            this.dgvSupplierView.ReadOnly = true;
            this.dgvSupplierView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvSupplierView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSupplierView.RowHeadersVisible = false;
            this.dgvSupplierView.RowHeadersWidth = 15;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSupplierView.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvSupplierView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvSupplierView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSupplierView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSupplierView.Size = new System.Drawing.Size(1429, 522);
            this.dgvSupplierView.TabIndex = 221;
            this.dgvSupplierView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSupplierView_CellClick);
            // 
            // txtSupplierSearch
            // 
            this.txtSupplierSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtSupplierSearch.Location = new System.Drawing.Point(220, 94);
            this.txtSupplierSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSupplierSearch.MaxLength = 1000;
            this.txtSupplierSearch.Name = "txtSupplierSearch";
            this.txtSupplierSearch.Size = new System.Drawing.Size(463, 29);
            this.txtSupplierSearch.TabIndex = 252;
            this.txtSupplierSearch.TextChanged += new System.EventHandler(this.txtSupplierSearch_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(24, 100);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(188, 23);
            this.label12.TabIndex = 251;
            this.label12.Text = "Search Supplier Name :";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 54);
            this.label1.TabIndex = 250;
            this.label1.Text = "Supplier Views";
            // 
            // clmintSupplierID
            // 
            this.clmintSupplierID.DataPropertyName = "intSupplierID";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmintSupplierID.DefaultCellStyle = dataGridViewCellStyle3;
            this.clmintSupplierID.HeaderText = "SupplierID";
            this.clmintSupplierID.Name = "clmintSupplierID";
            this.clmintSupplierID.ReadOnly = true;
            this.clmintSupplierID.Visible = false;
            this.clmintSupplierID.Width = 5;
            // 
            // clmSupplierName
            // 
            this.clmSupplierName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmSupplierName.DataPropertyName = "vcSupplierName";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmSupplierName.DefaultCellStyle = dataGridViewCellStyle4;
            this.clmSupplierName.HeaderText = "Name";
            this.clmSupplierName.MaxInputLength = 1000;
            this.clmSupplierName.Name = "clmSupplierName";
            this.clmSupplierName.ReadOnly = true;
            // 
            // clmAddress
            // 
            this.clmAddress.DataPropertyName = "vcAddress";
            this.clmAddress.HeaderText = "Address";
            this.clmAddress.Name = "clmAddress";
            this.clmAddress.ReadOnly = true;
            this.clmAddress.Width = 200;
            // 
            // vcCity
            // 
            this.vcCity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.vcCity.DataPropertyName = "vcCity";
            this.vcCity.HeaderText = "City";
            this.vcCity.Name = "vcCity";
            this.vcCity.ReadOnly = true;
            this.vcCity.Visible = false;
            // 
            // clmContactNo
            // 
            this.clmContactNo.DataPropertyName = "intContactNo";
            this.clmContactNo.HeaderText = "Contact No";
            this.clmContactNo.Name = "clmContactNo";
            this.clmContactNo.ReadOnly = true;
            this.clmContactNo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmContactNo.Width = 75;
            // 
            // clmEmail
            // 
            this.clmEmail.DataPropertyName = "vcEmail";
            this.clmEmail.HeaderText = "Email";
            this.clmEmail.Name = "clmEmail";
            this.clmEmail.ReadOnly = true;
            this.clmEmail.Width = 250;
            // 
            // clmbtnDeleteSupplier
            // 
            this.clmbtnDeleteSupplier.HeaderText = "Delete";
            this.clmbtnDeleteSupplier.Name = "clmbtnDeleteSupplier";
            this.clmbtnDeleteSupplier.ReadOnly = true;
            this.clmbtnDeleteSupplier.Width = 50;
            // 
            // frmSupplierView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(67)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(1490, 695);
            this.Controls.Add(this.txtSupplierSearch);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSupplierView);
            this.Name = "frmSupplierView";
            this.Text = "frmSupplierView";
            this.Controls.SetChildIndex(this.dgvSupplierView, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.txtSupplierSearch, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplierView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSupplierView;
        private System.Windows.Forms.TextBox txtSupplierSearch;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmintSupplierID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn vcCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmContactNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEmail;
        private System.Windows.Forms.DataGridViewButtonColumn clmbtnDeleteSupplier;
    }
}