namespace DbDemo
{
    partial class ProjectDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Close = new System.Windows.Forms.Button();
            this.DesTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.DetailsProject = new System.Windows.Forms.Label();
            this.TitleLabel1 = new System.Windows.Forms.Label();
            this.DescLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Close
            // 
            this.Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Close.Location = new System.Drawing.Point(122, 242);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 23);
            this.Close.TabIndex = 73;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // DesTextBox
            // 
            this.DesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DesTextBox.Location = new System.Drawing.Point(110, 111);
            this.DesTextBox.Multiline = true;
            this.DesTextBox.Name = "DesTextBox";
            this.DesTextBox.ReadOnly = true;
            this.DesTextBox.Size = new System.Drawing.Size(193, 107);
            this.DesTextBox.TabIndex = 70;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.DescriptionLabel.Location = new System.Drawing.Point(13, 111);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(72, 15);
            this.DescriptionLabel.TabIndex = 69;
            this.DescriptionLabel.Text = "Description:";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleTextBox.Location = new System.Drawing.Point(110, 70);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.ReadOnly = true;
            this.TitleTextBox.Size = new System.Drawing.Size(193, 20);
            this.TitleTextBox.TabIndex = 68;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.TitleLabel.Location = new System.Drawing.Point(13, 70);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(33, 15);
            this.TitleLabel.TabIndex = 67;
            this.TitleLabel.Text = "Title:";
            // 
            // DetailsProject
            // 
            this.DetailsProject.Dock = System.Windows.Forms.DockStyle.Top;
            this.DetailsProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.DetailsProject.Location = new System.Drawing.Point(0, 0);
            this.DetailsProject.Name = "DetailsProject";
            this.DetailsProject.Size = new System.Drawing.Size(317, 49);
            this.DetailsProject.TabIndex = 66;
            this.DetailsProject.Text = "Details";
            this.DetailsProject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TitleLabel1
            // 
            this.TitleLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TitleLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.TitleLabel1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.TitleLabel1.Location = new System.Drawing.Point(109, 70);
            this.TitleLabel1.Name = "TitleLabel1";
            this.TitleLabel1.Size = new System.Drawing.Size(194, 20);
            this.TitleLabel1.TabIndex = 74;
            // 
            // DescLabel
            // 
            this.DescLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DescLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DescLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.DescLabel.Location = new System.Drawing.Point(109, 111);
            this.DescLabel.Name = "DescLabel";
            this.DescLabel.Size = new System.Drawing.Size(194, 107);
            this.DescLabel.TabIndex = 75;
            // 
            // ProjectDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 277);
            this.Controls.Add(this.DescLabel);
            this.Controls.Add(this.TitleLabel1);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.DesTextBox);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.DetailsProject);
            this.Name = "ProjectDetails";
            this.Text = "ProjectDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.TextBox DesTextBox;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label DetailsProject;
        private System.Windows.Forms.Label TitleLabel1;
        private System.Windows.Forms.Label DescLabel;
    }
}