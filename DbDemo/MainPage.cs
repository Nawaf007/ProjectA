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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;  

namespace DbDemo
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
            GRButton.Visible = false;
            this.MinimumSize = new Size(this.Width, this.Height);
            DatabaseConnection.getInstance().ConnectionString = "Data Source=HAIER-PC\\NAWAF;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=2922";
            try
            {
                var con = DatabaseConnection.getInstance().getConnection();
                con.Open();
            }
            catch (Exception ex)
            {

            }
            HomeButton.Checked = true;
            Refresh();
        }
        private bool BV(String col)
        {
            if(StudentDataGrid.Columns[col] == null)
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
        void IsHome(bool var)
        {
            PATG.Visible = var;
            SATG.Visible = var;
            NOP.Visible = var;
            AATP.Visible = var;
            TrademarkLabel.Visible = var;
            splitContainer4.Visible = var;
            splitContainer5.Visible = var;
            StudentDataGrid.Visible = !var;
            StudentCreate.Visible = !var;
            SearchButton.Visible = !var;
            SearchCategory.Visible = !var;
            SearchTextBox.Visible = !var;
            button1.Visible = !var;
            DeleteButton.Visible = !var;
            if(!var)
            {
                button1.Visible = BV("Select");
                DeleteButton.Visible = button1.Visible;
            }
        }

        public void Refresh()
        {
            StudentDataGrid.Columns.Clear();
            SearchCategory.Items.Clear();
            if(StudentButton.Checked)
            {
                IsHome(false);
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
                    String cmd = "Select Person.Id, FirstName, LastName, Contact, Email, DateOfBirth, Gender, Value, RegistrationNo, GroupId from (Person JOIN (SELECT Student.Id, RegistrationNo, GroupId FROM Student JOIN GroupStudent ON StudentId = Id AND Status = (SELECT Id FROM Lookup WHERE Category = 'STATUS' AND Value = 'Active') UNION SELECT Id, RegistrationNo,'' As GroupId FROM Student WHERE Id NOT IN (SELECT Student.Id FROM Student JOIN GroupStudent ON StudentId = Id)) Students ON Person.Id = Students.Id) JOIN Lookup ON Person.Gender = Lookup.Id ";
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
                        stu.Genders = reader.GetString(7);
                        stu.RegistrationNo = reader.GetString(8);
                        stu.GroupId = (int)reader.GetValue(9);
                        students.Add(stu);
                    }
                    StudentDataGrid.DataSource = students;
                    StudentDataGrid.Columns["Id"].Visible = false;
                    StudentDataGrid.Columns["Gender"].Visible = false;
                    StudentDataGrid.Columns["GroupId"].Visible = false;
                    StudentDataGrid.Columns["AssignmentDate"].Visible = false;
                    StudentDataGrid.Columns["Status"].Visible = false;
                    for (int j = 0; j < StudentDataGrid.RowCount; j++)
                    {
                        StudentDataGrid.Rows[j].Cells[StudentDataGrid.Columns["Select"].Index].Value = false;
                    }
                    DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();
                    bcol.HeaderText = "";
                    bcol.Text = "Edit";
                    bcol.Name = "btnEdit";
                    bcol.UseColumnTextForButtonValue = true;
                    StudentDataGrid.Columns.Add(bcol);
                    DataGridViewButtonColumn bcol1 = new DataGridViewButtonColumn();
                    bcol1.HeaderText = "";
                    bcol1.Text = "Group Details";
                    bcol1.Name = "btnGroup";
                    bcol1.UseColumnTextForButtonValue = true;
                    StudentDataGrid.Columns.Add(bcol1);
                    cmd = "Select FirstName, LastName, Contact, Email, Value AS Genders, RegistrationNo, GroupId from (Person JOIN (SELECT Student.Id, RegistrationNo, GroupId FROM Student JOIN GroupStudent ON StudentId = Id UNION SELECT Id, RegistrationNo,'' As GroupId FROM Student WHERE Id NOT IN (SELECT Student.Id FROM Student JOIN GroupStudent ON StudentId = Id)) Students ON Person.Id = Students.Id) JOIN Lookup ON Person.Gender = Lookup.Id";
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
            if(AdvisorButton.Checked)
            {
                IsHome(false);
                try
                {
                    String cmd = "Select Person.Id, FirstName, LastName, Contact, Email, DateOfBirth, Gender, Value AS Genders, Designation ,a.Designations, Salary from ((Person JOIN Advisor ON Person.Id = Advisor.Id) JOIN Lookup ON Person.Gender = Lookup.Id) JOIN (SELECT Id, Value As Designations, Category FROM Lookup) a ON Advisor.Designation = a.Id ";
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
                        stu.Contact = reader.GetString(3);
                        stu.Email = reader.GetString(4);
                        stu.DateOfBirth = (DateTime)reader.GetValue(5);
                        stu.Gender = (int)reader.GetValue(6);
                        stu.Genders = reader.GetString(7);
                        stu.Designation = (int)reader.GetValue(8);
                        stu.Designations = reader.GetString(9);
                        stu.Salary = (decimal)reader.GetValue(10);
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
                    StudentDataGrid.Columns["AssignmentDate"].Visible = false;
                    StudentDataGrid.Columns["AdvisorRole"].Visible = false;
                    DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();
                    bcol.HeaderText = "";
                    bcol.Text = "Edit";
                    bcol.Name = "btnEdit";
                    bcol.UseColumnTextForButtonValue = true;
                    StudentDataGrid.Columns.Add(bcol);
                    /*DataGridViewButtonColumn bcol1 = new DataGridViewButtonColumn();
                    bcol1.HeaderText = "";
                    bcol1.Text = "Delete";
                    bcol1.Name = "btnDelete";
                    bcol1.UseColumnTextForButtonValue = true;
                    StudentDataGrid.Columns.Add(bcol1);*/
                    cmd = "Select FirstName, LastName, Contact, Email, Value AS Genders, Designations, Salary from ((Person JOIN Advisor ON Person.Id = Advisor.Id) JOIN Lookup ON Person.Gender = Lookup.Id) JOIN (SELECT Id, Value As Designations, Category FROM Lookup) a ON Advisor.Designation = a.Id";
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
            if(ProjectButton.Checked)
            {
                IsHome(false);
                try
                {
                    String cmd = "Select Id, Title, Description from Project";
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
                    List<ProjectClass> students = new List<ProjectClass>();
                    while (reader.Read())
                    {
                        ProjectClass stu = new ProjectClass();
                        stu.Id = (int)reader.GetValue(0);
                        stu.Titlle = reader.GetString(1);
                        stu.Description = reader.GetString(2);
                        students.Add(stu);
                    }
                    StudentDataGrid.DataSource = students;
                    for (int j = 0; j < StudentDataGrid.RowCount; j++)
                    {
                        StudentDataGrid.Rows[j].Cells[StudentDataGrid.Columns["Select"].Index].Value = false;
                    }
                    StudentDataGrid.Columns["Id"].Visible = false;
                    StudentDataGrid.Columns["Description"].Visible = false;
                    StudentDataGrid.Columns["AssignmentDate"].Visible = false;
                    DataGridViewButtonColumn bcol3 = new DataGridViewButtonColumn();
                    bcol3.HeaderText = "";
                    bcol3.Text = "Details";
                    bcol3.Name = "btnDetails";
                    bcol3.UseColumnTextForButtonValue = true;
                    StudentDataGrid.Columns.Add(bcol3);
                    DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();
                    bcol.HeaderText = "";
                    bcol.Text = "Edit";
                    bcol.Name = "btnEdit";
                    bcol.UseColumnTextForButtonValue = true;
                    StudentDataGrid.Columns.Add(bcol);
                    /*DataGridViewButtonColumn bcol1 = new DataGridViewButtonColumn();
                    bcol1.HeaderText = "";
                    bcol1.Text = "Delete";
                    bcol1.Name = "btnDelete";
                    bcol1.UseColumnTextForButtonValue = true;
                    StudentDataGrid.Columns.Add(bcol1);*/
                    DataGridViewButtonColumn bcol2 = new DataGridViewButtonColumn();
                    bcol2.HeaderText = "";
                    bcol2.Text = "Group";
                    bcol2.Name = "btnGroup";
                    bcol2.UseColumnTextForButtonValue = true;
                    StudentDataGrid.Columns.Add(bcol2);
                    DataGridViewButtonColumn bcol4 = new DataGridViewButtonColumn();
                    bcol4.HeaderText = "";
                    bcol4.Text = "Advisor";
                    bcol4.Name = "btnAdvisor";
                    bcol4.UseColumnTextForButtonValue = true;
                    StudentDataGrid.Columns.Add(bcol4);
                    cmd = "Select Title from Project";
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
            if (EvaluationButton.Checked)
            {
                IsHome(false);
                try
                {
                    String cmd = "Select Id, Name, TotalMarks, TotalWeightage from Evaluation";
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
                    List<EvaluationClass> students = new List<EvaluationClass>();
                    while (reader.Read())
                    {
                        EvaluationClass stu = new EvaluationClass();
                        stu.Id = (int)reader.GetValue(0);
                        stu.Name = reader.GetString(1);
                        stu.TotalMarks = (int)reader.GetValue(2);
                        stu.TotalWeightage = (int)reader.GetValue(3);
                        students.Add(stu);
                    }
                    StudentDataGrid.DataSource = students;
                    for (int j = 0; j < StudentDataGrid.RowCount; j++)
                    {
                        StudentDataGrid.Rows[j].Cells[StudentDataGrid.Columns["Select"].Index].Value = false;
                    }
                    StudentDataGrid.Columns["Id"].Visible = false;
                    StudentDataGrid.Columns["ObtainedMarks"].Visible = false;
                    StudentDataGrid.Columns["EvaluationDate"].Visible = false;
                    DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();
                    bcol.HeaderText = "";
                    bcol.Text = "Edit";
                    bcol.Name = "btnEdit";
                    bcol.UseColumnTextForButtonValue = true;
                    StudentDataGrid.Columns.Add(bcol);
                    cmd = "Select Name, TotalMarks, TotalWeightage from Evaluation";
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
            /*if (GroupButton.Checked)
            {
                IsHome(false);
                try
                {
                    String cmd = "Select Id, Created_On, Title from (Group JOIN GroupProject ON Group.Id = GroupId) JOIN Project ON Project.Id = ProjectId";
                    var reader = DatabaseConnection.getInstance().getData(cmd);

                    List<GroupClass> students = new List<GroupClass>();
                    while (reader.Read())
                    {
                        GroupClass stu = new GroupClass();
                        stu.Id = (int)reader.GetValue(0);
                        stu.Created_On = (DateTime)reader.GetValue(1);
                        stu.Project = reader.GetString(2);
                        students.Add(stu);
                    }
                    StudentDataGrid.DataSource = students;
                    DataGridViewButtonColumn bcol3 = new DataGridViewButtonColumn();
                    bcol3.HeaderText = "";
                    bcol3.Text = "Details";
                    bcol3.Name = "btnDetails";
                    bcol3.UseColumnTextForButtonValue = true;
                    StudentDataGrid.Columns.Add(bcol3);
                    DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();
                    bcol.HeaderText = "";
                    bcol.Text = "Edit";
                    bcol.Name = "btnEdit";
                    bcol.UseColumnTextForButtonValue = true;
                    StudentDataGrid.Columns.Add(bcol);
                    DataGridViewButtonColumn bcol1 = new DataGridViewButtonColumn();
                    bcol1.HeaderText = "";
                    bcol1.Text = "Delete";
                    bcol1.Name = "btnDelete";
                    bcol1.UseColumnTextForButtonValue = true;
                    StudentDataGrid.Columns.Add(bcol1);
                    cmd = "Select Id, Title AS Projects from (Group JOIN GroupProject ON Group.Id = GroupId) JOIN Project ON Project.Id = ProjectId";
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
            }*/
            if(HomeButton.Checked)
            {
                IsHome(true);
                String cmd = "select COUNT(*) from Project";
                var reader = DatabaseConnection.getInstance().getData(cmd);
                while (reader.Read())
                {
                    NOP.Text = "No. of Projects: \n \n" + reader.GetValue(0).ToString();
                }
                cmd = "SELECT Count(*) FROM (SELECT DISTINCT StudentId FROM GroupStudent) A";
                reader = DatabaseConnection.getInstance().getData(cmd);
                while (reader.Read())
                {
                    SATG.Text = "Students assigned to Groups: \n \n" + reader.GetValue(0).ToString() + "\\";
                }
                cmd = "SELECT Count(*) FROM Student";
                reader = DatabaseConnection.getInstance().getData(cmd);
                while (reader.Read())
                {
                    SATG.Text = SATG.Text + reader.GetValue(0).ToString();
                }
                cmd = "SELECT Count(*) FROM (SELECT DISTINCT ProjectId FROM GroupProject) A";
                reader = DatabaseConnection.getInstance().getData(cmd);
                while (reader.Read())
                {
                    PATG.Text = "Projects assigned to Groups: \n \n" + reader.GetValue(0).ToString() + "\\";
                }
                cmd = "SELECT Count(*) FROM Project";
                reader = DatabaseConnection.getInstance().getData(cmd);
                while (reader.Read())
                {
                    PATG.Text = PATG.Text + reader.GetValue(0).ToString();
                }
                cmd = "SELECT Count(*) FROM (SELECT DISTINCT AdvisorId FROM ProjectAdvisor) A";
                reader = DatabaseConnection.getInstance().getData(cmd);
                while (reader.Read())
                {
                    AATP.Text = "Advisors assigned to Projects: \n \n" + reader.GetValue(0).ToString() + "\\";
                }
                cmd = "SELECT Count(*) FROM Advisor";
                reader = DatabaseConnection.getInstance().getData(cmd);
                while (reader.Read())
                {
                    AATP.Text = AATP.Text + reader.GetValue(0).ToString();
                }
                TrademarkLabel.Text = "Created by 2016-CE-07";
            }
        }

        private void HomeButton_CheckedChanged(object sender, EventArgs e)
        {
            HomeButton.Checked = true;
            AdvisorButton.Checked = false;
            ProjectButton.Checked = false;
            StudentButton.Checked = false;
            //GroupButton.Checked = false;
            EvaluationButton.Checked = false;
            GRButton.Visible = false;
            Refresh();
        }

        private void ProjectButton_CheckedChanged(object sender, EventArgs e)
        {
            HomeButton.Checked = false;
            AdvisorButton.Checked = false;
            ProjectButton.Checked = true;
            StudentButton.Checked = false;
            //GroupButton.Checked = false;
            EvaluationButton.Checked = false;
            GRButton.Visible = true;
            Refresh();
        }

        private void StudentButton_CheckedChanged(object sender, EventArgs e)
        {
            HomeButton.Checked = false;
            AdvisorButton.Checked = false;
            ProjectButton.Checked = false;
            StudentButton.Checked = true;
            //GroupButton.Checked = false;
            EvaluationButton.Checked = false;
            GRButton.Visible = true;
            Refresh();
        }

        private void AdvisorButton_CheckedChanged(object sender, EventArgs e)
        {
            HomeButton.Checked = false;
            AdvisorButton.Checked = true;
            ProjectButton.Checked = false;
            StudentButton.Checked = false;
            //GroupButton.Checked = false;
            EvaluationButton.Checked = false;
            GRButton.Visible = false;
            Refresh();
        }
        private void GroupButton_CheckedChanged(object sender, EventArgs e)
        {
            HomeButton.Checked = false;
            AdvisorButton.Checked = false;
            ProjectButton.Checked = false;
            StudentButton.Checked = false;
            //GroupButton.Checked = true;
            EvaluationButton.Checked = false;
            GRButton.Visible = false;
            Refresh();
        }

        private void EvaluationButton_CheckedChanged(object sender, EventArgs e)
        {
            HomeButton.Checked = false;
            AdvisorButton.Checked = false;
            ProjectButton.Checked = false;
            StudentButton.Checked = false;
            //GroupButton.Checked = false;
            EvaluationButton.Checked = true;
            GRButton.Visible = true;
            Refresh();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (StudentButton.Checked)
            {
                try
                {
                    if (SearchTextBox.Text == "")
                    {
                        Refresh();
                        return;
                    }
                    String cmd = "Select Person.Id, FirstName, LastName, Contact, Email, DateOfBirth, Gender, Genders, RegistrationNo, GroupId from (Person JOIN (SELECT Student.Id, RegistrationNo, GroupId FROM Student JOIN GroupStudent ON StudentId = Id UNION SELECT Id, RegistrationNo,'' As GroupId FROM Student WHERE Id NOT IN (SELECT Student.Id FROM Student JOIN GroupStudent ON StudentId = Id)) Students ON Person.Id = Students.Id) JOIN (SELECT Id, Value As Genders FROM Lookup) a ON Person.Gender = a.Id Where " + SearchCategory.Text + " = '" + SearchTextBox.Text + "'";
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
                        stu.Genders = reader.GetString(7);
                        stu.RegistrationNo = reader.GetString(8);
                        students.Add(stu);
                    }
                    StudentDataGrid.DataSource = students;
                    //StudentDataGrid.Columns[0].Visible = false;
                    //StudentDataGrid.Columns[6].Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (ProjectButton.Checked)
            {
                try
                {
                    if (SearchTextBox.Text == "")
                    {
                        Refresh();
                        return;
                    }
                    String cmd = "Select Id, Title, Description from Project Where " + SearchCategory.Text + " = '" + SearchTextBox.Text + "'";
                    var reader = DatabaseConnection.getInstance().getData(cmd);

                    List<ProjectClass> students = new List<ProjectClass>();
                    while (reader.Read())
                    {
                        ProjectClass stu = new ProjectClass();
                        stu.Id = (int)reader.GetValue(0);
                        stu.Titlle = reader.GetString(1);
                        stu.Description = reader.GetString(2);
                        students.Add(stu);
                    }
                    StudentDataGrid.DataSource = students;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (AdvisorButton.Checked)
            {
                try
                {
                    if (SearchTextBox.Text == "")
                    {
                        Refresh();
                        return;
                    }
                    String cmd = "Select Person.Id, FirstName, LastName, Contact, Email, DateOfBirth, Gender, Genders, Designation , Designations, Salary from ((Person JOIN Advisor ON Person.Id = Advisor.Id) JOIN (SELECT Id, Value As Genders FROM Lookup) b ON Person.Gender = b.Id) JOIN (SELECT Id, Value As Designations, Category FROM Lookup) a ON Advisor.Designation = a.Id Where " + SearchCategory.Text + " = '" + SearchTextBox.Text + "'";
                    var reader = DatabaseConnection.getInstance().getData(cmd);

                    List<AdvisorClass> students = new List<AdvisorClass>();
                    while (reader.Read())
                    {
                        AdvisorClass stu = new AdvisorClass();
                        stu.Id = (int)reader.GetValue(0);
                        stu.FirstName = reader.GetString(1);
                        stu.LastName = reader.GetString(2);
                        stu.Contact = reader.GetString(3);
                        stu.Email = reader.GetString(4);
                        stu.DateOfBirth = (DateTime)reader.GetValue(5);
                        stu.Gender = (int)reader.GetValue(6);
                        stu.Genders = reader.GetString(7);
                        stu.Designation = (int)reader.GetValue(8);
                        stu.Designations = reader.GetString(9);
                        stu.Salary = (decimal)reader.GetValue(10);
                        students.Add(stu);
                    }
                    StudentDataGrid.DataSource = students;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (EvaluationButton.Checked)
            {
                try
                {
                    if (SearchTextBox.Text == "")
                    {
                        Refresh();
                        return;
                    }
                    String cmd = "Select Id, Name, TotalMarks, TotalWeightage from Evaluation Where " + SearchCategory.Text + " = '" + SearchTextBox.Text + "'";
                    var reader = DatabaseConnection.getInstance().getData(cmd);

                    List<EvaluationClass> students = new List<EvaluationClass>();
                    while (reader.Read())
                    {
                        EvaluationClass stu = new EvaluationClass();
                        stu.Id = (int)reader.GetValue(0);
                        stu.Name = reader.GetString(1);
                        stu.TotalMarks = (int)reader.GetValue(2);
                        stu.TotalWeightage = (int)reader.GetValue(3);
                        students.Add(stu);
                    }
                    StudentDataGrid.DataSource = students;
                    //StudentDataGrid.Columns[0].Visible = false;
                    //StudentDataGrid.Columns[6].Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            /*if (GroupButton.Checked)
            {
                try
                {
                    if (SearchTextBox.Text == "")
                    {
                        Refresh();
                        return;
                    }
                    String cmd = "Select Id, Title AS Projects from (Group JOIN GroupProject ON Group.Id = GroupId) JOIN Project ON Project.Id = ProjectId Where " + SearchCategory.Text + " = '" + SearchTextBox.Text + "'";
                    var reader = DatabaseConnection.getInstance().getData(cmd);

                    List<GroupClass> students = new List<GroupClass>();
                    while (reader.Read())
                    {
                        GroupClass stu = new GroupClass();
                        stu.Id = (int)reader.GetValue(0);
                        stu.Created_On = (DateTime)reader.GetValue(1);
                        stu.Project = reader.GetString(2);
                        students.Add(stu);
                    }
                    StudentDataGrid.DataSource = students;
                    //StudentDataGrid.Columns[0].Visible = false;
                    //StudentDataGrid.Columns[6].Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }*/
        }
        private void StudentCreate_Click(object sender, EventArgs e)
        {
            if (StudentButton.Checked)
            {
                StudentCreate Sc = new StudentCreate(this);
                Sc.Show();
            }
            if (ProjectButton.Checked)
            {
                ProjectCreate Sc = new ProjectCreate(this);
                Sc.Show();
            }
            if (AdvisorButton.Checked)
            {
                AdvisorCreate Sc = new AdvisorCreate(this);
                Sc.Show();
            }
            if(EvaluationButton.Checked)
            {
                EvaluationCreate Ev = new EvaluationCreate(this);
                Ev.Show();
            }
            /*if(GroupButton.Checked)
            {
                //GroupCreate Sc = new GroupCreate(this);
                //Sc.Show();
            }*/
        }

        private void StudentDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == StudentDataGrid.Columns["Select"].Index)
            {
                StudentDataGrid.Rows[e.RowIndex].Cells[StudentDataGrid.Columns["Select"].Index].Value = !(bool)StudentDataGrid.Rows[e.RowIndex].Cells[StudentDataGrid.Columns["Select"].Index].Value;
                DeleteButton.Visible = BV("Select");
            }
            if (StudentButton.Checked)
            {
                int id;
                if (e.ColumnIndex == StudentDataGrid.Columns["Select"].Index)
                {
                    button1.Visible = BV("Select");
                }
                if (e.ColumnIndex == StudentDataGrid.Columns["btnGroup"].Index)
                {
                    id = (int)StudentDataGrid.Rows[e.RowIndex].Cells[StudentDataGrid.Columns["GroupId"].Index].Value;
                    GroupDetails gd = new GroupDetails(id);
                    gd.Show();
                }
                if (e.ColumnIndex == StudentDataGrid.Columns["btnEdit"].Index)
                {
                    id = (int)StudentDataGrid.Rows[e.RowIndex].Cells[StudentDataGrid.Columns["Id"].Index].Value;
                    StudentEdit se = new StudentEdit(id, this);
                    se.Show();
                }
            }
            if (ProjectButton.Checked)
            {
                int id;
                /*if (e.ColumnIndex == StudentDataGrid.Columns["btnDelete"].Index)
                {
                    id = (int)StudentDataGrid.Rows[e.RowIndex].Cells[StudentDataGrid.Columns["Id"].Index].Value;
                    int truedel = Convert.ToInt32(Microsoft.VisualBasic.Interaction.MsgBox("Are you sure?", MsgBoxStyle.YesNo, "Delete"));
                    if (truedel == 6)
                    {
                        try
                        {
                            String cmd = String.Format("DELETE FROM Project WHERE Id = '{0}'", id);
                            DatabaseConnection.getInstance().exectuteQuery(cmd);
                            Refresh();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }*/
                if (e.ColumnIndex == StudentDataGrid.Columns["btnEdit"].Index)
                {
                    id = (int)StudentDataGrid.Rows[e.RowIndex].Cells[StudentDataGrid.Columns["Id"].Index].Value;
                    ProjectEdit se = new ProjectEdit(id, this);
                    se.Show();
                }
                if (e.ColumnIndex == StudentDataGrid.Columns["btnDetails"].Index)
                {
                    id = (int)StudentDataGrid.Rows[e.RowIndex].Cells[StudentDataGrid.Columns["Id"].Index].Value;
                    ProjectDetails se = new ProjectDetails(id);
                    se.Show();
                }
                if (e.ColumnIndex == StudentDataGrid.Columns["btnAdvisor"].Index)
                {
                    id = (int)StudentDataGrid.Rows[e.RowIndex].Cells[StudentDataGrid.Columns["Id"].Index].Value;
                    AdvisorDetails se = new AdvisorDetails(id);
                    se.Show();
                }
                if (e.ColumnIndex == StudentDataGrid.Columns["btnGroup"].Index)
                {
                    id = (int)StudentDataGrid.Rows[e.RowIndex].Cells[StudentDataGrid.Columns["Id"].Index].Value;
                    String cmd = String.Format("SELECT COUNT(*) FROM Project JOIN GroupProject ON Id = ProjectId WHERE Id = '{0}'", id);
                    var reader = DatabaseConnection.getInstance().getData(cmd);
                    while(reader.Read())
                    {
                        if((int)reader.GetValue(0) == 0)
                        {
                            MessageBox.Show("Group is not assigned yet. \nTo assign a group, go to student section, in group details and add project.");
                        }
                        else if((int)reader.GetValue(0) == 1)
                        {
                            cmd = String.Format("SELECT GroupId FROM Project JOIN GroupProject ON Id = ProjectId WHERE Id = '{0}'", id);
                            var reader2 = DatabaseConnection.getInstance().getData(cmd);
                            while(reader2.Read())
                            {
                                GroupDetails gd = new GroupDetails((int)reader2.GetValue(0));
                                gd.Show();
                            }
                        }
                        else if((int)reader.GetValue(0) > 1)
                        {
                            Confirmation c = new Confirmation(id);
                            c.Show();
                        }
                    }
                }
            }
            if (AdvisorButton.Checked)
            {
                int id;
                /*if (e.ColumnIndex == StudentDataGrid.Columns["btnDelete"].Index)
                {
                    id = (int)StudentDataGrid.Rows[e.RowIndex].Cells[StudentDataGrid.Columns["Id"].Index].Value;
                    int truedel = Convert.ToInt32(Microsoft.VisualBasic.Interaction.MsgBox("Are you sure?", MsgBoxStyle.YesNo, "Delete"));
                    if (truedel == 6)
                    {
                        try
                        {
                            String cmd = String.Format("DELETE FROM Advisor WHERE Id = '{0}'", id);
                            DatabaseConnection.getInstance().exectuteQuery(cmd);
                            cmd = String.Format("DELETE FROM Person WHERE Id = '{0}'", id);
                            DatabaseConnection.getInstance().exectuteQuery(cmd);
                            Refresh();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }*/
                if (e.ColumnIndex == StudentDataGrid.Columns["btnEdit"].Index)
                {
                    id = (int)StudentDataGrid.Rows[e.RowIndex].Cells[StudentDataGrid.Columns["Id"].Index].Value;
                    AdvisorEdit se = new AdvisorEdit(id, this);
                    se.Show();
                }
            }
            if (EvaluationButton.Checked)
            {
                int id;
                if (e.ColumnIndex == StudentDataGrid.Columns["btnEdit"].Index)
                {
                    id = (int)StudentDataGrid.Rows[e.RowIndex].Cells[StudentDataGrid.Columns["Id"].Index].Value;
                    EvaluationEdit se = new EvaluationEdit(id, this);
                    se.Show();
                }
            }
            /*if (GroupButton.Checked)
            {
                int id;
                if (e.ColumnIndex == StudentDataGrid.Columns["btnDelete"].Index)
                {
                    id = (int)StudentDataGrid.Rows[e.RowIndex].Cells[StudentDataGrid.Columns["Id"].Index].Value;
                    int truedel = Convert.ToInt32(Microsoft.VisualBasic.Interaction.MsgBox("Are you sure?", MsgBoxStyle.YesNo, "Delete"));
                    if (truedel == 6)
                    {
                        try
                        {
                            String cmd = String.Format("DELETE FROM Group WHERE Id = '{0}'; DELETE FROM GroupProject WHERE GroupId = '{0}'; DELETE FROM GroupStudent WHERE GroupId = '{0}'; DELETE FROM GroupEvaluation WHERE GroupId = '{0}';", id);
                            DatabaseConnection.getInstance().exectuteQuery(cmd);
                            Refresh();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                if (e.ColumnIndex == StudentDataGrid.Columns["btnEdit"].Index)
                {
                    id = (int)StudentDataGrid.Rows[e.RowIndex].Cells[StudentDataGrid.Columns["Id"].Index].Value;
                    //GroupEdit se = new GroupEdit(id, this);
                    //se.Show();
                }
                if (e.ColumnIndex == StudentDataGrid.Columns["btnDetails"].Index)
                {
                    id = (int)StudentDataGrid.Rows[e.RowIndex].Cells[StudentDataGrid.Columns["Id"].Index].Value;
                    //GroupDetails se = new GroupDetails(id);
                    //se.Show();
                }
            }*/
        }

        private void splitContainer7_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String ids = "-1";
            List<int> idi = new List<int>();
            int? count = 0;
            for(int i = 0; i < StudentDataGrid.RowCount; i++)
            {
                if ((bool)StudentDataGrid.Rows[i].Cells[StudentDataGrid.Columns["Select"].Index].Value)
                {
                    ids = ids + ", " + StudentDataGrid.Rows[i].Cells[StudentDataGrid.Columns["Id"].Index].Value.ToString();
                    idi.Add((int)StudentDataGrid.Rows[i].Cells[StudentDataGrid.Columns["Id"].Index].Value);
                }
            }
            String cmd = "Select Count(*) from Student JOIN GroupStudent ON Id = StudentId AND Status = (SELECT Id FROM Lookup WHERE Category = 'STATUS' AND Value = 'Active') WHERE Id IN (" + ids + ")";
            var reader = DatabaseConnection.getInstance().getData(cmd);
            while (reader.Read())
            {
                count = (int)reader.GetValue(0);
            }
            int truecount = 6;
            if(count != 0)
            {
                truecount = Convert.ToInt32(Microsoft.VisualBasic.Interaction.MsgBox(count.ToString() + " student/s already exists in a group.\nIf you hit 'Yes' he/she/they will be removed from other group/s.", MsgBoxStyle.YesNo, "Confirmation"));
            }
            if(truecount == 6)
            {
                truecount = Convert.ToInt32(Microsoft.VisualBasic.Interaction.MsgBox("Do you want to select a old group of an student to be assigned to other students?.", MsgBoxStyle.YesNo, "Confirmation"));
                if (truecount == 6)
                {
                    Confirmation sc = new Confirmation(idi, ids, this);
                    sc.Show();
                }
                else
                {
                    cmd = "UPDATE GroupStudent SET Status = (SELECT Id FROM Lookup WHERE Category = 'STATUS' AND Value = 'InActive') WHERE StudentId IN (Select Id from Student JOIN GroupStudent ON Id = StudentId WHERE Id IN (" + ids + "))";
                    DatabaseConnection.getInstance().exectuteQuery(cmd);
                    cmd = "INSERT INTO [ProjectA].[dbo].[Group] (Created_On) OUTPUT Inserted.Id VALUES (GETDATE())";
                    reader = DatabaseConnection.getInstance().getData(cmd);
                    while (reader.Read())
                    {
                        count = (int)reader.GetValue(0);
                    }
                    foreach (int x in idi)
                    {
                        cmd = String.Format("Insert INTO GroupStudent(GroupId, StudentId, Status, AssignmentDate) values('{0}', '{1}', (SELECT Id FROM Lookup WHERE Category = 'STATUS' AND Value = 'Active'), GETDATE())", count, x);
                        DatabaseConnection.getInstance().exectuteQuery(cmd);
                    }
                    MessageBox.Show("Group created.");
                }
                Refresh();
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
            if(StudentButton.Checked && truedel == 6)
            {
                foreach(int id in idi)
                {
                    try
                    {
                        String cmd = String.Format("DELETE FROM GroupStudent OUTPUT deleted.GroupId WHERE StudentId = '{0}'", id);
                        var reader = DatabaseConnection.getInstance().getData(cmd);
                        while(reader.Read())
                        {
                            cmd = String.Format("SELECT Count(*) FROM GroupStudent WHERE GroupId = '{0}'", (int)reader.GetValue(0));
                            var reader2 = DatabaseConnection.getInstance().getData(cmd);
                            while(reader2.Read())
                            {
                                if((int)reader2.GetValue(0) == 0)
                                {
                                    cmd = String.Format("DELETE FROM GroupEvaluation WHERE GroupId = '{0}'", (int)reader.GetValue(0));
                                    DatabaseConnection.getInstance().exectuteQuery(cmd);
                                    cmd = String.Format("DELETE FROM GroupProject WHERE GroupId = '{0}'", (int)reader.GetValue(0));
                                    DatabaseConnection.getInstance().exectuteQuery(cmd);
                                    cmd = String.Format("DELETE FROM [ProjectA].[dbo].[Group] WHERE Id = '{0}'", (int)reader.GetValue(0));
                                    DatabaseConnection.getInstance().exectuteQuery(cmd);
                                }
                            }
                        }
                        cmd = String.Format("DELETE FROM Student WHERE Id = '{0}'", id);
                        DatabaseConnection.getInstance().exectuteQuery(cmd);
                        cmd = String.Format("DELETE FROM Person WHERE Id = '{0}'", id);
                        DatabaseConnection.getInstance().exectuteQuery(cmd);
                        Refresh();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            if (AdvisorButton.Checked && truedel == 6)
            {
                foreach (int id in idi)
                {
                    try
                    {
                        String cmd = String.Format("DELETE FROM ProjectAdvisor WHERE AdvisorId = '{0}'", id);
                        DatabaseConnection.getInstance().exectuteQuery(cmd);
                        cmd = String.Format("DELETE FROM Advisor WHERE Id = '{0}'", id);
                        DatabaseConnection.getInstance().exectuteQuery(cmd);
                        cmd = String.Format("DELETE FROM Person WHERE Id = '{0}'", id);
                        DatabaseConnection.getInstance().exectuteQuery(cmd);
                        Refresh();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            if (ProjectButton.Checked && truedel == 6)
            {
                foreach (int id in idi)
                {
                    try
                    {
                        String cmd = String.Format("DELETE FROM ProjectAdvisor WHERE ProjectId = '{0}'", id);
                        DatabaseConnection.getInstance().exectuteQuery(cmd);
                        cmd = String.Format("DELETE FROM GroupProject WHERE ProjectId = '{0}'", id);
                        DatabaseConnection.getInstance().exectuteQuery(cmd);
                        cmd = String.Format("DELETE FROM Project WHERE Id = '{0}'", id);
                        DatabaseConnection.getInstance().exectuteQuery(cmd);
                        Refresh();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            if (EvaluationButton.Checked && truedel == 6)
            {
                foreach (int id in idi)
                {
                    try
                    {
                        String cmd = String.Format("DELETE FROM GroupEvaluation WHERE EvaluationId = '{0}'", id);
                        DatabaseConnection.getInstance().exectuteQuery(cmd);
                        cmd = String.Format("DELETE FROM Evaluation WHERE Id = '{0}'", id);
                        DatabaseConnection.getInstance().exectuteQuery(cmd);
                        Refresh();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            Refresh();
        }

        private void NOP_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProjectButton.Checked)
                {
                    BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                    iTextSharp.text.Font font = new iTextSharp.text.Font(bf, 16, iTextSharp.text.Font.BOLDITALIC);
                    Document document = new Document();
                    PdfWriter.GetInstance(document, new FileStream("../../../Reports/ProjectReport.pdf", FileMode.Create));
                    document.Open();
                    Paragraph p = new Paragraph(new Chunk("Projects List \n \n", font));
                    p.Alignment = Element.ALIGN_CENTER; ;
                    p.Font = font;
                    document.Add(p);
                    PdfPTable table = new PdfPTable(3);
                    iTextSharp.text.Font font2 = new iTextSharp.text.Font(bf, 14, iTextSharp.text.Font.BOLDITALIC);
                    PdfPCell cell = new PdfPCell(new Phrase(new Chunk("Projects", font2)));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(new Chunk("Type", font2)));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(new Chunk("Name", font2)));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);

                    string cmd = "SELECT Id FROM Project";
                    var reader = DatabaseConnection.getInstance().getData(cmd);
                    List<int> idi = new List<int>();
                    while (reader.Read())
                    {
                        idi.Add((int)reader.GetValue(0));
                    }
                    foreach (int i in idi)
                    {
                        int count = -1;
                        cmd = "SELECT count(*) FROM Project JOIN ProjectAdvisor ON Project.Id = ProjectId WHERE Project.Id = " + i;
                        reader = DatabaseConnection.getInstance().getData(cmd);
                        while (reader.Read())
                        {
                            count = (int)reader.GetValue(0);
                        }
                        if (count == 0)
                        {
                            cmd = "SELECT Title FROM Project WHERE Id = " + i;
                            reader = DatabaseConnection.getInstance().getData(cmd);
                            while (reader.Read())
                            {
                                cell = new PdfPCell(new Phrase(reader.GetString(0)));
                                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                                table.AddCell(cell);
                                cell = new PdfPCell(new Phrase("Not Assigned"));
                                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                                table.AddCell(cell);
                                cell = new PdfPCell(new Phrase("Not Assigned"));
                                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                                table.AddCell(cell);

                            }
                        }
                        else
                        {
                            cmd = "SELECT Title FROM Project WHERE Id = " + i;
                            reader = DatabaseConnection.getInstance().getData(cmd);
                            while (reader.Read())
                            {
                                cell = new PdfPCell(new Phrase(reader.GetString(0)));
                                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                                cell.Rowspan = count;
                                table.AddCell(cell);
                            }
                            cmd = "SELECT Value, FirstName + LastName FROM ((ProjectAdvisor JOIN Advisor ON Advisor.Id = AdvisorId) JOIN Person ON Advisor.Id = Person.Id) JOIN Lookup ON AdvisorRole = Lookup.Id WHERE ProjectId = " + i + " ORDER BY AdvisorRole";
                            reader = DatabaseConnection.getInstance().getData(cmd);
                            while (reader.Read())
                            {
                                cell = new PdfPCell(new Phrase(reader.GetString(0)));
                                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                                table.AddCell(cell);
                                cell = new PdfPCell(new Phrase(reader.GetString(1)));
                                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                                table.AddCell(cell);
                            }
                        }
                    }
                    table.WidthPercentage = 100;
                    document.Add(table);
                    document.Close();
                    MessageBox.Show("File stored in project files in Reports folder.\nName: ProjectReport.pdf");
                }
                if (StudentButton.Checked)
                {
                    BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                    iTextSharp.text.Font font = new iTextSharp.text.Font(bf, 16, iTextSharp.text.Font.BOLDITALIC);
                    Document document = new Document();
                    PdfWriter.GetInstance(document, new FileStream("../../../Reports/StudentReport.pdf", FileMode.Create));
                    document.Open();
                    Paragraph p = new Paragraph(new Chunk("Students List \n \n", font));
                    p.Alignment = Element.ALIGN_CENTER; ;
                    p.Font = font;
                    document.Add(p);
                    PdfPTable table = new PdfPTable(6);
                    iTextSharp.text.Font font2 = new iTextSharp.text.Font(bf, 14, iTextSharp.text.Font.BOLDITALIC);
                    PdfPCell cell = new PdfPCell(new Phrase(new Chunk("Registration No.", font2)));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(new Chunk("Name", font2)));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(new Chunk("Project", font2)));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(new Chunk("Total Marks", font2)));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(new Chunk("Obtained Marks", font2)));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(new Chunk("Weightage %", font2)));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);

                    string cmd = "SELECT Id FROM Student ";
                    var reader = DatabaseConnection.getInstance().getData(cmd);
                    List<int> idi = new List<int>();
                    while (reader.Read())
                    {
                        idi.Add((int)reader.GetValue(0));
                    }
                    foreach (int i in idi)
                    {
                        int count = -1;
                        cmd = "SELECT count(*) FROM (Student JOIN GroupStudent ON Student.Id = StudentId) JOIN GroupProject ON GroupStudent.GroupId = GroupProject.GroupId WHERE Status = (SELECT Id FROM Lookup WHERE Category = 'STATUS' AND Value = 'Active') AND Student.Id = " + i;
                        reader = DatabaseConnection.getInstance().getData(cmd);
                        while (reader.Read())
                        {
                            count = (int)reader.GetValue(0);
                        }
                        if (count == 0)
                        {
                            cmd = "SELECT RegistrationNo, FirstName + ' ' + LastName FROM Student JOIN Person ON Person.Id = Student.Id WHERE Person.Id = " + i;
                            reader = DatabaseConnection.getInstance().getData(cmd);
                            while (reader.Read())
                            {
                                cell = new PdfPCell(new Phrase(reader.GetString(0)));
                                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                                table.AddCell(cell);
                                cell = new PdfPCell(new Phrase(reader.GetString(1)));
                                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                                table.AddCell(cell);
                                cell = new PdfPCell(new Phrase("Not Assigned"));
                                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                                table.AddCell(cell);
                                cell = new PdfPCell(new Phrase("0"));
                                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                                table.AddCell(cell);
                                cell = new PdfPCell(new Phrase("0"));
                                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                                table.AddCell(cell);
                                cell = new PdfPCell(new Phrase("0"));
                                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                                table.AddCell(cell);
                            }
                        }
                        else
                        {
                            cmd = "SELECT RegistrationNo, FirstName + ' ' + LastName FROM Student JOIN Person ON Person.Id = Student.Id WHERE Person.Id = " + i;
                            reader = DatabaseConnection.getInstance().getData(cmd);
                            while (reader.Read())
                            {
                                cell = new PdfPCell(new Phrase(reader.GetString(0)));
                                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                                cell.Rowspan = count;
                                table.AddCell(cell);
                                cell = new PdfPCell(new Phrase(reader.GetString(1)));
                                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                                cell.Rowspan = count;
                                table.AddCell(cell);

                            }
                            cmd = "SELECT ProjectId FROM ((Student JOIN GroupStudent ON Student.Id = StudentId) JOIN GroupProject ON GroupStudent.GroupId = GroupProject.GroupId) JOIN Project ON Project.Id = ProjectId WHERE Status = (SELECT Id FROM Lookup WHERE Category = 'STATUS' AND Value = 'Active') AND Student.Id = " + i + " EXCEPT SELECT ProjectId FROM (SELECT Title, Name, TotalMarks, RegistrationNo, ObtainedMarks, TotalWeightage, GroupStudent.AssignmentDate, EvaluationDate, GroupStudent.GroupId, StudentId, ProjectId, EvaluationId FROM ((((GroupProject JOIN GroupEvaluation ON GroupProject.GroupId = GroupEvaluation.GroupId) JOIN GroupStudent ON GroupProject.GroupId = GroupStudent.GroupId) JOIN Project ON ProjectId = Project.Id) JOIN Evaluation ON EvaluationId = Evaluation.Id) JOIN Student ON StudentId = Student.Id WHERE Status = (SELECT Id FROM Lookup WHERE Category = 'STATUS' AND Value = 'Active') AND Convert(date, GroupStudent.AssignmentDate) <= convert(date, GroupEvaluation.EvaluationDate) UNION SELECT Title, Name, TotalMarks, RegistrationNo, ObtainedMarks, TotalWeightage, AssignmentDate, EvaluationDate, GroupId, StudentId, ProjectId, EvaluationId FROM (SELECT Title, Evaluation.Name, TotalMarks, RegistrationNo, ObtainedMarks, TotalWeightage, GroupStudent.GroupId, StudentId, ProjectId, EvaluationId, Status, GroupStudent.AssignmentDate, EvaluationDate FROM ((((GroupProject JOIN GroupEvaluation ON GroupProject.GroupId = GroupEvaluation.GroupId) JOIN GroupStudent ON GroupProject.GroupId = GroupStudent.GroupId) JOIN Project ON ProjectId = Project.Id) JOIN Evaluation ON EvaluationId = Evaluation.Id) JOIN Student ON StudentId = Student.Id) as a WHERE Status = (SELECT Id FROM Lookup WHERE Category = 'STATUS' AND Value = 'InActive') AND Convert(date, AssignmentDate) <= convert(date, EvaluationDate) AND Convert(date, (SELECT AssignmentDate FROM GroupStudent WHERE StudentId = a.StudentId AND Status = (SELECT Id FROM Lookup WHERE Category = 'STATUS' AND Value = 'Active'))) >= convert(date, EvaluationDate)) B WHERE StudentId = " + i;
                            reader = DatabaseConnection.getInstance().getData(cmd);
                            if(reader.HasRows == true)
                            {
                                cmd = "SELECT Title FROM ((Student JOIN GroupStudent ON Student.Id = StudentId) JOIN GroupProject ON GroupStudent.GroupId = GroupProject.GroupId) JOIN Project ON Project.Id = ProjectId WHERE Status = (SELECT Id FROM Lookup WHERE Category = 'STATUS' AND Value = 'Active') AND Student.Id = " + i;
                                reader = DatabaseConnection.getInstance().getData(cmd);
                                while (reader.Read())
                                {
                                    cell = new PdfPCell(new Phrase(reader.GetString(0)));
                                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                                    table.AddCell(cell);
                                    cell = new PdfPCell(new Phrase("0"));
                                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                                    table.AddCell(cell);
                                    cell = new PdfPCell(new Phrase("0"));
                                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                                    table.AddCell(cell);
                                    cell = new PdfPCell(new Phrase("0"));
                                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                                    table.AddCell(cell);
                                }
                            }
                            cmd = "SELECT Title, SUM(TotalMarks), Sum(ObtainedMarks), SUM(TotalWeightage) FROM (SELECT Title, Name, TotalMarks, RegistrationNo, ObtainedMarks, TotalWeightage, GroupStudent.AssignmentDate, EvaluationDate, GroupStudent.GroupId, StudentId, ProjectId, EvaluationId FROM ((((GroupProject JOIN GroupEvaluation ON GroupProject.GroupId = GroupEvaluation.GroupId) JOIN GroupStudent ON GroupProject.GroupId = GroupStudent.GroupId) JOIN Project ON ProjectId = Project.Id) JOIN Evaluation ON EvaluationId = Evaluation.Id) JOIN Student ON StudentId = Student.Id WHERE Status = (SELECT Id FROM Lookup WHERE Category = 'STATUS' AND Value = 'Active') AND Convert(date, GroupStudent.AssignmentDate) <= convert(date, GroupEvaluation.EvaluationDate) UNION SELECT Title, Name, TotalMarks, RegistrationNo, ObtainedMarks, TotalWeightage, AssignmentDate, EvaluationDate, GroupId, StudentId, ProjectId, EvaluationId FROM (SELECT Title, Evaluation.Name, TotalMarks, RegistrationNo, ObtainedMarks, TotalWeightage, GroupStudent.GroupId, StudentId, ProjectId, EvaluationId, Status, GroupStudent.AssignmentDate, EvaluationDate FROM ((((GroupProject JOIN GroupEvaluation ON GroupProject.GroupId = GroupEvaluation.GroupId) JOIN GroupStudent ON GroupProject.GroupId = GroupStudent.GroupId) JOIN Project ON ProjectId = Project.Id) JOIN Evaluation ON EvaluationId = Evaluation.Id) JOIN Student ON StudentId = Student.Id) as a WHERE Status = (SELECT Id FROM Lookup WHERE Category = 'STATUS' AND Value = 'InActive') AND Convert(date, AssignmentDate) <= convert(date, EvaluationDate) AND Convert(date, (SELECT AssignmentDate FROM GroupStudent WHERE StudentId = a.StudentId AND Status = (SELECT Id FROM Lookup WHERE Category = 'STATUS' AND Value = 'Active'))) >= convert(date, EvaluationDate)) B WHERE StudentId = " + i + " GROUP BY Title";
                            reader = DatabaseConnection.getInstance().getData(cmd);
                            while (reader.Read())
                            {
                                cell = new PdfPCell(new Phrase(reader.GetString(0)));
                                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                                table.AddCell(cell);
                                cell = new PdfPCell(new Phrase(reader.GetValue(1).ToString()));
                                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                                table.AddCell(cell);
                                cell = new PdfPCell(new Phrase(reader.GetValue(2).ToString()));
                                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                                table.AddCell(cell);
                                cell = new PdfPCell(new Phrase(reader.GetValue(3).ToString()));
                                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                                table.AddCell(cell);
                            }
                        }
                    }
                    table.WidthPercentage = 100;
                    document.Add(table);
                    document.Close();
                    MessageBox.Show("File stored in project files in Reports folder.\nName: StudentReport.pdf");
                }
                if (EvaluationButton.Checked)
                {
                    BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                    iTextSharp.text.Font font = new iTextSharp.text.Font(bf, 16, iTextSharp.text.Font.BOLDITALIC);
                    Document document = new Document();
                    PdfWriter.GetInstance(document, new FileStream("../../../Reports/EvaluationReport.pdf", FileMode.Create));
                    document.Open();
                    Paragraph p = new Paragraph(new Chunk("Evaluation List \n \n", font));
                    p.Alignment = Element.ALIGN_CENTER; ;
                    p.Font = font;
                    document.Add(p);
                    PdfPTable table = new PdfPTable(6);
                    iTextSharp.text.Font font2 = new iTextSharp.text.Font(bf, 14, iTextSharp.text.Font.BOLDITALIC);
                    PdfPCell cell = new PdfPCell(new Phrase(new Chunk("Project", font2)));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(new Chunk("Evaluation", font2)));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(new Chunk("Total Marks", font2)));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(new Chunk("Weightage %", font2)));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(new Chunk("Registration Number", font2)));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                    cell = new PdfPCell(new Phrase(new Chunk("Obtained Marks", font2)));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);

                    string cmd = "SELECT Id FROM Project";
                    var reader = DatabaseConnection.getInstance().getData(cmd);
                    List<int> idi = new List<int>();
                    while (reader.Read())
                    {
                        idi.Add((int)reader.GetValue(0));
                    }
                    foreach (int i in idi)
                    {
                        int count = -1;
                        cmd = "SELECT COUNT(*) FROM (SELECT Title, Name, TotalMarks, RegistrationNo, ObtainedMarks FROM ((((GroupProject JOIN GroupEvaluation ON GroupProject.GroupId = GroupEvaluation.GroupId) JOIN GroupStudent ON GroupProject.GroupId = GroupStudent.GroupId) JOIN Project ON ProjectId = Project.Id) JOIN Evaluation ON EvaluationId = Evaluation.Id) JOIN Student ON StudentId = Student.Id WHERE Status = (SELECT Id FROM Lookup WHERE Category = 'STATUS' AND Value = 'Active') AND Convert(date, GroupStudent.AssignmentDate) <= convert(date, GroupEvaluation.EvaluationDate) AND ProjectId = " + i + "  UNION SELECT Title, Name, TotalMarks, RegistrationNo, ObtainedMarks FROM (SELECT Title, Evaluation.Name, TotalMarks, RegistrationNo, ObtainedMarks, GroupStudent.GroupId, StudentId, ProjectId, EvaluationId, Status, GroupStudent.AssignmentDate, EvaluationDate FROM ((((GroupProject JOIN GroupEvaluation ON GroupProject.GroupId = GroupEvaluation.GroupId) JOIN GroupStudent ON GroupProject.GroupId = GroupStudent.GroupId) JOIN Project ON ProjectId = Project.Id) JOIN Evaluation ON EvaluationId = Evaluation.Id) JOIN Student ON StudentId = Student.Id) as a WHERE Status = (SELECT Id FROM Lookup WHERE Category = 'STATUS' AND Value = 'InActive') AND Convert(date, AssignmentDate) <= convert(date, EvaluationDate) AND Convert(date, (SELECT AssignmentDate FROM GroupStudent WHERE StudentId = a.StudentId AND Status = (SELECT Id FROM Lookup WHERE Category = 'STATUS' AND Value = 'Active'))) >= convert(date, EvaluationDate) AND ProjectId = " + i + ") B";
                        reader = DatabaseConnection.getInstance().getData(cmd);
                        while (reader.Read())
                        {
                            count = (int)reader.GetValue(0);
                        }
                        if (count == 0)
                        {
                            cmd = "SELECT Title FROM Project WHERE Id = " + i;
                            reader = DatabaseConnection.getInstance().getData(cmd);
                            while (reader.Read())
                            {
                                cell = new PdfPCell(new Phrase(reader.GetString(0)));
                                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                                table.AddCell(cell);
                                cell = new PdfPCell(new Phrase("Not Assigned"));
                                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                                table.AddCell(cell);
                                cell = new PdfPCell(new Phrase("Not Assigned"));
                                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                                table.AddCell(cell);
                                cell = new PdfPCell(new Phrase("Not Assigned"));
                                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                                table.AddCell(cell);
                                cell = new PdfPCell(new Phrase("Not Assigned"));
                                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                                table.AddCell(cell);
                                cell = new PdfPCell(new Phrase("Not Assigned"));
                                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                                table.AddCell(cell);
                            }
                        }
                        else
                        {
                            cmd = "SELECT Title FROM Project WHERE Id = " + i;
                            reader = DatabaseConnection.getInstance().getData(cmd);
                            while (reader.Read())
                            {
                                cell = new PdfPCell(new Phrase(reader.GetString(0)));
                                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                                cell.Rowspan = count;
                                table.AddCell(cell);

                            }
                            cmd = "SELECT DISTINCT EvaluationId FROM (SELECT Title, Name, TotalMarks, RegistrationNo, ObtainedMarks, GroupStudent.AssignmentDate, EvaluationDate, GroupStudent.GroupId, EvaluationId FROM ((((GroupProject JOIN GroupEvaluation ON GroupProject.GroupId = GroupEvaluation.GroupId) JOIN GroupStudent ON GroupProject.GroupId = GroupStudent.GroupId) JOIN Project ON ProjectId = Project.Id) JOIN Evaluation ON EvaluationId = Evaluation.Id) JOIN Student ON StudentId = Student.Id WHERE Status = (SELECT Id FROM Lookup WHERE Category = 'STATUS' AND Value = 'Active') AND Convert(date, GroupStudent.AssignmentDate) <= convert(date, GroupEvaluation.EvaluationDate) AND ProjectId = " + i + "  UNION SELECT Title, Name, TotalMarks, RegistrationNo, ObtainedMarks, AssignmentDate, EvaluationDate, GroupId, EvaluationId FROM (SELECT Title, Evaluation.Name, TotalMarks, RegistrationNo, ObtainedMarks, GroupStudent.GroupId, StudentId, ProjectId, EvaluationId, Status, GroupStudent.AssignmentDate, EvaluationDate FROM ((((GroupProject JOIN GroupEvaluation ON GroupProject.GroupId = GroupEvaluation.GroupId) JOIN GroupStudent ON GroupProject.GroupId = GroupStudent.GroupId) JOIN Project ON ProjectId = Project.Id) JOIN Evaluation ON EvaluationId = Evaluation.Id) JOIN Student ON StudentId = Student.Id) as a WHERE Status = (SELECT Id FROM Lookup WHERE Category = 'STATUS' AND Value = 'InActive') AND Convert(date, AssignmentDate) <= convert(date, EvaluationDate) AND Convert(date, (SELECT AssignmentDate FROM GroupStudent WHERE StudentId = a.StudentId AND Status = (SELECT Id FROM Lookup WHERE Category = 'STATUS' AND Value = 'Active'))) >= convert(date, EvaluationDate) AND ProjectId = " + i + ") B";
                            reader = DatabaseConnection.getInstance().getData(cmd);
                            List<int> idi2 = new List<int>();
                            while (reader.Read())
                            {
                                idi2.Add((int)reader.GetValue(0));
                            }
                            foreach (int i2 in idi2)
                            {
                                int count2 = -1;
                                cmd = "SELECT COUNT(*) FROM (SELECT Title, Name, TotalMarks, RegistrationNo, ObtainedMarks, GroupStudent.AssignmentDate, EvaluationDate, GroupStudent.GroupId, EvaluationId FROM ((((GroupProject JOIN GroupEvaluation ON GroupProject.GroupId = GroupEvaluation.GroupId) JOIN GroupStudent ON GroupProject.GroupId = GroupStudent.GroupId) JOIN Project ON ProjectId = Project.Id) JOIN Evaluation ON EvaluationId = Evaluation.Id) JOIN Student ON StudentId = Student.Id WHERE Status = (SELECT Id FROM Lookup WHERE Category = 'STATUS' AND Value = 'Active') AND Convert(date, GroupStudent.AssignmentDate) <= convert(date, GroupEvaluation.EvaluationDate) AND ProjectId = " + i + " AND EvaluationId = " + i2 + "  UNION SELECT Title, Name, TotalMarks, RegistrationNo, ObtainedMarks, AssignmentDate, EvaluationDate, GroupId, EvaluationId FROM (SELECT Title, Evaluation.Name, TotalMarks, RegistrationNo, ObtainedMarks, GroupStudent.GroupId, StudentId, ProjectId, EvaluationId, Status, GroupStudent.AssignmentDate, EvaluationDate FROM ((((GroupProject JOIN GroupEvaluation ON GroupProject.GroupId = GroupEvaluation.GroupId) JOIN GroupStudent ON GroupProject.GroupId = GroupStudent.GroupId) JOIN Project ON ProjectId = Project.Id) JOIN Evaluation ON EvaluationId = Evaluation.Id) JOIN Student ON StudentId = Student.Id) as a WHERE Status = (SELECT Id FROM Lookup WHERE Category = 'STATUS' AND Value = 'InActive') AND Convert(date, AssignmentDate) <= convert(date, EvaluationDate) AND Convert(date, (SELECT AssignmentDate FROM GroupStudent WHERE StudentId = a.StudentId AND Status = (SELECT Id FROM Lookup WHERE Category = 'STATUS' AND Value = 'Active'))) >= convert(date, EvaluationDate) AND ProjectId = " + i + " AND EvaluationId = " + i2 + ") B";
                                reader = DatabaseConnection.getInstance().getData(cmd);
                                while (reader.Read())
                                {
                                    count2 = (int)reader.GetValue(0);
                                }
                                if (count2 != 0)
                                {
                                    cmd = "SELECT Name, TotalMarks, TotalWeightage FROM Evaluation WHERE Id = " + i2;
                                    reader = DatabaseConnection.getInstance().getData(cmd);
                                    while (reader.Read())
                                    {
                                        cell = new PdfPCell(new Phrase(reader.GetString(0)));
                                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                                        cell.Rowspan = count2;
                                        table.AddCell(cell);
                                        cell = new PdfPCell(new Phrase(reader.GetValue(1).ToString()));
                                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                                        cell.Rowspan = count2;
                                        table.AddCell(cell);
                                        cell = new PdfPCell(new Phrase(reader.GetValue(2).ToString()));
                                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                                        cell.Rowspan = count2;
                                        table.AddCell(cell);

                                    }
                                    cmd = "SELECT RegistrationNo, ObtainedMarks FROM ((((GroupProject JOIN GroupEvaluation ON GroupProject.GroupId = GroupEvaluation.GroupId) JOIN GroupStudent ON GroupProject.GroupId = GroupStudent.GroupId) JOIN Project ON ProjectId = Project.Id) JOIN Evaluation ON EvaluationId = Evaluation.Id) JOIN Student ON StudentId = Student.Id WHERE Status = (SELECT Id FROM Lookup WHERE Category = 'STATUS' AND Value = 'Active') AND Convert(date, GroupStudent.AssignmentDate) <= convert(date, GroupEvaluation.EvaluationDate) AND ProjectId = " + i + " AND EvaluationId = " + i2 + " UNION SELECT RegistrationNo, ObtainedMarks FROM (SELECT Title, Evaluation.Name, TotalMarks, RegistrationNo, ObtainedMarks, GroupStudent.GroupId, StudentId, ProjectId, EvaluationId, Status, GroupStudent.AssignmentDate, EvaluationDate FROM ((((GroupProject JOIN GroupEvaluation ON GroupProject.GroupId = GroupEvaluation.GroupId) JOIN GroupStudent ON GroupProject.GroupId = GroupStudent.GroupId) JOIN Project ON ProjectId = Project.Id) JOIN Evaluation ON EvaluationId = Evaluation.Id) JOIN Student ON StudentId = Student.Id) as a WHERE Status = (SELECT Id FROM Lookup WHERE Category = 'STATUS' AND Value = 'InActive') AND Convert(date, AssignmentDate) <= convert(date, EvaluationDate) AND Convert(date, (SELECT AssignmentDate FROM GroupStudent WHERE StudentId = a.StudentId AND Status = (SELECT Id FROM Lookup WHERE Category = 'STATUS' AND Value = 'Active'))) >= convert(date, EvaluationDate) AND ProjectId = " + i + " AND EvaluationId = " + i2;
                                    reader = DatabaseConnection.getInstance().getData(cmd);
                                    while (reader.Read())
                                    {
                                        cell = new PdfPCell(new Phrase(reader.GetString(0)));
                                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                                        table.AddCell(cell);
                                        cell = new PdfPCell(new Phrase(reader.GetValue(1).ToString()));
                                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                                        table.AddCell(cell);
                                    }
                                }
                            }
                        }
                    }
                    table.WidthPercentage = 100;
                    document.Add(table);
                    document.Close();
                    MessageBox.Show("File stored in project files in Reports folder.\nName: EvaluationReport.pdf");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
