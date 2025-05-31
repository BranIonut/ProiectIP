/**************************************************************************
 *                                                                        *
 *  File:        DashboardAdminControl.cs                                 *
 *  Copyright:   (c) 2025, Check & Drive                                  *
 *  E-mail:      checkandrive@chestionarauto.ro                           *
 *  Description: Inițializarea panoului de control al adminului           *
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
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChestionarAuto.UserControls
{
    public partial class DashboardAdminControl : UserControl
    {
        public event EventHandler UserPanelRequested;
        public event EventHandler<RemoveProgressEvent> RemoveUserProgressRequested;
        public event EventHandler<RemoveUserEvent> RemoveUserRequested;
        public event EventHandler<ChangeUserRoleEvent> ChangeUserRoleRequested;
        public event EventHandler<RemoveQuizEvent> RemoveQuizRequested;
        public event EventHandler CreateQuizRequested;
        private string _selectedUser;
        private string _selectedRole;
        private string _selectedQuiz;

        /// <summary>
        /// Constructor pentru inițializarea panoului de control al adminului.
        /// </summary>
        public DashboardAdminControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Funcție ce produce event de întoarcere la panel-ul utilizatorului.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void baskToUserPanelButton_Click(object sender, EventArgs e)
        {
            UserPanelRequested?.Invoke(this, e);  
        }

        /// <summary>
        /// Funcție ce populează lista cu utilizatorii aplicației, înregistrați în baza de date.
        /// </summary>
        /// <param name="users"></param>
        public void populateUsersList(Dictionary<string, string> users)
        {
            listView1.Items.Clear();
            listView1.Columns.Clear();

            listView1.View = System.Windows.Forms.View.Details;
            listView1.FullRowSelect = true;

            listView1.Columns.Add("No.", 40);
            listView1.Columns.Add("User", 150);
            listView1.Columns.Add("Role", 100);

            int index = 1;
            foreach (var kvp in users)
            {
                ListViewItem item = new ListViewItem(index.ToString());
                item.SubItems.Add(kvp.Key);
                item.SubItems.Add(kvp.Value);
                listView1.Items.Add(item);
                index++;
            }
        }

        /// <summary>
        /// Funcție ce populează lista cu quiz-urile create de aplicație și disponibile spre completare de către utilizatori.
        /// </summary>
        /// <param name="quizzes"></param>
        public void populateQuizzesList(List<string> quizzes)
        {

            listView2.Items.Clear();
            listView2.Columns.Clear();

            listView2.View = System.Windows.Forms.View.Details;
            listView2.FullRowSelect = true;


            listView2.Columns.Add("Quiz number", 180);

            foreach (var quiz in quizzes)
            {

                listView2.Items.Add(new ListViewItem(quiz));
            }
        }

        /// <summary>
        /// Apelată atunci când un utilizator din listă este selectat.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                _selectedUser = null;
                _selectedRole = null;
                return;
            }

            var item = listView1.SelectedItems[0];
            _selectedUser = item.SubItems[1].Text;
            _selectedRole = item.SubItems[2].Text;
        }

        /// <summary>
        /// Apelată atunci când un quiz din listă este selectat.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count == 0)
            {
                _selectedQuiz = null;
                return;
            }

            _selectedQuiz = listView2.SelectedItems[0].Text;
        }

        /// <summary>
        /// Returnează utilizatorul selectat din listă.
        /// </summary>
        /// <returns>Pereche cheie (username) și valoare (rol).</returns>
        public KeyValuePair<string, string> SelectedUser()
        {
            return new KeyValuePair<string, string>(_selectedUser, _selectedRole);
        }

        /// <summary>
        /// Returnează quiz-ul selectat din listă.
        /// </summary>
        /// <returns>String reprezentând numele quiz-ului.</returns>
        public string SelectedQuiz()
        {
            return _selectedQuiz;
        }

        /// <summary>
        /// Apelată atunci când se dorește resetarea progresului utilizatorului selectat.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetUserProgButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(_selectedUser))
                {
                    MessageBox.Show("Vă rugăm selectați un utilizator din listă!",
                        "Niciun utilizator selectat",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
                DialogResult result = MessageBox.Show(
            $"Sigur doriți să resetați progresul utilizatorului '{_selectedUser}'?\n\n",
            "Confirmare resetare progres",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    RemoveUserProgressRequested?.Invoke(this, new RemoveProgressEvent(_selectedUser));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la resetarea progresului utilizatorului: {ex.Message}",
                    "Eroare",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Apelată atunci când se dorește eliminarea unui utiizator din lista utilizatorilor înregistrați.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(_selectedUser))
                {
                    MessageBox.Show("Va rugam selectati un user din lista");
                    return;
                }

                RemoveUserRequested?.Invoke(this, new RemoveUserEvent(_selectedUser));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la eliminarea utilizatorului: {ex.Message}");
            }
        }

        /// <summary>
        /// Apelată atunci când se dorește schimbarea rolului curent al utilizatorului selectat.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void changeRoleButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(_selectedUser))
                {
                    MessageBox.Show("Va rugam selectati un user din lista");
                }
                string newRole = _selectedRole == "admin" ? "user" : "admin";

                ChangeUserRoleRequested?.Invoke(this, new ChangeUserRoleEvent(_selectedUser, newRole));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la schimbarea rolului utilizatorului: {ex.Message}",
                    "Eroare",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Apelată atunci când se dorește adăugarea unui nou quiz în lista celor existente deja.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createQuizButton_Click(object sender, EventArgs e)
        {
            try
            {
                CreateQuizRequested?.Invoke(this, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la crearea quiz-ului: {ex.Message}",
                    "Eroare",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Apelată atunci când se dorește ștergerea unui quiz selectat din cele existente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeQuizButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(_selectedQuiz))
                {
                    MessageBox.Show("Vă rugăm selectați un quiz din listă!",
                        "Niciun quiz selectat",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
                 RemoveQuizRequested?.Invoke(this, new RemoveQuizEvent(_selectedQuiz));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la ștergerea quiz-ului: {ex.Message}",
                    "Eroare",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void helpAdminButton_Click(object sender, EventArgs e)
        {
            string helpPath = Path.Combine(Application.StartupPath, "ChestionarAuto_API.chm");
            if (File.Exists(helpPath))
            {
                Help.ShowHelp(this, helpPath);
            }
            else
            {
                MessageBox.Show("Documentația API nu a fost găsită!");
            }
        }
    }
    /// <summary>
    /// Event pentru resetarea progresului.
    /// </summary>
    public class RemoveProgressEvent : EventArgs
    {
        public string Username { get; }

        public RemoveProgressEvent(string username)
        {
            Username = username;
        }
    }

    /// <summary>
    /// Event pentru eliminarea utilizatorului.
    /// </summary>
    public class RemoveUserEvent : EventArgs
    {
        public string Username { get; }

        public RemoveUserEvent(string username)
        {
            Username = username;
        }
    }

    /// <summary>
    /// Event peentru schimbarea rolului utilizatorului.
    /// </summary>
    public class ChangeUserRoleEvent : EventArgs
    {
        public string Username { get; }
        public string Role { get; }

        public ChangeUserRoleEvent(string username, string role)
        {
            Username = username;
            Role = role;
        }
    }

    /// <summary>
    /// Event pentru eliminarea quiz-ului selectat.
    /// </summary>
    public class RemoveQuizEvent : EventArgs
    {
        public string Quiz { get; }

        public RemoveQuizEvent(string quiz)
        {
            Quiz = quiz;
        }
    }
}
