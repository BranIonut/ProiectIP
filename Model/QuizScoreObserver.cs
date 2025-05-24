using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChestionarAuto
{
    public class QuizScoreObserver : IQuizObserver
    {
        private Quiz _quiz;
        private IView _view;

        public QuizScoreObserver(Quiz quiz, IView view)
        {
            _quiz = quiz;
            _view = view;
        }

        public void OnAnswerValidated(bool isCorrect)
        {
            if (isCorrect)
                _quiz.correctAnswers++;
            else
                _quiz.wrongAnswers++;

            int totalAnswered = _quiz.correctAnswers + _quiz.wrongAnswers;
            if (totalAnswered == _quiz.questionsList.Count)
                _quiz.quizState = "completed";
            else
            {
                _quiz.quizState = "in progress";
                _view.UpdateUI(_quiz.correctAnswers, _quiz.wrongAnswers);
            }
        }
    }
}
