using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChestionarAuto
{
    public partial class SignUpUserControl : UserControl
    {

        public event EventHandler LoginRequested;
        public SignUpUserControl()
        {
            InitializeComponent();
        }

        private void goToLogInPanelLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginRequested?.Invoke(this, e); // Notifica Form1
        }
    }
}
