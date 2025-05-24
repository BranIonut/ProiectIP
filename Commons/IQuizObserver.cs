using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChestionarAuto
{
    public interface IQuizObserver
    {
        void OnAnswerValidated(bool isCorrect);
    }
}
