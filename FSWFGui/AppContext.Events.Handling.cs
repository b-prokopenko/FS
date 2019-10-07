using System;
using System.Windows.Forms;
using System.ComponentModel;
using FSCoreLibrary.Interfaces;

namespace FSWFGui
{
    partial class AppContext
    {
        private void CloseStartupForm(object sender, ISortParams e)
        {
            StartupForm.Hide();
        }

        private void PrepareBackgroundWork(object sender, ISortParams e)
        {
            Service.PrepareTasks(e);
        }

        private void UpdateProgressForm(object sender, ISortParams e)
        {
            ProgressForm.progressBar.Maximum = Service.Tasks.Count;
            ProgressForm.progressBar.Update();
            ProgressForm.UpdateReadyTotalField();
        }

        private void ShowProgressForm(object sender, ISortParams e)
        {
            ProgressForm.Show();
        }

        private void RunBackgroundWorker(object sender, ISortParams e)
        {
            BackgroundWorker.RunWorkerAsync();
        }

        private void OnBackgroundWork(object sender, DoWorkEventArgs e)
        {
            int total = Service.Tasks.Count;
            for (int i = 0; i < total; i++)
            {
                if (BackgroundWorker.CancellationPending)
                {
                    e.Cancel = true;
                    BackgroundWorker.ReportProgress(i);
                    break;
                }
                Service.Tasks[i].Start();
                Service.Tasks[i].Wait();
                int filesCopied = i + 1;
                BackgroundWorker.ReportProgress(filesCopied);
            }
        }

        private void OnBackgroundProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ProgressForm.progressBar.Value = e.ProgressPercentage;
            ProgressForm.progressBar.Update();
            ProgressForm.UpdateReadyTotalField();
        }

        private void OnBackgroundWorkCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            DialogResult result;
            if (e.Cancelled)
                result = MessageBox.Show("Operation has been canceled.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                result = MessageBox.Show("The work has been completed.", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (result.Equals(DialogResult.OK))
                ProgressForm.Close();
        }

        private void OnProgressCancel(object sender, EventArgs e)
        {
            if (BackgroundWorker.WorkerSupportsCancellation)
                BackgroundWorker.CancelAsync();
        }

        private void OnProgressFormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
