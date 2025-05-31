/**************************************************************************
 *                                                                        *
 *  File:        QuizScoreObserver.cs                                     *
 *  Copyright:   (c) 2025, Check & Drive                                  *
 *  E-mail:      checkandrive@chestionarauto.ro                           *
 *  Description:  Reprezintă un observator pentru chestionar care         *
 *               monitorizează scorul utilizatorului.                     *
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChestionarAuto
{
    /// <summary>
    /// Reprezintă un observator pentru chestionar care monitorizează scorul utilizatorului.
    /// </summary>
    public class QuizScoreObserver : IQuizObserver
    {
        private Quiz _quiz;
        private IView _view;

        /// <summary>
        /// Constructorul clasei QuizScoreObserver.
        /// </summary>
        /// <param name="quiz">Obiectul Quiz a cărui stare va fi actualizată în funcție de răspunsurile utilizatorului.</param>
        /// <param name="view">Interfața utilizator care va fi actualizată în funcție de scorul actual.</param>
        public QuizScoreObserver(Quiz quiz, IView view)
        {
            _quiz = quiz;
            _view = view;
        }

        /// <summary>
        /// Metoda care este apelată atunci când un răspuns este validat.
        /// </summary>
        /// <param name="isCorrect">Indică dacă răspunsul utilizatorului a fost corect (true) sau greșit (false).</param>
        public void OnAnswerValidated(bool isCorrect)
        {
            if (isCorrect)
                _quiz.correctAnswers++;
            else
                _quiz.wrongAnswers++;

            if (_quiz.wrongAnswers >= 5)
            {
                _quiz.quizState = "failed";
                _view.UpdateUI(_quiz.correctAnswers, _quiz.wrongAnswers);
                _view.FailQuiz();
            }
            else
            {
                int totalAnswered = _quiz.correctAnswers + _quiz.wrongAnswers;
                if (totalAnswered == _quiz.questionsList.Count)
                {
                    _quiz.quizState = "passed";
                    _view.UpdateUI(_quiz.correctAnswers, _quiz.wrongAnswers);
                    _view.PassQuiz();
                }
                else
                {
                    _quiz.quizState = "in progress";
                    _view.UpdateUI(_quiz.correctAnswers, _quiz.wrongAnswers);
                }
            }
        }
    }
}
