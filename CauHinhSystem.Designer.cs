namespace Nhom1_WFA_QLSV
{
    partial class CauHinhSystem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            coloDiag = new ColorDialog();
            label1 = new Label();
            btnBgC = new Button();
            label2 = new Label();
            fontDiag = new FontDialog();
            cboFont = new ComboBox();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(242, 242, 242);
            label1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            label1.Location = new Point(49, 97);
            label1.Name = "label1";
            label1.Size = new Size(50, 17);
            label1.TabIndex = 0;
            label1.Text = "Theme";
            // 
            // btnBgC
            // 
            btnBgC.BackColor = Color.FromArgb(242, 242, 242);
            btnBgC.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnBgC.ForeColor = Color.FromArgb(222, 0, 0, 0);
            btnBgC.Location = new Point(148, 91);
            btnBgC.Name = "btnBgC";
            btnBgC.Size = new Size(201, 23);
            btnBgC.TabIndex = 1;
            btnBgC.Text = "Đổi";
            btnBgC.UseVisualStyleBackColor = false;
            btnBgC.Click += btnBgC_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(242, 242, 242);
            label2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            label2.Location = new Point(49, 127);
            label2.Name = "label2";
            label2.Size = new Size(37, 17);
            label2.TabIndex = 0;
            label2.Text = "Font";
            // 
            // cboFont
            // 
            cboFont.BackColor = Color.FromArgb(242, 242, 242);
            cboFont.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            cboFont.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboFont.FormattingEnabled = true;
            cboFont.Location = new Point(148, 127);
            cboFont.Name = "cboFont";
            cboFont.Size = new Size(201, 25);
            cboFont.TabIndex = 2;
            cboFont.SelectedIndexChanged += cboFont_SelectedIndexChanged;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.BackColor = Color.FromArgb(242, 242, 242);
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(343, 202);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(158, 36);
            materialButton1.TabIndex = 3;
            materialButton1.Text = "materialButton1";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = false;
            // 
            // CauHinhSystem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(materialButton1);
            Controls.Add(cboFont);
            Controls.Add(btnBgC);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CauHinhSystem";
            ShowIcon = false;
            Text = "CauHinhSystem";
            Load += CauHinhSystem_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ColorDialog coloDiag;
        private Label label1;
        private Button btnBgC;
        private Label label2;
        private FontDialog fontDiag;
        private ComboBox cboFont;
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}