using System.Windows.Forms;

namespace FSWFGui.Forms
{
    public partial class ProgressForm : Form
    {
        public ProgressForm()
        {
            InitializeComponent();
        }

        public void UpdateReadyTotalField()
        {
            ReadyTotal.Text = $"Copied {progressBar.Value} of {progressBar.Maximum}";
        }
    }
}
