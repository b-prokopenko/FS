using FSWFGui.Forms;
using FSCoreLibrary.Interfaces;
using FSCoreLibrary;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.ComponentModel;
using System;

namespace FSWFGui
{
    class AppContext : ApplicationContext
    {
        private BackgroundWorker worker;
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
            Progress.gogog();

            //Task.Run(()=> {
            //    Service.Sort(Params);
            //});
            //worker.RunWorkerAsync();
        }
    }
}
