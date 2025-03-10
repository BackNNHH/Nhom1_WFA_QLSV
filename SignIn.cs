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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Nhom1_WFA_QLSV
{
    public partial class SignIn : Form
    { 
        public SignIn()
        {
            InitializeComponent();
        }


        private void btnSign_Click(object sender, EventArgs e)
        {
            //DataTable table = new();
            Debug.WriteLine(txtUserName.Text + txtPass.Text);
            if (string.IsNullOrEmpty(txtUserName.Text) || string.IsNullOrEmpty(txtPass.Text))
            {
                //MessageBox.Show("Bạn lại một lần nữa, tại sao không dùng app...", "****** NOITE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                texWarm.Text = "Vui lòng nhập đầy đủ thông tin!";
                return;
            }
            else
            {
                DataTable table = DataBase.UserLogTest(txtUserName.Text, txtPass.Text);
                if (table.Rows.Count > 0)
                {
                    DataBase.UpateData();
                    Main formChinh = new();
                    formChinh.Show();
                    this.Hide();
                }
                else
                {
                    //MessageBox.Show("Chức mừng, bạn đã trúng 1 bịt thạch dừa 500kg!🐧", "SAYGEX NOITE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    texWarm.Text = "User name hoặc password không hợp lệ!";
                }
            }
        }

        private void btnPuchClick(object sender, EventArgs e)
        {
            Debug.WriteLine("+------------------------------------------------------------------------------------+");
            //DataBase.UpateData();
            txtUserName.Text = "DungCT";
            txtPass.Text = "capi";


            Debug.WriteLine("⠀⠀⠀⠀⠀⠀⢀⣤⣀⣀⣀⠀⠈⠻⣷⣄\n⠀⠀⠀⠀⢀⣴⣿⣿⣿⡿⠋⠀⠀⠀⠹⣿⣦⡀\n⠀⠀⢀⣴⣿⣿⣿⣿⣏⠀⠀⠀⠀⠀⠀⢹⣿⣧\n⠀⠀⠙⢿⣿⡿⠋⠻⣿⣿⣦⡀⠀⠀⠀⢸⣿⣿⡆\n⠀⠀⠀⠀⠉⠀⠀⠀⠈⠻⣿⣿⣦⡀⠀⢸⣿⣿⡇\n⠀⠀⠀⠀⢀⣀⣄⡀⠀⠀⠈⠻⣿⣿⣶⣿⣿⣿⠁\n⠀⠀⠀⣠⣿⣿⢿⣿⣶⣶⣶⣶⣾⣿⣿⣿⣿⡁\n⢠⣶⣿⣿⠋⠀⠉⠛⠿⠿⠿⠿⠿⠛⠻⣿⣿⣦⡀\n⣿⣿⠟⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠻⣿⡿");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            QuenMatkhau f = new();
            f.UserNCache = string.IsNullOrEmpty(txtUserName.Text) ? "" : txtUserName.Text;
            f.Show();
        }

    }
}
