using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace DbDemo
{
    public partial class GroupDetails : Form
    {
        private int id;
        private bool BV(String col, DataGridView dgv)
        {
            for (int j = 0; j < ProjectDataGrid.RowCount; j++)
            {
                if (dgv.Rows[j].Cells[ProjectDataGrid.Columns[col].Index].Value == null)
                {
                    dgv.Rows[j].Cells[ProjectDataGrid.Columns[col].Index].Value = false;
                }
            }
            if (dgv.Columns[col] == null)
            {
                return false;
            }
            for (int i = 0; i < dgv.RowCount; i++)
            {
                if ((bool)dgv.Rows[i].Cells[dgv.Columns[col].Index].Value == true)
                {
                    return true;
                }
            }
            return false;
        }
        public void Refresh()
        {
            DeleteButtonP.Visible = false;
            EvalDeleteButton.Visible = false;
            StudentDataGrid.Columns.Clear();
            SearchCategoryS.Items.Clear();
            ProjectDataGrid.Columns.Clear();
            SearchCategoryP.Items.Clear();
            EvaluationDataGrid.Columns.Clear();
            SearchCategoryE.Items.Clear();
            try
            {
                String cmd = "Select Person.Id, FirstName, LastName, Contact, Email, DateOfBirth, Gender, RegistrationNo, GroupId, AssignmentDate, Value from ((Person JOIN Student ON Person.Id = Student.Id) JOIN GroupStudent ON Student.Id = StudentId) JOIN Lookup ON Lookup.Id = Status WHERE GroupId = " + id.ToString();
                var reader = DatabaseConnection.getInstance().getData(cmd);

                List<StudentClass> students = new List<StudentClass>();
                while (reader.Read())
                {
                    StudentClass stu = new StudentClass();
                    stu.Id = (int)reader.GetValue(0);
                    stu.FirstName = reader.GetString(1);
                    stu.LastName = reader.GetString(2);
                    stu.Contact = reader.GetString(3);
                    stu.Email = reader.GetString(4);
                    stu.DateOfBirth = (DateTime)reader.GetValue(5);
                    stu.Gender = (int)reader.GetValue(6);
                    stu.RegistrationNo = reader.GetString(7);
                    stu.GroupId = (int)reader.GetValue(8);
                    stu.AssignmentDate = (DateTime)reader.GetValue(9);
                    stu.Status = reader.GetString(10);
                    students.Add(stu);
                }
                StudentDataGrid.DataSource = students;
                StudentDataGrid.Columns["Id"].Visible = false;
                StudentDataGrid.Columns["Gender"].Visible = false;
                StudentDataGrid.Columns["Contact"].Visible = false;
                StudentDataGrid.Columns["Email"].Visible = false;
                StudentDataGrid.Columns["FirstName"].Visible = false;
                StudentDataGrid.Columns["LastName"].Visible = false;
                StudentDataGrid.Columns["DateOfBirth"].Visible = false;
                StudentDataGrid.Columns["Genders"].Visible = false;
                StudentDataGrid.Columns["GroupId"].Visible = false;
                cmd = "Select RegistrationNo, Status As Statuses from (Person JOIN Student ON Person.Id = Student.Id) JOIN GroupStudent ON Student.Id = StudentId";
                reader = DatabaseConnection.getInstance().getData(cmd);
                int i = 0;
                while (reader.FieldCount > i)
                {
                    if (!SearchCategoryS.Items.Contains(reader.GetName(i)))
                    {
                        SearchCategoryS.Items.Add(reader.GetName(i));
                    }
                    i++;
                }
                SearchCategoryS.SelectedIndex = 0;
                DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
                checkColumn.Name = "Select";
                checkColumn.HeaderText = "";
                checkColumn.TrueValue = true;
                checkColumn.FalseValue = false;
                checkColumn.Width = 20;
                checkColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                checkColumn.ReadOnly = false; //if the datagridview is resized (on form resize) the checkbox won't take up too much; value is relative to the other columns' fill values
                ProjectDataGrid.Columns.Add(checkColumn);
                cmd = "Select Id, Title, Description, AssignmentDate from Project JOIN GroupProject ON Id = ProjectId WHERE GroupId = " + id.ToString();
                reader = DatabaseConnection.getInstance().getData(cmd);
                List<ProjectClass> project = new List<ProjectClass>();
                while (reader.Read())
                {
                    ProjectClass stu = new ProjectClass();
                    stu.Id = (int)reader.GetValue(0);
                    stu.Titlle = reader.GetString(1);
                    stu.Description = reader.GetString(2);
                    stu.AssignmentDate = (DateTime)reader.GetValue(3);
                    project.Add(stu);
                }
                ProjectDataGrid.DataSource = project;
                ProjectDataGrid.Columns["Id"].Visible = false;
                ProjectDataGrid.Columns["Description"].Visible = false;
                for (int j = 0; j < ProjectDataGrid.RowCount; j++)
                {
                    ProjectDataGrid.Rows[j].Cells[ProjectDataGrid.Columns["Select"].Index].Value = false;
                }
                cmd = "Select Title from Project JOIN GroupProject ON Id = ProjectId";
                reader = DatabaseConnection.getInstance().getData(cmd);
                i = 0;
                while (reader.FieldCount > i)
                {
                    if (!SearchCategoryP.Items.Contains(reader.GetName(i)))
                    {
                        SearchCategoryP.Items.Add(reader.GetName(i));
                    }
                    i++;
                }
                SearchCategoryP.SelectedIndex = 0;
                cmd = "Select Id, Name, TotalMarks, TotalWeightage, ObtainedMarks, EvaluationDate from Evaluation JOIN GroupEvaluation ON Id = EvaluationId WHERE GroupId = " + id.ToString();
                reader = DatabaseConnection.getInstance().getData(cmd);
                DataGridViewCheckBoxColumn checkColumn2 = new DataGridViewCheckBoxColumn();
                checkColumn2.Name = "Select";
                checkColumn2.HeaderText = "";
                checkColumn2.TrueValue = true;
                checkColumn2.FalseValue = false;
                checkColumn2.Width = 20;
                checkColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                checkColumn2.ReadOnly = false; //if the datagridview is resized (on form resize) the checkbox won't take up too much; value is relative to the other columns' fill values
                EvaluationDataGrid.Columns.Add(checkColumn2);
                List<EvaluationClass> evaluation = new List<EvaluationClass>();
                while (reader.Read())
                {
                    EvaluationClass stu = new EvaluationClass();
                    stu.Id = (int)reader.GetValue(0);
                    stu.Name = reader.GetString(1);
                    stu.TotalMarks = (int)reader.GetValue(2);
                    stu.TotalWeightage = (int)reader.GetValue(3);
                    stu.ObtainedMarks = (int)reader.GetValue(4);
                    stu.EvaluationDate = (DateTime)reader.GetValue(5);
                    evaluation.Add(stu);
                }
                EvaluationDataGrid.DataSource = evaluation;
                EvaluationDataGrid.Columns["Id"].Visible = false;
                for (int j = 0; j < EvaluationDataGrid.RowCount; j++)
                {
                    EvaluationDataGrid.Rows[j].Cells[EvaluationDataGrid.Columns["Select"].Index].Value = false;
                }
                cmd = "Select Name, TotalMarks, TotalWeightage from Evaluation JOIN GroupEvaluation ON Id = EvaluationId";
                reader = DatabaseConnection.getInstance().getData(cmd);
                i = 0;
                while (reader.FieldCount > i)
                {
                    if (!SearchCategoryE.Items.Contains(reader.GetName(i)))
                    {
                        SearchCategoryE.Items.Add(reader.GetName(i));
                    }
                    i++;
                }
                SearchCategoryE.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public GroupDetails(int GroupId)
        {
            id =GroupId;
            InitializeComponent();
            this.MinimumSize = new Size(this.Width, this.Height);
            Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ProjectCreate_Click(object sender, EventArgs e)
        {
            ProjectSelect ps = new ProjectSelect(id, this);
            ps.Show();
        }

        private void SearchTextBoxP_TextChanged(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            List<int> idi = new List<int>();
            for (int i = 0; i < ProjectDataGrid.RowCount; i++)
            {
                if ((bool)ProjectDataGrid.Rows[i].Cells[ProjectDataGrid.Columns["Select"].Index].Value)
                {
                    idi.Add((int)ProjectDataGrid.Rows[i].Cells[ProjectDataGrid.Columns["Id"].Index].Value);
                }
            }
            int truedel = Convert.ToInt32(Microsoft.VisualBasic.Interaction.MsgBox("Are you sure to delete " + idi.Count.ToString() + " item/s?", MsgBoxStyle.YesNo, "Delete"));
            if (truedel == 6)
            {
                foreach (int idk in idi)
                {
                    try
                    {
                        String cmd = String.Format("DELETE FROM GroupProject WHERE ProjectId = '{0}' AND GroupId = '{1}'", idk, id);
                        DatabaseConnection.getInstance().exectuteQuery(cmd);
                        Refresh();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void ProjectDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == ProjectDataGrid.Columns["Select"].Index)
            {
                if (ProjectDataGrid.Rows[e.RowIndex].Cells[ProjectDataGrid.Columns["Select"].Index].Value == null)
                {
                    ProjectDataGrid.Rows[e.RowIndex].Cells[ProjectDataGrid.Columns["Select"].Index].Value = true;
                }
                else
                {
                    ProjectDataGrid.Rows[e.RowIndex].Cells[ProjectDataGrid.Columns["Select"].Index].Value = !(bool)ProjectDataGrid.Rows[e.RowIndex].Cells[ProjectDataGrid.Columns["Select"].Index].Value;
                }
                DeleteButtonP.Visible = BV("Select", ProjectDataGrid);
            }
        }

        private void SearchButtonP_Click(object sender, EventArgs e)
        {
            try
            {
                if (SearchTextBoxP.Text == "")
                {
                    Refresh();
                    return;
                }
                String cmd = "Select Id, Title, Description, AssignmentDate from Project JOIN GroupProject ON Id = ProjectId WHERE GroupId = " + id.ToString() + " AND " + SearchCategoryP.Text + " = '" + SearchTextBoxP.Text + "'";
                var reader = DatabaseConnection.getInstance().getData(cmd);
                List<ProjectClass> project = new List<ProjectClass>();
                while (reader.Read())
                {
                    ProjectClass stu = new ProjectClass();
                    stu.Id = (int)reader.GetValue(0);
                    stu.Titlle = reader.GetString(1);
                    stu.Description = reader.GetString(2);
                    stu.AssignmentDate = (DateTime)reader.GetValue(3);
                    project.Add(stu);
                }
                ProjectDataGrid.DataSource = project;
                ProjectDataGrid.Columns["Id"].Visible = false;
                ProjectDataGrid.Columns["Description"].Visible = false;
                for (int j = 0; j < ProjectDataGrid.RowCount; j++)
                {
                    ProjectDataGrid.Rows[j].Cells[ProjectDataGrid.Columns["Select"].Index].Value = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SearchButtonS_Click(object sender, EventArgs e)
        {
            try
            {
                if (SearchTextBoxS.Text == "")
                {
                    Refresh();
                    return;
                }
                String cmd = "Select Id, FirstName, LastName, Contact, Email, DateOfBirth, Gender, RegistrationNo, GroupId, AssignmentDate, Statuses from (Select Person.Id, FirstName, LastName, Contact, Email, DateOfBirth, Gender, RegistrationNo, GroupId, AssignmentDate, Value AS Statuses from ((Person JOIN Student ON Person.Id = Student.Id) JOIN GroupStudent ON Student.Id = StudentId) JOIN Lookup ON Lookup.Id = Status WHERE GroupId = " + id.ToString() + ") A WHERE " + SearchCategoryS.Text + " = '" + SearchTextBoxS.Text + "'";
                var reader = DatabaseConnection.getInstance().getData(cmd);

                List<StudentClass> students = new List<StudentClass>();
                while (reader.Read())
                {
                    StudentClass stu = new StudentClass();
                    stu.Id = (int)reader.GetValue(0);
                    stu.FirstName = reader.GetString(1);
                    stu.LastName = reader.GetString(2);
                    stu.Contact = reader.GetString(3);
                    stu.Email = reader.GetString(4);
                    stu.DateOfBirth = (DateTime)reader.GetValue(5);
                    stu.Gender = (int)reader.GetValue(6);
                    stu.RegistrationNo = reader.GetString(7);
                    stu.GroupId = (int)reader.GetValue(8);
                    stu.AssignmentDate = (DateTime)reader.GetValue(9);
                    stu.Status = reader.GetString(10);
                    students.Add(stu);
                }
                StudentDataGrid.DataSource = students;
                StudentDataGrid.Columns["Id"].Visible = false;
                StudentDataGrid.Columns["Gender"].Visible = false;
                StudentDataGrid.Columns["Contact"].Visible = false;
                StudentDataGrid.Columns["Email"].Visible = false;
                StudentDataGrid.Columns["FirstName"].Visible = false;
                StudentDataGrid.Columns["LastName"].Visible = false;
                StudentDataGrid.Columns["DateOfBirth"].Visible = false;
                StudentDataGrid.Columns["Genders"].Visible = false;
                StudentDataGrid.Columns["GroupId"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EvalDeleteButton_Click(object sender, EventArgs e)
        {
            List<int> idi = new List<int>();
            for (int i = 0; i < EvaluationDataGrid.RowCount; i++)
            {
                if ((bool)EvaluationDataGrid.Rows[i].Cells[EvaluationDataGrid.Columns["Select"].Index].Value)
                {
                    idi.Add((int)EvaluationDataGrid.Rows[i].Cells[EvaluationDataGrid.Columns["Id"].Index].Value);
                }
            }
            int truedel = Convert.ToInt32(Microsoft.VisualBasic.Interaction.MsgBox("Are you sure to delete " + idi.Count.ToString() + " item/s?", MsgBoxStyle.YesNo, "Delete"));
            if (truedel == 6)
            {
                foreach (int idk in idi)
                {
                    try
                    {
                        String cmd = String.Format("DELETE FROM GroupEvaluation WHERE EvaluationId = '{0}' AND GroupId = '{1}'", idk, id);
                        DatabaseConnection.getInstance().exectuteQuery(cmd);
                        Refresh();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void EvaluationDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == EvaluationDataGrid.Columns["Select"].Index)
            {
                if (EvaluationDataGrid.Rows[e.RowIndex].Cells[EvaluationDataGrid.Columns["Select"].Index].Value == null)
                {
                    EvaluationDataGrid.Rows[e.RowIndex].Cells[EvaluationDataGrid.Columns["Select"].Index].Value = true;
                }
                else
                {
                    EvaluationDataGrid.Rows[e.RowIndex].Cells[EvaluationDataGrid.Columns["Select"].Index].Value = !(bool)EvaluationDataGrid.Rows[e.RowIndex].Cells[EvaluationDataGrid.Columns["Select"].Index].Value;
                }
                EvalDeleteButton.Visible = BV("Select", EvaluationDataGrid);
            }
        }

        private void SearchButtonE_Click(object sender, EventArgs e)
        {
            try
            {
                if (SearchTextBoxE.Text == "")
                {
                    Refresh();
                    return;
                }
                String cmd = "Select Id, Name, TotalMarks, TotalWeightage, EvaluationDate from Evaluation JOIN GroupEvaluation ON Id = EvaluationId WHERE GroupId = " + id.ToString() + " AND " + SearchCategoryE.Text + " = '" + SearchTextBoxE.Text + "'";
                var reader = DatabaseConnection.getInstance().getData(cmd);
                List<EvaluationClass> evaluation = new List<EvaluationClass>();
                while (reader.Read())
                {
                    EvaluationClass stu = new EvaluationClass();
                    stu.Id = (int)reader.GetValue(0);
                    stu.Name = reader.GetString(1);
                    stu.TotalMarks = (int)reader.GetValue(2);
                    stu.TotalWeightage = (int)reader.GetValue(3);
                    stu.ObtainedMarks = (int)reader.GetValue(4);
                    stu.EvaluationDate = (DateTime)reader.GetValue(5);
                    evaluation.Add(stu);
                }
                EvaluationDataGrid.DataSource = evaluation;
                EvaluationDataGrid.Columns["Id"].Visible = false;
                for (int j = 0; j < EvaluationDataGrid.RowCount; j++)
                {
                    EvaluationDataGrid.Rows[j].Cells[EvaluationDataGrid.Columns["Select"].Index].Value = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EvaluationCreate_Click(object sender, EventArgs e)
        {
            EvaluationSelect es = new EvaluationSelect(id, this);
            es.Show();
        }
    }
}
