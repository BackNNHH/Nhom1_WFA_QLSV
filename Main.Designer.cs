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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panel1 = new Panel();
            nav = new MenuStrip();
            navQLSV = new ToolStripMenuItem();
            navNhapDiem = new ToolStripMenuItem();
            navXemDiem = new ToolStripMenuItem();
            navSystem = new ToolStripMenuItem();
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
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            materialFloatingActionButton1 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            imageList1 = new ImageList(components);
            chartScores = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel1.SuspendLayout();
            nav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartScores).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(242, 242, 242);
            panel1.Controls.Add(nav);
            panel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            panel1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            panel1.Location = new Point(6, 136);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(162, 456);
            panel1.TabIndex = 2;
            // 
            // nav
            // 
            nav.BackColor = Color.FromArgb(242, 242, 242);
            nav.Dock = DockStyle.Left;
            nav.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            nav.ForeColor = Color.FromArgb(222, 0, 0, 0);
            nav.ImageScalingSize = new Size(20, 20);
            nav.Items.AddRange(new ToolStripItem[] { navQLSV, navNhapDiem, navXemDiem, navSystem });
            nav.Location = new Point(0, 0);
            nav.Name = "nav";
            nav.Padding = new Padding(7, 3, 0, 3);
            nav.Size = new Size(149, 456);
            nav.TabIndex = 2;
            nav.Text = "menuStrip1";
            // 
            // navQLSV
            // 
            navQLSV.AutoSize = false;
            navQLSV.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Pixel);
            navQLSV.Name = "navQLSV";
            navQLSV.Size = new Size(142, 40);
            navQLSV.Text = "Quản Lý sinh viên";
            navQLSV.Click += navQLSV_Click;
            // 
            // navNhapDiem
            // 
            navNhapDiem.AutoSize = false;
            navNhapDiem.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Pixel);
            navNhapDiem.Name = "navNhapDiem";
            navNhapDiem.Size = new Size(142, 40);
            navNhapDiem.Text = "Nhập điểm ";
            navNhapDiem.Click += nhaToolStripMenuItem_Click;
            // 
            // navXemDiem
            // 
            navXemDiem.AutoSize = false;
            navXemDiem.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Pixel);
            navXemDiem.Name = "navXemDiem";
            navXemDiem.Size = new Size(142, 40);
            navXemDiem.Text = "Xem điểm";
            navXemDiem.Click += xemDdieToolStripMenuItem_Click;
            // 
            // navSystem
            // 
            navSystem.AutoSize = false;
            navSystem.DropDownItems.AddRange(new ToolStripItem[] { cấuHìnhHệThôgsToolStripMenuItem, toolStripSeparator1, MnuDangXuat, toolStripSeparator2, thoátToolStripMenuItem });
            navSystem.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Pixel);
            navSystem.Image = Properties.Resources.systemIc;
            navSystem.Name = "navSystem";
            navSystem.Size = new Size(142, 40);
            navSystem.Text = "Hệ Thống";
            // 
            // cấuHìnhHệThôgsToolStripMenuItem
            // 
            cấuHìnhHệThôgsToolStripMenuItem.Image = Properties.Resources.setting;
            cấuHìnhHệThôgsToolStripMenuItem.Name = "cấuHìnhHệThôgsToolStripMenuItem";
            cấuHìnhHệThôgsToolStripMenuItem.Size = new Size(209, 26);
            cấuHìnhHệThôgsToolStripMenuItem.Text = "Cấu hình hệ thống";
            cấuHìnhHệThôgsToolStripMenuItem.Click += cấuHìnhHệThôgsToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(206, 6);
            // 
            // MnuDangXuat
            // 
            MnuDangXuat.Image = Properties.Resources.signout;
            MnuDangXuat.Name = "MnuDangXuat";
            MnuDangXuat.Size = new Size(209, 26);
            MnuDangXuat.Text = "Đăng xuất";
            MnuDangXuat.Click += MnuDangXuat_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(206, 6);
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Image = Properties.Resources.exit;
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(209, 26);
            thoátToolStripMenuItem.Text = "Thoát";
            // 
            // texSLSV
            // 
            texSLSV.AutoSize = true;
            texSLSV.BackColor = Color.FromArgb(242, 242, 242);
            texSLSV.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            texSLSV.ForeColor = Color.FromArgb(222, 0, 0, 0);
            texSLSV.Location = new Point(220, 440);
            texSLSV.Name = "texSLSV";
            texSLSV.Size = new Size(139, 18);
            texSLSV.TabIndex = 3;
            texSLSV.Text = "Số Lượng Sinh Viên";
            // 
            // txtSLSV
            // 
            txtSLSV.BackColor = Color.FromArgb(242, 242, 242);
            txtSLSV.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSLSV.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtSLSV.Location = new Point(370, 436);
            txtSLSV.Margin = new Padding(3, 4, 3, 4);
            txtSLSV.Name = "txtSLSV";
            txtSLSV.ReadOnly = true;
            txtSLSV.Size = new Size(114, 24);
            txtSLSV.TabIndex = 4;
            txtSLSV.Text = "N/A";
            // 
            // texMVP
            // 
            texMVP.AutoSize = true;
            texMVP.BackColor = Color.FromArgb(242, 242, 242);
            texMVP.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            texMVP.ForeColor = Color.FromArgb(222, 0, 0, 0);
            texMVP.Location = new Point(220, 479);
            texMVP.Name = "texMVP";
            texMVP.Size = new Size(107, 18);
            texMVP.TabIndex = 3;
            texMVP.Text = "Sinh Viên MVP";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(242, 242, 242);
            textBox1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            textBox1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            textBox1.Location = new Point(370, 475);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(114, 24);
            textBox1.TabIndex = 4;
            textBox1.Text = "N/A";
            // 
            // texLop
            // 
            texLop.AutoSize = true;
            texLop.BackColor = Color.FromArgb(242, 242, 242);
            texLop.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            texLop.ForeColor = Color.FromArgb(222, 0, 0, 0);
            texLop.Location = new Point(536, 436);
            texLop.Name = "texLop";
            texLop.Size = new Size(101, 18);
            texLop.TabIndex = 3;
            texLop.Text = "Số Lượng Lớp";
            // 
            // txtLop
            // 
            txtLop.BackColor = Color.FromArgb(242, 242, 242);
            txtLop.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtLop.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtLop.Location = new Point(668, 432);
            txtLop.Margin = new Padding(3, 4, 3, 4);
            txtLop.Name = "txtLop";
            txtLop.ReadOnly = true;
            txtLop.Size = new Size(114, 24);
            txtLop.TabIndex = 4;
            txtLop.Text = "N/A";
            // 
            // texKhoa
            // 
            texKhoa.AutoSize = true;
            texKhoa.BackColor = Color.FromArgb(242, 242, 242);
            texKhoa.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            texKhoa.ForeColor = Color.FromArgb(222, 0, 0, 0);
            texKhoa.Location = new Point(536, 479);
            texKhoa.Name = "texKhoa";
            texKhoa.Size = new Size(110, 18);
            texKhoa.TabIndex = 3;
            texKhoa.Text = "Số Lượng Khoa";
            // 
            // txtKhoa
            // 
            txtKhoa.BackColor = Color.FromArgb(242, 242, 242);
            txtKhoa.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtKhoa.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtKhoa.Location = new Point(668, 475);
            txtKhoa.Margin = new Padding(3, 4, 3, 4);
            txtKhoa.Name = "txtKhoa";
            txtKhoa.ReadOnly = true;
            txtKhoa.Size = new Size(114, 24);
            txtKhoa.TabIndex = 4;
            txtKhoa.Text = "N/A";
            // 
            // LblUserName
            // 
            LblUserName.AutoSize = true;
            LblUserName.BackColor = Color.FromArgb(242, 242, 242);
            LblUserName.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LblUserName.ForeColor = Color.FromArgb(222, 0, 0, 0);
            LblUserName.Location = new Point(7, 85);
            LblUserName.Name = "LblUserName";
            LblUserName.Size = new Size(0, 18);
            LblUserName.TabIndex = 5;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(220, 136);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(212, 87);
            materialCard1.TabIndex = 6;
            // 
            // materialFloatingActionButton1
            // 
            materialFloatingActionButton1.BackColor = Color.FromArgb(242, 242, 242);
            materialFloatingActionButton1.Depth = 0;
            materialFloatingActionButton1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialFloatingActionButton1.Icon = Properties.Resources.group;
            materialFloatingActionButton1.Image = Properties.Resources.group;
            materialFloatingActionButton1.Location = new Point(404, 153);
            materialFloatingActionButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialFloatingActionButton1.Name = "materialFloatingActionButton1";
            materialFloatingActionButton1.Size = new Size(60, 60);
            materialFloatingActionButton1.TabIndex = 7;
            materialFloatingActionButton1.Text = "materialFloatingActionButton1";
            materialFloatingActionButton1.UseVisualStyleBackColor = false;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "add-user.png");
            imageList1.Images.SetKeyName(1, "circle.png");
            imageList1.Images.SetKeyName(2, "department.png");
            imageList1.Images.SetKeyName(3, "graphic-board.png");
            imageList1.Images.SetKeyName(4, "group.png");
            imageList1.Images.SetKeyName(5, "mvp.png");
            // 
            // chartScores
            // 
            chartScores.BackColor = Color.FromArgb(242, 242, 242);
            chartArea2.Name = "ChartArea1";
            chartScores.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartScores.Legends.Add(legend2);
            chartScores.Location = new Point(220, 535);
            chartScores.Name = "chartScores";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartScores.Series.Add(series2);
            chartScores.Size = new Size(602, 266);
            chartScores.TabIndex = 8;
            chartScores.Text = "avgScoreChart";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 842);
            Controls.Add(chartScores);
            Controls.Add(materialFloatingActionButton1);
            Controls.Add(materialCard1);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "Main";
            Padding = new Padding(3, 85, 3, 4);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trang Chủ";
            Load += Main_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            nav.ResumeLayout(false);
            nav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartScores).EndInit();
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
        private ToolStripMenuItem navNhapDiem;
        private ToolStripMenuItem navSystem;
        private ToolStripMenuItem cấuHìnhHệThôgsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem MnuDangXuat;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private Label LblUserName;
        private ToolStripMenuItem navXemDiem;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton1;
        private ImageList imageList1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartScores;
    }
}
