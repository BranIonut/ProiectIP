using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChestionarAuto
{
    /// <summary>
    /// Interfață pentru vizualizarea aplicației.
    /// </summary>
    public interface IView
    {
        void LoadLoginControl(bool err);
        void LoadSignupControl(bool err);
        void LoadUserDashboardControl(string role);
        void LoadAdminDashboardControl();
        void SetPresenter(IPresenter presenter);
        void ShowQuestion(Question question, bool isLastQuestion);
        void UpdateUI(int correctAnswers, int wrongAnswers);
        void ShowQuizResults(Quiz _quiz);
        void AbortQuiz();
        void FailQuiz();
        void PassQuiz();
    }
}
