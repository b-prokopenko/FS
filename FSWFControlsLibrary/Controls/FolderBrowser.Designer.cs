namespace FSWFControlsLibrary.Controls
{
    partial class FolderBrowser
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FolderBrowser));
            this.textBox = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.fsButton = new FSWFControlsLibrary.Buttons.FSButton();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.Font = new System.Drawing.Font("Verdana", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.textBox.ForeColor = System.Drawing.Color.Black;
            this.textBox.Location = new System.Drawing.Point(3, 3);
            this.textBox.MaximumSize = new System.Drawing.Size(0, 24);
            this.textBox.MinimumSize = new System.Drawing.Size(131, 24);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(131, 24);
            this.textBox.TabIndex = 1;
            this.textBox.Text = "Path";
            this.textBox.WordWrap = false;
            // 
            // fsButton
            // 
            this.fsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fsButton.BackColor = System.Drawing.Color.Transparent;
            this.fsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fsButton.BackgroundImage")));
            this.fsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fsButton.Location = new System.Drawing.Point(137, 3);
            this.fsButton.MaximumSize = new System.Drawing.Size(30, 21);
            this.fsButton.MinimumSize = new System.Drawing.Size(30, 21);
            this.fsButton.Name = "fsButton";
            this.fsButton.Size = new System.Drawing.Size(30, 21);
            this.fsButton.TabIndex = 0;
            this.fsButton.Click += new System.EventHandler(this.SelectPath);
            // 
            // FolderBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.fsButton);
            this.Name = "FolderBrowser";
            this.Size = new System.Drawing.Size(167, 24);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Buttons.FSButton fsButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        public System.Windows.Forms.TextBox textBox;
    }
}
