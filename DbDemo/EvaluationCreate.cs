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
    public partial class EvaluationCreate : Form
    {
        private MainPage par;
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
        public EvaluationCreate(MainPage parent)
        {
            par = parent;
            InitializeComponent();
            this.MinimumSize = new Size(this.Width, this.Height);
            NError.Text = "";
            TMError.Text = "";
            TWError.Text = "";
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            int flag = 0;
            try
            {
                EvaluationClass stu = new EvaluationClass();
                if ((string.IsNullOrEmpty(NameTextBox.Text)))
                {
                    flag++;
                }
                else if (Regexp("^[a-zA-Z0-9]{1,100}", NameTextBox, NError, "Only alphabets are allowed.", 100))
                {
                    stu.Name = NameTextBox.Text;
                    flag++;
                }
                if ((string.IsNullOrEmpty(TMTextBox.Text)))
                {
                    flag++;
                }
                else if (Regexp("^[0-9]{1,3}", TMTextBox, TMError, "Only valid numbers are allowed.", 3))
                {
                    stu.TotalMarks = Convert.ToInt32(TMTextBox.Text);
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
                    string cmd = String.Format("INSERT INTO Evaluation(Name, TotalMarks, TotalWeightage) values('{0}','{1}','{2}')", stu.Name, stu.TotalMarks, stu.TotalWeightage);
                    DatabaseConnection.getInstance().exectuteQuery(cmd);
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
