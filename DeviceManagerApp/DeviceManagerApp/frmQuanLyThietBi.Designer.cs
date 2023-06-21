﻿namespace DeviceManagerApp
{
    partial class frmQuanLyThietBi
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
            this.components = new System.ComponentModel.Container();
            this.lblQLTbi = new System.Windows.Forms.Label();
            this.gbThongtinTB = new System.Windows.Forms.GroupBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDetail = new System.Windows.Forms.Button();
            this.ptb_Device = new System.Windows.Forms.PictureBox();
            this.gbTimKiemTbi = new System.Windows.Forms.GroupBox();
            this.dtp_DateBuy = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTimKiemTbi = new System.Windows.Forms.Button();
            this.txtTiemKiemTbi = new System.Windows.Forms.TextBox();
            this.btnXoaTbi = new System.Windows.Forms.Button();
            this.btnSuaTbi = new System.Windows.Forms.Button();
            this.btnThemTbi = new System.Windows.Forms.Button();
            this.rtbGhiChuTbi = new System.Windows.Forms.RichTextBox();
            this.lblGhiChuTbi = new System.Windows.Forms.Label();
            this.dtBaoHanh = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.cbPhong = new System.Windows.Forms.ComboBox();
            this.lblPhong = new System.Windows.Forms.Label();
            this.cbNhaCungCap = new System.Windows.Forms.ComboBox();
            this.cbLoaiTbi = new System.Windows.Forms.ComboBox();
            this.txtTenTbi = new System.Windows.Forms.TextBox();
            this.lblNhaCungCap = new System.Windows.Forms.Label();
            this.lblLoaiTbi = new System.Windows.Forms.Label();
            this.lblTenTBi = new System.Windows.Forms.Label();
            this.lb_Image = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.DeviceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeviceDetail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.SpecsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WarrantyPeriob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeviceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeviceImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.dtgvQlThietBi = new System.Windows.Forms.DataGridView();
            this.gbThongtinTB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Device)).BeginInit();
            this.gbTimKiemTbi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQlThietBi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQLTbi
            // 
            this.lblQLTbi.AutoSize = true;
            this.lblQLTbi.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblQLTbi.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblQLTbi.Location = new System.Drawing.Point(0, 0);
            this.lblQLTbi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQLTbi.Name = "lblQLTbi";
            this.lblQLTbi.Size = new System.Drawing.Size(306, 50);
            this.lblQLTbi.TabIndex = 0;
            this.lblQLTbi.Text = "Quản Lý Thiết Bị";
            // 
            // gbThongtinTB
            // 
            this.gbThongtinTB.Controls.Add(this.txtPrice);
            this.gbThongtinTB.Controls.Add(this.label3);
            this.gbThongtinTB.Controls.Add(this.btnDetail);
            this.gbThongtinTB.Controls.Add(this.ptb_Device);
            this.gbThongtinTB.Controls.Add(this.gbTimKiemTbi);
            this.gbThongtinTB.Controls.Add(this.btnXoaTbi);
            this.gbThongtinTB.Controls.Add(this.btnSuaTbi);
            this.gbThongtinTB.Controls.Add(this.btnThemTbi);
            this.gbThongtinTB.Controls.Add(this.rtbGhiChuTbi);
            this.gbThongtinTB.Controls.Add(this.lblGhiChuTbi);
            this.gbThongtinTB.Controls.Add(this.dtBaoHanh);
            this.gbThongtinTB.Controls.Add(this.label1);
            this.gbThongtinTB.Controls.Add(this.cbKhoa);
            this.gbThongtinTB.Controls.Add(this.lblKhoa);
            this.gbThongtinTB.Controls.Add(this.cbPhong);
            this.gbThongtinTB.Controls.Add(this.lblPhong);
            this.gbThongtinTB.Controls.Add(this.cbNhaCungCap);
            this.gbThongtinTB.Controls.Add(this.cbLoaiTbi);
            this.gbThongtinTB.Controls.Add(this.txtTenTbi);
            this.gbThongtinTB.Controls.Add(this.lblNhaCungCap);
            this.gbThongtinTB.Controls.Add(this.lblLoaiTbi);
            this.gbThongtinTB.Controls.Add(this.lblTenTBi);
            this.gbThongtinTB.Controls.Add(this.lb_Image);
            this.gbThongtinTB.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbThongtinTB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbThongtinTB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbThongtinTB.Location = new System.Drawing.Point(0, 50);
            this.gbThongtinTB.Margin = new System.Windows.Forms.Padding(2);
            this.gbThongtinTB.Name = "gbThongtinTB";
            this.gbThongtinTB.Padding = new System.Windows.Forms.Padding(2);
            this.gbThongtinTB.Size = new System.Drawing.Size(1257, 384);
            this.gbThongtinTB.TabIndex = 1;
            this.gbThongtinTB.TabStop = false;
            this.gbThongtinTB.Text = "Thông tin thiết bị";
            this.gbThongtinTB.Enter += new System.EventHandler(this.gbThongtinTB_Enter);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(517, 146);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(174, 27);
            this.txtPrice.TabIndex = 16;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Price_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(396, 149);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Giá :";
            // 
            // btnDetail
            // 
            this.btnDetail.BackColor = System.Drawing.Color.Lime;
            this.btnDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDetail.Location = new System.Drawing.Point(1076, 324);
            this.btnDetail.Margin = new System.Windows.Forms.Padding(2);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(170, 40);
            this.btnDetail.TabIndex = 14;
            this.btnDetail.Text = "Thông số kỹ thuật";
            this.btnDetail.UseVisualStyleBackColor = false;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // ptb_Device
            // 
            this.ptb_Device.Location = new System.Drawing.Point(1000, 76);
            this.ptb_Device.Name = "ptb_Device";
            this.ptb_Device.Size = new System.Drawing.Size(200, 200);
            this.ptb_Device.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_Device.TabIndex = 13;
            this.ptb_Device.TabStop = false;
            this.toolTip1.SetToolTip(this.ptb_Device, "Nhấn đúp để tải ảnh");
            // 
            // gbTimKiemTbi
            // 
            this.gbTimKiemTbi.Controls.Add(this.dtp_DateBuy);
            this.gbTimKiemTbi.Controls.Add(this.label2);
            this.gbTimKiemTbi.Controls.Add(this.btnTimKiemTbi);
            this.gbTimKiemTbi.Controls.Add(this.txtTiemKiemTbi);
            this.gbTimKiemTbi.Location = new System.Drawing.Point(5, 290);
            this.gbTimKiemTbi.Margin = new System.Windows.Forms.Padding(2);
            this.gbTimKiemTbi.Name = "gbTimKiemTbi";
            this.gbTimKiemTbi.Padding = new System.Windows.Forms.Padding(2);
            this.gbTimKiemTbi.Size = new System.Drawing.Size(964, 86);
            this.gbTimKiemTbi.TabIndex = 12;
            this.gbTimKiemTbi.TabStop = false;
            this.gbTimKiemTbi.Text = "Tìm kiếm thiết bị";
            // 
            // dtp_DateBuy
            // 
            this.dtp_DateBuy.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_DateBuy.Location = new System.Drawing.Point(512, 42);
            this.dtp_DateBuy.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_DateBuy.Name = "dtp_DateBuy";
            this.dtp_DateBuy.Size = new System.Drawing.Size(174, 27);
            this.dtp_DateBuy.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(391, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Ngày mua :";
            // 
            // btnTimKiemTbi
            // 
            this.btnTimKiemTbi.BackColor = System.Drawing.Color.Lime;
            this.btnTimKiemTbi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiemTbi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTimKiemTbi.Location = new System.Drawing.Point(801, 34);
            this.btnTimKiemTbi.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiemTbi.Name = "btnTimKiemTbi";
            this.btnTimKiemTbi.Size = new System.Drawing.Size(107, 40);
            this.btnTimKiemTbi.TabIndex = 13;
            this.btnTimKiemTbi.Text = "Tìm Kiếm";
            this.btnTimKiemTbi.UseVisualStyleBackColor = false;
            // 
            // txtTiemKiemTbi
            // 
            this.txtTiemKiemTbi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTiemKiemTbi.Location = new System.Drawing.Point(137, 42);
            this.txtTiemKiemTbi.Margin = new System.Windows.Forms.Padding(2);
            this.txtTiemKiemTbi.Name = "txtTiemKiemTbi";
            this.txtTiemKiemTbi.Size = new System.Drawing.Size(176, 27);
            this.txtTiemKiemTbi.TabIndex = 12;
            // 
            // btnXoaTbi
            // 
            this.btnXoaTbi.BackColor = System.Drawing.Color.Lime;
            this.btnXoaTbi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaTbi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXoaTbi.Location = new System.Drawing.Point(806, 182);
            this.btnXoaTbi.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaTbi.Name = "btnXoaTbi";
            this.btnXoaTbi.Size = new System.Drawing.Size(107, 40);
            this.btnXoaTbi.TabIndex = 11;
            this.btnXoaTbi.Text = "Xóa";
            this.btnXoaTbi.UseVisualStyleBackColor = false;
            // 
            // btnSuaTbi
            // 
            this.btnSuaTbi.BackColor = System.Drawing.Color.Lime;
            this.btnSuaTbi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaTbi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSuaTbi.Location = new System.Drawing.Point(806, 103);
            this.btnSuaTbi.Margin = new System.Windows.Forms.Padding(2);
            this.btnSuaTbi.Name = "btnSuaTbi";
            this.btnSuaTbi.Size = new System.Drawing.Size(107, 40);
            this.btnSuaTbi.TabIndex = 10;
            this.btnSuaTbi.Text = "Cập Nhật";
            this.btnSuaTbi.UseVisualStyleBackColor = false;
            // 
            // btnThemTbi
            // 
            this.btnThemTbi.BackColor = System.Drawing.Color.Lime;
            this.btnThemTbi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemTbi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThemTbi.Location = new System.Drawing.Point(806, 26);
            this.btnThemTbi.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemTbi.Name = "btnThemTbi";
            this.btnThemTbi.Size = new System.Drawing.Size(107, 40);
            this.btnThemTbi.TabIndex = 9;
            this.btnThemTbi.Text = "Thêm Mới";
            this.btnThemTbi.UseVisualStyleBackColor = false;
            this.btnThemTbi.Click += new System.EventHandler(this.btnThemTbi_Click);
            // 
            // rtbGhiChuTbi
            // 
            this.rtbGhiChuTbi.Location = new System.Drawing.Point(517, 199);
            this.rtbGhiChuTbi.Margin = new System.Windows.Forms.Padding(2);
            this.rtbGhiChuTbi.Name = "rtbGhiChuTbi";
            this.rtbGhiChuTbi.Size = new System.Drawing.Size(174, 74);
            this.rtbGhiChuTbi.TabIndex = 8;
            this.rtbGhiChuTbi.Text = "";
            // 
            // lblGhiChuTbi
            // 
            this.lblGhiChuTbi.AutoSize = true;
            this.lblGhiChuTbi.Location = new System.Drawing.Point(396, 199);
            this.lblGhiChuTbi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGhiChuTbi.Name = "lblGhiChuTbi";
            this.lblGhiChuTbi.Size = new System.Drawing.Size(72, 20);
            this.lblGhiChuTbi.TabIndex = 8;
            this.lblGhiChuTbi.Text = "Ghi Chú :";
            // 
            // dtBaoHanh
            // 
            this.dtBaoHanh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBaoHanh.Location = new System.Drawing.Point(517, 86);
            this.dtBaoHanh.Margin = new System.Windows.Forms.Padding(2);
            this.dtBaoHanh.Name = "dtBaoHanh";
            this.dtBaoHanh.Size = new System.Drawing.Size(174, 27);
            this.dtBaoHanh.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(396, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Hạn bảo hành :";
            // 
            // cbKhoa
            // 
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Location = new System.Drawing.Point(517, 26);
            this.cbKhoa.Margin = new System.Windows.Forms.Padding(2);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(174, 28);
            this.cbKhoa.TabIndex = 6;
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Location = new System.Drawing.Point(396, 33);
            this.lblKhoa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(53, 20);
            this.lblKhoa.TabIndex = 6;
            this.lblKhoa.Text = "Khoa :";
            // 
            // cbPhong
            // 
            this.cbPhong.FormattingEnabled = true;
            this.cbPhong.Location = new System.Drawing.Point(144, 199);
            this.cbPhong.Margin = new System.Windows.Forms.Padding(2);
            this.cbPhong.Name = "cbPhong";
            this.cbPhong.Size = new System.Drawing.Size(174, 28);
            this.cbPhong.TabIndex = 5;
            // 
            // lblPhong
            // 
            this.lblPhong.AutoSize = true;
            this.lblPhong.Location = new System.Drawing.Point(28, 202);
            this.lblPhong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(62, 20);
            this.lblPhong.TabIndex = 5;
            this.lblPhong.Text = "Phòng :";
            // 
            // cbNhaCungCap
            // 
            this.cbNhaCungCap.FormattingEnabled = true;
            this.cbNhaCungCap.Location = new System.Drawing.Point(142, 145);
            this.cbNhaCungCap.Margin = new System.Windows.Forms.Padding(2);
            this.cbNhaCungCap.Name = "cbNhaCungCap";
            this.cbNhaCungCap.Size = new System.Drawing.Size(174, 28);
            this.cbNhaCungCap.TabIndex = 4;
            // 
            // cbLoaiTbi
            // 
            this.cbLoaiTbi.FormattingEnabled = true;
            this.cbLoaiTbi.Location = new System.Drawing.Point(144, 85);
            this.cbLoaiTbi.Margin = new System.Windows.Forms.Padding(2);
            this.cbLoaiTbi.Name = "cbLoaiTbi";
            this.cbLoaiTbi.Size = new System.Drawing.Size(174, 28);
            this.cbLoaiTbi.TabIndex = 3;
            // 
            // txtTenTbi
            // 
            this.txtTenTbi.Location = new System.Drawing.Point(142, 30);
            this.txtTenTbi.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenTbi.Name = "txtTenTbi";
            this.txtTenTbi.Size = new System.Drawing.Size(174, 27);
            this.txtTenTbi.TabIndex = 2;
            // 
            // lblNhaCungCap
            // 
            this.lblNhaCungCap.AutoSize = true;
            this.lblNhaCungCap.Location = new System.Drawing.Point(26, 148);
            this.lblNhaCungCap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNhaCungCap.Name = "lblNhaCungCap";
            this.lblNhaCungCap.Size = new System.Drawing.Size(106, 20);
            this.lblNhaCungCap.TabIndex = 3;
            this.lblNhaCungCap.Text = "Thương hiệu :";
            // 
            // lblLoaiTbi
            // 
            this.lblLoaiTbi.AutoSize = true;
            this.lblLoaiTbi.Location = new System.Drawing.Point(26, 88);
            this.lblLoaiTbi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoaiTbi.Name = "lblLoaiTbi";
            this.lblLoaiTbi.Size = new System.Drawing.Size(100, 20);
            this.lblLoaiTbi.TabIndex = 2;
            this.lblLoaiTbi.Text = "Loại thiết bị :";
            // 
            // lblTenTBi
            // 
            this.lblTenTBi.AutoSize = true;
            this.lblTenTBi.Location = new System.Drawing.Point(26, 35);
            this.lblTenTBi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenTBi.Name = "lblTenTBi";
            this.lblTenTBi.Size = new System.Drawing.Size(96, 20);
            this.lblTenTBi.TabIndex = 1;
            this.lblTenTBi.Text = "Tên thiết bị :";
            // 
            // lb_Image
            // 
            this.lb_Image.AutoSize = true;
            this.lb_Image.Location = new System.Drawing.Point(1000, 26);
            this.lb_Image.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Image.Name = "lb_Image";
            this.lb_Image.Size = new System.Drawing.Size(96, 20);
            this.lb_Image.TabIndex = 0;
            this.lb_Image.Text = "Ảnh thiết bị:";
            // 
            // DeviceId
            // 
            this.DeviceId.DataPropertyName = "Id";
            this.DeviceId.HeaderText = "Id";
            this.DeviceId.MinimumWidth = 6;
            this.DeviceId.Name = "DeviceId";
            this.DeviceId.ReadOnly = true;
            this.DeviceId.Visible = false;
            // 
            // Brand
            // 
            this.Brand.HeaderText = "Thương hiệu";
            this.Brand.MinimumWidth = 6;
            this.Brand.Name = "Brand";
            this.Brand.ReadOnly = true;
            // 
            // DeviceDetail
            // 
            this.DeviceDetail.FillWeight = 79.3672F;
            this.DeviceDetail.HeaderText = "Thông số chi tiết";
            this.DeviceDetail.MinimumWidth = 6;
            this.DeviceDetail.Name = "DeviceDetail";
            // 
            // SpecsId
            // 
            this.SpecsId.HeaderText = "Thông số";
            this.SpecsId.MinimumWidth = 6;
            this.SpecsId.Name = "SpecsId";
            this.SpecsId.Visible = false;
            // 
            // WarrantyPeriob
            // 
            this.WarrantyPeriob.DataPropertyName = "WarrantyPeriod";
            this.WarrantyPeriob.FillWeight = 79.3672F;
            this.WarrantyPeriob.HeaderText = "Hạn bảo hành";
            this.WarrantyPeriob.MinimumWidth = 6;
            this.WarrantyPeriob.Name = "WarrantyPeriob";
            this.WarrantyPeriob.ReadOnly = true;
            // 
            // CreatedDate
            // 
            this.CreatedDate.DataPropertyName = "CreatedDate";
            this.CreatedDate.FillWeight = 79.3672F;
            this.CreatedDate.HeaderText = "Ngày mua";
            this.CreatedDate.MinimumWidth = 6;
            this.CreatedDate.Name = "CreatedDate";
            this.CreatedDate.ReadOnly = true;
            // 
            // Note
            // 
            this.Note.DataPropertyName = "Note";
            this.Note.FillWeight = 79.3672F;
            this.Note.HeaderText = "Mô tả";
            this.Note.MinimumWidth = 6;
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
            // 
            // DeviceName
            // 
            this.DeviceName.DataPropertyName = "Name";
            this.DeviceName.FillWeight = 79.3672F;
            this.DeviceName.HeaderText = "Tên thiết bị";
            this.DeviceName.MinimumWidth = 6;
            this.DeviceName.Name = "DeviceName";
            this.DeviceName.ReadOnly = true;
            // 
            // DeviceImage
            // 
            this.DeviceImage.DataPropertyName = "Image";
            this.DeviceImage.FillWeight = 79.3672F;
            this.DeviceImage.HeaderText = "Thiết bị";
            this.DeviceImage.MinimumWidth = 6;
            this.DeviceImage.Name = "DeviceImage";
            this.DeviceImage.ReadOnly = true;
            this.DeviceImage.Visible = false;
            // 
            // dtgvQlThietBi
            // 
            this.dtgvQlThietBi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvQlThietBi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dtgvQlThietBi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvQlThietBi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DeviceImage,
            this.DeviceName,
            this.Note,
            this.CreatedDate,
            this.WarrantyPeriob,
            this.SpecsId,
            this.DeviceDetail,
            this.Brand,
            this.DeviceId});
            this.dtgvQlThietBi.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtgvQlThietBi.Location = new System.Drawing.Point(0, 434);
            this.dtgvQlThietBi.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvQlThietBi.Name = "dtgvQlThietBi";
            this.dtgvQlThietBi.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtgvQlThietBi.RowTemplate.Height = 33;
            this.dtgvQlThietBi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvQlThietBi.Size = new System.Drawing.Size(1257, 303);
            this.dtgvQlThietBi.TabIndex = 2;
            this.dtgvQlThietBi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvQlThietBi_CellClick);
            // 
            // frmQuanLyThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 739);
            this.Controls.Add(this.dtgvQlThietBi);
            this.Controls.Add(this.gbThongtinTB);
            this.Controls.Add(this.lblQLTbi);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmQuanLyThietBi";
            this.Text = "QuanLyThietBi";
            this.gbThongtinTB.ResumeLayout(false);
            this.gbThongtinTB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Device)).EndInit();
            this.gbTimKiemTbi.ResumeLayout(false);
            this.gbTimKiemTbi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQlThietBi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQLTbi;
        private System.Windows.Forms.GroupBox gbThongtinTB;
        private System.Windows.Forms.ComboBox cbNhaCungCap;
        private System.Windows.Forms.ComboBox cbLoaiTbi;
        private System.Windows.Forms.TextBox txtTenTbi;
        private System.Windows.Forms.Label lblNhaCungCap;
        private System.Windows.Forms.Label lblLoaiTbi;
        private System.Windows.Forms.Label lblTenTBi;
        private System.Windows.Forms.Label lb_Image;
        private System.Windows.Forms.RichTextBox rtbGhiChuTbi;
        private System.Windows.Forms.Label lblGhiChuTbi;
        private System.Windows.Forms.DateTimePicker dtBaoHanh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.ComboBox cbPhong;
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.Button btnXoaTbi;
        private System.Windows.Forms.Button btnSuaTbi;
        private System.Windows.Forms.Button btnThemTbi;
        private System.Windows.Forms.GroupBox gbTimKiemTbi;
        private System.Windows.Forms.Button btnTimKiemTbi;
        private System.Windows.Forms.TextBox txtTiemKiemTbi;
        private System.Windows.Forms.PictureBox ptb_Device;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.DateTimePicker dtp_DateBuy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewButtonColumn DeviceDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpecsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn WarrantyPeriob;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceName;
        private System.Windows.Forms.DataGridViewImageColumn DeviceImage;
        private System.Windows.Forms.DataGridView dtgvQlThietBi;
    }
}