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
            fontDiag = new FontDialog();
            cboFont = new ComboBox();
            groupBox1 = new GroupBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            tggbtn = new RJToggleButton();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            groupBox3 = new GroupBox();
            materialButton3 = new MaterialSkin.Controls.MaterialButton();
            materialButton2 = new MaterialSkin.Controls.MaterialButton();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            pictureBox3 = new PictureBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            mbtnKYS = new MaterialSkin.Controls.MaterialButton();
            label3 = new Label();
            materialButton4 = new MaterialSkin.Controls.MaterialButton();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // cboFont
            // 
            cboFont.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cboFont.BackColor = Color.FromArgb(242, 242, 242);
            cboFont.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            cboFont.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboFont.FormattingEnabled = true;
            cboFont.ItemHeight = 17;
            cboFont.Location = new Point(487, 33);
            cboFont.Name = "cboFont";
            cboFont.Size = new Size(201, 25);
            cboFont.TabIndex = 2;
            cboFont.SelectedIndexChanged += cboFont_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(242, 242, 242);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cboFont);
            groupBox1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            groupBox1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            groupBox1.Location = new Point(49, 177);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(706, 81);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Font";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(242, 242, 242);
            pictureBox2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            pictureBox2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            pictureBox2.Image = Properties.Resources.Font_Icon;
            pictureBox2.Location = new Point(6, 18);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(61, 57);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(242, 242, 242);
            label1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            label1.Location = new Point(88, 36);
            label1.Name = "label1";
            label1.Size = new Size(242, 17);
            label1.TabIndex = 3;
            label1.Text = "Font được sửa dụng hầu hết các form\r\n";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(242, 242, 242);
            groupBox2.Controls.Add(tggbtn);
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Controls.Add(label2);
            groupBox2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            groupBox2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            groupBox2.Location = new Point(49, 90);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(706, 81);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Theme";
            // 
            // tggbtn
            // 
            tggbtn.BackColor = Color.FromArgb(242, 242, 242);
            tggbtn.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            tggbtn.ForeColor = Color.FromArgb(222, 0, 0, 0);
            tggbtn.Location = new Point(588, 26);
            tggbtn.Margin = new Padding(3, 2, 3, 2);
            tggbtn.MinimumSize = new Size(39, 16);
            tggbtn.Name = "tggbtn";
            tggbtn.OffBackColor = SystemColors.ControlLightLight;
            tggbtn.OffToggleColor = Color.Black;
            tggbtn.OnBackColor = SystemColors.ActiveCaptionText;
            tggbtn.OnToggleColor = Color.White;
            tggbtn.Size = new Size(100, 36);
            tggbtn.TabIndex = 5;
            tggbtn.UseVisualStyleBackColor = false;
            tggbtn.CheckedChanged += rjToggleButton1_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(242, 242, 242);
            pictureBox1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            pictureBox1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            pictureBox1.Image = Properties.Resources.theme_10;
            pictureBox1.Location = new Point(6, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(242, 242, 242);
            label2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            label2.Location = new Point(88, 26);
            label2.Name = "label2";
            label2.Size = new Size(323, 51);
            label2.TabIndex = 3;
            label2.Text = "Loại chủ đề đang sửa dụng\r\ncó 2 loại gồm chủ đề sáng và chủ đề tối...\r\nCó một số form cần load lại để áp dụng chuyển đổi!";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(242, 242, 242);
            groupBox3.Controls.Add(materialButton4);
            groupBox3.Controls.Add(materialButton3);
            groupBox3.Controls.Add(materialButton2);
            groupBox3.Controls.Add(materialButton1);
            groupBox3.Controls.Add(pictureBox3);
            groupBox3.Controls.Add(textBox2);
            groupBox3.Controls.Add(textBox1);
            groupBox3.Controls.Add(mbtnKYS);
            groupBox3.Controls.Add(label3);
            groupBox3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            groupBox3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            groupBox3.Location = new Point(49, 264);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(706, 165);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Account";
            // 
            // materialButton3
            // 
            materialButton3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton3.BackColor = Color.FromArgb(242, 242, 242);
            materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton3.Depth = 0;
            materialButton3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialButton3.HighEmphasis = true;
            materialButton3.Icon = null;
            materialButton3.Location = new Point(540, 133);
            materialButton3.Margin = new Padding(4, 6, 4, 6);
            materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton3.Name = "materialButton3";
            materialButton3.NoAccentTextColor = Color.Empty;
            materialButton3.Size = new Size(158, 36);
            materialButton3.TabIndex = 10;
            materialButton3.Text = "materialButton3";
            materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton3.UseAccentColor = false;
            materialButton3.UseVisualStyleBackColor = false;
            // 
            // materialButton2
            // 
            materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton2.BackColor = Color.FromArgb(242, 242, 242);
            materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = null;
            materialButton2.Location = new Point(154, 120);
            materialButton2.Margin = new Padding(4, 6, 4, 6);
            materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(158, 36);
            materialButton2.TabIndex = 9;
            materialButton2.Text = "materialButton2";
            materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = false;
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
            materialButton1.Location = new Point(308, 104);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(158, 36);
            materialButton1.TabIndex = 8;
            materialButton1.Text = "materialButton1";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(242, 242, 242);
            pictureBox3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            pictureBox3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            pictureBox3.Image = Properties.Resources.oooo_oo;
            pictureBox3.Location = new Point(6, 18);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(61, 57);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(242, 242, 242);
            textBox2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            textBox2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            textBox2.Location = new Point(249, 46);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 24);
            textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(242, 242, 242);
            textBox1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            textBox1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            textBox1.Location = new Point(92, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 24);
            textBox1.TabIndex = 6;
            // 
            // mbtnKYS
            // 
            mbtnKYS.AutoSize = false;
            mbtnKYS.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mbtnKYS.BackColor = Color.Red;
            mbtnKYS.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            mbtnKYS.Depth = 0;
            mbtnKYS.ForeColor = Color.Red;
            mbtnKYS.HighEmphasis = true;
            mbtnKYS.Icon = null;
            mbtnKYS.Location = new Point(467, 46);
            mbtnKYS.Margin = new Padding(4, 6, 4, 6);
            mbtnKYS.MouseState = MaterialSkin.MouseState.HOVER;
            mbtnKYS.Name = "mbtnKYS";
            mbtnKYS.NoAccentTextColor = Color.Empty;
            mbtnKYS.Size = new Size(201, 36);
            mbtnKYS.TabIndex = 5;
            mbtnKYS.Text = "KillYouSelf";
            mbtnKYS.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            mbtnKYS.UseAccentColor = true;
            mbtnKYS.UseVisualStyleBackColor = false;
            mbtnKYS.Click += mbtnKYS_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(242, 242, 242);
            label3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            label3.Location = new Point(73, 20);
            label3.Name = "label3";
            label3.Size = new Size(215, 17);
            label3.TabIndex = 3;
            label3.Text = "DELETE or Change you password";
            // 
            // materialButton4
            // 
            materialButton4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton4.BackColor = Color.LightGray;
            materialButton4.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton4.Depth = 0;
            materialButton4.ForeColor = Color.LightGray;
            materialButton4.HighEmphasis = true;
            materialButton4.Icon = null;
            materialButton4.Location = new Point(407, 43);
            materialButton4.Margin = new Padding(4, 6, 4, 6);
            materialButton4.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton4.Name = "materialButton4";
            materialButton4.NoAccentTextColor = Color.Empty;
            materialButton4.Size = new Size(158, 36);
            materialButton4.TabIndex = 11;
            materialButton4.Text = "materialButton4";
            materialButton4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton4.UseAccentColor = false;
            materialButton4.UseVisualStyleBackColor = false;
            // 
            // CauHinhSystem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "CauHinhSystem";
            ShowIcon = false;
            Text = " ";
            Load += CauHinhSystem_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ColorDialog coloDiag;
        private FontDialog fontDiag;
        private ComboBox cboFont;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private GroupBox groupBox3;
        private MaterialSkin.Controls.MaterialButton mbtnKYS;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private RJToggleButton tggbtn;
        private PictureBox pictureBox3;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private MaterialSkin.Controls.MaterialButton materialButton4;
    }
}