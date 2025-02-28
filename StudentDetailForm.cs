using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class StudentDetailForm : Form
    {
        public StudentDetailForm(string name, string studentClass, string mssv, string gender, DateTime dob, string address, Dictionary<string, double> grades)
        {
            InitializeComponent(); // Đảm bảo giao diện được load
            LoadStudentDetails(name, studentClass, mssv, gender, dob, address, grades);
        }

        private void LoadStudentDetails(string name, string studentClass, string mssv, string gender, DateTime dob, string address, Dictionary<string, double> grades)
        {
            lblName.Text = $"Tên: {name}";
            lblClass.Text = $"Lớp: {studentClass}";
            lblMSSV.Text = $"MSSV: {mssv}";
            lblGender.Text = $"Giới tính: {gender}";
            lblDOB.Text = $"Ngày sinh: {dob:dd/MM/yyyy}";
            lblAddress.Text = $"Địa chỉ: {address}";

            // Kiểm tra DataGridView đã tồn tại chưa
            if (dataGridViewGrades != null)
            {
                dataGridViewGrades.Rows.Clear();
                foreach (var subject in grades)
                {
                    dataGridViewGrades.Rows.Add(subject.Key, subject.Value);
                }
            }
        }
    }
}
