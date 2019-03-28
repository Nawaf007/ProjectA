namespace DbDemo
{
    partial class AdvisorEdit
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
            this.DesComboBox = new System.Windows.Forms.ComboBox();
            this.DesignationLabel = new System.Windows.Forms.Label();
            this.DateOfBirthPick = new System.Windows.Forms.DateTimePicker();
            this.GenderComboBox = new System.Windows.Forms.ComboBox();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.SalaryError = new System.Windows.Forms.Label();
            this.EmailError = new System.Windows.Forms.Label();
            this.ConError = new System.Windows.Forms.Label();
            this.LNError = new System.Windows.Forms.Label();
            this.FNError = new System.Windows.Forms.Label();
            this.SalaryTextBox = new System.Windows.Forms.TextBox();
            this.SalaryLabel = new System.Windows.Forms.Label();
            this.DateOfBirthLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.ContactTextBox = new System.Windows.Forms.TextBox();
            this.ContactLabel = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.EditAdvisor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DesComboBox
            // 
            this.DesComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DesComboBox.FormattingEnabled = true;
            this.DesComboBox.Location = new System.Drawing.Point(108, 345);
            this.DesComboBox.Name = "DesComboBox";
            this.DesComboBox.Size = new System.Drawing.Size(193, 21);
            this.DesComboBox.TabIndex = 77;
            // 
            // DesignationLabel
            // 
            this.DesignationLabel.AutoSize = true;
            this.DesignationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.DesignationLabel.Location = new System.Drawing.Point(12, 345);
            this.DesignationLabel.Name = "DesignationLabel";
            this.DesignationLabel.Size = new System.Drawing.Size(76, 15);
            this.DesignationLabel.TabIndex = 76;
            this.DesignationLabel.Text = "Designation:";
            // 
            // DateOfBirthPick
            // 
            this.DateOfBirthPick.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DateOfBirthPick.Location = new System.Drawing.Point(109, 227);
            this.DateOfBirthPick.Name = "DateOfBirthPick";
            this.DateOfBirthPick.Size = new System.Drawing.Size(193, 20);
            this.DateOfBirthPick.TabIndex = 75;
            // 
            // GenderComboBox
            // 
            this.GenderComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GenderComboBox.FormattingEnabled = true;
            this.GenderComboBox.Location = new System.Drawing.Point(109, 304);
            this.GenderComboBox.Name = "GenderComboBox";
            this.GenderComboBox.Size = new System.Drawing.Size(193, 21);
            this.GenderComboBox.TabIndex = 74;
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.GenderLabel.Location = new System.Drawing.Point(12, 305);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(51, 15);
            this.GenderLabel.TabIndex = 73;
            this.GenderLabel.Text = "Gender:";
            // 
            // Cancel
            // 
            this.Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Cancel.Location = new System.Drawing.Point(12, 399);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 72;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Add
            // 
            this.Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Add.Location = new System.Drawing.Point(227, 399);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 71;
            this.Add.Text = "Save";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // SalaryError
            // 
            this.SalaryError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SalaryError.AutoSize = true;
            this.SalaryError.Location = new System.Drawing.Point(109, 289);
            this.SalaryError.Name = "SalaryError";
            this.SalaryError.Size = new System.Drawing.Size(58, 13);
            this.SalaryError.TabIndex = 70;
            this.SalaryError.Text = "SalaryError";
            // 
            // EmailError
            // 
            this.EmailError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailError.AutoSize = true;
            this.EmailError.Location = new System.Drawing.Point(109, 211);
            this.EmailError.Name = "EmailError";
            this.EmailError.Size = new System.Drawing.Size(54, 13);
            this.EmailError.TabIndex = 69;
            this.EmailError.Text = "EmailError";
            // 
            // ConError
            // 
            this.ConError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConError.AutoSize = true;
            this.ConError.Location = new System.Drawing.Point(109, 172);
            this.ConError.Name = "ConError";
            this.ConError.Size = new System.Drawing.Size(48, 13);
            this.ConError.TabIndex = 68;
            this.ConError.Text = "ConError";
            // 
            // LNError
            // 
            this.LNError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LNError.AutoSize = true;
            this.LNError.Location = new System.Drawing.Point(109, 133);
            this.LNError.Name = "LNError";
            this.LNError.Size = new System.Drawing.Size(43, 13);
            this.LNError.TabIndex = 67;
            this.LNError.Text = "LNError";
            // 
            // FNError
            // 
            this.FNError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FNError.AutoSize = true;
            this.FNError.Location = new System.Drawing.Point(109, 94);
            this.FNError.Name = "FNError";
            this.FNError.Size = new System.Drawing.Size(43, 13);
            this.FNError.TabIndex = 66;
            this.FNError.Text = "FNError";
            // 
            // SalaryTextBox
            // 
            this.SalaryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SalaryTextBox.Location = new System.Drawing.Point(109, 266);
            this.SalaryTextBox.Name = "SalaryTextBox";
            this.SalaryTextBox.Size = new System.Drawing.Size(193, 20);
            this.SalaryTextBox.TabIndex = 65;
            // 
            // SalaryLabel
            // 
            this.SalaryLabel.AutoSize = true;
            this.SalaryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.SalaryLabel.Location = new System.Drawing.Point(12, 266);
            this.SalaryLabel.Name = "SalaryLabel";
            this.SalaryLabel.Size = new System.Drawing.Size(44, 15);
            this.SalaryLabel.TabIndex = 64;
            this.SalaryLabel.Text = "Salary:";
            // 
            // DateOfBirthLabel
            // 
            this.DateOfBirthLabel.AutoSize = true;
            this.DateOfBirthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.DateOfBirthLabel.Location = new System.Drawing.Point(12, 227);
            this.DateOfBirthLabel.Name = "DateOfBirthLabel";
            this.DateOfBirthLabel.Size = new System.Drawing.Size(79, 15);
            this.DateOfBirthLabel.TabIndex = 63;
            this.DateOfBirthLabel.Text = "Date Of Birth:";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailTextBox.Location = new System.Drawing.Point(109, 188);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(193, 20);
            this.EmailTextBox.TabIndex = 62;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.EmailLabel.Location = new System.Drawing.Point(12, 188);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(42, 15);
            this.EmailLabel.TabIndex = 61;
            this.EmailLabel.Text = "Email:";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LastNameTextBox.Location = new System.Drawing.Point(109, 110);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(193, 20);
            this.LastNameTextBox.TabIndex = 60;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.LastNameLabel.Location = new System.Drawing.Point(12, 110);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(70, 15);
            this.LastNameLabel.TabIndex = 59;
            this.LastNameLabel.Text = "Last Name:";
            // 
            // ContactTextBox
            // 
            this.ContactTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactTextBox.Location = new System.Drawing.Point(109, 149);
            this.ContactTextBox.Name = "ContactTextBox";
            this.ContactTextBox.Size = new System.Drawing.Size(193, 20);
            this.ContactTextBox.TabIndex = 58;
            // 
            // ContactLabel
            // 
            this.ContactLabel.AutoSize = true;
            this.ContactLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ContactLabel.Location = new System.Drawing.Point(12, 150);
            this.ContactLabel.Name = "ContactLabel";
            this.ContactLabel.Size = new System.Drawing.Size(51, 15);
            this.ContactLabel.TabIndex = 57;
            this.ContactLabel.Text = "Contact:";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstNameTextBox.Location = new System.Drawing.Point(109, 69);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(193, 20);
            this.FirstNameTextBox.TabIndex = 56;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.FirstNameLabel.Location = new System.Drawing.Point(12, 69);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(70, 15);
            this.FirstNameLabel.TabIndex = 55;
            this.FirstNameLabel.Text = "First Name:";
            // 
            // EditAdvisor
            // 
            this.EditAdvisor.Dock = System.Windows.Forms.DockStyle.Top;
            this.EditAdvisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.EditAdvisor.Location = new System.Drawing.Point(0, 0);
            this.EditAdvisor.Name = "EditAdvisor";
            this.EditAdvisor.Size = new System.Drawing.Size(314, 49);
            this.EditAdvisor.TabIndex = 54;
            this.EditAdvisor.Text = "Edit";
            this.EditAdvisor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdvisorEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 429);
            this.Controls.Add(this.DesComboBox);
            this.Controls.Add(this.DesignationLabel);
            this.Controls.Add(this.DateOfBirthPick);
            this.Controls.Add(this.GenderComboBox);
            this.Controls.Add(this.GenderLabel);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.SalaryError);
            this.Controls.Add(this.EmailError);
            this.Controls.Add(this.ConError);
            this.Controls.Add(this.LNError);
            this.Controls.Add(this.FNError);
            this.Controls.Add(this.SalaryTextBox);
            this.Controls.Add(this.SalaryLabel);
            this.Controls.Add(this.DateOfBirthLabel);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.ContactTextBox);
            this.Controls.Add(this.ContactLabel);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.EditAdvisor);
            this.Name = "AdvisorEdit";
            this.Text = "AdvisorEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox DesComboBox;
        private System.Windows.Forms.Label DesignationLabel;
        private System.Windows.Forms.DateTimePicker DateOfBirthPick;
        private System.Windows.Forms.ComboBox GenderComboBox;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label SalaryError;
        private System.Windows.Forms.Label EmailError;
        private System.Windows.Forms.Label ConError;
        private System.Windows.Forms.Label LNError;
        private System.Windows.Forms.Label FNError;
        private System.Windows.Forms.TextBox SalaryTextBox;
        private System.Windows.Forms.Label SalaryLabel;
        private System.Windows.Forms.Label DateOfBirthLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox ContactTextBox;
        private System.Windows.Forms.Label ContactLabel;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label EditAdvisor;
    }
}