using Microsoft.Data.SqlClient;
using System.Data;
using Syncfusion.WinForms.ListView;
using Timer = System.Windows.Forms.Timer;

namespace Nhom1_WFA_QLSV
{
    public partial class NhapDiem : BaseMaterialForm
    {
        private bool DiemTXIsValid = false;
        private bool DiemGKIsValid = false;
        private bool DiemCKIsValid = false;

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
            if (string.IsNullOrWhiteSpace(monHoc) ||
                !float.TryParse(txtDiemTX.Text, out diemTX) ||
                !float.TryParse(txtDiemGK.Text, out diemGK) ||
                !float.TryParse(txtDiemCK.Text, out diemCK))  // Sửa lỗi ở đây
            {
                MessageBox.Show("Vui lòng nhập đầy đủ và đúng định dạng điểm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Nếu bất kỳ giá trị nào không hợp lệ, dừng lại
            if (DiemTXIsValid ||
                DiemGKIsValid ||
                DiemCKIsValid)
            {
                return;
            }
            else
            {
                // Lưu dữ liệu vào CSDL (SQL Server)
                string connectionString = DataBase.DbStr;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Diem(MaSV, TenMon, DiemTX, DiemGK, DiemCK) VALUES (@MaSV, @TenMon, @DiemTX, @DiemGK, @DiemCK)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaSV", mssv);
                        cmd.Parameters.AddWithValue("@TenMon", monHoc);
                        cmd.Parameters.AddWithValue("@DiemTX", diemTX);
                        cmd.Parameters.AddWithValue("@DiemGK", diemGK);
                        cmd.Parameters.AddWithValue("@DiemCK", diemCK);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Lưu điểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void txtMSSV_TextChanged_1(object sender, EventArgs e)
        {
            string mssv = txtMSSV.Text.Trim();
            if (!string.IsNullOrEmpty(mssv))
            {
                if (IsDataExist(mssv))
                {
                    txtDiemTX.Enabled = true;
                    txtDiemGK.Enabled = true;
                    txtDiemCK.Enabled = true;
                    lbMSSV.Text = "";
                    LoadMonHocTheoSinhVien(mssv);
                }
                else
                {
                    lbMSSV.Text = "Sinh viên không tồn tại hoặc chưa đăng kí môn!";
                    lbMSSV.ForeColor = Color.Red;
                }
            }
            else
            {

            }
        }

        private bool IsDataExist(string studentID)
        {
            using (SqlConnection conn = new SqlConnection(DataBase.DbStr))
            {
                string query = "SELECT COUNT(*) FROM SinhVien WHERE MaSV = @MaSV";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaSV", studentID);

                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        private bool DiemIsCompleted(string studentID)
        {
            using (SqlConnection conn = new SqlConnection(DataBase.DbStr))
            {
                string query = "SELECT COUNT(*) FROM SinhVien WHERE MaSV = @MaSV";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaSV", studentID);

                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }


        private bool DiemIsValid(float diem, Label lb)
        {
            if (diem < 0 || diem > 10)
            {
                lb.Text = "Giá trị không hợp lệ!";
                lb.ForeColor = Color.Red;
                return false;
            }
            return true;
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
            txtDiemTX.Enabled = false;
            txtDiemGK.Enabled = false;
            txtDiemCK.Enabled = false;
            cbMonHoc.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbMonHoc.AutoCompleteSource = AutoCompleteSource.ListItems;
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

        private void txtDiemTX_TextChanged(object sender, EventArgs e)
        {
            float diemTX;
            float.TryParse(txtDiemTX.Text, out diemTX);
            if (DiemIsValid(diemTX, lbTX))
            {
                DiemTXIsValid = true;
            }
        }

        private void txtDiemGK_TextChanged(object sender, EventArgs e)
        {
            float diemGK;
            float.TryParse(txtDiemGK.Text, out diemGK);
            if (DiemIsValid(diemGK, lbGK))
            {
                DiemGKIsValid = true;
            }
        }

        private void txtDiemCK_TextChanged(object sender, EventArgs e)
        {
            float diemCK;
            float.TryParse(txtDiemCK.Text, out diemCK);
            if (DiemIsValid(diemCK, lbCK))
            {
                DiemCKIsValid = true;
            }
        }

    }
}

