namespace DbDemo
{
    partial class EvaluationSelect
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
            this.CancelButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchCategory = new System.Windows.Forms.ComboBox();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.ProjectDataGrid = new System.Windows.Forms.DataGridView();
            this.ProjectLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OMTextBox = new System.Windows.Forms.TextBox();
            this.OMError = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EDDatePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CancelButton.Location = new System.Drawing.Point(26, 307);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 33;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.Location = new System.Drawing.Point(362, 307);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 32;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(224, 62);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 31;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchCategory
            // 
            this.SearchCategory.FormattingEnabled = true;
            this.SearchCategory.Location = new System.Drawing.Point(12, 64);
            this.SearchCategory.Name = "SearchCategory";
            this.SearchCategory.Size = new System.Drawing.Size(67, 21);
            this.SearchCategory.TabIndex = 30;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(85, 64);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(133, 20);
            this.SearchTextBox.TabIndex = 29;
            // 
            // ProjectDataGrid
            // 
            this.ProjectDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProjectDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProjectDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProjectDataGrid.Location = new System.Drawing.Point(12, 90);
            this.ProjectDataGrid.Name = "ProjectDataGrid";
            this.ProjectDataGrid.ReadOnly = true;
            this.ProjectDataGrid.Size = new System.Drawing.Size(438, 158);
            this.ProjectDataGrid.TabIndex = 28;
            this.ProjectDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProjectDataGrid_CellContentClick);
            // 
            // ProjectLabel
            // 
            this.ProjectLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProjectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.ProjectLabel.Location = new System.Drawing.Point(0, 0);
            this.ProjectLabel.Name = "ProjectLabel";
            this.ProjectLabel.Size = new System.Drawing.Size(463, 49);
            this.ProjectLabel.TabIndex = 27;
            this.ProjectLabel.Text = "Select Evaluation";
            this.ProjectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Obtained Marks: ";
            // 
            // OMTextBox
            // 
            this.OMTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OMTextBox.Location = new System.Drawing.Point(106, 254);
            this.OMTextBox.Name = "OMTextBox";
            this.OMTextBox.Size = new System.Drawing.Size(86, 20);
            this.OMTextBox.TabIndex = 35;
            this.OMTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // OMError
            // 
            this.OMError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OMError.AutoSize = true;
            this.OMError.Location = new System.Drawing.Point(198, 257);
            this.OMError.Name = "OMError";
            this.OMError.Size = new System.Drawing.Size(43, 13);
            this.OMError.TabIndex = 41;
            this.OMError.Text = "LNError";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Evaluation Date: ";
            // 
            // EDDatePicker
            // 
            this.EDDatePicker.Location = new System.Drawing.Point(108, 280);
            this.EDDatePicker.MaxDate = new System.DateTime(2019, 3, 28, 0, 0, 0, 0);
            this.EDDatePicker.Name = "EDDatePicker";
            this.EDDatePicker.Size = new System.Drawing.Size(184, 20);
            this.EDDatePicker.TabIndex = 45;
            this.EDDatePicker.Value = new System.DateTime(2019, 3, 28, 0, 0, 0, 0);
            // 
            // EvaluationSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 342);
            this.Controls.Add(this.EDDatePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OMError);
            this.Controls.Add(this.OMTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchCategory);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.ProjectDataGrid);
            this.Controls.Add(this.ProjectLabel);
            this.Name = "EvaluationSelect";
            this.Text = "EvaluationSelect";
            ((System.ComponentModel.ISupportInitialize)(this.ProjectDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ComboBox SearchCategory;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.DataGridView ProjectDataGrid;
        private System.Windows.Forms.Label ProjectLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OMTextBox;
        private System.Windows.Forms.Label OMError;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker EDDatePicker;
    }
}