using System.Diagnostics;

namespace Nhom1_WFA_QLSV
{
    public partial class QuanLySinhVien : Form
    {
        bool isEdit = false;
        public QuanLySinhVien()
        {
            InitializeComponent();
            CauHinhSystem.LoadMeme(this);
        }

        private void QuanLySinhVien_Load(object sender, EventArgs e)
        {
            //LoadThanhPho();
            LoadKhachHang();
            SetEnable(false);
        }
        private void LoadKhachHang()
        {
            var sql = "SELECT * FROM SinhVien ORDER BY HoTen";
            DgvKhachHang.DataSource = DataBase.GetData(sql);

            CboLop.DataSource = DataBase.GetData("SELECT * FROM LopHoc");
            CboLop.DisplayMember = "TenLop";
            CboLop.ValueMember = "MaLop";
        }

        //private void LoadThanhPho()
        //{
        //    var sql = "SELECT * FROM ThanhPho ORDER BY TenThanhPho";
        //    var dtThanhPho = DataBase.GetData(sql);

        //    //Đổ dữ liệu vô Combobox CboThanhPho 
        //    CboThanhPho.DataSource = dtThanhPho;
        //    CboThanhPho.DisplayMember = "TenThanhPho";
        //    CboThanhPho.ValueMember = "MaThanhPho";

        //    //Đổ dữ liệu vô Combobox bên trong DataGridView 
        //    var DgvCboThanhPho = DgvKhachHang.Columns["MaThanhPho"] as DataGridViewComboBoxColumn;
        //    DgvCboThanhPho.DataSource = dtThanhPho;
        //    DgvCboThanhPho.DisplayMember = "TenThanhPho";
        //    DgvCboThanhPho.ValueMember = "MaThanhPho";
        //}

        /// <summary> 
        /// Thay đổi trạng thái các nút nhấn 
        /// </summary> 
        /// <param name="enable"></param> 
        void SetEnable(bool enable)
        {
            TxtMaSV.Enabled = enable;
            TxtTenSV.Enabled = enable;
            TxtNgaySinh.Enabled = enable;
            //TxtGioi.Enabled = enable;
            TxtDiaChi.Enabled = enable;
            TxtEmail.Enabled = enable;
            TxtDienThoai.Enabled = enable;
            //TxtMaSV.Enabled = enable;

            //set bộ nút (Thêm/Sửa trái ngược với textbox ở trên) 
            BtnThem.Enabled = !enable;
            BtnSua.Enabled = !enable;
            //không cho xóa khi đang edit (enable = True) 
            BtnXoa.Enabled = !isEdit;
            BtnHuy.Enabled = enable;
            BtnLuu.Enabled = enable;

            radNam.Enabled = enable;
            radNu.Enabled = enable;
            CboLop.Enabled = enable;
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            SetEnable(true);
            //isEdit = false;
            ////xóa giá trị đang nhập 
            //TxtMaSV.Clear();
            //TxtTenSV.Clear();
            //TxtNgaySinh.Refresh();
            //TxtDiaChi.Clear();
            //TxtDienThoai.Clear();
            //TxtDiaChi.Clear();
            //TxtEmail.Clear();
            //TxtDienThoai.Clear();
            //TxtMaSV.Clear();
            //radNam.Checked = true;
            //radNu.Checked = false;
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            SetEnable(true);
            isEdit = true;
            TxtMaSV.Enabled = false;
        }
        public string GetGioiTinh()
        {
            string gioiTinh = "Nam";
            if (radNu.Checked) gioiTinh = "Nữ";
            else if (radNam.Checked) gioiTinh = "Nam";
            return gioiTinh;
        }
        private void BtnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtMaSV.Text) || string.IsNullOrEmpty(TxtTenSV.Text) || string.IsNullOrEmpty(TxtNgaySinh.Text) || string.IsNullOrEmpty(TxtDiaChi.Text) || string.IsNullOrEmpty(TxtEmail.Text) || string.IsNullOrEmpty(TxtDienThoai.Text))
            {
                MessageBox.Show("Vui lòng điền đủ thông tin", "Thiếu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string ngaySinh = TxtNgaySinh.Value.ToString("yyyy-MM-dd");


            if (isEdit)
            {

                if (!DataBase.SVCheckSelf(TxtMaSV, TxtEmail, "Email"))
                {
                    MessageBox.Show("Trùng Email!", "Trùng dữ lệu!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!DataBase.SVCheckSelf(TxtMaSV, TxtDienThoai, "SoDienThoai"))
                {
                    MessageBox.Show("Trùng Số Điện Thoại!", "Trùng dữ lệu!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var sqlEdit = $"UPDATE SinhVien SET HoTen = N'{TxtTenSV.Text}', NgaySinh = '{ngaySinh}', GioiTinh = N'{GetGioiTinh()}', DiaChi = N'{TxtDiaChi.Text}', Email = '{TxtEmail.Text}', SoDienThoai = '{TxtDienThoai.Text}' WHERE MaSV = '{TxtMaSV.Text}'";
                DataBase.SetData(sqlEdit);
                isEdit = false;
            }
            else
            {
                //MessageBox.Show("SAYGEX69", "SAVEHEX^(", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (!DataBase.UniqueCheck(TxtMaSV, "MaSV"))
                {
                    MessageBox.Show("Trùng Mã Sinh Viên!", "Trùng dữ lệu!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!DataBase.UniqueCheck(TxtEmail, "Email"))
                {
                    MessageBox.Show("Trùng Email!", "Trùng dữ lệu!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!DataBase.UniqueCheck(TxtDienThoai, "SoDienThoai"))
                {
                    MessageBox.Show("Trùng Số Điện Thoại!", "Trùng dữ lệu!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var sqlInsert = $"INSERT INTO SinhVien(MaSV, HoTen, NgaySinh, GioiTinh, DiaChi, Email, SoDienThoai, MaLop) VALUES('{TxtMaSV.Text}',N'{TxtTenSV.Text}','{ngaySinh}',N'{GetGioiTinh()}',N'{TxtDiaChi.Text}','{TxtEmail.Text}','{TxtDienThoai.Text}','{CboLop.SelectedValue}')";
                DataBase.SetData(sqlInsert);
                MessageBox.Show("Đã thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            LoadKhachHang();
            SetEnable(false);
        }

        private void BtnHuy_Click(object sender, EventArgs e)
        {
            isEdit = true;
            this.SetEnable(false); // Không cho phép sửa thông tin trên form
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (TxtMaSV.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng chọn một sinh viên để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var traLoi = MessageBox.Show($"Bạn có chắc xóa sinh viên {TxtTenSV.Text} không?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (traLoi == DialogResult.Yes)
            {
                var sqlDelete = $"DELETE FROM SinhVien WHERE MaSV = '{TxtMaSV.Text}'";
                if (DataBase.SetData(sqlDelete)) LoadKhachHang();
                else MessageBox.Show("Xóa không thành công!");
            }
        }

        private void BtnTaiLai_Click(object sender, EventArgs e) { this.LoadKhachHang(); }

        private void DgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Debug.WriteLine(CboLop.SelectedValue);
            TxtMaSV.Text = DgvKhachHang.Rows[e.RowIndex].Cells["MaSV"].Value.ToString();
            TxtTenSV.Text = DgvKhachHang.Rows[e.RowIndex].Cells["HoTen"].Value.ToString();
            TxtNgaySinh.Text = DgvKhachHang.Rows[e.RowIndex].Cells["NgaySinh"].Value.ToString();
            TxtDiaChi.Text = DgvKhachHang.Rows[e.RowIndex].Cells["DiaChi"].Value.ToString();
            TxtEmail.Text = DgvKhachHang.Rows[e.RowIndex].Cells["Email"].Value.ToString();
            TxtDienThoai.Text = DgvKhachHang.Rows[e.RowIndex].Cells["SoDienThoai"].Value.ToString();
            var gioiTinh = DgvKhachHang.Rows[e.RowIndex].Cells["GioiTinh"].Value.ToString();
            if (gioiTinh == "Nam")
            {
                radNam.Checked = true;
                radNu.Checked = false;
            }
            else if (gioiTinh == "Nữ")
            {
                radNam.Checked = false;
                radNu.Checked = true;
            }
            else
            {
                radNam.Checked = false;
                radNu.Checked = false;
            }
            CboLop.SelectedValue = DgvKhachHang.Rows[e.RowIndex].Cells["MaLop"].Value;
            //TxtMaLop.Text = DgvKhachHang.Rows[e.RowIndex].Cells["MaLop"].Value.ToString();

            this.SetEnable(false); // Không cho phép sửa thông tin trên form
        }
    }
}
