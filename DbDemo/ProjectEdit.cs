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
    public partial class ProjectEdit : Form
    {
        private MainPage par;
        private ProjectClass stuold;
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
        public ProjectEdit(int id, MainPage parent)
        {
            par = parent;
            InitializeComponent();
            this.MinimumSize = new Size(this.Width, this.Height);
            TitleError.Text = "";
            DesError.Text = "";
            String cmd = "SELECT Id, Title, Description FROM Project where Id = " + id.ToString();
            var reader = DatabaseConnection.getInstance().getData(cmd);
            stuold = new ProjectClass();
            while (reader.Read())
            {
                stuold.Id = (int)reader.GetValue(0);
                stuold.Titlle = reader.GetString(1);
                stuold.Description = reader.GetString(2);
            }
            TitleTextBox.Text = stuold.Titlle;
            DesTextBox.Text = stuold.Description;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            int flag = 0;
            try
            {
                ProjectClass stu = new ProjectClass();
                stu.Titlle = null;
                stu.Description = null;
                if (Regexp("^[a-zA-Z]{1,100}", TitleTextBox, TitleError, "Only alphabets are allowed.", 100))
                {
                    stu.Titlle = TitleTextBox.Text;
                    flag++;
                }
                if ((string.IsNullOrEmpty(DesTextBox.Text)))
                {
                    flag++;
                }
                else
                {
                    stu.Description = DesTextBox.Text;
                    flag++;
                }
                if (flag == 2)
                {
                    String cmd = String.Format("Update Project SET Title = '{0}', Description = '{1}' WHERE Id = '{2}'", stu.Titlle, stu.Description, stuold.Id);
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

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DesError_Click(object sender, EventArgs e)
        {

        }

        private void TitleError_Click(object sender, EventArgs e)
        {

        }

        private void DesTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DescriptionLabel_Click(object sender, EventArgs e)
        {

        }

        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TitleLabel_Click(object sender, EventArgs e)
        {

        }

        private void CreateAdvisor_Click(object sender, EventArgs e)
        {

        }
    }
}
