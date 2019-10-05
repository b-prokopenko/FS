using FSCoreLibrary.Interfaces;
using FSWFGui.Entities;
using System;
using System.Windows.Forms;

namespace FSWFGui.Forms
{
    public partial class StartupForm : Form
    {
        public event EventHandler<ISortParams> ParamsReady;
        private event EventHandler PathSelected;
        SortParams SortParams = new SortParams();
        public StartupForm()
        {
            InitializeComponent();
            PathSelected += CheckParams;
        }

        private void SourceFolderSelected(object sender, EventArgs e)
        {
            SortParams.SourceFolder = SourceSelector.textBox.Text;
            PathSelected?.Invoke(this, new EventArgs());
        }

        private void TargetFolderSelected(object sender, EventArgs e)
        {
            SortParams.TargetFolder = TargetSelector.textBox.Text;
            PathSelected?.Invoke(this, new EventArgs());
        }

        private void CheckParams(object sender, EventArgs e)
        {
            if (SortParams.IsReady())
                StartButton.Enabled = true;
        }

        private void StartButtonClick(object sender, EventArgs e)
        {
            ParamsReady?.Invoke(this, SortParams);
        }
    }
}
