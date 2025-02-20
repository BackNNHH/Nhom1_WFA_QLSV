namespace Nhom1_WFA_QLSV
{
    partial class ThemSinhVien
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
            title = new Label();
            labelTenSV = new Label();
            txtTenSV = new TextBox();
            labelMSSV = new Label();
            txtMSSV = new TextBox();
            labelLop = new Label();
            txtLop = new TextBox();
            radioNam = new RadioButton();
            radioNu = new RadioButton();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            title.ForeColor = SystemColors.HotTrack;
            title.Location = new Point(12, 9);
            title.Name = "title";
            title.Size = new Size(175, 28);
            title.TabIndex = 2;
            title.Text = "THÊM SINH VIÊN";
            // 
            // labelTenSV
            // 
            labelTenSV.AutoSize = true;
            labelTenSV.Location = new Point(29, 97);
            labelTenSV.Name = "labelTenSV";
            labelTenSV.Size = new Size(77, 15);
            labelTenSV.TabIndex = 3;
            labelTenSV.Text = "Tên Sinh Viên";
            // 
            // txtTenSV
            // 
            txtTenSV.Location = new Point(112, 94);
            txtTenSV.Name = "txtTenSV";
            txtTenSV.Size = new Size(100, 23);
            txtTenSV.TabIndex = 4;
            // 
            // labelMSSV
            // 
            labelMSSV.AutoSize = true;
            labelMSSV.Location = new Point(264, 97);
            labelMSSV.Name = "labelMSSV";
            labelMSSV.Size = new Size(37, 15);
            labelMSSV.TabIndex = 3;
            labelMSSV.Text = "MSSV";
            // 
            // txtMSSV
            // 
            txtMSSV.Location = new Point(307, 97);
            txtMSSV.Name = "txtMSSV";
            txtMSSV.Size = new Size(100, 23);
            txtMSSV.TabIndex = 4;
            // 
            // labelLop
            // 
            labelLop.AutoSize = true;
            labelLop.Location = new Point(431, 97);
            labelLop.Name = "labelLop";
            labelLop.Size = new Size(27, 15);
            labelLop.TabIndex = 3;
            labelLop.Text = "Lớp";
            // 
            // txtLop
            // 
            txtLop.Location = new Point(474, 97);
            txtLop.Name = "txtLop";
            txtLop.Size = new Size(100, 23);
            txtLop.TabIndex = 4;
            // 
            // radioNam
            // 
            radioNam.AutoSize = true;
            radioNam.Location = new Point(264, 135);
            radioNam.Name = "radioNam";
            radioNam.Size = new Size(51, 19);
            radioNam.TabIndex = 5;
            radioNam.TabStop = true;
            radioNam.Text = "Nam";
            radioNam.UseVisualStyleBackColor = true;
            // 
            // radioNu
            // 
            radioNu.AutoSize = true;
            radioNu.Location = new Point(333, 139);
            radioNu.Name = "radioNu";
            radioNu.Size = new Size(41, 19);
            radioNu.TabIndex = 5;
            radioNu.TabStop = true;
            radioNu.Text = "Nữ";
            radioNu.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(29, 135);
            dateTimePicker1.MaxDate = new DateTime(2025, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 6;
            dateTimePicker1.Value = new DateTime(2025, 1, 1, 0, 0, 0, 0);
            // 
            // ThemSinhVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimePicker1);
            Controls.Add(radioNu);
            Controls.Add(radioNam);
            Controls.Add(txtLop);
            Controls.Add(labelLop);
            Controls.Add(txtMSSV);
            Controls.Add(labelMSSV);
            Controls.Add(txtTenSV);
            Controls.Add(labelTenSV);
            Controls.Add(title);
            Name = "ThemSinhVien";
            Text = "ThemSinhVien";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title;
        private Label labelTenSV;
        private TextBox txtTenSV;
        private Label labelMSSV;
        private TextBox txtMSSV;
        private Label labelLop;
        private TextBox txtLop;
        private RadioButton radioNam;
        private RadioButton radioNu;
        private DateTimePicker dateTimePicker1;
    }
}