namespace DbDemo
{
    partial class StudentCreate
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
            this.CreateStudent = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.ContactTextBox = new System.Windows.Forms.TextBox();
            this.ContactLabel = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.DateOfBirthLabel = new System.Windows.Forms.Label();
            this.RegNoTextBox = new System.Windows.Forms.TextBox();
            this.RegistrtionNoLabel = new System.Windows.Forms.Label();
            this.FNError = new System.Windows.Forms.Label();
            this.LNError = new System.Windows.Forms.Label();
            this.ConError = new System.Windows.Forms.Label();
            this.EmailError = new System.Windows.Forms.Label();
            this.DBError = new System.Windows.Forms.Label();
            this.RegError = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.GenderComboBox = new System.Windows.Forms.ComboBox();
            this.DateOfBirthPick = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // CreateStudent
            // 
            this.CreateStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.CreateStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.CreateStudent.Location = new System.Drawing.Point(0, 0);
            this.CreateStudent.Name = "CreateStudent";
            this.CreateStudent.Size = new System.Drawing.Size(314, 49);
            this.CreateStudent.TabIndex = 1;
            this.CreateStudent.Text = "Create";
            this.CreateStudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.FirstNameLabel.Location = new System.Drawing.Point(12, 52);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(70, 15);
            this.FirstNameLabel.TabIndex = 2;
            this.FirstNameLabel.Text = "First Name:";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstNameTextBox.Location = new System.Drawing.Point(109, 52);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(193, 20);
            this.FirstNameTextBox.TabIndex = 3;
            // 
            // ContactTextBox
            // 
            this.ContactTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactTextBox.Location = new System.Drawing.Point(109, 132);
            this.ContactTextBox.Name = "ContactTextBox";
            this.ContactTextBox.Size = new System.Drawing.Size(193, 20);
            this.ContactTextBox.TabIndex = 5;
            // 
            // ContactLabel
            // 
            this.ContactLabel.AutoSize = true;
            this.ContactLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ContactLabel.Location = new System.Drawing.Point(12, 133);
            this.ContactLabel.Name = "ContactLabel";
            this.ContactLabel.Size = new System.Drawing.Size(51, 15);
            this.ContactLabel.TabIndex = 4;
            this.ContactLabel.Text = "Contact:";
            this.ContactLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LastNameTextBox.Location = new System.Drawing.Point(109, 93);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(193, 20);
            this.LastNameTextBox.TabIndex = 7;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.LastNameLabel.Location = new System.Drawing.Point(12, 93);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(70, 15);
            this.LastNameLabel.TabIndex = 6;
            this.LastNameLabel.Text = "Last Name:";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailTextBox.Location = new System.Drawing.Point(109, 171);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(193, 20);
            this.EmailTextBox.TabIndex = 9;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.EmailLabel.Location = new System.Drawing.Point(12, 171);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(42, 15);
            this.EmailLabel.TabIndex = 8;
            this.EmailLabel.Text = "Email:";
            // 
            // DateOfBirthLabel
            // 
            this.DateOfBirthLabel.AutoSize = true;
            this.DateOfBirthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.DateOfBirthLabel.Location = new System.Drawing.Point(12, 210);
            this.DateOfBirthLabel.Name = "DateOfBirthLabel";
            this.DateOfBirthLabel.Size = new System.Drawing.Size(79, 15);
            this.DateOfBirthLabel.TabIndex = 10;
            this.DateOfBirthLabel.Text = "Date Of Birth:";
            // 
            // RegNoTextBox
            // 
            this.RegNoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RegNoTextBox.Location = new System.Drawing.Point(109, 249);
            this.RegNoTextBox.Name = "RegNoTextBox";
            this.RegNoTextBox.Size = new System.Drawing.Size(193, 20);
            this.RegNoTextBox.TabIndex = 13;
            // 
            // RegistrtionNoLabel
            // 
            this.RegistrtionNoLabel.AutoSize = true;
            this.RegistrtionNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.RegistrtionNoLabel.Location = new System.Drawing.Point(12, 249);
            this.RegistrtionNoLabel.Name = "RegistrtionNoLabel";
            this.RegistrtionNoLabel.Size = new System.Drawing.Size(95, 15);
            this.RegistrtionNoLabel.TabIndex = 12;
            this.RegistrtionNoLabel.Text = "Registration No:";
            // 
            // FNError
            // 
            this.FNError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FNError.AutoSize = true;
            this.FNError.Location = new System.Drawing.Point(109, 77);
            this.FNError.Name = "FNError";
            this.FNError.Size = new System.Drawing.Size(43, 13);
            this.FNError.TabIndex = 14;
            this.FNError.Text = "FNError";
            // 
            // LNError
            // 
            this.LNError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LNError.AutoSize = true;
            this.LNError.Location = new System.Drawing.Point(109, 116);
            this.LNError.Name = "LNError";
            this.LNError.Size = new System.Drawing.Size(43, 13);
            this.LNError.TabIndex = 15;
            this.LNError.Text = "LNError";
            // 
            // ConError
            // 
            this.ConError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConError.AutoSize = true;
            this.ConError.Location = new System.Drawing.Point(109, 155);
            this.ConError.Name = "ConError";
            this.ConError.Size = new System.Drawing.Size(48, 13);
            this.ConError.TabIndex = 16;
            this.ConError.Text = "ConError";
            // 
            // EmailError
            // 
            this.EmailError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailError.AutoSize = true;
            this.EmailError.Location = new System.Drawing.Point(109, 194);
            this.EmailError.Name = "EmailError";
            this.EmailError.Size = new System.Drawing.Size(54, 13);
            this.EmailError.TabIndex = 17;
            this.EmailError.Text = "EmailError";
            // 
            // DBError
            // 
            this.DBError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DBError.AutoSize = true;
            this.DBError.Location = new System.Drawing.Point(109, 233);
            this.DBError.Name = "DBError";
            this.DBError.Size = new System.Drawing.Size(44, 13);
            this.DBError.TabIndex = 18;
            this.DBError.Text = "DBError";
            // 
            // RegError
            // 
            this.RegError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RegError.AutoSize = true;
            this.RegError.Location = new System.Drawing.Point(109, 272);
            this.RegError.Name = "RegError";
            this.RegError.Size = new System.Drawing.Size(49, 13);
            this.RegError.TabIndex = 19;
            this.RegError.Text = "RegError";
            // 
            // Add
            // 
            this.Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Add.Location = new System.Drawing.Point(227, 339);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 20;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Cancel
            // 
            this.Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Cancel.Location = new System.Drawing.Point(12, 339);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 21;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.GenderLabel.Location = new System.Drawing.Point(12, 288);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(51, 15);
            this.GenderLabel.TabIndex = 22;
            this.GenderLabel.Text = "Gender:";
            // 
            // GenderComboBox
            // 
            this.GenderComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GenderComboBox.FormattingEnabled = true;
            this.GenderComboBox.Location = new System.Drawing.Point(109, 287);
            this.GenderComboBox.Name = "GenderComboBox";
            this.GenderComboBox.Size = new System.Drawing.Size(193, 21);
            this.GenderComboBox.TabIndex = 25;
            // 
            // DateOfBirthPick
            // 
            this.DateOfBirthPick.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DateOfBirthPick.Location = new System.Drawing.Point(109, 210);
            this.DateOfBirthPick.Name = "DateOfBirthPick";
            this.DateOfBirthPick.Size = new System.Drawing.Size(193, 20);
            this.DateOfBirthPick.TabIndex = 26;
            // 
            // StudentCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 384);
            this.Controls.Add(this.DateOfBirthPick);
            this.Controls.Add(this.GenderComboBox);
            this.Controls.Add(this.GenderLabel);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.RegError);
            this.Controls.Add(this.DBError);
            this.Controls.Add(this.EmailError);
            this.Controls.Add(this.ConError);
            this.Controls.Add(this.LNError);
            this.Controls.Add(this.FNError);
            this.Controls.Add(this.RegNoTextBox);
            this.Controls.Add(this.RegistrtionNoLabel);
            this.Controls.Add(this.DateOfBirthLabel);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.ContactTextBox);
            this.Controls.Add(this.ContactLabel);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.CreateStudent);
            this.Name = "StudentCreate";
            this.Text = "StudentCreate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CreateStudent;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox ContactTextBox;
        private System.Windows.Forms.Label ContactLabel;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label DateOfBirthLabel;
        private System.Windows.Forms.TextBox RegNoTextBox;
        private System.Windows.Forms.Label RegistrtionNoLabel;
        private System.Windows.Forms.Label FNError;
        private System.Windows.Forms.Label LNError;
        private System.Windows.Forms.Label ConError;
        private System.Windows.Forms.Label EmailError;
        private System.Windows.Forms.Label DBError;
        private System.Windows.Forms.Label RegError;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.ComboBox GenderComboBox;
        private System.Windows.Forms.DateTimePicker DateOfBirthPick;
    }
}