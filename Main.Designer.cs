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
            texSLSV = new Label();
            txtSLSV = new TextBox();
            texMVP = new Label();
            textBox1 = new TextBox();
            texLop = new Label();
            txtLop = new TextBox();
            texKhoa = new Label();
            txtKhoa = new TextBox();
            panel1.SuspendLayout();
            nav.SuspendLayout();
            SuspendLayout();
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            title.ForeColor = SystemColors.HotTrack;
            title.Location = new Point(232, 24);
            title.Name = "title";
            title.Size = new Size(430, 37);
            title.TabIndex = 0;
            title.Text = "ỨNG DỤNG QUẢN LÝ SINH VIÊN";
            // 
            // panel1
            // 
            panel1.Controls.Add(nav);
            panel1.Location = new Point(0, 71);
            panel1.Name = "panel1";
            panel1.Size = new Size(142, 379);
            panel1.TabIndex = 2;
            // 
            // nav
            // 
            nav.Dock = DockStyle.Left;
            nav.Items.AddRange(new ToolStripItem[] { navMain, navQLSV });
            nav.Location = new Point(0, 0);
            nav.Name = "nav";
            nav.Size = new Size(118, 379);
            nav.TabIndex = 2;
            nav.Text = "menuStrip1";
            // 
            // navMain
            // 
            navMain.Name = "navMain";
            navMain.Size = new Size(105, 19);
            navMain.Text = "Trang Chủ";
            // 
            // navQLSV
            // 
            navQLSV.Name = "navQLSV";
            navQLSV.Size = new Size(105, 19);
            navQLSV.Text = "Quản Lý sinh viên";
            // 
            // texSLSV
            // 
            texSLSV.AutoSize = true;
            texSLSV.Location = new Point(232, 141);
            texSLSV.Name = "texSLSV";
            texSLSV.Size = new Size(109, 15);
            texSLSV.TabIndex = 3;
            texSLSV.Text = "Số Lượng Sinh Viên";
            // 
            // txtSLSV
            // 
            txtSLSV.Location = new Point(347, 138);
            txtSLSV.Name = "txtSLSV";
            txtSLSV.ReadOnly = true;
            txtSLSV.Size = new Size(100, 23);
            txtSLSV.TabIndex = 4;
            txtSLSV.Text = "N/A";
            // 
            // texMVP
            // 
            texMVP.AutoSize = true;
            texMVP.Location = new Point(232, 170);
            texMVP.Name = "texMVP";
            texMVP.Size = new Size(84, 15);
            texMVP.TabIndex = 3;
            texMVP.Text = "Sinh Viên MVP";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(347, 167);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            textBox1.Text = "N/A";
            // 
            // texLop
            // 
            texLop.AutoSize = true;
            texLop.Location = new Point(493, 141);
            texLop.Name = "texLop";
            texLop.Size = new Size(80, 15);
            texLop.TabIndex = 3;
            texLop.Text = "Số Lượng Lớp";
            // 
            // txtLop
            // 
            txtLop.Location = new Point(608, 138);
            txtLop.Name = "txtLop";
            txtLop.ReadOnly = true;
            txtLop.Size = new Size(100, 23);
            txtLop.TabIndex = 4;
            txtLop.Text = "N/A";
            // 
            // texKhoa
            // 
            texKhoa.AutoSize = true;
            texKhoa.Location = new Point(493, 173);
            texKhoa.Name = "texKhoa";
            texKhoa.Size = new Size(87, 15);
            texKhoa.TabIndex = 3;
            texKhoa.Text = "Số Lượng Khoa";
            // 
            // txtKhoa
            // 
            txtKhoa.Location = new Point(608, 170);
            txtKhoa.Name = "txtKhoa";
            txtKhoa.ReadOnly = true;
            txtKhoa.Size = new Size(100, 23);
            txtKhoa.TabIndex = 4;
            txtKhoa.Text = "N/A";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "Main";
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
    }
}
