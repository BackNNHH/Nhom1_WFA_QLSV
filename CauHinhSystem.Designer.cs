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
            label1 = new Label();
            btnBgC = new Button();
            label2 = new Label();
            btnFont = new Button();
            fontDiag = new FontDialog();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(242, 242, 242);
            label1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            label1.Location = new Point(56, 129);
            label1.Name = "label1";
            label1.Size = new Size(93, 18);
            label1.TabIndex = 0;
            label1.Text = "TextMethPro";
            // 
            // btnBgC
            // 
            btnBgC.BackColor = Color.FromArgb(242, 242, 242);
            btnBgC.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnBgC.ForeColor = Color.FromArgb(222, 0, 0, 0);
            btnBgC.Location = new Point(169, 129);
            btnBgC.Margin = new Padding(3, 4, 3, 4);
            btnBgC.Name = "btnBgC";
            btnBgC.Size = new Size(86, 31);
            btnBgC.TabIndex = 1;
            btnBgC.Text = "Đổi";
            btnBgC.UseVisualStyleBackColor = false;
            btnBgC.Click += btnBgC_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(242, 242, 242);
            label2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            label2.Location = new Point(56, 173);
            label2.Name = "label2";
            label2.Size = new Size(38, 18);
            label2.TabIndex = 0;
            label2.Text = "Font";
            // 
            // btnFont
            // 
            btnFont.BackColor = Color.FromArgb(242, 242, 242);
            btnFont.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnFont.ForeColor = Color.FromArgb(222, 0, 0, 0);
            btnFont.Location = new Point(169, 163);
            btnFont.Margin = new Padding(3, 4, 3, 4);
            btnFont.Name = "btnFont";
            btnFont.Size = new Size(86, 31);
            btnFont.TabIndex = 1;
            btnFont.Text = "Đổi";
            btnFont.UseVisualStyleBackColor = false;
            btnFont.Click += btnF_Click;
            // 
            // CauHinhSystem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnFont);
            Controls.Add(btnBgC);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CauHinhSystem";
            Padding = new Padding(3, 85, 3, 4);
            ShowIcon = false;
            Text = "CauHinhSystem";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ColorDialog coloDiag;
        private Label label1;
        private Button btnBgC;
        private Label label2;
        private Button btnFont;
        private FontDialog fontDiag;
    }
}