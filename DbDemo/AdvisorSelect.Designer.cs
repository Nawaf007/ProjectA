namespace DbDemo
{
    partial class AdvisorSelect
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
            this.StudentDataGrid = new System.Windows.Forms.DataGridView();
            this.AdvisorLabel = new System.Windows.Forms.Label();
            this.ARLabel = new System.Windows.Forms.Label();
            this.ARComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.StudentDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CancelButton.Location = new System.Drawing.Point(35, 290);
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
            this.AddButton.Location = new System.Drawing.Point(298, 290);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 32;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(224, 60);
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
            this.SearchCategory.Location = new System.Drawing.Point(12, 62);
            this.SearchCategory.Name = "SearchCategory";
            this.SearchCategory.Size = new System.Drawing.Size(67, 21);
            this.SearchCategory.TabIndex = 30;
            this.SearchCategory.SelectedIndexChanged += new System.EventHandler(this.SearchCategory_SelectedIndexChanged);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(85, 62);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(133, 20);
            this.SearchTextBox.TabIndex = 29;
            // 
            // StudentDataGrid
            // 
            this.StudentDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StudentDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StudentDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentDataGrid.Location = new System.Drawing.Point(12, 88);
            this.StudentDataGrid.Name = "StudentDataGrid";
            this.StudentDataGrid.ReadOnly = true;
            this.StudentDataGrid.Size = new System.Drawing.Size(374, 152);
            this.StudentDataGrid.TabIndex = 28;
            this.StudentDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentDataGrid_CellContentClick);
            // 
            // AdvisorLabel
            // 
            this.AdvisorLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AdvisorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.AdvisorLabel.Location = new System.Drawing.Point(0, 0);
            this.AdvisorLabel.Name = "AdvisorLabel";
            this.AdvisorLabel.Size = new System.Drawing.Size(399, 49);
            this.AdvisorLabel.TabIndex = 27;
            this.AdvisorLabel.Text = "Select Advisor";
            this.AdvisorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ARLabel
            // 
            this.ARLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ARLabel.Location = new System.Drawing.Point(12, 261);
            this.ARLabel.Name = "ARLabel";
            this.ARLabel.Size = new System.Drawing.Size(73, 13);
            this.ARLabel.TabIndex = 34;
            this.ARLabel.Text = "Advisor Role: ";
            // 
            // ARComboBox
            // 
            this.ARComboBox.FormattingEnabled = true;
            this.ARComboBox.Location = new System.Drawing.Point(85, 258);
            this.ARComboBox.Name = "ARComboBox";
            this.ARComboBox.Size = new System.Drawing.Size(133, 21);
            this.ARComboBox.TabIndex = 35;
            // 
            // AdvisorSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 318);
            this.Controls.Add(this.ARComboBox);
            this.Controls.Add(this.ARLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchCategory);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.StudentDataGrid);
            this.Controls.Add(this.AdvisorLabel);
            this.Name = "AdvisorSelect";
            this.Text = "AdvisorSelect";
            ((System.ComponentModel.ISupportInitialize)(this.StudentDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ComboBox SearchCategory;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.DataGridView StudentDataGrid;
        private System.Windows.Forms.Label AdvisorLabel;
        private System.Windows.Forms.Label ARLabel;
        private System.Windows.Forms.ComboBox ARComboBox;
    }
}