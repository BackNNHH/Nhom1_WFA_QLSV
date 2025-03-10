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
        public static void UpateData()
        {
            var connection = new SqlConnection(DbStr);
            connection.Open();
            try
            {
                SlKhoa = Convert.ToInt32(new SqlCommand("SELECT COUNT(*) FROM Khoa", connection).ExecuteScalar());
                SlLop = Convert.ToInt32(new SqlCommand("SELECT COUNT(*) FROM LopHoc", connection).ExecuteScalar());
                SlSV = Convert.ToInt32(new SqlCommand("SELECT COUNT(*) FROM SinhVien", connection).ExecuteScalar());
            }
            catch
            {
                SlKhoa = GetData("SELECT MaKhoa FROM Khoa").Rows.Count;
                SlLop = GetData("SELECT MaLop FROM LopHoc").Rows.Count;
                SlSV = GetData("SELECT MaSV FROM SinhVien").Rows.Count;
            }
            connection.Close();
            //Debug.WriteLine(result);
            //Debug.WriteLine(dataAdapter);
        }
        public static bool UniqueCheck(TextBox source, string where, string from = "SinhVien")
        {
            var connection = new SqlConnection(DbStr);
            connection.Open();
            int co = (int)new SqlCommand($"SELECT COUNT(*) FROM {from} WHERE {where} = '{source.Text}'", connection).ExecuteScalar();
            connection.Close();
            return co == 0;
        }
        public static bool SVCheckSelf(TextBox MaSV, TextBox data,string where)
        {
            var dt = GetData($"SELECT * FROM SinhVien WHERE {where} = '{data.Text}'");

            if (dt.Rows.Count == 1)
            {
                if (MaSV.Text == dt.Rows[0]["MaSV"].ToString())
                    return true;
            }
            return false;
        }
        public static DataTable GetData(string sql)
        {
            DataTable dt = new DataTable();
            var connection = new SqlConnection(DbStr);
            var dataAdapter = new SqlDataAdapter(sql, connection);
            dataAdapter.Fill(dt);
            return dt;
        }
        public static bool SetData(string sql)
        {
            try
            {
                var connection = new SqlConnection(DbStr);
                var command = new SqlCommand(sql, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
                command.Connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return false;
            }
        }
        public static DataTable UserLogTest(string user, string pass, string token = "")
        {
            bool TOKENburh = string.IsNullOrEmpty(token);
            DataTable dt = new();
            //SqlConnection connection = new(DbStr);
            string data;

            if (TOKENburh) data = $"SELECT * FROM Users WHERE username='{user}' AND password = '{pass}'";
            else data = $"SELECT * FROM Users WHERE username='{user}' AND keyword = '{token}'";

            SqlDataAdapter adapter = new(data, new SqlConnection(DbStr));
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
#pragma warning disable CS8601
                username = row["username"].ToString();
                if (TOKENburh)
                {
                    SetData($"UPDATE Users SET password = '{pass}' WHERE id = '{row["id"]}'");
                    password = pass;
                }
                else
                    password = row["password"].ToString();
#pragma warning restore CS8601
            }
            return dt;
        }
    }
}