using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChestionarAuto
{
    public interface IView
    {
        void LoadLoginControl();
        void LoadSignupControl();
        void LoadUserDashboardControl(string role);
        void LoadAdminDashboardControl();
    }
}
