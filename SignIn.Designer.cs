namespace Nhom1_WFA_QLSV
{
    partial class SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            panel1 = new Panel();
            button1 = new Button();
            txtPass = new TextBox();
            label1 = new Label();
            texWarm = new Label();
            labelPass = new Label();
            txtUserName = new TextBox();
            labelTen = new Label();
            title = new Label();
            button2 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.AutoSize = true;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txtPass);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(texWarm);
            panel1.Controls.Add(labelPass);
            panel1.Controls.Add(txtUserName);
            panel1.Controls.Add(labelTen);
            panel1.Controls.Add(title);
            panel1.Location = new Point(218, 95);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(482, 381);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.AllowDrop = true;
            button1.Anchor = AnchorStyles.Bottom;
            button1.AutoSize = true;
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(88, 311);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(310, 52);
            button1.TabIndex = 3;
            button1.Text = "Đăng nhập";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnSign_Click;
            // 
            // txtPass
            // 
            txtPass.BorderStyle = BorderStyle.FixedSingle;
            txtPass.Location = new Point(98, 217);
            txtPass.Margin = new Padding(3, 4, 3, 4);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(313, 27);
            txtPass.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(291, 281);
            label1.Name = "label1";
            label1.Size = new Size(129, 23);
            label1.TabIndex = 1;
            label1.Text = "Quên mật khẩu";
            label1.Click += label1_Click;
            // 
            // texWarm
            // 
            texWarm.AutoSize = true;
            texWarm.Font = new Font("Segoe UI", 10F);
            texWarm.ForeColor = Color.Red;
            texWarm.Location = new Point(30, 265);
            texWarm.Name = "texWarm";
            texWarm.Size = new Size(194, 23);
            texWarm.TabIndex = 1;
            texWarm.Text = "Vui lòng nhập thông tin";
            // 
            // labelPass
            // 
            labelPass.AutoSize = true;
            labelPass.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelPass.ForeColor = SystemColors.WindowFrame;
            labelPass.Location = new Point(55, 188);
            labelPass.Name = "labelPass";
            labelPass.Size = new Size(90, 23);
            labelPass.TabIndex = 1;
            labelPass.Text = "Password:";
            // 
            // txtUserName
            // 
            txtUserName.BorderStyle = BorderStyle.FixedSingle;
            txtUserName.Location = new Point(98, 141);
            txtUserName.Margin = new Padding(3, 4, 3, 4);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(313, 27);
            txtUserName.TabIndex = 2;
            // 
            // labelTen
            // 
            labelTen.AutoSize = true;
            labelTen.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelTen.ForeColor = SystemColors.WindowFrame;
            labelTen.Location = new Point(55, 112);
            labelTen.Name = "labelTen";
            labelTen.Size = new Size(102, 23);
            labelTen.TabIndex = 1;
            labelTen.Text = "User Name:";
            // 
            // title
            // 
            title.Anchor = AnchorStyles.Top;
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            title.ForeColor = SystemColors.HotTrack;
            title.Location = new Point(149, 52);
            title.Name = "title";
            title.Size = new Size(200, 41);
            title.TabIndex = 0;
            title.Text = "ĐĂNG NHẬP";
            title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.AllowDrop = true;
            button2.Anchor = AnchorStyles.Bottom;
            button2.AutoSize = true;
            button2.BackColor = Color.Pink;
            button2.ForeColor = SystemColors.ControlText;
            button2.Location = new Point(818, 532);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 52);
            button2.TabIndex = 3;
            button2.Text = "don't click";
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnPuchClick;
            // 
            // SignIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.MC_XP;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 600);
            Controls.Add(button2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "SignIn";
            ShowIcon = false;
            Text = "SignIn";
            Load += SignIn_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label title;
        private TextBox txtPass;
        private Label labelPass;
        private TextBox txtUserName;
        private Label labelTen;
        private Button button1;
        private Button button2;
        private Label texWarm;
        private Label label1;
    }
}