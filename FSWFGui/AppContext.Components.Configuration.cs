namespace FSWFGui
{
    partial class AppContext
    {
        private void ConfigureComponents()
        {
            Worker.WorkerReportsProgress = true;
            Worker.WorkerSupportsCancellation = true;
        }
    }
}
