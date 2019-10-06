using FSWFGui.Forms;
using FSCoreLibrary.Interfaces;
using FSCoreLibrary;
using System.Windows.Forms;

namespace FSWFGui
{
    class AppContext : ApplicationContext
    {
        ISortService Service;
        StartupForm Startup;
        ProgressForm Progress;
        ISortParams Params;
        public AppContext()
        {
            Service = FSCore.Service;
            Startup = new StartupForm();
            Startup.ParamsReady += SortFilesAsync;
            MainForm = Startup;
        }

        private void SortFilesAsync(object sender, ISortParams e)
        {
            Params = e;
            Progress = new ProgressForm(Service, e);

            MainForm.Hide();
            Progress.Show();
            Progress.Start();

            //Task.Run(()=> {
            //    Service.Sort(Params);
            //});
            //worker.RunWorkerAsync();
        }
    }
}
