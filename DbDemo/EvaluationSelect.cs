using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace DbDemo
{
    public partial class EvaluationSelect : Form
    {
        private int id;
        private GroupDetails par;
        public bool Regexp(string re, TextBox tb, Label lbl, string s, int maxsize)
        {
            Regex regex = new Regex(re);

            if (tb.Text.Length > maxsize)
            {
                lbl.Text = "Max character size allowed is " + maxsize;
                lbl.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            else if (regex.IsMatch(tb.Text))
            {
                lbl.Text = "";
                return true;
            }
            else
            {
                lbl.Text = s;
                lbl.ForeColor = System.Drawing.Color.Red;
                return false;
            }
        }
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
                String cmd = "Select Id, Name, TotalMarks, TotalWeightage from Evaluation WHERE Id NOT IN (Select Id from Evaluation JOIN GroupEvaluation ON Id = EvaluationId WHERE GroupId = " + id.ToString() + ")";
                var reader = DatabaseConnection.getInstance().getData(cmd);

                List<EvaluationClass> project = new List<EvaluationClass>();
                while (reader.Read())
                {
                    EvaluationClass stu = new EvaluationClass();
                    stu.Id = (int)reader.GetValue(0);
                    stu.Name = reader.GetString(1);
                    stu.TotalMarks = (int)reader.GetValue(2);
                    stu.TotalWeightage = (int)reader.GetValue(3);
                    project.Add(stu);
                }
                ProjectDataGrid.DataSource = project;
                ProjectDataGrid.Columns["EvaluationDate"].Visible = false;
                ProjectDataGrid.Columns["ObtainedMarks"].Visible = false;
                for (int j = 0; j < ProjectDataGrid.RowCount; j++)
                {
                    ProjectDataGrid.Rows[j].Cells[ProjectDataGrid.Columns["Select"].Index].Value = false;
                }
                ProjectDataGrid.Columns["Id"].Visible = false;
                ProjectDataGrid.Columns["TotalWeightage"].Visible = false;
                cmd = "Select Name, TotalMarks from Evaluation";
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
        public EvaluationSelect(int GroupId, GroupDetails parent)
        {
            InitializeComponent();
            EDDatePicker.MaxDate = DateTime.Now;
            EDDatePicker.Value = EDDatePicker.MaxDate;
            this.MinimumSize = new Size(this.Width, this.Height);
            id = GroupId;
            par = parent;
            OMError.Text = "";
            Refresh();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            int flag = 0;
            int obtainmark = 0;
            List<int> idi = new List<int>();
            String ids = "-1";
            for (int j = 0; j < ProjectDataGrid.RowCount; j++)
            {
                if (ProjectDataGrid.Rows[j].Cells[ProjectDataGrid.Columns["Select"].Index].Value == null)
                {
                    ProjectDataGrid.Rows[j].Cells[ProjectDataGrid.Columns["Select"].Index].Value = false;
                }
            }
            for (int i = 0; i < ProjectDataGrid.RowCount; i++)
            {
                if ((bool)ProjectDataGrid.Rows[i].Cells[ProjectDataGrid.Columns["Select"].Index].Value)
                {
                    idi.Add((int)ProjectDataGrid.Rows[i].Cells[ProjectDataGrid.Columns["Id"].Index].Value);
                    ids = ids + ", " + ProjectDataGrid.Rows[i].Cells[ProjectDataGrid.Columns["Id"].Index].Value.ToString();
                }
            }
            if ((string.IsNullOrEmpty(OMTextBox.Text)))
            {
                flag++;
                obtainmark = 0;
            }
            else if (Regexp("^[0-9]{1,3}", OMTextBox, OMError, "Only valid numbers are allowed.", 3))
            {
                obtainmark = Convert.ToInt32(OMTextBox.Text);
                string cmd = "SELECT COUNT(*) FROM Evaluation WHERE Id IN (" + ids + ") AND TotalMarks < " + OMTextBox.Text;
                var reader = DatabaseConnection.getInstance().getData(cmd);
                while (reader.Read())
                {
                    if ((int)reader.GetValue(0) > 0)
                    {
                        flag--;
                        OMError.ForeColor = System.Drawing.Color.Red;
                        OMError.Text = "Total marks is less than current obtained marks.";
                    }
                }
                flag++;
            }
            if(flag == 1)
            {
                try
                {
                    int sum = 0;
                    string cmd = "SELECT SUM(TotalWeightage) FROM Evaluation JOIN GroupEvaluation ON EvaluationId = Id WHERE GroupId = " + id;
                    var reader = DatabaseConnection.getInstance().getData(cmd);
                    while (reader.Read())
                    {
                        if(reader.GetValue(0) == null)
                        {
                            sum = (int)reader.GetValue(0) + sum;
                        }
                    }
                    foreach(int idk in idi)
                    {
                        cmd = "SELECT TotalWeightage FROM Evaluation WHERE Id = " + idk;
                        reader = DatabaseConnection.getInstance().getData(cmd);
                        while (reader.Read())
                        {
                            sum = (int)reader.GetValue(0) + sum;
                            if (sum > 100)
                            {
                                MessageBox.Show("Total Weightage of evaluation/s exceeds 100%.\nCurrent evaluation not added.");
                                flag = 0;
                                break;
                            }
                        }
                    }
                    if(flag != 0)
                    {
                        foreach (int idk in idi)
                        {
                            DateTime s = EDDatePicker.Value;
                            cmd = String.Format("INSERT INTO GroupEvaluation(EvaluationId, GroupId, ObtainedMarks, EvaluationDate) VALUES({0}, {1}, {2}, '{3}')", idk, id, obtainmark, s.Month + "/" + s.Day + "/" + s.Year);
                            DatabaseConnection.getInstance().exectuteQuery(cmd);
                        }
                    }
                    if (idi.Count == 0)
                    {
                        MessageBox.Show("Nothing was selected.");
                    }
                    else if (flag != 0)
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

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (SearchTextBox.Text == "")
                {
                    Refresh();
                    return;
                }
                String cmd = "Select Id, Name, TotalMarks, TotalWeightage from Evaluation WHERE " + SearchCategory.Text + " = '" + SearchTextBox.Text + "'";
                var reader = DatabaseConnection.getInstance().getData(cmd);
                List<EvaluationClass> evaluation = new List<EvaluationClass>();
                while (reader.Read())
                {
                    EvaluationClass stu = new EvaluationClass();
                    stu.Id = (int)reader.GetValue(0);
                    stu.Name = reader.GetString(1);
                    stu.TotalMarks = (int)reader.GetValue(2);
                    stu.TotalWeightage = (int)reader.GetValue(3);
                    evaluation.Add(stu);
                }
                ProjectDataGrid.DataSource = evaluation;
                for (int j = 0; j < ProjectDataGrid.RowCount; j++)
                {
                    ProjectDataGrid.Rows[j].Cells[ProjectDataGrid.Columns["Select"].Index].Value = false;
                }
                ProjectDataGrid.Columns["Id"].Visible = false;
                ProjectDataGrid.Columns["TotalWeightage"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
