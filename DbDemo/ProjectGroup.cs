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
    public partial class ProjectGroup : Form
    {
        public ProjectGroup()
        {
            InitializeComponent();
            this.MinimumSize = new Size(this.Width, this.Height);
            try
            {
                String cmd = "Select Id, Created_On, AssignmentDate from Group JOIN GroupProject";
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AdvisorCreate_Click(object sender, EventArgs e)
        {

        }
    }
}
