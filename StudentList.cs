using System;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;

namespace StudentManagement
{
    public partial class StudentList : Form
    {
        private List<Student> students = new List<Student>();
        public StudentList()
        {
            InitializeComponent();
            LoadStudents();
        }

        private void LoadStudents()
        {
            students = new List<Student>
            {
                new Student { Name = "Nguyen Van A", Class = "CTK43", MSSV = "123456", Gender = "Nam", DOB = new DateTime(2003, 5, 21), Address = "Hanoi", Grades = new Dictionary<string, double> { { "Math", 8.5 }, { "English", 7.5 } } },
                new Student { Name = "Tran Thi B", Class = "CTK43", MSSV = "123457", Gender = "Nữ", DOB = new DateTime(2003, 8, 15), Address = "HCMC", Grades = new Dictionary<string, double> { { "Math", 9.0 }, { "English", 8.0 } } }
            };

            dataGridViewStudents.DataSource = students.Select(s => new { s.Name, s.Class, s.MSSV }).ToList();
        }

        private void dataGridViewStudents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra không phải header
            {
                // Kiểm tra xem có dữ liệu hay không
                if (dataGridViewStudents.Rows[e.RowIndex].Cells[2].Value == null)
                {
                    MessageBox.Show("Lỗi: Dữ liệu MSSV không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string mssv = dataGridViewStudents.Rows[e.RowIndex].Cells[2].Value.ToString();

                // Tìm sinh viên theo MSSV
                Student student = students.FirstOrDefault(s => s.MSSV == mssv);

                // Kiểm tra nếu không tìm thấy sinh viên
                if (student == null)
                {
                    MessageBox.Show("Không tìm thấy thông tin sinh viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Mở form chi tiết với dữ liệu đầy đủ
                StudentDetailForm detailForm = new StudentDetailForm(
                    student.Name, student.Class, student.MSSV, student.Gender,
                    student.DOB, student.Address, student.Grades
                );
                detailForm.ShowDialog();
            }
        }
    }
}
