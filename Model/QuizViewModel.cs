using System;
using System.Collections.Generic;

namespace ChestionarAuto
{
    public class QuizViewModel
    {
        private Quiz _quiz;
        private Dictionary<string, List<int>> _userAnswers = new Dictionary<string, List<int>>();

        private List<IQuizObserver> observers = new List<IQuizObserver>();

        public QuizViewModel(Quiz quiz)
        {
            _quiz = quiz;
        }

        public void RegisterObserver(IQuizObserver observer)
        {
            observers.Add(observer);
        }

        public void UnregisterObserver(IQuizObserver observer)
        {
            observers.Remove(observer);
        }

        private void NotifyObservers(bool isCorrect)
        {
            foreach (var observer in observers)
            {
                observer.OnAnswerValidated(isCorrect);
            }
        }

        public void AnswerQuestion(string questionText, List<int> selectedAnswers)
        {
            if (_userAnswers.ContainsKey(questionText))
                _userAnswers[questionText] = selectedAnswers;
            else
                _userAnswers.Add(questionText, selectedAnswers);

            Question question = null;
            for (int i = 0; i < _quiz.questionsList.Count; i++)
            {
                if (string.Equals(_quiz.questionsList[i].question, questionText, StringComparison.OrdinalIgnoreCase))
                {
                    question = _quiz.questionsList[i];
                    break;
                }
            }

            if (question != null)
            {
                bool isCorrect = AreListsEqualIgnoreOrder(selectedAnswers, question.correctAnswers);
                NotifyObservers(isCorrect);
            }
        }

        private bool AreListsEqualIgnoreOrder(List<int> list1, List<int> list2)
        {
            if (list1 == null || list2 == null)
                return false;

            if (list1.Count != list2.Count)
                return false;

            list1.Sort();
            list2.Sort();

            for (int i = 0; i < list1.Count; i++)
            {
                if (list1[i] != list2[i])
                    return false;
            }

            return true;
        }
    }
}
