namespace Nhom1_WFA_QLSV
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            panel1 = new Panel();
            nav = new MenuStrip();
            navQLSV = new ToolStripMenuItem();
            nhaToolStripMenuItem = new ToolStripMenuItem();
            xemDdieToolStripMenuItem = new ToolStripMenuItem();
            đăngNhậpToolStripMenuItem = new ToolStripMenuItem();
            cấuHìnhHệThôgsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            MnuDangXuat = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            texSLSV = new Label();
            txtSLSV = new TextBox();
            texMVP = new Label();
            textBox1 = new TextBox();
            texLop = new Label();
            txtLop = new TextBox();
            texKhoa = new Label();
            txtKhoa = new TextBox();
            LblUserName = new Label();
            panel1.SuspendLayout();
            nav.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(242, 242, 242);
            panel1.Controls.Add(nav);
            panel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            panel1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            panel1.Location = new Point(0, 71);
            panel1.Name = "panel1";
            panel1.Size = new Size(142, 379);
            panel1.TabIndex = 2;
            // 
            // nav
            // 
            nav.BackColor = Color.FromArgb(242, 242, 242);
            nav.Dock = DockStyle.Left;
            nav.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            nav.ForeColor = Color.FromArgb(222, 0, 0, 0);
            nav.ImageScalingSize = new Size(20, 20);
            nav.Items.AddRange(new ToolStripItem[] { navQLSV, nhaToolStripMenuItem, xemDdieToolStripMenuItem, đăngNhậpToolStripMenuItem });
            nav.Location = new Point(0, 0);
            nav.Name = "nav";
            nav.Size = new Size(134, 379);
            nav.TabIndex = 2;
            nav.Text = "menuStrip1";
            // 
            // navQLSV
            // 
            navQLSV.Name = "navQLSV";
            navQLSV.Size = new Size(121, 21);
            navQLSV.Text = "Quản Lý sinh viên";
            navQLSV.Click += navQLSV_Click;
            // 
            // nhaToolStripMenuItem
            // 
            nhaToolStripMenuItem.Name = "nhaToolStripMenuItem";
            nhaToolStripMenuItem.Size = new Size(121, 21);
            nhaToolStripMenuItem.Text = "Nhập điểm ";
            nhaToolStripMenuItem.Click += nhaToolStripMenuItem_Click;
            // 
            // xemDdieToolStripMenuItem
            // 
            xemDdieToolStripMenuItem.Name = "xemDdieToolStripMenuItem";
            xemDdieToolStripMenuItem.Size = new Size(121, 21);
            xemDdieToolStripMenuItem.Text = "Xem điểm";
            xemDdieToolStripMenuItem.Click += xemDdieToolStripMenuItem_Click;
            // 
            // đăngNhậpToolStripMenuItem
            // 
            đăngNhậpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cấuHìnhHệThôgsToolStripMenuItem, toolStripSeparator1, MnuDangXuat, toolStripSeparator2, thoátToolStripMenuItem });
            đăngNhậpToolStripMenuItem.Image = Properties.Resources.systemIc;
            đăngNhậpToolStripMenuItem.Name = "đăngNhậpToolStripMenuItem";
            đăngNhậpToolStripMenuItem.Size = new Size(121, 24);
            đăngNhậpToolStripMenuItem.Text = "Hệ Thống";
            // 
            // cấuHìnhHệThôgsToolStripMenuItem
            // 
            cấuHìnhHệThôgsToolStripMenuItem.Image = Properties.Resources.setting;
            cấuHìnhHệThôgsToolStripMenuItem.Name = "cấuHìnhHệThôgsToolStripMenuItem";
            cấuHìnhHệThôgsToolStripMenuItem.Size = new Size(196, 26);
            cấuHìnhHệThôgsToolStripMenuItem.Text = "Cấu hình hệ thống";
            cấuHìnhHệThôgsToolStripMenuItem.Click += cấuHìnhHệThôgsToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(193, 6);
            // 
            // MnuDangXuat
            // 
            MnuDangXuat.Image = Properties.Resources.signout;
            MnuDangXuat.Name = "MnuDangXuat";
            MnuDangXuat.Size = new Size(196, 26);
            MnuDangXuat.Text = "Đăng xuất";
            MnuDangXuat.Click += MnuDangXuat_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(193, 6);
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Image = Properties.Resources.exit;
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(196, 26);
            thoátToolStripMenuItem.Text = "Thoát";
            // 
            // texSLSV
            // 
            texSLSV.AutoSize = true;
            texSLSV.BackColor = Color.FromArgb(242, 242, 242);
            texSLSV.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            texSLSV.ForeColor = Color.FromArgb(222, 0, 0, 0);
            texSLSV.Location = new Point(216, 144);
            texSLSV.Name = "texSLSV";
            texSLSV.Size = new Size(128, 17);
            texSLSV.TabIndex = 3;
            texSLSV.Text = "Số Lượng Sinh Viên";
            // 
            // txtSLSV
            // 
            txtSLSV.BackColor = Color.FromArgb(242, 242, 242);
            txtSLSV.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSLSV.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtSLSV.Location = new Point(347, 141);
            txtSLSV.Name = "txtSLSV";
            txtSLSV.ReadOnly = true;
            txtSLSV.Size = new Size(100, 24);
            txtSLSV.TabIndex = 4;
            txtSLSV.Text = "N/A";
            // 
            // texMVP
            // 
            texMVP.AutoSize = true;
            texMVP.BackColor = Color.FromArgb(242, 242, 242);
            texMVP.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            texMVP.ForeColor = Color.FromArgb(222, 0, 0, 0);
            texMVP.Location = new Point(216, 173);
            texMVP.Name = "texMVP";
            texMVP.Size = new Size(98, 17);
            texMVP.TabIndex = 3;
            texMVP.Text = "Sinh Viên MVP";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(242, 242, 242);
            textBox1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            textBox1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            textBox1.Location = new Point(347, 170);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(100, 24);
            textBox1.TabIndex = 4;
            textBox1.Text = "N/A";
            // 
            // texLop
            // 
            texLop.AutoSize = true;
            texLop.BackColor = Color.FromArgb(242, 242, 242);
            texLop.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            texLop.ForeColor = Color.FromArgb(222, 0, 0, 0);
            texLop.Location = new Point(493, 141);
            texLop.Name = "texLop";
            texLop.Size = new Size(95, 17);
            texLop.TabIndex = 3;
            texLop.Text = "Số Lượng Lớp";
            // 
            // txtLop
            // 
            txtLop.BackColor = Color.FromArgb(242, 242, 242);
            txtLop.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtLop.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtLop.Location = new Point(608, 138);
            txtLop.Name = "txtLop";
            txtLop.ReadOnly = true;
            txtLop.Size = new Size(100, 24);
            txtLop.TabIndex = 4;
            txtLop.Text = "N/A";
            // 
            // texKhoa
            // 
            texKhoa.AutoSize = true;
            texKhoa.BackColor = Color.FromArgb(242, 242, 242);
            texKhoa.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            texKhoa.ForeColor = Color.FromArgb(222, 0, 0, 0);
            texKhoa.Location = new Point(493, 173);
            texKhoa.Name = "texKhoa";
            texKhoa.Size = new Size(104, 17);
            texKhoa.TabIndex = 3;
            texKhoa.Text = "Số Lượng Khoa";
            // 
            // txtKhoa
            // 
            txtKhoa.BackColor = Color.FromArgb(242, 242, 242);
            txtKhoa.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtKhoa.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtKhoa.Location = new Point(608, 170);
            txtKhoa.Name = "txtKhoa";
            txtKhoa.ReadOnly = true;
            txtKhoa.Size = new Size(100, 24);
            txtKhoa.TabIndex = 4;
            txtKhoa.Text = "N/A";
            // 
            // LblUserName
            // 
            LblUserName.AutoSize = true;
            LblUserName.BackColor = Color.FromArgb(242, 242, 242);
            LblUserName.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LblUserName.ForeColor = Color.FromArgb(222, 0, 0, 0);
            LblUserName.Location = new Point(18, 7);
            LblUserName.Name = "LblUserName";
            LblUserName.Size = new Size(0, 17);
            LblUserName.TabIndex = 5;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblUserName);
            Controls.Add(textBox1);
            Controls.Add(texMVP);
            Controls.Add(txtKhoa);
            Controls.Add(texKhoa);
            Controls.Add(txtLop);
            Controls.Add(texLop);
            Controls.Add(txtSLSV);
            Controls.Add(texSLSV);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trang Chủ";
            Load += Main_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            nav.ResumeLayout(false);
            nav.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private MenuStrip nav;
        private ToolStripMenuItem navQLSV;
        private Label texSLSV;
        private TextBox txtSLSV;
        private Label texMVP;
        private TextBox textBox1;
        private Label texLop;
        private TextBox txtLop;
        private Label texKhoa;
        private TextBox txtKhoa;
        private ToolStripMenuItem nhaToolStripMenuItem;
        private ToolStripMenuItem đăngNhậpToolStripMenuItem;
        private ToolStripMenuItem cấuHìnhHệThôgsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem MnuDangXuat;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private Label LblUserName;
        private ToolStripMenuItem xemDdieToolStripMenuItem;
    }
}
