using System.Windows.Forms;

namespace StudentManagement
{
    partial class StudentList
    {
        private System.Windows.Forms.Button btnAddStudent;
        private DataGridView dataGridViewStudents;
        private TextBox searchBox;
        private Button searchButton;

        private void InitializeComponent()
        {
            this.dataGridViewStudents = new DataGridView();
            this.searchBox = new TextBox();
            this.searchButton = new Button();
            this.btnAddStudent = new System.Windows.Forms.Button();

            // Cấu hình Form
            this.Text = "Student Management";
            this.Size = new System.Drawing.Size(800, 500);

            // Cấu hình DataGridView
            this.dataGridViewStudents.Location = new System.Drawing.Point(20, 50);
            this.dataGridViewStudents.Size = new System.Drawing.Size(760, 400); 
            this.dataGridViewStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStudents.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            // Search Box
            this.searchBox.Location = new System.Drawing.Point(20, 12);
            this.searchBox.Size = new System.Drawing.Size(200, 20);

            // Search Button
            this.searchButton.Location = new System.Drawing.Point(230, 10);
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.Text = "Search";

            // Tạo nút "+"
            this.btnAddStudent.Text = "+";
            this.btnAddStudent.Font = new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Bold);
            this.btnAddStudent.Size = new System.Drawing.Size(80, 80);
            this.btnAddStudent.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddStudent.ForeColor = System.Drawing.Color.White;
            this.btnAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStudent.FlatAppearance.BorderSize = 0;

            // Đặt vị trí ở góc dưới bên phải
            this.btnAddStudent.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
            this.btnAddStudent.Location = new System.Drawing.Point(this.ClientSize.Width - 90, this.ClientSize.Height - 100);

            // Sự kiện resize để cập nhật vị trí nút "+"
            this.Resize += (s, e) => {
                this.btnAddStudent.Location = new System.Drawing.Point(this.ClientSize.Width - 50, this.ClientSize.Height - 50);
            };

            // Thêm controls vào form
            this.Controls.Add(this.dataGridViewStudents);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.btnAddStudent);
            this.btnAddStudent.BringToFront();

            this.dataGridViewStudents.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridViewStudents_CellDoubleClick);
        }
    }
}
