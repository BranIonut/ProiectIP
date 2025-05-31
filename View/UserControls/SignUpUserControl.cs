/**************************************************************************
 *                                                                        *
 *  File:        SignUpUserControl.cs                                     *
 *  Copyright:   (c) 2025, Check & Drive                                  *
 *  E-mail:      checkandrive@chestionarauto.ro                           *
 *  Description: Metoda de signup a uzerului                              *
 *                                                                        *
 *  Această aplicație a fost realizată de patru studenți ai Facultății de *
 *  Automatică și Calculatoare, în cadrul materiei Ingineria Programării. *
 *  Este oferită ca software liber, conform licenței GNU GPL.             *
 *  Poate fi redistribuită și/sau modificată, dar fără nicio garanție,    *
 *  nici măcar pentru adecvarea la un scop anume.                         *
 *                                                                        *
 **************************************************************************/

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

        /// <summary>
        /// Apelată atunci când se dorește redirecționarea către pagina de autentificare a utilizatorului.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void goToLogInPanelLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginRequested?.Invoke(this, e);
        }

        /// <summary>
        /// Apelată când se dorește înregistrarea utilizatorului.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string username = textBox3.Text.Trim();
                string name = textBox4.Text.Trim();
                string email = textBox5.Text.Trim();
                string password = textBox6.Text;

                // Validări locale înainte de a trimite la presenter
                List<string> errors = new List<string>();

                if (string.IsNullOrWhiteSpace(username) || username.Length < 3)
                    errors.Add("• Username-ul trebuie să aibă minim 3 caractere");

                if (string.IsNullOrWhiteSpace(name))
                    errors.Add("• Numele complet este obligatoriu");

                if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
                    errors.Add("• Email-ul trebuie să fie valid");

                if (string.IsNullOrWhiteSpace(password) || password.Length < 8)
                    errors.Add("• Parola trebuie să aibă minim 8 caractere");

                if (errors.Count > 0)
                {
                    MessageBox.Show("Vă rugăm corectați următoarele erori:\n\n" + string.Join("\n", errors),
                        "Date invalide",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                SignupRequested?.Invoke(this, new SignupEventArgs(username, name, email, password));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la înregistrare: {ex.Message}",
                    "Eroare",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Setarea vizibilității mesajului de eroare în cazul în care datele introduse pentru înregistrare sunt eronate.
        /// </summary>
        /// <param name="visible"></param>
        public void setErrorVisible(bool visible)
        {
            errorLabel.Visible = true;
            errorLabel.Visible = visible;
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, System.Environment.CurrentDirectory + "\\Help_ChestionarAuto.chm");
        }
    }
    /// <summary>
    /// Eveniment generat pentru operația de înregistrare utilizator.
    /// </summary>
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
