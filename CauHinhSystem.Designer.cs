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
            label1.Location = new Point(49, 97);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 0;
            label1.Text = "TextMethPro";
            // 
            // btnBgC
            // 
            btnBgC.Location = new Point(148, 97);
            btnBgC.Name = "btnBgC";
            btnBgC.Size = new Size(75, 23);
            btnBgC.TabIndex = 1;
            btnBgC.Text = "Đổi";
            btnBgC.UseVisualStyleBackColor = true;
            btnBgC.Click += btnBgC_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 130);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 0;
            label2.Text = "Font";
            // 
            // btnFont
            // 
            btnFont.Location = new Point(148, 122);
            btnFont.Name = "btnFont";
            btnFont.Size = new Size(75, 23);
            btnFont.TabIndex = 1;
            btnFont.Text = "Đổi";
            btnFont.UseVisualStyleBackColor = true;
            btnFont.Click += btnF_Click;
            // 
            // CauHinhSystem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFont);
            Controls.Add(btnBgC);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CauHinhSystem";
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