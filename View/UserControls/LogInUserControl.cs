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
        private IPresenter _presenter;
        public event EventHandler SignUpRequested;
        public event EventHandler<LoginEventArgs> LoginRequested;

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
            string username = textBox1.Text;
            string password = textBox2.Text;

            LoginRequested?.Invoke(this, new LoginEventArgs(username, password));
        }
    }

    public class LoginEventArgs : EventArgs
    {
        public string Username { get; }
        public string Password { get; }

        public LoginEventArgs(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
