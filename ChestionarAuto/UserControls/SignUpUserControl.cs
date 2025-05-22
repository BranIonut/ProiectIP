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
        public event EventHandler<SignupEventArgs> SignupRequested;
        public SignUpUserControl()
        {
            InitializeComponent();
        }

        private void goToLogInPanelLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginRequested?.Invoke(this, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox3.Text;
            string name = textBox4.Text;
            string email = textBox5.Text;
            string password = textBox6.Text;
            SignupRequested?.Invoke(this, new SignupEventArgs(username, name, email, password));
        }
    }
    public class SignupEventArgs : EventArgs
    {
        public string Username { get; }
        public string Name { get; }
        public string Email { get; }
        public string Password { get; }

        public SignupEventArgs(string username, string name, string email, string password)
        {
            Username = username;
            Name = name;
            Email = email;
            Password = password;
        }
    }
}
