using FSCoreLibrary;
using FSCoreLibrary.Interfaces;
using FSWFGui.Forms;
using System.ComponentModel;
using System.Windows.Forms;

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
