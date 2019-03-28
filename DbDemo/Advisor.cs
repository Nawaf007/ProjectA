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
    public partial class Advisor : Form
    {
        public void Refresh()
        {
            try
            {
                String cmd = "Select Person.Id, FirstName, LastName, Contact, Email, DateOfBirth, Gender, Value, Designation ,a.Designations, Salary from ((Person JOIN Advisor ON Person.Id = Advisor.Id) JOIN Lookup ON Person.Gender = Lookup.Id) JOIN (SELECT Id, Value As Designations, Category FROM Lookup) a ON Advisor.Designation = a.Id ";
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
                AdvisorDataGrid.DataSource = students;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public Advisor()
        {
            InitializeComponent();
            this.MinimumSize = new Size(this.Width, this.Height);
            try
            {
                String cmd = "Select Person.Id, FirstName, LastName, Contact, Email, DateOfBirth, Gender, Value AS Genders, Designation ,a.Designations, Salary from ((Person JOIN Advisor ON Person.Id = Advisor.Id) JOIN Lookup ON Person.Gender = Lookup.Id) JOIN (SELECT Id, Value As Designations, Category FROM Lookup) a ON Advisor.Designation = a.Id ";
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
                AdvisorDataGrid.DataSource = students;
                AdvisorDataGrid.Columns[0].Visible = false;
                AdvisorDataGrid.Columns[6].Visible = false;
                AdvisorDataGrid.Columns[7].Visible = false;
                DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();
                bcol.HeaderText = "";
                bcol.Text = "Edit";
                bcol.Name = "btnEdit";
                bcol.UseColumnTextForButtonValue = true;
                AdvisorDataGrid.Columns.Add(bcol);
                DataGridViewButtonColumn bcol1 = new DataGridViewButtonColumn();
                bcol1.HeaderText = "";
                bcol1.Text = "Delete";
                bcol1.Name = "btnDelete";
                bcol1.UseColumnTextForButtonValue = true;
                AdvisorDataGrid.Columns.Add(bcol1);
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

        private void AdvisorCreate_Click(object sender, EventArgs e)
        {
            //AdvisorCreate Sc = new AdvisorCreate(this);
            //Sc.Show();
        }

        private void AdvisorDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id;
            if (e.ColumnIndex == 1)
            {
                id = (int)AdvisorDataGrid.Rows[e.RowIndex].Cells[2].Value;
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
            }
            if (e.ColumnIndex == 0)
            {
                id = (int)AdvisorDataGrid.Rows[e.RowIndex].Cells[2].Value;
                //AdvisorEdit se = new AdvisorEdit(id, this);
                //se.Show();
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
                AdvisorDataGrid.DataSource = students;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
