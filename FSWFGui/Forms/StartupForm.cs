using FSCoreLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FSWFGui.Forms
{
    public partial class StartupForm : Form
    {
        public event EventHandler<ISortParams> ParamsReady;
        public StartupForm()
        {
            InitializeComponent();
        }
    }
}
