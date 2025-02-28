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
            panel1 = new Panel();
            button1 = new Button();
            txtPass = new TextBox();
            labelPass = new Label();
            txtUserName = new TextBox();
            labelTen = new Label();
            title = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.AutoSize = true;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txtPass);
            panel1.Controls.Add(labelPass);
            panel1.Controls.Add(txtUserName);
            panel1.Controls.Add(labelTen);
            panel1.Controls.Add(title);
            panel1.Location = new Point(163, 91);
            panel1.Name = "panel1";
            panel1.Size = new Size(476, 275);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.AllowDrop = true;
            button1.Anchor = AnchorStyles.Bottom;
            button1.AutoSize = true;
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(103, 213);
            button1.Name = "button1";
            button1.Size = new Size(271, 39);
            button1.TabIndex = 3;
            button1.Text = "Đăng nhập";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtPass
            // 
            txtPass.BorderStyle = BorderStyle.FixedSingle;
            txtPass.Location = new Point(136, 152);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(281, 23);
            txtPass.TabIndex = 2;
            // 
            // labelPass
            // 
            labelPass.AutoSize = true;
            labelPass.Font = new Font("Segoe UI", 10F);
            labelPass.Location = new Point(50, 152);
            labelPass.Name = "labelPass";
            labelPass.Size = new Size(70, 19);
            labelPass.TabIndex = 1;
            labelPass.Text = "Password:";
            // 
            // txtUserName
            // 
            txtUserName.BorderStyle = BorderStyle.FixedSingle;
            txtUserName.Location = new Point(136, 123);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(281, 23);
            txtUserName.TabIndex = 2;
            // 
            // labelTen
            // 
            labelTen.AutoSize = true;
            labelTen.Font = new Font("Segoe UI", 10F);
            labelTen.Location = new Point(50, 123);
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
            title.Location = new Point(159, 49);
            title.Name = "title";
            title.Size = new Size(161, 32);
            title.TabIndex = 0;
            title.Text = "ĐĂNG NHẬP";
            title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SignIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "SignIn";
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
    }
}