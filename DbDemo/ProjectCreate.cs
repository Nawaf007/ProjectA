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
    public partial class ProjectCreate : Form
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
        public ProjectCreate(MainPage parent)
        {
            par = parent;
            InitializeComponent();
            this.MinimumSize = new Size(this.Width, this.Height);
            TitleError.Text = "";
            DesError.Text = "";
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
                    String cmd = String.Format("INSERT INTO Project(Title, Description) values('{0}','{1}')", stu.Titlle, stu.Description);
                    DatabaseConnection.getInstance().exectuteQuery(cmd);
                }
                par.Refresh();
                this.Close();
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
    }
}
