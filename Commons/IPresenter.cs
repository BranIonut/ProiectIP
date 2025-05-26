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
        void OnSignupRequest(string username, string name, string email, string password);
        void OnStartQuiz();
        void GoToMainMenu();
        void OnFailQuiz();
        void OnPassQuiz();
        List<Quiz> OnLoadUserHistory();

    }
}
