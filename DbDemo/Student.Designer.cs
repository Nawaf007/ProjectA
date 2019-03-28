namespace DbDemo
{
    partial class Student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student));
            this.StudentLabel = new System.Windows.Forms.Label();
            this.StudentDataGrid = new System.Windows.Forms.DataGridView();
            this.StudentCreate = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchCategory = new System.Windows.Forms.ComboBox();
            this.SearchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StudentDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentLabel
            // 
            this.StudentLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.StudentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.StudentLabel.Location = new System.Drawing.Point(0, 0);
            this.StudentLabel.Name = "StudentLabel";
            this.StudentLabel.Size = new System.Drawing.Size(589, 49);
            this.StudentLabel.TabIndex = 0;
            this.StudentLabel.Text = "Students";
            this.StudentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StudentDataGrid
            // 
            this.StudentDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StudentDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StudentDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentDataGrid.Location = new System.Drawing.Point(12, 71);
            this.StudentDataGrid.Name = "StudentDataGrid";
            this.StudentDataGrid.ReadOnly = true;
            this.StudentDataGrid.Size = new System.Drawing.Size(565, 353);
            this.StudentDataGrid.TabIndex = 1;
            this.StudentDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // StudentCreate
            // 
            this.StudentCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StudentCreate.BackColor = System.Drawing.Color.White;
            this.StudentCreate.Image = ((System.Drawing.Image)(resources.GetObject("StudentCreate.Image")));
            this.StudentCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.StudentCreate.Location = new System.Drawing.Point(544, 32);
            this.StudentCreate.Name = "StudentCreate";
            this.StudentCreate.Size = new System.Drawing.Size(33, 33);
            this.StudentCreate.TabIndex = 2;
            this.StudentCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.StudentCreate.UseVisualStyleBackColor = false;
            this.StudentCreate.Click += new System.EventHandler(this.button1_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(85, 45);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(133, 20);
            this.SearchTextBox.TabIndex = 3;
            // 
            // SearchCategory
            // 
            this.SearchCategory.FormattingEnabled = true;
            this.SearchCategory.Location = new System.Drawing.Point(12, 45);
            this.SearchCategory.Name = "SearchCategory";
            this.SearchCategory.Size = new System.Drawing.Size(67, 21);
            this.SearchCategory.TabIndex = 4;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(224, 43);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 6;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 436);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchCategory);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.StudentCreate);
            this.Controls.Add(this.StudentDataGrid);
            this.Controls.Add(this.StudentLabel);
            this.Name = "Student";
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StudentLabel;
        private System.Windows.Forms.DataGridView StudentDataGrid;
        private System.Windows.Forms.Button StudentCreate;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.ComboBox SearchCategory;
        private System.Windows.Forms.Button SearchButton;
    }
}