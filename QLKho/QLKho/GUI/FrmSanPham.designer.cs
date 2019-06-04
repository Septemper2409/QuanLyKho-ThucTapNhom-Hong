namespace QLKho.GUI
{
    partial class FrmSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSanPham));
            this.txtGiasp = new System.Windows.Forms.TextBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnRefesh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSanPham = new System.Windows.Forms.Label();
            this.lblgia = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtSoluongsp = new System.Windows.Forms.TextBox();
            this.txtTensp = new System.Windows.Forms.TextBox();
            this.lbltsKT = new System.Windows.Forms.Label();
            this.lblsoLuong = new System.Windows.Forms.Label();
            this.lbltenSP = new System.Windows.Forms.Label();
            this.lblmaSP = new System.Windows.Forms.Label();
            this.dgvSanpham = new System.Windows.Forms.DataGridView();
            this.MA_SP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEN_SP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MA_NCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THONGSO_KT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtThongsokt = new System.Windows.Forms.TextBox();
            this.btnback = new System.Windows.Forms.Button();
            this.lblGetMa = new System.Windows.Forms.Label();
            this.cboMancc = new System.Windows.Forms.ComboBox();
            this.lblmaNCC = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanpham)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtGiasp
            // 
            this.txtGiasp.Location = new System.Drawing.Point(195, 176);
            this.txtGiasp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGiasp.Multiline = true;
            this.txtGiasp.Name = "txtGiasp";
            this.txtGiasp.Size = new System.Drawing.Size(231, 37);
            this.txtGiasp.TabIndex = 2;
            // 
            // btnHuy
            // 
            this.btnHuy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHuy.BackgroundImage")));
            this.btnHuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHuy.Location = new System.Drawing.Point(714, 16);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(115, 74);
            this.btnHuy.TabIndex = 16;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.BackgroundImage")));
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnXoa.Location = new System.Drawing.Point(380, 16);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(125, 74);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSua.BackgroundImage")));
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSua.Location = new System.Drawing.Point(557, 16);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(110, 74);
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
            this.btnThem.Location = new System.Drawing.Point(210, 16);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(118, 74);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnRefesh
            // 
            this.btnRefesh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefesh.BackgroundImage")));
            this.btnRefesh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRefesh.Location = new System.Drawing.Point(51, 16);
            this.btnRefesh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(117, 74);
            this.btnRefesh.TabIndex = 12;
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
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSearch.Location = new System.Drawing.Point(532, 164);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(123, 57);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblSanPham
            // 
            this.lblSanPham.AutoSize = true;
            this.lblSanPham.BackColor = System.Drawing.Color.Transparent;
            this.lblSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSanPham.ForeColor = System.Drawing.Color.Transparent;
            this.lblSanPham.Location = new System.Drawing.Point(402, 16);
            this.lblSanPham.Name = "lblSanPham";
            this.lblSanPham.Size = new System.Drawing.Size(197, 38);
            this.lblSanPham.TabIndex = 1;
            this.lblSanPham.Text = "SẢN PHẨM";
            // 
            // lblgia
            // 
            this.lblgia.AutoSize = true;
            this.lblgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgia.ForeColor = System.Drawing.SystemColors.Control;
            this.lblgia.Location = new System.Drawing.Point(6, 188);
            this.lblgia.Name = "lblgia";
            this.lblgia.Size = new System.Drawing.Size(122, 25);
            this.lblgia.TabIndex = 17;
            this.lblgia.Text = "Thành tiền:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(756, 164);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(241, 37);
            this.txtSearch.TabIndex = 6;
            // 
            // txtSoluongsp
            // 
            this.txtSoluongsp.Location = new System.Drawing.Point(195, 124);
            this.txtSoluongsp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoluongsp.Multiline = true;
            this.txtSoluongsp.Name = "txtSoluongsp";
            this.txtSoluongsp.Size = new System.Drawing.Size(231, 44);
            this.txtSoluongsp.TabIndex = 3;
            this.txtSoluongsp.TextChanged += new System.EventHandler(this.txtSoluongsp_TextChanged);
            // 
            // txtTensp
            // 
            this.txtTensp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTensp.Location = new System.Drawing.Point(195, 80);
            this.txtTensp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTensp.Multiline = true;
            this.txtTensp.Name = "txtTensp";
            this.txtTensp.Size = new System.Drawing.Size(231, 36);
            this.txtTensp.TabIndex = 1;
            // 
            // lbltsKT
            // 
            this.lbltsKT.AutoSize = true;
            this.lbltsKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltsKT.ForeColor = System.Drawing.SystemColors.Control;
            this.lbltsKT.Location = new System.Drawing.Point(527, 45);
            this.lbltsKT.Name = "lbltsKT";
            this.lbltsKT.Size = new System.Drawing.Size(151, 25);
            this.lbltsKT.TabIndex = 4;
            this.lbltsKT.Text = "Thông số KT: ";
            // 
            // lblsoLuong
            // 
            this.lblsoLuong.AutoSize = true;
            this.lblsoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsoLuong.ForeColor = System.Drawing.SystemColors.Control;
            this.lblsoLuong.Location = new System.Drawing.Point(6, 143);
            this.lblsoLuong.Name = "lblsoLuong";
            this.lblsoLuong.Size = new System.Drawing.Size(124, 25);
            this.lblsoLuong.TabIndex = 3;
            this.lblsoLuong.Text = "Số Lượng : ";
            // 
            // lbltenSP
            // 
            this.lbltenSP.AutoSize = true;
            this.lbltenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltenSP.ForeColor = System.Drawing.SystemColors.Control;
            this.lbltenSP.Location = new System.Drawing.Point(6, 91);
            this.lbltenSP.Name = "lbltenSP";
            this.lbltenSP.Size = new System.Drawing.Size(175, 25);
            this.lbltenSP.TabIndex = 2;
            this.lbltenSP.Text = "Tên Sản Phẩm : ";
            // 
            // lblmaSP
            // 
            this.lblmaSP.AutoSize = true;
            this.lblmaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmaSP.ForeColor = System.Drawing.SystemColors.Control;
            this.lblmaSP.Location = new System.Drawing.Point(6, 45);
            this.lblmaSP.Name = "lblmaSP";
            this.lblmaSP.Size = new System.Drawing.Size(167, 25);
            this.lblmaSP.TabIndex = 1;
            this.lblmaSP.Text = "Mã Sản Phẩm : ";
            // 
            // dgvSanpham
            // 
            this.dgvSanpham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanpham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MA_SP,
            this.TEN_SP,
            this.MA_NCC,
            this.THONGSO_KT,
            this.GIA,
            this.SOLUONG});
            this.dgvSanpham.Location = new System.Drawing.Point(11, 18);
            this.dgvSanpham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSanpham.Name = "dgvSanpham";
            this.dgvSanpham.RowHeadersVisible = false;
            this.dgvSanpham.RowTemplate.Height = 24;
            this.dgvSanpham.Size = new System.Drawing.Size(1047, 249);
            this.dgvSanpham.TabIndex = 0;
            this.dgvSanpham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanpham_CellContentClick);
            // 
            // MA_SP
            // 
            this.MA_SP.DataPropertyName = "maSP";
            this.MA_SP.HeaderText = "Mã Sản Phẩm";
            this.MA_SP.Name = "MA_SP";
            // 
            // TEN_SP
            // 
            this.TEN_SP.DataPropertyName = "tenSP";
            this.TEN_SP.HeaderText = "Tên Sản Phẩm";
            this.TEN_SP.Name = "TEN_SP";
            // 
            // MA_NCC
            // 
            this.MA_NCC.DataPropertyName = "maNCC";
            this.MA_NCC.HeaderText = "Mã Nhà Cung Cấp";
            this.MA_NCC.Name = "MA_NCC";
            // 
            // THONGSO_KT
            // 
            this.THONGSO_KT.DataPropertyName = "tsKT";
            this.THONGSO_KT.HeaderText = "Thông Số Kỹ Thuật";
            this.THONGSO_KT.Name = "THONGSO_KT";
            // 
            // GIA
            // 
            this.GIA.DataPropertyName = "gia";
            this.GIA.HeaderText = "Đơn Giá";
            this.GIA.Name = "GIA";
            // 
            // SOLUONG
            // 
            this.SOLUONG.DataPropertyName = "soLuong";
            this.SOLUONG.HeaderText = "Số Lượng";
            this.SOLUONG.Name = "SOLUONG";
            // 
            // txtThongsokt
            // 
            this.txtThongsokt.Location = new System.Drawing.Point(756, 34);
            this.txtThongsokt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtThongsokt.Multiline = true;
            this.txtThongsokt.Name = "txtThongsokt";
            this.txtThongsokt.Size = new System.Drawing.Size(241, 36);
            this.txtThongsokt.TabIndex = 4;
            // 
            // btnback
            // 
            this.btnback.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnback.BackgroundImage")));
            this.btnback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnback.Location = new System.Drawing.Point(883, 16);
            this.btnback.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(114, 74);
            this.btnback.TabIndex = 21;
            this.btnback.Text = "Thoát";
            this.btnback.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click_1);
            // 
            // lblGetMa
            // 
            this.lblGetMa.AutoSize = true;
            this.lblGetMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGetMa.ForeColor = System.Drawing.SystemColors.Control;
            this.lblGetMa.Location = new System.Drawing.Point(190, 45);
            this.lblGetMa.Name = "lblGetMa";
            this.lblGetMa.Size = new System.Drawing.Size(24, 25);
            this.lblGetMa.TabIndex = 20;
            this.lblGetMa.Text = "1";
            // 
            // cboMancc
            // 
            this.cboMancc.FormattingEnabled = true;
            this.cboMancc.Location = new System.Drawing.Point(756, 103);
            this.cboMancc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboMancc.Name = "cboMancc";
            this.cboMancc.Size = new System.Drawing.Size(241, 27);
            this.cboMancc.TabIndex = 5;
            this.cboMancc.SelectedIndexChanged += new System.EventHandler(this.cboMancc_SelectedIndexChanged);
            // 
            // lblmaNCC
            // 
            this.lblmaNCC.AutoSize = true;
            this.lblmaNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmaNCC.ForeColor = System.Drawing.SystemColors.Control;
            this.lblmaNCC.Location = new System.Drawing.Point(527, 105);
            this.lblmaNCC.Name = "lblmaNCC";
            this.lblmaNCC.Size = new System.Drawing.Size(210, 25);
            this.lblmaNCC.TabIndex = 19;
            this.lblmaNCC.Text = "Mã Nhà Cung Cấp : ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.btnback);
            this.panel3.Controls.Add(this.btnHuy);
            this.panel3.Controls.Add(this.btnRefesh);
            this.panel3.Controls.Add(this.btnXoa);
            this.panel3.Controls.Add(this.btnSua);
            this.panel3.Controls.Add(this.btnThem);
            this.panel3.Location = new System.Drawing.Point(12, 351);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1071, 109);
            this.panel3.TabIndex = 81;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.dgvSanpham);
            this.panel4.Location = new System.Drawing.Point(12, 466);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1071, 281);
            this.panel4.TabIndex = 82;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.lblmaSP);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.lblGetMa);
            this.groupBox1.Controls.Add(this.cboMancc);
            this.groupBox1.Controls.Add(this.lbltenSP);
            this.groupBox1.Controls.Add(this.lblmaNCC);
            this.groupBox1.Controls.Add(this.txtTensp);
            this.groupBox1.Controls.Add(this.lblsoLuong);
            this.groupBox1.Controls.Add(this.txtThongsokt);
            this.groupBox1.Controls.Add(this.txtGiasp);
            this.groupBox1.Controls.Add(this.lbltsKT);
            this.groupBox1.Controls.Add(this.txtSoluongsp);
            this.groupBox1.Controls.Add(this.lblgia);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(12, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1071, 251);
            this.groupBox1.TabIndex = 83;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sản phẩm";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.lblSanPham);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1071, 76);
            this.panel1.TabIndex = 84;
            // 
            // FrmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1107, 759);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FrmSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Sản Phẩm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanpham)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtGiasp;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnRefesh;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSanPham;
        private System.Windows.Forms.Label lblgia;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtSoluongsp;
        private System.Windows.Forms.TextBox txtTensp;
        private System.Windows.Forms.Label lbltsKT;
        private System.Windows.Forms.Label lblsoLuong;
        private System.Windows.Forms.Label lbltenSP;
        private System.Windows.Forms.Label lblmaSP;
        private System.Windows.Forms.DataGridView dgvSanpham;
        private System.Windows.Forms.TextBox txtThongsokt;
        private System.Windows.Forms.ComboBox cboMancc;
        private System.Windows.Forms.Label lblmaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MA_SP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEN_SP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MA_NCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn THONGSO_KT;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
        private System.Windows.Forms.Label lblGetMa;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
    }
}