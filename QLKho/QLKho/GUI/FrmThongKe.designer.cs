namespace QLKho.GUI
{
    partial class FrmThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmThongKe));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnback = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnthongke = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpdenngay = new System.Windows.Forms.DateTimePicker();
            this.dtptungay = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblsum = new System.Windows.Forms.Label();
            this.dgvthongke = new System.Windows.Forms.DataGridView();
            this.MASP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYXUAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THANHTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvthongke)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.btnback);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1021, 90);
            this.panel2.TabIndex = 1;
            // 
            // btnback
            // 
            this.btnback.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnback.BackgroundImage")));
            this.btnback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnback.Location = new System.Drawing.Point(900, 23);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(103, 48);
            this.btnback.TabIndex = 20;
            this.btnback.Text = "Thoát";
            this.btnback.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(136, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(699, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "THỐNG KÊ DOANH THU  HÀNG HÓA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(93, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Đến ngày: ";
            // 
            // btnthongke
            // 
            this.btnthongke.BackColor = System.Drawing.Color.Blue;
            this.btnthongke.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthongke.ForeColor = System.Drawing.SystemColors.Control;
            this.btnthongke.Image = ((System.Drawing.Image)(resources.GetObject("btnthongke.Image")));
            this.btnthongke.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthongke.Location = new System.Drawing.Point(553, 41);
            this.btnthongke.Name = "btnthongke";
            this.btnthongke.Size = new System.Drawing.Size(281, 63);
            this.btnthongke.TabIndex = 2;
            this.btnthongke.Text = "Thống Kê";
            this.btnthongke.UseVisualStyleBackColor = false;
            this.btnthongke.Click += new System.EventHandler(this.btnthongke_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(93, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Từ ngày: ";
            // 
            // dtpdenngay
            // 
            this.dtpdenngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpdenngay.Location = new System.Drawing.Point(277, 97);
            this.dtpdenngay.Name = "dtpdenngay";
            this.dtpdenngay.Size = new System.Drawing.Size(150, 27);
            this.dtpdenngay.TabIndex = 1;
            // 
            // dtptungay
            // 
            this.dtptungay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtptungay.Location = new System.Drawing.Point(277, 43);
            this.dtptungay.Name = "dtptungay";
            this.dtptungay.Size = new System.Drawing.Size(150, 27);
            this.dtptungay.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.lblsum);
            this.panel3.Controls.Add(this.dgvthongke);
            this.panel3.Location = new System.Drawing.Point(12, 302);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1021, 354);
            this.panel3.TabIndex = 3;
            // 
            // lblsum
            // 
            this.lblsum.AutoSize = true;
            this.lblsum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsum.Location = new System.Drawing.Point(1126, 387);
            this.lblsum.Name = "lblsum";
            this.lblsum.Size = new System.Drawing.Size(64, 32);
            this.lblsum.TabIndex = 6;
            this.lblsum.Text = "abc";
            // 
            // dgvthongke
            // 
            this.dgvthongke.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvthongke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvthongke.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MASP,
            this.TENSP,
            this.SOLUONG,
            this.DONGIA,
            this.NGAYXUAT,
            this.THANHTIEN});
            this.dgvthongke.Location = new System.Drawing.Point(19, 14);
            this.dgvthongke.Name = "dgvthongke";
            this.dgvthongke.RowHeadersVisible = false;
            this.dgvthongke.RowTemplate.Height = 24;
            this.dgvthongke.Size = new System.Drawing.Size(984, 248);
            this.dgvthongke.TabIndex = 0;
            // 
            // MASP
            // 
            this.MASP.DataPropertyName = "MASP";
            this.MASP.HeaderText = "Mã Sản Phẩm";
            this.MASP.Name = "MASP";
            // 
            // TENSP
            // 
            this.TENSP.DataPropertyName = "TENSP";
            this.TENSP.HeaderText = "Tên Sản Phẩm";
            this.TENSP.Name = "TENSP";
            // 
            // SOLUONG
            // 
            this.SOLUONG.DataPropertyName = "SOLUONG";
            this.SOLUONG.HeaderText = "Số Lượng";
            this.SOLUONG.Name = "SOLUONG";
            // 
            // DONGIA
            // 
            this.DONGIA.DataPropertyName = "DONGIA";
            this.DONGIA.HeaderText = "Đơn Giá";
            this.DONGIA.Name = "DONGIA";
            // 
            // NGAYXUAT
            // 
            this.NGAYXUAT.DataPropertyName = "NGAYXUAT";
            this.NGAYXUAT.HeaderText = "Ngày Xuất";
            this.NGAYXUAT.Name = "NGAYXUAT";
            // 
            // THANHTIEN
            // 
            this.THANHTIEN.DataPropertyName = "THANHTIEN";
            this.THANHTIEN.HeaderText = "Thành Tiền";
            this.THANHTIEN.Name = "THANHTIEN";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.dtpdenngay);
            this.groupBox1.Controls.Add(this.btnthongke);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtptungay);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(13, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1020, 156);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin thống kê";
            // 
            // FrmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 673);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống Kê";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvthongke)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnthongke;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpdenngay;
        private System.Windows.Forms.DateTimePicker dtptungay;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvthongke;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYXUAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn THANHTIEN;
        private System.Windows.Forms.Label lblsum;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}