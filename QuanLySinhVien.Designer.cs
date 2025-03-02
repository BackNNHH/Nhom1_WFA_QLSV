namespace Nhom1_WFA_QLSV
{
    partial class QuanLySinhVien
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
            label1 = new Label();
            TxtMaSV = new TextBox();
            label2 = new Label();
            TxtTenSV = new TextBox();
            label3 = new Label();
            TxtDiaChi = new TextBox();
            TxtDienThoai = new TextBox();
            label5 = new Label();
            BtnThem = new Button();
            BtnSua = new Button();
            BtnLuu = new Button();
            BtnHuy = new Button();
            BtnXoa = new Button();
            BtnTaiLai = new Button();
            DgvKhachHang = new DataGridView();
            label4 = new Label();
            label6 = new Label();
            TxtEmail = new TextBox();
            TxtNgaySinh = new DateTimePicker();
            MaSV = new DataGridViewTextBoxColumn();
            HoTen = new DataGridViewTextBoxColumn();
            NgaySinh = new DataGridViewTextBoxColumn();
            GioiTInh = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            SoDienThoai = new DataGridViewTextBoxColumn();
            MaLop = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)DgvKhachHang).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã SV";
            // 
            // TxtMaSV
            // 
            TxtMaSV.Location = new Point(68, 6);
            TxtMaSV.Name = "TxtMaSV";
            TxtMaSV.Size = new Size(400, 23);
            TxtMaSV.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 38);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 0;
            label2.Text = "Tên SV";
            // 
            // TxtTenSV
            // 
            TxtTenSV.Location = new Point(68, 35);
            TxtTenSV.Name = "TxtTenSV";
            TxtTenSV.Size = new Size(400, 23);
            TxtTenSV.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 67);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 0;
            label3.Text = "Địa chỉ";
            // 
            // TxtDiaChi
            // 
            TxtDiaChi.Location = new Point(68, 64);
            TxtDiaChi.Name = "TxtDiaChi";
            TxtDiaChi.Size = new Size(400, 23);
            TxtDiaChi.TabIndex = 1;
            // 
            // TxtDienThoai
            // 
            TxtDienThoai.Location = new Point(563, 67);
            TxtDienThoai.Name = "TxtDienThoai";
            TxtDienThoai.Size = new Size(225, 23);
            TxtDienThoai.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(493, 70);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 0;
            label5.Text = "Điện thoại";
            // 
            // BtnThem
            // 
            BtnThem.Location = new Point(12, 415);
            BtnThem.Name = "BtnThem";
            BtnThem.Size = new Size(75, 23);
            BtnThem.TabIndex = 3;
            BtnThem.Text = "Thêm";
            BtnThem.UseVisualStyleBackColor = true;
            BtnThem.Click += BtnThem_Click;
            // 
            // BtnSua
            // 
            BtnSua.Location = new Point(93, 415);
            BtnSua.Name = "BtnSua";
            BtnSua.Size = new Size(75, 23);
            BtnSua.TabIndex = 3;
            BtnSua.Text = "Sửa";
            BtnSua.UseVisualStyleBackColor = true;
            BtnSua.Click += BtnSua_Click;
            // 
            // BtnLuu
            // 
            BtnLuu.Location = new Point(174, 415);
            BtnLuu.Name = "BtnLuu";
            BtnLuu.Size = new Size(75, 23);
            BtnLuu.TabIndex = 3;
            BtnLuu.Text = "Lưu";
            BtnLuu.UseVisualStyleBackColor = true;
            BtnLuu.Click += BtnLuu_Click;
            // 
            // BtnHuy
            // 
            BtnHuy.Location = new Point(255, 415);
            BtnHuy.Name = "BtnHuy";
            BtnHuy.Size = new Size(75, 23);
            BtnHuy.TabIndex = 3;
            BtnHuy.Text = "Hủy";
            BtnHuy.UseVisualStyleBackColor = true;
            BtnHuy.Click += BtnHuy_Click;
            // 
            // BtnXoa
            // 
            BtnXoa.Location = new Point(336, 415);
            BtnXoa.Name = "BtnXoa";
            BtnXoa.Size = new Size(75, 23);
            BtnXoa.TabIndex = 3;
            BtnXoa.Text = "Xóa";
            BtnXoa.UseVisualStyleBackColor = true;
            BtnXoa.Click += BtnXoa_Click;
            // 
            // BtnTaiLai
            // 
            BtnTaiLai.Location = new Point(713, 415);
            BtnTaiLai.Name = "BtnTaiLai";
            BtnTaiLai.Size = new Size(75, 23);
            BtnTaiLai.TabIndex = 3;
            BtnTaiLai.Text = "Tải lại";
            BtnTaiLai.UseVisualStyleBackColor = true;
            BtnTaiLai.Click += BtnTaiLai_Click;
            // 
            // DgvKhachHang
            // 
            DgvKhachHang.AllowUserToAddRows = false;
            DgvKhachHang.AllowUserToDeleteRows = false;
            DgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvKhachHang.Columns.AddRange(new DataGridViewColumn[] { MaSV, HoTen, NgaySinh, GioiTInh, DiaChi, Email, SoDienThoai, MaLop });
            DgvKhachHang.Location = new Point(12, 93);
            DgvKhachHang.Name = "DgvKhachHang";
            DgvKhachHang.ReadOnly = true;
            DgvKhachHang.Size = new Size(776, 316);
            DgvKhachHang.TabIndex = 4;
            DgvKhachHang.CellContentClick += DgvKhachHang_CellContentClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(493, 9);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 0;
            label4.Text = "Ngày Sinh";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(493, 41);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 0;
            label6.Text = "Email";
            // 
            // TxtEmail
            // 
            TxtEmail.Location = new Point(563, 38);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(225, 23);
            TxtEmail.TabIndex = 1;
            // 
            // TxtNgaySinh
            // 
            TxtNgaySinh.Location = new Point(563, 6);
            TxtNgaySinh.Name = "TxtNgaySinh";
            TxtNgaySinh.Size = new Size(225, 23);
            TxtNgaySinh.TabIndex = 5;
            // 
            // MaSV
            // 
            MaSV.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            MaSV.DataPropertyName = "MaSV";
            MaSV.HeaderText = "MÃ SV";
            MaSV.Name = "MaSV";
            MaSV.ReadOnly = true;
            MaSV.Width = 67;
            // 
            // HoTen
            // 
            HoTen.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            HoTen.DataPropertyName = "HoTen";
            HoTen.HeaderText = "Họ Tên";
            HoTen.Name = "HoTen";
            HoTen.ReadOnly = true;
            // 
            // NgaySinh
            // 
            NgaySinh.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NgaySinh.DataPropertyName = "NgaySinh";
            NgaySinh.HeaderText = "Ngày Sinh";
            NgaySinh.Name = "NgaySinh";
            NgaySinh.ReadOnly = true;
            // 
            // GioiTInh
            // 
            GioiTInh.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            GioiTInh.DataPropertyName = "GioiTInh";
            GioiTInh.HeaderText = "Giới Tính";
            GioiTInh.Name = "GioiTInh";
            GioiTInh.ReadOnly = true;
            GioiTInh.Width = 79;
            // 
            // DiaChi
            // 
            DiaChi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.HeaderText = "Địa Chỉ";
            DiaChi.Name = "DiaChi";
            DiaChi.ReadOnly = true;
            // 
            // Email
            // 
            Email.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // SoDienThoai
            // 
            SoDienThoai.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SoDienThoai.DataPropertyName = "SoDienThoai";
            SoDienThoai.HeaderText = "Số Điện Thoại";
            SoDienThoai.Name = "SoDienThoai";
            SoDienThoai.ReadOnly = true;
            // 
            // MaLop
            // 
            MaLop.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            MaLop.DataPropertyName = "MaLop";
            MaLop.HeaderText = "Mã Lớp";
            MaLop.Name = "MaLop";
            MaLop.ReadOnly = true;
            MaLop.Width = 72;
            // 
            // QuanLySinhVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TxtNgaySinh);
            Controls.Add(DgvKhachHang);
            Controls.Add(BtnTaiLai);
            Controls.Add(BtnXoa);
            Controls.Add(BtnHuy);
            Controls.Add(BtnLuu);
            Controls.Add(BtnSua);
            Controls.Add(BtnThem);
            Controls.Add(TxtDiaChi);
            Controls.Add(label3);
            Controls.Add(TxtTenSV);
            Controls.Add(label2);
            Controls.Add(TxtEmail);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(TxtDienThoai);
            Controls.Add(label5);
            Controls.Add(TxtMaSV);
            Controls.Add(label1);
            Name = "QuanLySinhVien";
            Text = "QuanLySinhVien";
            Load += QuanLySinhVien_Load;
            ((System.ComponentModel.ISupportInitialize)DgvKhachHang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TxtMaSV;
        private Label label2;
        private TextBox TxtTenSV;
        private Label label3;
        private TextBox TxtDiaChi;
        private TextBox TxtDienThoai;
        private Label label5;
        private Button BtnThem;
        private Button BtnSua;
        private Button BtnLuu;
        private Button BtnHuy;
        private Button BtnXoa;
        private Button BtnTaiLai;
        private DataGridView DgvKhachHang;
        private Label label4;
        private Label label6;
        private TextBox TxtEmail;
        private DateTimePicker TxtNgaySinh;
        private DataGridViewTextBoxColumn MaSV;
        private DataGridViewTextBoxColumn HoTen;
        private DataGridViewTextBoxColumn NgaySinh;
        private DataGridViewTextBoxColumn GioiTInh;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn SoDienThoai;
        private DataGridViewTextBoxColumn MaLop;
    }
}