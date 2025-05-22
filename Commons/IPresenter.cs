using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChestionarAuto
{
    public interface IPresenter
    {
        void OnLoginRequest(string username, string password);
        void OnSignupRequest(string username, string name, string email, string password);
    }
}
