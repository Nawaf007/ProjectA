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
    public partial class ProjectSelect : Form
    {
        private int id;
        private GroupDetails par;
        public void Refresh()
        {
            ProjectDataGrid.Columns.Clear();
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
                ProjectDataGrid.Columns.Add(checkColumn);
                String cmd = "SELECT Id, Title FROM Project WHERE Id NOT IN (Select Id from Project JOIN GroupProject ON Id = ProjectId WHERE GroupId = " + id.ToString() + ")";
                var reader = DatabaseConnection.getInstance().getData(cmd);
                List<ProjectClass> project = new List<ProjectClass>();
                while (reader.Read())
                {
                    ProjectClass stu = new ProjectClass();
                    stu.Id = (int)reader.GetValue(0);
                    stu.Titlle = reader.GetString(1);
                    project.Add(stu);
                }
                ProjectDataGrid.DataSource = project;
                for (int j = 0; j < ProjectDataGrid.RowCount; j++)
                {
                    ProjectDataGrid.Rows[j].Cells[ProjectDataGrid.Columns["Select"].Index].Value = false;
                }
                ProjectDataGrid.Columns["Id"].Visible = false;
                ProjectDataGrid.Columns["Description"].Visible = false;
                ProjectDataGrid.Columns["AssignmentDate"].Visible = false;
                cmd = "Select Title from Project JOIN GroupProject ON Id = ProjectId";
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public ProjectSelect(int GroupId, GroupDetails parent)
        {
            InitializeComponent();
            this.MinimumSize = new Size(this.Width, this.Height);
            id = GroupId;
            par = parent;
            Refresh();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < ProjectDataGrid.RowCount; j++)
            {
                if(ProjectDataGrid.Rows[j].Cells[ProjectDataGrid.Columns["Select"].Index].Value == null)
                {
                    ProjectDataGrid.Rows[j].Cells[ProjectDataGrid.Columns["Select"].Index].Value = false;
                }
            }
            try
            {
                List<int> idi = new List<int>();
                for (int i = 0; i < ProjectDataGrid.RowCount; i++)
                {
                    if ((bool)ProjectDataGrid.Rows[i].Cells[ProjectDataGrid.Columns["Select"].Index].Value)
                    {
                        idi.Add((int)ProjectDataGrid.Rows[i].Cells[ProjectDataGrid.Columns["Id"].Index].Value);
                    }
                }
                foreach(int idk in idi)
                {

                    String cmd = String.Format("INSERT INTO GroupProject(ProjectId, GroupId, AssignmentDate) VALUES({0}, {1}, GETDATE())", idk, id);
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
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
                String cmd = "SELECT Id, Title FROM Project WHERE Id NOT IN (Select Id from Project JOIN GroupProject ON Id = ProjectId WHERE GroupId = " + id.ToString() + ") AND " + SearchCategory.Text + " = '" + SearchTextBox.Text + "'";
                var reader = DatabaseConnection.getInstance().getData(cmd);
                List<ProjectClass> project = new List<ProjectClass>();
                while (reader.Read())
                {
                    ProjectClass stu = new ProjectClass();
                    stu.Id = (int)reader.GetValue(0);
                    stu.Titlle = reader.GetString(1);
                    project.Add(stu);
                }
                ProjectDataGrid.DataSource = project;
                for (int j = 0; j < ProjectDataGrid.RowCount; j++)
                {
                    ProjectDataGrid.Rows[j].Cells[ProjectDataGrid.Columns["Select"].Index].Value = false;
                }
                ProjectDataGrid.Columns["Id"].Visible = false;
                ProjectDataGrid.Columns["Description"].Visible = false;
                ProjectDataGrid.Columns["AssignmentDate"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
