using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom1_WFA_QLSV
{
    public partial class QuanLySinhVien : Form
    {
        bool isEdit = false;
        public QuanLySinhVien()
        {
            InitializeComponent();
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
            TxtMaSV.Enabled = enable;

            //set bộ nút (Thêm/Sửa trái ngược với textbox ở trên) 
            BtnThem.Enabled = !enable;
            BtnSua.Enabled = !enable;
            //không cho xóa khi đang edit (enable = True) 
            BtnXoa.Enabled = !isEdit;
            BtnHuy.Enabled = enable;
            BtnLuu.Enabled = enable;
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            SetEnable(true);

            //xóa giá trị đang nhập 
            TxtMaSV.Clear();
            TxtTenSV.Clear();
            TxtDiaChi.Clear();
            TxtDienThoai.Clear();
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            SetEnable(true);
            isEdit = true;
            TxtMaSV.Enabled = false;
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            //if (isEdit)//đang sửa 
            //{
            //    var sqlEdit = $"UPDATE KhachHang SET TenCty = N'{TxtTenSV.Text}', DiaChi = N'{TxtDiaChi.Text}', DienThoai = '{TxtDienThoai.Text}', MaThanhPho ='{CboThanhPho.SelectedValue}' WHERE MaKH = '{TxtMaSV.Text}'";

            //    DataBase.SetData(sqlEdit);
            //    isEdit = false;
            //}
            //else
            //{
            //    var sqlInsert = $"INSERT INTO KhachHang(MaKH, TenCty, DiaChi, DienThoai, MaThanhPho) VALUES('{TxtMaSV.Text}', N'{TxtTenSV.Text}', '{TxtDiaChi.Text}', '{TxtDienThoai.Text}', '{CboThanhPho.SelectedValue}')";

            //    DataBase.SetData(sqlInsert);
            //}

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
            //dựa vào textbox mã khách hàng để xóa 
            if (TxtMaSV.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng chọn một khách hàng để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var traLoi = MessageBox.Show("Bạn có chắc xóa khách hàng không?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (traLoi == DialogResult.Yes)
            {
                var sqlDelete = $"DELETE FROM KhachHang WHERE MaKH = '{TxtMaSV.Text}'";
                if (DataBase.SetData(sqlDelete))
                {
                    LoadKhachHang();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công!");
                }
            }
        }

        private void BtnTaiLai_Click(object sender, EventArgs e) { this.LoadKhachHang(); }

        private void DgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtMaSV.Text = DgvKhachHang.Rows[e.RowIndex].Cells["MaSV"].Value.ToString();
            TxtTenSV.Text = DgvKhachHang.Rows[e.RowIndex].Cells["HoTen"].Value.ToString();
            TxtNgaySinh.Text = DgvKhachHang.Rows[e.RowIndex].Cells["NgaySinh"].Value.ToString();
            TxtDiaChi.Text = DgvKhachHang.Rows[e.RowIndex].Cells["DiaChi"].Value.ToString();
            TxtEmail.Text = DgvKhachHang.Rows[e.RowIndex].Cells["Email"].Value.ToString();
            TxtDienThoai.Text = DgvKhachHang.Rows[e.RowIndex].Cells["SoDienThoai"].Value.ToString();
            //TxtMaLop.Text = DgvKhachHang.Rows[e.RowIndex].Cells["MaLop"].Value.ToString();

            this.SetEnable(false); // Không cho phép sửa thông tin trên form
        }
    }
}
