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
    public partial class AdvisorDetails : Form
    {
        private int id;
        private bool BV(String col)
        {
            if (StudentDataGrid.Columns[col] == null)
            {
                return false;
            }
            for (int i = 0; i < StudentDataGrid.RowCount; i++)
            {
                if ((bool)StudentDataGrid.Rows[i].Cells[StudentDataGrid.Columns[col].Index].Value)
                {
                    return true;
                }
            }
            return false;
        }
        public void Refresh()
        {
            DeleteButton.Visible = false;
            StudentDataGrid.Columns.Clear();
            SearchCategory.Items.Clear();
            try
            {
                String cmd = "SELECT Person.Id, FirstName, LastName, Email, AssignmentDate, Value AS AdvisorRoles FROM ((Advisor JOIN Person ON Advisor.Id = Person.Id) JOIN ProjectAdvisor ON Advisor.Id = AdvisorId) JOIN Lookup ON AdvisorRole = Lookup.Id WHERE ProjectId = " + id.ToString();
                var reader = DatabaseConnection.getInstance().getData(cmd);
                DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
                checkColumn.Name = "Select";
                checkColumn.HeaderText = "";
                checkColumn.TrueValue = true;
                checkColumn.FalseValue = false;
                checkColumn.Width = 20;
                checkColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                checkColumn.ReadOnly = false; //if the datagridview is resized (on form resize) the checkbox won't take up too much; value is relative to the other columns' fill values
                StudentDataGrid.Columns.Add(checkColumn);
                List<AdvisorClass> students = new List<AdvisorClass>();
                while (reader.Read())
                {
                    AdvisorClass stu = new AdvisorClass();
                    stu.Id = (int)reader.GetValue(0);
                    stu.FirstName = reader.GetString(1);
                    stu.LastName = reader.GetString(2);
                    stu.Email = reader.GetString(3);
                    stu.AssignmentDate = (DateTime)reader.GetValue(4);
                    stu.AdvisorRole = reader.GetString(5);
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
                cmd = "SELECT FirstName, LastName, Email, Value AS AdvisorRoles FROM ((Advisor JOIN Person ON Advisor.Id = Person.Id) JOIN ProjectAdvisor ON Advisor.Id = AdvisorId) JOIN Lookup ON AdvisorRole = Lookup.Id";
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
        public AdvisorDetails(int ProjectId)
        {
            InitializeComponent();
            this.MinimumSize = new Size(this.Width, this.Height);
            id = ProjectId;
            Refresh();
        }

        private void AdvisorCreate_Click(object sender, EventArgs e)
        {
            AdvisorSelect ps = new AdvisorSelect(id, this);
            ps.Show();
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
                DeleteButton.Visible = BV("Select");
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            List<int> idi = new List<int>();
            for (int i = 0; i < StudentDataGrid.RowCount; i++)
            {
                if ((bool)StudentDataGrid.Rows[i].Cells[StudentDataGrid.Columns["Select"].Index].Value)
                {
                    idi.Add((int)StudentDataGrid.Rows[i].Cells[StudentDataGrid.Columns["Id"].Index].Value);
                }
            }
            int truedel = Convert.ToInt32(Microsoft.VisualBasic.Interaction.MsgBox("Are you sure to delete " + idi.Count.ToString() + " item/s?", MsgBoxStyle.YesNo, "Delete"));
            if (truedel == 6)
            {
                foreach (int idk in idi)
                {
                    try
                    {
                        String cmd = String.Format("DELETE FROM ProjectAdvisor WHERE ProjectId = '{0}' AND AdvisorId = '{1}'", id, idk);
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

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (SearchTextBox.Text == "")
                {
                    Refresh();
                    return;
                }
                String cmd = "SELECT Person.Id, FirstName, LastName, Email, AssignmentDate, Value AS AdvisorRoles FROM ((Advisor JOIN Person ON Advisor.Id = Person.Id) JOIN ProjectAdvisor ON Advisor.Id = AdvisorId) JOIN Lookup ON AdvisorRole = Lookup.Id WHERE ProjectId = " + id.ToString() + " AND " + SearchCategory.Text + " = '" + SearchTextBox.Text + "'";
                var reader = DatabaseConnection.getInstance().getData(cmd);
                List<AdvisorClass> students = new List<AdvisorClass>();
                while (reader.Read())
                {
                    AdvisorClass stu = new AdvisorClass();
                    stu.Id = (int)reader.GetValue(0);
                    stu.FirstName = reader.GetString(1);
                    stu.LastName = reader.GetString(2);
                    stu.Email = reader.GetString(3);
                    stu.AssignmentDate = (DateTime)reader.GetValue(4);
                    stu.AdvisorRole = reader.GetString(5);
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
