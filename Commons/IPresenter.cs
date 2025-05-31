/**************************************************************************
 *                                                                        *
 *  File:        IPresenter.cs                                            *
 *  Copyright:   (c) 2025, Check & Drive                                  *
 *  E-mail:      checkandrive@chestionarauto.ro                           *
 *  Description: Interfață pentru presenter-ul aplicației.                *
 *                                                                        *
 *  Această aplicație a fost realizată de patru studenți ai Facultății de *
 *  Automatică și Calculatoare, în cadrul materiei Ingineria Programării. *
 *  Este oferită ca software liber, conform licenței GNU GPL.             *
 *  Poate fi redistribuită și/sau modificată, dar fără nicio garanție,    *
 *  nici măcar pentru adecvarea la un scop anume.                         *
 *                                                                        *
 **************************************************************************/
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChestionarAuto
{
    /// <summary>
    /// Interfață pentru presenter-ul aplicației.
    /// </summary>
    public interface IPresenter
    {
        void OnAbortQuiz();
        void OnLoginRequest(string username, string password);
        void OnLogoutRequest();
        void OnNextQuestion(List<int> selectedAnswers);
        bool OnSignupRequest(string username, string name, string email, string password);
        void OnStartQuiz();
        void GoToMainMenu();
        void OnFailQuiz();
        void OnPassQuiz();
        List<Quiz> OnLoadUserHistory();
        Dictionary<string, string> GetUsers();
        List<string> GetQuizzes();
        bool OnRemoveUser(string username);
        bool OnDeleteUserProgress(string username);
        bool OnChangeUserRole(string username, string role);
        bool OnRemoveQuiz(int id);
        void OnCreateQuiz();
        string GetCurrentUsername();
        bool OnChangeOwnRole(string username, string role);
    }
}
