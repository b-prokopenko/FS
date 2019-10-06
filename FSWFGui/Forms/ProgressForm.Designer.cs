﻿namespace FSWFGui.Forms
{
    partial class ProgressForm
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
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.ReadyTotal = new System.Windows.Forms.Label();
            this.InProgress = new System.Windows.Forms.Label();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(12, 12);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(356, 23);
            this.progressBar.TabIndex = 0;
            // 
            // ReadyTotal
            // 
            this.ReadyTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReadyTotal.AutoSize = true;
            this.ReadyTotal.Location = new System.Drawing.Point(344, 38);
            this.ReadyTotal.Name = "ReadyTotal";
            this.ReadyTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ReadyTotal.Size = new System.Drawing.Size(24, 13);
            this.ReadyTotal.TabIndex = 1;
            this.ReadyTotal.Text = "0/0";
            this.ReadyTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // InProgress
            // 
            this.InProgress.AutoSize = true;
            this.InProgress.Location = new System.Drawing.Point(12, 42);
            this.InProgress.Name = "InProgress";
            this.InProgress.Size = new System.Drawing.Size(0, 13);
            this.InProgress.TabIndex = 2;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorker_ProgressChanged);
            // 
            // ProgressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 88);
            this.Controls.Add(this.InProgress);
            this.Controls.Add(this.ReadyTotal);
            this.Controls.Add(this.progressBar);
            this.Name = "ProgressForm";
            this.Text = "ProgressForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label ReadyTotal;
        private System.Windows.Forms.Label InProgress;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}