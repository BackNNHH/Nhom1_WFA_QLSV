using Microsoft.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using Timer = System.Windows.Forms.Timer;

namespace Nhom1_WFA_QLSV
{
    public partial class QuanLySinhVien : BaseMaterialForm
    {
        bool isEdit = false;
        bool isSearch = false;
        public QuanLySinhVien()
        {
            InitializeComponent();
            CauHinhSystem.LoadMeme(this);
            if (ThemeManager.IsDarkMode)
            {
                DgvKhachHang.DefaultCellStyle = new DataGridViewCellStyle() { BackColor = Color.FromArgb(255, 50, 50, 50) };
            }
            else
            {
                DgvKhachHang.DefaultCellStyle = new DataGridViewCellStyle() { BackColor = Color.FromArgb(255, 242, 242, 242) };
            }
        }

        private void QuanLySinhVien_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
            Timer timer = new Timer();
            timer.Interval = 30;
            timer.Tick += (s, ev) =>
            {
                if (this.Opacity < 1) this.Opacity += 0.05;
                else timer.Stop();
            };
            timer.Start();
            lbtMode.Text = "";
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
        //void setSear(bool sear)
        //{
        //    isSearch = !sear;
        //}
        private void BtnThem_Click(object sender, EventArgs e)
        {
            lbtMode.Text = "Bạn đang ở chế độ THÊM!";
            SetEnable(true);
            isEdit = false;
            //xóa giá trị đang nhập 
            TxtMaSV.Clear();
            TxtTenSV.Clear();
            TxtNgaySinh.Refresh();
            TxtDiaChi.Clear();
            TxtDienThoai.Clear();
            TxtDiaChi.Clear();
            TxtEmail.Clear();
            TxtDienThoai.Clear();
            TxtMaSV.Clear();
            radNam.Checked = true;
            radNu.Checked = false;
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            lbtMode.Text = "Bạn đang ở chế độ SỬA!";
            SetEnable(true);
            isEdit = true;
            TxtMaSV.Enabled = false;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (isSearch)
            {
                string query = "SELECT * FROM SinhVien WHERE 1=1";

                if (!string.IsNullOrEmpty(TxtMaSV.Text)) query += " AND MaSV LIKE @MaSV";
                if (!string.IsNullOrEmpty(TxtTenSV.Text)) query += " AND HoTen LIKE @HoTen";
                //if (!string.IsNullOrEmpty(TxtNgaySinh.Text)) query += " AND NgaySinh = @NgaySinh";
                if (GetGioiTinh() != "N/A") query += " AND GioiTinh LIKE @GioiTinh";
                if (!string.IsNullOrEmpty(TxtDiaChi.Text)) query += " AND DiaChi LIKE @DiaChi";
                if (!string.IsNullOrEmpty(TxtEmail.Text)) query += " AND Email LIKE @Email";
                if (!string.IsNullOrEmpty(TxtDienThoai.Text)) query += " AND SoDienThoai LIKE @DienThoai";
                if (!string.IsNullOrEmpty(CboLop.Text)) query += " AND MaLop LIKE @MaLop";
                try
                {
                    using SqlConnection connection = new(DataBase.DbStr);
                    using SqlCommand command = new(query, connection);

                    if (!string.IsNullOrEmpty(TxtMaSV.Text)) command.Parameters.AddWithValue("@MaSV", "%" + TxtMaSV.Text + "%");
                    if (!string.IsNullOrEmpty(TxtTenSV.Text)) command.Parameters.AddWithValue("@HoTen", "%" + TxtTenSV.Text + "%");
                    //if (!string.IsNullOrEmpty(TxtNgaySinh.Text)) command.Parameters.AddWithValue("@NgaySinh", TxtNgaySinh.Value.ToString("yyyy-MM-dd"));
                    if (GetGioiTinh() != "N/A") command.Parameters.AddWithValue("@GioiTinh", GetGioiTinh());
                    if (!string.IsNullOrEmpty(TxtDiaChi.Text)) command.Parameters.AddWithValue("@DiaChi", "%" + TxtDiaChi.Text + "%");
                    if (!string.IsNullOrEmpty(TxtEmail.Text)) command.Parameters.AddWithValue("@Email", "%" + TxtEmail.Text + "%");
                    if (!string.IsNullOrEmpty(TxtDienThoai.Text)) command.Parameters.AddWithValue("@DienThoai", "%" + TxtDienThoai.Text + "%");
                    if (!string.IsNullOrEmpty(CboLop.Text)) command.Parameters.AddWithValue("@MaLop", CboLop.SelectedValue);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dt = new();
                    dt.Load(reader);
                    reader.Close();
                    DgvKhachHang.DataSource = dt;
                }
                catch (Exception ex) { MessageBox.Show("OMG YOU GET 'CON BỌ' lớn: " + ex.Message); }
            }
            else
            {
                isSearch = true;
                BtnThem_Click(sender, e);
                lbtMode.Text = "Bạn đang ở chế độ TÌM KIẾM!";
                SetEnable(true);
                TxtNgaySinh.Enabled = false;
                BtnThem.Enabled = false;
                BtnSua.Enabled = false;
                BtnXoa.Enabled = false;
                BtnLuu.Enabled = false;
                BtnHuy.Enabled = true;

                radNam.Checked = false; radNu.Checked = false;
                CboLop.Text = string.Empty;//""???
            }
        }
        public string GetGioiTinh()
        {
            string gioiTinh = "Nam";
            if (radNu.Checked) gioiTinh = "Nữ";
            else if (!radNam.Checked) gioiTinh = "N/A";
            return gioiTinh;
        }
        private void BtnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtMaSV.Text) || string.IsNullOrEmpty(TxtTenSV.Text) || string.IsNullOrEmpty(TxtNgaySinh.Text) || string.IsNullOrEmpty(TxtDiaChi.Text) || string.IsNullOrEmpty(TxtEmail.Text) || string.IsNullOrEmpty(TxtDienThoai.Text))
            {
                MessageBox.Show("Vui lòng điền đủ thông tin", "Thiếu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(TxtDienThoai.Text, out _))
            {
                MessageBox.Show("Số điện thoại không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!TxtEmail.Text.Contains("@"))
            {
                MessageBox.Show("Email không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                var traLoi = MessageBox.Show($"Bạn có muốn lưu thay đổi sinh viên {TxtTenSV.Text} không?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traLoi == DialogResult.Yes)
                {
                    var sqlEdit = $"UPDATE SinhVien SET HoTen = N'{TxtTenSV.Text}', NgaySinh = '{ngaySinh}', GioiTinh = N'{GetGioiTinh()}', DiaChi = N'{TxtDiaChi.Text}', Email = '{TxtEmail.Text}', SoDienThoai = '{TxtDienThoai.Text}' WHERE MaSV = '{TxtMaSV.Text}'";
                    if (DataBase.SetData(sqlEdit)) MessageBox.Show("Đã sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else MessageBox.Show("Sửa thất bại!");
                }
                isEdit = false;
            }
            else
            {
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
            lbtMode.Text = "";
            isEdit = true;
            isSearch = false;
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

        private void BtnTaiLai_Click(object sender, EventArgs e)
        {
            this.LoadKhachHang();
            if (isSearch)
            {
                radNam.Checked = false; radNu.Checked = false;
                CboLop.Text = string.Empty;
                BtnHuy_Click(sender, e);
            }
        }

        private void DgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex >= 0 && e.RowIndex < DgvKhachHang.Rows.Count)) return;
            //if (isEdit)
            //{
            //    var ask = MessageBox.Show($"Bạn có chắc hủy chỉnh sủa sinh viên {TxtTenSV.Text} không?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //    if (ask == DialogResult.Yes) return;
            //}


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
            if (!isSearch)
                this.SetEnable(false); // Không cho phép sửa thông tin trên form
        }

        private void QuanLySinhVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Timer timer = new Timer();
            timer.Interval = 30;
            timer.Tick += (s, ev) =>
            {
                if (this.Opacity > 0) this.Opacity -= 0.05;
                else
                {
                    timer.Stop();
                    e.Cancel = false;
                    this.Close();
                }
            };
            timer.Start();
        }
    }
}
