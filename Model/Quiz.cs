using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChestionarAuto
{
    public class Quiz
    {
        public int Id { get; set; }
        public List<Question> questionsList { get; set; }
        public string quizState { get; set; }
        public int correctAnswers { get; set; }
        public int wrongAnswers { get; set; }

        public Quiz(int Id, List<Question> questionsList, int correctAnswers, int wrongAnswers, string quizState) {
            this.Id = Id;
            this.questionsList = questionsList;
            this.correctAnswers = correctAnswers;
            this.wrongAnswers = wrongAnswers;
            this.quizState = quizState;
        }
    }
}
