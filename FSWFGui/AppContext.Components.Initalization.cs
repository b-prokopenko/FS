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
        StartupForm StartupForm;
        ProgressForm ProgressForm;
        BackgroundWorker BackgroundWorker;
        public AppContext()
        {
            InitializeComponents();
            ConfigureComponents();
            RegisterEvents();

            StartupForm.Show();
        }
        private void InitializeComponents()
        {
            Service = FSCore.Service;
            StartupForm = new StartupForm();
            ProgressForm = new ProgressForm();
            BackgroundWorker = new BackgroundWorker();
        }
    }
}
