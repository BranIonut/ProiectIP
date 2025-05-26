using ChestionarAuto.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChestionarAuto
{
    /// <summary>
    /// Clasa View implementează interfața IView și este responsabilă pentru interacțiunea cu utilizatorul.
    /// </summary>
    public class View : IView
    {
        private Form1 _form;
        private IPresenter presenter;
        private QuizControl quizControl;

        /// <summary>
        /// Constructorul clasei View.
        /// </summary>
        /// <param name="form">Formularul principal al aplicației.</param>
        public View(Form1 form)
        {
            _form = form;
        }

        /// <summary>
        /// Setează presenter-ul pentru View.
        /// </summary>
        /// <param name="presenter">Obiectul presenter care conține logica aplicației.</param>
        public void SetPresenter(IPresenter presenter)
        {
            this.presenter = presenter;
        }

        /// <summary>
        /// Încarcă controlul de autentificare (LogInUserControl) în formular.
        /// </summary>
        public void LoadLoginControl()
        {
            var loginControl = new LogInUserControl();
            loginControl.LoginRequested += (s, e) => presenter.OnLoginRequest(e.Username, e.Password);
            loginControl.SignUpRequested += (s, e) => LoadSignupControl();
            _form.LoadUserControl(loginControl);
        }

        /// <summary>
        /// Încarcă controlul de înregistrare (SignUpUserControl) în formular.
        /// </summary>
        public void LoadSignupControl()
        {
            var signupControl = new SignUpUserControl();
            signupControl.LoginRequested += (s, e) => LoadLoginControl();
            signupControl.SignupRequested += (s, e) => presenter.OnSignupRequest(e.Username, e.Name, e.Email, e.Password);
            _form.LoadUserControl(signupControl);
        }

        /// <summary>
        /// Încarcă controlul de tablă de bord pentru utilizator (DashboardUserControl) în formular.
        /// </summary>
        /// <param name="role">Parametru ce primește rolul utilizatorului curent logat (ex: "admin" sau "user").</param>
        public void LoadUserDashboardControl(string role)
        {
            var dashboardUserControl = new DashboardUserControl();

            dashboardUserControl.LogOutRequested += (s, e) => presenter.OnLogoutRequest();
            dashboardUserControl.AdminDashBoardRequested += (s, e) => this.LoadAdminDashboardControl();
            dashboardUserControl.StartQuizRequested += (s, e) => this.StartQuizControl();
            this.LoadUserHistory(dashboardUserControl);
            if (role == "admin")
            {
                dashboardUserControl.SetAdminDashBttnVisibility(false);
                dashboardUserControl.SetAdminDashBttnVisibility(true);
            }
            else if (role == "user")
            {
                dashboardUserControl.SetAdminDashBttnVisibility(false);
            }
            //dashboardUserControl.SetAdminDashBttnVisibility(true);
            _form.LoadUserControl(dashboardUserControl);
        }

        /// <summary>
        /// Încarcă controlul de tablă de bord pentru administrator (DashboardAdminControl) în formular.
        /// </summary>
        public void LoadAdminDashboardControl()
        {
            var dashboardAdminControl = new DashboardAdminControl();
            dashboardAdminControl.UserPanelRequested += (s, e) => LoadUserDashboardControl("admin");
            _form.LoadUserControl(dashboardAdminControl);
        }

        /// <summary>
        /// Inițiază controlul de quiz (QuizControl) și îl încarcă în formular.
        /// </summary>
        public void StartQuizControl()
        {
            quizControl = new QuizControl();

            quizControl.NextQuestionClicked += (s, e) => presenter.OnNextQuestion(e.SelectedAnswers);
            quizControl.AbortQuizClicked += (s, e) => this.AbortQuiz();
            quizControl.FailedQuiz += (s, e) => this.FailQuiz();

            _form.LoadUserControl(quizControl);
            quizControl.UpdateUI(0, 0);
            quizControl.StartGlobalTimer();
            presenter.OnStartQuiz();
        }

        /// <summary>
        /// Afișează o întrebare în controlul de quiz.
        /// </summary>
        /// <param name="question">Întrebarea ce urmează să fie afișată.</param>
        /// <param name="isLastQuestion">Indică dacă întrebarea este ultima din quiz.</param>
        public void ShowQuestion(Question question, bool isLastQuestion = false)
        {
            quizControl.LoadQuestion(question, isLastQuestion);
        }

        /// <summary>
        /// Afișează rezultatele quiz-ului și navighează înapoi la meniul principal.
        /// </summary>
        /// <param name="_quiz">Obiectul de tip Quiz care conține rezultatele quiz-ului (răspunsuri corecte, greșite, stare).</param>
        public void ShowQuizResults(Quiz _quiz)
        {
            quizControl.ShowQuizResults(_quiz.correctAnswers, _quiz.wrongAnswers, _quiz.quizState);
            presenter.GoToMainMenu();
        }

        /// <summary>
        /// Actualizează interfața utilizatorului cu numărul de răspunsuri corecte și greșite.
        /// </summary>
        /// <param name="correctAnswers">Numărul de răspunsuri corecte.</param>
        /// <param name="wrongAnswers">Numărul de răspunsuri greșite.</param>
        public void UpdateUI(int correctAnswers, int wrongAnswers)
        {
            quizControl.UpdateUI(correctAnswers, wrongAnswers);
        }

        public void AbortQuiz()
        {
            quizControl.StopTimer();
            presenter.OnAbortQuiz();
        }

        public void FailQuiz()
        {
            quizControl.StopTimer();
            presenter.OnFailQuiz();
        }

        public void PassQuiz()
        {
            quizControl.StopTimer();
            presenter.OnPassQuiz();
        }

        private void LoadUserHistory(DashboardUserControl dashboardUserControl)
        {
            List<Quiz> quizList = presenter.OnLoadUserHistory();
            int index = 0;
            while(index < quizList.Count)
            {
                dashboardUserControl.UpdateUserHistoryUI(index, quizList[index].correctAnswers, quizList[index].wrongAnswers,
                     quizList[index].quizState);
                index++;
            }
        }
    }
}
