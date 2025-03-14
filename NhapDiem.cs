using Microsoft.Data.SqlClient;
using System.Data;
using Timer = System.Windows.Forms.Timer;

namespace Nhom1_WFA_QLSV
{
    public partial class NhapDiem : BaseMaterialForm
    {
        public NhapDiem()
        {
            InitializeComponent();
            //CauHinhSystem.LoadMeme(this);
        }



        private void LoadMonHocTheoSinhVien(string mssv)
        {
            try
            {
                SqlConnection conn = new SqlConnection(DataBase.DbStr);

                conn.Open();
                string query = @"
                   SELECT MonHoc.MaMon, MonHoc.TenMon
                   FROM DangKyMonHoc
                   INNER JOIN MonHoc ON DangKyMonHoc.MaMon = MonHoc.MaMon
                   WHERE DangKyMonHoc.MaSV = @MaSV";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaSV", mssv);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cbMonHoc.DataSource = dt;
                cbMonHoc.DisplayMember = "TenMon"; // Hiển thị tên môn học
                cbMonHoc.ValueMember = "MaMon";   // Lưu mã môn học
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }




        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            string mssv = txtMSSV.Text;
            string monHoc = cbMonHoc.Text;
            float diemTX, diemGK, diemCK;

            if (string.IsNullOrWhiteSpace(mssv))
            {
                MessageBox.Show("Vui lòng nhập MSSV hợp lệ.");
                return;
            }


            // Kiểm tra nhập liệu
            if (string.IsNullOrWhiteSpace(mssv) || string.IsNullOrWhiteSpace(monHoc) ||
                !float.TryParse(txtDiemTX.Text, out diemTX) ||
                !float.TryParse(txtDiemGK.Text, out diemGK) ||
                !float.TryParse(txtDiemGK.Text, out diemCK))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ và đúng định dạng điểm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Lưu dữ liệu vào CSDL (Ví dụ: SQL Server)
            string connectionString = DataBase.DbStr;
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();
            string query = "INSERT INTO Diem(MaSV, TenMon, DiemTX, DiemGK, DiemCK) VALUES (@MaSV, @TenMon, @DiemTX, @DiemGK, @DiemCK)";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@MaSV", mssv);
            cmd.Parameters.AddWithValue("@TenMon", monHoc);
            cmd.Parameters.AddWithValue("@DiemTX", diemTX);
            cmd.Parameters.AddWithValue("@DiemGK", diemGK);
            cmd.Parameters.AddWithValue("@DiemCK", diemCK);

            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Lưu điểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtMSSV_TextChanged_1(object sender, EventArgs e)
        {
            string mssv = txtMSSV.Text.Trim();
            if (!string.IsNullOrEmpty(mssv))
            {
                LoadMonHocTheoSinhVien(mssv);
            }
            else
            {
                MessageBox.Show("Hãy nhập mã sinh viên trước khi chọn môn!");
            }
        }

        private void NhapDiem_FormClosing(object sender, FormClosingEventArgs e)
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

        private void NhapDiem_Load_1(object sender, EventArgs e)
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
        }
    }


}
