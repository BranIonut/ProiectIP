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
        public string correctAnswer { get; set; }

        public Question(string question, List<string> answers, string correctAnswer) {
            this.question = question;
            this.answers = answers;
            this.correctAnswer = correctAnswer;

        }
    }
}
