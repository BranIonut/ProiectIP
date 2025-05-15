using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons
{
    internal class Question
    {
        protected string question;
        protected List<string> answers;
        protected string correctAnswer;
        protected int difficulty;

        public Question(string question, List<string> answers, string correctAnswer, int difficulty)
        {
            this.question = question;
            this.answers = answers;
            this.correctAnswer = correctAnswer;
            this.difficulty = difficulty;
        }
    }
}
