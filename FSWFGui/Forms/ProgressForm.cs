using FSCoreLibrary.Interfaces;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FSWFGui.Forms
{
    public partial class ProgressForm : Form
    {
        ISortService Service;
        ISortParams Params;
        public ProgressForm(ISortService service, ISortParams p)
        {
            InitializeComponent();
            Service = service;
            Params = p;
        }

        public void Start()
        {
            Service.PrepareTasks(Params);
            progressBar.Maximum = Service.Tasks.Count;
            UpdateReadyTotalField();
            backgroundWorker.RunWorkerAsync();
        }

        private void BackgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            int total = Service.Tasks.Count;
            for (int i = 0; i < total; i++)
            {
                if (backgroundWorker.CancellationPending)
                {
                    e.Cancel = true;
                    backgroundWorker.ReportProgress(i);
                    break;
                }
                Service.Tasks[i].Start();
                Service.Tasks[i].Wait();
                int filesCopied = i + 1;
                backgroundWorker.ReportProgress(filesCopied);
            }
        }

        private void BackgroundWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            progressBar.Update();
            UpdateReadyTotalField();
            UpdateReadyTotalField();
        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            DialogResult result;
            if (e.Cancelled)
                result = MessageBox.Show("Operation was canceled.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                result = MessageBox.Show("The work has been completed", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
                this.Close();
        }

        private void UpdateReadyTotalField()
        {
            ReadyTotal.Text = $"Copied {progressBar.Value} of {progressBar.Maximum}";
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if (backgroundWorker.WorkerSupportsCancellation == true)
            {
                backgroundWorker.CancelAsync();
            }
        }
    }
}
