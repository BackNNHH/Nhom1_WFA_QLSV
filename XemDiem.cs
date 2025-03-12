using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.Logging;
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
    public partial class XemDiem : BaseMaterialForm
    {
        public XemDiem()
        {
            InitializeComponent();
            LoadDanhSachLop();
            if (ThemeManager.IsDarkMode == true)
            {
                dtgv.BackgroundColor = Color.Black;

            }
        }

        private void XemDiem_Load(object sender, EventArgs e)
        {

        }

        // Load danh sách lớp vào ComboBox
        private void LoadDanhSachLop()
        {
            SqlConnection conn = new SqlConnection(DataBase.DbStr);
            conn.Open();
            DataTable dt = DataBase.GetData("SELECT TenLop FROM LopHoc");

            // Xóa danh sách cũ trước khi thêm mới
            cboLop.Items.Clear();
            cboLop.Items.Add("Tất cả"); // Thêm tùy chọn "Tất cả"

            // Duyệt qua từng dòng trong DataTable và thêm vào ComboBox
            foreach (DataRow row in dt.Rows)
            {
                cboLop.Items.Add(row["TenLop"].ToString());
            }

            // Chọn mặc định là "Tất cả"
            cboLop.SelectedIndex = 0;

        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var lop = cboLop.SelectedItem?.ToString(); // Lấy giá trị từ ComboBox
                using (SqlConnection conn = new SqlConnection(DataBase.DbStr))
                {
                    conn.Open();

                    // Tạo truy vấn SQL cơ bản
                    string query = @"
                    SELECT sv.MaSV, sv.HoTen, lh.TenLop, bd.TenMon, bd.DiemTX, bd.DiemGK, bd.DiemCK
                    FROM SinhVien sv
                    LEFT JOIN Diem bd ON sv.MaSV = bd.MaSV
                    INNER JOIN LopHoc lh ON sv.MaLop = lh.MaLop";


                    // Nếu chọn lớp cụ thể thì thêm điều kiện WHERE
                    if (!string.IsNullOrEmpty(lop) && lop != "Tất cả")
                    {
                        query += " WHERE lh.TenLop = @Lop";
                    }

                    // Tạo SqlCommand sau khi query đã hoàn chỉnh
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (!string.IsNullOrEmpty(lop) && lop != "Tất cả")
                        {
                            cmd.Parameters.AddWithValue("@Lop", lop);
                        }

                        DataTable dt = new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);

                        dtgv.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }




    }
}
