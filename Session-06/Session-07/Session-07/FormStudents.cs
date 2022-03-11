using Entities;
using Newtonsoft.Json;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_07
{
    public partial class FormStudents : Form
    {
        List<Student> students = new List<Student>();
        StudentService studentService = new StudentService();
        Student student = new Student();
        public FormStudents()
        {
            InitializeComponent();
        }

        private void FormStudents_Load(object sender, EventArgs e)
        {
            ShowStudents();
        }

        private void ShowStudents()
        {
            listViewStudents.Items.Clear();
            var json = studentService.Get();
            students = JsonConvert.DeserializeObject<List<Student>>(json);
            if (students != null)
            {
                foreach (var item in students)
                {
                    listViewStudents.Items.Add(string.Format("{0}", item.Name));
                }
            }
            else
            {
                students = new List<Student>();
            }
        }
        private void Edit()
        {
            if (listViewStudents.SelectedIndices.Count > 0)
            {
                students[listViewStudents.SelectedIndices[0]].Name = textName.Text;
                students[listViewStudents.SelectedIndices[0]].Age = Convert.ToInt32(textAge.Text);
                students[listViewStudents.SelectedIndices[0]].ResgistrationNumber = Convert.ToInt32(textRegistrationNumber.Text);
            }

        }
        private void New()
        {
            listViewStudents.Items.Add("new Student");

            students.Add(new Student() { Name = "New Student" });

        }
        private void Delete()
        {
            if (listViewStudents.SelectedIndices.Count > 0)
            {
                students.RemoveAt(listViewStudents.SelectedIndices[0]);
                listViewStudents.Items.RemoveAt(listViewStudents.SelectedIndices[0]);
                textName.Text = string.Empty;
                textAge.Text = string.Empty;
                textRegistrationNumber.Text = string.Empty;
            }
        }
        private void SaveToJson()
        {
            var json = JsonConvert.SerializeObject(students);
            studentService.Save(json);
        }

        private void ShowSelectedStudent()
        {
            if (listViewStudents.SelectedIndices.Count > 0)
            {
                student = students[listViewStudents.SelectedIndices[0]];
                textName.Text = student.Name;
                textAge.Text = student.Age.ToString();
                textRegistrationNumber.Text = student.ResgistrationNumber.ToString();
            }


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Edit();

            SaveToJson();

            ShowStudents();
        }

        private void listViewStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowSelectedStudent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            New();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
