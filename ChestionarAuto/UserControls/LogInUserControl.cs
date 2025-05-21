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
    public partial class LogInUserControl : UserControl
    {

        public event EventHandler SignUpRequested;
        public LogInUserControl()
        {
            InitializeComponent();
        }

        private void goToSignupLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpRequested?.Invoke(this, e); // Notifica Form1
        }
    }
}
