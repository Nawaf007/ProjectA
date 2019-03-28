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
    public partial class ProjectDetails : Form
    {
        public ProjectDetails(int id)
        {
            InitializeComponent();
            this.MinimumSize = new Size(this.Width, this.Height);
            String cmd = "SELECT Id, Title, Description FROM Project where Id = " + id.ToString();
            var reader = DatabaseConnection.getInstance().getData(cmd);
            ProjectClass stuold = new ProjectClass();
            while (reader.Read())
            {
                stuold.Id = (int)reader.GetValue(0);
                stuold.Titlle = reader.GetString(1);
                stuold.Description = reader.GetString(2);
            }
            TitleLabel1.Text = stuold.Titlle;
            DescLabel.Text = stuold.Description;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
