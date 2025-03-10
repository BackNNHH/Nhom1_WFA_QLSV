using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom1_WFA_QLSV
{
    class DataBase
    {

        public static string ChuoiKetNoi
        {
            get
            {
                // Tuan Dung
                return
                @"Data Source=Dung;
                  Initial Catalog=QLSINHVIEN;
                  Integrated Security=True;
                  Trust Server Certificate=True";
            }
        }

        public static string DbStr
        {
            get
            {
                return//CHIDAI
                @"Data Source = CHIDAI;Integrated Security = True;Initial Catalog = QLSinhVien;Trust Server Certificate=True";
            }
        }
        public static DataTable GetData(string sql)
        {
            DataTable dt = new DataTable();
            var connection = new SqlConnection(DbStr);
            var dataAdapter = new SqlDataAdapter(sql, connection);
            dataAdapter.Fill(dt);
            return dt;
        }
        public static DataTable UserLogTest(string user,string pass)
        {
            DataTable dt = new();
            SqlConnection connection = new(DbStr);

            SqlDataAdapter adapter = new($"SELECT * FROM NhanVien WHERE MaDN={user} AND MatKhau = {pass}", connection);
            adapter.Fill(dt);
            return dt;
        }
    }
}
