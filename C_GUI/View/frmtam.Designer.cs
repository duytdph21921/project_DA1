namespace C_GUI.View
{
    partial class frmtam
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
            this.label12 = new System.Windows.Forms.Label();
            this.panel_dulieu = new System.Windows.Forms.Panel();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dtg_sanpham = new System.Windows.Forms.DataGridView();
            this.cbb_timtheoloaissp = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_timthotensp = new System.Windows.Forms.TextBox();
            this.btn_timiem = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel_thongtin = new System.Windows.Forms.Panel();
            this.btn_sua = new FontAwesome.Sharp.IconButton();
            this.btn_xoa = new FontAwesome.Sharp.IconButton();
            this.btn_them = new FontAwesome.Sharp.IconButton();
            this.rdb_ngungban = new System.Windows.Forms.RadioButton();
            this.rdb_dangban = new System.Windows.Forms.RadioButton();
            this.rtb_mota = new System.Windows.Forms.RichTextBox();
            this.rtb_ghichu = new System.Windows.Forms.RichTextBox();
            this.tb_dongia = new System.Windows.Forms.TextBox();
            this.cbb_loaisp = new System.Windows.Forms.ComboBox();
            this.tb_tensp = new System.Windows.Forms.TextBox();
            this.tb_masp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ptb_anhsp = new System.Windows.Forms.PictureBox();
            this.panel_Ql_SanPham = new System.Windows.Forms.Panel();
            this.panel_dulieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_sanpham)).BeginInit();
            this.panel_thongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_anhsp)).BeginInit();
            this.panel_Ql_SanPham.SuspendLayout();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(398, 913);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 32);
            this.label12.TabIndex = 19;
            // 
            // panel_dulieu
            // 
            this.panel_dulieu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel_dulieu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_dulieu.Controls.Add(this.checkBox2);
            this.panel_dulieu.Controls.Add(this.checkBox1);
            this.panel_dulieu.Controls.Add(this.dtg_sanpham);
            this.panel_dulieu.Controls.Add(this.cbb_timtheoloaissp);
            this.panel_dulieu.Controls.Add(this.label10);
            this.panel_dulieu.Controls.Add(this.label9);
            this.panel_dulieu.Controls.Add(this.tb_timthotensp);
            this.panel_dulieu.Controls.Add(this.btn_timiem);
            this.panel_dulieu.Controls.Add(this.label8);
            this.panel_dulieu.Location = new System.Drawing.Point(1842, 40);
            this.panel_dulieu.Margin = new System.Windows.Forms.Padding(5);
            this.panel_dulieu.Name = "panel_dulieu";
            this.panel_dulieu.Size = new System.Drawing.Size(638, 712);
            this.panel_dulieu.TabIndex = 13;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(1180, 102);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(5);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(167, 36);
            this.checkBox2.TabIndex = 23;
            this.checkBox2.Text = "Ngừng bán";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(985, 102);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(5);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(150, 36);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.Text = "Đang bán";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // dtg_sanpham
            // 
            this.dtg_sanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_sanpham.Location = new System.Drawing.Point(171, 192);
            this.dtg_sanpham.Margin = new System.Windows.Forms.Padding(5);
            this.dtg_sanpham.Name = "dtg_sanpham";
            this.dtg_sanpham.RowHeadersWidth = 51;
            this.dtg_sanpham.RowTemplate.Height = 29;
            this.dtg_sanpham.Size = new System.Drawing.Size(1011, 880);
            this.dtg_sanpham.TabIndex = 21;
            // 
            // cbb_timtheoloaissp
            // 
            this.cbb_timtheoloaissp.FormattingEnabled = true;
            this.cbb_timtheoloaissp.Location = new System.Drawing.Point(686, 106);
            this.cbb_timtheoloaissp.Margin = new System.Windows.Forms.Padding(5);
            this.cbb_timtheoloaissp.Name = "cbb_timtheoloaissp";
            this.cbb_timtheoloaissp.Size = new System.Drawing.Size(223, 40);
            this.cbb_timtheoloaissp.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(985, 43);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 32);
            this.label10.TabIndex = 18;
            this.label10.Text = "Trạng thái :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(668, 43);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(192, 32);
            this.label9.TabIndex = 18;
            this.label9.Text = "Loại sản phẩm :";
            // 
            // tb_timthotensp
            // 
            this.tb_timthotensp.Location = new System.Drawing.Point(171, 106);
            this.tb_timthotensp.Margin = new System.Windows.Forms.Padding(5);
            this.tb_timthotensp.Name = "tb_timthotensp";
            this.tb_timthotensp.PlaceholderText = "Nhập tên sản phẩm vào đây ...";
            this.tb_timthotensp.Size = new System.Drawing.Size(365, 39);
            this.tb_timthotensp.TabIndex = 18;
            // 
            // btn_timiem
            // 
            this.btn_timiem.Location = new System.Drawing.Point(548, 102);
            this.btn_timiem.Margin = new System.Windows.Forms.Padding(5);
            this.btn_timiem.Name = "btn_timiem";
            this.btn_timiem.Size = new System.Drawing.Size(115, 46);
            this.btn_timiem.TabIndex = 19;
            this.btn_timiem.Text = "Tìm";
            this.btn_timiem.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(171, 43);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(185, 32);
            this.label8.TabIndex = 18;
            this.label8.Text = "Tên sản phẩm :";
            // 
            // panel_thongtin
            // 
            this.panel_thongtin.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel_thongtin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_thongtin.Controls.Add(this.btn_sua);
            this.panel_thongtin.Controls.Add(this.btn_xoa);
            this.panel_thongtin.Controls.Add(this.btn_them);
            this.panel_thongtin.Controls.Add(this.rdb_ngungban);
            this.panel_thongtin.Controls.Add(this.rdb_dangban);
            this.panel_thongtin.Controls.Add(this.rtb_mota);
            this.panel_thongtin.Controls.Add(this.rtb_ghichu);
            this.panel_thongtin.Controls.Add(this.tb_dongia);
            this.panel_thongtin.Controls.Add(this.cbb_loaisp);
            this.panel_thongtin.Controls.Add(this.tb_tensp);
            this.panel_thongtin.Controls.Add(this.tb_masp);
            this.panel_thongtin.Controls.Add(this.label7);
            this.panel_thongtin.Controls.Add(this.label6);
            this.panel_thongtin.Controls.Add(this.label5);
            this.panel_thongtin.Controls.Add(this.label4);
            this.panel_thongtin.Controls.Add(this.label3);
            this.panel_thongtin.Controls.Add(this.label2);
            this.panel_thongtin.Controls.Add(this.label1);
            this.panel_thongtin.Controls.Add(this.ptb_anhsp);
            this.panel_thongtin.Location = new System.Drawing.Point(374, 518);
            this.panel_thongtin.Margin = new System.Windows.Forms.Padding(5);
            this.panel_thongtin.Name = "panel_thongtin";
            this.panel_thongtin.Size = new System.Drawing.Size(883, 714);
            this.panel_thongtin.TabIndex = 12;
            // 
            // btn_sua
            // 
            this.btn_sua.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_sua.IconChar = FontAwesome.Sharp.IconChar.ScrewdriverWrench;
            this.btn_sua.IconColor = System.Drawing.Color.Black;
            this.btn_sua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sua.Location = new System.Drawing.Point(739, 955);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(5);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Padding = new System.Windows.Forms.Padding(32, 3, 0, 0);
            this.btn_sua.Size = new System.Drawing.Size(286, 85);
            this.btn_sua.TabIndex = 43;
            this.btn_sua.Text = "SỬA";
            this.btn_sua.UseVisualStyleBackColor = true;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_xoa.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btn_xoa.IconColor = System.Drawing.Color.Black;
            this.btn_xoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoa.Location = new System.Drawing.Point(395, 955);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(5);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Padding = new System.Windows.Forms.Padding(32, 3, 0, 0);
            this.btn_xoa.Size = new System.Drawing.Size(286, 85);
            this.btn_xoa.TabIndex = 44;
            this.btn_xoa.Text = "XÓA";
            this.btn_xoa.UseVisualStyleBackColor = true;
            // 
            // btn_them
            // 
            this.btn_them.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_them.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btn_them.IconColor = System.Drawing.Color.Black;
            this.btn_them.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them.Location = new System.Drawing.Point(46, 955);
            this.btn_them.Margin = new System.Windows.Forms.Padding(5);
            this.btn_them.Name = "btn_them";
            this.btn_them.Padding = new System.Windows.Forms.Padding(32, 6, 0, 0);
            this.btn_them.Size = new System.Drawing.Size(286, 85);
            this.btn_them.TabIndex = 42;
            this.btn_them.Text = "THÊM";
            this.btn_them.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_them.UseVisualStyleBackColor = true;
            // 
            // rdb_ngungban
            // 
            this.rdb_ngungban.AutoSize = true;
            this.rdb_ngungban.Location = new System.Drawing.Point(569, 574);
            this.rdb_ngungban.Margin = new System.Windows.Forms.Padding(5);
            this.rdb_ngungban.Name = "rdb_ngungban";
            this.rdb_ngungban.Size = new System.Drawing.Size(166, 36);
            this.rdb_ngungban.TabIndex = 20;
            this.rdb_ngungban.TabStop = true;
            this.rdb_ngungban.Text = "Ngừng bán";
            this.rdb_ngungban.UseVisualStyleBackColor = true;
            // 
            // rdb_dangban
            // 
            this.rdb_dangban.AutoSize = true;
            this.rdb_dangban.Location = new System.Drawing.Point(341, 574);
            this.rdb_dangban.Margin = new System.Windows.Forms.Padding(5);
            this.rdb_dangban.Name = "rdb_dangban";
            this.rdb_dangban.Size = new System.Drawing.Size(149, 36);
            this.rdb_dangban.TabIndex = 19;
            this.rdb_dangban.TabStop = true;
            this.rdb_dangban.Text = "Đang bán";
            this.rdb_dangban.UseVisualStyleBackColor = true;
            // 
            // rtb_mota
            // 
            this.rtb_mota.Location = new System.Drawing.Point(341, 651);
            this.rtb_mota.Margin = new System.Windows.Forms.Padding(5);
            this.rtb_mota.Name = "rtb_mota";
            this.rtb_mota.Size = new System.Drawing.Size(508, 94);
            this.rtb_mota.TabIndex = 15;
            this.rtb_mota.Text = "";
            // 
            // rtb_ghichu
            // 
            this.rtb_ghichu.Location = new System.Drawing.Point(341, 778);
            this.rtb_ghichu.Margin = new System.Windows.Forms.Padding(5);
            this.rtb_ghichu.Name = "rtb_ghichu";
            this.rtb_ghichu.Size = new System.Drawing.Size(508, 94);
            this.rtb_ghichu.TabIndex = 13;
            this.rtb_ghichu.Text = "";
            // 
            // tb_dongia
            // 
            this.tb_dongia.Location = new System.Drawing.Point(341, 490);
            this.tb_dongia.Margin = new System.Windows.Forms.Padding(5);
            this.tb_dongia.Name = "tb_dongia";
            this.tb_dongia.Size = new System.Drawing.Size(508, 39);
            this.tb_dongia.TabIndex = 11;
            // 
            // cbb_loaisp
            // 
            this.cbb_loaisp.FormattingEnabled = true;
            this.cbb_loaisp.Location = new System.Drawing.Point(341, 413);
            this.cbb_loaisp.Margin = new System.Windows.Forms.Padding(5);
            this.cbb_loaisp.Name = "cbb_loaisp";
            this.cbb_loaisp.Size = new System.Drawing.Size(508, 40);
            this.cbb_loaisp.TabIndex = 10;
            // 
            // tb_tensp
            // 
            this.tb_tensp.Location = new System.Drawing.Point(341, 338);
            this.tb_tensp.Margin = new System.Windows.Forms.Padding(5);
            this.tb_tensp.Name = "tb_tensp";
            this.tb_tensp.Size = new System.Drawing.Size(508, 39);
            this.tb_tensp.TabIndex = 9;
            // 
            // tb_masp
            // 
            this.tb_masp.Location = new System.Drawing.Point(341, 262);
            this.tb_masp.Margin = new System.Windows.Forms.Padding(5);
            this.tb_masp.Name = "tb_masp";
            this.tb_masp.Size = new System.Drawing.Size(508, 39);
            this.tb_masp.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(107, 574);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 32);
            this.label7.TabIndex = 7;
            this.label7.Text = "Trạng thái :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(98, 776);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 32);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ghi chú :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(107, 656);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 32);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mô tả :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(107, 499);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Đơn giá :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(107, 424);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Loại sản phẩm :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(104, 349);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên sản phẩm :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(107, 274);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Sản Phẩm :";
            // 
            // ptb_anhsp
            // 
            this.ptb_anhsp.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ptb_anhsp.Location = new System.Drawing.Point(207, 56);
            this.ptb_anhsp.Margin = new System.Windows.Forms.Padding(5);
            this.ptb_anhsp.Name = "ptb_anhsp";
            this.ptb_anhsp.Size = new System.Drawing.Size(203, 178);
            this.ptb_anhsp.TabIndex = 0;
            this.ptb_anhsp.TabStop = false;
            // 
            // panel_Ql_SanPham
            // 
            this.panel_Ql_SanPham.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_Ql_SanPham.Controls.Add(this.panel_thongtin);
            this.panel_Ql_SanPham.Location = new System.Drawing.Point(-15, -16);
            this.panel_Ql_SanPham.Name = "panel_Ql_SanPham";
            this.panel_Ql_SanPham.Size = new System.Drawing.Size(2575, 1285);
            this.panel_Ql_SanPham.TabIndex = 22;
            // 
            // frmtam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2544, 1253);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel_dulieu);
            this.Controls.Add(this.panel_Ql_SanPham);
            this.Name = "frmtam";
            this.Text = "frmtam";
            this.panel_dulieu.ResumeLayout(false);
            this.panel_dulieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_sanpham)).EndInit();
            this.panel_thongtin.ResumeLayout(false);
            this.panel_thongtin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_anhsp)).EndInit();
            this.panel_Ql_SanPham.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel_dulieu;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridView dtg_sanpham;
        private System.Windows.Forms.ComboBox cbb_timtheoloaissp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_timthotensp;
        private System.Windows.Forms.Button btn_timiem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel_thongtin;
        private FontAwesome.Sharp.IconButton btn_sua;
        private FontAwesome.Sharp.IconButton btn_xoa;
        private FontAwesome.Sharp.IconButton btn_them;
        private System.Windows.Forms.RadioButton rdb_ngungban;
        private System.Windows.Forms.RadioButton rdb_dangban;
        private System.Windows.Forms.RichTextBox rtb_mota;
        private System.Windows.Forms.RichTextBox rtb_ghichu;
        private System.Windows.Forms.TextBox tb_dongia;
        private System.Windows.Forms.ComboBox cbb_loaisp;
        private System.Windows.Forms.TextBox tb_tensp;
        private System.Windows.Forms.TextBox tb_masp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ptb_anhsp;
        private System.Windows.Forms.Panel panel_Ql_SanPham;
    }
}