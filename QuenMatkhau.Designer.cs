namespace Nhom1_WFA_QLSV
{
    partial class QuenMatkhau
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
            txtPass = new TextBox();
            texWarm = new Label();
            labelPass = new Label();
            txtToken = new TextBox();
            label1 = new Label();
            txtUserName = new TextBox();
            labelTen = new Label();
            title = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtPass
            // 
            txtPass.BorderStyle = BorderStyle.FixedSingle;
            txtPass.Location = new Point(112, 268);
            txtPass.Margin = new Padding(3, 4, 3, 4);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(313, 27);
            txtPass.TabIndex = 2;
            // 
            // texWarm
            // 
            texWarm.AutoSize = true;
            texWarm.Font = new Font("Segoe UI", 10F);
            texWarm.ForeColor = Color.Red;
            texWarm.Location = new Point(14, 321);
            texWarm.Name = "texWarm";
            texWarm.Size = new Size(194, 23);
            texWarm.TabIndex = 1;
            texWarm.Text = "Vui lòng nhập thông tin";
            // 
            // labelPass
            // 
            labelPass.AutoSize = true;
            labelPass.Font = new Font("Segoe UI", 10F);
            labelPass.Location = new Point(69, 239);
            labelPass.Name = "labelPass";
            labelPass.Size = new Size(123, 23);
            labelPass.TabIndex = 1;
            labelPass.Text = "New Password:";
            // 
            // txtToken
            // 
            txtToken.BorderStyle = BorderStyle.FixedSingle;
            txtToken.Location = new Point(112, 197);
            txtToken.Margin = new Padding(3, 4, 3, 4);
            txtToken.Name = "txtToken";
            txtToken.Size = new Size(313, 27);
            txtToken.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(69, 168);
            label1.Name = "label1";
            label1.Size = new Size(58, 23);
            label1.TabIndex = 1;
            label1.Text = "Token:";
            // 
            // txtUserName
            // 
            txtUserName.BorderStyle = BorderStyle.FixedSingle;
            txtUserName.Location = new Point(112, 124);
            txtUserName.Margin = new Padding(3, 4, 3, 4);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(313, 27);
            txtUserName.TabIndex = 2;
            // 
            // labelTen
            // 
            labelTen.AutoSize = true;
            labelTen.Font = new Font("Segoe UI", 10F);
            labelTen.Location = new Point(69, 95);
            labelTen.Name = "labelTen";
            labelTen.Size = new Size(99, 23);
            labelTen.TabIndex = 1;
            labelTen.Text = "User Name:";
            // 
            // title
            // 
            title.Anchor = AnchorStyles.Top;
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            title.ForeColor = SystemColors.HotTrack;
            title.Location = new Point(150, 12);
            title.Name = "title";
            title.Size = new Size(245, 41);
            title.TabIndex = 0;
            title.Text = "Quên Mật  Khẩu";
            title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.AllowDrop = true;
            button1.Anchor = AnchorStyles.Bottom;
            button1.AutoSize = true;
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(112, 351);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(310, 52);
            button1.TabIndex = 4;
            button1.Text = "Đăng nhập";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // QuenMatkhau
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 420);
            Controls.Add(button1);
            Controls.Add(txtPass);
            Controls.Add(title);
            Controls.Add(texWarm);
            Controls.Add(labelTen);
            Controls.Add(labelPass);
            Controls.Add(txtUserName);
            Controls.Add(txtToken);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "QuenMatkhau";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QuenMatkhau";
            FormClosing += QuenMatkhau_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtPass;
        private Label texWarm;
        private Label labelPass;
        private Label title;
        private TextBox txtToken;
        private Label label1;
        private TextBox txtUserName;
        private Label labelTen;
        private Button button1;
    }
}