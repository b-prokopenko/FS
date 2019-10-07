namespace FSWFGui
{
    partial class AppContext
    {
        private void RegisterEvents()
        {
            StartupForm.ParamsReady += CloseStartupForm;
            StartupForm.ParamsReady += PrepareBackgroundWork;
            StartupForm.ParamsReady += UpdateProgressForm;
            StartupForm.ParamsReady += ShowProgressForm;
            StartupForm.ParamsReady += RunBackgroundWorker;
            StartupForm.FormClosed += OnFormClosed;

            BackgroundWorker.DoWork += OnBackgroundWork;
            BackgroundWorker.ProgressChanged += OnBackgroundProgressChanged;
            BackgroundWorker.RunWorkerCompleted += OnBackgroundWorkCompleted;

            ProgressForm.btnCancel.Click += OnProgressCancel;
            ProgressForm.FormClosed += OnFormClosed;
        }

    }
}
