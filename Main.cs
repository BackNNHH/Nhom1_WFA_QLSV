using System.Diagnostics;

namespace Nhom1_WFA_QLSV
{
    public partial class Main : Form
    {

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
    }
}
