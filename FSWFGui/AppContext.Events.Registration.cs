namespace FSWFGui
{
    partial class AppContext
    {
        private void RegisterEvents()
        {
            Startup.ParamsReady += CloseStartupForm;
            Startup.ParamsReady += PrepareBackgroundWork;
            Startup.ParamsReady += UpdateProgressForm;
            Startup.ParamsReady += ShowProgressForm;
            Startup.ParamsReady += RunBackgroundWorker;

            Worker.DoWork += OnBackgroundWork;
            Worker.ProgressChanged += OnBackgroundProgressChanged;
            Worker.RunWorkerCompleted += OnBackgroundWorkCompleted;

            Progress.btnCancel.Click += OnProgressCancel;
            Progress.FormClosed += OnProgressFormClosed;
        }

    }
}
