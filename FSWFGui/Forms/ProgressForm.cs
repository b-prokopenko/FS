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
            backgroundWorker.RunWorkerAsync();
        }

        private void BackgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            int total = Service.Tasks.Count;
            for (int i = 0; i < total; i++)
            {
                if (backgroundWorker.CancellationPending)
                {
                    backgroundWorker.ReportProgress(0);
                    backgroundWorker.CancelAsync();
                }
                Service.Tasks[i].Start();
                Service.Tasks[i].Wait();
                int readyPercentage = i;
                backgroundWorker.ReportProgress(readyPercentage);
            }
        }

        private void BackgroundWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            progressBar.Update();
            UpdateReadyTotalField();
        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Work has been completed", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdateReadyTotalField()
        {
            ReadyTotal.Text = $"Copied {progressBar.Value} of {progressBar.Maximum}";
        }
    }
}
