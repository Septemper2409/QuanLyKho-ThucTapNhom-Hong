namespace QLKho.GUI
{
    partial class FrmNhaCungCap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNhaCungCap));
            this.dgvNhacungcap = new System.Windows.Forms.DataGridView();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHINCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDTNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WEBSITENCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnRefesh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtWebncc = new System.Windows.Forms.TextBox();
            this.txtTenncc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMancc = new System.Windows.Forms.Label();
            this.lblma = new System.Windows.Forms.Label();
            this.txtDiachincc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSdtncc = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhacungcap)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvNhacungcap
            // 
            this.dgvNhacungcap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhacungcap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhacungcap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNCC,
            this.TenNCC,
            this.DIACHINCC,
            this.SDTNCC,
            this.WEBSITENCC});
            this.dgvNhacungcap.Location = new System.Drawing.Point(17, 15);
            this.dgvNhacungcap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvNhacungcap.Name = "dgvNhacungcap";
            this.dgvNhacungcap.RowHeadersVisible = false;
            this.dgvNhacungcap.RowTemplate.Height = 24;
            this.dgvNhacungcap.Size = new System.Drawing.Size(1032, 224);
            this.dgvNhacungcap.TabIndex = 0;
            this.dgvNhacungcap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhacungcap_CellContentClick);
            // 
            // MaNCC
            // 
            this.MaNCC.DataPropertyName = "MANCC";
            this.MaNCC.HeaderText = "Mã Nhà Cung Cấp";
            this.MaNCC.Name = "MaNCC";
            // 
            // TenNCC
            // 
            this.TenNCC.DataPropertyName = "TenNCC";
            this.TenNCC.HeaderText = "Tên Nhà Cung Cấp";
            this.TenNCC.Name = "TenNCC";
            // 
            // DIACHINCC
            // 
            this.DIACHINCC.DataPropertyName = "DIACHINCC";
            this.DIACHINCC.HeaderText = "Địa Chỉ";
            this.DIACHINCC.Name = "DIACHINCC";
            // 
            // SDTNCC
            // 
            this.SDTNCC.DataPropertyName = "SDTNCC";
            this.SDTNCC.HeaderText = "Số Điện Thoại";
            this.SDTNCC.Name = "SDTNCC";
            // 
            // WEBSITENCC
            // 
            this.WEBSITENCC.DataPropertyName = "WEBSITENCC";
            this.WEBSITENCC.HeaderText = "Website";
            this.WEBSITENCC.Name = "WEBSITENCC";
            // 
            // btnHuy
            // 
            this.btnHuy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHuy.BackgroundImage")));
            this.btnHuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHuy.Location = new System.Drawing.Point(702, 24);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(120, 76);
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
            this.btnXoa.Location = new System.Drawing.Point(369, 24);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(119, 76);
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
            this.btnSua.Location = new System.Drawing.Point(535, 24);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(123, 76);
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
            this.btnThem.Location = new System.Drawing.Point(196, 24);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(113, 76);
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
            this.btnRefesh.Location = new System.Drawing.Point(36, 24);
            this.btnRefesh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(121, 76);
            this.btnRefesh.TabIndex = 7;
            this.btnRefesh.Text = "Refresh";
            this.btnRefesh.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnRefesh.UseVisualStyleBackColor = true;
            this.btnRefesh.Click += new System.EventHandler(this.btnRefesh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSearch.Location = new System.Drawing.Point(553, 138);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 55);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnback
            // 
            this.btnback.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnback.BackgroundImage")));
            this.btnback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnback.Location = new System.Drawing.Point(868, 24);
            this.btnback.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(115, 76);
            this.btnback.TabIndex = 20;
            this.btnback.Text = "Thoát";
            this.btnback.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(781, 137);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(240, 40);
            this.txtSearch.TabIndex = 5;
            // 
            // txtWebncc
            // 
            this.txtWebncc.Location = new System.Drawing.Point(781, 25);
            this.txtWebncc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWebncc.Multiline = true;
            this.txtWebncc.Name = "txtWebncc";
            this.txtWebncc.Size = new System.Drawing.Size(240, 36);
            this.txtWebncc.TabIndex = 4;
            // 
            // txtTenncc
            // 
            this.txtTenncc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenncc.Location = new System.Drawing.Point(158, 82);
            this.txtTenncc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenncc.Multiline = true;
            this.txtTenncc.Name = "txtTenncc";
            this.txtTenncc.Size = new System.Drawing.Size(243, 34);
            this.txtTenncc.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(548, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số Điện Thoại NCC: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(548, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Website : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(19, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên NCC : ";
            // 
            // lblMancc
            // 
            this.lblMancc.AutoSize = true;
            this.lblMancc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMancc.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMancc.Location = new System.Drawing.Point(19, 34);
            this.lblMancc.Name = "lblMancc";
            this.lblMancc.Size = new System.Drawing.Size(114, 25);
            this.lblMancc.TabIndex = 1;
            this.lblMancc.Text = "Mã NCC : ";
            // 
            // lblma
            // 
            this.lblma.AutoSize = true;
            this.lblma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblma.ForeColor = System.Drawing.SystemColors.Control;
            this.lblma.Location = new System.Drawing.Point(139, 34);
            this.lblma.Name = "lblma";
            this.lblma.Size = new System.Drawing.Size(24, 25);
            this.lblma.TabIndex = 18;
            this.lblma.Text = "0";
            // 
            // txtDiachincc
            // 
            this.txtDiachincc.Location = new System.Drawing.Point(158, 137);
            this.txtDiachincc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiachincc.Multiline = true;
            this.txtDiachincc.Name = "txtDiachincc";
            this.txtDiachincc.Size = new System.Drawing.Size(243, 40);
            this.txtDiachincc.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(20, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 29);
            this.label6.TabIndex = 17;
            this.label6.Text = "Địa chỉ : ";
            // 
            // txtSdtncc
            // 
            this.txtSdtncc.Location = new System.Drawing.Point(781, 76);
            this.txtSdtncc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSdtncc.Multiline = true;
            this.txtSdtncc.Name = "txtSdtncc";
            this.txtSdtncc.Size = new System.Drawing.Size(240, 40);
            this.txtSdtncc.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.btnRefesh);
            this.panel3.Controls.Add(this.btnback);
            this.panel3.Controls.Add(this.btnThem);
            this.panel3.Controls.Add(this.btnHuy);
            this.panel3.Controls.Add(this.btnSua);
            this.panel3.Controls.Add(this.btnXoa);
            this.panel3.Location = new System.Drawing.Point(12, 311);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1079, 111);
            this.panel3.TabIndex = 79;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.dgvNhacungcap);
            this.panel4.Location = new System.Drawing.Point(12, 428);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1079, 269);
            this.panel4.TabIndex = 80;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.lblMancc);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.lblma);
            this.groupBox1.Controls.Add(this.txtSdtncc);
            this.groupBox1.Controls.Add(this.txtDiachincc);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtWebncc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTenncc);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1079, 223);
            this.groupBox1.TabIndex = 81;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhà cung cấp";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1079, 65);
            this.panel1.TabIndex = 82;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(419, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "NHÀ CUNG CẤP";
            // 
            // FrmNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1119, 720);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FrmNhaCungCap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhà Cung Cấp";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhacungcap)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNhacungcap;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnRefesh;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtWebncc;
        private System.Windows.Forms.TextBox txtTenncc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMancc;
        private System.Windows.Forms.TextBox txtDiachincc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSdtncc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHINCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDTNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn WEBSITENCC;
        private System.Windows.Forms.Label lblma;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}