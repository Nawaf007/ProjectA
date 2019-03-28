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
    public partial class Project : Form
    {
        public void Refresh()
        {
            try
            {
                String cmd = "Select Id, Title, Description from Project";
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
                ProjectDataGrid.DataSource = students;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public Project()
        {
            InitializeComponent();
            this.MinimumSize = new Size(this.Width, this.Height);
            try
            {
                String cmd = "Select Id, Title, Description from Project";
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
                ProjectDataGrid.DataSource = students;
                ProjectDataGrid.Columns[0].Visible = false;
                ProjectDataGrid.Columns[2].Visible = false;
                DataGridViewButtonColumn bcol3 = new DataGridViewButtonColumn();
                bcol3.HeaderText = "";
                bcol3.Text = "Details";
                bcol3.Name = "btnDetails";
                bcol3.UseColumnTextForButtonValue = true;
                ProjectDataGrid.Columns.Add(bcol3);
                DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();
                bcol.HeaderText = "";
                bcol.Text = "Edit";
                bcol.Name = "btnEdit";
                bcol.UseColumnTextForButtonValue = true;
                ProjectDataGrid.Columns.Add(bcol);
                DataGridViewButtonColumn bcol1 = new DataGridViewButtonColumn();
                bcol1.HeaderText = "";
                bcol1.Text = "Delete";
                bcol1.Name = "btnDelete";
                bcol1.UseColumnTextForButtonValue = true;
                ProjectDataGrid.Columns.Add(bcol1);
                DataGridViewButtonColumn bcol2 = new DataGridViewButtonColumn();
                bcol2.HeaderText = "";
                bcol2.Text = "Group";
                bcol2.Name = "btnGroup";
                bcol2.UseColumnTextForButtonValue = true;
                ProjectDataGrid.Columns.Add(bcol2);
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

        private void ProjectCreate_Click(object sender, EventArgs e)
        {
            //ProjectCreate Sc = new ProjectCreate(this);
            //Sc.Show();
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
                ProjectDataGrid.DataSource = students;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ProjectDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id;
            if (e.ColumnIndex == 2)
            {
                id = (int)ProjectDataGrid.Rows[e.RowIndex].Cells[4].Value;
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
            }
            if (e.ColumnIndex == 1)
            {
                id = (int)ProjectDataGrid.Rows[e.RowIndex].Cells[4].Value;
                //ProjectEdit se = new ProjectEdit(id, this);
                //se.Show();
            }
            if (e.ColumnIndex == 0)
            {
                id = (int)ProjectDataGrid.Rows[e.RowIndex].Cells[4].Value;
                ProjectDetails se = new ProjectDetails(id);
                se.Show();
            }
            if (e.ColumnIndex == 3)
            {
                MessageBox.Show("Groups entity is still in development phase.");
            }
        }

        private void SearchCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProjectLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
