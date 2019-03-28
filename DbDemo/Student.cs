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
    public partial class Student : Form
    {
        public void Refresh()
        {
            try
            {
                String cmd = "Select Person.Id, FirstName, LastName, Contact, Email, DateOfBirth, Gender, Value, RegistrationNo from (Person JOIN Student ON Person.Id = Student.Id) JOIN Lookup ON Person.Gender = Lookup.Id ";
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public Student()
        {
            InitializeComponent();
            this.MinimumSize = new Size(this.Width, this.Height);
            try
            {
                String cmd = "Select Person.Id, FirstName, LastName, Contact, Email, DateOfBirth, Gender, Value, RegistrationNo from (Person JOIN Student ON Person.Id = Student.Id) JOIN Lookup ON Person.Gender = Lookup.Id ";
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
                StudentDataGrid.Columns[0].Visible = false;
                StudentDataGrid.Columns[6].Visible = false;
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
                cmd = "Select FirstName, LastName, Contact, Email, Value AS Genders, RegistrationNo from (Person JOIN Student ON Person.Id = Student.Id) JOIN Lookup ON Lookup.Id = Person.Gender";
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

        private void Student_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id;
            if(e.ColumnIndex == 1)
            {
                id = (int)StudentDataGrid.Rows[e.RowIndex].Cells[2].Value;
                int truedel = Convert.ToInt32(Microsoft.VisualBasic.Interaction.MsgBox("Are you sure?", MsgBoxStyle.YesNo, "Delete"));
                if (truedel == 6)
                {
                    try
                    {
                        String cmd = String.Format("DELETE FROM Student WHERE Id = '{0}'", id);
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
                id = (int)StudentDataGrid.Rows[e.RowIndex].Cells[2].Value;
                //StudentEdit se = new StudentEdit(id, this);
                //se.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //StudentCreate Sc = new StudentCreate(this);
            //Sc.Show();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            
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
                String cmd = "Select Person.Id, FirstName, LastName, Contact, Email, DateOfBirth, Gender, Genders, RegistrationNo from (Person JOIN Student ON Person.Id = Student.Id) JOIN (SELECT Id, Value As Genders FROM Lookup) a ON Person.Gender = a.Id Where " + SearchCategory.Text + " = '" + SearchTextBox.Text + "'";
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
    }
}
