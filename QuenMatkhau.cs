using System.Data;

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
    }
}
