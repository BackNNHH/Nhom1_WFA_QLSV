namespace Nhom1_WFA_QLSV
{
    partial class XemDiem
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
            cboLop = new MaterialSkin.Controls.MaterialComboBox();
            label1 = new Label();
            dtgv = new DataGridView();
            txtMSSV = new DataGridViewTextBoxColumn();
            txtName = new DataGridViewTextBoxColumn();
            txtLop = new DataGridViewTextBoxColumn();
            txtMon = new DataGridViewTextBoxColumn();
            txtDTX = new DataGridViewTextBoxColumn();
            txtDGK = new DataGridViewTextBoxColumn();
            txtDCK = new DataGridViewTextBoxColumn();
            txtDTB = new DataGridViewTextBoxColumn();
            label2 = new Label();
            mtrtxtName = new MaterialSkin.Controls.MaterialTextBox();
            ((System.ComponentModel.ISupportInitialize)dtgv).BeginInit();
            SuspendLayout();
            // 
            // cboLop
            // 
            cboLop.AutoResize = false;
            cboLop.BackColor = Color.FromArgb(242, 242, 242);
            cboLop.Depth = 0;
            cboLop.DrawMode = DrawMode.OwnerDrawVariable;
            cboLop.DropDownHeight = 174;
            cboLop.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLop.DropDownWidth = 121;
            cboLop.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboLop.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboLop.FormattingEnabled = true;
            cboLop.IntegralHeight = false;
            cboLop.ItemHeight = 43;
            cboLop.Location = new Point(126, 83);
            cboLop.MaxDropDownItems = 4;
            cboLop.MouseState = MaterialSkin.MouseState.OUT;
            cboLop.Name = "cboLop";
            cboLop.Size = new Size(188, 49);
            cboLop.StartIndex = 0;
            cboLop.TabIndex = 0;
            cboLop.SelectedIndexChanged += cboLop_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(242, 242, 242);
            label1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            label1.Location = new Point(29, 96);
            label1.Name = "label1";
            label1.Size = new Size(33, 18);
            label1.TabIndex = 1;
            label1.Text = "Lớp";
            // 
            // dtgv
            // 
            dtgv.AllowUserToAddRows = false;
            dtgv.AllowUserToDeleteRows = false;
            dtgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv.Columns.AddRange(new DataGridViewColumn[] { txtMSSV, txtName, txtLop, txtMon, txtDTX, txtDGK, txtDCK, txtDTB });
            dtgv.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            dtgv.Location = new Point(6, 185);
            dtgv.Name = "dtgv";
            dtgv.ReadOnly = true;
            dtgv.RowHeadersWidth = 51;
            dtgv.Size = new Size(1033, 259);
            dtgv.TabIndex = 2;
            // 
            // txtMSSV
            // 
            txtMSSV.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            txtMSSV.DataPropertyName = "MaSV";
            txtMSSV.HeaderText = "MSSV";
            txtMSSV.MinimumWidth = 6;
            txtMSSV.Name = "txtMSSV";
            txtMSSV.ReadOnly = true;
            // 
            // txtName
            // 
            txtName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            txtName.DataPropertyName = "HoTen";
            txtName.HeaderText = "Tên";
            txtName.MinimumWidth = 6;
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            // 
            // txtLop
            // 
            txtLop.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            txtLop.DataPropertyName = "TenLop";
            txtLop.HeaderText = "Lớp";
            txtLop.MinimumWidth = 6;
            txtLop.Name = "txtLop";
            txtLop.ReadOnly = true;
            // 
            // txtMon
            // 
            txtMon.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            txtMon.DataPropertyName = "TenMon";
            txtMon.HeaderText = "Môn";
            txtMon.MinimumWidth = 6;
            txtMon.Name = "txtMon";
            txtMon.ReadOnly = true;
            // 
            // txtDTX
            // 
            txtDTX.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            txtDTX.DataPropertyName = "DiemTX";
            txtDTX.HeaderText = "Điểm Thường Xuyên";
            txtDTX.MinimumWidth = 6;
            txtDTX.Name = "txtDTX";
            txtDTX.ReadOnly = true;
            // 
            // txtDGK
            // 
            txtDGK.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            txtDGK.DataPropertyName = "DiemGK";
            txtDGK.HeaderText = "Điểm Giữa Kì";
            txtDGK.MinimumWidth = 6;
            txtDGK.Name = "txtDGK";
            txtDGK.ReadOnly = true;
            // 
            // txtDCK
            // 
            txtDCK.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            txtDCK.DataPropertyName = "DiemCK";
            txtDCK.HeaderText = "Điểm Cuối Kì";
            txtDCK.MinimumWidth = 6;
            txtDCK.Name = "txtDCK";
            txtDCK.ReadOnly = true;
            // 
            // txtDTB
            // 
            txtDTB.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            txtDTB.DataPropertyName = "DiemTB";
            txtDTB.HeaderText = "Điểm Trung Bình";
            txtDTB.MinimumWidth = 6;
            txtDTB.Name = "txtDTB";
            txtDTB.ReadOnly = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(242, 242, 242);
            label2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            label2.Location = new Point(406, 96);
            label2.Name = "label2";
            label2.Size = new Size(32, 18);
            label2.TabIndex = 4;
            label2.Text = "Tên";
            // 
            // mtrtxtName
            // 
            mtrtxtName.AnimateReadOnly = false;
            mtrtxtName.BackColor = Color.FromArgb(242, 242, 242);
            mtrtxtName.BorderStyle = BorderStyle.None;
            mtrtxtName.Depth = 0;
            mtrtxtName.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mtrtxtName.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mtrtxtName.LeadingIcon = null;
            mtrtxtName.Location = new Point(478, 82);
            mtrtxtName.MaxLength = 50;
            mtrtxtName.MouseState = MaterialSkin.MouseState.OUT;
            mtrtxtName.Multiline = false;
            mtrtxtName.Name = "mtrtxtName";
            mtrtxtName.Size = new Size(237, 50);
            mtrtxtName.TabIndex = 5;
            mtrtxtName.Text = "";
            mtrtxtName.TrailingIcon = null;
            mtrtxtName.TextChanged += mtrtxtName_TextChanged;
            // 
            // XemDiem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1043, 450);
            Controls.Add(mtrtxtName);
            Controls.Add(label2);
            Controls.Add(dtgv);
            Controls.Add(label1);
            Controls.Add(cboLop);
            Name = "XemDiem";
            Text = "Xem Điểm";
            Load += XemDiem_Load;
            ((System.ComponentModel.ISupportInitialize)dtgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialComboBox cboLop;
        private Label label1;
        private DataGridView dtgv;
        private Label label2;
        private MaterialSkin.Controls.MaterialTextBox mtrtxtName;
        private DataGridViewTextBoxColumn txtMSSV;
        private DataGridViewTextBoxColumn txtName;
        private DataGridViewTextBoxColumn txtLop;
        private DataGridViewTextBoxColumn txtMon;
        private DataGridViewTextBoxColumn txtDTX;
        private DataGridViewTextBoxColumn txtDGK;
        private DataGridViewTextBoxColumn txtDCK;
        private DataGridViewTextBoxColumn txtDTB;
    }
}