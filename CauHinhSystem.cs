using MaterialSkin.Controls;
using System.Diagnostics;
using System.Windows.Forms;

namespace Nhom1_WFA_QLSV
{
    public partial class CauHinhSystem : MaterialForm
    {
        private static Color _cColor= Properties.Settings.Default.BackColor;
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

        private void btnBgC_Click(object sender, EventArgs e)
        {
            DialogResult result = coloDiag.ShowDialog();
            if (result == DialogResult.OK)
            {

                CurrentColor = coloDiag.Color;
                //Color selectedColor = coloDiag.Color;
                //this.BackColor = selectedColor;
                Properties.Settings.Default.BackColor = CurrentColor;
                this.BackColor = coloDiag.Color;
                ApplyTTAF();

            }
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

        private void btnF_Click(object sender, EventArgs e)
        {
            DialogResult result = fontDiag.ShowDialog();
            if (result == DialogResult.OK)
            {

                CurrentFont = fontDiag.Font;
                //this.BackColor = coloDiag.Color;
                ApplyTTAF();

            }
        }
    }

}