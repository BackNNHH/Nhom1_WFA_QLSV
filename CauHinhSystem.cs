using MaterialSkin;
using MaterialSkin.Controls;
using System.Diagnostics;
using System.Windows.Forms;

namespace Nhom1_WFA_QLSV
{
    public partial class CauHinhSystem : BaseMaterialForm
    {
        private static Color _cColor = Properties.Settings.Default.BackColor;
        private static Font _cFont = Properties.Settings.Default.Font;

        public static Color CurrentColor
        {
            get { return _cColor; }
            set
            {
                _cColor = value;
                ApplyTTAF();
            }
        }
        public static Font CurrentFont
        {
            get { return _cFont; }
            set
            {
                _cFont = value;
                ApplyTTAF();
            }
        }
        public static void LoadMeme(Form f)
        {
            ApplyTTF(f);
        }
        public CauHinhSystem()
        {
            InitializeComponent();
            //_cColor = this.BackColor;
        }

        public static void ApplyTTAF()
        {
            foreach (Form form in Application.OpenForms)
            {
                ApplyTTF(form);
            }
        }

        private static void ApplyTTF(Form form)//ThemeToForm
        {
            form.BackColor = _cColor;
            form.Font = _cFont;
            foreach (Control control in form.Controls) ApplyTTControl(control);
        }

        private static void ApplyTTControl(Control control)
        {
            control.BackColor = _cColor;
            //control.Font = _cFont;
            float currentSize = control.Font.Size;
            control.Font = new Font(_cFont.FontFamily, currentSize);
            if (control is Label label) label.BackColor = Color.Transparent;
            foreach (Control childControl in control.Controls) ApplyTTControl(childControl);

        }

        //private void btnF_Click(object sender, EventArgs e)
        //{
        //    DialogResult result = fontDiag.ShowDialog();
        //    if (result == DialogResult.OK)
        //    {

        //        CurrentFont = fontDiag.Font;
        //        //this.BackColor = coloDiag.Color;
        //        ApplyTTAF();

        //    }
        //}

        private void CauHinhSystem_Load(object sender, EventArgs e)
        {
            LoadFF();
            mtrbtnPassword.Hide();
            mtrbtnNewPassword.Hide();
        }

        void LoadFF()
        {
            cboFont.Text = CurrentFont.Name;
            FontFamily[] ff = FontFamily.Families;
            foreach (FontFamily f in ff)
            {
                cboFont.Items.Add(f.Name);
            }
        }

        private void cboFont_SelectedIndexChanged(object sender, EventArgs e)
        {

            CurrentFont = new Font(cboFont.Text, 9);
            ApplyTTAF();
        }

        private void rjToggleButton1_CheckedChanged(object sender, EventArgs e)
        {
            ThemeManager.ToggleTheme();
            if (ThemeManager.IsDarkMode)
            {
                _cColor = SystemColors.WindowFrame;
            }
        }


        private void customMaterialButton1_Click_1(object sender, EventArgs e)
        {
            int count = 0;
            mtrbtnPassword.Show();
            if (!String.IsNullOrEmpty(mtrbtnPassword.Text))
            {
                var traLoi = MessageBox.Show("Bạn có chắc xóa tài khoản không?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traLoi == DialogResult.Yes)
                {
                    var sqlDelete = $"DELETE FROM Users WHERE username = '{DataBase.username}'";
                    DataBase.TruyVanXuLyDuLieu(sqlDelete);
                    MessageBox.Show("Xóa không thành công!");
                    Application.Restart();
                }
            }
            if (count == 2)
            {
                mtrbtnPassword.Hide();
            }
        }

        private void customMaterialButton2_Click_1(object sender, EventArgs e)
        {
            int count = 0;
            mtrbtnPassword.Show();
            mtrbtnNewPassword.Show();

            if (!String.IsNullOrEmpty(mtrbtnNewPassword.Text) && !String.IsNullOrEmpty(mtrbtnPassword.Text))
            {
                string OldPass = mtrbtnPassword.Text;
                String NewPass = mtrbtnNewPassword.Text;
                var sqlUpdate = $"UPDATE Users SET password = '{NewPass}' WHERE password = '{OldPass}'";
                DataBase.SetData(sqlUpdate);
                MessageBox.Show("Cập nhật thông tin!");
            }
            if (count == 2)
            {
                mtrbtnPassword.Hide();
                mtrbtnNewPassword.Hide();
            }
        }
    }
}