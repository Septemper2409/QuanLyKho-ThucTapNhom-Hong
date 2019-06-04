namespace QLKho.GUI
{
    partial class FrmXuatSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmXuatSanPham));
            this.label1 = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Button();
            this.dgvXuatsanpham = new System.Windows.Forms.DataGridView();
            this.MAPX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYXUAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MACTPX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MACT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboManv = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dtpNgayxuat = new System.Windows.Forms.DateTimePicker();
            this.txtSoluongsp = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnRefesh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtGiasp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboTenSP = new System.Windows.Forms.ComboBox();
            this.lblChiTiet = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblMaPX = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXuatsanpham)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(362, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "XUẤT SẢN PHẨM";
            // 
            // btnback
            // 
            this.btnback.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnback.BackgroundImage")));
            this.btnback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnback.Location = new System.Drawing.Point(860, 18);
            this.btnback.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(123, 64);
            this.btnback.TabIndex = 20;
            this.btnback.Text = "Thoát";
            this.btnback.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // dgvXuatsanpham
            // 
            this.dgvXuatsanpham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvXuatsanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXuatsanpham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAPX,
            this.NGAYXUAT,
            this.HOTEN,
            this.TENSP,
            this.DONGIA,
            this.SOLUONG,
            this.MaSP,
            this.MACTPX,
            this.MANV,
            this.MACT});
            this.dgvXuatsanpham.Location = new System.Drawing.Point(18, 12);
            this.dgvXuatsanpham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvXuatsanpham.Name = "dgvXuatsanpham";
            this.dgvXuatsanpham.RowHeadersVisible = false;
            this.dgvXuatsanpham.RowTemplate.Height = 24;
            this.dgvXuatsanpham.Size = new System.Drawing.Size(1053, 246);
            this.dgvXuatsanpham.TabIndex = 0;
            // 
            // MAPX
            // 
            this.MAPX.DataPropertyName = "MAPX";
            this.MAPX.HeaderText = "Mã Phiếu Xuất";
            this.MAPX.Name = "MAPX";
            // 
            // NGAYXUAT
            // 
            this.NGAYXUAT.DataPropertyName = "NGAYXUAT";
            this.NGAYXUAT.HeaderText = "Ngày Xuất";
            this.NGAYXUAT.Name = "NGAYXUAT";
            // 
            // HOTEN
            // 
            this.HOTEN.DataPropertyName = "HOTEN";
            this.HOTEN.HeaderText = "Nhân Viên Xuất";
            this.HOTEN.Name = "HOTEN";
            // 
            // TENSP
            // 
            this.TENSP.DataPropertyName = "TENSP";
            this.TENSP.HeaderText = "Tên Sản Phẩm";
            this.TENSP.Name = "TENSP";
            // 
            // DONGIA
            // 
            this.DONGIA.DataPropertyName = "DONGIA";
            this.DONGIA.HeaderText = "Đơn Giá";
            this.DONGIA.Name = "DONGIA";
            // 
            // SOLUONG
            // 
            this.SOLUONG.DataPropertyName = "SOLUONG";
            this.SOLUONG.HeaderText = "Số Lượng";
            this.SOLUONG.Name = "SOLUONG";
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.HeaderText = "MaSP";
            this.MaSP.Name = "MaSP";
            this.MaSP.Visible = false;
            // 
            // MACTPX
            // 
            this.MACTPX.DataPropertyName = "MACTPX";
            this.MACTPX.HeaderText = "MACTPX";
            this.MACTPX.Name = "MACTPX";
            this.MACTPX.Visible = false;
            // 
            // MANV
            // 
            this.MANV.DataPropertyName = "MANV";
            this.MANV.HeaderText = "MANV";
            this.MANV.Name = "MANV";
            this.MANV.Visible = false;
            // 
            // MACT
            // 
            this.MACT.DataPropertyName = "MACT";
            this.MACT.HeaderText = "MACT";
            this.MACT.Name = "MACT";
            this.MACT.Visible = false;
            // 
            // cboManv
            // 
            this.cboManv.FormattingEnabled = true;
            this.cboManv.Location = new System.Drawing.Point(255, 175);
            this.cboManv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboManv.Name = "cboManv";
            this.cboManv.Size = new System.Drawing.Size(152, 27);
            this.cboManv.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(530, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Giá : ";
            // 
            // btnHuy
            // 
            this.btnHuy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHuy.BackgroundImage")));
            this.btnHuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHuy.Location = new System.Drawing.Point(707, 20);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(119, 62);
            this.btnHuy.TabIndex = 16;
            this.btnHuy.Text = " phiếu xuất mới";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.BackgroundImage")));
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnXoa.Location = new System.Drawing.Point(376, 18);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(131, 64);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dtpNgayxuat
            // 
            this.dtpNgayxuat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayxuat.Location = new System.Drawing.Point(255, 123);
            this.dtpNgayxuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgayxuat.Name = "dtpNgayxuat";
            this.dtpNgayxuat.Size = new System.Drawing.Size(147, 27);
            this.dtpNgayxuat.TabIndex = 1;
            // 
            // txtSoluongsp
            // 
            this.txtSoluongsp.Location = new System.Drawing.Point(747, 123);
            this.txtSoluongsp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoluongsp.Multiline = true;
            this.txtSoluongsp.Name = "txtSoluongsp";
            this.txtSoluongsp.Size = new System.Drawing.Size(196, 27);
            this.txtSoluongsp.TabIndex = 5;
            // 
            // btnSua
            // 
            this.btnSua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSua.BackgroundImage")));
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSua.Location = new System.Drawing.Point(549, 18);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(123, 64);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThem.BackgroundImage")));
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnThem.Location = new System.Drawing.Point(213, 18);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(121, 64);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnRefesh
            // 
            this.btnRefesh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefesh.BackgroundImage")));
            this.btnRefesh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefesh.Location = new System.Drawing.Point(42, 18);
            this.btnRefesh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(127, 64);
            this.btnRefesh.TabIndex = 8;
            this.btnRefesh.Text = "Refresh";
            this.btnRefesh.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnRefesh.UseVisualStyleBackColor = true;
            this.btnRefesh.Click += new System.EventHandler(this.btnRefesh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(535, 152);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(118, 57);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(747, 171);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(196, 31);
            this.txtSearch.TabIndex = 6;
            // 
            // txtGiasp
            // 
            this.txtGiasp.Enabled = false;
            this.txtGiasp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiasp.Location = new System.Drawing.Point(747, 76);
            this.txtGiasp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGiasp.Multiline = true;
            this.txtGiasp.Name = "txtGiasp";
            this.txtGiasp.Size = new System.Drawing.Size(196, 24);
            this.txtGiasp.TabIndex = 4;
            this.txtGiasp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(530, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên Sản Phẩm : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(19, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày xuất : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(19, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Phiếu : ";
            // 
            // cboTenSP
            // 
            this.cboTenSP.FormattingEnabled = true;
            this.cboTenSP.Location = new System.Drawing.Point(747, 33);
            this.cboTenSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboTenSP.Name = "cboTenSP";
            this.cboTenSP.Size = new System.Drawing.Size(196, 27);
            this.cboTenSP.TabIndex = 27;
            // 
            // lblChiTiet
            // 
            this.lblChiTiet.AutoSize = true;
            this.lblChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTiet.ForeColor = System.Drawing.SystemColors.Control;
            this.lblChiTiet.Location = new System.Drawing.Point(250, 75);
            this.lblChiTiet.Name = "lblChiTiet";
            this.lblChiTiet.Size = new System.Drawing.Size(24, 25);
            this.lblChiTiet.TabIndex = 26;
            this.lblChiTiet.Text = "1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(19, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(204, 25);
            this.label10.TabIndex = 25;
            this.label10.Text = "Mã Chi Tiết Phiếu : ";
            // 
            // lblMaPX
            // 
            this.lblMaPX.AutoSize = true;
            this.lblMaPX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPX.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMaPX.Location = new System.Drawing.Point(250, 32);
            this.lblMaPX.Name = "lblMaPX";
            this.lblMaPX.Size = new System.Drawing.Size(24, 25);
            this.lblMaPX.TabIndex = 24;
            this.lblMaPX.Text = "1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(530, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 25);
            this.label8.TabIndex = 23;
            this.label8.Text = "Số Lượng : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(19, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã Nhân Viên : ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.btnRefesh);
            this.panel3.Controls.Add(this.btnback);
            this.panel3.Controls.Add(this.btnThem);
            this.panel3.Controls.Add(this.btnSua);
            this.panel3.Controls.Add(this.btnXoa);
            this.panel3.Controls.Add(this.btnHuy);
            this.panel3.Location = new System.Drawing.Point(12, 324);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1091, 95);
            this.panel3.TabIndex = 85;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.dgvXuatsanpham);
            this.panel4.Location = new System.Drawing.Point(12, 434);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1091, 287);
            this.panel4.TabIndex = 86;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSoluongsp);
            this.groupBox1.Controls.Add(this.lblMaPX);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lblChiTiet);
            this.groupBox1.Controls.Add(this.cboTenSP);
            this.groupBox1.Controls.Add(this.txtGiasp);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpNgayxuat);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboManv);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(12, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1092, 225);
            this.groupBox1.TabIndex = 87;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin xuất sản phẩm";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1092, 67);
            this.panel1.TabIndex = 88;
            // 
            // FrmXuatSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1116, 732);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FrmXuatSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xuất Sản Phẩm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvXuatsanpham)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.DataGridView dgvXuatsanpham;
        private System.Windows.Forms.ComboBox cboManv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DateTimePicker dtpNgayxuat;
        private System.Windows.Forms.TextBox txtSoluongsp;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnRefesh;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtGiasp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblMaPX;
        private System.Windows.Forms.Label lblChiTiet;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPX;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYXUAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MACTPX;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MACT;
        private System.Windows.Forms.ComboBox cboTenSP;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
    }
}