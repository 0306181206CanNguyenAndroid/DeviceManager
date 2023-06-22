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
            this.cbPhong = new System.Windows.Forms.ComboBox();
            this.lblPhong = new System.Windows.Forms.Label();
            this.cbNhaCungCap = new System.Windows.Forms.ComboBox();
            this.cbLoaiTbi = new System.Windows.Forms.ComboBox();
            this.txtTenTbi = new System.Windows.Forms.TextBox();
            this.lblNhaCungCap = new System.Windows.Forms.Label();
            this.lblLoaiTbi = new System.Windows.Forms.Label();
            this.lblTenTBi = new System.Windows.Forms.Label();
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
            lblQLTbi.AutoSize = true;
            lblQLTbi.Dock = System.Windows.Forms.DockStyle.Top;
            lblQLTbi.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblQLTbi.Location = new System.Drawing.Point(0, 0);
            lblQLTbi.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            lblQLTbi.Name = "lblQLTbi";
            lblQLTbi.Size = new System.Drawing.Size(248, 41);
            lblQLTbi.TabIndex = 0;
            lblQLTbi.Text = "Quản Lý Thiết Bị";
            // 
            // gbThongtinTB
            // 
            this.gbThongtinTB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gbThongtinTB.Controls.Add(this.cbPhong);
            this.gbThongtinTB.Controls.Add(this.lblPhong);
            this.gbThongtinTB.Controls.Add(this.cbNhaCungCap);
            this.gbThongtinTB.Controls.Add(this.cbLoaiTbi);
            this.gbThongtinTB.Controls.Add(this.txtTenTbi);
            this.gbThongtinTB.Controls.Add(this.lblNhaCungCap);
            this.gbThongtinTB.Controls.Add(this.lblLoaiTbi);
            this.gbThongtinTB.Controls.Add(this.lblTenTBi);
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

            // 
            // cbPhong
            // 
            this.cbPhong.FormattingEnabled = true;
            this.cbPhong.Location = new System.Drawing.Point(1049, 100);
            this.cbPhong.Margin = new System.Windows.Forms.Padding(2);
            this.cbPhong.Name = "cbPhong";
            this.cbPhong.Size = new System.Drawing.Size(197, 28);
            this.cbPhong.TabIndex = 23;
            // 
            // lblPhong
            // 
            this.lblPhong.AutoSize = true;
            this.lblPhong.Location = new System.Drawing.Point(933, 103);
            this.lblPhong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(62, 20);
            this.lblPhong.TabIndex = 24;
            this.lblPhong.Text = "Phòng :";
            // 
            // cbNhaCungCap
            // 
            this.cbNhaCungCap.FormattingEnabled = true;
            this.cbNhaCungCap.Location = new System.Drawing.Point(355, 171);
            this.cbNhaCungCap.Margin = new System.Windows.Forms.Padding(2);
            this.cbNhaCungCap.Name = "cbNhaCungCap";
            this.cbNhaCungCap.Size = new System.Drawing.Size(174, 28);
            this.cbNhaCungCap.TabIndex = 22;
            // 
            // cbLoaiTbi
            // 
            this.cbLoaiTbi.FormattingEnabled = true;
            this.cbLoaiTbi.Location = new System.Drawing.Point(355, 100);
            this.cbLoaiTbi.Margin = new System.Windows.Forms.Padding(2);
            this.cbLoaiTbi.Name = "cbLoaiTbi";
            this.cbLoaiTbi.Size = new System.Drawing.Size(174, 28);
            this.cbLoaiTbi.TabIndex = 20;
            // 
            // txtTenTbi
            // 
            this.txtTenTbi.Location = new System.Drawing.Point(355, 30);
            this.txtTenTbi.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenTbi.Name = "txtTenTbi";
            this.txtTenTbi.Size = new System.Drawing.Size(174, 27);
            this.txtTenTbi.TabIndex = 18;
            // 
            // lblNhaCungCap
            // 
            this.lblNhaCungCap.AutoSize = true;
            this.lblNhaCungCap.Location = new System.Drawing.Point(239, 174);
            this.lblNhaCungCap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNhaCungCap.Name = "lblNhaCungCap";
            this.lblNhaCungCap.Size = new System.Drawing.Size(106, 20);
            this.lblNhaCungCap.TabIndex = 21;
            this.lblNhaCungCap.Text = "Thương hiệu :";
            // 
            // lblLoaiTbi
            // 
            this.lblLoaiTbi.AutoSize = true;
            this.lblLoaiTbi.Location = new System.Drawing.Point(237, 103);
            this.lblLoaiTbi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoaiTbi.Name = "lblLoaiTbi";
            this.lblLoaiTbi.Size = new System.Drawing.Size(100, 20);
            this.lblLoaiTbi.TabIndex = 19;
            this.lblLoaiTbi.Text = "Loại thiết bị :";
            // 
            // lblTenTBi
            // 
            this.lblTenTBi.AutoSize = true;
            this.lblTenTBi.Location = new System.Drawing.Point(239, 35);
            this.lblTenTBi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenTBi.Name = "lblTenTBi";
            this.lblTenTBi.Size = new System.Drawing.Size(96, 20);
            this.lblTenTBi.TabIndex = 17;
            this.lblTenTBi.Text = "Tên thiết bị :";
            // 
            // txtPrice
            // 

            this.txtPrice.Location = new System.Drawing.Point(1033, 171);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(213, 27);
            this.txtPrice.TabIndex = 16;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Price_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(933, 174);
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
            this.btnDetail.Location = new System.Drawing.Point(1076, 310);
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
            this.ptb_Device.Location = new System.Drawing.Point(11, 80);
            this.ptb_Device.Name = "ptb_Device";
            this.ptb_Device.Size = new System.Drawing.Size(200, 200);
            this.ptb_Device.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_Device.TabIndex = 13;
            this.ptb_Device.TabStop = false;
            this.toolTip1.SetToolTip(this.ptb_Device, "Nhấn đúp để tải ảnh");
            this.ptb_Device.DoubleClick += new System.EventHandler(this.ptb_Device_DoubleClick);
            // 
            // gbTimKiemTbi
            // 
            this.gbTimKiemTbi.Controls.Add(this.dtp_DateBuy);
            this.gbTimKiemTbi.Controls.Add(this.label2);
            this.gbTimKiemTbi.Controls.Add(this.btnTimKiemTbi);
            this.gbTimKiemTbi.Controls.Add(this.txtTiemKiemTbi);
            this.gbTimKiemTbi.Location = new System.Drawing.Point(5, 289);
            this.gbTimKiemTbi.Margin = new System.Windows.Forms.Padding(2);
            this.gbTimKiemTbi.Name = "gbTimKiemTbi";
            this.gbTimKiemTbi.Padding = new System.Windows.Forms.Padding(2);
            this.gbTimKiemTbi.Size = new System.Drawing.Size(873, 75);
            this.gbTimKiemTbi.TabIndex = 12;
            this.gbTimKiemTbi.TabStop = false;
            this.gbTimKiemTbi.Text = "Tìm kiếm thiết bị";
            // 
            // dtp_DateBuy
            // 
            this.dtp_DateBuy.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_DateBuy.Location = new System.Drawing.Point(592, 30);
            this.dtp_DateBuy.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_DateBuy.Name = "dtp_DateBuy";
            this.dtp_DateBuy.Size = new System.Drawing.Size(216, 27);
            this.dtp_DateBuy.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(451, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Ngày mua :";
            // 
            // btnTimKiemTbi
            // 
            this.btnTimKiemTbi.BackColor = System.Drawing.Color.Transparent;
            this.btnTimKiemTbi.BackgroundImage = global::DeviceManagerApp.Properties.Resources.search;
            this.btnTimKiemTbi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTimKiemTbi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiemTbi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTimKiemTbi.Location = new System.Drawing.Point(241, 34);
            this.btnTimKiemTbi.Margin = new System.Windows.Forms.Padding(10);
            this.btnTimKiemTbi.Name = "btnTimKiemTbi";
            this.btnTimKiemTbi.Padding = new System.Windows.Forms.Padding(5);
            this.btnTimKiemTbi.Size = new System.Drawing.Size(40, 27);
            this.btnTimKiemTbi.TabIndex = 13;
            this.toolTip1.SetToolTip(this.btnTimKiemTbi, "Tìm kiếm");
            this.btnTimKiemTbi.UseVisualStyleBackColor = false;
            // 
            // txtTiemKiemTbi
            // 
            this.txtTiemKiemTbi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTiemKiemTbi.Location = new System.Drawing.Point(6, 34);
            this.txtTiemKiemTbi.Margin = new System.Windows.Forms.Padding(2);
            this.txtTiemKiemTbi.Name = "txtTiemKiemTbi";
            this.txtTiemKiemTbi.Size = new System.Drawing.Size(223, 27);
            this.txtTiemKiemTbi.TabIndex = 12;
            // 
            // btnXoaTbi
            // 
            this.btnXoaTbi.BackColor = System.Drawing.Color.Transparent;
            this.btnXoaTbi.BackgroundImage = global::DeviceManagerApp.Properties.Resources.delete_pc1;
            this.btnXoaTbi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXoaTbi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaTbi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXoaTbi.Location = new System.Drawing.Point(457, 223);
            this.btnXoaTbi.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaTbi.Name = "btnXoaTbi";
            this.btnXoaTbi.Size = new System.Drawing.Size(72, 57);
            this.btnXoaTbi.TabIndex = 11;
            this.toolTip1.SetToolTip(this.btnXoaTbi, "Xóa");
            this.btnXoaTbi.UseVisualStyleBackColor = false;
            // 
            // btnSuaTbi
            // 
            this.btnSuaTbi.BackColor = System.Drawing.Color.Transparent;
            this.btnSuaTbi.BackgroundImage = global::DeviceManagerApp.Properties.Resources.edit_pc2;
            this.btnSuaTbi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSuaTbi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaTbi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSuaTbi.Location = new System.Drawing.Point(347, 223);
            this.btnSuaTbi.Margin = new System.Windows.Forms.Padding(2);
            this.btnSuaTbi.Name = "btnSuaTbi";
            this.btnSuaTbi.Size = new System.Drawing.Size(71, 57);
            this.btnSuaTbi.TabIndex = 10;
            this.toolTip1.SetToolTip(this.btnSuaTbi, "Cập nhật");
            this.btnSuaTbi.UseVisualStyleBackColor = false;
            // 
            // btnThemTbi
            // 
            this.btnThemTbi.BackColor = System.Drawing.Color.Transparent;
            this.btnThemTbi.BackgroundImage = global::DeviceManagerApp.Properties.Resources.add_device;
            this.btnThemTbi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThemTbi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemTbi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThemTbi.Location = new System.Drawing.Point(239, 223);
            this.btnThemTbi.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemTbi.Name = "btnThemTbi";
            this.btnThemTbi.Size = new System.Drawing.Size(67, 57);
            this.btnThemTbi.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnThemTbi, "Thêm thiết bị");
            this.btnThemTbi.UseVisualStyleBackColor = false;
            this.btnThemTbi.Click += new System.EventHandler(this.btnThemTbi_Click);
            // 
            // rtbGhiChuTbi
            // 
            this.rtbGhiChuTbi.Location = new System.Drawing.Point(670, 103);
            this.rtbGhiChuTbi.Margin = new System.Windows.Forms.Padding(2);
            this.rtbGhiChuTbi.Name = "rtbGhiChuTbi";
            this.rtbGhiChuTbi.Size = new System.Drawing.Size(208, 96);
            this.rtbGhiChuTbi.TabIndex = 8;
            this.rtbGhiChuTbi.Text = "";
            // 
            // lblGhiChuTbi
            // 
            this.lblGhiChuTbi.AutoSize = true;
            this.lblGhiChuTbi.Location = new System.Drawing.Point(597, 103);
            this.lblGhiChuTbi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGhiChuTbi.Name = "lblGhiChuTbi";
            this.lblGhiChuTbi.Size = new System.Drawing.Size(72, 20);
            this.lblGhiChuTbi.TabIndex = 8;
            this.lblGhiChuTbi.Text = "Ghi Chú :";
            // 
            // dtBaoHanh
            // 
            this.dtBaoHanh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBaoHanh.Location = new System.Drawing.Point(1072, 29);
            this.dtBaoHanh.Margin = new System.Windows.Forms.Padding(2);
            this.dtBaoHanh.Name = "dtBaoHanh";
            this.dtBaoHanh.Size = new System.Drawing.Size(174, 27);
            this.dtBaoHanh.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(933, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Hạn bảo hành :";
            // 
            // cbKhoa
            // 
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Location = new System.Drawing.Point(670, 31);
            this.cbKhoa.Margin = new System.Windows.Forms.Padding(2);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(208, 28);
            this.cbKhoa.TabIndex = 6;
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Location = new System.Drawing.Point(597, 34);
            this.lblKhoa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(53, 20);
            this.lblKhoa.TabIndex = 6;
            this.lblKhoa.Text = "Khoa :";
            // 
            // lb_Image
            // 
            this.lb_Image.AutoSize = true;
            this.lb_Image.Location = new System.Drawing.Point(11, 33);
            this.lb_Image.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Image.Name = "lb_Image";
            this.lb_Image.Size = new System.Drawing.Size(96, 20);
            this.lb_Image.TabIndex = 0;
            this.lb_Image.Text = "Ảnh thiết bị:";
            // 
            // DeviceId
            // 
            DeviceId.DataPropertyName = "Id";
            DeviceId.HeaderText = "Id";
            DeviceId.MinimumWidth = 6;
            DeviceId.Name = "DeviceId";
            DeviceId.ReadOnly = true;
            DeviceId.Visible = false;
            // 
            // Brand
            // 
            Brand.HeaderText = "Thương hiệu";
            Brand.MinimumWidth = 6;
            Brand.Name = "Brand";
            Brand.ReadOnly = true;
            // 
            // DeviceDetail
            // 
            DeviceDetail.FillWeight = 79.3672F;
            DeviceDetail.HeaderText = "Thông số chi tiết";
            DeviceDetail.MinimumWidth = 6;
            DeviceDetail.Name = "DeviceDetail";
            // 
            // SpecsId
            // 
            SpecsId.HeaderText = "Thông số";
            SpecsId.MinimumWidth = 6;
            SpecsId.Name = "SpecsId";
            SpecsId.Visible = false;
            // 
            // WarrantyPeriob
            // 
            WarrantyPeriob.DataPropertyName = "WarrantyPeriod";
            WarrantyPeriob.FillWeight = 79.3672F;
            WarrantyPeriob.HeaderText = "Hạn bảo hành";
            WarrantyPeriob.MinimumWidth = 6;
            WarrantyPeriob.Name = "WarrantyPeriob";
            WarrantyPeriob.ReadOnly = true;
            // 
            // CreatedDate
            // 
            CreatedDate.DataPropertyName = "CreatedDate";
            CreatedDate.FillWeight = 79.3672F;
            CreatedDate.HeaderText = "Ngày mua";
            CreatedDate.MinimumWidth = 6;
            CreatedDate.Name = "CreatedDate";
            CreatedDate.ReadOnly = true;
            // 
            // Note
            // 
            Note.DataPropertyName = "Note";
            Note.FillWeight = 79.3672F;
            Note.HeaderText = "Mô tả";
            Note.MinimumWidth = 6;
            Note.Name = "Note";
            Note.ReadOnly = true;
            // 
            // DeviceName
            // 
            DeviceName.DataPropertyName = "Name";
            DeviceName.FillWeight = 79.3672F;
            DeviceName.HeaderText = "Tên thiết bị";
            DeviceName.MinimumWidth = 6;
            DeviceName.Name = "DeviceName";
            DeviceName.ReadOnly = true;
            // 
            // DeviceImage
            // 
            DeviceImage.DataPropertyName = "Image";
            DeviceImage.FillWeight = 79.3672F;
            DeviceImage.HeaderText = "Thiết bị";
            DeviceImage.MinimumWidth = 6;
            DeviceImage.Name = "DeviceImage";
            DeviceImage.ReadOnly = true;
            DeviceImage.Visible = false;
            // 
            // dtgvQlThietBi
            // 
            dtgvQlThietBi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dtgvQlThietBi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dtgvQlThietBi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvQlThietBi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { DeviceImage, DeviceName, Note, CreatedDate, WarrantyPeriob, SpecsId, DeviceDetail, Brand, DeviceId });
            dtgvQlThietBi.Dock = System.Windows.Forms.DockStyle.Top;
            dtgvQlThietBi.Location = new System.Drawing.Point(0, 329);
            dtgvQlThietBi.Margin = new System.Windows.Forms.Padding(1);
            dtgvQlThietBi.Name = "dtgvQlThietBi";
            dtgvQlThietBi.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dtgvQlThietBi.RowTemplate.Height = 33;
            dtgvQlThietBi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dtgvQlThietBi.Size = new System.Drawing.Size(899, 227);
            dtgvQlThietBi.TabIndex = 2;
            dtgvQlThietBi.CellClick += dtgvQlThietBi_CellClick;
            // 
            // frmQuanLyThietBi
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(899, 421);
            Controls.Add(dtgvQlThietBi);
            Controls.Add(gbThongtinTB);
            Controls.Add(lblQLTbi);
            Margin = new System.Windows.Forms.Padding(1);
            Name = "frmQuanLyThietBi";
            Text = "QuanLyThietBi";
            gbThongtinTB.ResumeLayout(false);
            gbThongtinTB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptb_Device).EndInit();
            gbTimKiemTbi.ResumeLayout(false);
            gbTimKiemTbi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvQlThietBi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblQLTbi;
        private System.Windows.Forms.GroupBox gbThongtinTB;
        private System.Windows.Forms.Label lb_Image;
        private System.Windows.Forms.RichTextBox rtbGhiChuTbi;
        private System.Windows.Forms.Label lblGhiChuTbi;
        private System.Windows.Forms.DateTimePicker dtBaoHanh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.Label lblKhoa;
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
        private System.Windows.Forms.ComboBox cbPhong;
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.ComboBox cbNhaCungCap;
        private System.Windows.Forms.ComboBox cbLoaiTbi;
        private System.Windows.Forms.TextBox txtTenTbi;
        private System.Windows.Forms.Label lblNhaCungCap;
        private System.Windows.Forms.Label lblLoaiTbi;
        private System.Windows.Forms.Label lblTenTBi;
    }
}