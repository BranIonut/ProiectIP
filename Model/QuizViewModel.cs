using System;
using System.Collections.Generic;

namespace ChestionarAuto
{
    /// <summary>
    /// Reprezintă modelul de vizualizare pentru chestionar, care gestionează logica de răspuns la întrebări și notificarea observatorilor.
    /// </summary>
    public class QuizViewModel
    {
        private Quiz _quiz;
        private Dictionary<string, List<int>> _userAnswers = new Dictionary<string, List<int>>();

        private List<IQuizObserver> observers = new List<IQuizObserver>();

        /// <summary>
        /// Constructorul clasei QuizViewModel.
        /// </summary>
        /// <param name="quiz">Obiectul Quiz care conține întrebările și starea chestionarului.</param>
        public QuizViewModel(Quiz quiz)
        {
            _quiz = quiz;
        }

        /// <summary>
        /// Înregistrează un observator pentru a primi notificări despre validarea răspunsurilor.
        /// </summary>
        /// <param name="observer">Observatorul care va fi notificat la fiecare răspuns validat.</param>
        public void RegisterObserver(IQuizObserver observer)
        {
            observers.Add(observer);
        }

        /// <summary>
        /// Dezabonează un observator pentru a nu mai primi notificări despre validarea răspunsurilor.
        /// </summary>
        /// <param name="observer">Observatorul care va fi eliminat din lista de notificare.</param>
        public void UnregisterObserver(IQuizObserver observer)
        {
            observers.Remove(observer);
        }

        /// <summary>
        /// Notifică toți observatorii despre validarea răspunsului.
        /// </summary>
        /// <param name="isCorrect">Valoare booleană care indică dacă răspunsul utilizatorului a fost corect.</param>
        private void NotifyObservers(bool isCorrect)
        {
            foreach (var observer in observers)
            {
                observer.OnAnswerValidated(isCorrect);
            }
        }

        /// <summary>
        /// Răspunde la o întrebare a chestionarului cu răspunsurile selectate de utilizator.
        /// </summary>
        /// <param name="questionText">Textul întrebării la care utilizatorul a răspuns.</param>
        /// <param name="selectedAnswers">Lista de indecși ai răspunsurilor selectate de utilizator.</param>
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

        /// <summary>
        /// Verifică dacă două liste de răspunsuri sunt egale, ignorând ordinea elementelor.
        /// </summary>
        /// <param name="list1">Prima listă de răspunsuri.</param>
        /// <param name="list2">A doua listă de răspunsuri.</param>
        /// <returns>True dacă listele sunt egale ca elemente, indiferent de ordine; altfel, false.</returns>
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
