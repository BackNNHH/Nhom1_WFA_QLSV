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
            title = new Label();
            panel1 = new Panel();
            nav = new MenuStrip();
            navMain = new ToolStripMenuItem();
            navQLSV = new ToolStripMenuItem();
            nhaToolStripMenuItem = new ToolStripMenuItem();
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
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            title.ForeColor = SystemColors.HotTrack;
            title.Location = new Point(265, 32);
            title.Name = "title";
            title.Size = new Size(544, 46);
            title.TabIndex = 0;
            title.Text = "ỨNG DỤNG QUẢN LÝ SINH VIÊN";
            // 
            // panel1
            // 
            panel1.Controls.Add(nav);
            panel1.Location = new Point(0, 95);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(162, 505);
            panel1.TabIndex = 2;
            // 
            // nav
            // 
            nav.Dock = DockStyle.Left;
            nav.ImageScalingSize = new Size(20, 20);
            nav.Items.AddRange(new ToolStripItem[] { navMain, navQLSV, nhaToolStripMenuItem, đăngNhậpToolStripMenuItem });
            nav.Location = new Point(0, 0);
            nav.Name = "nav";
            nav.Padding = new Padding(7, 3, 0, 3);
            nav.Size = new Size(157, 505);
            nav.TabIndex = 2;
            nav.Text = "menuStrip1";
            // 
            // navMain
            // 
            navMain.Name = "navMain";
            navMain.Size = new Size(142, 24);
            navMain.Text = "Trang Chủ";
            // 
            // navQLSV
            // 
            navQLSV.Name = "navQLSV";
            navQLSV.Size = new Size(142, 24);
            navQLSV.Text = "Quản Lý sinh viên";
            navQLSV.Click += navQLSV_Click;
            // 
            // nhaToolStripMenuItem
            // 
            nhaToolStripMenuItem.Name = "nhaToolStripMenuItem";
            nhaToolStripMenuItem.Size = new Size(142, 24);
            nhaToolStripMenuItem.Text = "Nhập điểm ";
            nhaToolStripMenuItem.Click += nhaToolStripMenuItem_Click;
            // 
            // đăngNhậpToolStripMenuItem
            // 
            đăngNhậpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cấuHìnhHệThôgsToolStripMenuItem, toolStripSeparator1, MnuDangXuat, toolStripSeparator2, thoátToolStripMenuItem });
            đăngNhậpToolStripMenuItem.Name = "đăngNhậpToolStripMenuItem";
            đăngNhậpToolStripMenuItem.Size = new Size(142, 24);
            đăngNhậpToolStripMenuItem.Text = "Hệ Thống";
            // 
            // cấuHìnhHệThôgsToolStripMenuItem
            // 
            cấuHìnhHệThôgsToolStripMenuItem.Name = "cấuHìnhHệThôgsToolStripMenuItem";
            cấuHìnhHệThôgsToolStripMenuItem.Size = new Size(224, 26);
            cấuHìnhHệThôgsToolStripMenuItem.Text = "Cấu hình hệ thống";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(221, 6);
            // 
            // MnuDangXuat
            // 
            MnuDangXuat.Name = "MnuDangXuat";
            MnuDangXuat.Size = new Size(224, 26);
            MnuDangXuat.Text = "Đăng xuất";
            MnuDangXuat.Click += MnuDangXuat_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(221, 6);
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(224, 26);
            thoátToolStripMenuItem.Text = "Thoát";
            // 
            // texSLSV
            // 
            texSLSV.AutoSize = true;
            texSLSV.Location = new Point(265, 188);
            texSLSV.Name = "texSLSV";
            texSLSV.Size = new Size(137, 20);
            texSLSV.TabIndex = 3;
            texSLSV.Text = "Số Lượng Sinh Viên";
            // 
            // txtSLSV
            // 
            txtSLSV.Location = new Point(397, 184);
            txtSLSV.Margin = new Padding(3, 4, 3, 4);
            txtSLSV.Name = "txtSLSV";
            txtSLSV.ReadOnly = true;
            txtSLSV.Size = new Size(114, 27);
            txtSLSV.TabIndex = 4;
            txtSLSV.Text = "N/A";
            // 
            // texMVP
            // 
            texMVP.AutoSize = true;
            texMVP.Location = new Point(265, 227);
            texMVP.Name = "texMVP";
            texMVP.Size = new Size(104, 20);
            texMVP.TabIndex = 3;
            texMVP.Text = "Sinh Viên MVP";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(397, 223);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(114, 27);
            textBox1.TabIndex = 4;
            textBox1.Text = "N/A";
            // 
            // texLop
            // 
            texLop.AutoSize = true;
            texLop.Location = new Point(563, 188);
            texLop.Name = "texLop";
            texLop.Size = new Size(101, 20);
            texLop.TabIndex = 3;
            texLop.Text = "Số Lượng Lớp";
            // 
            // txtLop
            // 
            txtLop.Location = new Point(695, 184);
            txtLop.Margin = new Padding(3, 4, 3, 4);
            txtLop.Name = "txtLop";
            txtLop.ReadOnly = true;
            txtLop.Size = new Size(114, 27);
            txtLop.TabIndex = 4;
            txtLop.Text = "N/A";
            // 
            // texKhoa
            // 
            texKhoa.AutoSize = true;
            texKhoa.Location = new Point(563, 231);
            texKhoa.Name = "texKhoa";
            texKhoa.Size = new Size(110, 20);
            texKhoa.TabIndex = 3;
            texKhoa.Text = "Số Lượng Khoa";
            // 
            // txtKhoa
            // 
            txtKhoa.Location = new Point(695, 227);
            txtKhoa.Margin = new Padding(3, 4, 3, 4);
            txtKhoa.Name = "txtKhoa";
            txtKhoa.ReadOnly = true;
            txtKhoa.Size = new Size(114, 27);
            txtKhoa.TabIndex = 4;
            txtKhoa.Text = "N/A";
            // 
            // LblUserName
            // 
            LblUserName.AutoSize = true;
            LblUserName.Font = new Font("Segoe UI", 20F);
            LblUserName.Location = new Point(21, 9);
            LblUserName.Name = "LblUserName";
            LblUserName.Size = new Size(0, 46);
            LblUserName.TabIndex = 5;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
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
            Controls.Add(title);
            Margin = new Padding(3, 4, 3, 4);
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

        private Label title;
        private Panel panel1;
        private MenuStrip nav;
        private ToolStripMenuItem navMain;
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
    }
}
