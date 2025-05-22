using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChestionarAuto
{
    public class Question
    {
        public string question { get; set; }
        public List<string> answers { get; set; }
        public List<string> correctAnswers { get; set; }
        public string image { get; set; }
        public string difficulty { get; set; }

        public Question(string question, List<string> answers, List<string> correctAnswer, string image, string difficulty)
        {
            this.question = question;
            this.answers = answers;
            this.correctAnswers = correctAnswer;
            this.image = image;
            this.difficulty = difficulty;
        }
    }
}
