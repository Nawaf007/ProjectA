namespace DbDemo
{
    partial class Evaluation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Evaluation));
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchCategory = new System.Windows.Forms.ComboBox();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.EvaluationCreate = new System.Windows.Forms.Button();
            this.StudentDataGrid = new System.Windows.Forms.DataGridView();
            this.EvaluationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StudentDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(224, 48);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 12;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchCategory
            // 
            this.SearchCategory.FormattingEnabled = true;
            this.SearchCategory.Location = new System.Drawing.Point(12, 50);
            this.SearchCategory.Name = "SearchCategory";
            this.SearchCategory.Size = new System.Drawing.Size(67, 21);
            this.SearchCategory.TabIndex = 11;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(85, 50);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(133, 20);
            this.SearchTextBox.TabIndex = 10;
            // 
            // EvaluationCreate
            // 
            this.EvaluationCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EvaluationCreate.BackColor = System.Drawing.Color.White;
            this.EvaluationCreate.Image = ((System.Drawing.Image)(resources.GetObject("EvaluationCreate.Image")));
            this.EvaluationCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EvaluationCreate.Location = new System.Drawing.Point(544, 37);
            this.EvaluationCreate.Name = "EvaluationCreate";
            this.EvaluationCreate.Size = new System.Drawing.Size(33, 33);
            this.EvaluationCreate.TabIndex = 9;
            this.EvaluationCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EvaluationCreate.UseVisualStyleBackColor = false;
            this.EvaluationCreate.Click += new System.EventHandler(this.EvaluationCreate_Click);
            // 
            // StudentDataGrid
            // 
            this.StudentDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StudentDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StudentDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentDataGrid.Location = new System.Drawing.Point(12, 76);
            this.StudentDataGrid.Name = "StudentDataGrid";
            this.StudentDataGrid.ReadOnly = true;
            this.StudentDataGrid.Size = new System.Drawing.Size(565, 353);
            this.StudentDataGrid.TabIndex = 8;
            this.StudentDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentDataGrid_CellContentClick);
            // 
            // EvaluationLabel
            // 
            this.EvaluationLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.EvaluationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.EvaluationLabel.Location = new System.Drawing.Point(0, 0);
            this.EvaluationLabel.Name = "EvaluationLabel";
            this.EvaluationLabel.Size = new System.Drawing.Size(588, 49);
            this.EvaluationLabel.TabIndex = 7;
            this.EvaluationLabel.Text = "Evaluation";
            this.EvaluationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Evaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 435);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchCategory);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.EvaluationCreate);
            this.Controls.Add(this.StudentDataGrid);
            this.Controls.Add(this.EvaluationLabel);
            this.Name = "Evaluation";
            this.Text = "Evaluation";
            ((System.ComponentModel.ISupportInitialize)(this.StudentDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ComboBox SearchCategory;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button EvaluationCreate;
        private System.Windows.Forms.DataGridView StudentDataGrid;
        private System.Windows.Forms.Label EvaluationLabel;
    }
}