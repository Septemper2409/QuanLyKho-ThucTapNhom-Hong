namespace QLKho.GUI
{
    partial class FrmPhieuNhapCT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPhieuNhapCT));
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnRefesh = new System.Windows.Forms.Button();
            this.dgvChiTietPhieuNhap = new System.Windows.Forms.DataGridView();
            this.MaChiTietPhieuNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhieuNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSua = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblMaChiTietPhieuNhap = new System.Windows.Forms.Label();
            this.lblMaPhieuNhap = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboMaSanPhan = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhieuNhap)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.BackgroundImage")));
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnXoa.Location = new System.Drawing.Point(402, 18);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(120, 67);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnRefesh
            // 
            this.btnRefesh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefesh.BackgroundImage")));
            this.btnRefesh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRefesh.Location = new System.Drawing.Point(61, 18);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(120, 67);
            this.btnRefesh.TabIndex = 12;
            this.btnRefesh.Text = "Refresh";
            this.btnRefesh.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnRefesh.UseVisualStyleBackColor = true;
            this.btnRefesh.Click += new System.EventHandler(this.btnRefesh_Click);
            // 
            // dgvChiTietPhieuNhap
            // 
            this.dgvChiTietPhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietPhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaChiTietPhieuNhap,
            this.MaPhieuNhap,
            this.MaSanPham,
            this.SoLuong,
            this.DonGia});
            this.dgvChiTietPhieuNhap.Location = new System.Drawing.Point(14, 17);
            this.dgvChiTietPhieuNhap.Name = "dgvChiTietPhieuNhap";
            this.dgvChiTietPhieuNhap.RowHeadersVisible = false;
            this.dgvChiTietPhieuNhap.RowTemplate.Height = 24;
            this.dgvChiTietPhieuNhap.Size = new System.Drawing.Size(1046, 249);
            this.dgvChiTietPhieuNhap.TabIndex = 0;
            // 
            // MaChiTietPhieuNhap
            // 
            this.MaChiTietPhieuNhap.DataPropertyName = "MaChiTietPhieuNhap";
            this.MaChiTietPhieuNhap.HeaderText = "Mã Chi Tiết Phiếu Nhập";
            this.MaChiTietPhieuNhap.Name = "MaChiTietPhieuNhap";
            // 
            // MaPhieuNhap
            // 
            this.MaPhieuNhap.DataPropertyName = "MaPhieuNhap";
            this.MaPhieuNhap.HeaderText = "Mã Phiếu Nhập";
            this.MaPhieuNhap.Name = "MaPhieuNhap";
            // 
            // MaSanPham
            // 
            this.MaSanPham.DataPropertyName = "MaSanPham";
            this.MaSanPham.HeaderText = "Mã Sản Phẩm";
            this.MaSanPham.Name = "MaSanPham";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.Name = "DonGia";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.dgvChiTietPhieuNhap);
            this.panel3.Location = new System.Drawing.Point(15, 396);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1068, 286);
            this.panel3.TabIndex = 85;
            // 
            // btnSua
            // 
            this.btnSua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSua.BackgroundImage")));
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSua.Location = new System.Drawing.Point(560, 18);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(120, 67);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(336, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "CHI TIẾT PHIẾU NHẬP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(19, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã phiếu nhập:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(19, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "Mã sản phẩm";
            // 
            // btnHuy
            // 
            this.btnHuy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHuy.BackgroundImage")));
            this.btnHuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHuy.Location = new System.Drawing.Point(729, 18);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(120, 67);
            this.btnHuy.TabIndex = 16;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThem.BackgroundImage")));
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnThem.Location = new System.Drawing.Point(227, 18);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(120, 67);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSearch.Location = new System.Drawing.Point(561, 141);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(123, 54);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(729, 157);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(157, 29);
            this.txtSearch.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(582, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số lượng";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(897, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 67);
            this.button1.TabIndex = 21;
            this.button1.Text = "Thoát";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblMaChiTietPhieuNhap
            // 
            this.lblMaChiTietPhieuNhap.AutoSize = true;
            this.lblMaChiTietPhieuNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaChiTietPhieuNhap.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMaChiTietPhieuNhap.Location = new System.Drawing.Point(293, 44);
            this.lblMaChiTietPhieuNhap.Name = "lblMaChiTietPhieuNhap";
            this.lblMaChiTietPhieuNhap.Size = new System.Drawing.Size(24, 25);
            this.lblMaChiTietPhieuNhap.TabIndex = 26;
            this.lblMaChiTietPhieuNhap.Text = "0";
            // 
            // lblMaPhieuNhap
            // 
            this.lblMaPhieuNhap.AutoSize = true;
            this.lblMaPhieuNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPhieuNhap.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMaPhieuNhap.Location = new System.Drawing.Point(293, 100);
            this.lblMaPhieuNhap.Name = "lblMaPhieuNhap";
            this.lblMaPhieuNhap.Size = new System.Drawing.Size(24, 25);
            this.lblMaPhieuNhap.TabIndex = 25;
            this.lblMaPhieuNhap.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(19, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(242, 25);
            this.label4.TabIndex = 24;
            this.label4.Text = "Mã Chi Tiết Phiếu Nhập";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(906, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 25);
            this.label6.TabIndex = 23;
            this.label6.Text = "VNĐ";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(729, 95);
            this.txtDonGia.Multiline = true;
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(157, 30);
            this.txtDonGia.TabIndex = 22;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(729, 44);
            this.txtSoLuong.Multiline = true;
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(157, 25);
            this.txtSoLuong.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(582, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "Đơn giá";
            // 
            // cboMaSanPhan
            // 
            this.cboMaSanPhan.FormattingEnabled = true;
            this.cboMaSanPhan.Location = new System.Drawing.Point(298, 153);
            this.cboMaSanPhan.Name = "cboMaSanPhan";
            this.cboMaSanPhan.Size = new System.Drawing.Size(157, 27);
            this.cboMaSanPhan.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.btnXoa);
            this.panel4.Controls.Add(this.btnRefesh);
            this.panel4.Controls.Add(this.btnHuy);
            this.panel4.Controls.Add(this.btnThem);
            this.panel4.Controls.Add(this.btnSua);
            this.panel4.Location = new System.Drawing.Point(15, 291);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1068, 99);
            this.panel4.TabIndex = 86;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.lblMaChiTietPhieuNhap);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDonGia);
            this.groupBox1.Controls.Add(this.lblMaPhieuNhap);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.cboMaSanPhan);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(15, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1068, 204);
            this.groupBox1.TabIndex = 87;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhập chi tiết";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(15, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1068, 63);
            this.panel1.TabIndex = 88;
            // 
            // FrmPhieuNhapCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1107, 702);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.MaximizeBox = false;
            this.Name = "FrmPhieuNhapCT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập Chi Tiết";
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhieuNhap)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnRefesh;
        private System.Windows.Forms.DataGridView dgvChiTietPhieuNhap;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboMaSanPhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChiTietPhieuNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieuNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.Label lblMaPhieuNhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMaChiTietPhieuNhap;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
    }
}