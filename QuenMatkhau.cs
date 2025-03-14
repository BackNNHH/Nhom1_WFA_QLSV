using System.Data;
using Timer = System.Windows.Forms.Timer;

namespace Nhom1_WFA_QLSV
{
    public partial class QuenMatkhau : Form
    {
        public QuenMatkhau()
        {
            InitializeComponent();
        }
        public string userCache = "";
        public string UserNCache
        {
            get { return userCache; }
            set { userCache = value; txtUserName.Text = value; }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text) || string.IsNullOrEmpty(txtToken.Text) || string.IsNullOrEmpty(txtPass.Text))
            {
                //Debug.WriteLine("E");
                texWarm.Text = "Vui lòng nhập đầy đủ thông tin!";
            }
            else
            {
                //Debug.WriteLine(txtUserName.Text + txtToken.Text + txtPass.Text);
                DataTable table = DataBase.UserLogTest(txtUserName.Text, txtPass.Text, txtToken.Text);
                if (table.Rows.Count > 0) this.Hide();
                else texWarm.Text = "User name hoặc token không hợp lệ!";
            }
        }

        private void QuenMatkhau_FormClosing(object sender, FormClosingEventArgs e)
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

        private void QuenMatkhau_Load(object sender, EventArgs e)
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
        }
    }
}
