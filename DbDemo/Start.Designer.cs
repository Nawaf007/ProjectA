namespace DbDemo
{
    partial class Start
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
            this.AdvisorLabel = new System.Windows.Forms.Label();
            this.StuButton = new System.Windows.Forms.Button();
            this.AdButton = new System.Windows.Forms.Button();
            this.ProjButton = new System.Windows.Forms.Button();
            this.EvButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AdvisorLabel
            // 
            this.AdvisorLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AdvisorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.AdvisorLabel.Location = new System.Drawing.Point(0, 0);
            this.AdvisorLabel.Name = "AdvisorLabel";
            this.AdvisorLabel.Size = new System.Drawing.Size(284, 49);
            this.AdvisorLabel.TabIndex = 8;
            this.AdvisorLabel.Text = "Temp Main Page";
            this.AdvisorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StuButton
            // 
            this.StuButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StuButton.Location = new System.Drawing.Point(86, 72);
            this.StuButton.Name = "StuButton";
            this.StuButton.Size = new System.Drawing.Size(108, 25);
            this.StuButton.TabIndex = 9;
            this.StuButton.Text = "Students";
            this.StuButton.UseVisualStyleBackColor = true;
            this.StuButton.Click += new System.EventHandler(this.StuButton_Click);
            // 
            // AdButton
            // 
            this.AdButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdButton.Location = new System.Drawing.Point(86, 113);
            this.AdButton.Name = "AdButton";
            this.AdButton.Size = new System.Drawing.Size(108, 25);
            this.AdButton.TabIndex = 10;
            this.AdButton.Text = "Advisor";
            this.AdButton.UseVisualStyleBackColor = true;
            this.AdButton.Click += new System.EventHandler(this.AdButton_Click);
            // 
            // ProjButton
            // 
            this.ProjButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProjButton.Location = new System.Drawing.Point(86, 159);
            this.ProjButton.Name = "ProjButton";
            this.ProjButton.Size = new System.Drawing.Size(108, 25);
            this.ProjButton.TabIndex = 11;
            this.ProjButton.Text = "Project";
            this.ProjButton.UseVisualStyleBackColor = true;
            this.ProjButton.Click += new System.EventHandler(this.ProjButton_Click);
            // 
            // EvButton
            // 
            this.EvButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EvButton.Location = new System.Drawing.Point(86, 204);
            this.EvButton.Name = "EvButton";
            this.EvButton.Size = new System.Drawing.Size(108, 25);
            this.EvButton.TabIndex = 12;
            this.EvButton.Text = "Evaluation";
            this.EvButton.UseVisualStyleBackColor = true;
            this.EvButton.Click += new System.EventHandler(this.EvButton_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.EvButton);
            this.Controls.Add(this.ProjButton);
            this.Controls.Add(this.AdButton);
            this.Controls.Add(this.StuButton);
            this.Controls.Add(this.AdvisorLabel);
            this.Name = "Start";
            this.Text = "Start";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label AdvisorLabel;
        private System.Windows.Forms.Button StuButton;
        private System.Windows.Forms.Button AdButton;
        private System.Windows.Forms.Button ProjButton;
        private System.Windows.Forms.Button EvButton;

    }
}