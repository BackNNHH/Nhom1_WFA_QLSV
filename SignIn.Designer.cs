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
            textBox1 = new TextBox();
            labelPass = new Label();
            txtUserName = new TextBox();
            labelTen = new Label();
            title = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSize = true;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(labelPass);
            panel1.Controls.Add(txtUserName);
            panel1.Controls.Add(labelTen);
            panel1.Controls.Add(title);
            panel1.Location = new Point(174, 86);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(544, 424);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom;
            button1.AutoSize = true;
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(111, 299);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(310, 52);
            button1.TabIndex = 3;
            button1.Text = "Đăng nhập";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(155, 228);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(321, 27);
            textBox1.TabIndex = 2;
            // 
            // labelPass
            // 
            labelPass.AutoSize = true;
            labelPass.Font = new Font("Segoe UI", 10F);
            labelPass.Location = new Point(57, 228);
            labelPass.Name = "labelPass";
            labelPass.Size = new Size(84, 23);
            labelPass.TabIndex = 1;
            labelPass.Text = "Password:";
            // 
            // txtUserName
            // 
            txtUserName.BorderStyle = BorderStyle.FixedSingle;
            txtUserName.Location = new Point(155, 164);
            txtUserName.Margin = new Padding(3, 4, 3, 4);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(321, 27);
            txtUserName.TabIndex = 2;
            // 
            // labelTen
            // 
            labelTen.AutoSize = true;
            labelTen.Font = new Font("Segoe UI", 10F);
            labelTen.Location = new Point(57, 164);
            labelTen.Name = "labelTen";
            labelTen.Size = new Size(99, 23);
            labelTen.TabIndex = 1;
            labelTen.Text = "User Name:";
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            title.ForeColor = SystemColors.HotTrack;
            title.Location = new Point(195, 68);
            title.Name = "title";
            title.Size = new Size(168, 35);
            title.TabIndex = 0;
            title.Text = "ĐĂNG NHẬP";
            title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SignIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.MC_XP;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 600);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
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
        private TextBox textBox1;
        private Label labelPass;
        private TextBox txtUserName;
        private Label labelTen;
        private Button button1;
    }
}