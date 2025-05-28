using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChestionarAuto
{
    /// <summary>
    /// Reprezintă un chestionar care conține o listă de întrebări și starea acestuia.
    /// </summary>
    public class Quiz
    {
        public int Id { get; set; }
        public List<Question> questionsList { get; set; }
        public string quizState { get; set; }
        public int correctAnswers { get; set; }
        public int wrongAnswers { get; set; }

        /// <summary>
        /// Constructor pentru inițializarea unui obiect de tip Quiz
        /// </summary>
        /// <param name="Id">ID-ul quiz-ului</param>
        /// <param name="questionsList">Lista de întrebări, obiecte de tip Quiz.</param>
        /// <param name="correctAnswers">Numărul de întrebări la care s-a răspuns corect.</param>
        /// <param name="wrongAnswers">Numărul de întrebări la care s-a răspuns greșit.</param>
        /// <param name="quizState">Stadiul în care se află quiz-ul (aborted/completed/failed).</param>
        public Quiz(int Id, List<Question> questionsList, int correctAnswers, int wrongAnswers, string quizState) {
            this.Id = Id;
            this.questionsList = questionsList;
            this.correctAnswers = correctAnswers;
            this.wrongAnswers = wrongAnswers;
            this.quizState = quizState;
        }
    }
}
