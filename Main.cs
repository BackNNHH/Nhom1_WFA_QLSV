
using Microsoft.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using Timer = System.Windows.Forms.Timer;

namespace Nhom1_WFA_QLSV
{
    public partial class Main : BaseMaterialForm
    {
        public AverageScoreChart avgScoreChart;
        public DateTime now = DateTime.Now;

        //public bool DaDangNhap { get; set; } = false;
        //public void PhanQuyen()
        //{
        //    nav.Enabled = DaDangNhap;
        //    MnuDangXuat.Enabled = DaDangNhap;
        //}
        public Main()
        {
            InitializeComponent();
            CauHinhSystem.LoadMeme(this);
            UpdateChartData();
            LoadChartData();
        }


        private void Main_Load(object sender, EventArgs e)
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
            DataBase.UpateData();
            lbKhoa.Text = DataBase.SlKhoa.ToString();
            lbLop.Text = DataBase.SlLop.ToString();
            lbSV.Text = DataBase.SlSV.ToString();
            lbMVP.Text = GetMVPStudent();
            LblUserName.Text = DataBase.username;
        }

        private void UpdateChartData()
        {
            if (!IsTodayUpdated())
            {
                if (chartScores != null)
                {
                    try
                    {
                        List<double> scores = new List<double>();
                        double avgScore = 0;

                        using (SqlConnection conn = new SqlConnection(DataBase.DbStr))
                        {
                            string query = @"
                            SELECT DiemTX, DiemGK, DiemCK, 
                            COALESCE(((DiemTX * 2) + (DiemGK * 3) + (DiemCK * 5)) / 10.0, NULL) AS DiemTB
                            FROM Diem;";

                            SqlCommand cmd = new SqlCommand(query, conn);
                            conn.Open();
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    double score = reader.GetDouble(3);
                                    scores.Add(score);
                                }
                            }
                        }

                        if (scores.Count > 0)
                        {
                            avgScore = scores.Average();


                            using (SqlConnection conn = new SqlConnection(DataBase.DbStr))
                            {
                                string query = "INSERT INTO StudentScores(DateRecorded, AverageScore) VALUES (@now, @avgScore)";
                                using (SqlCommand cmd = new SqlCommand(query, conn))
                                {
                                    cmd.Parameters.AddWithValue("@now", DateTime.Now);
                                    cmd.Parameters.AddWithValue("@avgScore", avgScore);

                                    conn.Open();
                                    cmd.ExecuteNonQuery();
                                }
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


        private bool IsTodayUpdated()
        {
            using (SqlConnection conn = new SqlConnection(DataBase.DbStr))
            {
                string query = "SELECT COUNT(*) FROM StudentScores WHERE DateRecorded = CAST(GETDATE() AS DATE)";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        private void LoadChartData()
        {
            Dictionary<string, double> dailyAverages = new Dictionary<string, double>();
            DataTable dataTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(DataBase.DbStr))
            {
                string query = "SELECT TOP 7 DateRecorded, AverageScore FROM StudentScores ORDER BY DateRecorded ASC";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    string date = Convert.ToDateTime(row["DateRecorded"]).ToString("dd/MM");
                    double avgScore = Convert.ToDouble(row["AverageScore"]);
                    dailyAverages[date] = avgScore;
                }
            }
            avgScoreChart = new AverageScoreChart(chartScores);
            // Cập nhật biểu đồ
            avgScoreChart.SetDailyAverageData(dailyAverages);
        }

        private string GetMVPStudent()
        {
            string name;
            using (SqlConnection conn = new SqlConnection(DataBase.DbStr))
            {
                string query = @"
                    SELECT TOP 1 sv.HoTen,
                    COALESCE(((bd.DiemTX*2) + (bd.DiemGK*3) + (bd.DiemCK*5)) / 10.0, NULL) AS DiemTB
                    FROM SinhVien sv
                    LEFT JOIN Diem bd ON sv.MaSV = bd.MaSV
                    ORDER BY DiemTB DESC";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                name = (string)cmd.ExecuteScalar();
            }
            return name;
        }

        private void navQLSV_Click(object sender, EventArgs e)
        {
            QuanLySinhVien f = new();
            f.Show();
        }

        private void MnuDangNhap_Click(object sender, EventArgs e)
        {
            var f = new SignIn();
            f.Show();
        }

        private void nhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new NhapDiem();
            f.Show();
        }

        private void MnuDangXuat_Click(object sender, EventArgs e)
        {
            DataBase.username = "";
            var f = new SignIn();
            f.Show();
            this.Hide();

        }

        private void cấuHìnhHệThôgsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new CauHinhSystem();
            f.Show();
        }

        private void xemDdieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new XemDiem();
            f.Show();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
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
