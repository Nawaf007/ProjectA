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
    public partial class Evaluation : Form
    {
        public void Refresh()
        {
            try
            {
                String cmd = "Select Id, Name, TotalMarks, TotalWeightage from Evaluation";
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public Evaluation()
        {
            InitializeComponent();
            this.MinimumSize = new Size(this.Width, this.Height);
            try
            {
                String cmd = "Select Id, Name, TotalMarks, TotalWeightage from Evaluation";
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
                StudentDataGrid.Columns[0].Visible = false;
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

        private void EvaluationCreate_Click(object sender, EventArgs e)
        {
            /*EvaluationCreate Ev = new EvaluationCreate(this);
            Ev.Show();*/
        }

        private void StudentDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id;
            if (e.ColumnIndex == 1)
            {
                id = (int)StudentDataGrid.Rows[e.RowIndex].Cells[2].Value;
                int truedel = Convert.ToInt32(Microsoft.VisualBasic.Interaction.MsgBox("Are you sure?", MsgBoxStyle.YesNo, "Delete"));
                if (truedel == 6)
                {
                    try
                    {
                        String cmd = String.Format("DELETE FROM Evaluation WHERE Id = '{0}'", id);
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
                /*EvaluationEdit se = new EvaluationEdit(id, this);
                se.Show();*/
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
    }
}
