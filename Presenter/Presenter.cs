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
            _view.LoadLoginControl();
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
                _view.LoadLoginControl();
            }
        }

        /// <summary>
        /// Metoda care este apelată atunci când utilizatorul solicită înregistrarea unui nou cont.
        /// </summary>
        /// <param name="username">Numele de utilizator ales de către utilizator pentru autentificare.</param>
        /// <param name="name">Numele complet al utilizatorului.</param>
        /// <param name="email">Adresa de email a utilizatorului.</param>
        /// <param name="password">Parola aleasă de utilizator pentru contul său.</param>
        public void OnSignupRequest(string username, string name, string email, string password)
        {
            bool success = false;
            success = _model.AddUser(username, name, email, password);
            if (success)
            {
                _view.LoadLoginControl();
            }
            else
            {
                _view.LoadSignupControl();
            }
        }

        /// <summary>
        /// Metoda care este apelată atunci când utilizatorul solicită să înceapă un chestionar.
        /// </summary>
        public void OnStartQuiz()
        {
            _currentQuiz = _model.GetRandomQuiz();

            _quizViewModel = new QuizViewModel(_currentQuiz);
            _quizScoreObserver = new QuizScoreObserver(_currentQuiz, _view);
            _quizViewModel.RegisterObserver(_quizScoreObserver);

            _questions = _currentQuiz.questionsList;
            currentQuestionIndex = 0;
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
            currentQuestionIndex = 0;
            _currentQuiz.quizState = "aborted";
            _view.ShowQuizResults(_currentQuiz);
        }

        /// <summary>
        /// Metoda care este apelată pentru a naviga utilizatorul înapoi la meniul principal al aplicației.
        /// </summary>
        public void GoToMainMenu()
        {
            _view.LoadUserDashboardControl(_model.GetLoggedUserRole());
        }

        //public void SaveInDatabase(); TODO -> fac eu mai tarziu
    }
}
