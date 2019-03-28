namespace DbDemo
{
    partial class EvaluationEdit
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
            this.Save = new System.Windows.Forms.Button();
            this.TWError = new System.Windows.Forms.Label();
            this.TMError = new System.Windows.Forms.Label();
            this.NError = new System.Windows.Forms.Label();
            this.TMTextBox = new System.Windows.Forms.TextBox();
            this.TMLabel = new System.Windows.Forms.Label();
            this.TWTextBox = new System.Windows.Forms.TextBox();
            this.TWLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.CreateStudent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Cancel.Location = new System.Drawing.Point(12, 222);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 58;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Save
            // 
            this.Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Save.Location = new System.Drawing.Point(227, 222);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 57;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // TWError
            // 
            this.TWError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TWError.AutoSize = true;
            this.TWError.Location = new System.Drawing.Point(109, 172);
            this.TWError.Name = "TWError";
            this.TWError.Size = new System.Drawing.Size(47, 13);
            this.TWError.TabIndex = 56;
            this.TWError.Text = "TWError";
            // 
            // TMError
            // 
            this.TMError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TMError.AutoSize = true;
            this.TMError.Location = new System.Drawing.Point(109, 133);
            this.TMError.Name = "TMError";
            this.TMError.Size = new System.Drawing.Size(43, 13);
            this.TMError.TabIndex = 55;
            this.TMError.Text = "LNError";
            // 
            // NError
            // 
            this.NError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NError.AutoSize = true;
            this.NError.Location = new System.Drawing.Point(109, 94);
            this.NError.Name = "NError";
            this.NError.Size = new System.Drawing.Size(37, 13);
            this.NError.TabIndex = 54;
            this.NError.Text = "NError";
            // 
            // TMTextBox
            // 
            this.TMTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TMTextBox.Location = new System.Drawing.Point(109, 110);
            this.TMTextBox.Name = "TMTextBox";
            this.TMTextBox.Size = new System.Drawing.Size(193, 20);
            this.TMTextBox.TabIndex = 53;
            // 
            // TMLabel
            // 
            this.TMLabel.AutoSize = true;
            this.TMLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.TMLabel.Location = new System.Drawing.Point(12, 110);
            this.TMLabel.Name = "TMLabel";
            this.TMLabel.Size = new System.Drawing.Size(74, 15);
            this.TMLabel.TabIndex = 52;
            this.TMLabel.Text = "Total Marks:";
            // 
            // TWTextBox
            // 
            this.TWTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TWTextBox.Location = new System.Drawing.Point(109, 149);
            this.TWTextBox.Name = "TWTextBox";
            this.TWTextBox.Size = new System.Drawing.Size(193, 20);
            this.TWTextBox.TabIndex = 51;
            // 
            // TWLabel
            // 
            this.TWLabel.AutoSize = true;
            this.TWLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.TWLabel.Location = new System.Drawing.Point(12, 150);
            this.TWLabel.Name = "TWLabel";
            this.TWLabel.Size = new System.Drawing.Size(99, 15);
            this.TWLabel.TabIndex = 50;
            this.TWLabel.Text = "Total Weightage:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextBox.Location = new System.Drawing.Point(109, 69);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(193, 20);
            this.NameTextBox.TabIndex = 49;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.NameLabel.Location = new System.Drawing.Point(12, 69);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(44, 15);
            this.NameLabel.TabIndex = 48;
            this.NameLabel.Text = "Name:";
            // 
            // CreateStudent
            // 
            this.CreateStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.CreateStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.CreateStudent.Location = new System.Drawing.Point(0, 0);
            this.CreateStudent.Name = "CreateStudent";
            this.CreateStudent.Size = new System.Drawing.Size(314, 49);
            this.CreateStudent.TabIndex = 47;
            this.CreateStudent.Text = "Edit";
            this.CreateStudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EvaluationEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 251);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.TWError);
            this.Controls.Add(this.TMError);
            this.Controls.Add(this.NError);
            this.Controls.Add(this.TMTextBox);
            this.Controls.Add(this.TMLabel);
            this.Controls.Add(this.TWTextBox);
            this.Controls.Add(this.TWLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.CreateStudent);
            this.Name = "EvaluationEdit";
            this.Text = "EditEvaluation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label TWError;
        private System.Windows.Forms.Label TMError;
        private System.Windows.Forms.Label NError;
        private System.Windows.Forms.TextBox TMTextBox;
        private System.Windows.Forms.Label TMLabel;
        private System.Windows.Forms.TextBox TWTextBox;
        private System.Windows.Forms.Label TWLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label CreateStudent;
    }
}