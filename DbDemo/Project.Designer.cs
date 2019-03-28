namespace DbDemo
{
    partial class Project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Project));
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchCategory = new System.Windows.Forms.ComboBox();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.ProjectCreate = new System.Windows.Forms.Button();
            this.ProjectDataGrid = new System.Windows.Forms.DataGridView();
            this.ProjectLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(224, 50);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 18;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchCategory
            // 
            this.SearchCategory.FormattingEnabled = true;
            this.SearchCategory.Location = new System.Drawing.Point(12, 52);
            this.SearchCategory.Name = "SearchCategory";
            this.SearchCategory.Size = new System.Drawing.Size(67, 21);
            this.SearchCategory.TabIndex = 17;
            this.SearchCategory.SelectedIndexChanged += new System.EventHandler(this.SearchCategory_SelectedIndexChanged);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(85, 52);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(133, 20);
            this.SearchTextBox.TabIndex = 16;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // ProjectCreate
            // 
            this.ProjectCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProjectCreate.BackColor = System.Drawing.Color.White;
            this.ProjectCreate.Image = ((System.Drawing.Image)(resources.GetObject("ProjectCreate.Image")));
            this.ProjectCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ProjectCreate.Location = new System.Drawing.Point(544, 39);
            this.ProjectCreate.Name = "ProjectCreate";
            this.ProjectCreate.Size = new System.Drawing.Size(33, 33);
            this.ProjectCreate.TabIndex = 15;
            this.ProjectCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ProjectCreate.UseVisualStyleBackColor = false;
            this.ProjectCreate.Click += new System.EventHandler(this.ProjectCreate_Click);
            // 
            // ProjectDataGrid
            // 
            this.ProjectDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProjectDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProjectDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProjectDataGrid.Location = new System.Drawing.Point(12, 78);
            this.ProjectDataGrid.Name = "ProjectDataGrid";
            this.ProjectDataGrid.ReadOnly = true;
            this.ProjectDataGrid.Size = new System.Drawing.Size(565, 358);
            this.ProjectDataGrid.TabIndex = 14;
            this.ProjectDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProjectDataGrid_CellContentClick);
            // 
            // ProjectLabel
            // 
            this.ProjectLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProjectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.ProjectLabel.Location = new System.Drawing.Point(0, 0);
            this.ProjectLabel.Name = "ProjectLabel";
            this.ProjectLabel.Size = new System.Drawing.Size(587, 49);
            this.ProjectLabel.TabIndex = 13;
            this.ProjectLabel.Text = "Project";
            this.ProjectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ProjectLabel.Click += new System.EventHandler(this.ProjectLabel_Click);
            // 
            // Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 448);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchCategory);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.ProjectCreate);
            this.Controls.Add(this.ProjectDataGrid);
            this.Controls.Add(this.ProjectLabel);
            this.Name = "Project";
            this.Text = "Project";
            ((System.ComponentModel.ISupportInitialize)(this.ProjectDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ComboBox SearchCategory;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button ProjectCreate;
        private System.Windows.Forms.DataGridView ProjectDataGrid;
        private System.Windows.Forms.Label ProjectLabel;
    }
}