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
        public AppContext()
        {
            Service = FSCore.Service;
            Startup = new StartupForm();
            Progress = new ProgressForm();
            Startup.ParamsReady += SortFiles;
            MainForm = Startup;
        }

        private void SortFiles(object sender, ISortParams e)
        {
            Service.Sort(e);
        }
    }
}
