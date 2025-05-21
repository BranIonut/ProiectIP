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
        public event EventHandler DashBoardRequested;

        public LogInUserControl()
        {
            InitializeComponent();
        }

        private void goToSignupLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpRequested?.Invoke(this, e); // Notifica Form1
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = this.textBox1.Text;
            string password = this.textBox2.Text;

            if(username == "admin" && password == "admin")
            {
                DashBoardRequested?.Invoke(this, e);
            }
        }
    }
}
