using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChestionarAuto
{
    /// <summary>
    /// Interfață pentru observatorul quiz-ului.
    /// </summary>
    public interface IQuizObserver
    {
        void OnAnswerValidated(bool isCorrect);
    }
}
