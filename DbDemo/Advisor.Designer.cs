namespace DbDemo
{
    partial class Advisor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Advisor));
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchCategory = new System.Windows.Forms.ComboBox();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.AdvisorCreate = new System.Windows.Forms.Button();
            this.AdvisorDataGrid = new System.Windows.Forms.DataGridView();
            this.AdvisorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AdvisorDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(224, 49);
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
            this.SearchCategory.Location = new System.Drawing.Point(12, 51);
            this.SearchCategory.Name = "SearchCategory";
            this.SearchCategory.Size = new System.Drawing.Size(67, 21);
            this.SearchCategory.TabIndex = 11;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(85, 51);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(133, 20);
            this.SearchTextBox.TabIndex = 10;
            // 
            // AdvisorCreate
            // 
            this.AdvisorCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AdvisorCreate.BackColor = System.Drawing.Color.White;
            this.AdvisorCreate.Image = ((System.Drawing.Image)(resources.GetObject("AdvisorCreate.Image")));
            this.AdvisorCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AdvisorCreate.Location = new System.Drawing.Point(544, 38);
            this.AdvisorCreate.Name = "AdvisorCreate";
            this.AdvisorCreate.Size = new System.Drawing.Size(33, 33);
            this.AdvisorCreate.TabIndex = 9;
            this.AdvisorCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.AdvisorCreate.UseVisualStyleBackColor = false;
            this.AdvisorCreate.Click += new System.EventHandler(this.AdvisorCreate_Click);
            // 
            // AdvisorDataGrid
            // 
            this.AdvisorDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdvisorDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AdvisorDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdvisorDataGrid.Location = new System.Drawing.Point(12, 77);
            this.AdvisorDataGrid.Name = "AdvisorDataGrid";
            this.AdvisorDataGrid.ReadOnly = true;
            this.AdvisorDataGrid.Size = new System.Drawing.Size(565, 353);
            this.AdvisorDataGrid.TabIndex = 8;
            this.AdvisorDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AdvisorDataGrid_CellContentClick);
            // 
            // AdvisorLabel
            // 
            this.AdvisorLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AdvisorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.AdvisorLabel.Location = new System.Drawing.Point(0, 0);
            this.AdvisorLabel.Name = "AdvisorLabel";
            this.AdvisorLabel.Size = new System.Drawing.Size(588, 49);
            this.AdvisorLabel.TabIndex = 7;
            this.AdvisorLabel.Text = "Advisor";
            this.AdvisorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Advisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 436);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchCategory);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.AdvisorCreate);
            this.Controls.Add(this.AdvisorDataGrid);
            this.Controls.Add(this.AdvisorLabel);
            this.Name = "Advisor";
            this.Text = "Advisor";
            ((System.ComponentModel.ISupportInitialize)(this.AdvisorDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ComboBox SearchCategory;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button AdvisorCreate;
        private System.Windows.Forms.DataGridView AdvisorDataGrid;
        private System.Windows.Forms.Label AdvisorLabel;
    }
}