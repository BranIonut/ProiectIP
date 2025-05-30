using ChestionarAuto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChestionarAuto
{
    /// <summary>
    /// Reprezintă un presenter care gestionează logica aplicației și interacțiunea dintre model și vizualizare.
    /// </summary>
    public class Presenter : IPresenter
    {
        private IModel _model;
        private IView _view;
        private List<Question> _questions;
        private Quiz _currentQuiz;
        private int currentQuestionIndex = 0;
        private int _currentWrongAnswers = 0;
        private QuizViewModel _quizViewModel;
        private QuizScoreObserver _quizScoreObserver;

        /// <summary>
        /// Constructorul clasei Presenter.
        /// </summary>
        /// <param name="model">Instanța modelului care gestionează logica aplicației și accesul la date.</param>
        /// <param name="view">Instanța interfeței view care gestionează interacțiunea cu utilizatorul.</param>
        public Presenter(IModel model, IView view)
        {
            _model = model;
            _view = view;

        }

        /// <summary>
        /// Metoda care este apelată atunci când utilizatorul solicită deconectarea.
        /// </summary>
        public void OnLogoutRequest()
        {
            _model.Logout();
            _view.LoadLoginControl(true);
        }

        /// <summary>
        /// Metoda care este apelată atunci când utilizatorul solicită autentificarea.
        /// </summary>
        /// <param name="username">Numele de utilizator ales de către utilizator pentru autentificare.</param>
        /// <param name="password">Parola aleasă de utilizator pentru contul său pentru autentificare.</param>
        public void OnLoginRequest(string username, string password)
        {
            bool success = false;
            success = _model.Login(username, password);

            if (success)
            { 
                _view.LoadUserDashboardControl(_model.GetLoggedUserRole());
            }
            else
            {
                _view.LoadLoginControl(false);
            }
        }

        /// <summary>
        /// Metoda care este apelată atunci când utilizatorul solicită înregistrarea unui nou cont.
        /// </summary>
        /// <param name="username">Numele de utilizator ales de către utilizator pentru autentificare.</param>
        /// <param name="name">Numele complet al utilizatorului.</param>
        /// <param name="email">Adresa de email a utilizatorului.</param>
        /// <param name="password">Parola aleasă de utilizator pentru contul său.</param>
        public bool OnSignupRequest(string username, string name, string email, string password)
        {
            bool success = false;
            success = _model.AddUser(username, name, email, password);
            if (success)
            {
                _view.LoadLoginControl(true);
            }
            else
            {
                _view.LoadSignupControl(false);
            }
            return success;
        }

        /// <summary>
        /// Metoda care este apelată atunci când utilizatorul solicită să înceapă un chestionar.
        /// </summary>
        public void OnStartQuiz()
        {
            _currentQuiz = _model.GetRandomQuiz();

            _currentQuiz.correctAnswers = 0;
            _currentQuiz.wrongAnswers = 0;
            _currentQuiz.quizState = "in progress";

            currentQuestionIndex = 0;
            _currentWrongAnswers = 0;

            _quizViewModel = new QuizViewModel(_currentQuiz);
            _quizScoreObserver = new QuizScoreObserver(_currentQuiz, _view);
            _quizViewModel.RegisterObserver(_quizScoreObserver);

            _questions = _currentQuiz.questionsList;
            var isLastQuestion = false;
            if(currentQuestionIndex == _questions.Count-1)
            {
                isLastQuestion = true;
            }
            _view.ShowQuestion(_questions[currentQuestionIndex], isLastQuestion);
        }

        /// <summary>
        /// Metoda care este apelată atunci când utilizatorul răspunde la o întrebare a chestionarului și trece la următoarea întrebare.
        /// </summary>
        /// <param name="selectedAnswers">Lista cu indicii variantelor de răspuns selectate de utilizator pentru întrebarea curentă.</param>
        public void OnNextQuestion(List<int> selectedAnswers)
        {

            if (_questions == null)
                return;

            _quizViewModel.AnswerQuestion(_questions[currentQuestionIndex].question, selectedAnswers);

            currentQuestionIndex++;

            if (currentQuestionIndex > _questions.Count - 1)
            {
                _currentQuiz.quizState = "completed";
                _view.ShowQuizResults(_currentQuiz);
                return;
            }
            
            var isLastQuestion = false;
            if (currentQuestionIndex == _questions.Count - 1)
            {
                isLastQuestion = true;
            }
            _view.ShowQuestion(_questions[currentQuestionIndex], isLastQuestion);
        }

        /// <summary>
        /// Metoda care este apelată atunci când utilizatorul decide să renunțe la chestionar.
        /// </summary>
        public void OnAbortQuiz()
        {
            _currentQuiz.quizState = "aborted";
            this.SaveInDatabase(_currentQuiz);
            _view.ShowQuizResults(_currentQuiz);
        }

        /// <summary>
        /// Metoda care este apelată pentru a naviga utilizatorul înapoi la meniul principal al aplicației.
        /// </summary>
        public void GoToMainMenu()
        {
            currentQuestionIndex = 0;
            _quizScoreObserver = null;
            _quizViewModel = null;
            _currentWrongAnswers = 0;
            _view.LoadUserDashboardControl(_model.GetLoggedUserRole());
        }

        /// <summary>
        /// Apelată în momentul eșuării completării unui quiz.
        /// </summary>
        public void OnFailQuiz()
        {
            this.SaveInDatabase(_currentQuiz);
            _view.ShowQuizResults(_currentQuiz);
        }

        /// <summary>
        /// Apelată în momentul completării unui quiz.
        /// </summary>
        public void OnPassQuiz()
        {
            this.SaveInDatabase(_currentQuiz);
            _view.ShowQuizResults(_currentQuiz);
        }

        /// <summary>
        /// Adăugare înregistrare nouă în baza de date, după încercarea utilizatorului de a completa un quiz.
        /// </summary>
        /// <param name="_quiz">Datele quiz-ului completat.</param>
        private void SaveInDatabase(Quiz _quiz)
        {
            _model.AddToUserQuiz(_quiz.Id, _model.GetCurrentUserId(), _quiz.correctAnswers, _quiz.wrongAnswers, _quiz.quizState);
        }

        /// <summary>
        /// Obține lista quiz-urilor completate de utilizator în trecut.
        /// </summary>
        /// <returns></returns>
        public List<Quiz> OnLoadUserHistory()
        {
            int currentUserId = _model.GetCurrentUserId();
            List<Quiz> quizList = _model.GetLastTenQuizes(currentUserId);
            return quizList;
        }

        /// <summary>
        /// Obține lista de utilizatori înregistrați.
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, string> GetUsers()
        {
            return _model.GetUsers();
        }

        /// <summary>
        /// Obține lista de quiz-uri disponibile în aplicație.
        /// </summary>
        /// <returns></returns>
        public List<string> GetQuizzes()
        {
            return _model.GetQuizzes();
        }

        /// <summary>
        /// Elimină utilizatorul selectat.
        /// </summary>
        /// <param name="username">username-ul utilizatorului</param>
        /// <returns></returns>
        public bool OnRemoveUser(string username)
        {
            return _model.RemoveUser(username); 
        }

        /// <summary>
        /// Șterge progresul utilizatorului selectat.
        /// </summary>
        /// <param name="username">username-ul utilizatorului</param>
        /// <returns></returns>
        public bool OnDeleteUserProgress(string username)
        {
            return _model.UserResetProgress(username);
        }

        /// <summary>
        /// Schimbă rolul utilizatorului selectat.
        /// </summary>
        /// <param name="username">username-ul utilizatorului</param>
        /// <param name="role">rolul curent</param>
        /// <returns></returns>
        public bool OnChangeUserRole(string username, string role)
        {
            return _model.ChangeUserRole(username, role);
        }

        /// <summary>
        /// Elimină quiz-ul selectat.
        /// </summary>
        /// <param name="id">ID-ul quiz-ului selectat.</param>
        /// <returns></returns>
        public bool OnRemoveQuiz(int id)
        {
            if (id == null)
            {
                return false;
            }
            return _model.DeleteQuiz(id);
        }

        /// <summary>
        /// Creează un nou quiz.
        /// </summary>
        public void OnCreateQuiz()
        {
            _model.CreateQuiz(_model.GetQuizzes().Count+1);
        }

        /// <summary>
        /// Obține username-ul utilizatorului curent autentificat.
        /// </summary>
        /// <returns></returns>
        public string GetCurrentUsername()
        {
            return _model.GetCurrentUsername();
        }
          
    }
}
