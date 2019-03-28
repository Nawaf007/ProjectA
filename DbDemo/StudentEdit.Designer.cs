namespace DbDemo
{
    partial class StudentEdit
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
            this.DateOfBirthPick = new System.Windows.Forms.DateTimePicker();
            this.GenderComboBox = new System.Windows.Forms.ComboBox();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.RegError = new System.Windows.Forms.Label();
            this.DBError = new System.Windows.Forms.Label();
            this.EmailError = new System.Windows.Forms.Label();
            this.ConError = new System.Windows.Forms.Label();
            this.LNError = new System.Windows.Forms.Label();
            this.FNError = new System.Windows.Forms.Label();
            this.RegNoTextBox = new System.Windows.Forms.TextBox();
            this.RegistrtionNoLabel = new System.Windows.Forms.Label();
            this.DateOfBirthLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.ContactTextBox = new System.Windows.Forms.TextBox();
            this.ContactLabel = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.CreateStudent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DateOfBirthPick
            // 
            this.DateOfBirthPick.Location = new System.Drawing.Point(109, 216);
            this.DateOfBirthPick.Name = "DateOfBirthPick";
            this.DateOfBirthPick.Size = new System.Drawing.Size(193, 20);
            this.DateOfBirthPick.TabIndex = 49;
            // 
            // GenderComboBox
            // 
            this.GenderComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GenderComboBox.FormattingEnabled = true;
            this.GenderComboBox.Location = new System.Drawing.Point(109, 293);
            this.GenderComboBox.Name = "GenderComboBox";
            this.GenderComboBox.Size = new System.Drawing.Size(193, 21);
            this.GenderComboBox.TabIndex = 48;
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.GenderLabel.Location = new System.Drawing.Point(12, 294);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(51, 15);
            this.GenderLabel.TabIndex = 47;
            this.GenderLabel.Text = "Gender:";
            // 
            // Cancel
            // 
            this.Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Cancel.Location = new System.Drawing.Point(12, 340);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 46;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Edit
            // 
            this.Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Edit.Location = new System.Drawing.Point(227, 339);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(75, 23);
            this.Edit.TabIndex = 45;
            this.Edit.Text = "Save";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // RegError
            // 
            this.RegError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RegError.AutoSize = true;
            this.RegError.Location = new System.Drawing.Point(109, 278);
            this.RegError.Name = "RegError";
            this.RegError.Size = new System.Drawing.Size(49, 13);
            this.RegError.TabIndex = 44;
            this.RegError.Text = "RegError";
            // 
            // DBError
            // 
            this.DBError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DBError.AutoSize = true;
            this.DBError.Location = new System.Drawing.Point(109, 239);
            this.DBError.Name = "DBError";
            this.DBError.Size = new System.Drawing.Size(44, 13);
            this.DBError.TabIndex = 43;
            this.DBError.Text = "DBError";
            // 
            // EmailError
            // 
            this.EmailError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailError.AutoSize = true;
            this.EmailError.Location = new System.Drawing.Point(109, 200);
            this.EmailError.Name = "EmailError";
            this.EmailError.Size = new System.Drawing.Size(54, 13);
            this.EmailError.TabIndex = 42;
            this.EmailError.Text = "EmailError";
            // 
            // ConError
            // 
            this.ConError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConError.AutoSize = true;
            this.ConError.Location = new System.Drawing.Point(109, 161);
            this.ConError.Name = "ConError";
            this.ConError.Size = new System.Drawing.Size(48, 13);
            this.ConError.TabIndex = 41;
            this.ConError.Text = "ConError";
            // 
            // LNError
            // 
            this.LNError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LNError.AutoSize = true;
            this.LNError.Location = new System.Drawing.Point(109, 122);
            this.LNError.Name = "LNError";
            this.LNError.Size = new System.Drawing.Size(43, 13);
            this.LNError.TabIndex = 40;
            this.LNError.Text = "LNError";
            // 
            // FNError
            // 
            this.FNError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FNError.AutoSize = true;
            this.FNError.Location = new System.Drawing.Point(109, 83);
            this.FNError.Name = "FNError";
            this.FNError.Size = new System.Drawing.Size(43, 13);
            this.FNError.TabIndex = 39;
            this.FNError.Text = "FNError";
            // 
            // RegNoTextBox
            // 
            this.RegNoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RegNoTextBox.Location = new System.Drawing.Point(109, 255);
            this.RegNoTextBox.Name = "RegNoTextBox";
            this.RegNoTextBox.Size = new System.Drawing.Size(193, 20);
            this.RegNoTextBox.TabIndex = 38;
            // 
            // RegistrtionNoLabel
            // 
            this.RegistrtionNoLabel.AutoSize = true;
            this.RegistrtionNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.RegistrtionNoLabel.Location = new System.Drawing.Point(12, 255);
            this.RegistrtionNoLabel.Name = "RegistrtionNoLabel";
            this.RegistrtionNoLabel.Size = new System.Drawing.Size(95, 15);
            this.RegistrtionNoLabel.TabIndex = 37;
            this.RegistrtionNoLabel.Text = "Registration No:";
            // 
            // DateOfBirthLabel
            // 
            this.DateOfBirthLabel.AutoSize = true;
            this.DateOfBirthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.DateOfBirthLabel.Location = new System.Drawing.Point(12, 216);
            this.DateOfBirthLabel.Name = "DateOfBirthLabel";
            this.DateOfBirthLabel.Size = new System.Drawing.Size(79, 15);
            this.DateOfBirthLabel.TabIndex = 36;
            this.DateOfBirthLabel.Text = "Date Of Birth:";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailTextBox.Location = new System.Drawing.Point(109, 177);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(193, 20);
            this.EmailTextBox.TabIndex = 35;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.EmailLabel.Location = new System.Drawing.Point(12, 177);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(42, 15);
            this.EmailLabel.TabIndex = 34;
            this.EmailLabel.Text = "Email:";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LastNameTextBox.Location = new System.Drawing.Point(109, 99);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(193, 20);
            this.LastNameTextBox.TabIndex = 33;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.LastNameLabel.Location = new System.Drawing.Point(12, 99);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(70, 15);
            this.LastNameLabel.TabIndex = 32;
            this.LastNameLabel.Text = "Last Name:";
            // 
            // ContactTextBox
            // 
            this.ContactTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactTextBox.Location = new System.Drawing.Point(109, 138);
            this.ContactTextBox.Name = "ContactTextBox";
            this.ContactTextBox.Size = new System.Drawing.Size(193, 20);
            this.ContactTextBox.TabIndex = 31;
            // 
            // ContactLabel
            // 
            this.ContactLabel.AutoSize = true;
            this.ContactLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ContactLabel.Location = new System.Drawing.Point(12, 139);
            this.ContactLabel.Name = "ContactLabel";
            this.ContactLabel.Size = new System.Drawing.Size(51, 15);
            this.ContactLabel.TabIndex = 30;
            this.ContactLabel.Text = "Contact:";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstNameTextBox.Location = new System.Drawing.Point(109, 58);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(193, 20);
            this.FirstNameTextBox.TabIndex = 29;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.FirstNameLabel.Location = new System.Drawing.Point(12, 58);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(70, 15);
            this.FirstNameLabel.TabIndex = 28;
            this.FirstNameLabel.Text = "First Name:";
            // 
            // CreateStudent
            // 
            this.CreateStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.CreateStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.CreateStudent.Location = new System.Drawing.Point(0, 0);
            this.CreateStudent.Name = "CreateStudent";
            this.CreateStudent.Size = new System.Drawing.Size(316, 49);
            this.CreateStudent.TabIndex = 27;
            this.CreateStudent.Text = "Edit";
            this.CreateStudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StudentEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 374);
            this.Controls.Add(this.DateOfBirthPick);
            this.Controls.Add(this.GenderComboBox);
            this.Controls.Add(this.GenderLabel);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Edit);
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
            this.Name = "StudentEdit";
            this.Text = "StudentEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DateOfBirthPick;
        private System.Windows.Forms.ComboBox GenderComboBox;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Label RegError;
        private System.Windows.Forms.Label DBError;
        private System.Windows.Forms.Label EmailError;
        private System.Windows.Forms.Label ConError;
        private System.Windows.Forms.Label LNError;
        private System.Windows.Forms.Label FNError;
        private System.Windows.Forms.TextBox RegNoTextBox;
        private System.Windows.Forms.Label RegistrtionNoLabel;
        private System.Windows.Forms.Label DateOfBirthLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox ContactTextBox;
        private System.Windows.Forms.Label ContactLabel;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label CreateStudent;


    }
}