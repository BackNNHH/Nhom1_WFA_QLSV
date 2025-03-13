using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace Nhom1_WFA_QLSV
{
    public class CustomMaterialButton : MaterialButton
    {
        private Color _customBackColor = Color.Red; // Màu nền mặc định
        private string _customText = "Button"; // Chữ mặc định
        private Color _customTextColor = Color.White; // Màu chữ mặc định
        private int _borderRadius = 20; // Bo tròn góc
        private Color _borderColor = Color.Black;
        private int _borderSize = 2;

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

        [Category("Custom Properties")]
        public int BorderRadius
        {
            get { return _borderRadius; }
            set
            {
                _borderRadius = Math.Max(0, value);
                this.Invalidate();
            }
        }

        [Category("Custom Properties")]
        public Color BorderColor
        {
            get { return _borderColor; }
            set
            {
                _borderColor = value;
                this.Invalidate();
            }
        }

        [Category("Custom Properties")]
        public int BorderSize
        {
            get { return _borderSize; }
            set
            {
                _borderSize = Math.Max(0, value);
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

            // Tạo đường viền bo tròn
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, _borderRadius, _borderRadius, 180, 90);
            path.AddArc(Width - _borderRadius, 0, _borderRadius, _borderRadius, 270, 90);
            path.AddArc(Width - _borderRadius, Height - _borderRadius, _borderRadius, _borderRadius, 0, 90);
            path.AddArc(0, Height - _borderRadius, _borderRadius, _borderRadius, 90, 90);
            path.CloseFigure();

            this.Region = new Region(path); // Cắt button theo đường viền tròn

            // Vẽ viền ngoài
            using (Pen pen = new Pen(_borderColor, _borderSize))
            {
                pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                pevent.Graphics.DrawPath(pen, path);
            }
        }

        public override bool AutoSize
        {
            get;
            set;
         
        } = false;
    }
}
