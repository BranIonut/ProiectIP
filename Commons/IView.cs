/**************************************************************************
 *                                                                        *
 *  File:        IView.cs                                                 *
 *  Copyright:   (c) 2025, Check & Drive                                  *
 *  E-mail:      checkandrive@chestionarauto.ro                           *
 *  Description: Interfață pentru vizualizarea aplicației.                *
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
