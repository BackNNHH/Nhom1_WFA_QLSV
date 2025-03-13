
using System.Diagnostics;

namespace Nhom1_WFA_QLSV
{
    public partial class Main : BaseMaterialForm
    {
        private AverageScoreChart avgScoreChart;

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
            avgScoreChart = new AverageScoreChart(chartScores);

            // Dữ liệu mẫu (có thể thay bằng dữ liệu từ CSDL)
            Dictionary<string, double> dailyAverages = new Dictionary<string, double>
            {
                { "10/03", 7.5 },
                { "11/03", 8.2 },
                { "12/03", 6.8 },
                { "13/03", 9.1 },
                { "14/03", 7.9 }
            };

            avgScoreChart.SetDailyAverageData(dailyAverages);
        }


        private void Main_Load(object sender, EventArgs e)
        {

            DataBase.UpateData();
            txtKhoa.Text = DataBase.SlKhoa.ToString();
            txtLop.Text = DataBase.SlLop.ToString();
            txtSLSV.Text = DataBase.SlSV.ToString();
            LblUserName.Text = DataBase.username;


            Debug.WriteLine("NAS");
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

    }
}
