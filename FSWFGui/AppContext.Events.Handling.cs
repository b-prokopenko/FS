using FSCoreLibrary.Interfaces;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace FSWFGui
{
    partial class AppContext
    {
        private void HideStartupForm(object sender, ISortParams e)
        {
            Startup.Hide();
        }

        private void PrepareBackgroundWork(object sender, ISortParams e)
        {
            Service.PrepareTasks(e);
        }

        private void UpdateProgressForm(object sender, ISortParams e)
        {
            Progress.progressBar.Maximum = Service.Tasks.Count;
            Progress.progressBar.Update();
            Progress.UpdateReadyTotalField();
        }

        private void ShowProgressForm(object sender, ISortParams e)
        {
            Progress.Show();
        }

        private void RunBackgroundWorker(object sender, ISortParams e)
        {
            Worker.RunWorkerAsync();
        }

        private void OnBackgroundWork(object sender, DoWorkEventArgs e)
        {
            int total = Service.Tasks.Count;
            for (int i = 0; i < total; i++)
            {
                if (Worker.CancellationPending)
                {
                    e.Cancel = true;
                    Worker.ReportProgress(i);
                    break;
                }
                Service.Tasks[i].Start();
                Service.Tasks[i].Wait();
                int filesCopied = i + 1;
                Worker.ReportProgress(filesCopied);
            }
        }

        private void OnBackgroundProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Progress.progressBar.Value = e.ProgressPercentage;
            Progress.progressBar.Update();
            Progress.UpdateReadyTotalField();
        }

        private void OnBackgroundWorkCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            DialogResult result;
            if (e.Cancelled)
                result = MessageBox.Show("Operation was canceled.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                result = MessageBox.Show("The work has been completed", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
                Progress.Close();
        }

        private void OnProgressCancel(object sender, EventArgs e)
        {
            if (Worker.WorkerSupportsCancellation)
                Worker.CancelAsync();
        }

        private void OnProgressFormClosed(object sender, FormClosedEventArgs e)
        {
            Startup.Show();
        }
    }
}
