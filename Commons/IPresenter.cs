using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChestionarAuto
{
    public interface IPresenter
    {
        void OnAbortQuiz();
        void OnLoginRequest(string username, string password);
        void OnLogoutRequest();
        void OnNextQuestion(List<int> selectedAnswers);
        void OnPreviousQuestion();
        void OnSignupRequest(string username, string name, string email, string password);
        void OnStartQuiz();
    }
}
