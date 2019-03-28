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
    public partial class AdvisorCreate : Form
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
        public AdvisorCreate(MainPage parent)
        {
            par = parent;
            InitializeComponent();
            this.MinimumSize = new Size(this.Width, this.Height);
            FNError.Text = "";
            LNError.Text = "";
            ConError.Text = "";
            EmailError.Text = "";
            SalaryError.Text = "";
            DateOfBirthPick.Text = null;
            String cmd = "Select Value from Lookup Where Category = 'GENDER'";
            var reader = DatabaseConnection.getInstance().getData(cmd);
            while (reader.Read())
            {
                GenderComboBox.Items.Add(reader.GetString(0));
            }
            GenderComboBox.SelectedIndex = 0;
            cmd = "Select Value from Lookup Where Category = 'DESIGNATION'";
            reader = DatabaseConnection.getInstance().getData(cmd);
            while (reader.Read())
            {
                DesComboBox.Items.Add(reader.GetString(0));
            }
            DesComboBox.SelectedIndex = 0;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            int flag = 0;
            try
            {
                AdvisorClass stu = new AdvisorClass();
                stu.Gender = null;
                stu.LastName = null;
                stu.Contact = null;
                stu.DateOfBirth = null;
                stu.Salary = null;
                if (Regexp("^[a-zA-Z]{1,100}", FirstNameTextBox, FNError, "Only alphabets are allowed.", 100))
                {
                    stu.FirstName = FirstNameTextBox.Text;
                    flag++;
                }
                if ((string.IsNullOrEmpty(LastNameTextBox.Text)))
                {
                    flag++;
                }
                else if (Regexp("^[a-zA-Z]{1,100}", LastNameTextBox, LNError, "Only alphabets are allowed.", 100))
                {
                    stu.LastName = LastNameTextBox.Text;
                    flag++;
                }
                if ((string.IsNullOrEmpty(ContactTextBox.Text)))
                {
                    flag++;
                }
                else if (Regexp("^[0-9]{1,20}", ContactTextBox, ConError, "Only valid numbers are allowed.", 20))
                {
                    stu.Contact = ContactTextBox.Text;
                    flag++;
                }
                if (Regexp("^([\\w\\.\\-]+)@([\\w\\-]+)((\\.(\\w){2,3})+)$", EmailTextBox, EmailError, "Format not correct eg. abc@xyz.efg", 30))
                {
                    stu.Email = EmailTextBox.Text;
                    String cmd1 = "Select Id from Person Where Email = '" + EmailTextBox.Text + "'";
                    var reader1 = DatabaseConnection.getInstance().getData(cmd1);
                    while (reader1.Read())
                    {
                        flag--;
                        EmailError.Text = "Already exists";
                        EmailError.ForeColor = System.Drawing.Color.Red;
                    }
                    flag++;
                }
                stu.DateOfBirth = DateOfBirthPick.Value;
                flag++;
                if ((string.IsNullOrEmpty(SalaryTextBox.Text)))
                {
                    flag++;
                }
                else if (Regexp("[0-9]{1,18}", SalaryTextBox, SalaryError, "Only valid numbers are allowed.", 18))
                {
                    stu.Salary = Convert.ToDecimal(SalaryTextBox.Text);
                    flag++;
                }
                String cmd = "Select Id from Lookup Where Category = 'GENDER' AND Value = '" + GenderComboBox.Text + "'";
                var reader = DatabaseConnection.getInstance().getData(cmd);
                while (reader.Read())
                {
                    stu.Gender = (int)reader.GetValue(0);
                }
                flag++;
                cmd = "Select Id from Lookup Where Category = 'DESIGNATION' AND Value = '" + DesComboBox.Text + "'";
                reader = DatabaseConnection.getInstance().getData(cmd);
                while (reader.Read())
                {
                    stu.Designation = (int)reader.GetValue(0);
                }
                flag++;
                if (flag == 8)
                {
                    cmd = String.Format("INSERT INTO Person(FirstName, LastName, Contact, Email, DateOfBirth, Gender) values('{0}','{1}','{2}','{3}','{4}','{5}')", stu.FirstName, stu.LastName, stu.Contact, stu.Email, stu.DateOfBirth, stu.Gender);
                    DatabaseConnection.getInstance().exectuteQuery(cmd);
                    cmd = "Select Id from Person Where Email = '" + stu.Email + "'";
                    reader = DatabaseConnection.getInstance().getData(cmd);
                    int? id = null;
                    while (reader.Read())
                    {
                        id = (int)reader.GetValue(0);
                    }
                    if (id != null)
                    {
                        cmd = String.Format("Insert INTO Advisor(Id, Designation, Salary) values('{0}', '{1}', '{2}')", id, stu.Designation, stu.Salary);
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

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
