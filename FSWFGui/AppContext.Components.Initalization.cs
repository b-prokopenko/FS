using FSCoreLibrary;
using FSWFGui.Forms;
using System.Windows.Forms;
using System.ComponentModel;
using FSCoreLibrary.Interfaces;


namespace FSWFGui
{
    partial class AppContext : ApplicationContext
    {
        ISortService Service;
        StartupForm Startup;
        ProgressForm Progress;
        BackgroundWorker Worker;
        public AppContext()
        {
            InitializeComponents();
            ConfigureComponents();
            RegisterEvents();

            Startup.Show();
        }
        private void InitializeComponents()
        {
            Service = FSCore.Service;
            Startup = new StartupForm();
            Progress = new ProgressForm();
            Worker = new BackgroundWorker();
        }
    }
}
