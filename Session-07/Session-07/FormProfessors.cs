using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using Services;

using Newtonsoft.Json;
using System.IO;
using static Entities.Professor;

namespace Session_07
{
    public partial class FormProfessors : Form
    {
        List<Professor> professors = new List<Professor>();
        ProfessorService professorService = new ProfessorService();
        Professor professor = new Professor();

        public FormProfessors()
        {
            InitializeComponent();
        }


        private void FormProfessors_Load(object sender, EventArgs e)
        {
            ShowProfessors();
            comboBoxRank.Properties.Items.AddRange(typeof(Ranks).GetEnumValues());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Edit();

            SaveToJson();

            ShowProfessors();


        }
        private void ShowSelectedProfessor()
        {
            if (listViewProfessors.SelectedIndices.Count > 0)
            {
                professor = professors[listViewProfessors.SelectedIndices[0]];
                textName.Text = professor.GetName();
                textAge.Text = professor.Age.ToString();
                comboBoxRank.EditValue = (object)professor.Rank;
            }


        }

        private void listViewProfessors_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowSelectedProfessor();
        }
        private void Edit()
        {
            if (listViewProfessors.SelectedIndices.Count > 0)
            {
                professors[listViewProfessors.SelectedIndices[0]].Name = textName.Text;
                professors[listViewProfessors.SelectedIndices[0]].Age = Convert.ToInt32(textAge.Text);
                professors[listViewProfessors.SelectedIndices[0]].Rank = (Ranks)comboBoxRank.EditValue;
            }

        }
        private void ShowProfessors()
        {
            listViewProfessors.Items.Clear();
            var json = professorService.Get();
            professors = JsonConvert.DeserializeObject<List<Professor>>(json);
            if (professors != null)
            {
                foreach (var item in professors)
                {
                    listViewProfessors.Items.Add(string.Format("{0}", item.GetName()));
                }
            }
            else
            {
                professors = new List<Professor>();
            }


        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            New();
        }
        private void New()
        {
            listViewProfessors.Items.Add("new Professor");

            professors.Add(new Professor() { Name = "New Professor" });

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();

        }
        private void Delete()
        {
            if (listViewProfessors.SelectedIndices.Count > 0)
            {
                professors.RemoveAt(listViewProfessors.SelectedIndices[0]);
                listViewProfessors.Items.RemoveAt(listViewProfessors.SelectedIndices[0]);
                textName.Text = string.Empty;
                textAge.Text = string.Empty;

            }
        }
        private void SaveToJson()
        {
            var json = JsonConvert.SerializeObject(professors);
            professorService.Save(json);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
