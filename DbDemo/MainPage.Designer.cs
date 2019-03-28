namespace DbDemo
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.HomeButton = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AdvisorButton = new System.Windows.Forms.CheckBox();
            this.StudentButton = new System.Windows.Forms.CheckBox();
            this.ProjectButton = new System.Windows.Forms.CheckBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.EvaluationButton = new System.Windows.Forms.CheckBox();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchCategory = new System.Windows.Forms.ComboBox();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.StudentCreate = new System.Windows.Forms.Button();
            this.StudentDataGrid = new System.Windows.Forms.DataGridView();
            this.SATG = new System.Windows.Forms.Label();
            this.PATG = new System.Windows.Forms.Label();
            this.NOP = new System.Windows.Forms.Label();
            this.AATP = new System.Windows.Forms.Label();
            this.TrademarkLabel = new System.Windows.Forms.Label();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.GRButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            this.SuspendLayout();
            // 
            // HomeButton
            // 
            this.HomeButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HomeButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.HomeButton.Location = new System.Drawing.Point(3, 2);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(135, 24);
            this.HomeButton.TabIndex = 0;
            this.HomeButton.Text = "Home";
            this.HomeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(745, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "FYP Management";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdvisorButton
            // 
            this.AdvisorButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdvisorButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.AdvisorButton.Location = new System.Drawing.Point(3, 3);
            this.AdvisorButton.Name = "AdvisorButton";
            this.AdvisorButton.Size = new System.Drawing.Size(141, 24);
            this.AdvisorButton.TabIndex = 2;
            this.AdvisorButton.Text = "Advisor";
            this.AdvisorButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AdvisorButton.UseVisualStyleBackColor = true;
            this.AdvisorButton.Click += new System.EventHandler(this.AdvisorButton_CheckedChanged);
            // 
            // StudentButton
            // 
            this.StudentButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StudentButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.StudentButton.Location = new System.Drawing.Point(3, 2);
            this.StudentButton.Name = "StudentButton";
            this.StudentButton.Size = new System.Drawing.Size(137, 24);
            this.StudentButton.TabIndex = 3;
            this.StudentButton.Text = "Student";
            this.StudentButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.StudentButton.UseVisualStyleBackColor = true;
            this.StudentButton.Click += new System.EventHandler(this.StudentButton_CheckedChanged);
            // 
            // ProjectButton
            // 
            this.ProjectButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProjectButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.ProjectButton.Location = new System.Drawing.Point(3, 2);
            this.ProjectButton.Name = "ProjectButton";
            this.ProjectButton.Size = new System.Drawing.Size(144, 24);
            this.ProjectButton.TabIndex = 4;
            this.ProjectButton.Text = "Project";
            this.ProjectButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ProjectButton.UseVisualStyleBackColor = true;
            this.ProjectButton.Click += new System.EventHandler(this.ProjectButton_CheckedChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 56);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.HomeButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(745, 29);
            this.splitContainer1.SplitterDistance = 141;
            this.splitContainer1.TabIndex = 5;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.ProjectButton);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(600, 29);
            this.splitContainer2.SplitterDistance = 150;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.EvaluationButton);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer6);
            this.splitContainer3.Size = new System.Drawing.Size(446, 29);
            this.splitContainer3.SplitterDistance = 148;
            this.splitContainer3.TabIndex = 0;
            // 
            // EvaluationButton
            // 
            this.EvaluationButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EvaluationButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.EvaluationButton.Location = new System.Drawing.Point(3, 3);
            this.EvaluationButton.Name = "EvaluationButton";
            this.EvaluationButton.Size = new System.Drawing.Size(142, 24);
            this.EvaluationButton.TabIndex = 4;
            this.EvaluationButton.Text = "Evaluation";
            this.EvaluationButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EvaluationButton.UseVisualStyleBackColor = true;
            this.EvaluationButton.Click += new System.EventHandler(this.EvaluationButton_CheckedChanged);
            // 
            // splitContainer6
            // 
            this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer6.Location = new System.Drawing.Point(0, 0);
            this.splitContainer6.Name = "splitContainer6";
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.Controls.Add(this.StudentButton);
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.Controls.Add(this.AdvisorButton);
            this.splitContainer6.Size = new System.Drawing.Size(294, 29);
            this.splitContainer6.SplitterDistance = 143;
            this.splitContainer6.TabIndex = 0;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(224, 102);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 11;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchCategory
            // 
            this.SearchCategory.FormattingEnabled = true;
            this.SearchCategory.Location = new System.Drawing.Point(12, 104);
            this.SearchCategory.Name = "SearchCategory";
            this.SearchCategory.Size = new System.Drawing.Size(67, 21);
            this.SearchCategory.TabIndex = 10;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(85, 104);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(133, 20);
            this.SearchTextBox.TabIndex = 9;
            // 
            // StudentCreate
            // 
            this.StudentCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StudentCreate.BackColor = System.Drawing.Color.White;
            this.StudentCreate.Image = ((System.Drawing.Image)(resources.GetObject("StudentCreate.Image")));
            this.StudentCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.StudentCreate.Location = new System.Drawing.Point(724, 91);
            this.StudentCreate.Name = "StudentCreate";
            this.StudentCreate.Size = new System.Drawing.Size(33, 33);
            this.StudentCreate.TabIndex = 8;
            this.StudentCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.StudentCreate.UseVisualStyleBackColor = false;
            this.StudentCreate.Click += new System.EventHandler(this.StudentCreate_Click);
            // 
            // StudentDataGrid
            // 
            this.StudentDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StudentDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StudentDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentDataGrid.Location = new System.Drawing.Point(12, 130);
            this.StudentDataGrid.Name = "StudentDataGrid";
            this.StudentDataGrid.ReadOnly = true;
            this.StudentDataGrid.Size = new System.Drawing.Size(745, 288);
            this.StudentDataGrid.TabIndex = 7;
            this.StudentDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentDataGrid_CellContentClick);
            // 
            // SATG
            // 
            this.SATG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SATG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SATG.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.SATG.Location = new System.Drawing.Point(3, 0);
            this.SATG.Name = "SATG";
            this.SATG.Size = new System.Drawing.Size(239, 141);
            this.SATG.TabIndex = 13;
            this.SATG.Text = "SATG";
            this.SATG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PATG
            // 
            this.PATG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PATG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PATG.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.PATG.Location = new System.Drawing.Point(0, 0);
            this.PATG.Name = "PATG";
            this.PATG.Size = new System.Drawing.Size(238, 141);
            this.PATG.TabIndex = 14;
            this.PATG.Text = "PATG";
            this.PATG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NOP
            // 
            this.NOP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NOP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.NOP.Location = new System.Drawing.Point(12, 104);
            this.NOP.Name = "NOP";
            this.NOP.Size = new System.Drawing.Size(745, 89);
            this.NOP.TabIndex = 12;
            this.NOP.Text = "NOP";
            this.NOP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NOP.Click += new System.EventHandler(this.NOP_Click);
            // 
            // AATP
            // 
            this.AATP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AATP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AATP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.AATP.Location = new System.Drawing.Point(3, 0);
            this.AATP.Name = "AATP";
            this.AATP.Size = new System.Drawing.Size(247, 141);
            this.AATP.TabIndex = 15;
            this.AATP.Text = "AATP";
            this.AATP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TrademarkLabel
            // 
            this.TrademarkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TrademarkLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TrademarkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.TrademarkLabel.Location = new System.Drawing.Point(12, 367);
            this.TrademarkLabel.Name = "TrademarkLabel";
            this.TrademarkLabel.Size = new System.Drawing.Size(745, 51);
            this.TrademarkLabel.TabIndex = 16;
            this.TrademarkLabel.Text = "CR";
            this.TrademarkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer4.IsSplitterFixed = true;
            this.splitContainer4.Location = new System.Drawing.Point(12, 211);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.PATG);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.splitContainer5);
            this.splitContainer4.Size = new System.Drawing.Size(744, 141);
            this.splitContainer4.SplitterDistance = 241;
            this.splitContainer4.TabIndex = 17;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.SATG);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.AATP);
            this.splitContainer5.Size = new System.Drawing.Size(499, 141);
            this.splitContainer5.SplitterDistance = 245;
            this.splitContainer5.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(646, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 33);
            this.button1.TabIndex = 18;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.BackColor = System.Drawing.Color.White;
            this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
            this.DeleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DeleteButton.Location = new System.Drawing.Point(685, 91);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(33, 33);
            this.DeleteButton.TabIndex = 19;
            this.DeleteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // GRButton
            // 
            this.GRButton.Location = new System.Drawing.Point(336, 101);
            this.GRButton.Name = "GRButton";
            this.GRButton.Size = new System.Drawing.Size(102, 23);
            this.GRButton.TabIndex = 20;
            this.GRButton.Text = "Generate Report";
            this.GRButton.UseVisualStyleBackColor = true;
            this.GRButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 427);
            this.Controls.Add(this.GRButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.splitContainer4);
            this.Controls.Add(this.TrademarkLabel);
            this.Controls.Add(this.NOP);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchCategory);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.StudentCreate);
            this.Controls.Add(this.StudentDataGrid);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label1);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StudentDataGrid)).EndInit();
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox HomeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox AdvisorButton;
        private System.Windows.Forms.CheckBox StudentButton;
        private System.Windows.Forms.CheckBox ProjectButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ComboBox SearchCategory;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button StudentCreate;
        private System.Windows.Forms.DataGridView StudentDataGrid;
        private System.Windows.Forms.Label SATG;
        private System.Windows.Forms.Label PATG;
        private System.Windows.Forms.Label NOP;
        private System.Windows.Forms.Label AATP;
        private System.Windows.Forms.Label TrademarkLabel;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.CheckBox EvaluationButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private System.Windows.Forms.Button GRButton;


    }
}