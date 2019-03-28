namespace DbDemo
{
    partial class ProjectGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectGroup));
            this.GroupCreate = new System.Windows.Forms.Button();
            this.AdvisorDataGrid = new System.Windows.Forms.DataGridView();
            this.GroupLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AdvisorDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupCreate
            // 
            this.GroupCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupCreate.BackColor = System.Drawing.Color.White;
            this.GroupCreate.Image = ((System.Drawing.Image)(resources.GetObject("GroupCreate.Image")));
            this.GroupCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GroupCreate.Location = new System.Drawing.Point(572, 39);
            this.GroupCreate.Name = "GroupCreate";
            this.GroupCreate.Size = new System.Drawing.Size(33, 33);
            this.GroupCreate.TabIndex = 12;
            this.GroupCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.GroupCreate.UseVisualStyleBackColor = false;
            this.GroupCreate.Click += new System.EventHandler(this.AdvisorCreate_Click);
            // 
            // AdvisorDataGrid
            // 
            this.AdvisorDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdvisorDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AdvisorDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdvisorDataGrid.Location = new System.Drawing.Point(12, 78);
            this.AdvisorDataGrid.Name = "AdvisorDataGrid";
            this.AdvisorDataGrid.ReadOnly = true;
            this.AdvisorDataGrid.Size = new System.Drawing.Size(593, 343);
            this.AdvisorDataGrid.TabIndex = 11;
            // 
            // GroupLabel
            // 
            this.GroupLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.GroupLabel.Location = new System.Drawing.Point(0, 0);
            this.GroupLabel.Name = "GroupLabel";
            this.GroupLabel.Size = new System.Drawing.Size(616, 49);
            this.GroupLabel.TabIndex = 10;
            this.GroupLabel.Text = "Group";
            this.GroupLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProjectGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 433);
            this.Controls.Add(this.GroupCreate);
            this.Controls.Add(this.AdvisorDataGrid);
            this.Controls.Add(this.GroupLabel);
            this.Name = "ProjectGroup";
            this.Text = "Group";
            ((System.ComponentModel.ISupportInitialize)(this.AdvisorDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GroupCreate;
        private System.Windows.Forms.DataGridView AdvisorDataGrid;
        private System.Windows.Forms.Label GroupLabel;
    }
}