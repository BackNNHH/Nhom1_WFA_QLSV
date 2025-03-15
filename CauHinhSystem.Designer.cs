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
            mtrbtnNewPassword = new MaterialSkin.Controls.MaterialTextBox();
            mtrbtnPassword = new MaterialSkin.Controls.MaterialTextBox();
            customMaterialButton2 = new CustomMaterialButton();
            customMaterialButton1 = new CustomMaterialButton();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
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
            cboFont.Location = new Point(557, 44);
            cboFont.Margin = new Padding(3, 4, 3, 4);
            cboFont.Name = "cboFont";
            cboFont.Size = new Size(229, 25);
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
            groupBox1.Location = new Point(56, 236);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(807, 108);
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
            pictureBox2.Location = new Point(7, 24);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(70, 76);
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
            label1.Location = new Point(101, 48);
            label1.Name = "label1";
            label1.Size = new Size(259, 18);
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
            groupBox2.Location = new Point(56, 120);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(807, 108);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Theme";
            // 
            // tggbtn
            // 
            tggbtn.BackColor = Color.FromArgb(242, 242, 242);
            tggbtn.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            tggbtn.ForeColor = Color.FromArgb(222, 0, 0, 0);
            tggbtn.Location = new Point(672, 35);
            tggbtn.MinimumSize = new Size(45, 21);
            tggbtn.Name = "tggbtn";
            tggbtn.OffBackColor = SystemColors.ControlLightLight;
            tggbtn.OffToggleColor = Color.Black;
            tggbtn.OnBackColor = SystemColors.ActiveCaptionText;
            tggbtn.OnToggleColor = Color.White;
            tggbtn.Size = new Size(114, 48);
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
            pictureBox1.Location = new Point(7, 24);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 76);
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
            label2.Location = new Point(101, 35);
            label2.Name = "label2";
            label2.Size = new Size(354, 54);
            label2.TabIndex = 3;
            label2.Text = "Loại chủ đề đang sửa dụng\r\ncó 2 loại gồm chủ đề sáng và chủ đề tối...\r\nCó một số form cần load lại để áp dụng chuyển đổi!";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(242, 242, 242);
            groupBox3.Controls.Add(mtrbtnNewPassword);
            groupBox3.Controls.Add(mtrbtnPassword);
            groupBox3.Controls.Add(customMaterialButton2);
            groupBox3.Controls.Add(customMaterialButton1);
            groupBox3.Controls.Add(pictureBox3);
            groupBox3.Controls.Add(label3);
            groupBox3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            groupBox3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            groupBox3.Location = new Point(56, 352);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(807, 220);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Account";
            // 
            // mtrbtnNewPassword
            // 
            mtrbtnNewPassword.AnimateReadOnly = false;
            mtrbtnNewPassword.BackColor = Color.FromArgb(242, 242, 242);
            mtrbtnNewPassword.BorderStyle = BorderStyle.None;
            mtrbtnNewPassword.Depth = 0;
            mtrbtnNewPassword.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mtrbtnNewPassword.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mtrbtnNewPassword.Hint = "Mật Khẩu Mới";
            mtrbtnNewPassword.LeadingIcon = null;
            mtrbtnNewPassword.Location = new Point(101, 115);
            mtrbtnNewPassword.MaxLength = 50;
            mtrbtnNewPassword.MouseState = MaterialSkin.MouseState.OUT;
            mtrbtnNewPassword.Multiline = false;
            mtrbtnNewPassword.Name = "mtrbtnNewPassword";
            mtrbtnNewPassword.Size = new Size(181, 36);
            mtrbtnNewPassword.TabIndex = 11;
            mtrbtnNewPassword.Text = "";
            mtrbtnNewPassword.TrailingIcon = null;
            mtrbtnNewPassword.UseTallSize = false;
            // 
            // mtrbtnPassword
            // 
            mtrbtnPassword.AnimateReadOnly = false;
            mtrbtnPassword.BackColor = Color.FromArgb(242, 242, 242);
            mtrbtnPassword.BorderStyle = BorderStyle.None;
            mtrbtnPassword.Depth = 0;
            mtrbtnPassword.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mtrbtnPassword.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mtrbtnPassword.Hint = "Mật khẩu";
            mtrbtnPassword.LeadingIcon = null;
            mtrbtnPassword.Location = new Point(101, 53);
            mtrbtnPassword.MaxLength = 50;
            mtrbtnPassword.MouseState = MaterialSkin.MouseState.OUT;
            mtrbtnPassword.Multiline = false;
            mtrbtnPassword.Name = "mtrbtnPassword";
            mtrbtnPassword.Size = new Size(181, 36);
            mtrbtnPassword.TabIndex = 10;
            mtrbtnPassword.Text = "";
            mtrbtnPassword.TrailingIcon = null;
            mtrbtnPassword.UseTallSize = false;
            // 
            // customMaterialButton2
            // 
            customMaterialButton2.AutoSize = false;
            customMaterialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            customMaterialButton2.BackColor = Color.FromArgb(242, 242, 242);
            customMaterialButton2.BorderColor = Color.Black;
            customMaterialButton2.BorderRadius = 20;
            customMaterialButton2.BorderSize = 2;
            customMaterialButton2.CustomBackColor = Color.White;
            customMaterialButton2.CustomText = "Đổi Mật Khẩu";
            customMaterialButton2.CustomTextColor = Color.Black;
            customMaterialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            customMaterialButton2.Depth = 0;
            customMaterialButton2.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Pixel);
            customMaterialButton2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            customMaterialButton2.HighEmphasis = true;
            customMaterialButton2.Icon = null;
            customMaterialButton2.Location = new Point(494, 115);
            customMaterialButton2.Margin = new Padding(5);
            customMaterialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            customMaterialButton2.Name = "customMaterialButton2";
            customMaterialButton2.NoAccentTextColor = Color.Empty;
            customMaterialButton2.Size = new Size(149, 45);
            customMaterialButton2.TabIndex = 9;
            customMaterialButton2.Text = "customMaterialButton2";
            customMaterialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            customMaterialButton2.UseAccentColor = false;
            customMaterialButton2.UseVisualStyleBackColor = false;
            customMaterialButton2.Click += customMaterialButton2_Click_1;
            // 
            // customMaterialButton1
            // 
            customMaterialButton1.AutoSize = false;
            customMaterialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            customMaterialButton1.BackColor = Color.FromArgb(242, 242, 242);
            customMaterialButton1.BorderColor = Color.Black;
            customMaterialButton1.BorderRadius = 20;
            customMaterialButton1.BorderSize = 2;
            customMaterialButton1.CustomBackColor = Color.Red;
            customMaterialButton1.CustomText = "Xóa Tài Khoản";
            customMaterialButton1.CustomTextColor = Color.Black;
            customMaterialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            customMaterialButton1.Depth = 0;
            customMaterialButton1.FlatStyle = FlatStyle.Flat;
            customMaterialButton1.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Pixel);
            customMaterialButton1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            customMaterialButton1.HighEmphasis = true;
            customMaterialButton1.Icon = null;
            customMaterialButton1.Location = new Point(494, 40);
            customMaterialButton1.Margin = new Padding(5);
            customMaterialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            customMaterialButton1.Name = "customMaterialButton1";
            customMaterialButton1.NoAccentTextColor = Color.Empty;
            customMaterialButton1.Size = new Size(149, 45);
            customMaterialButton1.TabIndex = 8;
            customMaterialButton1.Text = "customMaterialButton1";
            customMaterialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            customMaterialButton1.UseAccentColor = false;
            customMaterialButton1.UseVisualStyleBackColor = false;
            customMaterialButton1.Click += customMaterialButton1_Click_1;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(242, 242, 242);
            pictureBox3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            pictureBox3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            pictureBox3.Image = Properties.Resources.registration;
            pictureBox3.Location = new Point(7, 24);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(70, 76);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(242, 242, 242);
            label3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            label3.Location = new Point(83, 27);
            label3.Name = "label3";
            label3.Size = new Size(231, 18);
            label3.TabIndex = 3;
            label3.Text = "DELETE or Change you password";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // CauHinhSystem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 587);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CauHinhSystem";
            Padding = new Padding(3, 85, 3, 4);
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = " Cấu Hình Hệ Thống";
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
        private Label label3;
        private RJToggleButton tggbtn;
        private PictureBox pictureBox3;
        private CustomMaterialButton customMaterialButton1;
        private CustomMaterialButton customMaterialButton2;
        private MaterialSkin.Controls.MaterialTextBox mtrbtnNewPassword;
        private MaterialSkin.Controls.MaterialTextBox mtrbtnPassword;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}