namespace DbDemo
{
    partial class ProjectCreate
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
            this.DesError = new System.Windows.Forms.Label();
            this.TitleError = new System.Windows.Forms.Label();
            this.DesTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.CreateAdvisor = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DesError
            // 
            this.DesError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DesError.AutoSize = true;
            this.DesError.Location = new System.Drawing.Point(110, 213);
            this.DesError.Name = "DesError";
            this.DesError.Size = new System.Drawing.Size(82, 13);
            this.DesError.TabIndex = 54;
            this.DesError.Text = "DescriptionError";
            // 
            // TitleError
            // 
            this.TitleError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleError.AutoSize = true;
            this.TitleError.Location = new System.Drawing.Point(110, 87);
            this.TitleError.Name = "TitleError";
            this.TitleError.Size = new System.Drawing.Size(49, 13);
            this.TitleError.TabIndex = 53;
            this.TitleError.Text = "TitleError";
            // 
            // DesTextBox
            // 
            this.DesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DesTextBox.Location = new System.Drawing.Point(110, 103);
            this.DesTextBox.Multiline = true;
            this.DesTextBox.Name = "DesTextBox";
            this.DesTextBox.Size = new System.Drawing.Size(193, 107);
            this.DesTextBox.TabIndex = 52;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.DescriptionLabel.Location = new System.Drawing.Point(13, 103);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(72, 15);
            this.DescriptionLabel.TabIndex = 51;
            this.DescriptionLabel.Text = "Description:";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleTextBox.Location = new System.Drawing.Point(110, 62);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(193, 20);
            this.TitleTextBox.TabIndex = 50;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.TitleLabel.Location = new System.Drawing.Point(13, 62);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(33, 15);
            this.TitleLabel.TabIndex = 49;
            this.TitleLabel.Text = "Title:";
            // 
            // CreateAdvisor
            // 
            this.CreateAdvisor.Dock = System.Windows.Forms.DockStyle.Top;
            this.CreateAdvisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.CreateAdvisor.Location = new System.Drawing.Point(0, 0);
            this.CreateAdvisor.Name = "CreateAdvisor";
            this.CreateAdvisor.Size = new System.Drawing.Size(315, 49);
            this.CreateAdvisor.TabIndex = 48;
            this.CreateAdvisor.Text = "Create";
            this.CreateAdvisor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cancel
            // 
            this.Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Cancel.Location = new System.Drawing.Point(13, 243);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 56;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Add
            // 
            this.Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Add.Location = new System.Drawing.Point(228, 243);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 55;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // ProjectCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 278);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.DesError);
            this.Controls.Add(this.TitleError);
            this.Controls.Add(this.DesTextBox);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.CreateAdvisor);
            this.Name = "ProjectCreate";
            this.Text = "ProjectCreate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DesError;
        private System.Windows.Forms.Label TitleError;
        private System.Windows.Forms.TextBox DesTextBox;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label CreateAdvisor;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Add;

    }
}