using FSCoreLibrary.Interfaces;
using System;
using System.Threading;
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
            ReadyTotal.Text = $"{progressBar.Value}/{progressBar.Maximum}";

        }

        private void HandleReady(object sender, int e)
        {
            backgroundWorker.ReportProgress(e);
        }

        public void gogog()
        {
            int i = 1;
            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.RunWorkerAsync(i);
            while (backgroundWorker.IsBusy)
            {
                Thread.Sleep(3);
                backgroundWorker.ReportProgress(Service.Ready);
            }

        }

        private void BackgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            Service.Sort(Params);
        }

        private void BackgroundWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            progressBar.Update();
        }
    }
}
