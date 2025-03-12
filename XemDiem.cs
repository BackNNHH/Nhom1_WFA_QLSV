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
#pragma warning disable CS8604 // Possible null reference argument.
                cboLop.Items.Add(row["TenLop"].ToString());
#pragma warning restore CS8604 // Possible null reference argument.
            }

            // Chọn mặc định là "Tất cả"
            cboLop.SelectedIndex = 0;

        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void mtrtxtName_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                string lop = cboLop.SelectedItem?.ToString(); // Lớp đang chọn
                string searchName = mtrtxtName.Text.Trim();  // Tên đang nhập

                using (SqlConnection conn = new SqlConnection(DataBase.DbStr))
                {
                    conn.Open();
                    string searchQuery = @"
                    SELECT sv.MaSV, sv.HoTen, lh.TenLop, bd.TenMon, bd.DiemTX, bd.DiemGK, bd.DiemCK,
                    COALESCE(((bd.DiemTX*2) + (bd.DiemGK*3) + (bd.DiemCK*5)) / 10.0, NULL) AS DiemTB
                    FROM SinhVien sv
                    LEFT JOIN Diem bd ON sv.MaSV = bd.MaSV
                    INNER JOIN LopHoc lh ON sv.MaLop = lh.MaLop";

                    List<SqlParameter> parameters = new List<SqlParameter>();
                    List<string> conditions = new List<string>();

                    // Lọc theo lớp
                    if (!string.IsNullOrEmpty(lop) && lop != "Tất cả")
                    {
                        conditions.Add("lh.TenLop = @Lop");
                        parameters.Add(new SqlParameter("@Lop", lop));
                    }

                    // Lọc theo tên sinh viên
                    if (!string.IsNullOrEmpty(searchName))
                    {
                        conditions.Add("sv.HoTen LIKE @SearchName");
                        parameters.Add(new SqlParameter("@SearchName", "%" + searchName + "%"));
                    }

                    // Nếu có điều kiện thì thêm WHERE vào truy vấn
                    if (conditions.Count > 0)
                    {
                        searchQuery += " WHERE " + string.Join(" AND ", conditions);
                    }

                    using (SqlCommand cmd = new SqlCommand(searchQuery, conn))
                    {
                        cmd.Parameters.AddRange(parameters.ToArray());

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
