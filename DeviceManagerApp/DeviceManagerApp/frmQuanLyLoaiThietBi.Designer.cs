﻿namespace DeviceManagerApp
{
    partial class frmQuanLyLoaiThietBi
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyLoaiThietBi));
            lblQLDeviceType = new System.Windows.Forms.Label();
            gbQlDeviceType = new System.Windows.Forms.GroupBox();
            btn_AddSpecs = new System.Windows.Forms.Button();
            rtbMotaLoaiTB = new System.Windows.Forms.RichTextBox();
            lblMoTaLoaiTB = new System.Windows.Forms.Label();
            gbTimKiemLoaiTb = new System.Windows.Forms.GroupBox();
            btnTimKiemLoaiTb = new System.Windows.Forms.Button();
            txtTiemKiemLoaiTb = new System.Windows.Forms.TextBox();
            btnXoaLoaiTb = new System.Windows.Forms.Button();
            btnSuaLoaiTb = new System.Windows.Forms.Button();
            btnThemLoaiTB = new System.Windows.Forms.Button();
            txtTenLoaiTB = new System.Windows.Forms.TextBox();
            lblTenLoaiTB = new System.Windows.Forms.Label();
            dgvLoaiTb = new System.Windows.Forms.DataGridView();
            DeviceTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            gbQlDeviceType.SuspendLayout();
            gbTimKiemLoaiTb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoaiTb).BeginInit();
            SuspendLayout();
            // 
            // lblQLDeviceType
            // 
            lblQLDeviceType.AutoSize = true;
            lblQLDeviceType.Dock = System.Windows.Forms.DockStyle.Top;
            lblQLDeviceType.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblQLDeviceType.Location = new System.Drawing.Point(0, 0);
            lblQLDeviceType.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            lblQLDeviceType.Name = "lblQLDeviceType";
            lblQLDeviceType.Size = new System.Drawing.Size(464, 60);
            lblQLDeviceType.TabIndex = 0;
            lblQLDeviceType.Text = "Quản Lý Loại Thiết Bị";
            // 
            // gbQlDeviceType
            // 
            gbQlDeviceType.Controls.Add(btn_AddSpecs);
            gbQlDeviceType.Controls.Add(rtbMotaLoaiTB);
            gbQlDeviceType.Controls.Add(lblMoTaLoaiTB);
            gbQlDeviceType.Controls.Add(gbTimKiemLoaiTb);
            gbQlDeviceType.Controls.Add(btnXoaLoaiTb);
            gbQlDeviceType.Controls.Add(btnSuaLoaiTb);
            gbQlDeviceType.Controls.Add(btnThemLoaiTB);
            gbQlDeviceType.Controls.Add(txtTenLoaiTB);
            gbQlDeviceType.Controls.Add(lblTenLoaiTB);
            gbQlDeviceType.Dock = System.Windows.Forms.DockStyle.Top;
            gbQlDeviceType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            gbQlDeviceType.Location = new System.Drawing.Point(0, 60);
            gbQlDeviceType.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            gbQlDeviceType.Name = "gbQlDeviceType";
            gbQlDeviceType.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            gbQlDeviceType.Size = new System.Drawing.Size(1426, 312);
            gbQlDeviceType.TabIndex = 2;
            gbQlDeviceType.TabStop = false;
            gbQlDeviceType.Text = "Thông tin loại thiết bị";
            // 
            // btn_AddSpecs
            // 
            btn_AddSpecs.BackColor = System.Drawing.Color.Transparent;
            btn_AddSpecs.BackgroundImage = (System.Drawing.Image)resources.GetObject("btn_AddSpecs.BackgroundImage");
            btn_AddSpecs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btn_AddSpecs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_AddSpecs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_AddSpecs.Location = new System.Drawing.Point(1214, 248);
            btn_AddSpecs.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            btn_AddSpecs.Name = "btn_AddSpecs";
            btn_AddSpecs.Size = new System.Drawing.Size(169, 50);
            btn_AddSpecs.TabIndex = 9;
            toolTip1.SetToolTip(btn_AddSpecs, "Thêm thông số");
            btn_AddSpecs.UseVisualStyleBackColor = false;
            btn_AddSpecs.Click += AddSpecs_Click;
            // 
            // rtbMotaLoaiTB
            // 
            rtbMotaLoaiTB.Location = new System.Drawing.Point(246, 128);
            rtbMotaLoaiTB.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            rtbMotaLoaiTB.Name = "rtbMotaLoaiTB";
            rtbMotaLoaiTB.Size = new System.Drawing.Size(253, 96);
            rtbMotaLoaiTB.TabIndex = 3;
            rtbMotaLoaiTB.Text = "";
            // 
            // lblMoTaLoaiTB
            // 
            lblMoTaLoaiTB.AutoSize = true;
            lblMoTaLoaiTB.Location = new System.Drawing.Point(74, 142);
            lblMoTaLoaiTB.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            lblMoTaLoaiTB.Name = "lblMoTaLoaiTB";
            lblMoTaLoaiTB.Size = new System.Drawing.Size(72, 25);
            lblMoTaLoaiTB.TabIndex = 18;
            lblMoTaLoaiTB.Text = "Mô tả :";
            // 
            // gbTimKiemLoaiTb
            // 
            gbTimKiemLoaiTb.Controls.Add(btnTimKiemLoaiTb);
            gbTimKiemLoaiTb.Controls.Add(txtTiemKiemLoaiTb);
            gbTimKiemLoaiTb.Location = new System.Drawing.Point(819, 22);
            gbTimKiemLoaiTb.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            gbTimKiemLoaiTb.Name = "gbTimKiemLoaiTb";
            gbTimKiemLoaiTb.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            gbTimKiemLoaiTb.Size = new System.Drawing.Size(564, 202);
            gbTimKiemLoaiTb.TabIndex = 17;
            gbTimKiemLoaiTb.TabStop = false;
            gbTimKiemLoaiTb.Text = "Tìm Kiếm";
            // 
            // btnTimKiemLoaiTb
            // 
            btnTimKiemLoaiTb.BackColor = System.Drawing.Color.Transparent;
            btnTimKiemLoaiTb.BackgroundImage = Properties.Resources.search;
            btnTimKiemLoaiTb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnTimKiemLoaiTb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnTimKiemLoaiTb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnTimKiemLoaiTb.Location = new System.Drawing.Point(396, 42);
            btnTimKiemLoaiTb.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            btnTimKiemLoaiTb.Name = "btnTimKiemLoaiTb";
            btnTimKiemLoaiTb.Size = new System.Drawing.Size(134, 50);
            btnTimKiemLoaiTb.TabIndex = 8;
            toolTip1.SetToolTip(btnTimKiemLoaiTb, "Tìm kiếm");
            btnTimKiemLoaiTb.UseVisualStyleBackColor = false;
            // 
            // txtTiemKiemLoaiTb
            // 
            txtTiemKiemLoaiTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtTiemKiemLoaiTb.Location = new System.Drawing.Point(31, 52);
            txtTiemKiemLoaiTb.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            txtTiemKiemLoaiTb.Name = "txtTiemKiemLoaiTb";
            txtTiemKiemLoaiTb.Size = new System.Drawing.Size(252, 31);
            txtTiemKiemLoaiTb.TabIndex = 7;
            // 
            // btnXoaLoaiTb
            // 
            btnXoaLoaiTb.BackColor = System.Drawing.Color.Transparent;
            btnXoaLoaiTb.BackgroundImage = (System.Drawing.Image)resources.GetObject("btnXoaLoaiTb.BackgroundImage");
            btnXoaLoaiTb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnXoaLoaiTb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnXoaLoaiTb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnXoaLoaiTb.Location = new System.Drawing.Point(661, 175);
            btnXoaLoaiTb.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            btnXoaLoaiTb.Name = "btnXoaLoaiTb";
            btnXoaLoaiTb.Size = new System.Drawing.Size(134, 50);
            btnXoaLoaiTb.TabIndex = 6;
            toolTip1.SetToolTip(btnXoaLoaiTb, "Xóa Loại Thiết Bị");
            btnXoaLoaiTb.UseVisualStyleBackColor = false;
            btnXoaLoaiTb.ClientSizeChanged += btnXoaLoaiTb_Click;
            btnXoaLoaiTb.Click += btnXoaLoaiTb_Click;
            // 
            // btnSuaLoaiTb
            // 
            btnSuaLoaiTb.BackColor = System.Drawing.Color.Transparent;
            btnSuaLoaiTb.BackgroundImage = (System.Drawing.Image)resources.GetObject("btnSuaLoaiTb.BackgroundImage");
            btnSuaLoaiTb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnSuaLoaiTb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSuaLoaiTb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSuaLoaiTb.Location = new System.Drawing.Point(661, 105);
            btnSuaLoaiTb.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            btnSuaLoaiTb.Name = "btnSuaLoaiTb";
            btnSuaLoaiTb.Size = new System.Drawing.Size(134, 50);
            btnSuaLoaiTb.TabIndex = 5;
            toolTip1.SetToolTip(btnSuaLoaiTb, "Cập nhật");
            btnSuaLoaiTb.UseVisualStyleBackColor = false;
            btnSuaLoaiTb.Click += btnSuaLoaiTb_Click;
            // 
            // btnThemLoaiTB
            // 
            btnThemLoaiTB.BackColor = System.Drawing.Color.Transparent;
            btnThemLoaiTB.BackgroundImage = (System.Drawing.Image)resources.GetObject("btnThemLoaiTB.BackgroundImage");
            btnThemLoaiTB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnThemLoaiTB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnThemLoaiTB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnThemLoaiTB.Location = new System.Drawing.Point(661, 22);
            btnThemLoaiTB.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            btnThemLoaiTB.Name = "btnThemLoaiTB";
            btnThemLoaiTB.Size = new System.Drawing.Size(134, 50);
            btnThemLoaiTB.TabIndex = 4;
            toolTip1.SetToolTip(btnThemLoaiTB, "Thêm Mới");
            btnThemLoaiTB.UseVisualStyleBackColor = false;
            btnThemLoaiTB.Click += btnThemLoaiTB_Click;
            // 
            // txtTenLoaiTB
            // 
            txtTenLoaiTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtTenLoaiTB.Location = new System.Drawing.Point(246, 62);
            txtTenLoaiTB.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            txtTenLoaiTB.Name = "txtTenLoaiTB";
            txtTenLoaiTB.Size = new System.Drawing.Size(252, 31);
            txtTenLoaiTB.TabIndex = 2;
            // 
            // lblTenLoaiTB
            // 
            lblTenLoaiTB.AutoSize = true;
            lblTenLoaiTB.Location = new System.Drawing.Point(74, 70);
            lblTenLoaiTB.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            lblTenLoaiTB.Name = "lblTenLoaiTB";
            lblTenLoaiTB.Size = new System.Drawing.Size(163, 25);
            lblTenLoaiTB.TabIndex = 1;
            lblTenLoaiTB.Text = "Tên Loại Thiết Bị :";
            // 
            // dgvLoaiTb
            // 
            dgvLoaiTb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoaiTb.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { DeviceTypeId, Column1, Column2 });
            dgvLoaiTb.Location = new System.Drawing.Point(0, 372);
            dgvLoaiTb.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            dgvLoaiTb.Name = "dgvLoaiTb";
            dgvLoaiTb.ReadOnly = true;
            dgvLoaiTb.RowHeadersWidth = 62;
            dgvLoaiTb.RowTemplate.Height = 33;
            dgvLoaiTb.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvLoaiTb.Size = new System.Drawing.Size(500, 266);
            dgvLoaiTb.TabIndex = 3;
            dgvLoaiTb.CellClick += dgvLoaiTb_CellClick;
            // 
            // DeviceTypeId
            // 
            DeviceTypeId.DataPropertyName = "Id";
            DeviceTypeId.HeaderText = "Id";
            DeviceTypeId.MinimumWidth = 8;
            DeviceTypeId.Name = "DeviceTypeId";
            DeviceTypeId.ReadOnly = true;
            DeviceTypeId.Visible = false;
            DeviceTypeId.Width = 150;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Name";
            Column1.HeaderText = "Tên Loại Thiết Bị";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Description";
            Column2.HeaderText = "Mô Tả";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 150;
            // 
            // frmQuanLyLoaiThietBi
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1426, 640);
            Controls.Add(dgvLoaiTb);
            Controls.Add(gbQlDeviceType);
            Controls.Add(lblQLDeviceType);
            Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            MinimumSize = new System.Drawing.Size(1443, 685);
            Name = "frmQuanLyLoaiThietBi";
            Text = "frmQuanLyLoaiThietBi";
            gbQlDeviceType.ResumeLayout(false);
            gbQlDeviceType.PerformLayout();
            gbTimKiemLoaiTb.ResumeLayout(false);
            gbTimKiemLoaiTb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoaiTb).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblQLDeviceType;
        private System.Windows.Forms.GroupBox gbQlDeviceType;
        private System.Windows.Forms.RichTextBox rtbMotaLoaiTB;
        private System.Windows.Forms.Label lblMoTaLoaiTB;
        private System.Windows.Forms.GroupBox gbTimKiemLoaiTb;
        private System.Windows.Forms.Button btnTimKiemLoaiTb;
        private System.Windows.Forms.TextBox txtTiemKiemLoaiTb;
        private System.Windows.Forms.Button btnXoaLoaiTb;
        private System.Windows.Forms.Button btnSuaLoaiTb;
        private System.Windows.Forms.Button btnThemLoaiTB;
        private System.Windows.Forms.TextBox txtTenLoaiTB;
        private System.Windows.Forms.Label lblTenLoaiTB;
        private System.Windows.Forms.DataGridView dgvLoaiTb;
        private System.Windows.Forms.Button btn_AddSpecs;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}