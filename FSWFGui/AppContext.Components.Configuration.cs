namespace FSWFGui
{
    partial class AppContext
    {
        private void ConfigureComponents()
        {
            BackgroundWorker.WorkerReportsProgress = true;
            BackgroundWorker.WorkerSupportsCancellation = true;
        }
    }
}
