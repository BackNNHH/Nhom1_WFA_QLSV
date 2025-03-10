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
            txtPass.Location = new Point(98, 201);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(274, 23);
            txtPass.TabIndex = 2;
            // 
            // texWarm
            // 
            texWarm.AutoSize = true;
            texWarm.Font = new Font("Segoe UI", 10F);
            texWarm.ForeColor = Color.Red;
            texWarm.Location = new Point(12, 241);
            texWarm.Name = "texWarm";
            texWarm.Size = new Size(156, 19);
            texWarm.TabIndex = 1;
            texWarm.Text = "Vui lòng nhập thông tin";
            // 
            // labelPass
            // 
            labelPass.AutoSize = true;
            labelPass.Font = new Font("Segoe UI", 10F);
            labelPass.Location = new Point(60, 179);
            labelPass.Name = "labelPass";
            labelPass.Size = new Size(101, 19);
            labelPass.TabIndex = 1;
            labelPass.Text = "New Password:";
            // 
            // txtToken
            // 
            txtToken.BorderStyle = BorderStyle.FixedSingle;
            txtToken.Location = new Point(98, 148);
            txtToken.Name = "txtToken";
            txtToken.Size = new Size(274, 23);
            txtToken.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(60, 126);
            label1.Name = "label1";
            label1.Size = new Size(48, 19);
            label1.TabIndex = 1;
            label1.Text = "Token:";
            // 
            // txtUserName
            // 
            txtUserName.BorderStyle = BorderStyle.FixedSingle;
            txtUserName.Location = new Point(98, 93);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(274, 23);
            txtUserName.TabIndex = 2;
            // 
            // labelTen
            // 
            labelTen.AutoSize = true;
            labelTen.Font = new Font("Segoe UI", 10F);
            labelTen.Location = new Point(60, 71);
            labelTen.Name = "labelTen";
            labelTen.Size = new Size(80, 19);
            labelTen.TabIndex = 1;
            labelTen.Text = "User Name:";
            // 
            // title
            // 
            title.Anchor = AnchorStyles.Top;
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            title.ForeColor = SystemColors.HotTrack;
            title.Location = new Point(131, 9);
            title.Name = "title";
            title.Size = new Size(199, 32);
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
            button1.Location = new Point(98, 263);
            button1.Name = "button1";
            button1.Size = new Size(271, 39);
            button1.TabIndex = 4;
            button1.Text = "Đăng nhập";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // QuenMatkhau
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 315);
            Controls.Add(button1);
            Controls.Add(txtPass);
            Controls.Add(title);
            Controls.Add(texWarm);
            Controls.Add(labelTen);
            Controls.Add(labelPass);
            Controls.Add(txtUserName);
            Controls.Add(txtToken);
            Controls.Add(label1);
            Name = "QuenMatkhau";
            ShowIcon = false;
            Text = "QuenMatkhau";
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