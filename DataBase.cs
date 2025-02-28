using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom1_WFA_QLSV
{
    public class DataBase
    {
        public static string username = "";
        public static string password = "";

        public static int SlSV = 0;
        public static int SlLop = 0;
        public static int SlKhoa = 0;










        public static string DbStr
        {
            get
            {
                return//CHIDAI
                @"Data Source = CHIDAI;Integrated Security = True;Initial Catalog = QLSinhVien;Trust Server Certificate=True";
            }
        }
        public static void UpateData()
        {
            SlKhoa = GetData("SELECT MaKhoa FROM Khoa").Rows.Count;
            SlLop = GetData("SELECT MaLop FROM LopHoc").Rows.Count;
            SlSV = GetData("SELECT MaSV FROM SinhVien").Rows.Count;

            //Debug.WriteLine(dt.Rows.Count);
            //Debug.WriteLine(dataAdapter);
        }
        public static DataTable GetData(string sql)
        {
            DataTable dt = new DataTable();
            var connection = new SqlConnection(DbStr);
            var dataAdapter = new SqlDataAdapter(sql, connection);
            dataAdapter.Fill(dt);
            return dt;
        }
        public static DataTable UserLogTest(string user, string pass)
        {
            DataTable dt = new();
            //SqlConnection connection = new(DbStr);
            SqlDataAdapter adapter = new($"SELECT * FROM Users WHERE username='{user}' AND password = '{pass}'", new SqlConnection(DbStr));
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
#pragma warning disable CS8601
                username = row["username"].ToString();
                password = row["password"].ToString();
#pragma warning restore CS8601
            }
            return dt;
        }
    }
}