namespace StudentManagement
{
    partial class StudentDetailForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblMSSV;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.DataGridView dataGridViewGrades;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblMSSV = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.dataGridViewGrades = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrades)).BeginInit();
            this.SuspendLayout();

            // Tiêu đề
            this.lblTitle.Text = "Thông Tin Sinh Viên";
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(100, 10);
            this.lblTitle.AutoSize = true;

            // Nhãn thông tin
            this.lblName.Text = "Tên: ";
            this.lblClass.Text = "Lớp: ";
            this.lblMSSV.Text = "MSSV: ";
            this.lblGender.Text = "Giới tính: ";
            this.lblDOB.Text = "Ngày sinh: ";
            this.lblAddress.Text = "Địa chỉ: ";

            // Vị trí các nhãn
            int startY = 50;
            int spacing = 30;

            // Bảng điểm
            this.dataGridViewGrades.Location = new System.Drawing.Point(20, startY);
            this.dataGridViewGrades.Size = new System.Drawing.Size(340, 150);
            this.dataGridViewGrades.ColumnCount = 2;
            this.dataGridViewGrades.Columns[0].Name = "Môn học";
            this.dataGridViewGrades.Columns[1].Name = "Điểm";

            // Cấu hình Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.lblTitle);
        }
    }
}