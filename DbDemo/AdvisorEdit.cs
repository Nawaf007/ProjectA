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
    public partial class AdvisorEdit : Form
    {
        private MainPage par;
        private AdvisorClass stuold;
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
        public AdvisorEdit(int id, MainPage parent)
        {
            par = parent;
            InitializeComponent();
            this.MinimumSize = new Size(this.Width, this.Height);
            FNError.Text = "";
            LNError.Text = "";
            ConError.Text = "";
            EmailError.Text = "";
            SalaryError.Text = "";
            String cmd = "Select Value from Lookup Where Category = 'GENDER'";
            var reader = DatabaseConnection.getInstance().getData(cmd);
            while (reader.Read())
            {
                GenderComboBox.Items.Add(reader.GetString(0));
            }
            cmd = "Select Value from Lookup Where Id = (SELECT Gender FROM Person where Id = " + id.ToString() + ")";
            reader = DatabaseConnection.getInstance().getData(cmd);
            while (reader.Read())
            {
                GenderComboBox.SelectedIndex = GenderComboBox.Items.IndexOf(reader.GetString(0));
            }
            cmd = "Select Value from Lookup Where Category = 'DESIGNATION'";
            reader = DatabaseConnection.getInstance().getData(cmd);
            while (reader.Read())
            {
                DesComboBox.Items.Add(reader.GetString(0));
            }
            cmd = "Select Value from Lookup Where Id = (SELECT Gender FROM Person where Id = " + id.ToString() + ")";
            reader = DatabaseConnection.getInstance().getData(cmd);
            while (reader.Read())
            {
                DesComboBox.SelectedIndex = GenderComboBox.Items.IndexOf(reader.GetString(0));
            }
            cmd = "SELECT Person.Id, FirstName, LastName, Contact, Email, DateOfBirth, Gender, Designation, Salary FROM Person JOIN Advisor ON Person.Id = Advisor.Id where Person.Id = " + id.ToString();
            reader = DatabaseConnection.getInstance().getData(cmd);
            stuold = new AdvisorClass();
            while (reader.Read())
            {
                stuold.Id = (int)reader.GetValue(0);
                stuold.FirstName = reader.GetString(1);
                stuold.LastName = reader.GetString(2);
                stuold.Contact = reader.GetString(3);
                stuold.Email = reader.GetString(4);
                stuold.DateOfBirth = (DateTime)reader.GetValue(5);
                stuold.Gender = (int)reader.GetValue(6);
                stuold.Designation = (int)reader.GetValue(7);
                stuold.Salary = (decimal)reader.GetValue(8);
            }
            FirstNameTextBox.Text = stuold.FirstName;
            LastNameTextBox.Text = stuold.LastName;
            ContactTextBox.Text = stuold.Contact;
            EmailTextBox.Text = stuold.Email;
            SalaryTextBox.Text = stuold.Salary.ToString();
            DateOfBirthPick.Value = (DateTime)stuold.DateOfBirth;
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
                    if (stuold.Email != stu.Email)
                    {
                        String cmd1 = "Select Id from Person Where Email = '" + EmailTextBox.Text + "'";
                        var reader1 = DatabaseConnection.getInstance().getData(cmd1);
                        while (reader1.Read())
                        {
                            flag--;
                            EmailError.Text = "Already exists";
                            EmailError.ForeColor = System.Drawing.Color.Red;
                        }
                    }
                    flag++;
                }
                stu.DateOfBirth = DateOfBirthPick.Value;
                flag++;
                if ((string.IsNullOrEmpty(SalaryTextBox.Text)))
                {
                    flag++;
                }
                else if (Regexp("^[0-9]{1,18}", SalaryTextBox, SalaryError, "Only valid numbers are allowed.", 18))
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
                    cmd = "Select Id from Person Where Email = '" + stuold.Email + "'";
                    reader = DatabaseConnection.getInstance().getData(cmd);
                    int? id = null;
                    while (reader.Read())
                    {
                        id = (int)reader.GetValue(0);
                    }
                    if (id != null)
                    {
                        cmd = String.Format("Update Person SET FirstName = '{0}', LastName = '{1}', Contact = '{2}', Email = '{3}', DateOfBirth = '{4}', Gender = '{5}' WHERE Id = '{6}'", stu.FirstName, stu.LastName, stu.Contact, stu.Email, stu.DateOfBirth, stu.Gender, id);
                        DatabaseConnection.getInstance().exectuteQuery(cmd);
                        cmd = String.Format("UPDATE Advisor SET Id = '{0}', Designation = '{1}', Salary = '{2}' WHERE Id = '{3}'", id, stu.Designation, stu.Salary, id);
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
