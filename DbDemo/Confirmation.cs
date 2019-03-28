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
    public partial class Confirmation : Form
    {
        private MainPage Parent;
        private List<int> SId = new List<int>();
        private int Id;
        int flag;
        public Confirmation(List<int> idi, String ids, MainPage par)
        {

            this.MinimumSize = new Size(this.Width, this.Height);
            try
            {
                flag = 0;
                Parent = par;
                InitializeComponent();
                InfoLabel.Text = "Select student in whose group other students will get added.";
                String cmd = "Select RegistrationNo from Student JOIN GroupStudent ON Id = StudentId WHERE Id IN (" + ids + ") AND Status = (SELECT Id FROM Lookup WHERE Category = 'STATUS' AND Value = 'Active')";
                var reader = DatabaseConnection.getInstance().getData(cmd);
                while (reader.Read())
                {
                    RegCombBox.Items.Add(reader.GetString(0));
                }
                foreach (int x in idi)
                {
                    SId.Add(x);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public Confirmation(int ProjectId)
        {
            this.MinimumSize = new Size(this.Width, this.Height);
            try
            {
                flag = 1;
                int i = 0;
                int prev = 0;
                InitializeComponent();
                Id = ProjectId;
                InfoLabel.Text = "Select student in whose group you want to view.";
                string cmd = "SELECT GroupProject.GroupId, RegistrationNo FROM (Student JOIN GroupStudent ON Student.Id = StudentId) JOIN GroupProject ON GroupStudent.GroupId = GroupProject.GroupId WHERE ProjectId = " + ProjectId.ToString() + " AND Status = (SELECT Id FROM Lookup WHERE Category = 'STATUS' AND Value = 'Active') ORDER BY GroupProject.GroupId";
                var reader = DatabaseConnection.getInstance().getData(cmd);
                while (reader.Read())
                {
                    if ((int)reader.GetValue(0) != prev)
                    {
                        prev = (int)reader.GetValue(0);
                        i++;
                    }
                    RegCombBox.Items.Add("Group " + i + ": " + reader.GetString(1));
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (RegCombBox.Text == "\0")
                {
                    MessageBox.Show("Box cannot be empty.");
                    return;
                }
                if (flag == 0)
                {
                    String ids = "-1";
                    int GId = 0;
                    foreach (int x in SId)
                    {
                        ids = ids + ", " + x.ToString();
                    }
                    String cmd = "SELECT GroupId, StudentId FROM GroupStudent WHERE GroupId = (Select GroupId FROM GroupStudent JOIN Student ON StudentId = Id WHERE RegistrationNo = '" + RegCombBox.SelectedItem.ToString() + "' AND Status = (SELECT Id FROM Lookup WHERE Category = 'STATUS' AND Value = 'Active')) AND StudentID IN (" + ids + ")";
                    var reader = DatabaseConnection.getInstance().getData(cmd);
                    while (reader.Read())
                    {
                        SId.Remove((int)reader.GetValue(1));
                        GId = (int)reader.GetValue(0);
                    }
                    ids = "-1";
                    foreach (int x in SId)
                    {
                        ids = ids + ", " + x.ToString();
                    }
                    cmd = "UPDATE GroupStudent SET Status = (SELECT Id FROM Lookup WHERE Category = 'STATUS' AND Value = 'InActive') WHERE StudentId IN (Select Id from Student JOIN GroupStudent ON Id = StudentId WHERE Id IN (" + ids + "))";
                    DatabaseConnection.getInstance().exectuteQuery(cmd);
                    foreach (int x in SId)
                    {
                        cmd = String.Format("Insert INTO GroupStudent(GroupId, StudentId, Status, AssignmentDate) values('{0}', '{1}', (SELECT Id FROM Lookup WHERE Category = 'STATUS' AND Value = 'Active'), GETDATE())", GId, x);
                        DatabaseConnection.getInstance().exectuteQuery(cmd);
                    }
                    Parent.Refresh();
                    MessageBox.Show("Students added.");
                    this.Close();
                }
                else if (flag == 1)
                {
                    int flag2 = 0;
                    String data = "";
                    foreach(char x in RegCombBox.SelectedItem.ToString())
                    {
                        if(flag2 <= 1 && x == ' ')
                        {
                            flag2++;
                        }
                        else if (x == '\0')
                        {
                            break;
                        }
                        else if(flag2 == 2)
                        {
                            data = data + x;
                        }
                    }
                    string cmd = "SELECT GroupProject.GroupId FROM (Student JOIN GroupStudent ON Student.Id = StudentId) JOIN GroupProject ON GroupStudent.GroupId = GroupProject.GroupId WHERE ProjectId = " + Id.ToString() + " AND RegistrationNo = '" + data + "' AND Status = (SELECT Id FROM Lookup WHERE Category = 'STATUS' AND Value = 'Active')";
                    var reader = DatabaseConnection.getInstance().getData(cmd);
                    while (reader.Read())
                    {
                        GroupDetails gd = new GroupDetails((int)reader.GetValue(0));
                        this.Close();
                        gd.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
