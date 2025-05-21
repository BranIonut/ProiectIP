using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChestionarAuto
{
    public interface IModel
    {
        void InitializeQuestions();
        void CreateQuiz(int n);
        void DeleteQuiz(int n);
        void QuizCancelled(int n, int correct, int incorrect);

        void QuizCompleted(int n, int correct, int incorrect);

        void QuizFailed(int n, int correct, int incorrect);
        bool Login(string username, string password);
        void Logout();
    }

}
