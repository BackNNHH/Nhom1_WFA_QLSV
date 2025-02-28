using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom1_WFA_QLSV
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            Debug.WriteLine(txtUserName.Text + txtPass.Text);
            DataTable tableNhanVien = DataBase.UserLogTest(txtUserName.Text, txtPass.Text);
            if (string.IsNullOrEmpty(txtUserName.Text) || string.IsNullOrEmpty(txtPass.Text))
                MessageBox.Show("Bạn lại một lần nữa, tại sao không dùng app saygex sáu mười chín, ở đây chúng tôi có những...sẵn sàng mọi lúc mọi nơi!", "SAYGEX NOITE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            if (tableNhanVien.Rows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Chức mừng, bạn đã đăng nhập thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    Main formChinh = new();
                    formChinh.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Chức mừng, bạn đã trúng 1 bịt thạch dừa 500kg!🐧", "SAYGEX NOITE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnPuchClick(object sender, EventArgs e)
        {
            Debug.WriteLine("⠀⠀⠀⠀⠀⠀⢀⣤⣀⣀⣀⠀⠈⠻⣷⣄\n⠀⠀⠀⠀⢀⣴⣿⣿⣿⡿⠋⠀⠀⠀⠹⣿⣦⡀\n⠀⠀⢀⣴⣿⣿⣿⣿⣏⠀⠀⠀⠀⠀⠀⢹⣿⣧\n⠀⠀⠙⢿⣿⡿⠋⠻⣿⣿⣦⡀⠀⠀⠀⢸⣿⣿⡆\n⠀⠀⠀⠀⠉⠀⠀⠀⠈⠻⣿⣿⣦⡀⠀⢸⣿⣿⡇\n⠀⠀⠀⠀⢀⣀⣄⡀⠀⠀⠈⠻⣿⣿⣶⣿⣿⣿⠁\n⠀⠀⠀⣠⣿⣿⢿⣿⣶⣶⣶⣶⣾⣿⣿⣿⣿⡁\n⢠⣶⣿⣿⠋⠀⠉⠛⠿⠿⠿⠿⠿⠛⠻⣿⣿⣦⡀\n⣿⣿⠟⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠻⣿⡿");
        }
    }
}
