namespace QLKho.GUI
{
    partial class FrmPhieuNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPhieuNhap));
            this.lblMaPhieu = new System.Windows.Forms.Label();
            this.cboMaNhanVien = new System.Windows.Forms.ComboBox();
            this.dtpNgaynhap = new System.Windows.Forms.DateTimePicker();
            this.cboMaNhaCungCap = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnChiTietPhieuNhap = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnRefesh = new System.Windows.Forms.Button();
            this.dgvDanhSachPhieuNhap = new System.Windows.Forms.DataGridView();
            this.MaPhieuNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPhieuNhap)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMaPhieu
            // 
            this.lblMaPhieu.AutoSize = true;
            this.lblMaPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPhieu.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMaPhieu.Location = new System.Drawing.Point(196, 47);
            this.lblMaPhieu.Name = "lblMaPhieu";
            this.lblMaPhieu.Size = new System.Drawing.Size(24, 25);
            this.lblMaPhieu.TabIndex = 28;
            this.lblMaPhieu.Text = "0";
            this.lblMaPhieu.Click += new System.EventHandler(this.lblMaPhieu_Click);
            // 
            // cboMaNhanVien
            // 
            this.cboMaNhanVien.FormattingEnabled = true;
            this.cboMaNhanVien.Location = new System.Drawing.Point(812, 103);
            this.cboMaNhanVien.Name = "cboMaNhanVien";
            this.cboMaNhanVien.Size = new System.Drawing.Size(162, 27);
            this.cboMaNhanVien.TabIndex = 24;
            this.cboMaNhanVien.SelectedIndexChanged += new System.EventHandler(this.cboMaNhanVien_SelectedIndexChanged);
            // 
            // dtpNgaynhap
            // 
            this.dtpNgaynhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaynhap.Location = new System.Drawing.Point(201, 102);
            this.dtpNgaynhap.Name = "dtpNgaynhap";
            this.dtpNgaynhap.Size = new System.Drawing.Size(153, 27);
            this.dtpNgaynhap.TabIndex = 20;
            // 
            // cboMaNhaCungCap
            // 
            this.cboMaNhaCungCap.FormattingEnabled = true;
            this.cboMaNhaCungCap.Location = new System.Drawing.Point(812, 49);
            this.cboMaNhaCungCap.Name = "cboMaNhaCungCap";
            this.cboMaNhaCungCap.Size = new System.Drawing.Size(162, 27);
            this.cboMaNhaCungCap.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(609, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 25);
            this.label7.TabIndex = 26;
            this.label7.Text = "Mã Nhà CC :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(41, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = "Ngày nhập : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(609, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "Mã Nhân Viên : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(41, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Mã Phiếu : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(305, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH SÁCH PHIẾU NHẬP";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(844, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 71);
            this.button1.TabIndex = 22;
            this.button1.Text = "Thoát";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnChiTietPhieuNhap
            // 
            this.btnChiTietPhieuNhap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChiTietPhieuNhap.BackgroundImage")));
            this.btnChiTietPhieuNhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnChiTietPhieuNhap.Location = new System.Drawing.Point(694, 14);
            this.btnChiTietPhieuNhap.Name = "btnChiTietPhieuNhap";
            this.btnChiTietPhieuNhap.Size = new System.Drawing.Size(132, 70);
            this.btnChiTietPhieuNhap.TabIndex = 27;
            this.btnChiTietPhieuNhap.Text = "Chi tiết phiếu\r\n";
            this.btnChiTietPhieuNhap.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnChiTietPhieuNhap.UseVisualStyleBackColor = true;
            this.btnChiTietPhieuNhap.Click += new System.EventHandler(this.btnChiTietPhieuNhap_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.BackgroundImage")));
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnXoa.Location = new System.Drawing.Point(370, 13);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(121, 71);
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
            this.btnSua.Location = new System.Drawing.Point(538, 13);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(122, 71);
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
            this.btnThem.Location = new System.Drawing.Point(201, 13);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(133, 71);
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
            this.btnRefesh.Location = new System.Drawing.Point(49, 13);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(119, 71);
            this.btnRefesh.TabIndex = 12;
            this.btnRefesh.Text = "Refresh";
            this.btnRefesh.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnRefesh.UseVisualStyleBackColor = true;
            this.btnRefesh.Click += new System.EventHandler(this.btnRefesh_Click);
            // 
            // dgvDanhSachPhieuNhap
            // 
            this.dgvDanhSachPhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachPhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhieuNhap,
            this.MaNhanVien,
            this.MaNhaCungCap,
            this.NgayNhap});
            this.dgvDanhSachPhieuNhap.Location = new System.Drawing.Point(17, 13);
            this.dgvDanhSachPhieuNhap.Name = "dgvDanhSachPhieuNhap";
            this.dgvDanhSachPhieuNhap.RowHeadersVisible = false;
            this.dgvDanhSachPhieuNhap.RowTemplate.Height = 24;
            this.dgvDanhSachPhieuNhap.Size = new System.Drawing.Size(1037, 243);
            this.dgvDanhSachPhieuNhap.TabIndex = 0;
            // 
            // MaPhieuNhap
            // 
            this.MaPhieuNhap.DataPropertyName = "MaPhieuNhap";
            this.MaPhieuNhap.HeaderText = "Mã phiếu nhập";
            this.MaPhieuNhap.Name = "MaPhieuNhap";
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.DataPropertyName = "MaNhanVien";
            this.MaNhanVien.HeaderText = "Mã nhân viên";
            this.MaNhanVien.Name = "MaNhanVien";
            // 
            // MaNhaCungCap
            // 
            this.MaNhaCungCap.DataPropertyName = "MaNhaCungCap";
            this.MaNhaCungCap.HeaderText = "Mã nhà cung cấp";
            this.MaNhaCungCap.Name = "MaNhaCungCap";
            // 
            // NgayNhap
            // 
            this.NgayNhap.DataPropertyName = "NgayNhap";
            this.NgayNhap.HeaderText = "Ngày nhập";
            this.NgayNhap.Name = "NgayNhap";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.btnRefesh);
            this.panel3.Controls.Add(this.btnChiTietPhieuNhap);
            this.panel3.Controls.Add(this.btnXoa);
            this.panel3.Controls.Add(this.btnSua);
            this.panel3.Controls.Add(this.btnThem);
            this.panel3.Location = new System.Drawing.Point(15, 269);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1063, 105);
            this.panel3.TabIndex = 83;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.dgvDanhSachPhieuNhap);
            this.panel4.Location = new System.Drawing.Point(15, 380);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1063, 288);
            this.panel4.TabIndex = 84;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboMaNhanVien);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblMaPhieu);
            this.groupBox1.Controls.Add(this.cboMaNhaCungCap);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dtpNgaynhap);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(15, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1063, 168);
            this.groupBox1.TabIndex = 85;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu nhập";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1066, 77);
            this.panel1.TabIndex = 86;
            // 
            // FrmPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1107, 694);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmPhieuNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DANH SÁCH PHIẾU NHẬP";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPhieuNhap)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDanhSachPhieuNhap;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnRefesh;
        private System.Windows.Forms.ComboBox cboMaNhanVien;
        private System.Windows.Forms.DateTimePicker dtpNgaynhap;
        private System.Windows.Forms.ComboBox cboMaNhaCungCap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnChiTietPhieuNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieuNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhap;
        private System.Windows.Forms.Label lblMaPhieu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
    }
}