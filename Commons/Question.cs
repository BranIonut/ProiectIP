using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ChestionarAuto
{
    /// <summary>
    /// Reprezintă o întrebare din chestionar.
    /// </summary>
    public class Question
    {
        public string question { get; set; }
        public List<string> answers { get; set; }
        public List<int> correctAnswers { get; set; }
        public string image { get; set; }
        public string difficulty { get; set; }

        static string exeFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        static string commonsFolder = Path.Combine(exeFolder, "..\\..\\..\\", "Commons");

        /// <summary>
        /// Constructor pentru inițializarea unui obiect de tip Question.
        /// </summary>
        /// <param name="question">Enunțul întrebării.</param>
        /// <param name="answers">Lista de variante.</param>
        /// <param name="correctAnswer">Răspunsul corect.</param>
        /// <param name="image">Path-ul către imaginea atașată întrebării.</param>
        /// <param name="difficulty">Dificultatea întrebării.</param>
        public Question(string question, List<string> answers, List<int> correctAnswer, string image, string difficulty)
        {
            this.question = question;
            this.answers = answers;
            this.correctAnswers = correctAnswer;
            this.image = Path.GetFullPath(Path.Combine(commonsFolder, image.Substring(1)));
            this.difficulty = difficulty;
        }
    }
}
