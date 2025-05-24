using ChestionarAuto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChestionarAuto
{
    public class Presenter : IPresenter
    {
        private IModel _model;
        private IView _view;
        private List<Question> _questions;
        private Quiz _currentQuiz;
        private int currentQuestionIndex = 0;
        private QuizViewModel _quizViewModel;
        private QuizScoreObserver _quizScoreObserver;

        public Presenter(IModel model, IView view)
        {
            _model = model;
            _view = view;

        }

        public void OnLogoutRequest()
        {
            _model.Logout();
            _view.LoadLoginControl();
        }

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

        public void OnAbortQuiz()
        {
            currentQuestionIndex = 0;
            _currentQuiz.quizState = "aborted";
            _view.ShowQuizResults(_currentQuiz);
        }

        public void GoToMainMenu()
        {
            _view.LoadUserDashboardControl(_model.GetLoggedUserRole());
        }

        //public void SaveInDatabase(); TODO -> fac eu mai tarziu
    }
}
