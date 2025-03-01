using System.Diagnostics;

namespace Nhom1_WFA_QLSV
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            txtKhoa.Text = DataBase.SlKhoa.ToString();
            txtLop.Text = DataBase.SlLop.ToString();
            txtSLSV.Text = DataBase.SlSV.ToString();


            Debug.WriteLine("NAS");
        }

        private void navQLSV_Click(object sender, EventArgs e)
        {
            QuanLySinhVien f = new();
            f.Show();
        }
    }
}
