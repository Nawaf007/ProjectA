namespace DbDemo
{
    partial class ProjectEdit
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
            this.Cancel = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.DesError = new System.Windows.Forms.Label();
            this.TitleError = new System.Windows.Forms.Label();
            this.DesTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.CreateAdvisor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Cancel.Location = new System.Drawing.Point(13, 249);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 65;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Add
            // 
            this.Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Add.Location = new System.Drawing.Point(228, 249);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 64;
            this.Add.Text = "Save";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // DesError
            // 
            this.DesError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DesError.AutoSize = true;
            this.DesError.Location = new System.Drawing.Point(110, 219);
            this.DesError.Name = "DesError";
            this.DesError.Size = new System.Drawing.Size(82, 13);
            this.DesError.TabIndex = 63;
            this.DesError.Text = "DescriptionError";
            this.DesError.Click += new System.EventHandler(this.DesError_Click);
            // 
            // TitleError
            // 
            this.TitleError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleError.AutoSize = true;
            this.TitleError.Location = new System.Drawing.Point(110, 93);
            this.TitleError.Name = "TitleError";
            this.TitleError.Size = new System.Drawing.Size(49, 13);
            this.TitleError.TabIndex = 62;
            this.TitleError.Text = "TitleError";
            this.TitleError.Click += new System.EventHandler(this.TitleError_Click);
            // 
            // DesTextBox
            // 
            this.DesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DesTextBox.Location = new System.Drawing.Point(110, 109);
            this.DesTextBox.Multiline = true;
            this.DesTextBox.Name = "DesTextBox";
            this.DesTextBox.Size = new System.Drawing.Size(193, 107);
            this.DesTextBox.TabIndex = 61;
            this.DesTextBox.TextChanged += new System.EventHandler(this.DesTextBox_TextChanged);
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.DescriptionLabel.Location = new System.Drawing.Point(13, 109);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(72, 15);
            this.DescriptionLabel.TabIndex = 60;
            this.DescriptionLabel.Text = "Description:";
            this.DescriptionLabel.Click += new System.EventHandler(this.DescriptionLabel_Click);
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleTextBox.Location = new System.Drawing.Point(110, 68);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(193, 20);
            this.TitleTextBox.TabIndex = 59;
            this.TitleTextBox.TextChanged += new System.EventHandler(this.TitleTextBox_TextChanged);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.TitleLabel.Location = new System.Drawing.Point(13, 68);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(33, 15);
            this.TitleLabel.TabIndex = 58;
            this.TitleLabel.Text = "Title:";
            this.TitleLabel.Click += new System.EventHandler(this.TitleLabel_Click);
            // 
            // CreateAdvisor
            // 
            this.CreateAdvisor.Dock = System.Windows.Forms.DockStyle.Top;
            this.CreateAdvisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.CreateAdvisor.Location = new System.Drawing.Point(0, 0);
            this.CreateAdvisor.Name = "CreateAdvisor";
            this.CreateAdvisor.Size = new System.Drawing.Size(316, 49);
            this.CreateAdvisor.TabIndex = 57;
            this.CreateAdvisor.Text = "Edit";
            this.CreateAdvisor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CreateAdvisor.Click += new System.EventHandler(this.CreateAdvisor_Click);
            // 
            // ProjectEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 278);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.DesError);
            this.Controls.Add(this.TitleError);
            this.Controls.Add(this.DesTextBox);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.CreateAdvisor);
            this.Name = "ProjectEdit";
            this.Text = "ProjectEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label DesError;
        private System.Windows.Forms.Label TitleError;
        private System.Windows.Forms.TextBox DesTextBox;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label CreateAdvisor;
    }
}