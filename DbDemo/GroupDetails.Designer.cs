namespace DbDemo
{
    partial class GroupDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupDetails));
            this.MainLabel = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.DeleteButtonP = new System.Windows.Forms.Button();
            this.SearchButtonP = new System.Windows.Forms.Button();
            this.SearchCategoryP = new System.Windows.Forms.ComboBox();
            this.SearchTextBoxP = new System.Windows.Forms.TextBox();
            this.ProjectCreate = new System.Windows.Forms.Button();
            this.ProjectDataGrid = new System.Windows.Forms.DataGridView();
            this.ProjectLabel = new System.Windows.Forms.Label();
            this.SearchButtonS = new System.Windows.Forms.Button();
            this.SearchCategoryS = new System.Windows.Forms.ComboBox();
            this.SearchTextBoxS = new System.Windows.Forms.TextBox();
            this.StudentDataGrid = new System.Windows.Forms.DataGridView();
            this.StudentLabel = new System.Windows.Forms.Label();
            this.EvalDeleteButton = new System.Windows.Forms.Button();
            this.SearchButtonE = new System.Windows.Forms.Button();
            this.SearchCategoryE = new System.Windows.Forms.ComboBox();
            this.SearchTextBoxE = new System.Windows.Forms.TextBox();
            this.EvaluationCreate = new System.Windows.Forms.Button();
            this.EvaluationDataGrid = new System.Windows.Forms.DataGridView();
            this.EvaluationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EvaluationDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // MainLabel
            // 
            this.MainLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.MainLabel.Location = new System.Drawing.Point(12, 9);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(723, 35);
            this.MainLabel.TabIndex = 2;
            this.MainLabel.Text = "Group Details";
            this.MainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 47);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.EvalDeleteButton);
            this.splitContainer1.Panel2.Controls.Add(this.SearchButtonE);
            this.splitContainer1.Panel2.Controls.Add(this.SearchCategoryE);
            this.splitContainer1.Panel2.Controls.Add(this.SearchTextBoxE);
            this.splitContainer1.Panel2.Controls.Add(this.EvaluationCreate);
            this.splitContainer1.Panel2.Controls.Add(this.EvaluationDataGrid);
            this.splitContainer1.Panel2.Controls.Add(this.EvaluationLabel);
            this.splitContainer1.Size = new System.Drawing.Size(723, 444);
            this.splitContainer1.SplitterDistance = 214;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.DeleteButtonP);
            this.splitContainer2.Panel1.Controls.Add(this.SearchButtonP);
            this.splitContainer2.Panel1.Controls.Add(this.SearchCategoryP);
            this.splitContainer2.Panel1.Controls.Add(this.SearchTextBoxP);
            this.splitContainer2.Panel1.Controls.Add(this.ProjectCreate);
            this.splitContainer2.Panel1.Controls.Add(this.ProjectDataGrid);
            this.splitContainer2.Panel1.Controls.Add(this.ProjectLabel);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.SearchButtonS);
            this.splitContainer2.Panel2.Controls.Add(this.SearchCategoryS);
            this.splitContainer2.Panel2.Controls.Add(this.SearchTextBoxS);
            this.splitContainer2.Panel2.Controls.Add(this.StudentDataGrid);
            this.splitContainer2.Panel2.Controls.Add(this.StudentLabel);
            this.splitContainer2.Size = new System.Drawing.Size(723, 214);
            this.splitContainer2.SplitterDistance = 355;
            this.splitContainer2.TabIndex = 0;
            // 
            // DeleteButtonP
            // 
            this.DeleteButtonP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButtonP.BackColor = System.Drawing.Color.White;
            this.DeleteButtonP.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButtonP.Image")));
            this.DeleteButtonP.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DeleteButtonP.Location = new System.Drawing.Point(267, 42);
            this.DeleteButtonP.Name = "DeleteButtonP";
            this.DeleteButtonP.Size = new System.Drawing.Size(33, 33);
            this.DeleteButtonP.TabIndex = 20;
            this.DeleteButtonP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.DeleteButtonP.UseVisualStyleBackColor = false;
            this.DeleteButtonP.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // SearchButtonP
            // 
            this.SearchButtonP.Location = new System.Drawing.Point(168, 52);
            this.SearchButtonP.Name = "SearchButtonP";
            this.SearchButtonP.Size = new System.Drawing.Size(78, 23);
            this.SearchButtonP.TabIndex = 18;
            this.SearchButtonP.Text = "Search";
            this.SearchButtonP.UseVisualStyleBackColor = true;
            this.SearchButtonP.Click += new System.EventHandler(this.SearchButtonP_Click);
            // 
            // SearchCategoryP
            // 
            this.SearchCategoryP.FormattingEnabled = true;
            this.SearchCategoryP.Location = new System.Drawing.Point(12, 54);
            this.SearchCategoryP.Name = "SearchCategoryP";
            this.SearchCategoryP.Size = new System.Drawing.Size(53, 21);
            this.SearchCategoryP.TabIndex = 17;
            // 
            // SearchTextBoxP
            // 
            this.SearchTextBoxP.Location = new System.Drawing.Point(71, 54);
            this.SearchTextBoxP.Name = "SearchTextBoxP";
            this.SearchTextBoxP.Size = new System.Drawing.Size(91, 20);
            this.SearchTextBoxP.TabIndex = 16;
            this.SearchTextBoxP.TextChanged += new System.EventHandler(this.SearchTextBoxP_TextChanged);
            // 
            // ProjectCreate
            // 
            this.ProjectCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProjectCreate.BackColor = System.Drawing.Color.White;
            this.ProjectCreate.Image = ((System.Drawing.Image)(resources.GetObject("ProjectCreate.Image")));
            this.ProjectCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ProjectCreate.Location = new System.Drawing.Point(306, 41);
            this.ProjectCreate.Name = "ProjectCreate";
            this.ProjectCreate.Size = new System.Drawing.Size(36, 33);
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
            this.ProjectDataGrid.Location = new System.Drawing.Point(12, 80);
            this.ProjectDataGrid.Name = "ProjectDataGrid";
            this.ProjectDataGrid.ReadOnly = true;
            this.ProjectDataGrid.Size = new System.Drawing.Size(330, 124);
            this.ProjectDataGrid.TabIndex = 14;
            this.ProjectDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProjectDataGrid_CellContentClick);
            // 
            // ProjectLabel
            // 
            this.ProjectLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProjectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.ProjectLabel.Location = new System.Drawing.Point(12, 9);
            this.ProjectLabel.Name = "ProjectLabel";
            this.ProjectLabel.Size = new System.Drawing.Size(330, 29);
            this.ProjectLabel.TabIndex = 13;
            this.ProjectLabel.Text = "Projects";
            this.ProjectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchButtonS
            // 
            this.SearchButtonS.Location = new System.Drawing.Point(168, 52);
            this.SearchButtonS.Name = "SearchButtonS";
            this.SearchButtonS.Size = new System.Drawing.Size(78, 23);
            this.SearchButtonS.TabIndex = 18;
            this.SearchButtonS.Text = "Search";
            this.SearchButtonS.UseVisualStyleBackColor = true;
            this.SearchButtonS.Click += new System.EventHandler(this.SearchButtonS_Click);
            // 
            // SearchCategoryS
            // 
            this.SearchCategoryS.FormattingEnabled = true;
            this.SearchCategoryS.Location = new System.Drawing.Point(17, 54);
            this.SearchCategoryS.Name = "SearchCategoryS";
            this.SearchCategoryS.Size = new System.Drawing.Size(47, 21);
            this.SearchCategoryS.TabIndex = 17;
            // 
            // SearchTextBoxS
            // 
            this.SearchTextBoxS.Location = new System.Drawing.Point(70, 54);
            this.SearchTextBoxS.Name = "SearchTextBoxS";
            this.SearchTextBoxS.Size = new System.Drawing.Size(92, 20);
            this.SearchTextBoxS.TabIndex = 16;
            // 
            // StudentDataGrid
            // 
            this.StudentDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StudentDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StudentDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentDataGrid.Location = new System.Drawing.Point(17, 80);
            this.StudentDataGrid.Name = "StudentDataGrid";
            this.StudentDataGrid.ReadOnly = true;
            this.StudentDataGrid.Size = new System.Drawing.Size(330, 124);
            this.StudentDataGrid.TabIndex = 14;
            // 
            // StudentLabel
            // 
            this.StudentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StudentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.StudentLabel.Location = new System.Drawing.Point(17, 9);
            this.StudentLabel.Name = "StudentLabel";
            this.StudentLabel.Size = new System.Drawing.Size(330, 29);
            this.StudentLabel.TabIndex = 13;
            this.StudentLabel.Text = "Students";
            this.StudentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EvalDeleteButton
            // 
            this.EvalDeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EvalDeleteButton.BackColor = System.Drawing.Color.White;
            this.EvalDeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("EvalDeleteButton.Image")));
            this.EvalDeleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EvalDeleteButton.Location = new System.Drawing.Point(634, 57);
            this.EvalDeleteButton.Name = "EvalDeleteButton";
            this.EvalDeleteButton.Size = new System.Drawing.Size(33, 33);
            this.EvalDeleteButton.TabIndex = 21;
            this.EvalDeleteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EvalDeleteButton.UseVisualStyleBackColor = false;
            this.EvalDeleteButton.Click += new System.EventHandler(this.EvalDeleteButton_Click);
            // 
            // SearchButtonE
            // 
            this.SearchButtonE.Location = new System.Drawing.Point(224, 67);
            this.SearchButtonE.Name = "SearchButtonE";
            this.SearchButtonE.Size = new System.Drawing.Size(75, 23);
            this.SearchButtonE.TabIndex = 18;
            this.SearchButtonE.Text = "Search";
            this.SearchButtonE.UseVisualStyleBackColor = true;
            this.SearchButtonE.Click += new System.EventHandler(this.SearchButtonE_Click);
            // 
            // SearchCategoryE
            // 
            this.SearchCategoryE.FormattingEnabled = true;
            this.SearchCategoryE.Location = new System.Drawing.Point(12, 69);
            this.SearchCategoryE.Name = "SearchCategoryE";
            this.SearchCategoryE.Size = new System.Drawing.Size(67, 21);
            this.SearchCategoryE.TabIndex = 17;
            // 
            // SearchTextBoxE
            // 
            this.SearchTextBoxE.Location = new System.Drawing.Point(85, 69);
            this.SearchTextBoxE.Name = "SearchTextBoxE";
            this.SearchTextBoxE.Size = new System.Drawing.Size(133, 20);
            this.SearchTextBoxE.TabIndex = 16;
            // 
            // EvaluationCreate
            // 
            this.EvaluationCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EvaluationCreate.BackColor = System.Drawing.Color.White;
            this.EvaluationCreate.Image = ((System.Drawing.Image)(resources.GetObject("EvaluationCreate.Image")));
            this.EvaluationCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EvaluationCreate.Location = new System.Drawing.Point(673, 56);
            this.EvaluationCreate.Name = "EvaluationCreate";
            this.EvaluationCreate.Size = new System.Drawing.Size(33, 33);
            this.EvaluationCreate.TabIndex = 15;
            this.EvaluationCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EvaluationCreate.UseVisualStyleBackColor = false;
            this.EvaluationCreate.Click += new System.EventHandler(this.EvaluationCreate_Click);
            // 
            // EvaluationDataGrid
            // 
            this.EvaluationDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EvaluationDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EvaluationDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EvaluationDataGrid.Location = new System.Drawing.Point(12, 95);
            this.EvaluationDataGrid.Name = "EvaluationDataGrid";
            this.EvaluationDataGrid.ReadOnly = true;
            this.EvaluationDataGrid.Size = new System.Drawing.Size(694, 128);
            this.EvaluationDataGrid.TabIndex = 14;
            this.EvaluationDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EvaluationDataGrid_CellContentClick);
            // 
            // EvaluationLabel
            // 
            this.EvaluationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EvaluationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.EvaluationLabel.Location = new System.Drawing.Point(12, 15);
            this.EvaluationLabel.Name = "EvaluationLabel";
            this.EvaluationLabel.Size = new System.Drawing.Size(694, 38);
            this.EvaluationLabel.TabIndex = 13;
            this.EvaluationLabel.Text = "Evaluations";
            this.EvaluationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GroupDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 503);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.MainLabel);
            this.Name = "GroupDetails";
            this.Text = "GroupDetails";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProjectDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EvaluationDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button SearchButtonP;
        private System.Windows.Forms.ComboBox SearchCategoryP;
        private System.Windows.Forms.TextBox SearchTextBoxP;
        private System.Windows.Forms.Button ProjectCreate;
        private System.Windows.Forms.DataGridView ProjectDataGrid;
        private System.Windows.Forms.Label ProjectLabel;
        private System.Windows.Forms.Button SearchButtonS;
        private System.Windows.Forms.ComboBox SearchCategoryS;
        private System.Windows.Forms.TextBox SearchTextBoxS;
        private System.Windows.Forms.DataGridView StudentDataGrid;
        private System.Windows.Forms.Label StudentLabel;
        private System.Windows.Forms.Button SearchButtonE;
        private System.Windows.Forms.ComboBox SearchCategoryE;
        private System.Windows.Forms.TextBox SearchTextBoxE;
        private System.Windows.Forms.Button EvaluationCreate;
        private System.Windows.Forms.DataGridView EvaluationDataGrid;
        private System.Windows.Forms.Label EvaluationLabel;
        private System.Windows.Forms.Button DeleteButtonP;
        private System.Windows.Forms.Button EvalDeleteButton;

    }
}