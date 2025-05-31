/**************************************************************************
 *                                                                        *
 *  File:        IModel.cs                                                *
 *  Copyright:   (c) 2025, Check & Drive                                  *
 *  E-mail:      checkandrive@chestionarauto.ro                           *
 *  Description: Interfață pentru modelul aplicației.                     *
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
    /// Interfață pentru modelul aplicației.
    /// </summary>
    public interface IModel
    {
        void InitializeQuestions();
        void CreateQuiz(int n);
        bool DeleteQuiz(int n);
        void QuizCancelled(int n, int correct, int incorrect);

        void QuizCompleted(int n, int correct, int incorrect);

        void QuizFailed(int n, int correct, int incorrect);
        bool Login(string username, string password);
        bool AddUser(string username, string name, string email, string password);
        void Logout();
        string GetLoggedUserRole();
        Quiz GetRandomQuiz();
        bool AddToUserQuiz(int quizId, int userId, int correctAns, int wrongAns, string quizState);
        int GetCurrentUserId();
        string GetCurrentUsername();
        List<Quiz> GetLastTenQuizes(int userId);
        Dictionary<string, string> GetUsers();
        List<string> GetQuizzes();
        bool UserResetProgress(string username);
        bool RemoveUser(string username);
        bool ChangeUserRole(string username, string role);

        bool isCurrentUser(string username);
    }
}
