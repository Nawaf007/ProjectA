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
    public partial class EvaluationEdit : Form
    {
        private MainPage par;
        private EvaluationClass stuold;
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
        public EvaluationEdit(int id, MainPage parent)
        {
            par = parent;
            InitializeComponent();
            this.MinimumSize = new Size(this.Width, this.Height);
            NError.Text = "";
            TMError.Text = "";
            TWError.Text = "";
            string cmd = "Select Id, Name, TotalMarks, TotalWeightage from Evaluation where Id = " + id.ToString();
            var reader = DatabaseConnection.getInstance().getData(cmd);
            stuold = new EvaluationClass();
            while (reader.Read())
            {
                stuold.Id = (int)reader.GetValue(0);
                stuold.Name = reader.GetString(1);
                stuold.TotalMarks = (int)reader.GetValue(2);
                stuold.TotalWeightage = (int)reader.GetValue(3);
            }
            NameTextBox.Text = stuold.Name;
            TMTextBox.Text = stuold.TotalMarks.ToString();
            TWTextBox.Text = stuold.TotalWeightage.ToString();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            int flag = 0;
            try
            {
                EvaluationClass stu = new EvaluationClass();
                if ((string.IsNullOrEmpty(NameTextBox.Text)))
                {
                    flag++;
                }
                else if (Regexp("^[a-zA-Z]{1,100}", NameTextBox, NError, "Only alphabets are allowed.", 100))
                {
                    stu.Name = NameTextBox.Text;
                    flag++;
                }
                if ((string.IsNullOrEmpty(TMTextBox.Text)))
                {
                    flag++;
                    string cmd = "SELECT COUNT(*) FROM Evaluation JOIN GroupEvaluation ON Id = EvaluationId WHERE ObtainedMarks > " + TMTextBox.Text;
                    var reader = DatabaseConnection.getInstance().getData(cmd);
                    while(reader.Read())
                    {
                        if((int)reader.GetValue(0) > 0)
                        {
                            flag--;
                            TMError.ForeColor = System.Drawing.Color.Red;
                            TMError.Text = "Some data have obtained marks so it can't be null.";
                        }
                    }
                }
                else if (Regexp("^[0-9]{1,3}", TMTextBox, TMError, "Only valid numbers are allowed.", 3))
                {
                    stu.TotalMarks = Convert.ToInt32(TMTextBox.Text);
                    string cmd = "SELECT COUNT(*) FROM Evaluation JOIN GroupEvaluation ON Id = EvaluationId WHERE ObtainedMarks > " + TMTextBox.Text;
                    var reader = DatabaseConnection.getInstance().getData(cmd);
                    while (reader.Read())
                    {
                        if ((int)reader.GetValue(0) > 0)
                        {
                            flag--;
                            TMError.ForeColor = System.Drawing.Color.Red;
                            TMError.Text = "Some data have obtained marks greater then current value.";
                        }
                    }
                    flag++;
                }
                if ((string.IsNullOrEmpty(TWTextBox.Text)))
                {
                    flag++;
                }
                else if (Regexp("^[0-9]{1,3}", TWTextBox, TWError, "Only valid numbers are allowed.", 3))
                {
                    if (Convert.ToInt32(TWTextBox.Text) > 100)
                    {
                        Regexp("^[?]{1,3}", TWTextBox, TWError, "Weightage cannot exceed 100%", 3);
                        flag--;
                    }
                    stu.TotalWeightage = Convert.ToInt32(TWTextBox.Text);
                    flag++;
                }
                if (flag == 3)
                {
                    if (stuold.Id != null)
                    {
                        string cmd = String.Format("Update Evaluation SET Name = '{0}', TotalMarks = '{1}', TotalWeightage = '{2}' WHERE Id = '{3}'", stu.Name, stu.TotalMarks, stu.TotalWeightage, stuold.Id);
                        DatabaseConnection.getInstance().exectuteQuery(cmd);
                    }
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
}
