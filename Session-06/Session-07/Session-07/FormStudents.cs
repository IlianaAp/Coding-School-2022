using Entities;
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

        private void ShowStudents() { }
    }
}
