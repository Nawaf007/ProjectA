using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbDemo
{
    public partial class AdvisorSelect : Form
    {
        private int id;
        private AdvisorDetails par;

        public void Refresh()
        {
            StudentDataGrid.Columns.Clear();
            SearchCategory.Items.Clear();
            try
            {
                DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
                checkColumn.Name = "Select";
                checkColumn.HeaderText = "";
                checkColumn.TrueValue = true;
                checkColumn.FalseValue = false;
                checkColumn.Width = 20;
                checkColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                checkColumn.ReadOnly = false; //if the datagridview is resized (on form resize) the checkbox won't take up too much; value is relative to the other columns' fill values
                StudentDataGrid.Columns.Add(checkColumn);
                String cmd = "SELECT Person.Id, FirstName, LastName, Email FROM Advisor JOIN Person ON Advisor.Id = Person.Id WHERE Advisor.Id NOT IN (Select AdvisorId from Project JOIN ProjectAdvisor ON Id = ProjectId WHERE ProjectId = " + id.ToString() + ")";
                var reader = DatabaseConnection.getInstance().getData(cmd);

                List<AdvisorClass> students = new List<AdvisorClass>();
                while (reader.Read())
                {
                    AdvisorClass stu = new AdvisorClass();
                    stu.Id = (int)reader.GetValue(0);
                    stu.FirstName = reader.GetString(1);
                    stu.LastName = reader.GetString(2);
                    stu.Email = reader.GetString(3);
                    students.Add(stu);
                }
                StudentDataGrid.DataSource = students;
                for (int j = 0; j < StudentDataGrid.RowCount; j++)
                {
                    StudentDataGrid.Rows[j].Cells[StudentDataGrid.Columns["Select"].Index].Value = false;
                }
                StudentDataGrid.Columns["Id"].Visible = false;
                StudentDataGrid.Columns["Gender"].Visible = false;
                StudentDataGrid.Columns["Designation"].Visible = false;
                StudentDataGrid.Columns["Contact"].Visible = false;
                StudentDataGrid.Columns["DateOfBirth"].Visible = false;
                StudentDataGrid.Columns["Genders"].Visible = false;
                StudentDataGrid.Columns["Designations"].Visible = false;
                StudentDataGrid.Columns["Salary"].Visible = false;
                StudentDataGrid.Columns["AssignmentDate"].Visible = false;
                StudentDataGrid.Columns["AdvisorRole"].Visible = false;
                cmd = "SELECT FirstName, LastName, Email FROM Advisor JOIN Person ON Advisor.Id = Person.Id";
                reader = DatabaseConnection.getInstance().getData(cmd);
                int i = 0;
                while (reader.FieldCount > i)
                {
                    if (!SearchCategory.Items.Contains(reader.GetName(i)))
                    {
                        SearchCategory.Items.Add(reader.GetName(i));
                    }
                    i++;
                }
                SearchCategory.SelectedIndex = 0;
                cmd = "SELECT Value FROM Lookup WHERE Category = 'ADVISOR_ROLE'";
                reader = DatabaseConnection.getInstance().getData(cmd);
                i = 0;
                while (reader.Read())
                {
                    ARComboBox.Items.Add(reader.GetString(0));
                }
                ARComboBox.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public AdvisorSelect(int ProjectId, AdvisorDetails parent)
        {
            InitializeComponent();
            this.MinimumSize = new Size(this.Width, this.Height);
            id = ProjectId;
            par = parent;
            Refresh();
        }

        private void SearchCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < StudentDataGrid.RowCount; j++)
            {
                if (StudentDataGrid.Rows[j].Cells[StudentDataGrid.Columns["Select"].Index].Value == null)
                {
                    StudentDataGrid.Rows[j].Cells[StudentDataGrid.Columns["Select"].Index].Value = false;
                }
            }
            try
            {
                List<int> idi = new List<int>();
                for (int i = 0; i < StudentDataGrid.RowCount; i++)
                {
                    if ((bool)StudentDataGrid.Rows[i].Cells[StudentDataGrid.Columns["Select"].Index].Value)
                    {
                        idi.Add((int)StudentDataGrid.Rows[i].Cells[StudentDataGrid.Columns["Id"].Index].Value);
                    }
                }
                foreach (int idk in idi)
                {

                    String cmd = String.Format("INSERT INTO ProjectAdvisor(ProjectId, AdvisorId, AssignmentDate, AdvisorRole) VALUES({0}, {1}, GETDATE(), (SELECT Id FROM Lookup WHERE Category = 'ADVISOR_ROLE' AND Value = '{2}'))", id, idk, ARComboBox.Text);
                    DatabaseConnection.getInstance().exectuteQuery(cmd);
                }
                if (idi.Count == 0)
                {
                    MessageBox.Show("Nothing was selected.");
                }
                else
                {
                    par.Refresh();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void StudentDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == StudentDataGrid.Columns["Select"].Index)
            {
                if (StudentDataGrid.Rows[e.RowIndex].Cells[StudentDataGrid.Columns["Select"].Index].Value == null)
                {
                    StudentDataGrid.Rows[e.RowIndex].Cells[StudentDataGrid.Columns["Select"].Index].Value = true;
                }
                else
                {
                    StudentDataGrid.Rows[e.RowIndex].Cells[StudentDataGrid.Columns["Select"].Index].Value = !(bool)StudentDataGrid.Rows[e.RowIndex].Cells[StudentDataGrid.Columns["Select"].Index].Value;
                }
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (SearchTextBox.Text == "")
                {
                    Refresh();
                    return;
                }
                String cmd = "SELECT Person.Id, FirstName, LastName, Email FROM Advisor JOIN Person ON Advisor.Id = Person.Id WHERE Advisor.Id NOT IN (Select AdvisorId from Project JOIN ProjectAdvisor ON Id = ProjectId WHERE ProjectId = " + id.ToString() + ") AND " + SearchCategory.Text + " = '" + SearchTextBox.Text + "'";
                var reader = DatabaseConnection.getInstance().getData(cmd);
                List<AdvisorClass> students = new List<AdvisorClass>();
                while (reader.Read())
                {
                    AdvisorClass stu = new AdvisorClass();
                    stu.Id = (int)reader.GetValue(0);
                    stu.FirstName = reader.GetString(1);
                    stu.LastName = reader.GetString(2);
                    stu.Email = reader.GetString(3);
                    students.Add(stu);
                }
                StudentDataGrid.DataSource = students;
                for (int j = 0; j < StudentDataGrid.RowCount; j++)
                {
                    StudentDataGrid.Rows[j].Cells[StudentDataGrid.Columns["Select"].Index].Value = false;
                }
                StudentDataGrid.Columns["Id"].Visible = false;
                StudentDataGrid.Columns["Gender"].Visible = false;
                StudentDataGrid.Columns["Designation"].Visible = false;
                StudentDataGrid.Columns["Contact"].Visible = false;
                StudentDataGrid.Columns["DateOfBirth"].Visible = false;
                StudentDataGrid.Columns["Genders"].Visible = false;
                StudentDataGrid.Columns["Designations"].Visible = false;
                StudentDataGrid.Columns["Salary"].Visible = false;
                StudentDataGrid.Columns["AssignmentDate"].Visible = false;
                StudentDataGrid.Columns["AdvisorRole"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
