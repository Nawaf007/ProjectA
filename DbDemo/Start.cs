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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
            this.MinimumSize = new Size(this.Width, this.Height);
            DatabaseConnection.getInstance().ConnectionString = "Data Source=HAIER-PC\\NAWAF;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=2922";
            try
            {
                var con = DatabaseConnection.getInstance().getConnection();
                con.Open();
            }
            catch (Exception ex)
            {

            }
        }

        private void StuButton_Click(object sender, EventArgs e)
        {
            Student stu = new Student();
            stu.Show();
        }

        private void AdButton_Click(object sender, EventArgs e)
        {
            Advisor ad = new Advisor();
            ad.Show();
        }

        private void ProjButton_Click(object sender, EventArgs e)
        {
            Project proj = new Project();
            proj.Show();
        }

        private void EvButton_Click(object sender, EventArgs e)
        {
            Evaluation Ev = new Evaluation();
            Ev.Show();
        }
    }
}
