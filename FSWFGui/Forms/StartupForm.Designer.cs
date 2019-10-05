namespace FSWFGui.Forms
{
    partial class StartupForm
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
            this.SourceSelector = new FSWFControlsLibrary.Controls.FolderBrowser();
            this.TargetSelector = new FSWFControlsLibrary.Controls.FolderBrowser();
            this.StartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SourceSelector
            // 
            this.SourceSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SourceSelector.BackColor = System.Drawing.Color.Transparent;
            this.SourceSelector.Location = new System.Drawing.Point(12, 12);
            this.SourceSelector.Name = "SourceSelector";
            this.SourceSelector.Size = new System.Drawing.Size(179, 24);
            this.SourceSelector.TabIndex = 0;
            this.SourceSelector.textBox.Text = "Source folder";
            this.SourceSelector.textBox.TextChanged += this.SourceFolderSelected;
            // 
            // TargetSelector
            // 
            this.TargetSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TargetSelector.BackColor = System.Drawing.Color.Transparent;
            this.TargetSelector.Location = new System.Drawing.Point(12, 42);
            this.TargetSelector.Name = "TargetSelector";
            this.TargetSelector.Size = new System.Drawing.Size(179, 24);
            this.TargetSelector.TabIndex = 1;
            this.TargetSelector.textBox.Text = "Target folder";
            this.TargetSelector.textBox.TextChanged += this.TargetFolderSelected;
            // 
            // StartButton
            // 
            this.StartButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.StartButton.Enabled = false;
            this.StartButton.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(65, 72);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "Sort";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButtonClick);
            // 
            // StartupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(204, 111);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.TargetSelector);
            this.Controls.Add(this.SourceSelector);
            this.MaximumSize = new System.Drawing.Size(220, 150);
            this.MinimumSize = new System.Drawing.Size(220, 150);
            this.Name = "StartupForm";
            this.Text = "FS";
            this.ResumeLayout(false);

        }

        #endregion

        private FSWFControlsLibrary.Controls.FolderBrowser SourceSelector;
        private FSWFControlsLibrary.Controls.FolderBrowser TargetSelector;
        private System.Windows.Forms.Button StartButton;
    }
}