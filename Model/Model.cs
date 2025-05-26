using Microsoft.SqlServer.Server;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Reflection;


namespace ChestionarAuto
{
    /// <summary>
    /// Reprezintă modelul de business logic pentru aplicația Chestionar Auto.
    /// Se ocupă de interacțiunea cu baza de date, întrebări, quizuri și utilizatori.
    /// </summary>
    public class Model : IModel
    {
        static string exeFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        static string commonsFolder = Path.Combine(exeFolder, "..\\..\\..\\", "Commons");
        string _questionsFileName = Path.GetFullPath(Path.Combine(commonsFolder, "questions.json"));
        string _databaseFileName = Path.GetFullPath(Path.Combine(commonsFolder, "application.db"));
        private User _currentUser;
        private List<Quiz> _quizzes;
        private List<Question> _questions;

        /// <summary>
        /// Constructorul clasei Model. Inițializează baza de date și încarcă întrebările.
        /// </summary>
        public Model()
        {
            _questions = new List<Question>();
            _quizzes = new List<Quiz>();
            InitializeDatabase();
            InitializeQuestions();
            for (int i = 1; i <= 10; i++)
            {
                CreateQuiz(i);
            }
        }

        /// <summary>
        /// Inițializează baza de date și creează tabelele necesare în baza de date dacă acestea nu există.
        /// </summary>
        private void InitializeDatabase()
        {
            var connection = new SQLiteConnection($"Data Source={_databaseFileName}");
            connection.Open();

            var command = connection.CreateCommand();

            command.CommandText = @"
                CREATE TABLE IF NOT EXISTS User (
                    id_user INTEGER PRIMARY KEY AUTOINCREMENT,
                    username TEXT NOT NULL UNIQUE,
                    email TEXT NOT NULL UNIQUE,
                    name TEXT NOT NULL,
                    password TEXT NOT NULL,
                    role TEXT NOT NULL DEFAULT 'user'
                );
            ";
            command.ExecuteNonQuery();

            command.CommandText = @"
                CREATE TABLE IF NOT EXISTS Quiz (
                    id_quiz INTEGER PRIMARY KEY AUTOINCREMENT
                );
            ";
            command.ExecuteNonQuery();

            command.CommandText = @"
                CREATE TABLE IF NOT EXISTS quiz_user (
                    id_user INTEGER NOT NULL,
                    id_quiz INTEGER NOT NULL,
                    correct_answers INTEGER NOT NULL,
                    incorrect_answers INTEGER NOT NULL,
                    quiz_state TEXT DEFAULT '',
                    PRIMARY KEY (id_user, id_quiz),
                    FOREIGN KEY (id_user) REFERENCES User(id_user),
                    FOREIGN KEY (id_quiz) REFERENCES Quiz(id_quiz)
                );
            ";
            command.ExecuteNonQuery();
        }

        /// <summary>
        /// Încarcă întrebările din fișierul JSON într-o listă de obiecte Question.
        /// </summary>
        public void InitializeQuestions()
        {
            try
            {
                string jsonContent = File.ReadAllText(_questionsFileName);
                _questions = JsonConvert.DeserializeObject<List<Question>>(jsonContent);

                foreach (Question question in _questions)
                {
                    Console.WriteLine($"Întrebare: {question.question}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroare la parsarea întrebărilor: " + ex.Message);
            }
        }

        /// <summary>
        /// Creează un quiz nou cu 25 de întrebări aleatorii și îl inserează în baza de date.
        /// </summary>
        /// <param name="n">Numărul de quizuri de creat (folosit doar în bucla constructorului).</param>
        public void CreateQuiz(int n)
        {
            Random random = new Random();
            List<Question> questionList = _questions.OrderBy(q => random.Next()).Take(25).ToList();

            var connection = new SQLiteConnection($"Data Source={_databaseFileName}");
            connection.Open();

            var command = connection.CreateCommand();

            command.CommandText = "INSERT INTO Quiz DEFAULT VALUES;";

            command.ExecuteNonQuery();

            command.CommandText = "SELECT last_insert_rowid();";

            long quizId = (long)command.ExecuteScalar();

            _quizzes.Add(new Quiz((int)quizId, questionList, 0, 0, "in progress"));


        }

        /// <summary>
        /// Șterge un quiz existent din baza de date și din lista de quiz-uri.
        /// </summary>
        /// <param name="n">Indexul quiz-ului ce va fi șters din listă.</param>
        /// <exception cref="Exception"></exception>
        public void DeleteQuiz(int n)
        {
            if (n < 0 || n >= _quizzes.Count)
            {
                throw new Exception("Cannot delete nonexistent quiz.");
            }

            int quizId = _quizzes[n].Id;

            using (var connection = new SQLiteConnection($"Data Source={_databaseFileName}"))
            {
                connection.Open();

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "DELETE FROM Quiz WHERE id_quiz = $quizId;";
                    command.Parameters.AddWithValue("$quizId", quizId);

                    command.ExecuteNonQuery();
                }
            }
            _quizzes.RemoveAt(n);

        }

        /// <summary>
        /// Actualizează starea unui quiz asociat unui utilizator (completat, anulat, eșuat).
        /// </summary>
        /// <param name="n">Indicele quiz-ului din lista de quiz-uri.</param>
        /// <param name="state">Starea quiz-ului ce va fi actualizată.</param>
        /// <param name="correct">Numărul de răspunsuri corecte.</param>
        /// <param name="incorrect">Numărul de răspunsuri greșite.</param>
        private void UpdateQuizUserState(int n, string state, int correct, int incorrect)
        {
            var connection = new SQLiteConnection($"Data Source={_databaseFileName}");
            connection.Open();

            var command = connection.CreateCommand();

            command.CommandText = @"
                UPDATE quiz_user 
                SET quiz_state = $state, correct_answers = $correct, incorrect_answers = $incorrect
                WHERE id_user = $userId AND id_quiz = $quizId;
            ";
            command.Parameters.AddWithValue("$userId", _currentUser.userId);
            command.Parameters.AddWithValue("$quizId", _quizzes[n].Id);
            command.Parameters.AddWithValue("$state", state);
            command.Parameters.AddWithValue("$correct", correct);
            command.Parameters.AddWithValue("$incorrect", incorrect);

            int rowsAffected = command.ExecuteNonQuery();

            if (rowsAffected == 0)
            {
                command.CommandText = @"
                    INSERT INTO quiz_user (id_user, id_quiz, correct_answers, incorrect_answers, quiz_state)
                    VALUES ($userId, $quizId, $correct, $incorrect, $state);
                ";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("$userId", _currentUser.userId);
                command.Parameters.AddWithValue("$quizId", _quizzes[n].Id);
                command.Parameters.AddWithValue("$correct", correct);
                command.Parameters.AddWithValue("$incorrect", incorrect);
                command.Parameters.AddWithValue("$state", state);

                command.ExecuteNonQuery();
            }

            _quizzes[n].quizState = state;
            _quizzes[n].correctAnswers = correct;
            _quizzes[n].wrongAnswers = incorrect;
        }

        /// <summary>
        /// Marchează un quiz ca anulat.
        /// </summary>
        public void QuizCancelled(int n, int correct, int incorrect)
            => UpdateQuizUserState(n, "cancelled", correct, incorrect);

        /// <summary>
        /// Marchează un quiz ca completat cu succes.
        /// </summary>
        public void QuizCompleted(int n, int correct, int incorrect)
            => UpdateQuizUserState(n, "completed", correct, incorrect);

        /// <summary>
        /// Marchează un quiz ca eșuat.
        /// </summary>
        public void QuizFailed(int n, int correct, int incorrect)
            => UpdateQuizUserState(n, "failed", correct, incorrect);

        /// <summary>
        /// Adaugă un utilizator nou în baza de date.
        /// </summary>
        /// <param name="username">Numele de utilizator folosit pentru identificare.</param>
        /// <param name="name">Numele și prenumele utilizatorului</param>
        /// <param name="email">Email-ul utilizatorului.</param>
        /// <param name="password">Parola utilizatorului.</param>
        /// <returns>True dacă utilizatorul a fost adăugat cu succes, sau false în caz contrar.</returns>
        public bool AddUser(string username, string name, string email, string password)
        {
            var connection = new SQLiteConnection($"Data Source={_databaseFileName}");
            connection.Open();

            Console.WriteLine(username + "\n" + name + "\n" + email + "\n" + password);

            var command = connection.CreateCommand();

            command.CommandText = @"
                INSERT INTO User (username, name, email, password, role)
                VALUES ($username, $name, $email, $password, 'user');
            ";

            command.Parameters.AddWithValue("$username", username);
            command.Parameters.AddWithValue("$name", name);
            command.Parameters.AddWithValue("$email", email);
            command.Parameters.AddWithValue("$password", password);

            try
            {
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (Exception e)
            {
                return false;
            }


        }

        /// <summary>
        /// Autentifică un utilizator în aplicație pe baza numelui de utilizator și a parolei.
        /// </summary>
        /// <param name="username">Numele de utilizator introdus de utilizator.</param>
        /// <param name="password">Parola introdusă de utilizator.</param>
        /// <returns>True dacă utilizatorul a fost logat cu succes, sau false în caz contrar.</returns>
        public bool Login(string username, string password)
        {
            var connection = new SQLiteConnection($"Data Source={_databaseFileName}");
            connection.Open();

            var command = connection.CreateCommand();

            command.CommandText = @"
                SELECT id_user, username, name, email, password, role
                FROM User
                WHERE username = $username AND password = $password;
            ";

            command.Parameters.AddWithValue("$username", username);
            command.Parameters.AddWithValue("$password", password);

            var reader = command.ExecuteReader();

            if (reader.Read())
            {
                _currentUser = new User(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3),
                    reader.GetString(4),
                    reader.GetString(5)
                );
                return true;
            }
            return false;
        }

        /// <summary>
        /// Deconectează utilizatorul curent din aplicație.
        /// </summary>
        public void Logout()
        {
            _currentUser = null;
        }

        /// <summary>
        /// Obține rolul utilizatorului curent conectat.
        /// </summary>
        /// <returns></returns>
        public string GetLoggedUserRole()
        {
            return _currentUser.Role;
        }

        /// <summary>
        /// Obține un quiz aleatoriu din lista de quiz-uri disponibile.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public Quiz GetRandomQuiz()
        {
            if (_quizzes == null || _quizzes.Count == 0)
                throw new InvalidOperationException("No quiz available :(");

            Random rnd = new Random();
            int index = rnd.Next(_quizzes.Count);
            return _quizzes[index];
        }

        /// <summary>
        /// Adaugă un quiz asociat unui utilizator în baza de date.
        /// </summary>
        /// <param name="quizId">ID-ul quiz-ului care a fost completat.</param>
        /// <param name="userId">ID-ul utilizatorului care a completat quiz-ul.</param>
        /// <param name="correctAns">Numărul de răspunsuri corecte.</param>
        /// <param name="wrongAns">Numărul de răspunsuri greșite.</param>
        /// <param name="quizState">Starea finală a quiz-ului (ex: completed, aborted, failed).</param>
        /// <returns>True dacă inserarea a avut succes, altfel false.</returns>
        public bool AddToUserQuiz(int quizId, int userId, int correctAns, int wrongAns, string quizState)
        {
            var connection = new SQLiteConnection($"Data Source={_databaseFileName}");
            connection.Open();

            var command = connection.CreateCommand();

            command.CommandText = @"
        INSERT INTO quiz_user (id_user, id_quiz, correct_answers, incorrect_answers, quiz_state)
        VALUES ($userId, $quizId, $correctAns, $wrongAns, $quizState);
    ";

            command.Parameters.AddWithValue("$userId", userId);
            command.Parameters.AddWithValue("$quizId", quizId);
            command.Parameters.AddWithValue("$correctAns", correctAns);
            command.Parameters.AddWithValue("$wrongAns", wrongAns);
            command.Parameters.AddWithValue("$quizState", quizState);
            try
            {
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}