using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace Nhom1_WFA_QLSV
{
    public class CustomMaterialButton : MaterialButton
    {
        private Color _customBackColor = Color.Red; // Màu nền mặc định
        private string _customText = "Button"; // Chữ mặc định
        private Color _customTextColor = Color.White; // Màu chữ mặc định

        [Category("Custom Properties")]
        public Color CustomBackColor
        {
            get { return _customBackColor; }
            set
            {
                _customBackColor = value;
                this.Invalidate(); // Vẽ lại button khi đổi màu
            }
        }

        [Category("Custom Properties")]
        public string CustomText
        {
            get { return _customText; }
            set
            {
                _customText = value;
                this.Invalidate(); // Vẽ lại chữ khi thay đổi
            }
        }

        [Category("Custom Properties")]
        public Color CustomTextColor
        {
            get { return _customTextColor; }
            set
            {
                _customTextColor = value;
                this.Invalidate();
            }
        }

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            // Không cho MaterialSkin vẽ nền gốc
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            // Vẽ nền với màu CustomBackColor
            using (SolidBrush brush = new SolidBrush(_customBackColor))
            {
                pevent.Graphics.FillRectangle(brush, this.ClientRectangle);
            }

            // Vẽ chữ với màu CustomTextColor
            using (SolidBrush textBrush = new SolidBrush(_customTextColor))
            {
                SizeF textSize = pevent.Graphics.MeasureString(_customText, this.Font);
                PointF textPosition = new PointF(
                    (this.Width - textSize.Width) / 2,
                    (this.Height - textSize.Height) / 2
                );
                pevent.Graphics.DrawString(_customText, this.Font, textBrush, textPosition);
            }
        }

        public override bool AutoSize
        {
            get;
            set;
         
        } = false;
    }
}
