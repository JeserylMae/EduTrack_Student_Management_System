using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Views
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        public void ShowForm() => this.Show();
        public void CloseForm() { this.Show(); this.Dispose(); }

        public Form FormMdiParent
        {
            set => this.MdiParent = value;
        }
    }
}
