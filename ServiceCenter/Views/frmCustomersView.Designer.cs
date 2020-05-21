namespace ServiceCenter.Views
{
    partial class frmCustomersView
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
            this.dgvCustomerView = new System.Windows.Forms.DataGridView();
            this.clmintCustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmVehicleNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vcItemDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmContactNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNameSearch = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtVehicleSearch = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerView)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCustomerView
            // 
            this.dgvCustomerView.AllowUserToAddRows = false;
            this.dgvCustomerView.AllowUserToDeleteRows = false;
            this.dgvCustomerView.AllowUserToOrderColumns = true;
            this.dgvCustomerView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCustomerView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCustomerView.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgvCustomerView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(58)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomerView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCustomerView.ColumnHeadersHeight = 35;
            this.dgvCustomerView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCustomerView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmintCustomerID,
            this.clmVehicleNo,
            this.clmCustomerName,
            this.vcItemDescription,
            this.clmCity,
            this.clmContactNo});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomerView.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCustomerView.EnableHeadersVisualStyles = false;
            this.dgvCustomerView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvCustomerView.Location = new System.Drawing.Point(12, 147);
            this.dgvCustomerView.MultiSelect = false;
            this.dgvCustomerView.Name = "dgvCustomerView";
            this.dgvCustomerView.ReadOnly = true;
            this.dgvCustomerView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvCustomerView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCustomerView.RowHeadersVisible = false;
            this.dgvCustomerView.RowHeadersWidth = 15;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCustomerView.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCustomerView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvCustomerView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCustomerView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomerView.Size = new System.Drawing.Size(1022, 515);
            this.dgvCustomerView.TabIndex = 220;
            // 
            // clmintCustomerID
            // 
            this.clmintCustomerID.DataPropertyName = "intCustomerID";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmintCustomerID.DefaultCellStyle = dataGridViewCellStyle3;
            this.clmintCustomerID.HeaderText = "CustomerID";
            this.clmintCustomerID.Name = "clmintCustomerID";
            this.clmintCustomerID.ReadOnly = true;
            this.clmintCustomerID.Visible = false;
            this.clmintCustomerID.Width = 5;
            // 
            // clmVehicleNo
            // 
            this.clmVehicleNo.DataPropertyName = "vcVehicleNo";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmVehicleNo.DefaultCellStyle = dataGridViewCellStyle4;
            this.clmVehicleNo.HeaderText = "Vehicle No";
            this.clmVehicleNo.Name = "clmVehicleNo";
            this.clmVehicleNo.ReadOnly = true;
            this.clmVehicleNo.Width = 150;
            // 
            // clmCustomerName
            // 
            this.clmCustomerName.DataPropertyName = "vcCustomerName";
            this.clmCustomerName.HeaderText = "Name";
            this.clmCustomerName.Name = "clmCustomerName";
            this.clmCustomerName.ReadOnly = true;
            this.clmCustomerName.Width = 150;
            // 
            // vcItemDescription
            // 
            this.vcItemDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.vcItemDescription.DataPropertyName = "vcAddress";
            this.vcItemDescription.HeaderText = "Address";
            this.vcItemDescription.Name = "vcItemDescription";
            this.vcItemDescription.ReadOnly = true;
            // 
            // clmCity
            // 
            this.clmCity.DataPropertyName = "vcCity";
            this.clmCity.HeaderText = "City";
            this.clmCity.Name = "clmCity";
            this.clmCity.ReadOnly = true;
            this.clmCity.Width = 150;
            // 
            // clmContactNo
            // 
            this.clmContactNo.DataPropertyName = "intContactNo";
            this.clmContactNo.HeaderText = "Contact No";
            this.clmContactNo.Name = "clmContactNo";
            this.clmContactNo.ReadOnly = true;
            this.clmContactNo.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 45);
            this.label1.TabIndex = 247;
            this.label1.Text = "Customer Views";
            // 
            // txtNameSearch
            // 
            this.txtNameSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtNameSearch.Location = new System.Drawing.Point(492, 105);
            this.txtNameSearch.MaxLength = 10000;
            this.txtNameSearch.Name = "txtNameSearch";
            this.txtNameSearch.Size = new System.Drawing.Size(221, 25);
            this.txtNameSearch.TabIndex = 251;
            this.txtNameSearch.Click += new System.EventHandler(this.txtNameSearch_Click);
            this.txtNameSearch.TextChanged += new System.EventHandler(this.txtNameSearch_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(365, 106);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 19);
            this.label13.TabIndex = 250;
            this.label13.Text = "Search for Name :";
            // 
            // txtVehicleSearch
            // 
            this.txtVehicleSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtVehicleSearch.Location = new System.Drawing.Point(147, 105);
            this.txtVehicleSearch.MaxLength = 1000;
            this.txtVehicleSearch.Name = "txtVehicleSearch";
            this.txtVehicleSearch.Size = new System.Drawing.Size(198, 25);
            this.txtVehicleSearch.TabIndex = 249;
            this.txtVehicleSearch.Click += new System.EventHandler(this.txtVehicleSearch_Click);
            this.txtVehicleSearch.TextChanged += new System.EventHandler(this.txtCodeSearch_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(19, 106);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 19);
            this.label12.TabIndex = 248;
            this.label12.Text = "Search Vehicle No:";
            // 
            // frmCustomersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(67)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(1046, 674);
            this.Controls.Add(this.txtNameSearch);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtVehicleSearch);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCustomerView);
            this.Name = "frmCustomersView";
            this.Text = "Customer View";
            this.Controls.SetChildIndex(this.dgvCustomerView, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.txtVehicleSearch, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.txtNameSearch, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomerView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNameSearch;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtVehicleSearch;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmintCustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmVehicleNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn vcItemDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmContactNo;
    }
}