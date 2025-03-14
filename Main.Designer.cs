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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
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
            texMVP = new Label();
            texLop = new Label();
            texKhoa = new Label();
            LblUserName = new Label();
            CrdSv = new MaterialSkin.Controls.MaterialCard();
            lbSV = new Label();
            materialFloatingActionButton1 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            chartScores = new System.Windows.Forms.DataVisualization.Charting.Chart();
            materialFloatingActionButton2 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            CrdLop = new MaterialSkin.Controls.MaterialCard();
            lbLop = new Label();
            materialFloatingActionButton3 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            CrdMVP = new MaterialSkin.Controls.MaterialCard();
            lbMVP = new Label();
            materialFloatingActionButton4 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            CrdKhoa = new MaterialSkin.Controls.MaterialCard();
            lbKhoa = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            nav.SuspendLayout();
            CrdSv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartScores).BeginInit();
            CrdLop.SuspendLayout();
            CrdMVP.SuspendLayout();
            CrdKhoa.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(242, 242, 242);
            panel1.Controls.Add(nav);
            panel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            panel1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            panel1.Location = new Point(5, 102);
            panel1.Name = "panel1";
            panel1.Size = new Size(142, 342);
            panel1.TabIndex = 2;
            // 
            // nav
            // 
            nav.AutoSize = false;
            nav.BackColor = Color.FromArgb(242, 242, 242);
            nav.Dock = DockStyle.Left;
            nav.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            nav.ForeColor = Color.FromArgb(222, 0, 0, 0);
            nav.ImageScalingSize = new Size(20, 20);
            nav.Items.AddRange(new ToolStripItem[] { navQLSV, navNhapDiem, navXemDiem, navSystem });
            nav.Location = new Point(0, 0);
            nav.Name = "nav";
            nav.RenderMode = ToolStripRenderMode.Professional;
            nav.Size = new Size(148, 342);
            nav.TabIndex = 2;
            nav.Text = "menuStrip1";
            // 
            // navQLSV
            // 
            navQLSV.AutoSize = false;
            navQLSV.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Pixel);
            navQLSV.Image = Properties.Resources.devicemanager;
            navQLSV.Name = "navQLSV";
            navQLSV.Size = new Size(142, 40);
            navQLSV.Text = "Quản Lý sinh viên";
            navQLSV.Click += navQLSV_Click;
            // 
            // navNhapDiem
            // 
            navNhapDiem.AutoSize = false;
            navNhapDiem.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Pixel);
            navNhapDiem.Image = Properties.Resources.import;
            navNhapDiem.Name = "navNhapDiem";
            navNhapDiem.Size = new Size(142, 40);
            navNhapDiem.Text = "Nhập điểm ";
            navNhapDiem.Click += nhaToolStripMenuItem_Click;
            // 
            // navXemDiem
            // 
            navXemDiem.AutoSize = false;
            navXemDiem.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Pixel);
            navXemDiem.Image = Properties.Resources.books;
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
            cấuHìnhHệThôgsToolStripMenuItem.Size = new Size(195, 22);
            cấuHìnhHệThôgsToolStripMenuItem.Text = "Cấu hình hệ thống";
            cấuHìnhHệThôgsToolStripMenuItem.Click += cấuHìnhHệThôgsToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(192, 6);
            // 
            // MnuDangXuat
            // 
            MnuDangXuat.Image = Properties.Resources.signout;
            MnuDangXuat.Name = "MnuDangXuat";
            MnuDangXuat.Size = new Size(195, 22);
            MnuDangXuat.Text = "Đăng xuất";
            MnuDangXuat.Click += MnuDangXuat_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(192, 6);
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Image = Properties.Resources.exit;
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(195, 22);
            thoátToolStripMenuItem.Text = "Thoát";
            // 
            // texSLSV
            // 
            texSLSV.AutoSize = true;
            texSLSV.BackColor = Color.FromArgb(255, 255, 255);
            texSLSV.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            texSLSV.ForeColor = Color.FromArgb(222, 0, 0, 0);
            texSLSV.Location = new Point(15, 10);
            texSLSV.Name = "texSLSV";
            texSLSV.Size = new Size(128, 17);
            texSLSV.TabIndex = 3;
            texSLSV.Text = "Số Lượng Sinh Viên";
            // 
            // texMVP
            // 
            texMVP.AutoSize = true;
            texMVP.BackColor = Color.FromArgb(255, 255, 255);
            texMVP.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            texMVP.ForeColor = Color.FromArgb(222, 0, 0, 0);
            texMVP.Location = new Point(17, 13);
            texMVP.Name = "texMVP";
            texMVP.Size = new Size(124, 17);
            texMVP.TabIndex = 3;
            texMVP.Text = "Sinh Viên Tiêu Biểu";
            // 
            // texLop
            // 
            texLop.AutoSize = true;
            texLop.BackColor = Color.FromArgb(255, 255, 255);
            texLop.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            texLop.ForeColor = Color.FromArgb(222, 0, 0, 0);
            texLop.Location = new Point(15, 13);
            texLop.Name = "texLop";
            texLop.Size = new Size(95, 17);
            texLop.TabIndex = 3;
            texLop.Text = "Số Lượng Lớp";
            // 
            // texKhoa
            // 
            texKhoa.AutoSize = true;
            texKhoa.BackColor = Color.FromArgb(255, 255, 255);
            texKhoa.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            texKhoa.ForeColor = Color.FromArgb(222, 0, 0, 0);
            texKhoa.Location = new Point(15, 10);
            texKhoa.Name = "texKhoa";
            texKhoa.Size = new Size(104, 17);
            texKhoa.TabIndex = 3;
            texKhoa.Text = "Số Lượng Khoa";
            // 
            // LblUserName
            // 
            LblUserName.AutoSize = true;
            LblUserName.BackColor = Color.FromArgb(242, 242, 242);
            LblUserName.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            LblUserName.ForeColor = Color.FromArgb(222, 0, 0, 0);
            LblUserName.Location = new Point(69, 64);
            LblUserName.Name = "LblUserName";
            LblUserName.Size = new Size(36, 17);
            LblUserName.TabIndex = 5;
            LblUserName.Text = "User";
            // 
            // CrdSv
            // 
            CrdSv.BackColor = Color.FromArgb(255, 255, 255);
            CrdSv.Controls.Add(lbSV);
            CrdSv.Controls.Add(texSLSV);
            CrdSv.Depth = 0;
            CrdSv.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CrdSv.Location = new Point(192, 102);
            CrdSv.Margin = new Padding(12, 10, 12, 10);
            CrdSv.MouseState = MaterialSkin.MouseState.HOVER;
            CrdSv.Name = "CrdSv";
            CrdSv.Padding = new Padding(12, 10, 12, 10);
            CrdSv.Size = new Size(186, 65);
            CrdSv.TabIndex = 6;
            // 
            // lbSV
            // 
            lbSV.AutoSize = true;
            lbSV.BackColor = Color.FromArgb(255, 255, 255);
            lbSV.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbSV.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lbSV.Location = new Point(17, 41);
            lbSV.Name = "lbSV";
            lbSV.Size = new Size(33, 17);
            lbSV.TabIndex = 4;
            lbSV.Text = "N/A";
            // 
            // materialFloatingActionButton1
            // 
            materialFloatingActionButton1.BackColor = Color.FromArgb(242, 242, 242);
            materialFloatingActionButton1.Depth = 0;
            materialFloatingActionButton1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialFloatingActionButton1.Icon = Properties.Resources.group;
            materialFloatingActionButton1.Image = Properties.Resources.group;
            materialFloatingActionButton1.Location = new Point(354, 115);
            materialFloatingActionButton1.Margin = new Padding(3, 2, 3, 2);
            materialFloatingActionButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialFloatingActionButton1.Name = "materialFloatingActionButton1";
            materialFloatingActionButton1.Size = new Size(63, 63);
            materialFloatingActionButton1.TabIndex = 7;
            materialFloatingActionButton1.Text = "materialFloatingActionButton1";
            materialFloatingActionButton1.UseVisualStyleBackColor = false;
            // 
            // chartScores
            // 
            chartScores.BackColor = Color.FromArgb(242, 242, 242);
            chartArea1.Name = "ChartArea1";
            chartScores.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartScores.Legends.Add(legend1);
            chartScores.Location = new Point(152, 293);
            chartScores.Margin = new Padding(3, 2, 3, 2);
            chartScores.Name = "chartScores";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartScores.Series.Add(series1);
            chartScores.Size = new Size(627, 200);
            chartScores.TabIndex = 8;
            // 
            // materialFloatingActionButton2
            // 
            materialFloatingActionButton2.BackColor = Color.FromArgb(242, 242, 242);
            materialFloatingActionButton2.Depth = 0;
            materialFloatingActionButton2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialFloatingActionButton2.Icon = Properties.Resources.graphic_board;
            materialFloatingActionButton2.Image = Properties.Resources.graphic_board;
            materialFloatingActionButton2.Location = new Point(643, 115);
            materialFloatingActionButton2.Margin = new Padding(3, 2, 3, 2);
            materialFloatingActionButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialFloatingActionButton2.Name = "materialFloatingActionButton2";
            materialFloatingActionButton2.Size = new Size(63, 63);
            materialFloatingActionButton2.TabIndex = 10;
            materialFloatingActionButton2.Text = "materialFloatingActionButton2";
            materialFloatingActionButton2.UseVisualStyleBackColor = false;
            // 
            // CrdLop
            // 
            CrdLop.BackColor = Color.FromArgb(255, 255, 255);
            CrdLop.Controls.Add(lbLop);
            CrdLop.Controls.Add(texLop);
            CrdLop.Depth = 0;
            CrdLop.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CrdLop.Location = new Point(482, 102);
            CrdLop.Margin = new Padding(12, 10, 12, 10);
            CrdLop.MouseState = MaterialSkin.MouseState.HOVER;
            CrdLop.Name = "CrdLop";
            CrdLop.Padding = new Padding(12, 10, 12, 10);
            CrdLop.Size = new Size(186, 65);
            CrdLop.TabIndex = 9;
            // 
            // lbLop
            // 
            lbLop.AutoSize = true;
            lbLop.BackColor = Color.FromArgb(255, 255, 255);
            lbLop.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbLop.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lbLop.Location = new Point(15, 41);
            lbLop.Name = "lbLop";
            lbLop.Size = new Size(33, 17);
            lbLop.TabIndex = 4;
            lbLop.Text = "N/A";
            // 
            // materialFloatingActionButton3
            // 
            materialFloatingActionButton3.BackColor = Color.FromArgb(242, 242, 242);
            materialFloatingActionButton3.Depth = 0;
            materialFloatingActionButton3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialFloatingActionButton3.Icon = Properties.Resources.mvp;
            materialFloatingActionButton3.Image = Properties.Resources.mvp;
            materialFloatingActionButton3.Location = new Point(354, 217);
            materialFloatingActionButton3.Margin = new Padding(3, 2, 3, 2);
            materialFloatingActionButton3.MouseState = MaterialSkin.MouseState.HOVER;
            materialFloatingActionButton3.Name = "materialFloatingActionButton3";
            materialFloatingActionButton3.Size = new Size(63, 62);
            materialFloatingActionButton3.TabIndex = 9;
            materialFloatingActionButton3.Text = "materialFloatingActionButton3";
            materialFloatingActionButton3.UseVisualStyleBackColor = false;
            // 
            // CrdMVP
            // 
            CrdMVP.BackColor = Color.FromArgb(255, 255, 255);
            CrdMVP.Controls.Add(lbMVP);
            CrdMVP.Controls.Add(texMVP);
            CrdMVP.Depth = 0;
            CrdMVP.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CrdMVP.Location = new Point(192, 204);
            CrdMVP.Margin = new Padding(12, 10, 12, 10);
            CrdMVP.MouseState = MaterialSkin.MouseState.HOVER;
            CrdMVP.Name = "CrdMVP";
            CrdMVP.Padding = new Padding(12, 10, 12, 10);
            CrdMVP.Size = new Size(186, 65);
            CrdMVP.TabIndex = 8;
            // 
            // lbMVP
            // 
            lbMVP.AutoSize = true;
            lbMVP.BackColor = Color.FromArgb(255, 255, 255);
            lbMVP.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbMVP.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lbMVP.Location = new Point(17, 41);
            lbMVP.Name = "lbMVP";
            lbMVP.Size = new Size(33, 17);
            lbMVP.TabIndex = 4;
            lbMVP.Text = "N/A";
            // 
            // materialFloatingActionButton4
            // 
            materialFloatingActionButton4.BackColor = Color.FromArgb(242, 242, 242);
            materialFloatingActionButton4.Depth = 0;
            materialFloatingActionButton4.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialFloatingActionButton4.Icon = Properties.Resources.department;
            materialFloatingActionButton4.Image = Properties.Resources.department;
            materialFloatingActionButton4.Location = new Point(643, 217);
            materialFloatingActionButton4.Margin = new Padding(3, 2, 3, 2);
            materialFloatingActionButton4.MouseState = MaterialSkin.MouseState.HOVER;
            materialFloatingActionButton4.Name = "materialFloatingActionButton4";
            materialFloatingActionButton4.Size = new Size(63, 62);
            materialFloatingActionButton4.TabIndex = 11;
            materialFloatingActionButton4.Text = "materialFloatingActionButton4";
            materialFloatingActionButton4.UseVisualStyleBackColor = false;
            // 
            // CrdKhoa
            // 
            CrdKhoa.BackColor = Color.FromArgb(255, 255, 255);
            CrdKhoa.Controls.Add(lbKhoa);
            CrdKhoa.Controls.Add(texKhoa);
            CrdKhoa.Depth = 0;
            CrdKhoa.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CrdKhoa.Location = new Point(482, 204);
            CrdKhoa.Margin = new Padding(12, 10, 12, 10);
            CrdKhoa.MouseState = MaterialSkin.MouseState.HOVER;
            CrdKhoa.Name = "CrdKhoa";
            CrdKhoa.Padding = new Padding(12, 10, 12, 10);
            CrdKhoa.Size = new Size(186, 65);
            CrdKhoa.TabIndex = 10;
            // 
            // lbKhoa
            // 
            lbKhoa.AutoSize = true;
            lbKhoa.BackColor = Color.FromArgb(255, 255, 255);
            lbKhoa.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbKhoa.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lbKhoa.Location = new Point(15, 41);
            lbKhoa.Name = "lbKhoa";
            lbKhoa.Size = new Size(33, 17);
            lbKhoa.TabIndex = 4;
            lbKhoa.Text = "N/A";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(242, 242, 242);
            label1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            label1.Location = new Point(6, 64);
            label1.Name = "label1";
            label1.Size = new Size(67, 17);
            label1.TabIndex = 5;
            label1.Text = "Welcome ";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 496);
            Controls.Add(materialFloatingActionButton4);
            Controls.Add(materialFloatingActionButton3);
            Controls.Add(CrdKhoa);
            Controls.Add(materialFloatingActionButton2);
            Controls.Add(CrdMVP);
            Controls.Add(CrdLop);
            Controls.Add(chartScores);
            Controls.Add(materialFloatingActionButton1);
            Controls.Add(CrdSv);
            Controls.Add(label1);
            Controls.Add(LblUserName);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trang Chủ";
            FormClosing += Main_FormClosing;
            Load += Main_Load;
            panel1.ResumeLayout(false);
            nav.ResumeLayout(false);
            nav.PerformLayout();
            CrdSv.ResumeLayout(false);
            CrdSv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartScores).EndInit();
            CrdLop.ResumeLayout(false);
            CrdLop.PerformLayout();
            CrdMVP.ResumeLayout(false);
            CrdMVP.PerformLayout();
            CrdKhoa.ResumeLayout(false);
            CrdKhoa.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private MenuStrip nav;
        private ToolStripMenuItem navQLSV;
        private Label texSLSV;
        private Label texMVP;
        private Label texLop;
        private Label texKhoa;
        private ToolStripMenuItem navNhapDiem;
        private ToolStripMenuItem navSystem;
        private ToolStripMenuItem cấuHìnhHệThôgsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem MnuDangXuat;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private Label LblUserName;
        private ToolStripMenuItem navXemDiem;
        private MaterialSkin.Controls.MaterialCard CrdSv;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartScores;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton2;
        private MaterialSkin.Controls.MaterialCard CrdLop;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton3;
        private MaterialSkin.Controls.MaterialCard CrdMVP;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton4;
        private MaterialSkin.Controls.MaterialCard CrdKhoa;
        private Label lbSV;
        private Label lbLop;
        private Label lbMVP;
        private Label lbKhoa;
        private Label label1;
    }
}
