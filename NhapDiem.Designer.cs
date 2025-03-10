namespace Nhom1_WFA_QLSV
{
    partial class NhapDiem
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
            label1 = new Label();
            txtDiemTX = new TextBox();
            label2 = new Label();
            label3 = new Label();
            cbMonHoc = new ComboBox();
            txtMSSV = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtDiemGK = new TextBox();
            label6 = new Label();
            txtDiemCK = new TextBox();
            btnLuu = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Variable Text Semibold", 20F, FontStyle.Bold);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(288, 19);
            label1.Name = "label1";
            label1.Size = new Size(194, 46);
            label1.TabIndex = 0;
            label1.Text = "Nhập Điểm";
            // 
            // txtDiemTX
            // 
            txtDiemTX.Location = new Point(201, 176);
            txtDiemTX.Name = "txtDiemTX";
            txtDiemTX.Size = new Size(355, 27);
            txtDiemTX.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(109, 88);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 3;
            label2.Text = "MSSV";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(117, 132);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 4;
            label3.Text = "Môn";
            // 
            // cbMonHoc
            // 
            cbMonHoc.FormattingEnabled = true;
            cbMonHoc.Location = new Point(201, 129);
            cbMonHoc.Name = "cbMonHoc";
            cbMonHoc.Size = new Size(355, 28);
            cbMonHoc.TabIndex = 5;
            cbMonHoc.MouseClick += comboBox2_MouseClick;
            // 
            // txtMSSV
            // 
            txtMSSV.Location = new Point(201, 85);
            txtMSSV.Name = "txtMSSV";
            txtMSSV.Size = new Size(355, 27);
            txtMSSV.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(11, 179);
            label4.Name = "label4";
            label4.Size = new Size(144, 20);
            label4.TabIndex = 7;
            label4.Text = "Điểm Thường Xuyên";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(59, 227);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 8;
            label5.Text = "Điểm Giữa Kì";
            // 
            // txtDiemGK
            // 
            txtDiemGK.Location = new Point(201, 219);
            txtDiemGK.Name = "txtDiemGK";
            txtDiemGK.Size = new Size(355, 27);
            txtDiemGK.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(59, 275);
            label6.Name = "label6";
            label6.Size = new Size(94, 20);
            label6.TabIndex = 10;
            label6.Text = "Điểm Cuối kì";
            // 
            // txtDiemCK
            // 
            txtDiemCK.Location = new Point(201, 272);
            txtDiemCK.Name = "txtDiemCK";
            txtDiemCK.Size = new Size(355, 27);
            txtDiemCK.TabIndex = 11;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(241, 336);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 12;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(423, 336);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 13;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // NhapDiem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(btnThoat);
            Controls.Add(btnLuu);
            Controls.Add(txtDiemCK);
            Controls.Add(label6);
            Controls.Add(txtDiemGK);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtMSSV);
            Controls.Add(cbMonHoc);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtDiemTX);
            Controls.Add(label1);
            Name = "NhapDiem";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDiemTX;
        private Label label2;
        private Label label3;
        private ComboBox cbMonHoc;
        private TextBox txtMSSV;
        private Label label4;
        private Label label5;
        private TextBox txtDiemGK;
        private Label label6;
        private TextBox txtDiemCK;
        private Button btnLuu;
        private Button btnThoat;
    }
}