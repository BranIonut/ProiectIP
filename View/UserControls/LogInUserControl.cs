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

        /// <summary>
        /// Apelată atunci când se dorește redirecționarea către pagina de înregistrare utilizator.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void goToSignupLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpRequested?.Invoke(this, e); // Notifica Form1
        }

        /// <summary>
        /// Apelată atunci când se dorește autentificarea utilizatorului.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            LoginRequested?.Invoke(this, new LoginEventArgs(username, password));
        }

        /// <summary>
        /// Setarea vizibilității pe interfață a mesajului de eroare, în cazul în care datele introduse la autentificare au fost eronate.
        /// </summary>
        /// <param name="visible"></param>
        public void setErrorMessageVisible(bool visible)
        {
            loginFailedLbl.Visible = visible;
        }

        private void LogInUserControl_Load(object sender, EventArgs e)
        {

        }
    }

    /// <summary>
    /// Event generat la operația de autentificare.
    /// </summary>
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
