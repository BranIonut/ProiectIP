using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChestionarAuto.UserControls
{
    public partial class DashboardUserControl : UserControl
    {
        public event EventHandler LogOutRequested;
        public event EventHandler AdminDashBoardRequested;
        public event EventHandler StartQuizRequested;

        public DashboardUserControl()
        {
            InitializeComponent();
            SetupQuizHistoryListView();
        }

        /// <summary>
        /// Actualizarea mesajului de întâmpinare pentru utilizatorul autentificat.
        /// </summary>
        /// <param name="username">Username-ul utilizatorului curent.</param>
        public void SetWelcomeMessage(string username)
        {
            welcomeBackLabel.Text = "Welcome back, " + username + "!";
        }

        /// <summary>
        /// Apelată atunci când se dorește deconectarea utilizatorului curent autentificat.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void logOutButton_Click(object sender, EventArgs e)
        {
            LogOutRequested?.Invoke(this, EventArgs.Empty);
           
        }

        /// <summary>
        /// Apelată atunci când utilizatorul cu rol de administrator dorește redirecționarea către panel-ul de admin.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void adminDashButton_Click(object sender, EventArgs e)
        {
            AdminDashBoardRequested?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Apelată atunci când se dorește începerea rezolvării unui quiz de către utilizatorul curent.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startQuizButton_Click(object sender, EventArgs e)
        {
            StartQuizRequested?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Inițializează lista în care se încarcă ulterior istoricul și progresul utilizatorului curent.
        /// </summary>
        public void SetupQuizHistoryListView()
        {
            userQuizHistoryList.View = System.Windows.Forms.View.Details;
            userQuizHistoryList.Columns.Add("Quiz", 150);
            userQuizHistoryList.Columns.Add("Corecte", 105);
            userQuizHistoryList.Columns.Add("Greșite", 105);
            userQuizHistoryList.Columns.Add("Stare", 200);
            userQuizHistoryList.FullRowSelect = true;
        }

        /// <summary>
        /// Actualizează lista de istoric de completări ale quiz-urilor.
        /// </summary>
        /// <param name="labelIndex"></param>
        /// <param name="correctAnswers"></param>
        /// <param name="wrongAnswers"></param>
        /// <param name="quiz_state"></param>
        public void UpdateUserHistoryUI(int labelIndex, int correctAnswers, int wrongAnswers, string quiz_state)
        {

            if (userQuizHistoryList.View != System.Windows.Forms.View.Details)
            {
                userQuizHistoryList.View = System.Windows.Forms.View.Details;
            }

            string quizName = $"Quiz #{labelIndex + 1}";

            ListViewItem item = new ListViewItem(quizName);
            item.SubItems.Add(correctAnswers.ToString());
            item.SubItems.Add(wrongAnswers.ToString());
            item.SubItems.Add(quiz_state);

            if (labelIndex < userQuizHistoryList.Items.Count)
            {
                userQuizHistoryList.Items[labelIndex] = item;
            }
            else 
            {
                userQuizHistoryList.Items.Add(item);
            }
        }
    }
}
